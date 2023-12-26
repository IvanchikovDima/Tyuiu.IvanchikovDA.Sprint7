
namespace Tyuiu.IvanchikovDA.Sprint7.Project.V10
{
    partial class FormMain
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
            this.panelTop_IDA = new System.Windows.Forms.Panel();
            this.buttonAbout_IDA = new System.Windows.Forms.Button();
            this.buttonHelp_IDA = new System.Windows.Forms.Button();
            this.buttonDataInfo_IDA = new System.Windows.Forms.Button();
            this.panelLeft_IDA = new System.Windows.Forms.Panel();
            this.chartData_IDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelRight_IDA = new System.Windows.Forms.Panel();
            this.buttonSales_IDA = new System.Windows.Forms.Button();
            this.buttonTiming_IDA = new System.Windows.Forms.Button();
            this.groupBoxInfo_IDA = new System.Windows.Forms.GroupBox();
            this.labelInfo_IDA = new System.Windows.Forms.Label();
            this.panelTop_IDA.SuspendLayout();
            this.panelLeft_IDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartData_IDA)).BeginInit();
            this.panelRight_IDA.SuspendLayout();
            this.groupBoxInfo_IDA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_IDA
            // 
            this.panelTop_IDA.Controls.Add(this.buttonDataInfo_IDA);
            this.panelTop_IDA.Controls.Add(this.buttonHelp_IDA);
            this.panelTop_IDA.Controls.Add(this.buttonAbout_IDA);
            this.panelTop_IDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_IDA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_IDA.Name = "panelTop_IDA";
            this.panelTop_IDA.Size = new System.Drawing.Size(983, 100);
            this.panelTop_IDA.TabIndex = 0;
            // 
            // buttonAbout_IDA
            // 
            this.buttonAbout_IDA.Location = new System.Drawing.Point(31, 22);
            this.buttonAbout_IDA.Name = "buttonAbout_IDA";
            this.buttonAbout_IDA.Size = new System.Drawing.Size(148, 46);
            this.buttonAbout_IDA.TabIndex = 1;
            this.buttonAbout_IDA.Text = "О приложении";
            this.buttonAbout_IDA.UseVisualStyleBackColor = true;
            this.buttonAbout_IDA.Click += new System.EventHandler(this.buttonAbout_IDA_Click);
            // 
            // buttonHelp_IDA
            // 
            this.buttonHelp_IDA.Location = new System.Drawing.Point(195, 22);
            this.buttonHelp_IDA.Name = "buttonHelp_IDA";
            this.buttonHelp_IDA.Size = new System.Drawing.Size(142, 46);
            this.buttonHelp_IDA.TabIndex = 2;
            this.buttonHelp_IDA.Text = "Инструкция";
            this.buttonHelp_IDA.UseVisualStyleBackColor = true;
            this.buttonHelp_IDA.Click += new System.EventHandler(this.buttonHelp_IDA_Click);
            // 
            // buttonDataInfo_IDA
            // 
            this.buttonDataInfo_IDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDataInfo_IDA.Location = new System.Drawing.Point(738, 22);
            this.buttonDataInfo_IDA.Name = "buttonDataInfo_IDA";
            this.buttonDataInfo_IDA.Size = new System.Drawing.Size(209, 46);
            this.buttonDataInfo_IDA.TabIndex = 3;
            this.buttonDataInfo_IDA.Text = "Сделать заказ";
            this.buttonDataInfo_IDA.UseVisualStyleBackColor = true;
            this.buttonDataInfo_IDA.Click += new System.EventHandler(this.buttonDataInfo_IDA_Click);
            // 
            // panelLeft_IDA
            // 
            this.panelLeft_IDA.Controls.Add(this.groupBoxInfo_IDA);
            this.panelLeft_IDA.Controls.Add(this.buttonTiming_IDA);
            this.panelLeft_IDA.Controls.Add(this.buttonSales_IDA);
            this.panelLeft_IDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_IDA.Location = new System.Drawing.Point(0, 100);
            this.panelLeft_IDA.Name = "panelLeft_IDA";
            this.panelLeft_IDA.Size = new System.Drawing.Size(195, 436);
            this.panelLeft_IDA.TabIndex = 1;
            // 
            // chartData_IDA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartData_IDA.ChartAreas.Add(chartArea1);
            this.chartData_IDA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartData_IDA.Legends.Add(legend1);
            this.chartData_IDA.Location = new System.Drawing.Point(0, 0);
            this.chartData_IDA.Name = "chartData_IDA";
            this.chartData_IDA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartData_IDA.Series.Add(series1);
            this.chartData_IDA.Size = new System.Drawing.Size(788, 436);
            this.chartData_IDA.TabIndex = 0;
            this.chartData_IDA.Text = "chart1";
            // 
            // panelRight_IDA
            // 
            this.panelRight_IDA.Controls.Add(this.chartData_IDA);
            this.panelRight_IDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_IDA.Location = new System.Drawing.Point(195, 100);
            this.panelRight_IDA.Name = "panelRight_IDA";
            this.panelRight_IDA.Size = new System.Drawing.Size(788, 436);
            this.panelRight_IDA.TabIndex = 2;
            // 
            // buttonSales_IDA
            // 
            this.buttonSales_IDA.Location = new System.Drawing.Point(31, 26);
            this.buttonSales_IDA.Name = "buttonSales_IDA";
            this.buttonSales_IDA.Size = new System.Drawing.Size(136, 58);
            this.buttonSales_IDA.TabIndex = 0;
            this.buttonSales_IDA.Text = "График доставок за 2023";
            this.buttonSales_IDA.UseVisualStyleBackColor = true;
            this.buttonSales_IDA.Click += new System.EventHandler(this.buttonSales_IDA_Click);
            // 
            // buttonTiming_IDA
            // 
            this.buttonTiming_IDA.Location = new System.Drawing.Point(31, 90);
            this.buttonTiming_IDA.Name = "buttonTiming_IDA";
            this.buttonTiming_IDA.Size = new System.Drawing.Size(136, 62);
            this.buttonTiming_IDA.TabIndex = 1;
            this.buttonTiming_IDA.Text = "График популярности заказов";
            this.buttonTiming_IDA.UseVisualStyleBackColor = true;
            this.buttonTiming_IDA.Click += new System.EventHandler(this.buttonTiming_IDA_Click);
            // 
            // groupBoxInfo_IDA
            // 
            this.groupBoxInfo_IDA.Controls.Add(this.labelInfo_IDA);
            this.groupBoxInfo_IDA.Location = new System.Drawing.Point(3, 184);
            this.groupBoxInfo_IDA.Name = "groupBoxInfo_IDA";
            this.groupBoxInfo_IDA.Size = new System.Drawing.Size(189, 249);
            this.groupBoxInfo_IDA.TabIndex = 2;
            this.groupBoxInfo_IDA.TabStop = false;
            this.groupBoxInfo_IDA.Text = "O НАС";
            // 
            // labelInfo_IDA
            // 
            this.labelInfo_IDA.AutoSize = true;
            this.labelInfo_IDA.Location = new System.Drawing.Point(2, 18);
            this.labelInfo_IDA.Name = "labelInfo_IDA";
            this.labelInfo_IDA.Size = new System.Drawing.Size(184, 102);
            this.labelInfo_IDA.TabIndex = 0;
            this.labelInfo_IDA.Text = "Работаем для вас с 2019 \r\nгода. Домашние продукты\r\nвысокого качества.Самые \r\nлучш" +
    "ие поставщики из \r\nТюмени. Сделайте заказ \r\nу нас! ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 536);
            this.Controls.Add(this.panelRight_IDA);
            this.Controls.Add(this.panelLeft_IDA);
            this.Controls.Add(this.panelTop_IDA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЗАКАЗ ДОМАШНИХ ПРОДУКТОВ В ТЮМЕНИ";
            this.panelTop_IDA.ResumeLayout(false);
            this.panelLeft_IDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartData_IDA)).EndInit();
            this.panelRight_IDA.ResumeLayout(false);
            this.groupBoxInfo_IDA.ResumeLayout(false);
            this.groupBoxInfo_IDA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_IDA;
        private System.Windows.Forms.Button buttonDataInfo_IDA;
        private System.Windows.Forms.Button buttonHelp_IDA;
        private System.Windows.Forms.Button buttonAbout_IDA;
        private System.Windows.Forms.Panel panelLeft_IDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData_IDA;
        private System.Windows.Forms.Panel panelRight_IDA;
        private System.Windows.Forms.Button buttonTiming_IDA;
        private System.Windows.Forms.Button buttonSales_IDA;
        private System.Windows.Forms.GroupBox groupBoxInfo_IDA;
        private System.Windows.Forms.Label labelInfo_IDA;
    }
}

