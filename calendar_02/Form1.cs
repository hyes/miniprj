using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System;
using System.Threading;
using System.Collections;

namespace calendar_02
{
	public partial class Form1 : Form
	{
		Label[] labels = new Label[30];
		MonthRecord month6 = new MonthRecord();
		public Form1()
		{
			//ArrayList labels = new ArrayLis
			InitializeComponent();

			labels[0] = day1;
			labels[1] = day2;
			labels[2] = day3;
			labels[3] = day4;
			labels[4] = day5;
			labels[5] = day6;
			labels[6] = day7;
			labels[7] = day8;
			labels[8] = day9;
			labels[9] = day10;
			labels[10] = day11;
			labels[11] = day12;
			labels[12] = day13;
			labels[13] = day14;
			labels[14] = day15;
			labels[15] = day16;
			labels[16] = day17;
			labels[17] = day18;
			labels[18] = day19;
			labels[19] = day20;
			labels[20] = day21;
			labels[21] = day22;
			labels[22] = day23;
			labels[23] = day24;
			labels[24] = day25;
			labels[25] = day26;
			labels[26] = day27;
			labels[27] = day28;
			labels[28] = day29;
			labels[29] = day30;
			//labels[30] = day31;
			

		}

		private void day1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Label label = (Label)sender;
			Form2 checkbox = new Form2(label.Name);
			if (checkbox.ShowDialog() == DialogResult.OK)
			{
				DayRecord day = checkbox.day;
				month6.Add(day);
				int index = int.Parse(label.Name.Substring(3));
				DrawOnCalendar(day, label);
			}

		}

			private void 저장SToolStripMenuItem_Click(object sender, System.EventArgs e)
			{
				 SaveFileDialog saveFileDialog = new SaveFileDialog();
				 if (saveFileDialog.ShowDialog() == DialogResult.OK)
				 {
					 Stream ws = new FileStream(saveFileDialog.FileName, FileMode.Create);
					 BinaryFormatter serializer = new BinaryFormatter();

					 serializer.Serialize(ws, month6);
					 ws.Close();
					
				 }
		}

			private void 불러오기OToolStripMenuItem_Click(object sender, System.EventArgs e)
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					Stream rs = new FileStream(openFileDialog.FileName, FileMode.Open);
					BinaryFormatter deserializer = new BinaryFormatter();
					month6 = (MonthRecord)deserializer.Deserialize(rs);

					ArrayList ssss = month6.monthly; 
					
					rs.Close();
					
						foreach (DayRecord day in ssss){
							DrawOnCalendar(day, labels[day.DD-1]);
						}	
					}
			}

			public int RandomNum()
			{
				Thread.Sleep(10);
				Random ran1 = new Random();
				int rn = ran1.Next(1, 70);
				return rn;
			}
			public int RandomNum1()
			{
				Thread.Sleep(10);
				Random ran1 = new Random();
				int rn = ran1.Next(1, 30);
				return rn;
			}
		
	
			public void DrawOnCalendar(DayRecord day, Label label)
			{
				Image bmp = new Bitmap(112, 96);
				Graphics g = Graphics.FromImage(bmp);

				if (day.study.Count != 0 && day.study.Count < 3)
				{
					int rn1 = RandomNum1();
					//	Thread.Sleep(10);
					int rn2 = RandomNum1();
					int n3 = day.study.Count;
					Image img_study = Image.FromFile(@"C:\Users\hyes\documents\visual studio 2010\Projects\calendar_02\calendar_02\Resources\pen.jpg");
					label.Image = bmp;
					Rectangle tem3 = new Rectangle(rn1, rn2, 20 * n3, 20 * n3);
					g.DrawImage(img_study, tem3);
				}

				else if (day.study.Count >= 3 && day.study.Count <= 6)
				{
					int rn1 = RandomNum1();
					//	Thread.Sleep(10);
					int rn2 = RandomNum1();
					int n3 = day.study.Count;
					Image img_study = Image.FromFile(@"C:\Users\hyes\documents\visual studio 2010\Projects\calendar_02\calendar_02\Resources\pen1.jpg");
					label.Image = bmp;
					Rectangle tem3 = new Rectangle(rn1, rn2, 15 * n3, 15 * n3);
					g.DrawImage(img_study, tem3);
				}

				else if (day.study.Count > 6)
				{
					Image img_study = Image.FromFile(@"C:\Users\hyes\documents\visual studio 2010\Projects\calendar_02\calendar_02\Resources\pen1.jpg");
					label.Image = bmp;
					Rectangle tem3 = new Rectangle(5, 5, 90, 90);
					g.DrawImage(img_study, tem3);
				}

				if (day.Coffee.Count != 0 && day.Coffee.Count < 4)
				{
					Image img_cof = Image.FromFile(@"C:\Users\hyes\Documents\Visual Studio 2010\Projects\calendar_02\calendar_02\Resources\coffee.png");
					int rn1 = RandomNum();
					//	Thread.Sleep(10);
					int rn2 = RandomNum();
					int n = day.Coffee.Count;
					label.Image = bmp;
					Rectangle tem = new Rectangle(rn1, rn2, n * 25, n * 25);
					g.DrawImage(img_cof, tem);
				}


				else if (day.Coffee.Count >= 4)
				{
					Image img_cof = Image.FromFile(@"C:\Users\hyes\Documents\Visual Studio 2010\Projects\calendar_02\calendar_02\Resources\coffee.png");
					label.Image = bmp;
					Rectangle tem = new Rectangle(0, 10, 80, 80);
					g.DrawImage(img_cof, tem);
					//	MessageBox.Show("Too Much Coffee!!! Caution:위경련");
				}

				if (day.Exercise.Count != 0 && day.Exercise.Count < 3)
				{
					int rn1 = RandomNum();
					//	Thread.Sleep(10);
					int rn2 = RandomNum();
					int n1 = day.Exercise.Count;
					Image img_exer = Image.FromFile(@"C:\Users\hyes\Documents\Visual Studio 2010\Projects\calendar_02\calendar_02\Resources\tennis.png");
					label.Image = bmp;
					Rectangle tem1 = new Rectangle(rn1, rn2, 25 * n1, 25 * n1);
					g.DrawImage(img_exer, tem1);
				}

				else if (day.Exercise.Count >= 3)
				{
					int n2 = day.Exercise.Count;
					Image img_exer = Image.FromFile(@"C:\Users\hyes\Documents\Visual Studio 2010\Projects\calendar_02\calendar_02\Resources\tennis.png");
					label.Image = bmp;
					Rectangle tem1 = new Rectangle(35, 10, 80, 80);
					g.DrawImage(img_exer, tem1);

				}

				if (day.meditation.Count != 0 && day.meditation.Count < 3)
				{
					int rn1 = RandomNum();
					//		Thread.Sleep(10);
					int rn2 = RandomNum();
					int n2 = day.meditation.Count;
					Image img_medi = Image.FromFile(@"C:\Users\hyes\Documents\Visual Studio 2010\Projects\calendar_02\calendar_02\Resources\meditation.png");
					label.Image = bmp;
					Rectangle tem2 = new Rectangle(rn1, rn2, 15 * n2, 15 * n2);
					g.DrawImage(img_medi, tem2);
				}

				else if (day.meditation.Count >= 3)
				{
					Image img_medi = Image.FromFile(@"C:\Users\hyes\Documents\Visual Studio 2010\Projects\calendar_02\calendar_02\Resources\meditation.png");
					label.Image = bmp;
					Rectangle tem2 = new Rectangle(20, 30, 80, 80);
					g.DrawImage(img_medi, tem2);
				}


				if (day.stress.Percent != 0)
				{
					int n4 = day.stress.Percent;
					//double barlength = 1.12 * n4;
					label.Image = bmp;
					Pen redPen = new Pen(Color.Transparent, 0);
					Color c2 = Color.FromArgb(n4, Color.Red);
					SolidBrush fillRed = new SolidBrush(c2);
					Rectangle stressbar = new Rectangle(0, 90, 112, 10);
					//Rectangle stressbar = new Rectangle(0, 90, (int)barlength, 10);
					g.DrawRectangle(redPen, stressbar);
					g.FillRectangle(fillRed, stressbar);
				}
			}

			private void button1_Click(object sender, EventArgs e)
			{
				Form3 stat = new Form3(month6);
				stat.ShowDialog();
			}
		}
}
