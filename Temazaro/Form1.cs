﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temazaro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void szerkesztToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.formSzerkeszt.ShowDialog(this);
          
           
        }

        private void újAdatHozzáadásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.formuj.ShowDialog(this);
        }

        private void könyvTörléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.formtorol.ShowDialog(this);
        }

        private void listBox1_update_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            listBox1_update.Items.Clear();
            Program.cmd.CommandText = "SELECT * FROM `konyv`;";
            Program.conn.Open();
            using (MySqlDataReader dr = Program.cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    konyv uj = new konyv(dr.GetInt32("id"), dr.GetString("szerzo"), dr.GetString("cim"), dr.GetString("fajta"));
                    listBox1_update.Items.Add(uj);
                }
               

            }
            listBox1_update.Update();
            Program.conn.Close();
           
        }

       
    }
}
