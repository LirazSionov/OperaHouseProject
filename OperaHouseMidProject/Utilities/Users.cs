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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Id_Lable_Click(object sender, EventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
        {

        }
       

        private  void Login_Button_Click(object sender, EventArgs e)
        {
            const string directorMessage = "Hello dear manager welcome to OperaHouse";
            const string guestMessage = "Hello dear guest welcome to OperaHouse";
            try
            {
                if ((Id_textBox.Text == "011023066") && ((Name_textBox.Text == "Gabi Sionov") || (Name_textBox.Text == "gabi sionov")))
                {
                    DirectorSelection directorSelect = new DirectorSelection();
                    MessageBox.Show(directorMessage, "Welcome", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                    directorSelect.Show();

                }
                else if ((Id_textBox.Text == "212733786") && ((Name_textBox.Text == "Liraz Sionov") || (Name_textBox.Text == "liraz sionov")))
                {
                    ConcertsListToInvite concertInvite = new ConcertsListToInvite();
                    MessageBox.Show(guestMessage, "Welcome", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                    concertInvite.Show();
                }
                else if ((Id_textBox.Text == "") || (Name_textBox.Text == ""))
                {
                    const string captionEmpty = "Empty filed";
                    MessageBox.Show("Please fill the empty place", captionEmpty, MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    const string captionInvalid = "Invalid details";
                    var result = MessageBox.Show("In correct details!!" +
                        "Do you want to try again", captionInvalid, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        this.Close();
                        HomePage hp = new HomePage();
                        hp.Show();
                    }
                    else { }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
       

        private  void button1_Click(object sender, EventArgs e)
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
