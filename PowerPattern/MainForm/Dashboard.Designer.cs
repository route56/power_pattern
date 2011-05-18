namespace MainForm
{
	partial class Dashboard
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
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label1 = new System.Windows.Forms.Label();
			this.lblBatteryStatusPercent = new System.Windows.Forms.Label();
			this.lblPowerStatus = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblTimeFullyCharged = new System.Windows.Forms.Label();
			this.lblPredictionToCharge = new System.Windows.Forms.Label();
			this.lblTimeLeftFullyDischarged = new System.Windows.Forms.Label();
			this.lblPredictionToDischarge = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.batteryStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.powerStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.standbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataUnitBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar1.Location = new System.Drawing.Point(11, 28);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(438, 23);
			this.progressBar1.TabIndex = 1;
			this.progressBar1.Value = 60;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Battery status";
			// 
			// lblBatteryStatusPercent
			// 
			this.lblBatteryStatusPercent.AutoSize = true;
			this.lblBatteryStatusPercent.Location = new System.Drawing.Point(103, 9);
			this.lblBatteryStatusPercent.Name = "lblBatteryStatusPercent";
			this.lblBatteryStatusPercent.Size = new System.Drawing.Size(33, 13);
			this.lblBatteryStatusPercent.TabIndex = 3;
			this.lblBatteryStatusPercent.Text = "100%";
			// 
			// lblPowerStatus
			// 
			this.lblPowerStatus.AutoSize = true;
			this.lblPowerStatus.Location = new System.Drawing.Point(103, 68);
			this.lblPowerStatus.Name = "lblPowerStatus";
			this.lblPowerStatus.Size = new System.Drawing.Size(49, 13);
			this.lblPowerStatus.TabIndex = 5;
			this.lblPowerStatus.Text = "Charging";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Power status";
			// 
			// lblTimeFullyCharged
			// 
			this.lblTimeFullyCharged.AutoSize = true;
			this.lblTimeFullyCharged.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTimeFullyCharged.Location = new System.Drawing.Point(228, 98);
			this.lblTimeFullyCharged.Name = "lblTimeFullyCharged";
			this.lblTimeFullyCharged.Size = new System.Drawing.Size(36, 16);
			this.lblTimeFullyCharged.TabIndex = 7;
			this.lblTimeFullyCharged.Text = "2:20";
			// 
			// lblPredictionToCharge
			// 
			this.lblPredictionToCharge.AutoSize = true;
			this.lblPredictionToCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPredictionToCharge.Location = new System.Drawing.Point(12, 100);
			this.lblPredictionToCharge.Name = "lblPredictionToCharge";
			this.lblPredictionToCharge.Size = new System.Drawing.Size(194, 13);
			this.lblPredictionToCharge.TabIndex = 6;
			this.lblPredictionToCharge.Text = "Time needed to get fully charged";
			// 
			// lblTimeLeftFullyDischarged
			// 
			this.lblTimeLeftFullyDischarged.AutoSize = true;
			this.lblTimeLeftFullyDischarged.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTimeLeftFullyDischarged.Location = new System.Drawing.Point(228, 125);
			this.lblTimeLeftFullyDischarged.Name = "lblTimeLeftFullyDischarged";
			this.lblTimeLeftFullyDischarged.Size = new System.Drawing.Size(36, 16);
			this.lblTimeLeftFullyDischarged.TabIndex = 9;
			this.lblTimeLeftFullyDischarged.Text = "1:20";
			// 
			// lblPredictionToDischarge
			// 
			this.lblPredictionToDischarge.AutoSize = true;
			this.lblPredictionToDischarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPredictionToDischarge.Location = new System.Drawing.Point(12, 127);
			this.lblPredictionToDischarge.Name = "lblPredictionToDischarge";
			this.lblPredictionToDischarge.Size = new System.Drawing.Size(186, 13);
			this.lblPredictionToDischarge.TabIndex = 8;
			this.lblPredictionToDischarge.Text = "Time left to get fully discharged";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeStampDataGridViewTextBoxColumn,
            this.batteryStatusDataGridViewTextBoxColumn,
            this.powerStatusDataGridViewTextBoxColumn,
            this.standbyDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.dataUnitBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(11, 172);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(438, 260);
			this.dataGridView1.TabIndex = 10;
			// 
			// timeStampDataGridViewTextBoxColumn
			// 
			this.timeStampDataGridViewTextBoxColumn.DataPropertyName = "TimeStamp";
			this.timeStampDataGridViewTextBoxColumn.HeaderText = "TimeStamp";
			this.timeStampDataGridViewTextBoxColumn.Name = "timeStampDataGridViewTextBoxColumn";
			this.timeStampDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// batteryStatusDataGridViewTextBoxColumn
			// 
			this.batteryStatusDataGridViewTextBoxColumn.DataPropertyName = "BatteryStatus";
			this.batteryStatusDataGridViewTextBoxColumn.HeaderText = "BatteryStatus";
			this.batteryStatusDataGridViewTextBoxColumn.Name = "batteryStatusDataGridViewTextBoxColumn";
			this.batteryStatusDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// powerStatusDataGridViewTextBoxColumn
			// 
			this.powerStatusDataGridViewTextBoxColumn.DataPropertyName = "PowerStatus";
			this.powerStatusDataGridViewTextBoxColumn.HeaderText = "PowerStatus";
			this.powerStatusDataGridViewTextBoxColumn.Name = "powerStatusDataGridViewTextBoxColumn";
			this.powerStatusDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// standbyDataGridViewTextBoxColumn
			// 
			this.standbyDataGridViewTextBoxColumn.DataPropertyName = "Standby";
			this.standbyDataGridViewTextBoxColumn.HeaderText = "Standby";
			this.standbyDataGridViewTextBoxColumn.Name = "standbyDataGridViewTextBoxColumn";
			this.standbyDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dataUnitBindingSource
			// 
			this.dataUnitBindingSource.DataSource = typeof(MainForm.DataUnit);
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.WorkerSupportsCancellation = true;
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(463, 444);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.lblTimeLeftFullyDischarged);
			this.Controls.Add(this.lblPredictionToDischarge);
			this.Controls.Add(this.lblTimeFullyCharged);
			this.Controls.Add(this.lblPredictionToCharge);
			this.Controls.Add(this.lblPowerStatus);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblBatteryStatusPercent);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.progressBar1);
			this.Name = "Dashboard";
			this.Text = "Power Pattern";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataUnitBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblBatteryStatusPercent;
		private System.Windows.Forms.Label lblPowerStatus;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblTimeFullyCharged;
		private System.Windows.Forms.Label lblPredictionToCharge;
		private System.Windows.Forms.Label lblTimeLeftFullyDischarged;
		private System.Windows.Forms.Label lblPredictionToDischarge;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn batteryStatusDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn powerStatusDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn standbyDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource dataUnitBindingSource;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}

