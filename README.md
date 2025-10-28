# How to Display Data Labels for Specific Points in .NET MAUI Cartesian Chart

This sample demonstrates how to show data labels only for selected data points in a .NET MAUI SfCartesianChart using Syncfusion controls. This technique helps reduce visual clutter and improves readability, especially in charts with many data points.

## What You'll Learn

- How to associate each data point with a ShowLabel property to control label visibility.
- How to apply business logic to determine which points should display labels.
- How to bind data to the chart and use a `LabelTemplate` for conditional label rendering.

## Key Steps

1. **Add a ShowLabel Property** - Each data point includes a flag to indicate whether its label should be shown.

2. **Apply Business Logic** - Set ShowLabel based on conditions like value thresholds or specific indices.

3. **Bind Data to Chart** - Connect your data source to the chart and enable data labels.

4. **Use a LabelTemplate** - Customize label appearance and visibility using data binding.

## Benefits

- Keeps the chart clean and focused.
- Adapts easily to different scenarios (e.g., highlight outliers).
- Ensures UI reflects business logic dynamically.

## Output:

<img width="1919" height="926" alt="Screenshot 2025-10-27 174441" src="https://github.com/user-attachments/assets/9681ab22-c607-47b9-b408-1515c38e3d2f" />

## Troubleshooting
If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

For a step-by-step procedure, refer to the [How to display data labels for specific data points in .NET MAUI Cartesian Chart?](https://support.syncfusion.com/kb/article/21702/how-to-display-data-labels-for-specific-data-points-in-net-maui-cartesian-chart) KB article.
