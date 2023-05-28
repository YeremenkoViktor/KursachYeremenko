using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Action_Propositions
{
    public partial class Form1 : Form
    {
        public List<ICatalogItem> item = new List<ICatalogItem>();
        List<ICatalogItem> itemsearch = new List<ICatalogItem>();
        public Form1()
        {
            InitializeComponent();
            item = JsonSaveLoad.LoadFromFile("Date.json");
            itemsearch = item;
            ShowCatalogItems(item);
            List<string> city = new List<string>();
            city.Add("Без вибору");
            foreach (var it in item)
            {
                city.Add(((CPromotionInfo)it).Location);
            }
            citycomboBox.Items.AddRange(city.Distinct().ToArray());
            Program.accountManager.Login("NewUser", "1");
            SetUsername(Program.accountManager.GetCurrentUsername());
        }
        private void ShowCatalogItems(List<ICatalogItem> catalogItems)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var item in catalogItems)
            {
                var res = item.GetCatalogItemData();
                if ((res.Item1.Item1 == false || res.Item1.Item2.Item3 <= 0) && Program.accountManager.IsCurrentUserAdmin() == false)
                {
                    continue;
                }
                var DiscountedPrice = res.Item1.Item2.Item1;
                var Discount = res.Item1.Item2.Item2;
                var Name = res.Item2;
                var Img = res.Item3;


                var tile = new Panel
                {
                    Width = 300,
                    Height = 235,
                    BorderStyle = BorderStyle.None,
                    Margin = new Padding(10),
                    Padding = new Padding(10)

                };
                tile.Click += (sender, e) => ((CPromotionInfo)item).GetFullItemData();

                var pictureBox = new PictureBox
                {
                    Image = Img,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Margin = new Padding(3),
                    Padding = new Padding(0),
                    Dock = DockStyle.None,
                    Width = 300,
                    Height = 200,
                };

                var nameLabel = new Label
                {
                    Text = Name,
                    Font = new Font("Nirmala UI", 12, FontStyle.Regular),
                    ForeColor = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0))))),
                    Width = 300,
                    Height = 20,
                    Margin = new Padding(0),
                    Padding = new Padding(0),
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.BottomLeft
                };

                var priceLabel = new Label
                {
                    Text = $"Ціна: {DiscountedPrice:$0.00}",
                    Font = new Font("Nirmala UI", 14, FontStyle.Bold),
                    ForeColor = Color.Black,
                    Width = 300,
                    Height = 20,
                    Margin = new Padding(0),
                    Padding = new Padding(0),
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.BottomRight
                };

                tile.Controls.Add(nameLabel);
                tile.Controls.Add(priceLabel);
                tile.Controls.Add(pictureBox);
                foreach (Control control in tile.Controls)
                {
                    control.Click += (sender, e) => ((CPromotionInfo)item).GetFullItemData();
                }

                flowLayoutPanel1.Controls.Add(tile);
            }
        }

        public void SetUsername(string username)
        {
            txtUsername.Text = username;
            panel1.Visible = Program.accountManager.IsCurrentUserAdmin();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new frmLog().Show();
        }


        private void BtnPost_Click(object sender, EventArgs e)
        {
            string shareName = tbShareName.Text;
            string companyName = tbCompanyName.Text;
            decimal discount = nudDiscount.Value;
            decimal discountprice = numDiscountPrice.Value;
            int quantity = (int)nudQuantity.Value;
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            string imagePath = tbImagePath.Text;
            CImg itemImage = new CImg(imagePath);
            Info price = new Info(discount, quantity, discountprice, startDate, endDate);
            string location = tbLocation.Text;
            string text = tbText.Text;

            if (quantity > 1 && endDate > startDate && endDate > DateTime.Now && discount > 0 && discountprice > 0 && discount<(decimal)100.01)
            {
                CPromotionInfo promotionInfo = new CPromotionInfo(shareName, companyName, price, itemImage, location, text);
                item.Add(promotionInfo);
                ShowCatalogItems(item);
                JsonSaveLoad.SaveToFile("Date.json", item);
            }
            else MessageBox.Show("Error in value", "Value error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
            openFileDialog.Title = "Select image";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbImagePath.Text = openFileDialog.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowCatalogItems(itemsearch);
        }

        private void citycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemsearch = new List<ICatalogItem>();
            MessageBox.Show("You have successfully change city", "Change successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (var it in item)
            {
                if (((CPromotionInfo)it).Location == citycomboBox.SelectedText)
                { itemsearch.Add(it); }
            }
            if (citycomboBox.SelectedText == "Без вибору")
                itemsearch = item;
            ShowCatalogItems(itemsearch);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            foreach (var it in item)
            {
                if (it.ShareName == tbShareName.Text)
                {
                    if (item.Remove(it))
                        MessageBox.Show("You have successfully delete promotion", "Delete successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("You don`t successfully delete promotion", "Delete fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    JsonSaveLoad.SaveToFile("Date.json", item);
                    break;
                }
            }
        }
    }
}