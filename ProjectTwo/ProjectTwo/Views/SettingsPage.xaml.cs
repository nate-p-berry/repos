using ProjectTwo.Models;

namespace ProjectTwo.Views;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
        InitializeComponent();
		// TODO: Input session state/ logging for the discount rate, growth rate assumptions
		
	}

	private void SubmitButton_Clicked(object sender, EventArgs e)
	{
        Entry GrowthRateEntry = new();
        Entry DiscountRateEntry = new();
        Entry IntrinsincValueWeightEntry = new();
        Entry ComparableValueWeightEntry = new();
        Entry FactorValueWeightEntry = new();
        Entry GeographyPreferenceEntry = new();
        //Entry OtherEntry = new();
        SessionState.currentUser.CategoryPreference = "business";
		GrowthRateEntry.BindingContext = SessionState.currentUser.GrowthRateExpectation;
		DiscountRateEntry.BindingContext = SessionState.currentUser.DiscountRateExpectation;
		IntrinsincValueWeightEntry.BindingContext = SessionState.WeightDCF;
		ComparableValueWeightEntry.BindingContext = SessionState.WeightComps;
		FactorValueWeightEntry.BindingContext = SessionState.WeightFactors;
		GeographyPreferenceEntry.BindingContext = SessionState.currentUser.CountryPreference;
	}
}