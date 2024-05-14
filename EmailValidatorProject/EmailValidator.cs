using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailValidatorProject
{
    public class EmailValidator
    {
        
        public static bool isValidEmail(string email)
        {
           

            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            if(email.Contains(" "))
            {
                return false;
            }

            if (!email.Contains("@")) 
            {
                return false;
            }

            if (!email.Contains(".")) 
            {
                return false;
            }
            var at = email.IndexOf("@");
            var dot = email.IndexOf(".", at);
            var userName = email.Substring(0, at);
            var domain = email.Substring(at + 1, dot - at - 1);
            if (userName.Length > 100)
            {
                return false;
            }
            
            if (userName.Length < 1)
            { 
                return false; 
            }

            if (domain.Length > 100) 
            {
                return false;
            }

            if (domain.Length < 3) 
            {
                return false;
            }

            foreach (var c in userName)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }

            foreach (var c in domain)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
