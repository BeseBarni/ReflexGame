

namespace ReflexGame;

public partial class MainPage : ContentPage
{
	int count = 0;
	Random r = new Random();
	private int time = 60;
	private bool isRunning = false;
    public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(Object sender, EventArgs e)
	{
		count++;

		countLabel.Text = $"Count: {count}";
		
	}
	private async void OnTimerStart(Object sender, EventArgs e)
	{
		isRunning = true;
		time = 10;
		while (isRunning)
		{
			if (time == 1)
			{
				isRunning = false;

			}
			time -= 1;
			SetTime();
            var x = r.Next(-((int)layout.Bounds.X - (int)CounterBtn.Width - 10), (int)layout.Bounds.X - (int)CounterBtn.Width - 10);
            var y = r.Next(-((int)layout.Bounds.Y - (int)CounterBtn.Height - 10), (int)layout.Bounds.Y - (int)CounterBtn.Height - 10);
            CounterBtn.TranslateTo(x, y);
            await Task.Delay(1000);
		}
	}

	private void SetTime()
	{
		timeLabel.Text = String.Format("Elapsed time: {0}", time);
	}
}

