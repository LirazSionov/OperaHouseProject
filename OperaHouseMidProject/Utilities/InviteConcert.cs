using OperaHouseMidProject.DataAccess;
using OperaHouseMidProject.Model;
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
    public partial class InviteConcert : Form
    {
        public InviteConcert()
        {
            InitializeComponent();
        }

        private void  button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (textBox5.Text == "") || (textBox6.Text == "") || (textBox7.Text == ""))
                {
                    MessageBox.Show("השלם שדות ריקים", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    using (var dbContext = new BlogDBContext())
                    {
                        var guest = new Fluent_guests { GuestId = textBox1.Text, GuestName = textBox2.Text, PhoneNumber = textBox3.Text, ConcertName = textBox4.Text, HallName = textBox5.Text, DateConcert = textBox6.Text, Hour = textBox7.Text };
                        dbContext.Add(guest);
                        dbContext.SaveChanges();
                    }
                    MessageBox.Show("הפרטים נשמרו בהצלחה" +
                         "נתראה בבית האופרה" +
                         "תודה על הרשמתך.", "Saved successfully", MessageBoxButtons.OK);
                    ConcertsListToInvite concerts = new ConcertsListToInvite();
                    concerts.Show();
                    this.Close();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
