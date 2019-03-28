using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeSearch;

namespace YoutubeBrowser
{
    public partial class Browser : Form
    {
        private bool searched = false;
        private string searchStr = " Search";
        private static Dictionary<Button, string> dict;
        private static List<Button> history;
        private static List<Button> home;

        public Browser()
        {
            InitializeComponent();
            dict = new Dictionary<Button, string>();
            history = new List<Button>();
            home = new List<Button>();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            foreach(Button b in history)
            {
                panelContent.Controls.Add(b);
            }
        }
        
        private void txtBoxSearch_Click(object sender, EventArgs e)
        {
            if (!searched)
            {
                txtBoxSearch.Text = "";
                searched = true;
            }
        }

        private void txtBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                doSearch();
            }
        }

        private void picBoxSearchBtn_Click(object sender, EventArgs e)
        {
            doSearch();
        }

        private void doSearch()
        {
            panelContent.Controls.Clear();
            home.Clear();
            VideoSearch vs = new VideoSearch();
            foreach (var item in vs.SearchQuery(txtBoxSearch.Text, 1))
            {
                Button b = new Button();
                b.Width = 340;
                b.Height = 356;
                b.TextImageRelation = TextImageRelation.TextAboveImage;
                b.Text = item.Title;
                b.ForeColor = Color.White;
                b.Font = new Font("Century Gothic", 18);
                byte[] imgBytes = new WebClient().DownloadData(item.Thumbnail);
                using (MemoryStream ms = new MemoryStream(imgBytes))
                {
                    b.Image = Image.FromStream(ms);
                }
                dict.Add(b, item.Url);
                b.Click += new EventHandler(videoClick);
                panelContent.Controls.Add(b);
                home.Add(b);
            }
        }

        private void videoClick(object sender, System.EventArgs e)
        {
            Button b = (Button)sender;
            history.Add(b);
            string url = dict[b];
            string code = url.Substring(url.IndexOf('=') + 1);
            Watch watchForm = new Watch(code);
            watchForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            txtBoxSearch.Text = searchStr;
            foreach(Button b in home)
            {
                panelContent.Controls.Add(b);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            history.Clear();
            home.Clear();
            dict.Clear();
            searched = false;
            searchStr = " Search";
            txtBoxSearch.Text = " Search";
        }
    }
}
