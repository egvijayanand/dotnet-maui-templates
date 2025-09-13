#nullable enable

namespace VijayAnand.MauiTemplates.Models
{
	public class Option : ObservableObject
	{
		private bool selected;

        public bool Selected
		{
			get => selected;
			set => SetProperty(ref selected, value);
		}

		public string? Content { get; init; }

        public string? Accelerator { get; init; }

        public int TabIndex { get; init; }
    }
}
