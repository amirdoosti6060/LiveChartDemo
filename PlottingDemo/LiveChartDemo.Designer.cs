namespace PlottingDemo
{
    partial class LiveChartDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            menuStrip1 = new MenuStrip();
            mnuInteraction = new ToolStripMenuItem();
            mnuZoomAll = new ToolStripMenuItem();
            mnuZoomX = new ToolStripMenuItem();
            mnuZoomY = new ToolStripMenuItem();
            mnuZoomBoth = new ToolStripMenuItem();
            mnuPan = new ToolStripMenuItem();
            mnuZoomBothPan = new ToolStripMenuItem();
            mnuZoomNone = new ToolStripMenuItem();
            legendToolStripMenuItem = new ToolStripMenuItem();
            mnuLegenHidden = new ToolStripMenuItem();
            mnuLegendTop = new ToolStripMenuItem();
            mnuLegendBottom = new ToolStripMenuItem();
            mnuLegendLeft = new ToolStripMenuItem();
            mnuLegendRight = new ToolStripMenuItem();
            axesToolStripMenuItem = new ToolStripMenuItem();
            mnuSeperator = new ToolStripMenuItem();
            mnuZeroLines = new ToolStripMenuItem();
            mnuSubSeperator = new ToolStripMenuItem();
            mnuTicks = new ToolStripMenuItem();
            mnuSubTicks = new ToolStripMenuItem();
            mnuSeries = new ToolStripMenuItem();
            mnuAnimationOnOff = new ToolStripMenuItem();
            mnuHoverable = new ToolStripMenuItem();
            mnuSeries1 = new ToolStripMenuItem();
            mnuSeries2 = new ToolStripMenuItem();
            dataToolStripMenuItem = new ToolStripMenuItem();
            mnu360Points = new ToolStripMenuItem();
            mnu3600Points = new ToolStripMenuItem();
            mnu36000Points = new ToolStripMenuItem();
            mnu360000Points = new ToolStripMenuItem();
            mnuLive = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // chart
            // 
            chart.Dock = DockStyle.Fill;
            chart.Location = new Point(0, 24);
            chart.Name = "chart";
            chart.Size = new Size(800, 426);
            chart.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuInteraction, legendToolStripMenuItem, axesToolStripMenuItem, mnuSeries, dataToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuInteraction
            // 
            mnuInteraction.DropDownItems.AddRange(new ToolStripItem[] { mnuZoomAll, mnuZoomX, mnuZoomY, mnuZoomBoth, mnuPan, mnuZoomBothPan, mnuZoomNone });
            mnuInteraction.Name = "mnuInteraction";
            mnuInteraction.Size = new Size(76, 20);
            mnuInteraction.Text = "Interaction";
            // 
            // mnuZoomAll
            // 
            mnuZoomAll.Name = "mnuZoomAll";
            mnuZoomAll.Size = new Size(180, 22);
            mnuZoomAll.Text = "Zoom All";
            mnuZoomAll.Click += mnuZoomAll_Click;
            // 
            // mnuZoomX
            // 
            mnuZoomX.Name = "mnuZoomX";
            mnuZoomX.Size = new Size(180, 22);
            mnuZoomX.Text = "Zoom X";
            mnuZoomX.Click += mnuZoomX_Click;
            // 
            // mnuZoomY
            // 
            mnuZoomY.Name = "mnuZoomY";
            mnuZoomY.Size = new Size(180, 22);
            mnuZoomY.Text = "Zoom Y";
            mnuZoomY.Click += mnuZoomY_Click;
            // 
            // mnuZoomBoth
            // 
            mnuZoomBoth.Name = "mnuZoomBoth";
            mnuZoomBoth.Size = new Size(180, 22);
            mnuZoomBoth.Text = "Zoom Both";
            mnuZoomBoth.Click += mnuZoomBoth_Click;
            // 
            // mnuPan
            // 
            mnuPan.Name = "mnuPan";
            mnuPan.Size = new Size(180, 22);
            mnuPan.Text = "Pan";
            mnuPan.Click += mnuPan_Click;
            // 
            // mnuZoomBothPan
            // 
            mnuZoomBothPan.Name = "mnuZoomBothPan";
            mnuZoomBothPan.Size = new Size(180, 22);
            mnuZoomBothPan.Text = "Zoom Both and Pan";
            mnuZoomBothPan.Click += mnuZoomBothPan_Click;
            // 
            // mnuZoomNone
            // 
            mnuZoomNone.Name = "mnuZoomNone";
            mnuZoomNone.Size = new Size(180, 22);
            mnuZoomNone.Text = "None";
            mnuZoomNone.Click += mnuZoomNone_Click;
            // 
            // legendToolStripMenuItem
            // 
            legendToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuLegenHidden, mnuLegendTop, mnuLegendBottom, mnuLegendLeft, mnuLegendRight });
            legendToolStripMenuItem.Name = "legendToolStripMenuItem";
            legendToolStripMenuItem.Size = new Size(58, 20);
            legendToolStripMenuItem.Text = "Legend";
            // 
            // mnuLegenHidden
            // 
            mnuLegenHidden.Name = "mnuLegenHidden";
            mnuLegenHidden.Size = new Size(114, 22);
            mnuLegenHidden.Text = "Hidden";
            mnuLegenHidden.Click += mnuLegenHidden_Click;
            // 
            // mnuLegendTop
            // 
            mnuLegendTop.Name = "mnuLegendTop";
            mnuLegendTop.Size = new Size(114, 22);
            mnuLegendTop.Text = "Top";
            mnuLegendTop.Click += mnuLegendTop_Click;
            // 
            // mnuLegendBottom
            // 
            mnuLegendBottom.Name = "mnuLegendBottom";
            mnuLegendBottom.Size = new Size(114, 22);
            mnuLegendBottom.Text = "Bottom";
            mnuLegendBottom.Click += mnuLegendBottom_Click;
            // 
            // mnuLegendLeft
            // 
            mnuLegendLeft.Name = "mnuLegendLeft";
            mnuLegendLeft.Size = new Size(114, 22);
            mnuLegendLeft.Text = "Left";
            mnuLegendLeft.Click += mnuLegendLeft_Click;
            // 
            // mnuLegendRight
            // 
            mnuLegendRight.Name = "mnuLegendRight";
            mnuLegendRight.Size = new Size(114, 22);
            mnuLegendRight.Text = "Right";
            mnuLegendRight.Click += mnuLegendRight_Click;
            // 
            // axesToolStripMenuItem
            // 
            axesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuSeperator, mnuZeroLines, mnuSubSeperator, mnuTicks, mnuSubTicks });
            axesToolStripMenuItem.Name = "axesToolStripMenuItem";
            axesToolStripMenuItem.Size = new Size(44, 20);
            axesToolStripMenuItem.Text = "Axes";
            // 
            // mnuSeperator
            // 
            mnuSeperator.Name = "mnuSeperator";
            mnuSeperator.Size = new Size(144, 22);
            mnuSeperator.Text = "Seperator";
            mnuSeperator.Click += mnuSeperator_Click;
            // 
            // mnuZeroLines
            // 
            mnuZeroLines.Name = "mnuZeroLines";
            mnuZeroLines.Size = new Size(144, 22);
            mnuZeroLines.Text = "Zero Lines";
            mnuZeroLines.Click += mnuZeroLines_Click;
            // 
            // mnuSubSeperator
            // 
            mnuSubSeperator.Name = "mnuSubSeperator";
            mnuSubSeperator.Size = new Size(144, 22);
            mnuSubSeperator.Text = "SubSeperator";
            mnuSubSeperator.Click += mnuSubSeperator_Click;
            // 
            // mnuTicks
            // 
            mnuTicks.Name = "mnuTicks";
            mnuTicks.Size = new Size(144, 22);
            mnuTicks.Text = "Ticks";
            mnuTicks.Click += mnuTicks_Click;
            // 
            // mnuSubTicks
            // 
            mnuSubTicks.Name = "mnuSubTicks";
            mnuSubTicks.Size = new Size(144, 22);
            mnuSubTicks.Text = "SubTicks";
            mnuSubTicks.Click += mnuSubTicks_Click;
            // 
            // mnuSeries
            // 
            mnuSeries.DropDownItems.AddRange(new ToolStripItem[] { mnuAnimationOnOff, mnuHoverable, mnuSeries1, mnuSeries2 });
            mnuSeries.Name = "mnuSeries";
            mnuSeries.Size = new Size(49, 20);
            mnuSeries.Text = "Series";
            // 
            // mnuAnimationOnOff
            // 
            mnuAnimationOnOff.Checked = true;
            mnuAnimationOnOff.CheckState = CheckState.Checked;
            mnuAnimationOnOff.Name = "mnuAnimationOnOff";
            mnuAnimationOnOff.Size = new Size(130, 22);
            mnuAnimationOnOff.Text = "Animation";
            mnuAnimationOnOff.Click += mnuAnimationOnOff_Click;
            // 
            // mnuHoverable
            // 
            mnuHoverable.Checked = true;
            mnuHoverable.CheckState = CheckState.Checked;
            mnuHoverable.Name = "mnuHoverable";
            mnuHoverable.Size = new Size(130, 22);
            mnuHoverable.Text = "Hoverable";
            mnuHoverable.Click += mnuHoverable_Click;
            // 
            // mnuSeries1
            // 
            mnuSeries1.Checked = true;
            mnuSeries1.CheckState = CheckState.Checked;
            mnuSeries1.Name = "mnuSeries1";
            mnuSeries1.Size = new Size(130, 22);
            mnuSeries1.Text = "Series 1";
            mnuSeries1.Click += mnuSeries1_Click;
            // 
            // mnuSeries2
            // 
            mnuSeries2.Checked = true;
            mnuSeries2.CheckState = CheckState.Checked;
            mnuSeries2.Name = "mnuSeries2";
            mnuSeries2.Size = new Size(130, 22);
            mnuSeries2.Text = "Series 2";
            mnuSeries2.Click += mnuSeries2_Click;
            // 
            // dataToolStripMenuItem
            // 
            dataToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnu360Points, mnu3600Points, mnu36000Points, mnu360000Points, mnuLive });
            dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            dataToolStripMenuItem.Size = new Size(43, 20);
            dataToolStripMenuItem.Text = "Data";
            // 
            // mnu360Points
            // 
            mnu360Points.Name = "mnu360Points";
            mnu360Points.Size = new Size(180, 22);
            mnu360Points.Text = "360 points";
            mnu360Points.Click += mnu360Points_Click;
            // 
            // mnu3600Points
            // 
            mnu3600Points.Name = "mnu3600Points";
            mnu3600Points.Size = new Size(180, 22);
            mnu3600Points.Text = "3600 points";
            mnu3600Points.Click += mnu3600Points_Click;
            // 
            // mnu36000Points
            // 
            mnu36000Points.Name = "mnu36000Points";
            mnu36000Points.Size = new Size(180, 22);
            mnu36000Points.Text = "36000 points";
            mnu36000Points.Click += mnu36000Points_Click;
            // 
            // mnu360000Points
            // 
            mnu360000Points.Name = "mnu360000Points";
            mnu360000Points.Size = new Size(180, 22);
            mnu360000Points.Text = "360000 points";
            mnu360000Points.Click += mnu360000Points_Click;
            // 
            // mnuLive
            // 
            mnuLive.Name = "mnuLive";
            mnuLive.Size = new Size(180, 22);
            mnuLive.Text = "Live";
            mnuLive.Click += mnuLive_Click;
            // 
            // LiveChartDemo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chart);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "LiveChartDemo";
            Text = "LiveChart Demo";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart chart;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuInteraction;
        private ToolStripMenuItem mnuZoomAll;
        private ToolStripMenuItem mnuZoomX;
        private ToolStripMenuItem mnuZoomY;
        private ToolStripMenuItem mnuZoomBoth;
        private ToolStripMenuItem mnuPan;
        private ToolStripMenuItem mnuZoomBothPan;
        private ToolStripMenuItem mnuZoomNone;
        private ToolStripMenuItem legendToolStripMenuItem;
        private ToolStripMenuItem mnuLegenHidden;
        private ToolStripMenuItem mnuLegendTop;
        private ToolStripMenuItem mnuLegendBottom;
        private ToolStripMenuItem mnuLegendLeft;
        private ToolStripMenuItem mnuLegendRight;
        private ToolStripMenuItem axesToolStripMenuItem;
        private ToolStripMenuItem mnuSeperator;
        private ToolStripMenuItem mnuZeroLines;
        private ToolStripMenuItem mnuSubSeperator;
        private ToolStripMenuItem mnuTicks;
        private ToolStripMenuItem mnuSubTicks;
        private ToolStripMenuItem mnuSeries;
        private ToolStripMenuItem mnuAnimationOnOff;
        private ToolStripMenuItem mnuHoverable;
        private ToolStripMenuItem mnuSeries1;
        private ToolStripMenuItem mnuSeries2;
        private ToolStripMenuItem dataToolStripMenuItem;
        private ToolStripMenuItem mnu360Points;
        private ToolStripMenuItem mnu3600Points;
        private ToolStripMenuItem mnu36000Points;
        private ToolStripMenuItem mnu360000Points;
        private ToolStripMenuItem mnuLive;
    }
}