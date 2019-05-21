using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace QTPrivateSaver
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void showHelp(string info) {
			MessageBox.Show(info, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		void Btn_goto_githubClick(object sender, EventArgs e)
		{
			Process.Start("https://github.com/Sagleft/QTPrivateSaver");
		}
		
		void Btn_help_exportClick(object sender, EventArgs e)
		{
			showHelp("Приватный ключ - это как пароль от вашего сейфа. Если вы потеряете такой пароль, то средства из сейфа невозможно будет достать. Чтобы этого не произошло вы можете записать приватный ключ куда-нибудь в безопасное место.");
		}
	}
}
