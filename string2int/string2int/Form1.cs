using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string2int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string a1 = QuesA.Text;
            string a1_ = new String(a1.Where(Char.IsDigit).ToArray());
            AnsA.Value = Convert.ToInt32(a1_);

            string b1 = QuesB.Text;
            string b1_ = new String(b1.Where(Char.IsDigit).ToArray());
            AnsB.Value = Convert.ToInt32(b1_);
        }
    }
}
