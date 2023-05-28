using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Propositions
{
    public static class JsonSaveLoad
    {
        public static void SaveToFile(string filePath, List<ICatalogItem> catalogItems)
        {
            string json = JsonConvert.SerializeObject(catalogItems, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static List<ICatalogItem> LoadFromFile(string filePath)
        {
            string json;
            try
            {
                json = File.ReadAllText(filePath);
            }
            catch
            {
                return new List<ICatalogItem>();
            }

            List<CPromotionInfo> catalogItems = JsonConvert.DeserializeObject<List<CPromotionInfo>>(json);
            List<ICatalogItem> Items = new List<ICatalogItem>();
            Items.AddRange(catalogItems);
            return Items;
        }

    }


    public class CImg
    {
        public string ImagePath { get; set; }
        public CImg(string imagePath)
        {
            if (imagePath != null && imagePath !="")
                ImagePath = imagePath;
            else ImagePath = "IMG\\" + "Static.jpg";
        }
        public CImg()
        {
            ImagePath = "IMG\\" + "Static.jpg";
        }

        public Image GetImage()
        {
            try
            {
                return Image.FromFile(ImagePath);
            }   
            catch
            {
                return Image.FromFile("IMG\\" + "Static.jpg");
            }
        }
    }
    public class Info
    { 
        public decimal Discount { get; }
        public int Count { get; set; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }

        public decimal PropositionPrice { get; }
        public bool IsActive => DateTime.Now >= StartDate && DateTime.Now <= EndDate;

        // Конструктор
        public Info( decimal discount, int count,decimal propositionPrice, DateTime startDate, DateTime endDate)
        {
            if(discount>0 && discount<(decimal)100.01)
            Discount = discount;
            else Discount = 1;
            if(count>0) Count = count;
            else Count = 0;
            if (endDate > startDate)
            {
                StartDate = startDate;
                EndDate = endDate;
            }
            else {
                StartDate = DateTime.Now;
                EndDate = DateTime.Now;
            }
            if(propositionPrice > 0)
            PropositionPrice = propositionPrice;
            else PropositionPrice = 0;
        }
        
        public (bool,(decimal, decimal, int)) GetItem() 
        {
            return (IsActive, (PropositionPrice, Discount, Count));
        }
    }

    public interface ICatalogItem
    {
        public Info info { set; get; } 
        public CImg ItemImage { set; get; }
        public string ShareName { set; get; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public string Text { get; set; } 
        public ((bool, (decimal, decimal, int)), string, Image) GetCatalogItemData();
    }

    public class CPromotionInfo : ICatalogItem
    {
        public Info info { set; get; } 
        public CImg ItemImage { set; get; } 
        public String ShareName { set; get; }
        public string CompanyName { get; set; } 
        public string Location { get; set; }
        public string Text { get; set; }

        public CPromotionInfo(string shareName, string companyName, Info info, CImg itemImage, string location, string text)
        {
            this.ShareName = shareName;
            this.CompanyName = companyName;
            this.info = info;
            this.ItemImage = itemImage;
            this.Location = location;
            this.Text = text;
        }

        public bool Buy(int count)
        {
            if (count <= info.Count && Program.accountManager.GetCurrentUsername()!= "NewUser")
            {
                info.Count -= count;
                return true;
            }
            return false;
        }

        public ((bool, (decimal, decimal, int)), string, Image) GetCatalogItemData()
        {
            return (info.GetItem(), ShareName, ItemImage.GetImage());
        }

        public void GetFullItemData()
        {
            (new FormPropositionInfo(this, Program.accountManager)).ShowPromotionInfo();
        }
    }

}
