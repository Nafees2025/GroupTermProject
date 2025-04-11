using System.Diagnostics.Tracing;
using GroupTermProject.BusinessLogic;

namespace GroupTermProject;

public partial class PaymentInfomation : ContentPage
{

	UserPaymentInfo user;

	public PaymentInfomation()
	{
		InitializeComponent();
		serviceDate.MinimumDate = DateTime.Now;
	}

    private void submitPayment_Clicked(object sender, EventArgs e)
    {
		try
		{

			// Gets the input
			var firstName = cardFirstName.Text;
			var lastName = cardLastName.Text;
			var userPhone = int.Parse(userPhoneNum.Text);
			var cardExpire = int.Parse(cardDate.Text);
			var cardtype = Convert.ToString(cardType.SelectedItem);
			var cardNumber = int.Parse(cardNum.Text);
			var cardSecurity = int.Parse(cardCVV.Text);
			DateTime selectedTime = serviceDate.Date;

			user = new UserPaymentInfo(firstName, lastName, userPhone, cardExpire, cardtype, cardNumber, cardSecurity, selectedTime);

			//Lets user know they have successfully payed for the subscription
			DisplayAlert("Success", "You have successfully entered payment info!", "Ok");

			cardFirstName.Text = "";
			cardLastName.Text = "";
			userPhoneNum.Text = "";
			cardDate.Text = "";
			cardType.SelectedItem = null;
			cardNum.Text = "";
			cardCVV.Text = "";

			//Takes them back to home page
			GoToHP();
		}
		catch (Exception ex) 
		{
			//Display error if user misinputs or wrong information
			DisplayAlert("Error", "Information missing/incorrect", "Ok");
		}
    }

	private void GoToHP()
	{
		Shell.Current.GoToAsync("//HomePage");
	}

    private void HomeButton_Clicked(object sender, EventArgs e)
    {

		// This will let the user know that the order is cancelled
		DisplayAlert("Cancelled Order", "You have cancelled payment.", "Ok");
        cardFirstName.Text = "";
        cardLastName.Text = "";
        userPhoneNum.Text = "";
        cardDate.Text = "";
        cardType.SelectedItem = null;
        cardNum.Text = "";
        cardCVV.Text = "";
		GoToHP();
    }

    private void CreatAccountButton_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Error", "Account has already been created", "Ok");
    }
}