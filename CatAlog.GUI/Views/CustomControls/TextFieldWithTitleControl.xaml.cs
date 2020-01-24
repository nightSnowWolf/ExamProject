using System.Windows;
using System.Windows.Controls;

namespace CatAlog.GUI.Views.CustomControls
{
    public partial class TextFieldWithTitleControl : UserControl
    {
        public static readonly DependencyProperty TitleNameProperty;

        public static readonly DependencyProperty TextProperty;

        public string TitleName
        {
            get { return (string)GetValue(TitleNameProperty); }
            set { SetValue(TitleNameProperty, value); }
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public TextFieldWithTitleControl()
        {
            InitializeComponent();
        }

        static TextFieldWithTitleControl()
        {
            TitleNameProperty = DependencyProperty.Register
                (
                    "TitleName",
                    typeof(string),
                    typeof(TextFieldWithTitleControl),
                    new FrameworkPropertyMetadata
                    (
                        "",
                        new PropertyChangedCallback(SetName)
                    ),
                        new ValidateValueCallback(ValidateName)
                );

            TextProperty = DependencyProperty.Register
                (
                    "Text",
                    typeof(string),
                    typeof(TextFieldWithTitleControl),
                    new FrameworkPropertyMetadata
                    (
                        "",
                        new PropertyChangedCallback(SetText)
                    ),
                    new ValidateValueCallback(ValidateText)
                );
        }

        private static void SetName(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((TextFieldWithTitleControl)d).InsertName();
        }

        private void InsertName()
        {
            label.Content = this.TitleName;
        }

        private static bool ValidateName(object value)
        {
            return value != null ? true : false;
        }

        private static void SetText(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((TextFieldWithTitleControl)d).InsertText();
        }

        private void InsertText()
        {
            textBox.Text = this.Text;
        }

        private static bool ValidateText(object value)
        {
            return value != null ? true : false;
        }
    }
}
