using CatAlog.GUI.Views.Windows;
using System.Windows;

namespace CatAlog.GUI.Services
{
    public class WindowsManager : DependencyObject
    {
        private AdditionalWindow _additionalWindow = null;

        private MessageWindow _messageWindow = null;

        public static readonly DependencyProperty TitleProperty;

        public static readonly DependencyProperty PackageProperty;

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public object Package
        {
            get { return (object)GetValue(PackageProperty); }
            set { SetValue(PackageProperty, value); }
        }

        static WindowsManager()
        {
            TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(WindowsManager));
            PackageProperty = DependencyProperty.Register("Package", typeof(object), typeof(WindowsManager));
        }

        protected virtual void Closad()
        { }

        public bool Close()
        {
            bool result = false;
            if (_additionalWindow != null)
            {
                _additionalWindow.Close();
                _additionalWindow = null;
                result = true;
            }

            if (_messageWindow != null)
            {
                _messageWindow.Close();
                _messageWindow = null;
                result = true;
            }
            return result;
        }

        protected void ShowAdditionalWindow(WindowsManager model)
        {
            model._additionalWindow = new AdditionalWindow();
            model._additionalWindow.DataContext = model;
            model._additionalWindow.Closed += (sender, e) => Close();
            model._additionalWindow.ShowDialog();
        }

        protected void ShowMessageDialog(WindowsManager model)
        {
            model._messageWindow = new MessageWindow();
            model._messageWindow.DataContext = model;
            model._messageWindow.Closed += (sender, e) => Close();
            model._messageWindow.ShowDialog();
        }
    }
}
