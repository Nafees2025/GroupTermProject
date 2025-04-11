using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupTermProject.BusinessLogic
{
    public class UserPaymentInfo
    {

        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public int UserPhoneNumber {  get; set; }
        public int CardDate { get; set; }
        public string CardType { get; set; }
        public int CardNum { get; set; }
        public int CardCVV { get; set; }
        public DateTime ServiceDate { get; set; }

        public UserPaymentInfo() { }

        public UserPaymentInfo(string firstName, string lastName, int userPhoneNumber, int cardDate, string cardType, int cardNum, int cardCVV, DateTime serviceDate) 
        {
            FirstName = firstName;
            LastName = lastName;
            UserPhoneNumber = userPhoneNumber;
            CardDate = cardDate;
            CardType = cardType;
            CardNum = cardNum;
            CardCVV = cardCVV;
            ServiceDate = serviceDate;
        }


    }
}
