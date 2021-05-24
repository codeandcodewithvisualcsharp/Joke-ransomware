using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainwinformsapp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Button { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select encrypted file to decrypt";
            op.Filter = "Encrypted file(*.crypt, *.fantom *.666)|*.crypt *.fantom *.666|All files(*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
                return;
        }
    }
}
