using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperaHouseMidProject.Utilities
{
    public partial class DirectorSelection : Form
    {
        public DirectorSelection()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            CRUDConcerts cRUD = new CRUDConcerts();
            cRUD.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CRUDInstances cRUDInstances = new CRUDInstances();
            cRUDInstances.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void DirectorSelection_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowArtistsList cRUDArtists = new ShowArtistsList();
            cRUDArtists.Show();
            this.Close();
        }
    }
}
