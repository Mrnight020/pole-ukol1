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
    public partial class Ukol2 : Form
    {
        public Ukol2()
        {
            InitializeComponent();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {

            listBox2.Items.Clear();
            listBox1.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            label6.Text = "***";
            label7.Text = "***";
            label8.Text = "***";
            Random rng = new Random();
            int[] pole = new int[15];

            for (int i = 0; i < 15; i++)
            {
                pole[i] = rng.Next(0, 10);
            }
            int povinnanula = rng.Next(0, 15);
            pole[povinnanula] = 0;
            foreach (int c in pole)
            {
                listBox1.Items.Add(c);                   
            }
            int cisilko = 20;
            int prvninula = 0;
            for (int i = 0; i < 15; i++)
            {
                if (cisilko > pole[i])
                {
                    cisilko = pole[i];
                    prvninula = i;
                }
            }
  
            int[] cislaponulu = new int[prvninula];
            for (int i = 0; i < prvninula; i++)
            {
                cislaponulu[i] = pole[i];
            }

            foreach (int c in cislaponulu)
            {
                listBox2.Items.Add(c);
            }
            float posledniprvek = 0;
            if (prvninula != 0)
            {
            float prvniprvek = cislaponulu[0];
            posledniprvek = cislaponulu[prvninula - 1];
            label6.Text = Convert.ToString(prvniprvek);
            label7.Text = Convert.ToString(posledniprvek);
            label8.Text = Convert.ToString(prvniprvek / posledniprvek);
            }
            else
            {
                MessageBox.Show("Nula je na prvni pozici , zkus to znovu!!");
            }

            for (int c = 0; c < prvninula; c++)
            {
                if(cislaponulu[c] < posledniprvek)
                {
                    listBox3.Items.Add(c+1);
                    listBox4.Items.Add(cislaponulu[c]);
                }
            }




        }

        private void Ukol2_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
