using System.Runtime.CompilerServices;

namespace MauiApp1
{
    public partial class DateTimePicker : ContentView
    {
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(DateTimePicker), default(string));

        public static readonly BindableProperty DateProperty = BindableProperty.Create(nameof(Date), typeof(DateTime), typeof(DateTimePicker), default(DateTime));

        public static readonly BindableProperty TimeProperty = BindableProperty.Create(nameof(Time), typeof(TimeSpan), typeof(DateTimePicker), default(TimeSpan));

        public static readonly BindableProperty MinimumDateProperty = BindableProperty.Create(nameof(MinimumDate), typeof(DateTime), typeof(DateTimePicker), default(DateTime));

        public DateTimePicker()
        {
            InitializeComponent();
        }

        public TimeSpan Time
        {
            get => (TimeSpan)GetValue(TimeProperty);
            set => SetValue(TimeProperty, value);
        }

        public DateTime Date
        {
            get => (DateTime)GetValue(DateProperty);
            set => SetValue(DateProperty, value);
        }

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public DateTime MinimumDate
        {
            get => (DateTime)GetValue(MinimumDateProperty);
            set => SetValue(MinimumDateProperty, value);
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == nameof(Title))
            {
                lblTitle.Text = Title;
            }
            else if (propertyName == nameof(Date))
            {
                occursOn.Date = Date;
            }
            else if (propertyName == nameof(Time))
            {
                occursAt.Time = Time;
            }
            else if (propertyName == nameof(MinimumDate))
            {
                occursOn.MinimumDate = MinimumDate;
            }
        }
    }
}
