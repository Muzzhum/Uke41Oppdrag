namespace Uke41Oppdrag
{
	partial class DiceStat
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
			this.StatChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.ThrowsNumUD = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.ThrowBtn = new System.Windows.Forms.Button();
			this.SidesNumUD = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.StatChart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ThrowsNumUD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SidesNumUD)).BeginInit();
			this.SuspendLayout();
			// 
			// StatChart
			// 
			chartArea1.Name = "ChartArea1";
			this.StatChart.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.StatChart.Legends.Add(legend1);
			this.StatChart.Location = new System.Drawing.Point(12, 12);
			this.StatChart.Name = "StatChart";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Antall";
			series1.Points.Add(dataPoint1);
			series1.Points.Add(dataPoint2);
			series1.Points.Add(dataPoint3);
			series1.Points.Add(dataPoint4);
			series1.Points.Add(dataPoint5);
			this.StatChart.Series.Add(series1);
			this.StatChart.Size = new System.Drawing.Size(300, 300);
			this.StatChart.TabIndex = 0;
			this.StatChart.Text = "chart1";
			// 
			// ThrowsNumUD
			// 
			this.ThrowsNumUD.Location = new System.Drawing.Point(401, 63);
			this.ThrowsNumUD.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
			this.ThrowsNumUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.ThrowsNumUD.Name = "ThrowsNumUD";
			this.ThrowsNumUD.Size = new System.Drawing.Size(93, 20);
			this.ThrowsNumUD.TabIndex = 1;
			this.ThrowsNumUD.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(319, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 26);
			this.label1.TabIndex = 2;
			this.label1.Text = "Kast terningen ganger";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// ThrowBtn
			// 
			this.ThrowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.ThrowBtn.Location = new System.Drawing.Point(322, 89);
			this.ThrowBtn.Name = "ThrowBtn";
			this.ThrowBtn.Size = new System.Drawing.Size(172, 42);
			this.ThrowBtn.TabIndex = 3;
			this.ThrowBtn.Text = "Kast!";
			this.ThrowBtn.UseVisualStyleBackColor = true;
			this.ThrowBtn.Click += new System.EventHandler(this.ThrowBtn_Click);
			// 
			// SidesNumUD
			// 
			this.SidesNumUD.Location = new System.Drawing.Point(401, 37);
			this.SidesNumUD.Maximum = int.MaxValue;
			this.SidesNumUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.SidesNumUD.Name = "SidesNumUD";
			this.SidesNumUD.Size = new System.Drawing.Size(93, 20);
			this.SidesNumUD.TabIndex = 4;
			this.SidesNumUD.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(319, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Antall sider";
			// 
			// DiceStat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(506, 323);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.SidesNumUD);
			this.Controls.Add(this.ThrowBtn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ThrowsNumUD);
			this.Controls.Add(this.StatChart);
			this.Name = "DiceStat";
			this.Text = "DiceStat";
			((System.ComponentModel.ISupportInitialize)(this.StatChart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ThrowsNumUD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SidesNumUD)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart StatChart;
		private System.Windows.Forms.NumericUpDown ThrowsNumUD;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button ThrowBtn;
		private System.Windows.Forms.NumericUpDown SidesNumUD;
		private System.Windows.Forms.Label label2;
	}
}