using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAW_Proiect
{
    public partial class customer : Form
    {
        Dictionary<Produs, int> achizitie = new Dictionary<Produs, int>();
        string username;
        public customer(string username)
        {
            InitializeComponent();
            this.username = username;
            label2.Text =  "Bun venit, " + username;
            //if (sumaProduse == 0)
            //   label3.Text = "Nu aveti produse in cos!";
            //else
            //    label3.Text = sumaProduse.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shop form2 = new Shop(achizitie);
            form2.ShowDialog();

        }

        private void customer_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(achizitie.ElementAt(0).ToString());
            //foreach (KeyValuePair<Produs, int> item in achizitie)
            //    sumaProduse += item.Value;
            //MessageBox.Show(sumaProduse.ToString());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            shoppingCart form = new shoppingCart(achizitie, username);
            form.ShowDialog();
        }
    }
}
