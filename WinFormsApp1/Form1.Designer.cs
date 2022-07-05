namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FrequencyDropdown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ContactDropdown = new System.Windows.Forms.ComboBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.AmountTextbox = new System.Windows.Forms.TextBox();
            this.CommentTextbox = new System.Windows.Forms.TextBox();
            this.PaymentTree = new System.Windows.Forms.TreeView();
            this.ErrorsForm = new System.Windows.Forms.Label();
            this.CollapseBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ExpandBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmBtn.Location = new System.Drawing.Point(63, 303);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBtn.TabIndex = 2;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.07954F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.92046F));
            this.tableLayoutPanel1.Controls.Add(this.FrequencyDropdown, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DatePicker, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ConfirmBtn, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ClearBtn, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ContactDropdown, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.NameTextbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AmountTextbox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CommentTextbox, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(622, 367);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(392, 343);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // FrequencyDropdown
            // 
            this.FrequencyDropdown.FormattingEnabled = true;
            this.FrequencyDropdown.Location = new System.Drawing.Point(144, 64);
            this.FrequencyDropdown.Name = "FrequencyDropdown";
            this.FrequencyDropdown.Size = new System.Drawing.Size(121, 23);
            this.FrequencyDropdown.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "Frequency :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date Next Payment :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DatePicker
            // 
            this.DatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DatePicker.Location = new System.Drawing.Point(144, 33);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 23);
            this.DatePicker.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 143);
            this.label6.TabIndex = 5;
            this.label6.Text = "Comment :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(144, 303);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 7;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "Contact Method :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ContactDropdown
            // 
            this.ContactDropdown.FormattingEnabled = true;
            this.ContactDropdown.Location = new System.Drawing.Point(144, 129);
            this.ContactDropdown.Name = "ContactDropdown";
            this.ContactDropdown.Size = new System.Drawing.Size(121, 23);
            this.ContactDropdown.TabIndex = 9;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(144, 3);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(245, 23);
            this.NameTextbox.TabIndex = 10;
            // 
            // AmountTextbox
            // 
            this.AmountTextbox.Location = new System.Drawing.Point(144, 97);
            this.AmountTextbox.Name = "AmountTextbox";
            this.AmountTextbox.Size = new System.Drawing.Size(245, 23);
            this.AmountTextbox.TabIndex = 11;
            // 
            // CommentTextbox
            // 
            this.CommentTextbox.Location = new System.Drawing.Point(144, 160);
            this.CommentTextbox.Multiline = true;
            this.CommentTextbox.Name = "CommentTextbox";
            this.CommentTextbox.Size = new System.Drawing.Size(245, 137);
            this.CommentTextbox.TabIndex = 12;
            // 
            // PaymentTree
            // 
            this.PaymentTree.Location = new System.Drawing.Point(24, 54);
            this.PaymentTree.Name = "PaymentTree";
            this.PaymentTree.Size = new System.Drawing.Size(547, 656);
            this.PaymentTree.TabIndex = 0;
            this.PaymentTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.PaymentSelectInTree_NodeClick);
            // 
            // ErrorsForm
            // 
            this.ErrorsForm.AutoSize = true;
            this.ErrorsForm.Location = new System.Drawing.Point(622, 330);
            this.ErrorsForm.Name = "ErrorsForm";
            this.ErrorsForm.Size = new System.Drawing.Size(0, 15);
            this.ErrorsForm.TabIndex = 7;
            // 
            // CollapseBtn
            // 
            this.CollapseBtn.Location = new System.Drawing.Point(548, 25);
            this.CollapseBtn.Name = "CollapseBtn";
            this.CollapseBtn.Size = new System.Drawing.Size(23, 23);
            this.CollapseBtn.TabIndex = 8;
            this.CollapseBtn.Text = "-";
            this.CollapseBtn.UseVisualStyleBackColor = true;
            this.CollapseBtn.Click += new System.EventHandler(this.CollapseBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(766, 717);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 9;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ExpandBtn
            // 
            this.ExpandBtn.Location = new System.Drawing.Point(519, 25);
            this.ExpandBtn.Name = "ExpandBtn";
            this.ExpandBtn.Size = new System.Drawing.Size(23, 23);
            this.ExpandBtn.TabIndex = 10;
            this.ExpandBtn.Text = "+";
            this.ExpandBtn.UseVisualStyleBackColor = true;
            this.ExpandBtn.Click += new System.EventHandler(this.ExpandBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 774);
            this.Controls.Add(this.ExpandBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CollapseBtn);
            this.Controls.Add(this.ErrorsForm);
            this.Controls.Add(this.PaymentTree);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Payments Tracker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Edit_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FrequencyDropdown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ContactDropdown;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox AmountTextbox;
        private System.Windows.Forms.TextBox CommentTextbox;
        private System.Windows.Forms.TreeView PaymentTree;
        private System.Windows.Forms.Label ErrorsForm;
        private System.Windows.Forms.Button CollapseBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ExpandBtn;
    }
}
