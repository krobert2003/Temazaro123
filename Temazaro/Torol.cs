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
    public partial class Torol : Form
    {
        public Torol()
        {
            InitializeComponent();
        }

        public void Torol_Load(object sender, EventArgs e)
        {
            Program.form1.listBox1_update.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.conn.Open();
            Program.cmd.CommandText = "DELETE FROM `konyv` WHERE Id = @id";
            Program.cmd.Parameters.Clear();
            Program.cmd.Parameters.AddWithValue("@id", textBox1.Text);

          
            if (Program.cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Sikeresen törlés!");
                Program.conn.Close();
                textBox1.Text = "";

              
            }
            else
            {
                MessageBox.Show("sikertelen  törlés!");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
