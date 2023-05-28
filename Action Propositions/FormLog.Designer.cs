namespace Action_Propositions
{
    partial class frmLog
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
            button2 = new Button();
            button1 = new Button();
            CheckBoxShowPas = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TxtPassword = new TextBox();
            TxtUsername = new TextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(204, 102, 0);
            label6.Location = new Point(92, 435);
            label6.Name = "label6";
            label6.Size = new Size(135, 17);
            label6.TabIndex = 18;
            label6.Text = "Створити акаунт";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 404);
            label5.Name = "label5";
            label5.Size = new Size(141, 17);
            label5.TabIndex = 19;
            label5.Text = "Не маєш акаунту?";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(204, 102, 0);
            button2.Location = new Point(41, 348);
            button2.Name = "button2";
            button2.Size = new Size(247, 40);
            button2.TabIndex = 16;
            button2.Text = "Очистити";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(204, 102, 0);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(41, 302);
            button1.Name = "button1";
            button1.Size = new Size(247, 40);
            button1.TabIndex = 17;
            button1.Text = "Увійти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CheckBoxShowPas
            // 
            CheckBoxShowPas.AutoSize = true;
            CheckBoxShowPas.Cursor = Cursors.Hand;
            CheckBoxShowPas.FlatStyle = FlatStyle.Flat;
            CheckBoxShowPas.Location = new Point(135, 275);
            CheckBoxShowPas.Name = "CheckBoxShowPas";
            CheckBoxShowPas.Size = new Size(153, 21);
            CheckBoxShowPas.TabIndex = 15;
            CheckBoxShowPas.Text = "Показати пароль";
            CheckBoxShowPas.UseVisualStyleBackColor = true;
            CheckBoxShowPas.CheckedChanged += CheckBoxShowPas_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 214);
            label3.Name = "label3";
            label3.Size = new Size(63, 17);
            label3.TabIndex = 13;
            label3.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 136);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 14;
            label2.Text = "Логін";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(204, 102, 0);
            label1.Location = new Point(41, 92);
            label1.Name = "label1";
            label1.Size = new Size(191, 37);
            label1.TabIndex = 11;
            label1.Text = "Розпочнімо";
            // 
            // TxtPassword
            // 
            TxtPassword.BackColor = Color.FromArgb(230, 231, 233);
            TxtPassword.BorderStyle = BorderStyle.None;
            TxtPassword.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtPassword.Location = new Point(41, 237);
            TxtPassword.Multiline = true;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '•';
            TxtPassword.Size = new Size(247, 32);
            TxtPassword.TabIndex = 9;
            // 
            // TxtUsername
            // 
            TxtUsername.BackColor = Color.FromArgb(230, 231, 233);
            TxtUsername.BorderStyle = BorderStyle.None;
            TxtUsername.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtUsername.Location = new Point(41, 159);
            TxtUsername.Multiline = true;
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(247, 32);
            TxtUsername.TabIndex = 10;
            // 
            // frmLog
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(330, 554);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CheckBoxShowPas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUsername);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Button button2;
        private Button button1;
        private CheckBox CheckBoxShowPas;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TxtPassword;
        private TextBox TxtUsername;
    }
}