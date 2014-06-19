namespace calendar_02
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.day1 = new System.Windows.Forms.Label();
			this.day2 = new System.Windows.Forms.Label();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.저장SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.불러오기OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.day3 = new System.Windows.Forms.Label();
			this.day4 = new System.Windows.Forms.Label();
			this.day5 = new System.Windows.Forms.Label();
			this.day6 = new System.Windows.Forms.Label();
			this.day7 = new System.Windows.Forms.Label();
			this.day8 = new System.Windows.Forms.Label();
			this.day9 = new System.Windows.Forms.Label();
			this.day10 = new System.Windows.Forms.Label();
			this.day11 = new System.Windows.Forms.Label();
			this.day17 = new System.Windows.Forms.Label();
			this.day18 = new System.Windows.Forms.Label();
			this.day15 = new System.Windows.Forms.Label();
			this.day16 = new System.Windows.Forms.Label();
			this.day24 = new System.Windows.Forms.Label();
			this.day25 = new System.Windows.Forms.Label();
			this.day22 = new System.Windows.Forms.Label();
			this.day23 = new System.Windows.Forms.Label();
			this.day14 = new System.Windows.Forms.Label();
			this.day21 = new System.Windows.Forms.Label();
			this.day29 = new System.Windows.Forms.Label();
			this.day30 = new System.Windows.Forms.Label();
			this.day12 = new System.Windows.Forms.Label();
			this.day13 = new System.Windows.Forms.Label();
			this.day19 = new System.Windows.Forms.Label();
			this.day20 = new System.Windows.Forms.Label();
			this.day26 = new System.Windows.Forms.Label();
			this.day27 = new System.Windows.Forms.Label();
			this.day28 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// day1
			// 
			this.day1.BackColor = System.Drawing.Color.Transparent;
			this.day1.ForeColor = System.Drawing.Color.Transparent;
			this.day1.Location = new System.Drawing.Point(25, 111);
			this.day1.Name = "day1";
			this.day1.Size = new System.Drawing.Size(112, 96);
			this.day1.TabIndex = 0;
			this.day1.Text = "1";
			this.day1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day2
			// 
			this.day2.BackColor = System.Drawing.Color.Transparent;
			this.day2.ForeColor = System.Drawing.Color.Transparent;
			this.day2.Location = new System.Drawing.Point(139, 111);
			this.day2.Name = "day2";
			this.day2.Size = new System.Drawing.Size(112, 96);
			this.day2.TabIndex = 2;
			this.day2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(843, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 파일FToolStripMenuItem
			// 
			this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장SToolStripMenuItem,
            this.불러오기OToolStripMenuItem});
			this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
			this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.파일FToolStripMenuItem.Text = "파일(&F)";
			// 
			// 저장SToolStripMenuItem
			// 
			this.저장SToolStripMenuItem.Name = "저장SToolStripMenuItem";
			this.저장SToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.저장SToolStripMenuItem.Text = "저장(&S)";
			this.저장SToolStripMenuItem.Click += new System.EventHandler(this.저장SToolStripMenuItem_Click);
			// 
			// 불러오기OToolStripMenuItem
			// 
			this.불러오기OToolStripMenuItem.Name = "불러오기OToolStripMenuItem";
			this.불러오기OToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.불러오기OToolStripMenuItem.Text = "불러오기(&O)";
			this.불러오기OToolStripMenuItem.Click += new System.EventHandler(this.불러오기OToolStripMenuItem_Click);
			// 
			// day3
			// 
			this.day3.BackColor = System.Drawing.Color.Transparent;
			this.day3.ForeColor = System.Drawing.Color.Transparent;
			this.day3.Location = new System.Drawing.Point(252, 111);
			this.day3.Name = "day3";
			this.day3.Size = new System.Drawing.Size(112, 96);
			this.day3.TabIndex = 5;
			this.day3.Text = "1";
			this.day3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day4
			// 
			this.day4.BackColor = System.Drawing.Color.Transparent;
			this.day4.ForeColor = System.Drawing.Color.Transparent;
			this.day4.Location = new System.Drawing.Point(368, 111);
			this.day4.Name = "day4";
			this.day4.Size = new System.Drawing.Size(112, 96);
			this.day4.TabIndex = 6;
			this.day4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day5
			// 
			this.day5.BackColor = System.Drawing.Color.Transparent;
			this.day5.ForeColor = System.Drawing.Color.Transparent;
			this.day5.Location = new System.Drawing.Point(482, 111);
			this.day5.Name = "day5";
			this.day5.Size = new System.Drawing.Size(112, 96);
			this.day5.TabIndex = 7;
			this.day5.Text = "1";
			this.day5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day6
			// 
			this.day6.BackColor = System.Drawing.Color.Transparent;
			this.day6.ForeColor = System.Drawing.Color.Transparent;
			this.day6.Location = new System.Drawing.Point(597, 111);
			this.day6.Name = "day6";
			this.day6.Size = new System.Drawing.Size(112, 96);
			this.day6.TabIndex = 8;
			this.day6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day7
			// 
			this.day7.BackColor = System.Drawing.Color.Transparent;
			this.day7.ForeColor = System.Drawing.Color.Transparent;
			this.day7.Location = new System.Drawing.Point(710, 111);
			this.day7.Name = "day7";
			this.day7.Size = new System.Drawing.Size(112, 96);
			this.day7.TabIndex = 9;
			this.day7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day7.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day8
			// 
			this.day8.BackColor = System.Drawing.Color.Transparent;
			this.day8.ForeColor = System.Drawing.Color.Transparent;
			this.day8.Location = new System.Drawing.Point(26, 209);
			this.day8.Name = "day8";
			this.day8.Size = new System.Drawing.Size(112, 96);
			this.day8.TabIndex = 10;
			this.day8.Text = "1";
			this.day8.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day8.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day9
			// 
			this.day9.BackColor = System.Drawing.Color.Transparent;
			this.day9.ForeColor = System.Drawing.Color.Transparent;
			this.day9.Location = new System.Drawing.Point(139, 209);
			this.day9.Name = "day9";
			this.day9.Size = new System.Drawing.Size(112, 96);
			this.day9.TabIndex = 11;
			this.day9.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day9.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day10
			// 
			this.day10.BackColor = System.Drawing.Color.Transparent;
			this.day10.ForeColor = System.Drawing.Color.Transparent;
			this.day10.Location = new System.Drawing.Point(252, 209);
			this.day10.Name = "day10";
			this.day10.Size = new System.Drawing.Size(112, 96);
			this.day10.TabIndex = 12;
			this.day10.Text = "1";
			this.day10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day10.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day11
			// 
			this.day11.BackColor = System.Drawing.Color.Transparent;
			this.day11.ForeColor = System.Drawing.Color.Transparent;
			this.day11.Location = new System.Drawing.Point(368, 209);
			this.day11.Name = "day11";
			this.day11.Size = new System.Drawing.Size(112, 96);
			this.day11.TabIndex = 13;
			this.day11.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day11.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day17
			// 
			this.day17.BackColor = System.Drawing.Color.Transparent;
			this.day17.ForeColor = System.Drawing.Color.Transparent;
			this.day17.Location = new System.Drawing.Point(252, 307);
			this.day17.Name = "day17";
			this.day17.Size = new System.Drawing.Size(112, 96);
			this.day17.TabIndex = 16;
			this.day17.Text = "1";
			this.day17.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day17.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day18
			// 
			this.day18.BackColor = System.Drawing.Color.Transparent;
			this.day18.ForeColor = System.Drawing.Color.Transparent;
			this.day18.Location = new System.Drawing.Point(368, 307);
			this.day18.Name = "day18";
			this.day18.Size = new System.Drawing.Size(112, 96);
			this.day18.TabIndex = 17;
			this.day18.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day18.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day15
			// 
			this.day15.BackColor = System.Drawing.Color.Transparent;
			this.day15.ForeColor = System.Drawing.Color.Transparent;
			this.day15.Location = new System.Drawing.Point(26, 307);
			this.day15.Name = "day15";
			this.day15.Size = new System.Drawing.Size(112, 96);
			this.day15.TabIndex = 14;
			this.day15.Text = "1";
			this.day15.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day15.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day16
			// 
			this.day16.BackColor = System.Drawing.Color.Transparent;
			this.day16.ForeColor = System.Drawing.Color.Transparent;
			this.day16.Location = new System.Drawing.Point(139, 307);
			this.day16.Name = "day16";
			this.day16.Size = new System.Drawing.Size(112, 96);
			this.day16.TabIndex = 15;
			this.day16.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day16.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day24
			// 
			this.day24.BackColor = System.Drawing.Color.Transparent;
			this.day24.ForeColor = System.Drawing.Color.Transparent;
			this.day24.Location = new System.Drawing.Point(252, 404);
			this.day24.Name = "day24";
			this.day24.Size = new System.Drawing.Size(112, 96);
			this.day24.TabIndex = 20;
			this.day24.Text = "1";
			this.day24.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day24.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day25
			// 
			this.day25.BackColor = System.Drawing.Color.Transparent;
			this.day25.ForeColor = System.Drawing.Color.Transparent;
			this.day25.Location = new System.Drawing.Point(367, 404);
			this.day25.Name = "day25";
			this.day25.Size = new System.Drawing.Size(112, 96);
			this.day25.TabIndex = 21;
			this.day25.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day25.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day22
			// 
			this.day22.BackColor = System.Drawing.Color.Transparent;
			this.day22.ForeColor = System.Drawing.Color.Transparent;
			this.day22.Location = new System.Drawing.Point(26, 404);
			this.day22.Name = "day22";
			this.day22.Size = new System.Drawing.Size(112, 96);
			this.day22.TabIndex = 18;
			this.day22.Text = "1";
			this.day22.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day22.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day23
			// 
			this.day23.BackColor = System.Drawing.Color.Transparent;
			this.day23.ForeColor = System.Drawing.Color.Transparent;
			this.day23.Location = new System.Drawing.Point(139, 404);
			this.day23.Name = "day23";
			this.day23.Size = new System.Drawing.Size(112, 96);
			this.day23.TabIndex = 19;
			this.day23.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day23.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day14
			// 
			this.day14.BackColor = System.Drawing.Color.Transparent;
			this.day14.ForeColor = System.Drawing.Color.Transparent;
			this.day14.Location = new System.Drawing.Point(710, 209);
			this.day14.Name = "day14";
			this.day14.Size = new System.Drawing.Size(112, 96);
			this.day14.TabIndex = 24;
			this.day14.Text = "1";
			this.day14.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day14.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day21
			// 
			this.day21.BackColor = System.Drawing.Color.Transparent;
			this.day21.ForeColor = System.Drawing.Color.Transparent;
			this.day21.Location = new System.Drawing.Point(710, 307);
			this.day21.Name = "day21";
			this.day21.Size = new System.Drawing.Size(112, 96);
			this.day21.TabIndex = 25;
			this.day21.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day21.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day29
			// 
			this.day29.BackColor = System.Drawing.Color.Transparent;
			this.day29.ForeColor = System.Drawing.Color.Transparent;
			this.day29.Location = new System.Drawing.Point(26, 501);
			this.day29.Name = "day29";
			this.day29.Size = new System.Drawing.Size(112, 96);
			this.day29.TabIndex = 22;
			this.day29.Text = "1";
			this.day29.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day29.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day30
			// 
			this.day30.BackColor = System.Drawing.Color.Transparent;
			this.day30.ForeColor = System.Drawing.Color.Transparent;
			this.day30.Location = new System.Drawing.Point(139, 501);
			this.day30.Name = "day30";
			this.day30.Size = new System.Drawing.Size(112, 96);
			this.day30.TabIndex = 23;
			this.day30.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day30.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day12
			// 
			this.day12.BackColor = System.Drawing.Color.Transparent;
			this.day12.ForeColor = System.Drawing.Color.Transparent;
			this.day12.Location = new System.Drawing.Point(482, 209);
			this.day12.Name = "day12";
			this.day12.Size = new System.Drawing.Size(112, 96);
			this.day12.TabIndex = 26;
			this.day12.Text = "1";
			this.day12.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day12.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day13
			// 
			this.day13.BackColor = System.Drawing.Color.Transparent;
			this.day13.ForeColor = System.Drawing.Color.Transparent;
			this.day13.Location = new System.Drawing.Point(597, 209);
			this.day13.Name = "day13";
			this.day13.Size = new System.Drawing.Size(112, 96);
			this.day13.TabIndex = 27;
			this.day13.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day13.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day19
			// 
			this.day19.BackColor = System.Drawing.Color.Transparent;
			this.day19.ForeColor = System.Drawing.Color.Transparent;
			this.day19.Location = new System.Drawing.Point(482, 307);
			this.day19.Name = "day19";
			this.day19.Size = new System.Drawing.Size(112, 96);
			this.day19.TabIndex = 28;
			this.day19.Text = "1";
			this.day19.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day19.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day20
			// 
			this.day20.BackColor = System.Drawing.Color.Transparent;
			this.day20.ForeColor = System.Drawing.Color.Transparent;
			this.day20.Location = new System.Drawing.Point(597, 307);
			this.day20.Name = "day20";
			this.day20.Size = new System.Drawing.Size(112, 96);
			this.day20.TabIndex = 29;
			this.day20.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day20.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day26
			// 
			this.day26.BackColor = System.Drawing.Color.Transparent;
			this.day26.ForeColor = System.Drawing.Color.Transparent;
			this.day26.Location = new System.Drawing.Point(482, 404);
			this.day26.Name = "day26";
			this.day26.Size = new System.Drawing.Size(112, 96);
			this.day26.TabIndex = 30;
			this.day26.Text = "1";
			this.day26.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day26.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day27
			// 
			this.day27.BackColor = System.Drawing.Color.Transparent;
			this.day27.ForeColor = System.Drawing.Color.Transparent;
			this.day27.Location = new System.Drawing.Point(597, 404);
			this.day27.Name = "day27";
			this.day27.Size = new System.Drawing.Size(112, 96);
			this.day27.TabIndex = 31;
			this.day27.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day27.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// day28
			// 
			this.day28.BackColor = System.Drawing.Color.Transparent;
			this.day28.ForeColor = System.Drawing.Color.Transparent;
			this.day28.Location = new System.Drawing.Point(710, 404);
			this.day28.Name = "day28";
			this.day28.Size = new System.Drawing.Size(112, 96);
			this.day28.TabIndex = 32;
			this.day28.Text = "1";
			this.day28.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.day28.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.day1_MouseDoubleClick);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Crimson;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(760, 22);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(62, 48);
			this.button1.TabIndex = 33;
			this.button1.Text = "통계";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackgroundImage = global::calendar_02.Properties.Resources.cal6;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(843, 618);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.day28);
			this.Controls.Add(this.day26);
			this.Controls.Add(this.day27);
			this.Controls.Add(this.day19);
			this.Controls.Add(this.day20);
			this.Controls.Add(this.day12);
			this.Controls.Add(this.day13);
			this.Controls.Add(this.day14);
			this.Controls.Add(this.day21);
			this.Controls.Add(this.day29);
			this.Controls.Add(this.day30);
			this.Controls.Add(this.day24);
			this.Controls.Add(this.day25);
			this.Controls.Add(this.day22);
			this.Controls.Add(this.day23);
			this.Controls.Add(this.day17);
			this.Controls.Add(this.day18);
			this.Controls.Add(this.day15);
			this.Controls.Add(this.day16);
			this.Controls.Add(this.day10);
			this.Controls.Add(this.day11);
			this.Controls.Add(this.day8);
			this.Controls.Add(this.day9);
			this.Controls.Add(this.day7);
			this.Controls.Add(this.day5);
			this.Controls.Add(this.day6);
			this.Controls.Add(this.day3);
			this.Controls.Add(this.day4);
			this.Controls.Add(this.day1);
			this.Controls.Add(this.day2);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "다이어리";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label day1;
		private System.Windows.Forms.Label day2;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 저장SToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 불러오기OToolStripMenuItem;
		private System.Windows.Forms.Label day3;
		private System.Windows.Forms.Label day4;
		private System.Windows.Forms.Label day5;
		private System.Windows.Forms.Label day6;
		private System.Windows.Forms.Label day7;
		private System.Windows.Forms.Label day8;
		private System.Windows.Forms.Label day9;
		private System.Windows.Forms.Label day10;
		private System.Windows.Forms.Label day11;
		private System.Windows.Forms.Label day17;
		private System.Windows.Forms.Label day18;
		private System.Windows.Forms.Label day15;
		private System.Windows.Forms.Label day16;
		private System.Windows.Forms.Label day24;
		private System.Windows.Forms.Label day25;
		private System.Windows.Forms.Label day22;
		private System.Windows.Forms.Label day23;
		private System.Windows.Forms.Label day14;
		private System.Windows.Forms.Label day21;
		private System.Windows.Forms.Label day29;
		private System.Windows.Forms.Label day30;
		private System.Windows.Forms.Label day12;
		private System.Windows.Forms.Label day13;
		private System.Windows.Forms.Label day19;
		private System.Windows.Forms.Label day20;
		private System.Windows.Forms.Label day26;
		private System.Windows.Forms.Label day27;
		private System.Windows.Forms.Label day28;
		private System.Windows.Forms.Button button1;


	}
}

