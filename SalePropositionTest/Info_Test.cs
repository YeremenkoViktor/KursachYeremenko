namespace SalePropositionTest
{
    [TestClass]
    public class Info_Test
    {
        [TestMethod]
        public void Info_constructor_Test1()
        {
            // Arrange
            Info test;
            decimal expected = 10;
            // Act
            test = new Info(10, 100, 100, DateTime.Now,DateTime.Now.AddDays(3));
            // Assert
            Assert.AreEqual(expected, test.Discount);
        }
        [TestMethod]
        public void Info_constructor_Test2()
        {
            // Arrange
            Info test;
            decimal expected = 10;
            // Act
            test = new Info(99, 10, 100, DateTime.Now, DateTime.Now.AddDays(3));
            // Assert
            Assert.AreEqual(expected, test.Count);
        }
        [TestMethod]
        public void Info_constructor_Test3()
        {
            // Arrange
            Info test;
            decimal expected = 10;
            // Act
            test = new Info(99, 100, 10, DateTime.Now, DateTime.Now.AddDays(3));
            // Assert
            Assert.AreEqual(expected, test.PropositionPrice);
        }
        [TestMethod]
        public void Info_constructor_Test4()
        {
            // Arrange
            Info test;
            DateTime expected = DateTime.Now;
            // Act
            test = new Info(99, 100, 100, DateTime.Now, DateTime.Now.AddDays(3));
            // Assert
            Assert.AreEqual(expected.Date, test.StartDate.Date);
        }
        [TestMethod]
        public void Info_constructor_Test5()
        {
            // Arrange
            Info test;
            DateTime expected = DateTime.Now.AddDays(3);
            // Act
            test = new Info(99, 100, 100, DateTime.Now, DateTime.Now.AddDays(3));
            // Assert
            Assert.AreEqual(expected.Date, test.EndDate.Date);
        }
        [TestMethod]
        public void Info_constructor_constraint_Discount_Test1()
        {
            // Arrange
            Info test;
            decimal expected = 1;
            // Act
            test = new Info(110, 100, 100, DateTime.Now, DateTime.Now.AddDays(3));
            // Assert
            Assert.AreEqual(expected, test.Discount);
        }

        [TestMethod]
        public void Info_constructor_constraint_Discount_Test2()
        {
            // Arrange
            Info test;
            decimal expected = 1;
            // Act
            test = new Info(-110, 100, 100, DateTime.Now, DateTime.Now.AddDays(3));
            // Assert
            Assert.AreEqual(expected, test.Discount);
        }

        [TestMethod]
        public void Info_constructor_constraint_Count_Test1()
        {
            // Arrange
            Info test;
            decimal expected = 0;
            // Act
            test = new Info(10, -100, 100, DateTime.Now, DateTime.Now.AddDays(3));
            // Assert
            Assert.AreEqual(expected, test.Count);
        }

        [TestMethod]
        public void Info_constructor_constraint_PropositionPrice_Test1()
        {
            // Arrange
            Info test;
            decimal expected = 0;
            // Act
            test = new Info(10, 100, -100, DateTime.Now, DateTime.Now.AddDays(3));
            // Assert
            Assert.AreEqual(expected, test.PropositionPrice);
        }

        [TestMethod]
        public void Info_constructor_constraint_StartDate_Test1()
        {
            // Arrange
            Info test;
            DateTime expected = DateTime.Now;
            // Act
            test = new Info(10, -100, 100, DateTime.Now.AddDays(3), DateTime.Now.AddDays(-3));
            // Assert
            Assert.AreEqual(expected.Date, test.StartDate.Date);
        }

        [TestMethod]
        public void Info_constructor_constraint_EndDate_Test1()
        {
            // Arrange
            Info test;
            DateTime expected = DateTime.Now;
            // Act
            test = new Info(10, -100, 100, DateTime.Now.AddDays(3), DateTime.Now.AddDays(-3));
            // Assert
            Assert.AreEqual(expected.Date, test.EndDate.Date);
        }

        [TestMethod]
        public void GetItem_Test1()
        {
            // Arrange
            Info test;
            bool expected = true;
            // Act
            test = new Info(10, 100, 100, DateTime.Now.AddDays(-3), DateTime.Now.AddDays(3));
            // Assert
            Assert.AreEqual(expected, test.GetItem().Item1);
        }

        [TestMethod]
        public void GetItem_Test2()
        {
            // Arrange
            Info test;
            decimal expected = 100;
            // Act
            test = new Info(10, 1000, 100, DateTime.Now.AddDays(-3), DateTime.Now.AddDays(3));
            // Assert
            Assert.AreEqual(expected, test.GetItem().Item2.Item1);
        }

        [TestMethod]
        public void GetItem_Test3()
        {
            // Arrange
            Info test;
            decimal expected = 10;
            // Act
            test = new Info(10, 1000, 100, DateTime.Now.AddDays(-3), DateTime.Now.AddDays(3));
            // Assert
            Assert.AreEqual(expected, test.GetItem().Item2.Item2);
        }

        [TestMethod]
        public void GetItem_Test4()
        {
            // Arrange
            Info test;
            decimal expected = 1000;
            // Act
            test = new Info(10, 1000, 100, DateTime.Now.AddDays(-3), DateTime.Now.AddDays(3));
            // Assert
            Assert.AreEqual(expected, test.GetItem().Item2.Item3);
        }
    }
}
