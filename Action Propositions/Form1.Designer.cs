namespace Action_Propositions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flowLayoutPanel1 = new FlowLayoutPanel();
            Account = new GroupBox();
            txtUsername = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            panel1 = new Panel();
            label12 = new Label();
            numDiscountPrice = new NumericUpDown();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            BtnDelete = new Button();
            nudQuantity = new NumericUpDown();
            BtnReg = new Button();
            nudDiscount = new NumericUpDown();
            label1 = new Label();
            tbImagePath = new TextBox();
            tbText = new TextBox();
            tbLocation = new TextBox();
            tbCompanyName = new TextBox();
            tbShareName = new TextBox();
            label9 = new Label();
            label11 = new Label();
            label10 = new Label();
            label3 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label13 = new Label();
            citycomboBox = new ComboBox();
            button1 = new Button();
            Account.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDiscountPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(14, 61);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(660, 688);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // Account
            // 
            Account.BackColor = Color.White;
            Account.BackgroundImageLayout = ImageLayout.None;
            Account.Controls.Add(txtUsername);
            Account.Controls.Add(btnLogin);
            Account.Controls.Add(btnRegister);
            Account.Location = new Point(685, 3);
            Account.Name = "Account";
            Account.Size = new Size(267, 146);
            Account.TabIndex = 4;
            Account.TabStop = false;
            Account.Text = "Акаунт";
            // 
            // txtUsername
            // 
            txtUsername.AutoSize = true;
            txtUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.FromArgb(204, 102, 0);
            txtUsername.Location = new Point(23, 21);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(215, 25);
            txtUsername.TabIndex = 2;
            txtUsername.Text = "User not authenticated";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.FromArgb(204, 102, 0);
            btnLogin.Location = new Point(22, 49);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(216, 35);
            btnLogin.TabIndex = 26;
            btnLogin.Text = "Увійти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.White;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.FromArgb(204, 102, 0);
            btnRegister.Location = new Point(22, 90);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(216, 35);
            btnRegister.TabIndex = 26;
            btnRegister.Text = "Зареєструватися";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label12);
            panel1.Controls.Add(numDiscountPrice);
            panel1.Controls.Add(dtpEndDate);
            panel1.Controls.Add(dtpStartDate);
            panel1.Controls.Add(BtnDelete);
            panel1.Controls.Add(nudQuantity);
            panel1.Controls.Add(BtnReg);
            panel1.Controls.Add(nudDiscount);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbImagePath);
            panel1.Controls.Add(tbText);
            panel1.Controls.Add(tbLocation);
            panel1.Controls.Add(tbCompanyName);
            panel1.Controls.Add(tbShareName);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(685, 155);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 594);
            panel1.TabIndex = 5;
            panel1.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 206);
            label12.Name = "label12";
            label12.Size = new Size(40, 17);
            label12.TabIndex = 29;
            label12.Text = "Ціна";
            // 
            // numDiscountPrice
            // 
            numDiscountPrice.DecimalPlaces = 2;
            numDiscountPrice.Location = new Point(115, 198);
            numDiscountPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numDiscountPrice.Name = "numDiscountPrice";
            numDiscountPrice.Size = new Size(136, 25);
            numDiscountPrice.TabIndex = 28;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(115, 318);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(136, 25);
            dtpEndDate.TabIndex = 26;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(115, 271);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(136, 25);
            dtpStartDate.TabIndex = 26;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.White;
            BtnDelete.Cursor = Cursors.Hand;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.ForeColor = Color.FromArgb(204, 102, 0);
            BtnDelete.Location = new Point(12, 552);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(239, 30);
            BtnDelete.TabIndex = 26;
            BtnDelete.Text = "Видалити";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(115, 237);
            nudQuantity.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(136, 25);
            nudQuantity.TabIndex = 25;
            // 
            // BtnReg
            // 
            BtnReg.BackColor = Color.FromArgb(204, 102, 0);
            BtnReg.Cursor = Cursors.Hand;
            BtnReg.FlatAppearance.BorderSize = 0;
            BtnReg.FlatStyle = FlatStyle.Flat;
            BtnReg.ForeColor = Color.White;
            BtnReg.Location = new Point(12, 516);
            BtnReg.Name = "BtnReg";
            BtnReg.Size = new Size(239, 30);
            BtnReg.TabIndex = 27;
            BtnReg.Text = "Додати";
            BtnReg.UseVisualStyleBackColor = false;
            BtnReg.Click += BtnPost_Click;
            // 
            // nudDiscount
            // 
            nudDiscount.DecimalPlaces = 2;
            nudDiscount.Location = new Point(115, 164);
            nudDiscount.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudDiscount.Name = "nudDiscount";
            nudDiscount.Size = new Size(136, 25);
            nudDiscount.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(204, 102, 0);
            label1.Location = new Point(7, 9);
            label1.Name = "label1";
            label1.Size = new Size(260, 25);
            label1.TabIndex = 4;
            label1.Text = "Управління пропозиціями";
            // 
            // tbImagePath
            // 
            tbImagePath.BackColor = Color.FromArgb(230, 231, 233);
            tbImagePath.BorderStyle = BorderStyle.None;
            tbImagePath.Cursor = Cursors.Hand;
            tbImagePath.Font = new Font("Nirmala UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            tbImagePath.Location = new Point(12, 380);
            tbImagePath.Multiline = true;
            tbImagePath.Name = "tbImagePath";
            tbImagePath.ReadOnly = true;
            tbImagePath.Size = new Size(239, 28);
            tbImagePath.TabIndex = 21;
            tbImagePath.Click += textBox3_Click;
            // 
            // tbText
            // 
            tbText.BackColor = Color.FromArgb(230, 231, 233);
            tbText.BorderStyle = BorderStyle.None;
            tbText.Font = new Font("Nirmala UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            tbText.Location = new Point(12, 482);
            tbText.Multiline = true;
            tbText.Name = "tbText";
            tbText.Size = new Size(239, 28);
            tbText.TabIndex = 21;
            // 
            // tbLocation
            // 
            tbLocation.BackColor = Color.FromArgb(230, 231, 233);
            tbLocation.BorderStyle = BorderStyle.None;
            tbLocation.Font = new Font("Nirmala UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            tbLocation.Location = new Point(12, 431);
            tbLocation.Multiline = true;
            tbLocation.Name = "tbLocation";
            tbLocation.Size = new Size(239, 28);
            tbLocation.TabIndex = 21;
            // 
            // tbCompanyName
            // 
            tbCompanyName.BackColor = Color.FromArgb(230, 231, 233);
            tbCompanyName.BorderStyle = BorderStyle.None;
            tbCompanyName.Font = new Font("Nirmala UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            tbCompanyName.Location = new Point(12, 125);
            tbCompanyName.Multiline = true;
            tbCompanyName.Name = "tbCompanyName";
            tbCompanyName.Size = new Size(239, 28);
            tbCompanyName.TabIndex = 21;
            // 
            // tbShareName
            // 
            tbShareName.BackColor = Color.FromArgb(230, 231, 233);
            tbShareName.BorderStyle = BorderStyle.None;
            tbShareName.Font = new Font("Nirmala UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            tbShareName.Location = new Point(12, 70);
            tbShareName.Multiline = true;
            tbShareName.Name = "tbShareName";
            tbShareName.Size = new Size(239, 28);
            tbShareName.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 360);
            label9.Name = "label9";
            label9.Size = new Size(99, 17);
            label9.TabIndex = 24;
            label9.Text = "Зображення";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 462);
            label11.Name = "label11";
            label11.Size = new Size(45, 17);
            label11.TabIndex = 24;
            label11.Text = "Опис";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 411);
            label10.Name = "label10";
            label10.Size = new Size(49, 17);
            label10.TabIndex = 24;
            label10.Text = "Місто";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(121, 17);
            label3.TabIndex = 24;
            label3.Text = "Назва компанії";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 324);
            label8.Name = "label8";
            label8.Size = new Size(86, 17);
            label8.TabIndex = 24;
            label8.Text = "Дата кінця";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 277);
            label7.Name = "label7";
            label7.Size = new Size(109, 17);
            label7.TabIndex = 24;
            label7.Text = "Дата початку";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 239);
            label6.Name = "label6";
            label6.Size = new Size(74, 17);
            label6.TabIndex = 24;
            label6.Text = "Кількість";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 166);
            label5.Name = "label5";
            label5.Size = new Size(63, 17);
            label5.TabIndex = 24;
            label5.Text = "Знижка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 24;
            label2.Text = "Назва";
            // 
            // panel2
            // 
            panel2.Controls.Add(label13);
            panel2.Controls.Add(citycomboBox);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(14, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(660, 43);
            panel2.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(70, 13);
            label13.Name = "label13";
            label13.Size = new Size(49, 17);
            label13.TabIndex = 2;
            label13.Text = "Місто";
            // 
            // citycomboBox
            // 
            citycomboBox.FormattingEnabled = true;
            citycomboBox.Location = new Point(125, 10);
            citycomboBox.Name = "citycomboBox";
            citycomboBox.Size = new Size(121, 25);
            citycomboBox.TabIndex = 1;
            citycomboBox.SelectedIndexChanged += citycomboBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = Color.White;
            button1.Location = new Point(35, 10);
            button1.Name = "button1";
            button1.Size = new Size(29, 30);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(966, 761);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Account);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Text = "Action Propositions";
            Account.ResumeLayout(false);
            Account.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDiscountPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox Account;
        private Label txtUsername;
        private Button btnLogin;
        private Button btnRegister;
        private Panel panel1;
        private Label label1;
        private TextBox tbShareName;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private NumericUpDown nudQuantity;
        private NumericUpDown nudDiscount;
        private TextBox tbImagePath;
        private TextBox tbCompanyName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox tbText;
        private TextBox tbLocation;
        private Label label11;
        private Label label10;
        private Button BtnReg;
        private Button BtnDelete;
        private Label label12;
        private NumericUpDown numDiscountPrice;
        private Panel panel2;
        private Button button1;
        private Label label13;
        private ComboBox citycomboBox;
    }
}