using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Drawing.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace calendar_02
{
	public partial class Form3 : Form
	{
		MonthRecord month6;
		int totalcoffee = 0;
		int totalexercise = 0;
		int totalstudy = 0;
		int totalmeditation = 0;
		int totalstress = 0;


		public Form3(MonthRecord month6)
		{
			InitializeComponent();
			this.month6 = month6;
			TotalCount();
		}

		public void TotalCount()
		{


			foreach (DayRecord day in month6.monthly)
			{

				this.totalcoffee += day.Coffee.Count;
				this.totalexercise += day.Exercise.Count;
				this.totalstudy += day.study.Count;
				this.totalmeditation += day.meditation.Count;
				this.totalstress += day.stress.Percent;

			}

			label5.Text = totalcoffee.ToString();
			label6.Text = totalmeditation.ToString();
			label7.Text = totalstudy.ToString();
			label8.Text = totalexercise.ToString();
	
		}


		public Bitmap[] smallimages = new Bitmap[]
		        {
				
		            Properties.Resources.small_coffee,
		            Properties.Resources.small_study,
		            Properties.Resources.small_medita,
		            Properties.Resources.small_tennis,
					
		        };

		private void button1_Click(object sender, EventArgs e)
		{
			pictureBox5.Image = smallimages[0];
			pictureBox6.Image = smallimages[2];
			pictureBox7.Image = smallimages[1];
			pictureBox8.Image = smallimages[3];
			
			chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
			chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
			chart2.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
			chart2.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
			chart3.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
			chart3.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
			chart4.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
			chart4.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
			chart5.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
			chart5.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
			
			
			Label temp2 = new Label();
			label1.Text = "Stress";
			label1.Font = new Font("나눔고딕", 10);

			foreach (DayRecord day in month6.monthly)
			{	
				chart2.Series["Stress"].Points.AddXY(day.DD, day.stress.Percent);
				chart1.Series["Coffee"].Points.AddXY(day.DD, day.Coffee.Count);
				chart4.Series["Meditation"].Points.AddXY(day.DD, day.meditation.Count);
				chart5.Series["Exercise"].Points.AddXY(day.DD, day.Exercise.Count);
				chart3.Series["Study"].Points.AddXY(day.DD, day.study.Count);
			}
		}

	}
}
