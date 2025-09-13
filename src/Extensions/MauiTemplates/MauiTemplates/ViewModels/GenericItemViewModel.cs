#nullable enable
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Windows.Input;
using VijayAnand.MauiTemplates.Extensions;
using VijayAnand.MauiTemplates.Models;

namespace VijayAnand.MauiTemplates.ViewModels
{
    public partial class GenericItemViewModel : PageViewModel
    {
        const string Colon = ":";
        const string CSharpTypePattern = @"^([A-Z]\w*)$";
        const string XamlTypePattern = @"^([a-zA-Z0-9]+\:)?([A-Z]\w*)$";

        public const string BasePlaceholderText = "Enter base type (in Pascal notation)";
        public const string GenericPlaceholderText = "Enter generic base type (in Pascal notation)";

        string baseType = BasePlaceholderText;
        string genericType = GenericPlaceholderText;

        public GenericItemViewModel() : this(false, false) { }

        public GenericItemViewModel(bool xamlItem, bool dotNet10, int ideVersion = 17)
        {
            Title = ".NET MAUI Generic Item | All-in-One Templates Pack";
            XamlItem = xamlItem;
            DotNet10 = dotNet10;

            BlogUrl = $"https://egvijayanand.in/?utm_source={(ideVersion == 18 ? "vs2026" : "vs2022")}&utm_medium=dialog&utm_campaign=new-item";
            SponsorUrl = "https://github.com/sponsors/egvijayanand";

            XamlOption = new() { Content = "_Xaml Only", Accelerator = "X", TabIndex = 2 };

            // Keep the objects in the same order to preserve the index value.
            Namespaces = [
            new() { Content = "_Global Namespace", Accelerator = "G", Selected = dotNet10, TabIndex = 3 },
            new() { Content = "_Implicit Namespace", Accelerator = "I", TabIndex = 4 },
            ];

            Suffixes =
            [
            new() { Content = "_Page", Accelerator = "P", TabIndex = 5 },
            new() { Content = "_View", Accelerator = "V", TabIndex = 6 },
            new() { Content = "_Shell", Accelerator = "S", TabIndex = 7 },
            new() { Content = "_Template", Accelerator = "T", TabIndex = 8 },
            new() { Content = "The_me", Accelerator = "M", TabIndex = 9 },
            new() { Content = "_Dialog", Accelerator = "D", TabIndex = 10 },
            new() { Content = "Pop_up", Accelerator = "U", TabIndex = 11 },
            new() { Content = "_Window", Accelerator = "W", TabIndex = 12 }
            ];

            if (XamlItem)
            {
                BaseTypes.Add("mct:Popup");
                BaseTypes.Add("vw:MauiPage");
            }
            else
            {
                BaseTypes.Add("Popup");
                BaseTypes.Add("MauiPage");
            }
        }

        public Action<string, string>? OnError { get; set; }

        public Action<bool>? OnDismiss { get; set; }

        #region Commands
        public ICommand SubmitCommand => new Command(OnSubmit);

        public ICommand CancelCommand => new Command(OnCancel);

        public ICommand NamespaceCommand => new Command<Option>(OnSelectNamespace);

        public ICommand SuffixCommand => new Command<Option>(OnSelectSuffix);
        #endregion

        #region Bindings
        public ObservableCollection<string> BaseTypes { get; } =
        [
            "Application",
            "ContentPage",
            "ContentView",
            "FlyoutPage",
            "Grid",
            "NavigationPage",
            "ResourceDictionary",
            "Shell",
            "StackLayout",
            "SwipeView",
            "TabbedPage",
            "TemplatedPage",
            "TemplatedView",
            "Window"
        ];

        /// <summary>
        /// To manage the <see cref="XamlOnly"/> option.
        /// </summary>
        public Option XamlOption { get; }

        public ObservableCollection<Option> Namespaces { get; }

        public ObservableCollection<Option> Suffixes { get; }

        public bool DotNet10 { get; }

        public bool XamlItem { get; }

        public string BaseType
        {
            get => baseType;
            set => SetProperty(ref baseType, value);
        }

        public string GenericType
        {
            get => genericType;
            set => SetProperty(ref genericType, value);
        }

        public string BlogUrl { get; }

        public string SponsorUrl { get; }
        #endregion

        #region Output
        public bool XamlOnly => XamlOption.Selected;

        public bool GlobalNamespace { get; private set; }

        public bool ImplicitNamespace { get; private set; }

        public string BaseTypeName
            => string.IsNullOrWhiteSpace(BaseType) || BaseType == BasePlaceholderText
            ? string.Empty
            : BaseType.Trim();

        public string GenericTypeName
            => string.IsNullOrWhiteSpace(GenericType) || GenericType == GenericPlaceholderText
            ? string.Empty
            : GenericType.Trim();

        public string ItemSuffix { get; private set; } = string.Empty;
        #endregion

        #region Methods
        private void OnSubmit()
        {
            if (XamlItem)
            {
                // The base type is mandatory.
                if (BaseTypeName.IsEmpty() || !Regex.IsMatch(BaseTypeName, XamlTypePattern))
                {
                    OnError?.Invoke("Invalid value for the base type.", nameof(BaseType));
                    return;
                }
                else if (GenericTypeName.HasValue() && !Regex.IsMatch(GenericTypeName, XamlTypePattern))
                {
                    // The generic type is optional and should only be validated if it is not empty.
                    OnError?.Invoke("Invalid value for the generic base type.", nameof(GenericType));
                    return;
                }
            }
            else
            {
                // The base type is mandatory.
                if (BaseTypeName.IsEmpty()
                    || BaseTypeName.Contains(Colon)
                    || !Regex.IsMatch(BaseTypeName, CSharpTypePattern))
                {
                    OnError?.Invoke("Invalid value for the C# base type.", nameof(BaseType));
                    return;
                }
                else if (GenericTypeName.HasValue()
                    && (GenericTypeName.Contains(Colon) || !Regex.IsMatch(GenericTypeName, CSharpTypePattern)))
                {
                    // The generic type is optional and should only be validated if it is not empty.
                    OnError?.Invoke("Invalid value for the C# generic base type.", nameof(GenericType));
                    return;
                }
            }

            GlobalNamespace = Namespaces[0].Selected;
            ImplicitNamespace = Namespaces[1].Selected;

            OnDismiss?.Invoke(true);
        }

        private void OnCancel() => OnDismiss?.Invoke(false);

        private void OnSelectNamespace(object? parameter)
        {
            if (parameter is Option option)
            {
                if (option.Selected)
                {
                    foreach (var item in Namespaces)
                    {
                        if (item != option)
                        {
                            item.Selected = false;
                        }
                    }
                }
            }
        }

        private void OnSelectSuffix(object? parameter)
        {
            if (parameter is Option suffix)
            {
                if (suffix.Selected)
                {
                    foreach (var item in Suffixes)
                    {
                        if (item != suffix)
                        {
                            item.Selected = false;
                        }
                    }

                    ItemSuffix = suffix.Content?.Replace("_", string.Empty) ?? string.Empty;
                }
                else
                {
                    ItemSuffix = string.Empty;
                }
            }
        }
        #endregion
    }
}
