namespace Uke41Oppdrag
{
	partial class Menu
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
			this.MonthfinderBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.DiceStatBtn = new System.Windows.Forms.Button();
			this.DoubleDiceBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// MonthfinderBtn
			// 
			this.MonthfinderBtn.Location = new System.Drawing.Point(12, 60);
			this.MonthfinderBtn.Name = "MonthfinderBtn";
			this.MonthfinderBtn.Size = new System.Drawing.Size(88, 23);
			this.MonthfinderBtn.TabIndex = 0;
			this.MonthfinderBtn.Text = "Månedsfinner";
			this.MonthfinderBtn.UseVisualStyleBackColor = true;
			this.MonthfinderBtn.Click += new System.EventHandler(this.MonthfinderBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(303, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "Velg et program å starte";
			// 
			// DiceStatBtn
			// 
			this.DiceStatBtn.Location = new System.Drawing.Point(227, 60);
			this.DiceStatBtn.Name = "DiceStatBtn";
			this.DiceStatBtn.Size = new System.Drawing.Size(88, 23);
			this.DiceStatBtn.TabIndex = 2;
			this.DiceStatBtn.Text = "Terningstatistikk";
			this.DiceStatBtn.UseVisualStyleBackColor = true;
			this.DiceStatBtn.Click += new System.EventHandler(this.DiceStatBtn_Click);
			// 
			// DoubleDiceBtn
			// 
			this.DoubleDiceBtn.Location = new System.Drawing.Point(122, 60);
			this.DoubleDiceBtn.Name = "DoubleDiceBtn";
			this.DoubleDiceBtn.Size = new System.Drawing.Size(88, 23);
			this.DoubleDiceBtn.TabIndex = 3;
			this.DoubleDiceBtn.Text = "Dobbel Terning";
			this.DoubleDiceBtn.UseVisualStyleBackColor = true;
			this.DoubleDiceBtn.Click += new System.EventHandler(this.DoubleDiceBtn_Click);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 100);
			this.Controls.Add(this.DoubleDiceBtn);
			this.Controls.Add(this.DiceStatBtn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.MonthfinderBtn);
			this.Name = "Menu";
			this.Text = "Velg et program";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button MonthfinderBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button DiceStatBtn;
		private System.Windows.Forms.Button DoubleDiceBtn;
	}
}

