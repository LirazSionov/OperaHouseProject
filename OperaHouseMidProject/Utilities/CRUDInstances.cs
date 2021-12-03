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
    public partial class CRUDInstances : Form
    {
        public CRUDInstances()
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
        public async Task button1_ClickAsync() 
        {
            try
            {
                string id = textBox1.Text;
                if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (textBox5.Text == ""))
                {
                    MessageBox.Show("השלם שדות ריקים", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    using (var dbContext = new BlogDBContext())
                    {
                        //Query hwo checking if the new instaneId is exist in DB 
                        //string quary =(from InstanceTypef in dbContext.Fluent_InstanceType
                        //               where InstanceTypef.InstanceID==id
                        //               select InstanceTypef.InstanceID).ToString();
                        //Convert.ToInt32(quary);
                        //Convert.ToInt32(id);
                        //if (id==quary)
                        //{
                        //    MessageBox.Show("קוד קונצרט כבר קיים" +
                        //        "שנה קוד", "Error", MessageBoxButtons.OK);
                        //}
                        //else
                        //{
                        var InstanceType = new Fluent_InstanceType { InstanceID = textBox1.Text, Name = textBox2.Text, Composer = textBox3.Text, Writer = textBox4.Text, DateWriting = textBox5.Text };
                        dbContext.Add(InstanceType);
                        dbContext.SaveChanges();
                        MessageBox.Show("הפרטים נשמרו בהצלחה", "Saved successfully", MessageBoxButtons.OK);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        await LoadInstanceGridAsync();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            await button1_ClickAsync();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DirectorSelection directorSelection = new DirectorSelection();
            directorSelection.Show();
            this.Close();
        }
        
        private async Task LoadInstanceGridAsync()
        {
            DataTable dtInctances = new DataTable();
            SqlConnection con = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=MyOperaHouse;" +
                "Trusted_Connection=True;MultipleActiveResultSets=true");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select* from Fluent_InstanceType", con);
                SqlDataReader reader = cmd.ExecuteReader();
                dtInctances.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            await Task.Delay(100);
           dataGridView1.DataSource =dtInctances;
        }
        private async void CRUDInstances_Load(object sender, EventArgs e)
        {
           await LoadInstanceGridAsync();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
