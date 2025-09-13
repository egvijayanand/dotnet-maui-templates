#nullable enable

using VijayAnand.MauiTemplates.Models;

namespace VijayAnand.MauiTemplates.ViewModels
{
    public partial class PageViewModel : BaseViewModel, ITitle
    {
        private string? title;

        public string? Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }
    }
}
