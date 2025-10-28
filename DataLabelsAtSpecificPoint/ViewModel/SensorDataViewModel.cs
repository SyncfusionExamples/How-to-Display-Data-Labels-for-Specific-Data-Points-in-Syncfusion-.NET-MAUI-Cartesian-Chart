using System.Collections.ObjectModel;

namespace DataLabelsAtSpecificPoint
{
    public class SensorDataViewModel
    {
        private readonly Random _rand = new();
        public ObservableCollection<ChartData> Data { get; set; } = new();
        public double Threshold { get; set; } = 75;

        public SensorDataViewModel()
        {
            // Generate richer initial dataset (no start/stop streaming)
            var now = DateTime.Now;
            // 60 points for the last minute
            for (int i = 60; i >= 1; i--)
            {
                var time = now.AddSeconds(-i).ToString("HH:mm:ss");
                var value = NextValue(50, 100);
                var show = value >= Threshold; // label only above threshold
                Data.Add(new ChartData(time, value, show));
            }
        }

        private double NextValue(double min, double max)
        {
            return Math.Round(min + _rand.NextDouble() * (max - min), 2);
        }
    }
}
