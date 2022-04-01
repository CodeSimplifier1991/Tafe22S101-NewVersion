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


/*
 Author: Behzad Pourdarab
 Date: 1/04/2022
 Version: V2.0
 Merge: from Mortgage Feature to development branch.
 Merge 2: From Currency conversion to the latest development branch.
 Note: Two feature branches merged successfully into the latest development branch.

 Merged the development branch with the release branch.
 Merged the release branch with the local master branch.
 Created tage V2.0 based on the latest version of the master branch.
 */

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainMenu : Page
	{
		public MainMenu()
		{
			this.InitializeComponent();
		}


		// START --------- Math Calculator Button Click ------------------
		private void mathCalculator_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainPage), null);
		}
		// END --------- Math Calculator Button Click ------------------


		// START --------- Mortgage Calculator Button Click ------------------
		private void mortgageCalculator_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MortgageCalculator), null);
		}
		// END --------- Mortgage Calculator Button Click ------------------


		// START --------- Currency Conversion Button Click ------------------
		private void currencyConversionBtn_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(CurrencyConversion), null);
		}
		// END --------- Currency Conversion Button Click ------------------


		// START --------- Exit Button Click ------------------
		private void exitBtn_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainMenu));
		}
		// END --------- Exit Button Click ------------------

	}
	// MainMenu
}
