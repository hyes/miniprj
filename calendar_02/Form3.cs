using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace calendar_02
{
	public partial class Form3 : Form
	{
		MonthRecord month6;
		int totalcoffee = 0;
		int totalexercise = 0;
		int totalstudy = 0;
		int totalmeditation = 0;


		public Form3(MonthRecord month6)
		{
			InitializeComponent();
			this.month6 = month6;
			TotalCount();
			StringCount();
		}

		public void TotalCount()
		{


			foreach (DayRecord day in month6.monthly)
			{

				this.totalcoffee += day.Coffee.Count;
				this.totalexercise += day.Exercise.Count;
				this.totalstudy += day.study.Count;
				this.totalmeditation += day.meditation.Count;
			}

			label5.Text = totalcoffee.ToString();
			label6.Text = totalmeditation.ToString();
			label7.Text = totalstudy.ToString();
			label8.Text = totalexercise.ToString();
		}

		public void StringCount()
		{
			int a = 0;
			int b = 0;
			int c = 0;
			//	ArrayList stringcoffee = new ArrayList();

			foreach (DayRecord day in month6.monthly)
			{


				if (day.Coffee.Name.Contains("라테") || day.Coffee.Name.Contains("라떼"))
				{
					//int a = 0;
					a += 1;
					label1.Text ="라떼를" + a.ToString() + "잔 마셨네요~";
					//label1.Text = + "   ";
					
				}
				else if (day.Coffee.Name.Contains("아메리카노") || day.Coffee.Name.Contains("커피"))
				{
					//int b = 0;
					b += 1;
					label2.Text ="아메리카노는" + b.ToString() + "잔 마셨고,";
					
				}
				else
				{
					int ddd = totalcoffee - c;
				}
			}

		}
	}
}
