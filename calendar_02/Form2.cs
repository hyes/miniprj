using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calendar_02
{
	public partial class Form2 : Form
	{
		string name;
		
		public DayRecord day;
		public MonthRecord monthly;
		Form1 frm1;

		public Form2(string name)
		{
			InitializeComponent();
			this.name = name;
		}
		public Form2(Form1 form)
		{
			InitializeComponent();
			frm1 = form;

		}
		
		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}
		
		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click_1(object sender, EventArgs e)
		{
		
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string rename = name.Substring(3);

			Coffee a = new Coffee(textBox2.Text, (int)numericUpDown1.Value);
			Study b = new Study(textBox4.Text, (int)numericUpDown3.Value);
			Exercise c = new Exercise(textBox5.Text, (int)numericUpDown4.Value);
			Meditation d = new Meditation(textBox3.Text, (int)numericUpDown2.Value);
			Stress f = new Stress((int)numericUpDown5.Value);

			day = new DayRecord(int.Parse(rename), a,c,b,d,f);

			if(day.Coffee.Count > 4)
				MessageBox.Show("Too Much Coffee>0< \n 위에 구멍나 ㅠㅠ!");
			if(day.Exercise.Count > 4)
				MessageBox.Show("Too Much Exercise makes you oooold");
			if (day.meditation.Count > 3) 
				MessageBox.Show("Too Much~ Enjoy Outdoor Activities~~");
			if (day.study.Count > 6 )
				MessageBox.Show("Gooooood!");


			//MonthRecord.Add(day);
			this.DialogResult = DialogResult.OK;
			this.Close();
			
		}
	}
}
