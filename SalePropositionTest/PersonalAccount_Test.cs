namespace SalePropositionTest
{
    [TestClass]
    public class PersonalAccount_Test
    {

        [TestMethod]
        public void Value_Test1()
        {
            // Arrange
            PersonAccount account = new PersonAccount();
            // Act
            account.Password = "expected";
            // Assert
            Assert.AreEqual("expected", account.Password);
        }

        [TestMethod]
        public void Value_Test2()
        {
            // Arrange
            PersonAccount account = new PersonAccount();
            // Act
            account.Username = "expected";
            // Assert
            Assert.AreEqual("expected", account.Username);
        }

        [TestMethod]
        public void Value_Test3()
        {
            // Arrange
            PersonAccount account = new PersonAccount();
            bool expected = true;
            // Act
            account.IsAdmin=true;
            // Assert
            Assert.AreEqual(expected, account.IsAdmin);
        }

        [TestMethod]
        public void Value_Test4()
        {
            // Arrange
            PersonAccount account = new PersonAccount();
            int expected = 1;
            // Act
            account.Id = 1;
            // Assert
            Assert.AreEqual(expected, account.Id);

        }

        [TestMethod]
        public void Clear_Test1()
        {
            // Arrange
            PersonAccount account = new PersonAccount();
            int expected = -1;
            // Act
            account.Id = 1;
            account.Username = "1";
            account.Password = "1";
            account.IsAdmin = true;
            account.Clear();
            // Assert
            Assert.AreEqual(expected, account.Id);
        }
        [TestMethod]
        public void Clear_Test2()
        {
            // Arrange
            PersonAccount account = new PersonAccount();
            string expected = "";
            // Act
            account.Id = 1;
            account.Username = "1";
            account.Password = "1";
            account.IsAdmin = true;
            account.Clear();
            // Assert
            Assert.AreEqual(expected, account.Password);
        }
        [TestMethod]
        public void Clear_Test3()
        {
            // Arrange
            PersonAccount account = new PersonAccount();
            string expected = "";
            // Act
            account.Id = 1;
            account.Username = "1";
            account.Password = "1";
            account.IsAdmin = true;
            account.Clear();
            // Assert
            Assert.AreEqual(expected, account.Username);
        }
        [TestMethod]
        public void Clear_Test4()
        {
            // Arrange
            PersonAccount account = new PersonAccount();
            bool expected = false;
            // Act
            account.Id = 1;
            account.Username = "1";
            account.Password = "1";
            account.IsAdmin = true;
            account.Clear();
            // Assert
            Assert.AreEqual(expected, account.IsAdmin);
        }
    }
}
