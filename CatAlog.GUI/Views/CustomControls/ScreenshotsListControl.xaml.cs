using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace CatAlog.GUI.Views.CustomControls
{
    public partial class ScreenshotsListControl : UserControl
    {
        public static readonly DependencyProperty DataListProperty;

        public List<string> DataList
        {
            get { return (List<string>)GetValue(DataListProperty); }
            set { SetValue(DataListProperty, value); }
        }

        public ScreenshotsListControl()
        {
            InitializeComponent();
        }

        static ScreenshotsListControl()
        {
            DataListProperty = DependencyProperty.Register("DataList", typeof(List<string>), typeof(ScreenshotsListControl), new PropertyMetadata(null));
        }
    }
}
