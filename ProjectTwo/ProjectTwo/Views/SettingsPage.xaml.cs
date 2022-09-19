using BusinessObjects;
using ProjectTwo.Models;

namespace ProjectTwo.Views;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
        Investor currentUser = new() {
            CategoryPreference = "business",
            CountryPreference = "us",
            DiscountRateExpectation = 0.05m,
            GrowthRateExpectation = 0.02m,
            WeightComparable = 0.333m,
            WeightDiscountedCashFlow = 0.333m,
            WeightFactorModel = 0.334m
        };

/*        currentUser.CategoryPreference = "business";
        GrowthRateEntry.BindingContext = currentUser.GrowthRateExpectation;
        DiscountRateEntry.BindingContext = currentUser.DiscountRateExpectation;
        IntrinsicValueWeightEntry.BindingContext = currentUser.WeightDiscountedCashFlow;
        ComparableValueWeightEntry.BindingContext = currentUser.WeightComparable;
        FactorValueWeightEntry.BindingContext = currentUser.WeightFactorModel;
        GeographyPreferenceEntry.BindingContext = currentUser.CountryPreference;*/
        InitializeComponent();
    }
    
    private void SubmitButton_Clicked(object sender, EventArgs e)
	{
        MessagingCenter.Send(this, $"Settings Saved!\n" +
            $"\n Growth Rate: {SessionState.GrowthRate}" +
            $"\n Discount Rate: {SessionState.DiscountRate}" +
            $"\n Intrinsic Value Weight: {SessionState.WeightDCF}" +
            $"\n Comparable Value Weight: {SessionState.WeightComps}" +
            $"\n Factor Value Weight: {SessionState.WeightFactors}" +
            $"\n Geography Preference: {SessionState.currentUser.CountryPreference}");
    }
    public void OnGrowthRateEntryTextCompleted(object sender, EventArgs e)
    {
        SessionState.GrowthRate = Convert.ToDecimal(((Entry)sender).Text);
    }
    public void OnDiscountRateEntryTextCompleted(object sender, EventArgs e)
    {
        SessionState.DiscountRate = Convert.ToDecimal(((Entry)sender).Text);
    }
    public void OnIntrinsicValueWeightCompleted(object sender, EventArgs e)
    {
        SessionState.WeightDCF = Convert.ToDecimal(((Entry)sender).Text);
    }
    public void OnComparableValueWeightCompleted(object sender, EventArgs e)
    {
        SessionState.WeightComps = Convert.ToDecimal(((Entry)sender).Text);
    }
    public void OnFactorValueWeightCompleted(object sender, EventArgs e)
    {
        SessionState.WeightFactors = Convert.ToDecimal(((Entry)sender).Text);
    }
    public void OnGeographyPreferenceCompleted(object sender, EventArgs e)
    {
        SessionState.currentUser.CountryPreference = ((Entry)sender).Text;
    }
    
    // TODO: Do I really need these if I have the stuff above?
    public void OnGrowthRateEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        SessionState.currentUser.GrowthRateExpectation = Convert.ToDecimal(GrowthRateEntry.Text);
    }
    public void OnDiscountRateEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        SessionState.currentUser.DiscountRateExpectation = Convert.ToDecimal(DiscountRateEntry.Text);
    }
    public void OnIntrinsicValueWeightEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        SessionState.WeightDCF = Convert.ToDecimal(IntrinsicValueWeightEntry.Text);
    }
    public void OnComparableValueWeightEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        SessionState.WeightComps = Convert.ToDecimal(ComparableValueWeightEntry.Text);
    }
    public void OnFactorValueWeightEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        SessionState.WeightFactors = Convert.ToDecimal(FactorValueWeightEntry.Text);
    }
    public void OnGeographyPreferenceEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        SessionState.currentUser.CountryPreference = GeographyPreferenceEntry.Text;
    }
    
}