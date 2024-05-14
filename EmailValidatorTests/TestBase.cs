using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailValidatorTests
{
    public class TestBase
    {
        public TestContext? TestContext { get; set; }

        public string getTestString(string testEmail)
        {
            return TestContext.Properties[testEmail]?.ToString();
        }
    }
}
