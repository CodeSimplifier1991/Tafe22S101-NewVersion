using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MortgageCalculator : Page
	{
		public MortgageCalculator()
		{
			this.InitializeComponent();
		}

		// START ---------- Loan Calculation Function -------------
		private void calculateTheLoanRepayment() {


			//Reading the data from the boxes
			double principaleLoanAmount = double.Parse(principalLoanAmountBox.Text);
			double durationOfLoanInYears = double.Parse(yearsOfTheLoanBox.Text);
			double durationOfTheLoanInMonths = double.Parse(andMonthOfTheLoanBox.Text);
			double yearlyInterestRate = double.Parse(yearlyInterestRateBox.Text) / 100;

			//Calculating the monthly interest rate
			double monthlyInterestRate = yearlyInterestRate / 12.0;

			//Calculating the loan duration in Months
			double loanRepayDurationInMonths = durationOfLoanInYears * 12 + durationOfTheLoanInMonths;

			double monthlyRepayment = 0;


			//Calculating the monthly repayment according to entered data
			monthlyRepayment =
				(principaleLoanAmount *
				monthlyInterestRate *
				(Math.Pow((1.0 + monthlyInterestRate), loanRepayDurationInMonths)) / ((Math.Pow((1.0 + monthlyInterestRate), loanRepayDurationInMonths)) - 1));

			//Show the result in the boxes
			monthlyInterestRateBox.Text = monthlyInterestRate.ToString("N4") + "%";
			monthlyRepaymentBox.Text = monthlyRepayment.ToString("N");
		}
		// END ------------ Loan Calculation Function -------------



		//START ---------- Calculate Button Click -----------
		private void calculateBtn_Click(object sender, RoutedEventArgs e)
		{
			calculateTheLoanRepayment();
		}
		//END ------------ Calculate Button Click -----------



		//START --------- Exit Button Click -----------
		private void exitBtn_Click(object sender, RoutedEventArgs e)
		{

		}
		//END ---------- Exit Button Click -----------

	}
	// MortgageCalculator
}
