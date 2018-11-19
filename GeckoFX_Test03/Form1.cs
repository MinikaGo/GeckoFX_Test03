using Gecko;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeckoFX_Test03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Xpcom.Initialize("Firefox");
            var geckoWebBrowser = new GeckoWebBrowser { Dock = DockStyle.Fill };
            //Form f = new Form();
            geckoWebBrowser1.Controls.Add(geckoWebBrowser);
            geckoWebBrowser.Navigate("www.google.com");
            //Application.Run(f);
        }
    }
}
