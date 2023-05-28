using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalePropositionTest
{
    [TestClass]
    public class AccountManager_Test
    {

        [TestMethod]
        public void Register_Test1()
        {
            // Arrange
            AccountManager accountManager = new AccountManager("Data Source=AccountsDatabase.db");
            bool expected = true;
            // Act
            bool result = accountManager.Register("TestUser", "TestUser");
            accountManager.Delete("TestUser");
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Register_Test2()
        {
            // Arrange
            AccountManager accountManager = new AccountManager("Data Source=AccountsDatabase.db");
            bool expected = false;
            // Act
            bool result = accountManager.Register("1111", "1111");
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Login_Test1()
        {
            // Arrange
            AccountManager accountManager = new AccountManager("Data Source=AccountsDatabase.db");
            bool expected = true;
            // Act
            bool result = accountManager.Login("1111", "1111");
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Login_Test2()
        {
            // Arrange
            AccountManager accountManager = new AccountManager("Data Source=AccountsDatabase.db");
            bool expected = false;
            // Act
            bool result = accountManager.Login("1111111111111111", "11111111111111111111");
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Delete_Test1()
        {
            // Arrange
            AccountManager accountManager = new AccountManager("Data Source=AccountsDatabase.db");
            bool expected = false;
            // Act
            accountManager.Register("Delete_Test1", "Delete_Test1");
            accountManager.Delete("Delete_Test1");
            bool result = accountManager.Login("1111111111111111", "11111111111111111111");
            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
