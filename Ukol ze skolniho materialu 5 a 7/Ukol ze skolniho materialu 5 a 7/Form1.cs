using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol_ze_skolniho_materialu_5_a_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ukol1 ukolek = new Ukol1();
            ukolek.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ukol2 ukolek2 = new Ukol2();
            ukolek2.Show();
        }
    }
}
