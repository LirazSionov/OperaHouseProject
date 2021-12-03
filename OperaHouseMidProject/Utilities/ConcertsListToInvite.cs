
using OperaHouseMidProject.DataAccess;
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
    public partial class ConcertsListToInvite: Form
    {
        public ConcertsListToInvite()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
            this.Close();
        }

        private void ConcertsListToInvite_Load(object sender, EventArgs e)
        {
            DataTable dtConcerts = new DataTable();
            SqlConnection con = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=MyOperaHouse;" +
                "Trusted_Connection=True;MultipleActiveResultSets=true");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select* from Fluent_concerts", con);
                SqlDataReader reader = cmd.ExecuteReader();
                dtConcerts.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            showConcertGrid.DataSource = dtConcerts;
        }

        private void showConcertGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var result = MessageBox.Show("?האם ברצונך להרשם לקונצרט זה", "הרשמה", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                InviteConcert inviteConcert = new InviteConcert();
                inviteConcert.Show();
                
            }
            else { }
        }
    }
}
