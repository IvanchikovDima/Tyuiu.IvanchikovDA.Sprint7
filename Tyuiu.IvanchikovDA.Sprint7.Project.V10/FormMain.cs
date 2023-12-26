using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IvanchikovDA.Sprint7.Project.V10.Lib;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.IvanchikovDA.Sprint7.Project.V10
{
    public partial class FormMain : Form
    {
        SalesData sd = new SalesData();
        private SalesDataCollection salesDataCollection;
        YearsData yd = new YearsData();
        private YearsDataCollection yearsDataCollection;
        public FormMain()
        {
            InitializeComponent();
            salesDataCollection = new SalesDataCollection();
            yearsDataCollection = new YearsDataCollection();
        }

        private void buttonAbout_IDA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonSales_IDA_Click(object sender, EventArgs e)
        {
            SalesDataCollection sd = new SalesDataCollection();

            chartData_IDA.Series.Clear();

            Series salesSeries = new Series("Продажи");
            salesSeries.ChartType = SeriesChartType.Spline;

            foreach (SalesData salesData in sd)
            {
                salesSeries.Points.AddXY(salesData.Month, salesData.Sales);
            }

            chartData_IDA.Series.Add(salesSeries);
        }

        private void buttonTiming_IDA_Click(object sender, EventArgs e)
        {
            YearsDataCollection yd = new YearsDataCollection();

            chartData_IDA.Series.Clear();

            Series salesSeries = new Series("Доставки");
            salesSeries.ChartType = SeriesChartType.Spline;

            foreach (YearsData yearsData in yd)
            {
                salesSeries.Points.AddXY(yearsData.Year, yearsData.Sales);
            }

            chartData_IDA.Series.Add(salesSeries);
        }

        private void buttonHelp_IDA_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();
        }

        private void buttonDataInfo_IDA_Click(object sender, EventArgs e)
        {
            FormOrder formOrder = new FormOrder();  
            formOrder.ShowDialog();
        }
    }
}
