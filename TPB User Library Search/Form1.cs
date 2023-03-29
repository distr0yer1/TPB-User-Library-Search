using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Threading;

namespace TPB_User_Library_Search
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private class TPB_Item
		{
			public long id;
			public string name;
			public short leechers;
			public short seeders;
			public int files;
			public long size;
			//public long added;
			public DateTime added;
			public short category;

			public TPB_Item(string input)
			{
				string[] data1 = input.Replace("\",\"", "\n").Split('\n');
				id = long.Parse(data1[0].Replace("\":\"", "\n").Split('\n')[1]);
				name = data1[1].Replace("\":\"", "\n").Split('\n')[1];
				leechers = short.Parse(data1[3].Replace("\":\"", "\n").Split('\n')[1]);
				seeders = short.Parse(data1[4].Replace("\":\"", "\n").Split('\n')[1]);
				files = int.Parse(data1[5].Replace("\":\"", "\n").Split('\n')[1]);
				size = long.Parse(data1[6].Replace("\":\"", "\n").Split('\n')[1]);
				//added = long.Parse(data1[8].Replace("\":\"", "\n").Split('\n')[1]);
				added = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(long.Parse(data1[8].Replace("\":\"", "\n").Split('\n')[1])).ToLocalTime();
				category = short.Parse(data1[10].Replace("\":\"", "\n").Split('\n')[1]);
			}

			override
			public string ToString()
			{
				if (size < 1024)
					return size.ToString() + " B | " + name;
				if (size < 1048576)
					return (size / 1024).ToString() + " KB | " + name;
				if (size < 1073741824)
					return (size / 1048576).ToString() + " MB | " + name;
				return (size / 1073741824).ToString() + " GB | " + name;

			}
		}

		private class InputParams
		{
			public string username;
			public short increm;
			public short offset;

			public InputParams(string u, short i, short o)
			{
				username = u;
				increm = i;
				offset = o;
			}
		}

		const string tpb_Search_API = "https://apibay.org/q.php?q=user:";
		const string tpb_Item_Desc = "https://apibay.org/t.php?id=";
		const string tpb_Item_Content = "https://apibay.org/f.php?id=";
		const string tpb_URL = "https://thepiratebay.org/description.php?id=";
		List<TPB_Item> user_List = new List<TPB_Item> { };
		Thread thread;

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnUsername_Click(object sender, EventArgs e)
		{
			user_List = new List<TPB_Item> { };

			const short searchThreads = 8;
			//thread 1
			thread = new Thread(new ParameterizedThreadStart(userLoader));
			thread.IsBackground = true;
			thread.Start(new InputParams(txtUsername.Text, searchThreads, 0));

			for (short i = 1; i < searchThreads; i++)
			{
				Thread thread2 = new Thread(new ParameterizedThreadStart(userLoader));
				thread2.IsBackground = true;
				thread2.Start(new InputParams(txtUsername.Text, searchThreads, i));
			}

			lbxContent.Items.AddRange(user_List.ToArray());
			tmrUpdate.Enabled = true;
			btnUsername.Enabled = false;
			btnFilter.Enabled = false;
		}

		private void userLoader(object input)
		{
			using (WebClient client = new WebClient())
			{
				bool items_exist = true;
				for (int i = ((InputParams)input).offset; items_exist; i+= ((InputParams)input).increm)
				{
					string tmp = client.DownloadString(tpb_Search_API + ((InputParams)input).username + ":" + i.ToString());
					if (tmp.Contains("No results returned"))
						items_exist = false;
					else
					{
						tmp = tmp.Remove(tmp.Length - 3).Remove(0, 3);
						string[] tmp2 = tmp.Replace("},{", "\n").Split('\n');
						foreach (string x in tmp2)
							user_List.Add(new TPB_Item(x));
					}
				}
			}
		}

		private void tmrUpdate_Tick(object sender, EventArgs e)
		{
			if (!thread.IsAlive)
			{
				btnUsername.Enabled = true;
				btnFilter.Enabled = true;
			}
			lblItems.Text = (user_List.Count / 50 + 1).ToString();
		}

		private void btnFilter_Click(object sender, EventArgs e)
		{
			List<TPB_Item> sorted = new List<TPB_Item> { };
			if (rbnFiles.Checked)
				sorted = user_List.OrderBy(f => f.files).ToList();
			else if (rbnLeecher.Checked)
				sorted = user_List.OrderBy(f => f.leechers).ToList();
			else if (rbnName.Checked)
				sorted = user_List.OrderBy(f => f.name).ToList();
			else if (rbnSeeder.Checked)
				sorted = user_List.OrderBy(f => f.seeders).ToList();
			else if (rbnSize.Checked)
				sorted = user_List.OrderBy(f => f.size).ToList();
			else if (rbnUploaded.Checked)
				sorted = user_List.OrderBy(f => f.added).ToList();
			if (txtSearch.TextLength > 0)
				sorted = sorted.FindAll(f => f.name.ToLower().Contains(txtSearch.Text.ToLower()));
			if (cbxFlip.Checked)
				sorted.Reverse();

			displaySorted(sorted);
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			
		}

		private void displaySorted(List<TPB_Item> sorted)
		{
			lbxContent.Items.Clear();
			lbxContent.Items.AddRange(sorted.ToArray());
		}

		private void Form1_ResizeEnd(object sender, EventArgs e)
		{
			lbxContent.Width = this.Width - 339;
			lbxContent.Height = this.Height - 55;
		}

		private void lbxContent_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (MessageBox.Show(tpb_URL + ((TPB_Item)lbxContent.SelectedItem).id.ToString() + "\n(OK to copy)", "Page URL", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
				Clipboard.SetText(tpb_URL + ((TPB_Item)lbxContent.SelectedItem).id.ToString());
		}
	}
}
