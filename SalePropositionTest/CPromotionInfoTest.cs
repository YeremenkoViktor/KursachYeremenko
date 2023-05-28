namespace SalePropositionTest
{
    [TestClass]
    public class CPromotionInfoTest
    {
        [TestMethod]
        public void CPromotionInfo_Constructor_Test1()
        {
            // Arrange
            CPromotionInfo item;
            // Act
            item = new CPromotionInfo("expected", "test", new Info(15, 100, 5, DateTime.Now, DateTime.Now), new CImg("test"), "test", "test");
            // Assert
            Assert.AreEqual("expected", item.ShareName);
        }

        [TestMethod]
        public void CPromotionInfo_Constructor_Test2()
        {
            // Arrange
            CPromotionInfo item;
            // Act
            item = new CPromotionInfo("test", "expected", new Info(15, 100, 5, DateTime.Now, DateTime.Now), new CImg("test"), "test", "test");
            // Assert
            Assert.AreEqual("expected", item.CompanyName);
        }

        [TestMethod]
        public void CPromotionInfo_Constructor_Test3()
        {
            // Arrange
            CPromotionInfo item;
            decimal expected = 15;
            // Act
            item = new CPromotionInfo("test", "test", new Info(15, 100, 5, DateTime.Now, DateTime.Now), new CImg("test"), "test", "test");
            // Assert
            Assert.AreEqual(expected, item.info.Discount);
        }

        [TestMethod]
        public void CPromotionInfo_Constructor_Test4()
        {
            // Arrange
            CPromotionInfo item;
            // Act
            item = new CPromotionInfo("test", "test", new Info(15, 100, 5, DateTime.Now, DateTime.Now), new CImg("expected"), "test", "test");
            // Assert
            Assert.AreEqual(new CImg("expected").ImagePath, item.ItemImage.ImagePath);
        }

        [TestMethod]
        public void CPromotionInfo_Constructor_Test5()
        {
            // Arrange
            CPromotionInfo item;
            // Act
            item = new CPromotionInfo("test", "test", new Info(15, 100, 5, DateTime.Now, DateTime.Now), new CImg("test"), "expected", "test");
            // Assert
            Assert.AreEqual("expected", item.Location);
        }

        [TestMethod]
        public void CPromotionInfo_Constructor_Test6()
        {
            // Arrange
            CPromotionInfo item;
            // Act
            item = new CPromotionInfo("test", "test", new Info(15, 100, 5, DateTime.Now, DateTime.Now), new CImg("test"), "text", "expected");
            // Assert
            Assert.AreEqual("expected", item.Text);
        }


    }
}
