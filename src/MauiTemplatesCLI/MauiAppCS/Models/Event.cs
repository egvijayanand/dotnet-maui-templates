namespace MauiApp._1.Models
{
    public partial class Event : ObservableObject
    {
        public Event() => Initialize();

        [ObservableProperty]
        private string _name = string.Empty;

        [ObservableProperty]
        private string location = string.Empty;

        [ObservableProperty]
        private DateTime _startsAt;

        [ObservableProperty]
        private DateTime _endsAt;

        [ObservableProperty]
        private string _notes = string.Empty;

        private void Initialize()
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            var tomorrow = today.AddDays(1);
            var now = DateTime.Now;

            if (now.Minute < 30)
            {
                if (now.Hour < 23)
                {
                    StartsAt = new DateTime(today, new TimeOnly(now.Hour, 30, 0));
                    EndsAt = new DateTime(today, new TimeOnly(now.Hour + 1, 0, 0));
                }
                else
                {
                    StartsAt = new DateTime(today, new TimeOnly(now.Hour, 30, 0));
                    EndsAt = new DateTime(tomorrow, new TimeOnly(0, 0, 0));
                }
            }
            else
            {
                if (now.Hour < 23)
                {
                    StartsAt = new DateTime(today, new TimeOnly(now.Hour + 1, 0, 0));
                    EndsAt = new DateTime(today, new TimeOnly(now.Hour + 1, 30, 0));
                }
                else
                {
                    StartsAt = new DateTime(tomorrow, new TimeOnly(0, 0, 0));
                    EndsAt = new DateTime(tomorrow, new TimeOnly(0, 30, 0));
                }
            }
        }
    }
}
