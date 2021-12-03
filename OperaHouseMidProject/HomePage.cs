using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperaHouseMidProject
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void backgroung_picture_Click(object sender, EventArgs e)
        {

        }

        private  void button1_Click_1(object sender, EventArgs e)
        {
            var result1 = MessageBox.Show("Do you want to exit?", "Time to yay goodbye?👋", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                var result2 = MessageBox.Show("Are you sure?", "Time to yay goodbye?👋", MessageBoxButtons.YesNo);
                if (result2 == DialogResult.Yes)
                    Application.Exit();
                else { }
            }
            else { }
        }
        
    }
}
