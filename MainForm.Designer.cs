/*
 * Сделано в SharpDevelop.
 * Пользователь: SystemShock
 * Дата: 21.05.2019
 * Время: 19:36
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace QTPrivateSaver
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btn_find_bdir = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_goto_github = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btn_help_export = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.btn_find_bdir);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.linkLabel1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(760, 174);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Шаг 1. Подготовка";
			// 
			// comboBox1
			// 
			this.comboBox1.Enabled = false;
			this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"MFCoin"});
			this.comboBox1.Location = new System.Drawing.Point(663, 28);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.comboBox1.Size = new System.Drawing.Size(82, 25);
			this.comboBox1.TabIndex = 7;
			this.comboBox1.Text = "MFCoin";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(147, 132);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "Помощь:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(552, 128);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(193, 32);
			this.button2.TabIndex = 5;
			this.button2.Text = "Перенести автоматически";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(353, 128);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(193, 32);
			this.button1.TabIndex = 5;
			this.button1.Text = "Где папка бывает обычно?";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// btn_find_bdir
			// 
			this.btn_find_bdir.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btn_find_bdir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btn_find_bdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_find_bdir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_find_bdir.Location = new System.Drawing.Point(253, 128);
			this.btn_find_bdir.Name = "btn_find_bdir";
			this.btn_find_bdir.Size = new System.Drawing.Size(94, 32);
			this.btn_find_bdir.TabIndex = 5;
			this.btn_find_bdir.Text = "Найти папку";
			this.btn_find_bdir.UseVisualStyleBackColor = false;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(15, 95);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(730, 30);
			this.label5.TabIndex = 4;
			this.label5.Text = "3. Скопируйте .conf файл для необходимой монеты по пути расположения blokchain.";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(15, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 30);
			this.label3.TabIndex = 3;
			this.label3.Text = "2. Затем";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(204, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(541, 30);
			this.label4.TabIndex = 0;
			this.label4.Text = "чтобы открыть папку с .conf файлами (в директории утилиты).";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(15, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(730, 30);
			this.label2.TabIndex = 0;
			this.label2.Text = "1. Закройте кошелек и убедитесь, что процесс не остался активным.";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// linkLabel1
			// 
			this.linkLabel1.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
			this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue;
			this.linkLabel1.Location = new System.Drawing.Point(84, 65);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(131, 30);
			this.linkLabel1.TabIndex = 1;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "кликните здесь,";
			this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabel1.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 365);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(494, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "Утилита для работы с приватными ключами ваших QT-кошельков";
			// 
			// btn_goto_github
			// 
			this.btn_goto_github.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_goto_github.FlatAppearance.BorderSize = 0;
			this.btn_goto_github.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_goto_github.Image = ((System.Drawing.Image)(resources.GetObject("btn_goto_github.Image")));
			this.btn_goto_github.Location = new System.Drawing.Point(652, 354);
			this.btn_goto_github.Name = "btn_goto_github";
			this.btn_goto_github.Size = new System.Drawing.Size(120, 45);
			this.btn_goto_github.TabIndex = 2;
			this.btn_goto_github.UseVisualStyleBackColor = true;
			this.btn_goto_github.Click += new System.EventHandler(this.Btn_goto_githubClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Location = new System.Drawing.Point(12, 192);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(269, 156);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Шаг 2";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(15, 39);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(244, 23);
			this.label7.TabIndex = 0;
			this.label7.Text = "- Запустите кошелек";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btn_help_export);
			this.groupBox3.Controls.Add(this.button3);
			this.groupBox3.Location = new System.Drawing.Point(296, 192);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(476, 155);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Шаг 3. Управление ключами";
			// 
			// btn_help_export
			// 
			this.btn_help_export.Location = new System.Drawing.Point(345, 65);
			this.btn_help_export.Name = "btn_help_export";
			this.btn_help_export.Size = new System.Drawing.Size(34, 33);
			this.btn_help_export.TabIndex = 1;
			this.btn_help_export.Text = "?";
			this.btn_help_export.UseVisualStyleBackColor = true;
			this.btn_help_export.Click += new System.EventHandler(this.Btn_help_exportClick);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(100, 65);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(239, 33);
			this.button3.TabIndex = 0;
			this.button3.Text = "Экспорт приватных ключей";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(784, 411);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btn_goto_github);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "QT Private Saver | Утилита";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btn_help_export;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btn_find_bdir;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_goto_github;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
