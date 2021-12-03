using OperaHouseMidProject.Model;
using OperaHouseMidProject.Utilities;
using System;
using System.Threading.Tasks;

namespace OperaHouseMidProject
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.logoPictures = new System.Windows.Forms.PictureBox();
            this.Details_label = new System.Windows.Forms.Label();
            this.Details2_lable = new System.Windows.Forms.Label();
            this.Continue_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictures)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPictures
            // 
            this.logoPictures.BackColor = System.Drawing.SystemColors.Control;
            this.logoPictures.Image = ((System.Drawing.Image)(resources.GetObject("logoPictures.Image")));
            this.logoPictures.Location = new System.Drawing.Point(1356, 29);
            this.logoPictures.Name = "logoPictures";
            this.logoPictures.Size = new System.Drawing.Size(347, 96);
            this.logoPictures.TabIndex = 0;
            this.logoPictures.TabStop = false;
            // 
            // Details_label
            // 
            this.Details_label.AutoSize = true;
            this.Details_label.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Details_label.ForeColor = System.Drawing.Color.Yellow;
            this.Details_label.Location = new System.Drawing.Point(614, 9);
            this.Details_label.Name = "Details_label";
            this.Details_label.Size = new System.Drawing.Size(593, 67);
            this.Details_label.TabIndex = 2;
            this.Details_label.Text = "עונת האופרה 2022-2021\r\n";
            this.Details_label.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Details2_lable
            // 
            this.Details2_lable.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Details2_lable.Font = new System.Drawing.Font("Castellar", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Details2_lable.ForeColor = System.Drawing.SystemColors.Info;
            this.Details2_lable.Location = new System.Drawing.Point(1356, 173);
            this.Details2_lable.Name = "Details2_lable";
            this.Details2_lable.Size = new System.Drawing.Size(325, 486);
            this.Details2_lable.TabIndex = 3;
            this.Details2_lable.Text = resources.GetString("Details2_lable.Text");
            this.Details2_lable.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Continue_button
            // 
            this.Continue_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Continue_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Continue_button.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Continue_button.ForeColor = System.Drawing.Color.Yellow;
            this.Continue_button.Location = new System.Drawing.Point(44, 698);
            this.Continue_button.Name = "Continue_button";
            this.Continue_button.Padding = new System.Windows.Forms.Padding(3);
            this.Continue_button.Size = new System.Drawing.Size(286, 70);
            this.Continue_button.TabIndex = 4;
            this.Continue_button.Text = "לפרטים והזמנה";
            this.Continue_button.UseVisualStyleBackColor = false;
            this.Continue_button.Click += new System.EventHandler(this.Continue_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 784);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 784);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(1424, 714);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(121, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "יציאה";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1832, 805);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Continue_button);
            this.Controls.Add(this.Details2_lable);
            this.Controls.Add(this.Details_label);
            this.Controls.Add(this.logoPictures);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HomePage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OperaHouse-HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.SizeChanged += new System.EventHandler(this.HomePage_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HomePage_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private  void Continue_button_Click(object sender, EventArgs e)
        {
            Users usersForm = new Users();
            usersForm.Show();
            this.Hide();
        }
        

        #endregion

        private System.Windows.Forms.PictureBox logoPictures;
        private System.Windows.Forms.Label Details_label;
        private System.Windows.Forms.Label Details2_lable;
        private System.Windows.Forms.Button Continue_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

