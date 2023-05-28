namespace Action_Propositions
{
    partial class FormPropositionInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPropositionInfo));
            labelShareName = new Label();
            labelCompanyName = new Label();
            labelPrice = new Label();
            labelLocation = new Label();
            labelText = new Label();
            pictureBoxItemImage = new PictureBox();
            labelPriceText = new Label();
            button2 = new Button();
            label1 = new Label();
            discount = new Label();
            button1 = new Button();
            tbcount = new TextBox();
            labelcount = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxItemImage).BeginInit();
            SuspendLayout();
            // 
            // labelShareName
            // 
            labelShareName.AutoSize = true;
            labelShareName.Font = new Font("Nirmala UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelShareName.ForeColor = Color.FromArgb(204, 102, 0);
            labelShareName.Location = new Point(43, 9);
            labelShareName.Name = "labelShareName";
            labelShareName.Size = new Size(230, 37);
            labelShareName.TabIndex = 0;
            labelShareName.Text = "Смачна історія";
            // 
            // labelCompanyName
            // 
            labelCompanyName.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelCompanyName.ForeColor = Color.FromArgb(204, 102, 0);
            labelCompanyName.Location = new Point(227, 453);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(136, 23);
            labelCompanyName.TabIndex = 1;
            labelCompanyName.Text = "Солодкий дім";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Nirmala UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrice.ForeColor = Color.Black;
            labelPrice.Location = new Point(12, 292);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(138, 37);
            labelPrice.TabIndex = 2;
            labelPrice.Text = "Price: 0.00";
            // 
            // labelLocation
            // 
            labelLocation.Font = new Font("Nirmala UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelLocation.Location = new Point(43, 453);
            labelLocation.Name = "labelLocation";
            labelLocation.Size = new Size(178, 23);
            labelLocation.TabIndex = 3;
            labelLocation.Text = "Харків";
            // 
            // labelText
            // 
            labelText.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelText.Location = new Point(43, 361);
            labelText.Name = "labelText";
            labelText.Size = new Size(320, 89);
            labelText.TabIndex = 4;
            // 
            // pictureBoxItemImage
            // 
            pictureBoxItemImage.Image = (Image)resources.GetObject("pictureBoxItemImage.Image");
            pictureBoxItemImage.Location = new Point(47, 49);
            pictureBoxItemImage.Name = "pictureBoxItemImage";
            pictureBoxItemImage.Size = new Size(320, 240);
            pictureBoxItemImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxItemImage.TabIndex = 5;
            pictureBoxItemImage.TabStop = false;
            // 
            // labelPriceText
            // 
            labelPriceText.AutoSize = true;
            labelPriceText.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            labelPriceText.Location = new Point(169, 315);
            labelPriceText.Name = "labelPriceText";
            labelPriceText.Size = new Size(0, 36);
            labelPriceText.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(204, 102, 0);
            button2.Location = new Point(43, 609);
            button2.Name = "button2";
            button2.Size = new Size(320, 35);
            button2.TabIndex = 7;
            button2.Text = "Закрити";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(192, 292);
            label1.Name = "label1";
            label1.Size = new Size(147, 37);
            label1.TabIndex = 8;
            label1.Text = "Quantity: 0";
            // 
            // discount
            // 
            discount.AutoSize = true;
            discount.Font = new Font("Nirmala UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            discount.ForeColor = Color.Black;
            discount.Location = new Point(12, 324);
            discount.Name = "discount";
            discount.Size = new Size(149, 37);
            discount.TabIndex = 9;
            discount.Text = "Discount: 0";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(204, 102, 0);
            button1.Location = new Point(43, 568);
            button1.Name = "button1";
            button1.Size = new Size(320, 35);
            button1.TabIndex = 10;
            button1.Text = "Придбати";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tbcount
            // 
            tbcount.BackColor = Color.FromArgb(230, 231, 233);
            tbcount.BorderStyle = BorderStyle.None;
            tbcount.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbcount.Location = new Point(47, 534);
            tbcount.Multiline = true;
            tbcount.Name = "tbcount";
            tbcount.Size = new Size(308, 28);
            tbcount.TabIndex = 22;
            // 
            // labelcount
            // 
            labelcount.AutoSize = true;
            labelcount.Font = new Font("Nirmala UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelcount.ForeColor = Color.Black;
            labelcount.Location = new Point(43, 494);
            labelcount.Margin = new Padding(0);
            labelcount.Name = "labelcount";
            labelcount.Size = new Size(150, 37);
            labelcount.TabIndex = 23;
            labelcount.Text = "Кількість:";
            // 
            // FormPropositionInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 656);
            Controls.Add(labelcount);
            Controls.Add(tbcount);
            Controls.Add(button1);
            Controls.Add(discount);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(pictureBoxItemImage);
            Controls.Add(labelText);
            Controls.Add(labelLocation);
            Controls.Add(labelPriceText);
            Controls.Add(labelPrice);
            Controls.Add(labelCompanyName);
            Controls.Add(labelShareName);
            Cursor = Cursors.Hand;
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPropositionInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPromotionInfo";
            ((System.ComponentModel.ISupportInitialize)pictureBoxItemImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelShareName;
        private Label labelCompanyName;
        private Label labelPrice;
        private Label labelLocation;
        private Label labelText;
        private PictureBox pictureBoxItemImage;
        private Label labelPriceText;
        private Button button2;
        private Label label1;
        private Label discount;
        private Button button1;
        private TextBox tbcount;
        private Label labelcount;
    }
}