using System.Collections;
using System.ComponentModel.Design;

namespace ProjectTwoLibrary
{
    // All the code in this file is included in all platforms.
    public partial class CardView : ContentView, IComponentInitializer
    {
        public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(nameof(CardTitle), typeof(string), typeof(CardView), string.Empty);

        public string CardTitle
        {
            get => (string)GetValue(CardView.CardTitleProperty);
            set => SetValue(CardView.CardTitleProperty, value);
        }
        // ...

        public CardView()
        {
            InitializeComponent();
        }

        public void InitializeExistingComponent(IDictionary defaultValues)
        {
            throw new NotImplementedException();
        }

        public void InitializeNewComponent(IDictionary defaultValues)
        {
            throw new NotImplementedException();
        }
        private void InitializeComponent()
        {
            global::Microsoft.Maui.Controls.Xaml.Extensions.LoadFromXaml(this, typeof(CardView));
        }
    }
}