using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeBrowser
{
    public partial class Watch : Form
    {
        private static string code;
        public Watch(String s)
        {
            code = s;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            
            base.OnLoad(e);
            var embed = "<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
            "</head><body>" +
            "<iframe width=\"" + webBrowser1.Width + "\" height=\"" + webBrowser1.Height + "\" src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";
            string url = "https://www.youtube.com/embed/" + code;
            this.webBrowser1.DocumentText = string.Format(embed, url);
        }
     }
}
