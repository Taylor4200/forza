﻿
namespace Forza_Mods_AIO.TabForms
{
    partial class StatsEditor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StatScanButton = new System.Windows.Forms.Button();
            this.ScanMarquee = new System.Windows.Forms.ProgressBar();
            this.StatsTable = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendButton = new System.Windows.Forms.Button();
            this.SendProgress = new System.Windows.Forms.ProgressBar();
            this.SendWorker = new System.ComponentModel.BackgroundWorker();
            this.FilterBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StatsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // StatScanButton
            // 
            this.StatScanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.StatScanButton.FlatAppearance.BorderSize = 0;
            this.StatScanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatScanButton.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatScanButton.ForeColor = System.Drawing.Color.White;
            this.StatScanButton.Location = new System.Drawing.Point(12, 8);
            this.StatScanButton.Name = "StatScanButton";
            this.StatScanButton.Size = new System.Drawing.Size(61, 28);
            this.StatScanButton.TabIndex = 1;
            this.StatScanButton.Text = "Scan";
            this.StatScanButton.UseVisualStyleBackColor = false;
            this.StatScanButton.Click += new System.EventHandler(this.StatScanButton_Click);
            this.StatScanButton.Leave += new System.EventHandler(this.StatScanButton_Leave);
            // 
            // ScanMarquee
            // 
            this.ScanMarquee.Location = new System.Drawing.Point(79, 13);
            this.ScanMarquee.Name = "ScanMarquee";
            this.ScanMarquee.Size = new System.Drawing.Size(148, 19);
            this.ScanMarquee.TabIndex = 2;
            // 
            // StatsTable
            // 
            this.StatsTable.AllowUserToAddRows = false;
            this.StatsTable.AllowUserToDeleteRows = false;
            this.StatsTable.AllowUserToResizeColumns = false;
            this.StatsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.StatsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StatsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StatsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.StatsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StatsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StatsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StatsTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.StatsTable.EnableHeadersVisualStyles = false;
            this.StatsTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(78)))));
            this.StatsTable.Location = new System.Drawing.Point(12, 41);
            this.StatsTable.Name = "StatsTable";
            this.StatsTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StatsTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StatsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.StatsTable.RowHeadersVisible = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.StatsTable.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.StatsTable.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Empty;
            this.StatsTable.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Empty;
            this.StatsTable.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StatsTable.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StatsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StatsTable.Size = new System.Drawing.Size(976, 393);
            this.StatsTable.TabIndex = 3;
            // 
            // Key
            // 
            this.Key.DataPropertyName = "Key";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.Key.DefaultCellStyle = dataGridViewCellStyle3;
            this.Key.HeaderText = "Stat/Setting Name";
            this.Key.MinimumWidth = 15;
            this.Key.Name = "Key";
            this.Key.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.DataPropertyName = "Value";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.Value.DefaultCellStyle = dataGridViewCellStyle4;
            this.Value.HeaderText = "Stat/Setting Value";
            this.Value.Name = "Value";
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.SendButton.FlatAppearance.BorderSize = 0;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(927, 8);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(61, 28);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // SendProgress
            // 
            this.SendProgress.Location = new System.Drawing.Point(773, 13);
            this.SendProgress.Name = "SendProgress";
            this.SendProgress.Size = new System.Drawing.Size(148, 19);
            this.SendProgress.TabIndex = 2;
            // 
            // SendWorker
            // 
            this.SendWorker.WorkerReportsProgress = true;
            this.SendWorker.WorkerSupportsCancellation = true;
            this.SendWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SendWorker_DoWork);
            this.SendWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.SendWorker_ProgressChanged);
            this.SendWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SendWorker_RunWorkerCompleted);
            // 
            // FilterBox
            // 
            this.FilterBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.FilterBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FilterBox.Font = new System.Drawing.Font("Open Sans", 10F);
            this.FilterBox.ForeColor = System.Drawing.Color.White;
            this.FilterBox.Location = new System.Drawing.Point(79, 13);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(100, 19);
            this.FilterBox.TabIndex = 4;
            this.FilterBox.Text = "Filter";
            this.FilterBox.TextChanged += new System.EventHandler(this.FilterBox_TextChanged);
            this.FilterBox.Enter += new System.EventHandler(this.FilterBox_Enter);
            this.FilterBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterBox_KeyDown);
            this.FilterBox.Leave += new System.EventHandler(this.FilterBox_Leave);
            // 
            // StatsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1000, 445);
            this.Controls.Add(this.FilterBox);
            this.Controls.Add(this.StatsTable);
            this.Controls.Add(this.SendProgress);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ScanMarquee);
            this.Controls.Add(this.StatScanButton);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatsEditor";
            this.Text = "StatsEditor";
            this.Load += new System.EventHandler(this.StatsEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StatsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StatScanButton;
        private System.Windows.Forms.ProgressBar ScanMarquee;
        private System.Windows.Forms.DataGridView StatsTable;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.ProgressBar SendProgress;
        public System.ComponentModel.BackgroundWorker SendWorker;
        private System.Windows.Forms.TextBox FilterBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}