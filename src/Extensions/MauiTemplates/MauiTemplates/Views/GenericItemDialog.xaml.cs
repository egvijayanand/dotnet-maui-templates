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
using VijayAnand.MauiTemplates.ViewModels;

namespace VijayAnand.MauiTemplates.Views
{
    public partial class GenericItemDialog : DialogWindow
    {
        readonly Brush foreColor;
        readonly Brush placeholderColor = Brushes.Gray;

        public GenericItemDialog(GenericItemViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
            ViewModel.OnError = (message, control) =>
            {
                MessageBox.Show(message, ".NET MAUI Generic Item", MessageBoxButton.OK, MessageBoxImage.Error);

                if (control == nameof(GenericItemViewModel.BaseType))
                {
                    cboBaseType.Focus();
                }
                else if (control == nameof(GenericItemViewModel.GenericType))
                {
                    txtGenericType.Focus();
                }
            };
            ViewModel.OnDismiss = (result) =>
            {
                DialogResult = result;
                Close();
            };
            DataContext = ViewModel;
            foreColor = cboBaseType.Foreground;
        }

        public GenericItemViewModel ViewModel { get; }

        private void OnBaseTypeGotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is ComboBox dropdown)
            {
                if (ViewModel.BaseTypeName == string.Empty)
                {
                    ViewModel.BaseType = string.Empty;
                    dropdown.Foreground = foreColor;
                }
            }
        }

        private void OnBaseTypeLostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is ComboBox dropdown)
            {
                if (ViewModel.BaseTypeName == string.Empty)
                {
                    ViewModel.BaseType = GenericItemViewModel.BasePlaceholderText;
                    dropdown.Foreground = placeholderColor;
                }
            }
        }

        private void OnGenericTypeGotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox entry)
            {
                if (ViewModel.GenericTypeName == string.Empty)
                {
                    ViewModel.GenericType = string.Empty;
                    entry.Foreground = foreColor;
                }
            }
        }

        private void OnGenericTypeLostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox entry)
            {
                if (ViewModel.GenericTypeName == string.Empty)
                {
                    ViewModel.GenericType = GenericItemViewModel.GenericPlaceholderText;
                    entry.Foreground = placeholderColor;
                }
            }
        }

        private void OnWindowLoaded(object sender, RoutedEventArgs e)
        {
            txtGenericType.Foreground = placeholderColor;
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
                else if (Keyboard.IsKeyDown(Key.N))
                {
                    txtGenericType.Focus();
                }
            }
        }
    }
}
