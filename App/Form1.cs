using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }
    }
}
