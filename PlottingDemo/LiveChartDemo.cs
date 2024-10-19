using LiveChartsCore;
using LiveChartsCore.Kernel.Sketches;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.Painting.Effects;
using SkiaSharp;
using System.Collections.ObjectModel;
using System.Data;

namespace PlottingDemo
{
    public partial class LiveChartDemo : Form
    {
        private RectangleF? selectionRectangle = null;
        private PointF? selectionStart = null;

        private static readonly SKColor s_gray = new(195, 195, 195);
        private static readonly SKColor s_gray1 = new(160, 160, 160);
        private static readonly SKColor s_gray2 = new(90, 90, 90);
        private static readonly SKColor s_dark3 = new(60, 60, 60);

        private SolidColorPaint ZeroPaint = new SolidColorPaint
        {
            Color = s_gray1,
            StrokeThickness = 2
        };

        private SolidColorPaint SeparatorsPaint = new SolidColorPaint
        {
            Color = s_gray,
            StrokeThickness = 1,
            PathEffect = new DashEffect(new float[] { 3, 3 })
        };

        private SolidColorPaint SubseparatorsPaint = new SolidColorPaint
        {
            Color = s_gray2,
            StrokeThickness = 0.5f
        };

        private SolidColorPaint TicksPaint = new SolidColorPaint
        {
            Color = s_gray,
            StrokeThickness = 1.5f
        };

        private SolidColorPaint SubticksPaint = new SolidColorPaint
        {
            Color = s_gray,
            StrokeThickness = 1
        };

        double[] series1Data = { 0 };
        double[] series2Data = { 0 };

        void ProvideData(int numData)
        {
            Task.Run(() =>
            {
                series1Data = Enumerable.Range(0, numData).Select(x => Math.Sin((double)x * Math.PI / 180.0)).ToArray();
                series2Data = Enumerable.Range(0, numData).Select(x => Math.Cos((double)x * Math.PI / 180.0)).ToArray();

                // Create chart
                chart.Series = new ISeries[]
                {
                    new LineSeries<double> { Values = series1Data, Name = "Series 1" },
                    new LineSeries<double> { Values = series2Data, Name = "Series 2" }
                };
            });
        }

        public LiveChartDemo()
        {
            InitializeComponent();

            ProvideData(360);
            /*
            // Create 1 million data points for two series
            double[] series1Data = Enumerable.Range(0, 360).Select(x => Math.Sin((double)x * Math.PI / 180.0)).ToArray();
            double[] series2Data = Enumerable.Range(0, 360).Select(x => Math.Cos((double)x * Math.PI / 180.0)).ToArray();

            // Create chart
            chart.Series = new ISeries[]
            {
                new LineSeries<double> { Values = series1Data, Name = "Series 1" },
                new LineSeries<double> { Values = series2Data, Name = "Series 2" }
            };
            */

            chart.XAxes = new Axis[]
            {
                new Axis
                {
                    Name = "X Axis",
                    NamePaint = new SolidColorPaint(s_dark3),
                    SubseparatorsCount = 9,
                }
            };

            chart.YAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Y Axis",
                    SubseparatorsCount = 9,
                }
            };

            chart.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.Both;
            chart.LegendPosition = LiveChartsCore.Measure.LegendPosition.Top;
        }

        private void mnuZoomAll_Click(object sender, EventArgs e)
        {
            ((Axis[])chart.XAxes)[0].MinLimit = null;
            ((Axis[])chart.XAxes)[0].MaxLimit = null;
            ((Axis[])chart.YAxes)[0].MinLimit = null;
            ((Axis[])chart.YAxes)[0].MaxLimit = null;
        }

        private void mnuZoomX_Click(object sender, EventArgs e)
        {
            chart.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.ZoomX;
        }

        private void mnuZoomY_Click(object sender, EventArgs e)
        {
            chart.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.ZoomY;
        }

        private void mnuZoomBoth_Click(object sender, EventArgs e)
        {
            chart.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.ZoomX | LiveChartsCore.Measure.ZoomAndPanMode.ZoomY;
        }

        private void mnuPan_Click(object sender, EventArgs e)
        {
            chart.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.PanX | LiveChartsCore.Measure.ZoomAndPanMode.PanY;
        }

        private void mnuZoomBothPan_Click(object sender, EventArgs e)
        {
            chart.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.Both;
        }

        private void mnuZoomNone_Click(object sender, EventArgs e)
        {
            chart.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.None;
        }

        private void mnuLegenHidden_Click(object sender, EventArgs e)
        {
            chart.LegendPosition = LiveChartsCore.Measure.LegendPosition.Hidden;
        }

        private void mnuLegendTop_Click(object sender, EventArgs e)
        {
            chart.LegendPosition = LiveChartsCore.Measure.LegendPosition.Top;
        }

        private void mnuLegendBottom_Click(object sender, EventArgs e)
        {
            chart.LegendPosition = LiveChartsCore.Measure.LegendPosition.Bottom;
        }

        private void mnuLegendLeft_Click(object sender, EventArgs e)
        {
            chart.LegendPosition = LiveChartsCore.Measure.LegendPosition.Left;
        }

        private void mnuLegendRight_Click(object sender, EventArgs e)
        {
            chart.LegendPosition = LiveChartsCore.Measure.LegendPosition.Right;
        }

        private void mnuSeperator_Click(object sender, EventArgs e)
        {
            mnuSeperator.Checked = !mnuSeperator.Checked;

            ((Axis[])chart.XAxes)[0].SeparatorsPaint = mnuSeperator.Checked ? SeparatorsPaint : null;
            ((Axis[])chart.YAxes)[0].SeparatorsPaint = mnuSeperator.Checked ? SeparatorsPaint : null;

            ((Axis[])chart.XAxes)[0].ShowSeparatorLines = mnuSeperator.Checked;
            ((Axis[])chart.YAxes)[0].ShowSeparatorLines = mnuSeperator.Checked;
        }

        private void mnuZeroLines_Click(object sender, EventArgs e)
        {
            mnuZeroLines.Checked = !mnuZeroLines.Checked;

            ((Axis[])chart.XAxes)[0].ZeroPaint = mnuZeroLines.Checked ? ZeroPaint : null;
            ((Axis[])chart.YAxes)[0].ZeroPaint = mnuZeroLines.Checked ? ZeroPaint : null;
        }

        private void mnuSubSeperator_Click(object sender, EventArgs e)
        {
            mnuSubSeperator.Checked = !mnuSubSeperator.Checked;

            ((Axis[])chart.XAxes)[0].SubseparatorsPaint = mnuSubSeperator.Checked ? SubseparatorsPaint : null;
            ((Axis[])chart.YAxes)[0].SubseparatorsPaint = mnuSubSeperator.Checked ? SubseparatorsPaint : null;
        }

        private void mnuTicks_Click(object sender, EventArgs e)
        {
            mnuTicks.Checked = !mnuTicks.Checked;

            ((Axis[])chart.XAxes)[0].TicksPaint = mnuTicks.Checked ? TicksPaint : null;
            ((Axis[])chart.YAxes)[0].TicksPaint = mnuTicks.Checked ? TicksPaint : null;
        }

        private void mnuSubTicks_Click(object sender, EventArgs e)
        {
            mnuSubTicks.Checked = !mnuSubTicks.Checked;

            ((Axis[])chart.XAxes)[0].SubticksPaint = mnuSubTicks.Checked ? SubticksPaint : null;
            ((Axis[])chart.YAxes)[0].SubticksPaint = mnuSubTicks.Checked ? SubticksPaint : null;
        }

        private void mnuAnimationOnOff_Click(object sender, EventArgs e)
        {
            mnuAnimationOnOff.Checked = !mnuAnimationOnOff.Checked;
            foreach (var ser in chart.Series)
                ser.AnimationsSpeed = mnuAnimationOnOff.Checked ? TimeSpan.FromMilliseconds(200) : TimeSpan.FromMilliseconds(0);
        }

        private void mnuHoverable_Click(object sender, EventArgs e)
        {
            mnuHoverable.Checked = !mnuHoverable.Checked;
            foreach (var ser in chart.Series)
                ser.IsHoverable = mnuHoverable.Checked;
        }

        private void mnuSeries1_Click(object sender, EventArgs e)
        {
            mnuSeries1.Checked = !mnuSeries1.Checked;
            ((ISeries[])chart.Series)[0].IsVisible = mnuSeries1.Checked;
        }

        private void mnuSeries2_Click(object sender, EventArgs e)
        {
            mnuSeries2.Checked = !mnuSeries2.Checked;
            ((ISeries[])chart.Series)[1].IsVisible = mnuSeries2.Checked;
        }

        private void mnu360Points_Click(object sender, EventArgs e)
        {
            ProvideData(360);
        }

        private void mnu3600Points_Click(object sender, EventArgs e)
        {
            ProvideData(3600);
        }

        private void mnu36000Points_Click(object sender, EventArgs e)
        {
            ProvideData(36000);
        }

        private void mnu360000Points_Click(object sender, EventArgs e)
        {
            ProvideData(360000);
        }

        private void mnuLive_Click(object sender, EventArgs e)
        {
            var liveData = new ObservableCollection<double> { 1, 2, 3, 4, 5 };

            chart.Series = new ISeries[]
            {
                    new LineSeries<double> { Values = liveData, Name = "Series 1" },
            };

            // Add new data points dynamically
            Task.Run(() =>
            {
                while (true)
                {
                    Invoke(new Action(() =>
                    {
                        liveData.Add(new Random().NextDouble() * 10);
                        if (liveData.Count > 50) liveData.RemoveAt(0); 
                    }));
                    Thread.Sleep(500);
                }
            });
        }
    }
}
