using OperaHouseMidProject.DataAccess;
using OperaHouseMidProject.Model;
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
    public partial class CRUDConcerts : Form
    {
        public CRUDConcerts()
        {
            InitializeComponent();
        }

        private void CRUDConcerts_Load(object sender, EventArgs e)
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
                dataGridView1.DataSource = dtConcerts;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (textBox5.Text == ""))
                {
                    MessageBox.Show("השלם שדות ריקים", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    using (var dbContext = new BlogDBContext())
                    {
                        var _concerts = new Fluent_concerts { ConcertId = textBox1.Text, InstanceName = textBox2.Text, ConductorName = textBox3.Text, Duration = textBox4.Text, Date = textBox8.Text , Hour = textBox5.Text ,HallName = textBox6.Text, HallNum = textBox9.Text , Cost = textBox7.Text };
                        dbContext.Add(_concerts);
                        dbContext.SaveChanges();
                        MessageBox.Show("הפרטים נשמרו בהצלחה", "Saved successfully", MessageBoxButtons.OK);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        textBox8.Text = "";
                        textBox9.Text = "";

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
            dataGridView1.DataSource = dtConcerts;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select row to delete");

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Delete concert by concertId
                if( (MessageBox.Show("Are you sure to delete?","Sure delete?",MessageBoxButtons.YesNo)==DialogResult.Yes))
                {
                    DataTable dtConcerts = new DataTable();
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ConcertId"].FormattedValue.ToString());
                    SqlConnection con = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=MyOperaHouse;" +
                        "Trusted_Connection=True;MultipleActiveResultSets=true");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete Fluent_concerts where ConcertId='" + id + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully");
                    SqlCommand cmd2 = new SqlCommand("select* from Fluent_concerts", con);
                    SqlDataReader reader = cmd2.ExecuteReader();
                    dtConcerts.Load(reader);
                    dataGridView1.DataSource = dtConcerts;
                    con.Close();
                }
               
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DirectorSelection directorSelection = new DirectorSelection();
            directorSelection.Show();
            this.Close();
        }
    }
}
