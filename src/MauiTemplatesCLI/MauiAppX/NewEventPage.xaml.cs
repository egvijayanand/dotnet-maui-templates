namespace MauiApp1
{
    public partial class NewEventPage : ContentPage
    {
        public NewEventPage()
        {
            InitializeComponent();
            InitEvent();
        }

        private void InitEvent()
        {
            var today = DateTime.Today;
            var tomorrow = today.AddDays(1);
            var now = DateTime.Now;

            if (now.Minute < 30)
            {
                if (now.Hour < 23)
                {
                    start.Date = today;
                    start.Time = new TimeSpan(now.Hour, 30, 0);
                    end.Date = today;
                    end.Time = new TimeSpan(now.Hour + 1, 0, 0);
                }
                else
                {
                    start.Date = today;
                    start.Time = new TimeSpan(now.Hour, 30, 0);
                    end.Date = tomorrow;
                    end.Time = new TimeSpan(0, 0, 0);

                }
            }
            else
            {
                if (now.Hour < 23)
                {
                    start.Date = today;
                    start.Time = new TimeSpan(now.Hour + 1, 0, 0);
                    end.Date = today;
                    end.Time = new TimeSpan(now.Hour + 1, 30, 0);
                }
                else
                {
                    start.Date = tomorrow;
                    start.Time = new TimeSpan(0, 0, 0);
                    end.Date = tomorrow;
                    end.Time = new TimeSpan(0, 30, 0);
                }
            }
        }

        private async void OnSave(object sender, EventArgs e)
        {
            await Application.Current?.MainPage?.DisplayAlert("Add Event", "Save the event details to a data store.", "OK");
#if (Hierarchical || Tabbed)
            await Navigation.PopModalAsync();
#else
            await Shell.Current.GoToAsync("..");
#endif
        }

        private async void OnCancel(object sender, EventArgs e)
        {
#if (Hierarchical || Tabbed)
            await Navigation.PopModalAsync();
#else
            await Shell.Current.GoToAsync("..");
#endif
        }
    }
}
