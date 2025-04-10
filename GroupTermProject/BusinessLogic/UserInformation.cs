using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupTermProject.BusinessLogic;

public class UserInformation
{
    // Creating all the properties for this class
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool newsLetterSubscription { get; set; }
    public static bool VerifyAccountCreated { get; set; }

    // Creating the base initailizer with no parameteres
    public UserInformation() { }

    // Creating the initailizer with parameteres
    public UserInformation(string firstName, string lastName, string email, string password, bool newsLetter, bool verifyAccount)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        newsLetterSubscription = newsLetter;
        VerifyAccountCreated = verifyAccount;
    }
}
