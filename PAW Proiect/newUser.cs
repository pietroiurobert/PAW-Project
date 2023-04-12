using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text.RegularExpressions;

namespace PAW_Proiect
{
    public partial class newUser : Form
    {
        List<Client> lista;

        public newUser()
        {
            InitializeComponent();
            //lista = new List<Client>();
            //FileStream fisier = new FileStream("clienti.dat", FileMode.Open, FileAccess.Read);
            //BinaryFormatter formatter = new BinaryFormatter();
            //lista = (List<Client>)formatter.Deserialize(fisier);
            //fisier.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = tbTelefon.Text;
            string pattern = "^[0123456789]*$";
            if (tbNume.Text == "")
            {
                tbNume.Focus();
                errorProvider1.SetError(tbNume, "Introduceti numele!");
            }
            else if (tbEmail.Text == "")
            {
                tbEmail.Focus();
                errorProvider1.SetError(tbEmail, "Introduceti email-ul!");
            }
            else if (tbTelefon.Text == "")
            {
                tbTelefon.Focus();
                errorProvider1.SetError(tbTelefon, "Introduceti numarul de telefon!");
            }
            else if (!Regex.IsMatch(input, pattern) || input.Length != 9 || !input.Substring(0, 1).Equals("7"))
            {
                tbTelefon.Focus();
                errorProvider1.SetError(tbTelefon, "Introduceti un numar de telefon valid!");
            }
            else
            {
                errorProvider1.Clear();
                Client client = new Client();
                client.Nume = tbNume.Text;
                client.Email = tbEmail.Text;
                client.Telefon = "0" + tbTelefon.Text;
                newUserPassword user = new newUserPassword(this, client, lista);
                user.ShowDialog(this);
            }
        }

        private void newUser_Load(object sender, EventArgs e)
        {

        }
    }
}