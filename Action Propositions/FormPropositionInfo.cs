using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Action_Propositions
{
    public partial class FormPropositionInfo : Form
    {
        ICatalogItem citem;
        public FormPropositionInfo(ICatalogItem item, AccountManager accountManager)
        {
            InitializeComponent();
            citem = item;
            labelShareName.Text = item.ShareName;
            labelCompanyName.Text = item.CompanyName;
            labelPrice.Text = $"Ціна: {item.info.PropositionPrice:$0.00}";
            discount.Text = $"Знижка: {item.info.Discount / 100:P}";
            labelLocation.Text = ((CPromotionInfo)item).Location;
            labelText.Text = ((CPromotionInfo)item).Text;
            label1.Text = $"Кількість: {((CPromotionInfo)item).info.Count}";
            pictureBoxItemImage.Image = item.ItemImage.GetImage();

        }


        public void ShowPromotionInfo()
        {
            this.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool result = int.TryParse(tbcount.Text, out var number);
            if (result && number > 0)
            {
                if (((CPromotionInfo)Program.Form.item.Find(n => n.ShareName == citem.ShareName)).Buy(number))
                {
                    MessageBox.Show("You have successfully buy a sale", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label1.Text = $"Quantity: {((CPromotionInfo)Program.Form.item.Find(n => n.ShareName == citem.ShareName)).info.Count}";
                    JsonSaveLoad.SaveToFile("Date.json", Program.Form.item);
                }
                else MessageBox.Show("You not login or not so much sale in storage", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else MessageBox.Show("Count is not normal", "Count Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
