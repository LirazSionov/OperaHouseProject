
namespace OperaHouseMidProject.Utilities
{
    partial class ConcertsListToInvite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConcertsListToInvite));
            this.showConcertGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showConcertGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // showConcertGrid
            // 
            this.showConcertGrid.AllowUserToAddRows = false;
            this.showConcertGrid.AllowUserToDeleteRows = false;
            this.showConcertGrid.AllowUserToResizeColumns = false;
            this.showConcertGrid.AllowUserToResizeRows = false;
            this.showConcertGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showConcertGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showConcertGrid.Location = new System.Drawing.Point(58, 158);
            this.showConcertGrid.Name = "showConcertGrid";
            this.showConcertGrid.ReadOnly = true;
            this.showConcertGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.showConcertGrid.RowHeadersWidth = 62;
            this.showConcertGrid.RowTemplate.Height = 33;
            this.showConcertGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showConcertGrid.Size = new System.Drawing.Size(1335, 478);
            this.showConcertGrid.TabIndex = 0;
            this.showConcertGrid.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.showConcertGrid_RowHeaderMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(411, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "רשימת הקונצרטים הקרובים";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(12, 658);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 64);
            this.button2.TabIndex = 3;
            this.button2.Text = "יציאה";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(1028, 658);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(387, 64);
            this.button3.TabIndex = 4;
            this.button3.Text = "לחזרה לדף הראשי";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(642, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "בחר קונצרט";
            // 
            // ConcertsListToInvite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1436, 745);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showConcertGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConcertsListToInvite";
            this.Text = "ConcertsListToInvite";
            this.Load += new System.EventHandler(this.ConcertsListToInvite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showConcertGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView showConcertGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
    }
}