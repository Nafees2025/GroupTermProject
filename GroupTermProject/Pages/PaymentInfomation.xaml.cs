using GroupTermProject.BusinessLogic;

namespace GroupTermProject;

public partial class PaymentInfomation : ContentPage
{

	UserPaymentInfo user = new UserPaymentInfo();

	public PaymentInfomation()
	{
		InitializeComponent();
		serviceDate.MinimumDate = DateTime.Now;
	}

    private void submitPayment_Clicked(object sender, EventArgs e)
    {
		try
		{
			
		}
		catch (Exception ex) 
		{

		}
    }
}