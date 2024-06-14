namespace TestMySQL
{
	partial class MainForm
	{
		/// <summary>
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Pulire le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Codice generato da Progettazione Windows Form

		/// <summary>
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent()
		{
			this.btConnect = new System.Windows.Forms.Button();
			this.btDisconnect = new System.Windows.Forms.Button();
			this.btStat = new System.Windows.Forms.Button();
			this.btSqlInsert = new System.Windows.Forms.Button();
			this.btSqlDelete = new System.Windows.Forms.Button();
			this.btSqlCount = new System.Windows.Forms.Button();
			this.btSqlQuery = new System.Windows.Forms.Button();
			this.btTab1 = new System.Windows.Forms.Button();
			this.btTab2 = new System.Windows.Forms.Button();
			this.btOpenQ = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tsslTable = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslStat = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslForms = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btConnect
			// 
			this.btConnect.Location = new System.Drawing.Point(12, 12);
			this.btConnect.Name = "btConnect";
			this.btConnect.Size = new System.Drawing.Size(75, 23);
			this.btConnect.TabIndex = 0;
			this.btConnect.Text = "Connect";
			this.btConnect.UseVisualStyleBackColor = true;
			this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
			// 
			// btDisconnect
			// 
			this.btDisconnect.Location = new System.Drawing.Point(12, 67);
			this.btDisconnect.Name = "btDisconnect";
			this.btDisconnect.Size = new System.Drawing.Size(75, 23);
			this.btDisconnect.TabIndex = 1;
			this.btDisconnect.Text = "Disconnect";
			this.btDisconnect.UseVisualStyleBackColor = true;
			this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
			// 
			// btStat
			// 
			this.btStat.Location = new System.Drawing.Point(12, 38);
			this.btStat.Name = "btStat";
			this.btStat.Size = new System.Drawing.Size(75, 23);
			this.btStat.TabIndex = 2;
			this.btStat.Text = "GetStatus";
			this.btStat.UseVisualStyleBackColor = true;
			this.btStat.Click += new System.EventHandler(this.btStat_Click);
			// 
			// btSqlInsert
			// 
			this.btSqlInsert.Location = new System.Drawing.Point(115, 125);
			this.btSqlInsert.Name = "btSqlInsert";
			this.btSqlInsert.Size = new System.Drawing.Size(100, 23);
			this.btSqlInsert.TabIndex = 3;
			this.btSqlInsert.Text = "SQL Insert";
			this.btSqlInsert.UseVisualStyleBackColor = true;
			this.btSqlInsert.Click += new System.EventHandler(this.btSqlInsert_Click);
			// 
			// btSqlDelete
			// 
			this.btSqlDelete.Location = new System.Drawing.Point(115, 154);
			this.btSqlDelete.Name = "btSqlDelete";
			this.btSqlDelete.Size = new System.Drawing.Size(100, 23);
			this.btSqlDelete.TabIndex = 4;
			this.btSqlDelete.Text = "SQL Delete";
			this.btSqlDelete.UseVisualStyleBackColor = true;
			this.btSqlDelete.Click += new System.EventHandler(this.btSqlDelete_Click);
			// 
			// btSqlCount
			// 
			this.btSqlCount.Location = new System.Drawing.Point(115, 183);
			this.btSqlCount.Name = "btSqlCount";
			this.btSqlCount.Size = new System.Drawing.Size(100, 23);
			this.btSqlCount.TabIndex = 5;
			this.btSqlCount.Text = "SQL Count";
			this.btSqlCount.UseVisualStyleBackColor = true;
			this.btSqlCount.Click += new System.EventHandler(this.btSqlCount_Click);
			// 
			// btSqlQuery
			// 
			this.btSqlQuery.Location = new System.Drawing.Point(115, 212);
			this.btSqlQuery.Name = "btSqlQuery";
			this.btSqlQuery.Size = new System.Drawing.Size(100, 23);
			this.btSqlQuery.TabIndex = 6;
			this.btSqlQuery.Text = "SQL Query";
			this.btSqlQuery.UseVisualStyleBackColor = true;
			this.btSqlQuery.Click += new System.EventHandler(this.btSqlQuery_Click);
			// 
			// btTab1
			// 
			this.btTab1.Location = new System.Drawing.Point(12, 125);
			this.btTab1.Name = "btTab1";
			this.btTab1.Size = new System.Drawing.Size(75, 23);
			this.btTab1.TabIndex = 7;
			this.btTab1.Text = "Città";
			this.btTab1.UseVisualStyleBackColor = true;
			this.btTab1.Click += new System.EventHandler(this.btTab1_Click);
			// 
			// btTab2
			// 
			this.btTab2.Location = new System.Drawing.Point(12, 148);
			this.btTab2.Name = "btTab2";
			this.btTab2.Size = new System.Drawing.Size(75, 23);
			this.btTab2.TabIndex = 8;
			this.btTab2.Text = "Utenti";
			this.btTab2.UseVisualStyleBackColor = true;
			this.btTab2.Click += new System.EventHandler(this.btTab2_Click);
			// 
			// btOpenQ
			// 
			this.btOpenQ.Location = new System.Drawing.Point(93, 12);
			this.btOpenQ.Name = "btOpenQ";
			this.btOpenQ.Size = new System.Drawing.Size(75, 23);
			this.btOpenQ.TabIndex = 11;
			this.btOpenQ.Text = "Open query";
			this.btOpenQ.UseVisualStyleBackColor = true;
			this.btOpenQ.Click += new System.EventHandler(this.btOpenQ_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTable,
            this.tsslStat,
            this.tsslForms});
			this.statusStrip1.Location = new System.Drawing.Point(0, 276);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(579, 22);
			this.statusStrip1.TabIndex = 12;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// tssl1
			// 
			this.tsslTable.Name = "tsslTable";
			this.tsslTable.Size = new System.Drawing.Size(118, 17);
			this.tsslTable.Text = "toolStripStatusLabel1";
			// 
			// tssl2
			// 
			this.tsslStat.Name = "tsslStat";
			this.tsslStat.Size = new System.Drawing.Size(118, 17);
			this.tsslStat.Text = "toolStripStatusLabel2";
			// 
			// tsslForms
			// 
			this.tsslForms.Name = "tsslForms";
			this.tsslForms.Size = new System.Drawing.Size(118, 17);
			this.tsslForms.Text = "toolStripStatusLabel1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(579, 298);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.btOpenQ);
			this.Controls.Add(this.btTab2);
			this.Controls.Add(this.btTab1);
			this.Controls.Add(this.btSqlQuery);
			this.Controls.Add(this.btSqlCount);
			this.Controls.Add(this.btSqlDelete);
			this.Controls.Add(this.btSqlInsert);
			this.Controls.Add(this.btStat);
			this.Controls.Add(this.btDisconnect);
			this.Controls.Add(this.btConnect);
			this.Name = "MainForm";
			this.Text = "MySQL test";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btConnect;
		private System.Windows.Forms.Button btDisconnect;
		private System.Windows.Forms.Button btStat;
		private System.Windows.Forms.Button btSqlInsert;
		private System.Windows.Forms.Button btSqlDelete;
		private System.Windows.Forms.Button btSqlCount;
		private System.Windows.Forms.Button btSqlQuery;
		private System.Windows.Forms.Button btTab1;
		private System.Windows.Forms.Button btTab2;
		private System.Windows.Forms.Button btOpenQ;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel tsslTable;
		private System.Windows.Forms.ToolStripStatusLabel tsslStat;
		private System.Windows.Forms.ToolStripStatusLabel tsslForms;
	}
}

