namespace DataLabelsAtSpecificPoint;

public class ChartData
{
    public string Category { get; set; }
    public double Value { get; set; }

    // Flag to indicate whether to show data label for this point
    public bool ShowLabel { get; set; }

    public ChartData(string category, double value, bool showLabel)
    {
        Category = category;
        Value = value;
        ShowLabel = showLabel;
    }
}
