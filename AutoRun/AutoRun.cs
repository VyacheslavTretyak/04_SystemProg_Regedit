using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRun
{
	public partial class AutoRun : Form
	{		
		public AutoRun()
		{
			InitializeComponent();
			btnRemove.Enabled = false;
			LoadRegistry();
			listBoxProg.SelectedIndexChanged += ListBoxProg_SelectedIndexChanged;
			btnAdd.Click += BtnAdd_Click;
			btnRemove.Click += BtnRemove_Click;
		}

		private void BtnRemove_Click(object sender, EventArgs e)
		{
			RegistryKey curUser = Registry.CurrentUser;
			RegistryKey key = curUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
			key.DeleteValue(listBoxProg.SelectedItem.ToString());
			key.Close();
			curUser.Close();
			listBoxProg.Items.Clear();
			LoadRegistry();
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			DialogResult res = openFileDialog.ShowDialog();
			if (res == DialogResult.OK)
			{
				AddProg();
			}
		}

		private void AddProg()
		{
			RegistryKey curUser = Registry.CurrentUser;
			RegistryKey key = curUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
			string str = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
			key.SetValue(str, openFileDialog.FileName);
			key.Close();
			curUser.Close();
			listBoxProg.Items.Clear();
			LoadRegistry();
			
		}

		private void ListBoxProg_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnRemove.Enabled = (listBoxProg.SelectedItems.Count > 0);			
		}

		private void LoadRegistry()
		{
			RegistryKey curUser = Registry.CurrentUser;
			RegistryKey key = curUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");		
			foreach (var item in key.GetValueNames())
			{
				listBoxProg.Items.Add(item);
			}
			
		}
	}
}
