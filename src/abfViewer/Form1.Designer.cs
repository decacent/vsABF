﻿namespace abfViewer
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.scottPlotUC1 = new ScottPlot.ScottPlotUC();
            this.cbAllSweeps = new System.Windows.Forms.CheckBox();
            this.nudVertOffset = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudVertOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 576);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // scottPlotUC1
            // 
            this.scottPlotUC1.Location = new System.Drawing.Point(221, 12);
            this.scottPlotUC1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scottPlotUC1.Name = "scottPlotUC1";
            this.scottPlotUC1.Size = new System.Drawing.Size(823, 579);
            this.scottPlotUC1.TabIndex = 1;
            // 
            // cbAllSweeps
            // 
            this.cbAllSweeps.AutoSize = true;
            this.cbAllSweeps.Location = new System.Drawing.Point(222, 597);
            this.cbAllSweeps.Name = "cbAllSweeps";
            this.cbAllSweeps.Size = new System.Drawing.Size(103, 17);
            this.cbAllSweeps.TabIndex = 2;
            this.cbAllSweeps.Text = "show all sweeps";
            this.cbAllSweeps.UseVisualStyleBackColor = true;
            this.cbAllSweeps.CheckedChanged += new System.EventHandler(this.cbAllSweeps_CheckedChanged);
            // 
            // nudVertOffset
            // 
            this.nudVertOffset.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudVertOffset.Location = new System.Drawing.Point(438, 596);
            this.nudVertOffset.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudVertOffset.Name = "nudVertOffset";
            this.nudVertOffset.Size = new System.Drawing.Size(62, 20);
            this.nudVertOffset.TabIndex = 3;
            this.nudVertOffset.ValueChanged += new System.EventHandler(this.nudVertOffset_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "vertical offset:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 593);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "change folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 628);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudVertOffset);
            this.Controls.Add(this.cbAllSweeps);
            this.Controls.Add(this.scottPlotUC1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudVertOffset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private ScottPlot.ScottPlotUC scottPlotUC1;
        private System.Windows.Forms.CheckBox cbAllSweeps;
        private System.Windows.Forms.NumericUpDown nudVertOffset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

