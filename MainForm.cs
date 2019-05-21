using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using Bitnet.Client;

namespace QTPrivateSaver
{
	public partial class MainForm : Form
	{
		BitnetClient bc = null;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void showHelp(string info) {
			MessageBox.Show(info, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		void openExplorer(string path) {
			if(Directory.Exists(path)) {
				Process.Start(new ProcessStartInfo("explorer.exe", path));
			} else {
				Debug.Print("path not found");
			}
		}
		
		string findBDir() {
			string path_appdata = Environment.ExpandEnvironmentVariables("%appdata%");
			string path_blockchain = path_appdata + @"\MFCoin";
			if(Directory.Exists(path_blockchain)) {
				return path_blockchain;
			} else {
				return "";
			}
		}
		
		void Btn_goto_githubClick(object sender, EventArgs e)
		{
			Process.Start("https://github.com/Sagleft/QTPrivateSaver");
		}
		
		void Btn_help_exportClick(object sender, EventArgs e)
		{
			showHelp("Приватный ключ - это как пароль от вашего сейфа. Если вы потеряете такой пароль, то средства из сейфа невозможно будет достать. Чтобы этого не произошло вы можете записать приватный ключ куда-нибудь в безопасное место.");
		}
		
		void LinkLabel_confDirLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			openExplorer("conf");
		}
		
		void Btn_find_bdirClick(object sender, EventArgs e)
		{
			string path_blockchain = findBDir();
			if(path_blockchain != "") {
				openExplorer(path_blockchain);
			} else {
				showHelp("Не удалось найти директорию");
			}
		}
		
		void Btn_help_bdataClick(object sender, EventArgs e)
		{
			showHelp("Для пользователя с именем Username\nи локальным диском C папка должна быть по адресу вида:\n\nC:/Пользователи/UserName/AppData/Roaming/MFCoin");
		}
		
		void Btn_tryCopy_confClick(object sender, EventArgs e)
		{
			//TODO: проверку существования папки conf в директории утилиты,
			//а также самого conf файла
			string conf_name = "MFCoin.conf";
			string path_blockchain = findBDir();
			string path_conf = path_blockchain + @"\" + conf_name;
			
			if(path_blockchain != "") {
				if(File.Exists(path_conf)) {
					DialogResult result = MessageBox.Show("Файл " + conf_name + " уже существует, заменить?", "Требуется выбор", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
					if(result == DialogResult.Yes) {
						//производим замену
						try {
							File.Copy("conf" + @"\" + conf_name, path_conf, true);
							//проверка на всякий пожарный
							if(File.Exists(path_conf)) {
								showHelp("Успешно!");
							}
						} catch(Exception ex) {
							Debug.Print("Отловлено исключение: " + ex.Message);
							showHelp("Что-то пошло не так.\nВозможно, требуется запустить утилиту\nот имени администратора");
						}
					}
				}
			} else {
				showHelp("Не удалось найти конечную папку");
			}
		}
		
		bool walletConnect() {
			//TODO: грузить данные для подключения из .conf файла
			//TODO: сделать генерацию .conf файлов со случайными данными
			BitnetClient client = new BitnetClient("http://127.0.0.1:22823");
     		client.Credentials = new NetworkCredential("user", "password");
     		bool result = true;
     		//проверка
     		try {
     			client.GetBalance();
     			bc = client;
     		} catch(Exception ex) {
     			result = false;
     			Debug.Print("Отловлено исключение: " + ex.Message);
     		}
     		return result;
		}
		
		void check_wallet() {
			if(walletConnect()) {
				showHelp("Всё ОК");
			} else {
				showHelp("Не удалось подключиться к кошельку");
			}
		}
		
		void Btn_test_connectionClick(object sender, EventArgs e)
		{
			check_wallet();
		}
		
		void Btn_export_keysClick(object sender, EventArgs e)
		{
			//можно было более элегантно, но и так сойдет
			if(bc == null) {
				walletConnect();
			}
			
			if(bc != null) {
				//если юзверь говорит, что кошелек зашифрован
				if(checkBox_locked.Checked) {
					//пусть по 1 секунде на аккаунт
					int unlock_timeout = bc.GetAccountsCount() * 2;
					try {
						bc.WalletPassphrase(textBox_password.Text, unlock_timeout);
					} catch(Exception ex) {
						showHelp("Пароль не подходит или кошелек уже разблокирован");
					}
				}
				bool success = false;
				Dictionary<string, string> keys = new Dictionary<string, string>();
				this.SuspendLayout();
				try {
					keys = bc.GetAccountsKeys();
					success = true;
				} catch(Exception ex) {
					//Debug.Print("Отловлена ошибка: " + ex.Message);
					showHelp("Что-то пошло не так:\n\n" + ex.Message);
				}
				this.ResumeLayout();
				if(success) {
					if (saveKeysDialog.ShowDialog() == DialogResult.OK)
	               	{
	                    string path = saveKeysDialog.FileName;
	                    string result = "Экспорт приватных ключей, QTPrivateSaver v." + Application.ProductVersion + Environment.NewLine;
	                    foreach(string ac_name in keys.Keys) {
	                    	result += Environment.NewLine + ac_name + ": " + keys[ac_name];
	                    }
	                    using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
						{
							// преобразуем строку в байты
							byte[] array = System.Text.Encoding.Default.GetBytes(result);
							// запись массива байтов в файл
							try {
								fstream.Write(array, 0, array.Length);
								//проверка, успешно ли записался файл
								if(File.Exists(path)) {
									showHelp("Экспортирвано!");
								} else {
									showHelp("Что-то пошло не так, не удалось сохранить файл.\nПопробуйте запустить от имени администратора");
								}
							} catch(Exception ex) {
								showHelp("Произошла ошибка:\n\n" + ex.Message);
							}
						}
	                }
				}
			} else {
				showHelp("Не удалось подключиться к кошельку");
			}
		}
	}
}
