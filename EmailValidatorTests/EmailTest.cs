using EmailValidatorProject;

namespace EmailValidatorTests
{
    [TestClass]
    public class EmailTest : TestBase
    {
        [TestMethod]
        public void test_for_empty_email_expect_false()
        {
            string email = getTestString("eEmpty");
            bool expected = false;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_for_not_empty_email_expect_true()
        {
            string email = getTestString("notEmpty");
            bool expected = true;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void test_for_space_expect_false()
        {
            string email = getTestString("space");
            bool expected = false;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void test_for_no_space_expect_true()
        {
            string email = getTestString("noSpace");
            bool expected = true;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_for_at_expect_false()
        {
            string email = getTestString("noat");
            bool expected = false;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void test_for_at_expect_true()
        {
            string email = getTestString("at");
            bool expected = true;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        
        public void test_for_dot_expect_false()
        {
            string email = getTestString("nodot");
            bool expected = false;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void test_for_dot_expect_true()
        {
            string email = getTestString("dot");
            bool expected = true;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_for_Username_Over100_expect_false() 
        {
            string email = getTestString("userNameGreaterThan100");
            bool expected = false;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_for_Username_less_than_100_expect_true()
        {
            string email = getTestString("userNameLessThan100");
            bool expected = true;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        
        public void test_for_Username_Less_Than_1_expect_false()
        {
            string email = getTestString("userNameLessThan1");
            bool expected = false;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void test_for_Username_Greater_Than_0_expect_true()
        {
            string email = getTestString("userNameGreaterThan0");
            bool expected = true;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void test_for_Domain_Greater_Than_100_expect_false()
        {
            string email = getTestString("domainNameGreaterThan100");
            bool expected = false;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void test_for_Domain_Less_Than_100_expect_true()
        {
            string email = getTestString("domainLessThan100");
            bool expected = true;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void test_for_Domain_Less_Than_3_expect_false()
        {
            string email = getTestString("domainNameLessThan3");
            bool expected = false;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void test_for_Domain_Greater_Than_2_expect_false()
        {
            string email = getTestString("domainGreaterThan2");
            bool expected = true;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void test_for_UserName_Contain_Special_Character_expect_false()
        {
            string email = getTestString("charInUserNameNotLetterOrDigit");
            bool expected = false;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void test_for_UserName_Does_Not_Contain_Special_Character_expect_true()
        {
            string email = getTestString("charInUserNameIsLetterOrDigit");
            bool expected = true;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void test_for_DomainName_Contain_Special_Character_expect_false()
        {
            string email = getTestString("charInDomainNameNotLetterOrDigit");
            bool expected = false;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void test_for_DomainName_Does_Not_Contain_Special_Character_expect_true()
        {
            string email = getTestString("charInDomainNameIsLetterOrDigit");
            bool expected = true;
            bool actual = EmailValidator.isValidEmail(email);
            TestContext.WriteLine(TestContext.TestName);
            Assert.AreEqual(expected, actual);
        }

        


    }
}