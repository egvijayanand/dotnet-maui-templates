namespace MauiApp._1.Models
{
    public partial class Event : ObservableObject
    {
        public Event() => Initialize();

#if Net10OrLater
        [ObservableProperty]
        public partial string Name { get; set; } = string.Empty;

        [ObservableProperty]
        public partial string Location { get; set; } = string.Empty;

        [ObservableProperty]
        public partial DateTime StartsAt { get; set; }

        [ObservableProperty]
        public partial DateTime EndsAt { get; set; }

        [ObservableProperty]
        public partial string Notes { get; set; } = string.Empty;
#else
        [ObservableProperty]
        private string _name = string.Empty;

        [ObservableProperty]
        private string _location = string.Empty;

        [ObservableProperty]
        private DateTime _startsAt;

        [ObservableProperty]
        private DateTime _endsAt;

        [ObservableProperty]
        private string _notes = string.Empty;
#endif

        private void Initialize()
        {
            var now = DateTime.Now;
            var today = new DateOnly(now.Year, now.Month, now.Day);

            StartsAt = (now.Hour, now.Minute) switch
            {
                (23, >= 30) => today.AddDays(1).ToDateTime(new TimeOnly()),
                (_, >= 30) => today.ToDateTime(new TimeOnly(now.Hour + 1, 0)),
                _ => today.ToDateTime(new TimeOnly(now.Hour, 30)),
            };

            EndsAt = StartsAt.AddMinutes(30); // interval
        }
    }
}
