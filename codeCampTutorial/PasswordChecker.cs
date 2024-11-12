using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeCampTutorial
{
    internal class PasswordChecker
    {
        public static void Run()
        {
            bool success = false;

            while (!success)
            {
                Console.WriteLine("Enter a password (must contain a number and a special character)");
                var password = Console.ReadLine();

                Console.WriteLine("Confirm password");
                var passwordConfirm = Console.ReadLine();

                if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(passwordConfirm))
                {
                    if (password.Equals(passwordConfirm))
                    {

                        bool hasNumber = password.Any(char.IsDigit);


                        bool hasSpecialChar = password.Any(ch => !char.IsLetterOrDigit(ch));

                        if (hasNumber && hasSpecialChar)
                        {
                            Console.WriteLine("Password is valid and the passwords match.");
                            success = true;
                        }
                        else
                        {
                            Console.WriteLine("Password must contain at least one number and one special character.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Passwords do not match.");
                    }
                }
                else
                {
                    Console.WriteLine("You did not enter a password.");
                }
            }

            
        }
    }

}
