namespace Test_Forms
{
	partial class Main_Form
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.lb_number = new System.Windows.Forms.Label();
			this.lb_Question = new System.Windows.Forms.Label();
			this.lb_questiontext = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStart = new System.Windows.Forms.ToolStripMenuItem();
			this.следующийВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolEnd = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolTB_LimitTime = new System.Windows.Forms.ToolStripTextBox();
			this.ToolTimer = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolTimeNow = new System.Windows.Forms.ToolStripMenuItem();
			this.GBox_Answers = new System.Windows.Forms.GroupBox();
			this.rb_4 = new System.Windows.Forms.RadioButton();
			this.rb_3 = new System.Windows.Forms.RadioButton();
			this.rb_2 = new System.Windows.Forms.RadioButton();
			this.rb_1 = new System.Windows.Forms.RadioButton();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.GBox_Answers.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer
			// 
			this.splitContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.lb_number);
			this.splitContainer.Panel1.Controls.Add(this.lb_Question);
			this.splitContainer.Panel1.Controls.Add(this.lb_questiontext);
			this.splitContainer.Panel1.Controls.Add(this.menuStrip1);
			this.splitContainer.Panel1MinSize = 100;
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.GBox_Answers);
			this.splitContainer.Panel2MinSize = 100;
			this.splitContainer.Size = new System.Drawing.Size(654, 381);
			this.splitContainer.SplitterDistance = 100;
			this.splitContainer.TabIndex = 0;
			this.splitContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
			this.splitContainer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
			this.splitContainer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
			// 
			// lb_number
			// 
			this.lb_number.AutoSize = true;
			this.lb_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
			this.lb_number.Location = new System.Drawing.Point(12, 51);
			this.lb_number.Name = "lb_number";
			this.lb_number.Size = new System.Drawing.Size(23, 13);
			this.lb_number.TabIndex = 1;
			this.lb_number.Text = "# 1";
			// 
			// lb_Question
			// 
			this.lb_Question.AutoSize = true;
			this.lb_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
			this.lb_Question.Location = new System.Drawing.Point(83, 49);
			this.lb_Question.Name = "lb_Question";
			this.lb_Question.Size = new System.Drawing.Size(65, 16);
			this.lb_Question.TabIndex = 0;
			this.lb_Question.Text = "Вопрос : ";
			// 
			// lb_questiontext
			// 
			this.lb_questiontext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lb_questiontext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
			this.lb_questiontext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(200)))));
			this.lb_questiontext.Location = new System.Drawing.Point(154, 36);
			this.lb_questiontext.Name = "lb_questiontext";
			this.lb_questiontext.Size = new System.Drawing.Size(471, 43);
			this.lb_questiontext.TabIndex = 0;
			this.lb_questiontext.Text = "Question";
			this.lb_questiontext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(44)))));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.ToolStart,
            this.следующийВопросToolStripMenuItem,
            this.ToolEnd,
            this.ToolTB_LimitTime,
            this.ToolTimer,
            this.ToolTimeNow});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(654, 25);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
			// 
			// ToolStart
			// 
			this.ToolStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
			this.ToolStart.Name = "ToolStart";
			this.ToolStart.Size = new System.Drawing.Size(50, 21);
			this.ToolStart.Text = "Старт";
			this.ToolStart.Click += new System.EventHandler(this.ToolStart_Click);
			// 
			// следующийВопросToolStripMenuItem
			// 
			this.следующийВопросToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.следующийВопросToolStripMenuItem.Enabled = false;
			this.следующийВопросToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
			this.следующийВопросToolStripMenuItem.Name = "следующийВопросToolStripMenuItem";
			this.следующийВопросToolStripMenuItem.Size = new System.Drawing.Size(146, 21);
			this.следующийВопросToolStripMenuItem.Text = "Следующий вопрос ->";
			this.следующийВопросToolStripMenuItem.Click += new System.EventHandler(this.следующийВопросToolStripMenuItem_Click);
			// 
			// ToolEnd
			// 
			this.ToolEnd.Enabled = false;
			this.ToolEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
			this.ToolEnd.Name = "ToolEnd";
			this.ToolEnd.Size = new System.Drawing.Size(80, 21);
			this.ToolEnd.Text = "Завершить";
			this.ToolEnd.Click += new System.EventHandler(this.ToolEnd_Click);
			// 
			// ToolTB_LimitTime
			// 
			this.ToolTB_LimitTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
			this.ToolTB_LimitTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ToolTB_LimitTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.ToolTB_LimitTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.ToolTB_LimitTime.MaxLength = 2;
			this.ToolTB_LimitTime.Name = "ToolTB_LimitTime";
			this.ToolTB_LimitTime.Size = new System.Drawing.Size(100, 21);
			this.ToolTB_LimitTime.Text = "Лимит времени";
			this.ToolTB_LimitTime.Click += new System.EventHandler(this.ToolTB_LimitTime_Click);
			// 
			// ToolTimer
			// 
			this.ToolTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(250)))), ((int)(((byte)(100)))));
			this.ToolTimer.Name = "ToolTimer";
			this.ToolTimer.Size = new System.Drawing.Size(54, 21);
			this.ToolTimer.Text = "Время";
			// 
			// ToolTimeNow
			// 
			this.ToolTimeNow.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.ToolTimeNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
			this.ToolTimeNow.Name = "ToolTimeNow";
			this.ToolTimeNow.Size = new System.Drawing.Size(104, 21);
			this.ToolTimeNow.Text = "Текущее время";
			// 
			// GBox_Answers
			// 
			this.GBox_Answers.Controls.Add(this.rb_4);
			this.GBox_Answers.Controls.Add(this.rb_3);
			this.GBox_Answers.Controls.Add(this.rb_2);
			this.GBox_Answers.Controls.Add(this.rb_1);
			this.GBox_Answers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GBox_Answers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.GBox_Answers.Location = new System.Drawing.Point(0, 0);
			this.GBox_Answers.Name = "GBox_Answers";
			this.GBox_Answers.Size = new System.Drawing.Size(654, 277);
			this.GBox_Answers.TabIndex = 0;
			this.GBox_Answers.TabStop = false;
			this.GBox_Answers.Text = "Варианты ответов";
			// 
			// rb_4
			// 
			this.rb_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.rb_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rb_4.Location = new System.Drawing.Point(332, 142);
			this.rb_4.Name = "rb_4";
			this.rb_4.Size = new System.Drawing.Size(280, 100);
			this.rb_4.TabIndex = 0;
			this.rb_4.TabStop = true;
			this.rb_4.Tag = "3";
			this.rb_4.Text = "Вариант 4";
			this.rb_4.UseVisualStyleBackColor = true;
			this.rb_4.CheckedChanged += new System.EventHandler(this.RB_Chek_Click);
			// 
			// rb_3
			// 
			this.rb_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rb_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rb_3.Location = new System.Drawing.Point(332, 36);
			this.rb_3.Name = "rb_3";
			this.rb_3.Size = new System.Drawing.Size(280, 100);
			this.rb_3.TabIndex = 0;
			this.rb_3.TabStop = true;
			this.rb_3.Tag = "2";
			this.rb_3.Text = "Вариант 3";
			this.rb_3.UseVisualStyleBackColor = true;
			this.rb_3.CheckedChanged += new System.EventHandler(this.RB_Chek_Click);
			// 
			// rb_2
			// 
			this.rb_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.rb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rb_2.Location = new System.Drawing.Point(21, 142);
			this.rb_2.Name = "rb_2";
			this.rb_2.Size = new System.Drawing.Size(280, 100);
			this.rb_2.TabIndex = 0;
			this.rb_2.TabStop = true;
			this.rb_2.Tag = "1";
			this.rb_2.Text = "Вариант 2";
			this.rb_2.UseVisualStyleBackColor = true;
			this.rb_2.CheckedChanged += new System.EventHandler(this.RB_Chek_Click);
			// 
			// rb_1
			// 
			this.rb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.rb_1.Location = new System.Drawing.Point(21, 36);
			this.rb_1.Name = "rb_1";
			this.rb_1.Size = new System.Drawing.Size(280, 100);
			this.rb_1.TabIndex = 0;
			this.rb_1.TabStop = true;
			this.rb_1.Tag = "0";
			this.rb_1.Text = "Вариант 1";
			this.rb_1.UseVisualStyleBackColor = true;
			this.rb_1.CheckedChanged += new System.EventHandler(this.RB_Chek_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Main_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.ClientSize = new System.Drawing.Size(654, 381);
			this.Controls.Add(this.splitContainer);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(650, 420);
			this.Name = "Main_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Программа Тестирования";
			this.Load += new System.EventHandler(this.Main_Form_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel1.PerformLayout();
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.GBox_Answers.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.Label lb_number;
		private System.Windows.Forms.Label lb_Question;
		private System.Windows.Forms.Label lb_questiontext;
		private System.Windows.Forms.GroupBox GBox_Answers;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem следующийВопросToolStripMenuItem;
		private System.Windows.Forms.RadioButton rb_4;
		private System.Windows.Forms.RadioButton rb_3;
		private System.Windows.Forms.RadioButton rb_2;
		private System.Windows.Forms.RadioButton rb_1;
		private System.Windows.Forms.ToolStripMenuItem ToolStart;
		private System.Windows.Forms.ToolStripMenuItem ToolTimer;
		private System.Windows.Forms.ToolStripMenuItem ToolTimeNow;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripMenuItem ToolEnd;
		private System.Windows.Forms.ToolStripTextBox ToolTB_LimitTime;
	}
}

