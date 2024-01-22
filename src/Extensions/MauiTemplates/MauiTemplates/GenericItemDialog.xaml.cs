using Microsoft.VisualStudio.PlatformUI;
using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace VijayAnand.MauiTemplates
{
    public partial class GenericItemDialog : DialogWindow
    {
        const string BasePlaceholderText = "Enter base type (in Pascal notation)";
        const string GenericPlaceholderText = "Enter generic base type (in Pascal notation)";
        const string CSharpTypeExpression = @"^([A-Z]\w*)$";
        const string XamlTypeExpression = @"^([a-zA-Z0-9]+\:)?([A-Z]\w*)$";

        readonly bool xamlTemplate;
        readonly Brush foreColor;
        readonly Brush placeholderColor = Brushes.Gray;

        public GenericItemDialog(bool xamlTemplate = true)
        {
            InitializeComponent();
            this.xamlTemplate = xamlTemplate;
            foreColor = cboBaseType.Foreground;
            chkXamlOnly.Visibility = xamlTemplate ? Visibility.Visible : Visibility.Collapsed;

            if (xamlTemplate)
            {
                cboBaseType.Items.Add(new ComboBoxItem() { Content = "mct:Popup" });
                cboBaseType.Items.Add(new ComboBoxItem() { Content = "vw:MauiPage" });
            }
            else
            {
                cboBaseType.Items.Add(new ComboBoxItem() { Content = "Popup" });
                cboBaseType.Items.Add(new ComboBoxItem() { Content = "MauiPage" });
            }
        }

        public string BaseType { get; private set; }

        public string GenericType { get; private set; }

        public bool XamlOnly { get; private set; }

        private void OnAcceptClick(object sender, RoutedEventArgs e)
        {
            XamlOnly = chkXamlOnly.Visibility == Visibility.Visible && chkXamlOnly.IsChecked is true;
            BaseType = cboBaseType.Text == BasePlaceholderText ? string.Empty : cboBaseType.Text.Trim();
            GenericType = txtGenericType.Text == GenericPlaceholderText ? string.Empty : txtGenericType.Text.Trim();

            if (string.IsNullOrEmpty(BaseType))
            {
                ShowMessage("Not a valid value for base type.");
                cboBaseType.Focus();
                return;
            }

            if (xamlTemplate)
            {
                if (!Regex.IsMatch(BaseType, XamlTypeExpression))
                {
                    ShowMessage("Not a valid value for C# base type.");
                    cboBaseType.Focus();
                    return;
                }
                else if (!string.IsNullOrEmpty(GenericType) && !Regex.IsMatch(GenericType, XamlTypeExpression))
                {
                    ShowMessage("Not a valid value for C# generic base type.");
                    txtGenericType.Focus();
                    return;
                }
            }
            else
            {
                if (BaseType.Contains(':') || !Regex.IsMatch(BaseType, CSharpTypeExpression))
                {
                    ShowMessage("Not a valid value for C# base type.");
                    cboBaseType.Focus();
                    return;
                }
                else if (!string.IsNullOrEmpty(GenericType) 
                    && (GenericType.Contains(':') || !Regex.IsMatch(GenericType, CSharpTypeExpression)))
                {
                    ShowMessage("Not a valid value for C# generic base type.");
                    txtGenericType.Focus();
                    return;
                }
            }

            DialogResult = true;
            Close();
        }

        private void OnCancelClick(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void OnBaseTypeGotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is ComboBox dropdown)
            {
                if (dropdown.Text.Trim() == BasePlaceholderText)
                {
                    dropdown.Text = string.Empty;
                    dropdown.Foreground = foreColor;
                }
            }
        }

        private void OnBaseTypeLostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is ComboBox dropdown)
            {
                if (dropdown.Text == string.Empty)
                {
                    dropdown.Text = BasePlaceholderText;
                    dropdown.Foreground = placeholderColor;
                }
            }
        }

        private void OnGenericTypeGotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox entry)
            {
                if (entry.Text.Trim() == GenericPlaceholderText)
                {
                    entry.Text = string.Empty;
                    entry.Foreground = foreColor;
                }
            }
        }

        private void OnGenericTypeLostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox entry)
            {
                if (entry.Text == string.Empty)
                {
                    entry.Text = GenericPlaceholderText;
                    entry.Foreground = placeholderColor;
                }
            }
        }

        private void OnWindowLoaded(object sender, RoutedEventArgs e)
        {
            txtGenericType.Foreground = placeholderColor;
            txtGenericType.Text = GenericPlaceholderText;
            cboBaseType.Focus();
        }

        private void OnRequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = e.Uri.AbsoluteUri,
                UseShellExecute = true
            });

            e.Handled = true;
        }

        private void OnWindowKeyDown(object sender, KeyEventArgs e)
        {
            if ((Keyboard.Modifiers & ModifierKeys.Alt) == ModifierKeys.Alt)
            {
                if (Keyboard.IsKeyDown(Key.B))
                {
                    cboBaseType.Focus();
                }
                else if (Keyboard.IsKeyDown(Key.G))
                {
                    txtGenericType.Focus();
                }
            }
        }

        private static void ShowMessage(string message)
        {
            MessageBox.Show(message, ".NET MAUI Generic Item", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
