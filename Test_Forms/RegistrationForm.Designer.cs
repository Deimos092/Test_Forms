namespace Test_Forms
{
	partial class RegistrationForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_pas = new System.Windows.Forms.TextBox();
			this.tb_log = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolLable = new System.Windows.Forms.ToolStripStatusLabel();
			this.btn_exit = new System.Windows.Forms.Button();
			this.btn_OK = new System.Windows.Forms.Button();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(54)))), ((int)(((byte)(12)))));
			this.label2.Location = new System.Drawing.Point(12, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Новый Пароль";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(54)))), ((int)(((byte)(12)))));
			this.label1.Location = new System.Drawing.Point(12, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Новый Логин";
			// 
			// tb_pas
			// 
			this.tb_pas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_pas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
			this.tb_pas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_pas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.tb_pas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.tb_pas.Location = new System.Drawing.Point(11, 106);
			this.tb_pas.Margin = new System.Windows.Forms.Padding(0);
			this.tb_pas.MaxLength = 25;
			this.tb_pas.Name = "tb_pas";
			this.tb_pas.PasswordChar = '*';
			this.tb_pas.Size = new System.Drawing.Size(264, 21);
			this.tb_pas.TabIndex = 1;
			this.tb_pas.Tag = "Введите пароль";
			this.tb_pas.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
			this.tb_pas.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			// 
			// tb_log
			// 
			this.tb_log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
			this.tb_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.tb_log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.tb_log.Location = new System.Drawing.Point(11, 67);
			this.tb_log.Margin = new System.Windows.Forms.Padding(0);
			this.tb_log.MaxLength = 25;
			this.tb_log.Name = "tb_log";
			this.tb_log.Size = new System.Drawing.Size(264, 21);
			this.tb_log.TabIndex = 0;
			this.tb_log.Tag = "Введите Логин";
			this.tb_log.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
			this.tb_log.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
			this.label3.Location = new System.Drawing.Point(41, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(193, 24);
			this.label3.TabIndex = 10;
			this.label3.Text = "Форма Регистрации";
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolLable});
			this.statusStrip1.Location = new System.Drawing.Point(0, 269);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(284, 22);
			this.statusStrip1.TabIndex = 12;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolLable
			// 
			this.toolLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(54)))), ((int)(((byte)(12)))));
			this.toolLable.Name = "toolLable";
			this.toolLable.Size = new System.Drawing.Size(166, 17);
			this.toolLable.Text = "Регистрация нового ученика";
			// 
			// btn_exit
			// 
			this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_exit.AutoSize = true;
			this.btn_exit.FlatAppearance.BorderSize = 0;
			this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
			this.btn_exit.Image = global::Test_Forms.Properties.Resources.logout;
			this.btn_exit.Location = new System.Drawing.Point(194, 225);
			this.btn_exit.Name = "btn_exit";
			this.btn_exit.Size = new System.Drawing.Size(81, 38);
			this.btn_exit.TabIndex = 3;
			this.btn_exit.Tag = "Назад ко входу";
			this.btn_exit.Text = "Назад";
			this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_exit.UseVisualStyleBackColor = true;
			this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
			this.btn_exit.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
			this.btn_exit.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			// 
			// btn_OK
			// 
			this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_OK.FlatAppearance.BorderSize = 0;
			this.btn_OK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(105)))), ((int)(((byte)(45)))));
			this.btn_OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
			this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_OK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
			this.btn_OK.Image = global::Test_Forms.Properties.Resources.tick;
			this.btn_OK.Location = new System.Drawing.Point(11, 132);
			this.btn_OK.Name = "btn_OK";
			this.btn_OK.Size = new System.Drawing.Size(264, 44);
			this.btn_OK.TabIndex = 2;
			this.btn_OK.Tag = "Зарегестрировать нового ученика";
			this.btn_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_OK.UseVisualStyleBackColor = true;
			this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
			this.btn_OK.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
			this.btn_OK.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			// 
			// RegistrationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.ClientSize = new System.Drawing.Size(284, 291);
			this.Controls.Add(this.btn_exit);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.btn_OK);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_pas);
			this.Controls.Add(this.tb_log);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(400, 430);
			this.MinimumSize = new System.Drawing.Size(300, 330);
			this.Name = "RegistrationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Форма Регистрации";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogonForm_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LogonForm_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LogonForm_MouseUp);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_pas;
		private System.Windows.Forms.TextBox tb_log;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_OK;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolLable;
		private System.Windows.Forms.Button btn_exit;
	}
}