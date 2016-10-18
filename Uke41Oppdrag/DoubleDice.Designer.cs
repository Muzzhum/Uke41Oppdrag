namespace Uke41Oppdrag
{
	partial class DoubleDice
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
			this.components = new System.ComponentModel.Container();
			this.Die1 = new System.Windows.Forms.PictureBox();
			this.Die2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.RoundsLbl = new System.Windows.Forms.Label();
			this.WinsLbl = new System.Windows.Forms.Label();
			this.ThrowBtn = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.WinMsgLbl = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.Die1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Die2)).BeginInit();
			this.SuspendLayout();
			// 
			// Die1
			// 
			this.Die1.Location = new System.Drawing.Point(12, 36);
			this.Die1.Name = "Die1";
			this.Die1.Size = new System.Drawing.Size(200, 200);
			this.Die1.TabIndex = 0;
			this.Die1.TabStop = false;
			// 
			// Die2
			// 
			this.Die2.Location = new System.Drawing.Point(218, 36);
			this.Die2.Name = "Die2";
			this.Die2.Size = new System.Drawing.Size(200, 200);
			this.Die2.TabIndex = 1;
			this.Die2.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label1.Location = new System.Drawing.Point(141, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Dobbel Terning";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
			this.label2.Location = new System.Drawing.Point(13, 243);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Antall runder";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
			this.label3.Location = new System.Drawing.Point(13, 269);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Antall seire";
			// 
			// RoundsLbl
			// 
			this.RoundsLbl.AutoSize = true;
			this.RoundsLbl.Location = new System.Drawing.Point(101, 245);
			this.RoundsLbl.Name = "RoundsLbl";
			this.RoundsLbl.Size = new System.Drawing.Size(0, 13);
			this.RoundsLbl.TabIndex = 5;
			this.RoundsLbl.Text = "0";
			// 
			// WinsLbl
			// 
			this.WinsLbl.AutoSize = true;
			this.WinsLbl.Location = new System.Drawing.Point(102, 271);
			this.WinsLbl.Name = "WinsLbl";
			this.WinsLbl.Size = new System.Drawing.Size(0, 13);
			this.WinsLbl.TabIndex = 6;
			this.WinsLbl.Text = "0";
			// 
			// ThrowBtn
			// 
			this.ThrowBtn.Location = new System.Drawing.Point(207, 245);
			this.ThrowBtn.Name = "ThrowBtn";
			this.ThrowBtn.Size = new System.Drawing.Size(108, 23);
			this.ThrowBtn.TabIndex = 7;
			this.ThrowBtn.Text = "Kast terningene!";
			this.ThrowBtn.UseVisualStyleBackColor = true;
			this.ThrowBtn.Click += new System.EventHandler(this.ThrowBtn_Click);
			// 
			// WinMsgLbl
			// 
			this.WinMsgLbl.AutoSize = true;
			this.WinMsgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WinMsgLbl.Location = new System.Drawing.Point(123, 309);
			this.WinMsgLbl.Name = "WinMsgLbl";
			this.WinMsgLbl.Size = new System.Drawing.Size(170, 37);
			this.WinMsgLbl.TabIndex = 8;
			this.WinMsgLbl.Text = "Gratulerer!";
			this.WinMsgLbl.Visible = false;
			// 
			// DoubleDice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 380);
			this.Controls.Add(this.WinMsgLbl);
			this.Controls.Add(this.ThrowBtn);
			this.Controls.Add(this.WinsLbl);
			this.Controls.Add(this.RoundsLbl);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Die2);
			this.Controls.Add(this.Die1);
			this.Name = "DoubleDice";
			this.Text = "DoubleDice";
			((System.ComponentModel.ISupportInitialize)(this.Die1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Die2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox Die1;
		private System.Windows.Forms.PictureBox Die2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label RoundsLbl;
		private System.Windows.Forms.Label WinsLbl;
		private System.Windows.Forms.Button ThrowBtn;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label WinMsgLbl;
	}
}