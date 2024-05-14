using EmailValidatorProject;

namespace EmailValidatorTests
{
    [TestClass]
    public class EmailTest : TestBase
    {
        [TestMethod]
        public void test_for_empty_email()
        {
            string email = getTestString("eEmpty");
            bool expected = false;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void test_for_space()
        {
            string email = getTestString("space");
            bool expected = false;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_for_at()
        {
            string email = getTestString("noat");
            bool expected = false;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        
        public void test_for_dot()
        {
            string email = getTestString("nodot");
            bool expected = false;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_for_Username_Over100() 
        {
            string email = getTestString("userNameGreaterThan100");
            bool expected = false;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        
        public void test_for_Username_Less_Than_1()
        {
            string email = getTestString("userNameLessThan1");
            bool expected = false;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void test_for_Domain_Greater_Than_100()
        {
            string email = getTestString("domainNameGreaterThan100");
            bool expected = false;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void test_for_Domain_Less_Than_3()
        {
            string email = getTestString("domainNameLessThan3");
            bool expected = false;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void test_for_UserName_Contain_Special_Character()
        {
            string email = getTestString("charInUserNameNotLetterOrDigit");
            bool expected = false;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void test_for_DomainName_Contain_Special_Character()
        {
            string email = getTestString("charInDomainNameNotLetterOrDigit");
            bool expected = false;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void test_for_Valid_Email()
        {
            string email = getTestString("validEmail");
            bool expected = true;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }
    }
}