﻿
namespace LinqLabs.作業
{
    partial class Frm作業_3
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_SearchClassGrade = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(426, 27);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(572, 277);
            this.chart1.TabIndex = 147;
            this.chart1.Text = "chart1";
            // 
            // btn_SearchClassGrade
            // 
            this.btn_SearchClassGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_SearchClassGrade.Location = new System.Drawing.Point(22, 27);
            this.btn_SearchClassGrade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_SearchClassGrade.Name = "btn_SearchClassGrade";
            this.btn_SearchClassGrade.Size = new System.Drawing.Size(333, 62);
            this.btn_SearchClassGrade.TabIndex = 146;
            this.btn_SearchClassGrade.Text = "搜尋 班級學生成績";
            this.btn_SearchClassGrade.UseVisualStyleBackColor = false;
            this.btn_SearchClassGrade.Click += new System.EventHandler(this.btn_SearchClassGrade_Click);
            // 
            // button37
            // 
            this.button37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button37.Location = new System.Drawing.Point(22, 109);
            this.button37.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(333, 62);
            this.button37.TabIndex = 145;
            this.button37.Text = "每個學生個人成績";
            this.button37.UseVisualStyleBackColor = false;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(22, 260);
            this.button33.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(333, 62);
            this.button33.TabIndex = 143;
            this.button33.Text = "自己分群";
            this.button33.UseVisualStyleBackColor = false;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // Frm作業_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 519);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn_SearchClassGrade);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.button33);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm作業_3";
            this.Text = "Frm作業_3";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_SearchClassGrade;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button33;
    }
}