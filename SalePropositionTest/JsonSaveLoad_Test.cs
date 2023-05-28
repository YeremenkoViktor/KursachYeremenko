namespace SalePropositionTest
{
    [TestClass]
    public class JsonSaveLoad_Test
    {
        [TestMethod]
        public void SaveToFile_LoadFromFile_Test1()
        {
            // Arrange
            List<ICatalogItem> items = new List<ICatalogItem>();
            CPromotionInfo item = new CPromotionInfo("expected","test", new Info(15,100,5,DateTime.Now,DateTime.Now),new CImg("test"),"test","test");
            items.Add(item);
            // Act
            JsonSaveLoad.SaveToFile("test.json", items);
            // Assert
            Assert.AreEqual("expected", JsonSaveLoad.LoadFromFile("test.json")[0].ShareName);
        }
        [TestMethod]
        public void SaveToFile_LoadFromFile_Test2()
        {
            // Arrange
            List<ICatalogItem> items = new List<ICatalogItem>();
            CPromotionInfo item = new CPromotionInfo("test", "expected", new Info(15, 100, 5, DateTime.Now, DateTime.Now), new CImg("test"), "test", "test");
            items.Add(item);
            // Act
            JsonSaveLoad.SaveToFile("test.json", items);
            // Assert
            Assert.AreEqual("expected", JsonSaveLoad.LoadFromFile("test.json")[0].CompanyName);
        }
        [TestMethod]
        public void SaveToFile_LoadFromFile_Test3()
        {
            // Arrange
            List<ICatalogItem> items = new List<ICatalogItem>();
            CPromotionInfo item = new CPromotionInfo("test", "test", new Info(15, 100, 5, DateTime.Now, DateTime.Now), new CImg("test"), "test", "test");
            items.Add(item);
            Decimal expected = 15;
            // Act
            JsonSaveLoad.SaveToFile("test.json", items);
            // Assert
            Assert.AreEqual(expected, JsonSaveLoad.LoadFromFile("test.json")[0].info.Discount);
        }
        [TestMethod]
        public void SaveToFile_LoadFromFile_Test4()
        {
            // Arrange
            List<ICatalogItem> items = new List<ICatalogItem>();
            CPromotionInfo item = new CPromotionInfo("test", "test", new Info(15, 100, 5, DateTime.Now, DateTime.Now), new CImg("expected"), "test", "test");
            items.Add(item);
            CImg expected = new CImg("expected");
            // Act
            JsonSaveLoad.SaveToFile("test.json", items);
            // Assert
            Assert.AreEqual(expected.ImagePath, JsonSaveLoad.LoadFromFile("test.json")[0].ItemImage.ImagePath);
        }
        [TestMethod]
        public void SaveToFile_LoadFromFile_Test5()
        {
            // Arrange
            List<ICatalogItem> items = new List<ICatalogItem>();
            CPromotionInfo item = new CPromotionInfo("test", "test", new Info(15, 100, 5, DateTime.Now, DateTime.Now), new CImg("test"), "expected", "test");
            items.Add(item);
            // Act
            JsonSaveLoad.SaveToFile("test.json", items);
            // Assert
            Assert.AreEqual("expected", JsonSaveLoad.LoadFromFile("test.json")[0].Location);
        }
        [TestMethod]
        public void SaveToFile_LoadFromFile_Test6()
        {
            // Arrange
            List<ICatalogItem> items = new List<ICatalogItem>();
            CPromotionInfo item = new CPromotionInfo("test", "test", new Info(15, 100, 5, DateTime.Now, DateTime.Now), new CImg("test"), "test", "expected");
            items.Add(item);
            // Act
            JsonSaveLoad.SaveToFile("test.json", items);
            // Assert
            Assert.AreEqual("expected", JsonSaveLoad.LoadFromFile("test.json")[0].Text);
        }
    }
}