using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperaHouseMidProject.Utilities
{
    public partial class ShowArtistsList : Form
    {
        public ShowArtistsList()
        {
            InitializeComponent();
        }

        private void CRUDArtists_Load(object sender, EventArgs e)
        {
            DataTable dtArtists = new DataTable();
            SqlConnection con = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=MyOperaHouse;" +
                "Trusted_Connection=True;MultipleActiveResultSets=true");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select* from Fluent_artists a,Fluent_players p,Fluent_conductors c", con);
                SqlDataReader reader = cmd.ExecuteReader();
                dtArtists.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            dataGridView1.DataSource = dtArtists;
        }
    

        private void button3_Click(object sender, EventArgs e)
        {
            DirectorSelection directorSelection = new DirectorSelection();
            directorSelection.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
