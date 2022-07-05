using Microsoft.Extensions.DependencyInjection;
using POC.API.Lib;
using POC.API.Lib.Controllers;
using POC.API.Lib.Model;
using POC.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private static PaymentController? paymentController = null;
        private const string pattern = "yy-MM-dd";
        private List<Payment> payments;

        public Form1(ServiceCollection services)
        {
            Startup startup = new Startup(services, "DataSource=Payments.db;mode=ReadWriteCreate;cache=shared");
            startup.ConfigureServices();

            InitializeComponent();

            InitializePaymentController();
            InitializeForms();
            InitializePayments();
        }

        public Form1()
        {
            InitializeComponent();

            InitializePaymentController();
            InitializeForms();
            InitializePayments();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            var warningText = string.Empty;

            var name = NameTextbox.Text;
            var frequency = (Frequency)FrequencyDropdown.SelectedIndex;
            var contactMethod = (ContactMethods)ContactDropdown.SelectedIndex;
            var comment = CommentTextbox.Text;

            var dateNextPayment = DatePicker.Value;
            dateNextPayment = DateTime.Parse(dateNextPayment.ToString(pattern));
            var dateNow = DateTime.Parse(DateTime.Now.ToString(pattern));
            if (dateNextPayment < dateNow)
            {
                warningText += "Next payment date can't be before today \n";
            }
            if (!double.TryParse(AmountTextbox.Text, out double amount) || amount < 0)
            {
                warningText += "The amount must be decimal";
            }

            if(string.IsNullOrEmpty(warningText))
            {
                paymentController.Post(new Payment(name, new Date(dateNextPayment, frequency), amount, contactMethod, new Comment(comment)));
                InitializePayments();
            }

            ErrorsForm.Text = warningText;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            AssignValueToForm(string.Empty, DateTime.Now, 0, string.Empty);
        }

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void InitializePaymentController()
        {
            if(paymentController == null)
            {
                paymentController = new PaymentController();
            }
        }

        private void AssignValueToForm(string name, DateTime date, double amount, string comment, ContactMethods method = ContactMethods.Online, Frequency frequency = Frequency.Weekly)
        {
            NameTextbox.Text = name;
            CommentTextbox.Text = comment;
            AmountTextbox.Text = amount.ToString();
            DatePicker.Value = date;
            FrequencyDropdown.SelectedItem = frequency;
            ContactDropdown.SelectedItem = method;
        }

        private void InitializeForms()
        {
            var dtFrequency = new DataTable();
            dtFrequency.Columns.Add("value");
            foreach(Frequency frequency in Enum.GetValues(typeof(Frequency)))
            {
                dtFrequency.Rows.Add(frequency);
            }
            FrequencyDropdown.DataSource = dtFrequency;
            FrequencyDropdown.DisplayMember = "value";
            FrequencyDropdown.ValueMember = "value";

            var dtMethods = new DataTable();
            dtMethods.Columns.Add("value");
            foreach (ContactMethods method in Enum.GetValues(typeof(ContactMethods)))
            {
                dtMethods.Rows.Add(method);
            }
            ContactDropdown.DataSource = dtMethods;
            ContactDropdown.DisplayMember = "value";
            ContactDropdown.ValueMember = "value";
        }

        private async Task InitializePayments()
        {
            payments = await paymentController.Get();
            //var payments = new List<Payment> { new Payment("Test", new Date(DateTime.Now, Frequency.Weekly), 10, ContactMethods.Online, new Comment("This is a test")),
            //new Payment("Test 2", new Date(DateTime.Now, Frequency.Weekly), 10, ContactMethods.Online, new Comment("This is a test"))};
            PaymentTree.BeginUpdate();

            PaymentTree.Nodes.Clear();
            foreach(var payment in payments)
            {
                PaymentTree.Nodes.Add(new TreeNode(payment.Name));
                PaymentTree.Nodes[payments.IndexOf(payment)].Nodes.AddRange( new []
                    {
                        new TreeNode($"Next payment date : {payment.Date.NextPaymentDate.ToString(pattern)}"),
                        new TreeNode($"Payment Frequency : {payment.Date.PaymentFrequency}"),
                        new TreeNode($"Amount : {payment.Amount}"),
                        new TreeNode($"Contact Method : {payment.ContactMethod}"),
                        new TreeNode($"Details : {payment.Comment.Text}")
                    }
                );
            }
            PaymentTree.EndUpdate();
            PaymentTree.ExpandAll();
            PaymentTree.SelectedNode = null;

        }

        protected void PaymentSelectInTree_NodeClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Determine by checking the Text property.
            if (e.Node.Parent == null)
            {
                var payment = payments.Find(x => x.Name == e.Node.Text);

                AssignValueToForm(payment.Name, payment.Date.NextPaymentDate, payment.Amount, payment.Comment.Text, payment.ContactMethod, payment.Date.PaymentFrequency);
            }
        }

        private void CollapseBtn_Click(object sender, EventArgs e)
        {
            PaymentTree.CollapseAll();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                if(string.IsNullOrEmpty(NameTextbox.Text))
                {
                    ErrorsForm.Text = "Select a payment to delete first";
                }
                else
                {
                    var result = paymentController.Delete(NameTextbox.Text);
                    if(result.Result == 0)
                    {
                        MessageBox.Show($"Payment information for {NameTextbox.Text} are deleted");
                    }
                    InitializePayments();
                }
            }
        }

        private void ExpandBtn_Click(object sender, EventArgs e)
        {
            PaymentTree.ExpandAll();
        }
    }
}
