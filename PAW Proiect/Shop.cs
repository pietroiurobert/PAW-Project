﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PAW_Proiect
{
    public partial class Shop : Form
    {
        List<Produs> listaProduse = new List<Produs>();
        //internal vs public class (to search)
        public Shop()
        {
            InitializeComponent();
            Produs produs1 = new Produs();
            
            FileStream fisier = new FileStream("produse.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            listaProduse = (List<Produs>)formatter.Deserialize(fisier);
            foreach(Produs produs in listaProduse)
            {
                ltProduse.Items.Add(produs);
            }
            fisier.Close();  
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Shop_Load(object sender, EventArgs e)
        {

        }
    }
} 