using System.Collections;
using System.ComponentModel.Design;
using System.Drawing;
using Microsoft.Maui;
using Microsoft.Maui.Graphics;
using Color = Microsoft.Maui.Graphics.Color;

namespace ProjectTwoLibrary.CardView
{
    // All the code in this file is included in all platforms.
    public partial class CardView : ContentView, IComponentInitializer
    {
        public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(nameof(CardTitle), typeof(string), typeof(CardView), string.Empty);
        public static readonly BindableProperty CardDescriptionProperty = BindableProperty.Create(nameof(CardDescription), typeof(string), typeof(CardView), string.Empty);
        public static readonly BindableProperty IconImageSourceProperty = BindableProperty.Create(nameof(ImageSource), typeof(ImageSource), typeof(CardView), string.Empty);
        //public static readonly BindableProperty IconImageSourceProperty = BindableProperty.Create(nameof(IconImageSource), typeof(ImageSource), typeof(CardView), string.Empty);
        public static readonly BindableProperty IconBackgroundColorProperty = BindableProperty.Create(nameof(BackgroundColor), typeof(Color), typeof(CardView), string.Empty);
        //public static readonly BindableProperty IconBackgroundColorProperty = BindableProperty.Create(nameof(IconBackgroundColor), typeof(Color), typeof(CardView), string.Empty);
        public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(nameof(Color), typeof(Color), typeof(CardView), string.Empty);
        //public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(CardView), string.Empty);
        public static readonly BindableProperty CardColorProperty = BindableProperty.Create(nameof(Color), typeof(Color), typeof(CardView), string.Empty);
        //public static readonly BindableProperty CardColorProperty = BindableProperty.Create(nameof(CardColor), typeof(Color), typeof(CardView), string.Empty);
        [DefaultValue("Unknown")]
        public string CardTitle
        {
            get => (string)GetValue(CardTitleProperty);
            set => SetValue(CardTitleProperty, value);
        }
        [DefaultValue("Not Applicable")]
        public string CardDescription
        {
            get => (string)GetValue(CardDescriptionProperty);
            set => SetValue(CardDescriptionProperty, value);
        }
        [DefaultValue($"C:\\Users\\berry\\source\\repos\\ProjectTwo\\ProjectTwo\\Resources\\Images\\")]
        public ImageSource IconImageSource
        {
            get => (ImageSource)GetValue(IconImageSourceProperty);
            set => SetValue(IconImageSourceProperty, value);
        }
        public Color IconBackgroundColor
        {
            get => (Color)GetValue(IconBackgroundColorProperty);
            set => SetValue(IconBackgroundColorProperty, value);
        }
        public Color BorderColor
        {
            get => (Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }
        public Color CardColor
        {
            get => (Color)GetValue(CardColorProperty);
            set => SetValue(CardColorProperty, value);
        }
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
    }
}