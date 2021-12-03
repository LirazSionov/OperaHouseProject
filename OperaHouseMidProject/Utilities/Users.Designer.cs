
namespace OperaHouseMidProject.Utilities
{
    partial class Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.Id_Lable = new System.Windows.Forms.Label();
            this.Name_Lable = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Id_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Id_Lable
            // 
            this.Id_Lable.AutoSize = true;
            this.Id_Lable.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Id_Lable.ForeColor = System.Drawing.Color.LightCoral;
            this.Id_Lable.Location = new System.Drawing.Point(948, 153);
            this.Id_Lable.Name = "Id_Lable";
            this.Id_Lable.Size = new System.Drawing.Size(110, 35);
            this.Id_Lable.TabIndex = 0;
            this.Id_Lable.Text = "ID User";
            this.Id_Lable.Click += new System.EventHandler(this.Id_Lable_Click);
            // 
            // Name_Lable
            // 
            this.Name_Lable.AutoSize = true;
            this.Name_Lable.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name_Lable.ForeColor = System.Drawing.Color.LightCoral;
            this.Name_Lable.Location = new System.Drawing.Point(913, 263);
            this.Name_Lable.Name = "Name_Lable";
            this.Name_Lable.Size = new System.Drawing.Size(145, 35);
            this.Name_Lable.TabIndex = 1;
            this.Name_Lable.Text = "Name User";
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Login_Button.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Login_Button.ForeColor = System.Drawing.Color.LightCoral;
            this.Login_Button.Location = new System.Drawing.Point(628, 411);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(245, 109);
            this.Login_Button.TabIndex = 3;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Id_textBox
            // 
            this.Id_textBox.Location = new System.Drawing.Point(663, 157);
            this.Id_textBox.Name = "Id_textBox";
            this.Id_textBox.Size = new System.Drawing.Size(192, 31);
            this.Id_textBox.TabIndex = 4;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(663, 267);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(192, 31);
            this.Name_textBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(51, 660);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 66);
            this.button1.TabIndex = 6;
            this.button1.Text = "יציאה";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 782);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Id_textBox);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Name_Lable);
            this.Controls.Add(this.Id_Lable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Users";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Id_Lable;
        private System.Windows.Forms.Label Name_Lable;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.TextBox Id_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Button button1;
    }
}