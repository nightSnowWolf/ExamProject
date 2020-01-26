using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CatAlog.GUI.Views.CustomControls
{
    public partial class TextBoxWithPopup : UserControl
    {
        private ObservableCollection<string> _itemsList;

        private KeyValuePair<int, string>[] _sourceItems;

        public static readonly DependencyProperty SourceItemsProperty;

        public static readonly DependencyProperty TextProperty;

        public ObservableCollection<string> ItemsList
        {
            get { return _itemsList; }
            set { _itemsList = value; }
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public KeyValuePair<int, string>[] SourceItems
        {
            get { return (KeyValuePair<int, string>[])GetValue(SourceItemsProperty); }
            set { SetValue(SourceItemsProperty, value); }
        }

        public TextBoxWithPopup()
        {
            InitializeComponent();
            _itemsList = new ObservableCollection<string>();
            lstSelecet.ItemsSource = ItemsList;
        }

        static TextBoxWithPopup()
        {
            SourceItemsProperty = DependencyProperty.Register("SourceItems", typeof(KeyValuePair<int, string>[]), typeof(TextBoxWithPopup), new PropertyMetadata(SetInItemsList));
            TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(TextBoxWithPopup), new PropertyMetadata(null));
        }

        private static void SetInItemsList(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((TextBoxWithPopup)d).SetItems();
        }

        private void SetItems()
        {
            _sourceItems = SourceItems;
        }

        private void lstSelecet_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Left && e.Key != Key.Up &&
                e.Key != Key.Right && e.Key != Key.Down)
            {
                mainTb.Focus();
            }

            switch (e.Key)
            {
                case Key.Enter:
                    {
                        EnterString(sender);
                        break;
                    }
                case Key.Escape:
                    {
                        textPopup.IsOpen = false;
                        break;
                    }
            }
        }

        private void lstSelecet_MouseEnter(object sender, MouseEventArgs e)
        {
            EnterString(sender);
        }

        private void EnterString(object sender)
        {
            textPopup.IsOpen = false;
            ListBox lb = sender as ListBox;
            if (lb == null)
            {
                return;
            }

            string selectedString = CreateStringForPaste(lb.SelectedItem.ToString());
            int wordEnd = mainTb.CaretIndex - 1;

            int wordStart = mainTb.Text.LastIndexOf(' ', mainTb.CaretIndex - 1);
            if (wordStart == -1)
            {
                wordStart = 0;
            }

            int count = wordEnd - wordStart;

            if (wordStart == 0)
            {
                mainTb.Text = "";
                wordEnd = 0;
            }
            else
            {
                mainTb.Text = mainTb.Text.Remove(wordStart + 1, count);
                wordEnd = wordStart + 1;
            }

            mainTb.Text = mainTb.Text.Insert(wordEnd, selectedString);
            mainTb.CaretIndex = wordEnd + selectedString.Length;
            mainTb.Focus();
        }

        private string CreateStringForPaste(string str)
        {
            StringBuilder builder = new StringBuilder(str);
            builder.Append(", ");
            return builder.ToString();
        }

        private void mainTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down && textPopup.IsOpen == true)
            {
                lstSelecet.Focus();
                return;
            }

            TextBox tb = sender as TextBox;

            if (e.Key == Key.Space)
            {
                textPopup.IsOpen = false;
                return;
            }

            if (tb == null || tb.CaretIndex == 0)
            {
                return;
            }

            string str = tb.Text;
            int wordStart = str.LastIndexOf(' ', tb.CaretIndex - 1);
            if (wordStart == -1)
            {
                wordStart = 0;
            }

            string lastWord = str.Substring(wordStart, tb.CaretIndex - wordStart);

            GetNewList(lastWord.Trim());

            if (ItemsList != null && ItemsList.Count != 0)
            {
                ShowMethodPopup(mainTb.GetRectFromCharacterIndex(mainTb.CaretIndex));
            }
            else
            {
                textPopup.IsOpen = false;
            }

        }

        private void ShowMethodPopup(Rect placement)
        {
            textPopup.PlacementTarget = mainTb;
            textPopup.PlacementRectangle = placement;
            textPopup.IsOpen = true;
            lstSelecet.SelectedIndex = 0;
        }

        private void GetNewList(string lastWord)
        {
            var output = _sourceItems.Select(word => word.Value.IndexOf(lastWord.ToLower())).ToList();
            ItemsList.Clear();

            for (int i = 0; i < output.Count; i++)
            {
                if (output[i] != -1)
                {
                    ItemsList.Add(_sourceItems[i].Value);
                }
            }
        }
    }
}
