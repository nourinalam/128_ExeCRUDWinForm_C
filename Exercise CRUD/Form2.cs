using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_CRUD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'daftarlaptopDataSet.Lenovo' table. You can move, or remove it, as needed.
            this.lenovoTableAdapter.Fill(this.daftarlaptopDataSet.Lenovo);
            // TODO: This line of code loads data into the 'daftarlaptopDataSet.Asus' table. You can move, or remove it, as needed.
            this.asusTableAdapter.Fill(this.daftarlaptopDataSet.Asus);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
        }
    }
}
