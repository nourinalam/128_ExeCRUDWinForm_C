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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'daftarlaptopDataSet.Hp' table. You can move, or remove it, as needed.
            this.hpTableAdapter.Fill(this.daftarlaptopDataSet.Hp);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
        }
    }
}
