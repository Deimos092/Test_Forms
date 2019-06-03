namespace Test_Forms
{
	partial class HelpInfo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpInfo));
			this.label1 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lb_Refresh = new System.Windows.Forms.Label();
			this.btn_Close = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
			this.label1.Location = new System.Drawing.Point(13, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "О программе";
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
			this.richTextBox1.Location = new System.Drawing.Point(16, 29);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(256, 138);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "Программа : Тестирование\n\nОписание : Программа предназначена для \nпроведения тест" +
    "ирования и выявления знаний\nу пользователей\n\nАвтор : Валерий Иванов";
			this.richTextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HelpInfo_MouseDown);
			this.richTextBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HelpInfo_MouseMove);
			this.richTextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HelpInfo_MouseUp);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
			this.label2.Location = new System.Drawing.Point(13, 170);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Последнее обновление :";
			// 
			// lb_Refresh
			// 
			this.lb_Refresh.AutoSize = true;
			this.lb_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
			this.lb_Refresh.Location = new System.Drawing.Point(156, 170);
			this.lb_Refresh.Name = "lb_Refresh";
			this.lb_Refresh.Size = new System.Drawing.Size(61, 13);
			this.lb_Refresh.TabIndex = 3;
			this.lb_Refresh.Text = "22.11.2018";
			// 
			// btn_Close
			// 
			this.btn_Close.BackColor = System.Drawing.Color.Transparent;
			this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_Close.FlatAppearance.BorderSize = 0;
			this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
			this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
			this.btn_Close.Image = global::Test_Forms.Properties.Resources.cancel;
			this.btn_Close.Location = new System.Drawing.Point(228, 197);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(44, 42);
			this.btn_Close.TabIndex = 4;
			this.btn_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btn_Close.UseVisualStyleBackColor = false;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// HelpInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.ClientSize = new System.Drawing.Size(284, 251);
			this.Controls.Add(this.btn_Close);
			this.Controls.Add(this.lb_Refresh);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(300, 290);
			this.MinimumSize = new System.Drawing.Size(300, 290);
			this.Name = "HelpInfo";
			this.Opacity = 0.9D;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Информация";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HelpInfo_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HelpInfo_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HelpInfo_MouseUp);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lb_Refresh;
		private System.Windows.Forms.Button btn_Close;
	}
}