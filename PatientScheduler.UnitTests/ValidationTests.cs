using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatientScheduler.Classes.Database;
using PatientScheduler.Classes.Validation;

namespace PatientScheduler.UnitTests
{
    [TestClass]
    public class ValidationTests
    {
        [TestMethod]
        public void ValidateUsername_Valid_ReturnsTrue()
        {
            var av = new AccountValidation();
            bool validUsername = av.ValidateUsername("jesse123");
            Assert.IsTrue(validUsername);
        }

        [TestMethod]
        public void ValidateUsername_InvalidWithPlaceholder_ReturnsFalse()
        {
            var av = new AccountValidation();
            bool validUsername = av.ValidateUsername("enter your username..");
            Assert.IsFalse(validUsername);
        }

        [TestMethod]
        public void ValidateUsername_InvalidWithSymbols_ReturnsFalse()
        {
            var av = new AccountValidation();
            bool validUsername = av.ValidateUsername("admin$");
            Assert.IsFalse(validUsername);
        }

        [TestMethod]
        public void ValidateUsername_InvalidTooShort_ReturnsFalse()
        {
            var av = new AccountValidation();
            bool validUsername = av.ValidateUsername("a1");
            Assert.IsFalse(validUsername);
        }

        [TestMethod]
        public void ValidateUsername_UsernameUnique_ReturnsTrue()
        {
            var ad = new AccountsData();
            bool uniqueUsername = ad.CheckForExistingUsername("69c5c5b711");
            Assert.IsTrue(uniqueUsername);
        }

        [TestMethod]
        public void ValidateUsername_UsernameNotUnique_ReturnsFalse()
        {
            var ad = new AccountsData();
            bool uniqueUsername = ad.CheckForExistingUsername("admin");
            Assert.IsFalse(uniqueUsername);
        }
    }
}
