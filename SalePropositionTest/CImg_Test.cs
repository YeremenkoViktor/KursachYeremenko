namespace SalePropositionTest
{
    [TestClass]
    public class CImg_Test
    {

        [TestMethod]
        public void CImg_string_Test1()
        {
            // Arrange
            CImg test;
            // Act
            test = new CImg("expected");
            // Assert
            Assert.AreEqual("expected",test.ImagePath);
        }

        [TestMethod]
        public void CImg_string_Test2()
        {
            // Arrange
            CImg test;
            // Act
            test = new CImg("");
            // Assert
            Assert.AreEqual(("IMG\\" + "Static.jpg"), test.ImagePath);
        }

        [TestMethod]
        public void CImg_string_Test3()
        {
            // Arrange
            CImg test;
            // Act
            test = new CImg(null);
            // Assert
            Assert.AreEqual(("IMG\\" + "Static.jpg"), test.ImagePath);
        }

        [TestMethod]
        public void CImg_Test1()
        {
            // Arrange
            CImg test;
            // Act
            test = new CImg();
            // Assert
            Assert.AreEqual(("IMG\\" + "Static.jpg"), test.ImagePath);
        }
    }
}
