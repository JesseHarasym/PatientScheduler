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

        [TestMethod]
        public void ValidatePassword_PasswordsAreEqual_ReturnsTrue()
        {
            var av = new AccountValidation();
            var passwordValidation = av.ValidatePassword("abc123", "abc123");
            bool passwordsEqual = passwordValidation.Item1;
            Assert.IsTrue(passwordsEqual);
        }

        [TestMethod]
        public void ValidatePassword_PasswordsAreNotEqual_ReturnsFalse()
        {
            var av = new AccountValidation();
            var passwordValidation = av.ValidatePassword("abc123", "cde456");
            bool passwordsEqual = passwordValidation.Item1;
            Assert.IsFalse(passwordsEqual);
        }

        [TestMethod]
        public void ValidatePassword_Valid_ReturnsTrue()
        {
            var av = new AccountValidation();
            var passwordValidation = av.ValidatePassword("abc123", "abc123");
            bool validPassword = passwordValidation.Item2;
            Assert.IsTrue(validPassword);
        }

        [TestMethod]
        public void ValidatePassword_InvalidTooShort_ReturnsFalse()
        {
            var av = new AccountValidation();
            var passwordValidation = av.ValidatePassword("abc12", "abc12");
            bool validPassword = passwordValidation.Item2;
            Assert.IsFalse(validPassword);
        }

        [TestMethod]
        public void ValidatePassword_PasswordLogIn_ReturnsTrue()
        {

            var ad = new AccountsData();
            var accountInfo = ad.GetAccountPassword("admin", "admin123");
            bool passwordMatch = accountInfo.Item1;
            Assert.IsTrue(passwordMatch);
        }

        [TestMethod]
        public void ValidatePassword_PasswordDoesNotLogIn_ReturnsFalse()
        {

            var ad = new AccountsData();
            var accountInfo = ad.GetAccountPassword("admin", "admin123456");
            bool passwordMatch = accountInfo.Item1;
            Assert.IsFalse(passwordMatch);
        }

        [TestMethod]
        public void ValidatePassword_ValidPasswordUnHashed_ReturnsTrue()
        {
            var hp = new HashPasswords();
            bool unHashed = hp.UnHashAccountPassword("admin123", "id5Js+i6vmHSk+l8sIuplu/85HdPCY6IrPSMf/cNJidF9uGM");
            Assert.IsTrue(unHashed);

        }

        [TestMethod]
        public void ValidatePassword_InvalidPasswordUnHashed_ReturnsFalse()
        {
            var hp = new HashPasswords();
            bool unHashed = hp.UnHashAccountPassword("abc123", "id5Js+i6vmHSk+l8sIuplu/85HdPCY6IrPSMf/cNJidF9uGM");
            Assert.IsFalse(unHashed);

        }

        [TestMethod]
        public void ValidateStaffId_ValidExists_ReturnsTrue()
        {
            var sd = new StaffData();
            bool validStaffId = sd.CheckForValidStaffId(1);
            Assert.IsTrue(validStaffId);
        }

        [TestMethod]
        public void ValidateStaffId_InvalidDoesNotExist_ReturnsFalse()
        {
            var sd = new StaffData();
            bool validStaffId = sd.CheckForValidStaffId(100000);
            Assert.IsFalse(validStaffId);
        }

        [TestMethod]
        public void ValidateStaffId_ValidDoesNotHaveAccount_ReturnsTrue()
        {
            var sd = new StaffData();
            bool staffIdHasAccount = sd.CheckIfStaffIdHasAccount(1000000);
            Assert.IsTrue(staffIdHasAccount);
        }

        [TestMethod]
        public void ValidateStaffId_InvalidDoesHaveAccount_ReturnsFalse()
        {
            var sd = new StaffData();
            bool staffIdHasAccount = sd.CheckIfStaffIdHasAccount(1);
            Assert.IsFalse(staffIdHasAccount);
        }
    }
}
