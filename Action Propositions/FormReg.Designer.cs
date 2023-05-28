namespace Action_Propositions
{
    partial class frmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            label5 = new Label();
            BtnClear = new Button();
            BtnReg = new Button();
            CheckBoxShowPas = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TxtPassword = new TextBox();
            TxtUsername = new TextBox();
            TxtConPas = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(204, 102, 0);
            label6.Location = new Point(54, 476);
            label6.Name = "label6";
            label6.Size = new Size(175, 17);
            label6.TabIndex = 28;
            label6.Text = "Повернутися до входу";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 450);
            label5.Name = "label5";
            label5.Size = new Size(148, 17);
            label5.TabIndex = 29;
            label5.Text = "Вже маєте акаунт?";
            // 
            // BtnClear
            // 
            BtnClear.BackColor = Color.White;
            BtnClear.Cursor = Cursors.Hand;
            BtnClear.FlatStyle = FlatStyle.Flat;
            BtnClear.ForeColor = Color.FromArgb(204, 102, 0);
            BtnClear.Location = new Point(29, 399);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(216, 35);
            BtnClear.TabIndex = 26;
            BtnClear.Text = "Очистити";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnReg
            // 
            BtnReg.BackColor = Color.FromArgb(204, 102, 0);
            BtnReg.Cursor = Cursors.Hand;
            BtnReg.FlatAppearance.BorderSize = 0;
            BtnReg.FlatStyle = FlatStyle.Flat;
            BtnReg.ForeColor = Color.White;
            BtnReg.Location = new Point(29, 358);
            BtnReg.Name = "BtnReg";
            BtnReg.Size = new Size(216, 35);
            BtnReg.TabIndex = 27;
            BtnReg.Text = "Зареєструватися";
            BtnReg.UseVisualStyleBackColor = false;
            BtnReg.Click += BtnReg_Click;
            // 
            // CheckBoxShowPas
            // 
            CheckBoxShowPas.AutoSize = true;
            CheckBoxShowPas.Cursor = Cursors.Hand;
            CheckBoxShowPas.FlatStyle = FlatStyle.Flat;
            CheckBoxShowPas.Location = new Point(92, 323);
            CheckBoxShowPas.Name = "CheckBoxShowPas";
            CheckBoxShowPas.Size = new Size(153, 21);
            CheckBoxShowPas.TabIndex = 25;
            CheckBoxShowPas.Text = "Показати пароль";
            CheckBoxShowPas.UseVisualStyleBackColor = true;
            CheckBoxShowPas.CheckedChanged += CheckBoxShowPas_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 190);
            label3.Name = "label3";
            label3.Size = new Size(63, 17);
            label3.TabIndex = 23;
            label3.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 123);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 24;
            label2.Text = "Логін";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(204, 102, 0);
            label1.Location = new Point(29, 66);
            label1.Name = "label1";
            label1.Size = new Size(185, 37);
            label1.TabIndex = 22;
            label1.Text = "Реєстрація";
            // 
            // TxtPassword
            // 
            TxtPassword.BackColor = Color.FromArgb(230, 231, 233);
            TxtPassword.BorderStyle = BorderStyle.None;
            TxtPassword.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtPassword.Location = new Point(29, 213);
            TxtPassword.Multiline = true;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '•';
            TxtPassword.Size = new Size(216, 28);
            TxtPassword.TabIndex = 20;
            // 
            // TxtUsername
            // 
            TxtUsername.BackColor = Color.FromArgb(230, 231, 233);
            TxtUsername.BorderStyle = BorderStyle.None;
            TxtUsername.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtUsername.Location = new Point(29, 143);
            TxtUsername.Multiline = true;
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(216, 28);
            TxtUsername.TabIndex = 21;
            // 
            // TxtConPas
            // 
            TxtConPas.BackColor = Color.FromArgb(230, 231, 233);
            TxtConPas.BorderStyle = BorderStyle.None;
            TxtConPas.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtConPas.Location = new Point(29, 289);
            TxtConPas.Multiline = true;
            TxtConPas.Name = "TxtConPas";
            TxtConPas.PasswordChar = '•';
            TxtConPas.Size = new Size(216, 28);
            TxtConPas.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 266);
            label4.Name = "label4";
            label4.Size = new Size(153, 17);
            label4.TabIndex = 23;
            label4.Text = "Підтвердіть пароль";
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(285, 544);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(BtnClear);
            Controls.Add(BtnReg);
            Controls.Add(CheckBoxShowPas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TxtConPas);
            Controls.Add(label1);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUsername);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogReg";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Button BtnClear;
        private Button BtnReg;
        private CheckBox CheckBoxShowPas;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TxtPassword;
        private TextBox TxtUsername;
        private TextBox TxtConPas;
        private Label label4;
    }
}