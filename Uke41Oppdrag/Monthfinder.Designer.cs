namespace Uke41Oppdrag
{
	partial class MonthFinder
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
			this.MonthNumUD = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.MonthOutputLbl = new System.Windows.Forms.Label();
			this.MonthCalcBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.MonthNumUD)).BeginInit();
			this.SuspendLayout();
			// 
			// MonthNumUD
			// 
			this.MonthNumUD.Location = new System.Drawing.Point(92, 33);
			this.MonthNumUD.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
			this.MonthNumUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.MonthNumUD.Name = "MonthNumUD";
			this.MonthNumUD.Size = new System.Drawing.Size(42, 20);
			this.MonthNumUD.TabIndex = 5;
			this.MonthNumUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Månedstall";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(38, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Månedsfinner";
			// 
			// MonthOutputLbl
			// 
			this.MonthOutputLbl.AutoSize = true;
			this.MonthOutputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MonthOutputLbl.Location = new System.Drawing.Point(12, 61);
			this.MonthOutputLbl.Name = "MonthOutputLbl";
			this.MonthOutputLbl.Size = new System.Drawing.Size(0, 16);
			this.MonthOutputLbl.TabIndex = 6;
			// 
			// MonthCalcBtn
			// 
			this.MonthCalcBtn.Location = new System.Drawing.Point(164, 33);
			this.MonthCalcBtn.Name = "MonthCalcBtn";
			this.MonthCalcBtn.Size = new System.Drawing.Size(75, 23);
			this.MonthCalcBtn.TabIndex = 7;
			this.MonthCalcBtn.Text = "Regn ut";
			this.MonthCalcBtn.UseVisualStyleBackColor = true;
			this.MonthCalcBtn.Click += new System.EventHandler(this.MonthCalcBtn_Click);
			// 
			// MonthFinder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(274, 108);
			this.Controls.Add(this.MonthCalcBtn);
			this.Controls.Add(this.MonthOutputLbl);
			this.Controls.Add(this.MonthNumUD);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MonthFinder";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Månedsfinner";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.MonthNumUD)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown MonthNumUD;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label MonthOutputLbl;
		private System.Windows.Forms.Button MonthCalcBtn;
	}
}