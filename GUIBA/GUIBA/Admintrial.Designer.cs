
namespace GUIBA
{
    partial class Admintrial
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.food_UC1 = new GUIBA.Food_UC();
            this.sweet_UC1 = new GUIBA.Sweet_UC();
            this.drink_UC2 = new GUIBA.Drink_UC();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Bisque;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1434, 185);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GUIBA.Properties.Resources.chef;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(931, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(233, 194);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(271, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(604, 57);
            this.label2.TabIndex = 1;
            this.label2.Text = "Food to put you in a good mood.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(378, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuisine Food";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.food_UC1);
            this.panel2.Controls.Add(this.sweet_UC1);
            this.panel2.Controls.Add(this.drink_UC2);
            this.panel2.Location = new System.Drawing.Point(211, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 491);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // food_UC1
            // 
            this.food_UC1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.food_UC1.Location = new System.Drawing.Point(3, 3);
            this.food_UC1.Name = "food_UC1";
            this.food_UC1.Size = new System.Drawing.Size(1208, 491);
            this.food_UC1.TabIndex = 11;
            this.food_UC1.Load += new System.EventHandler(this.food_UC1_Load);
            // 
            // sweet_UC1
            // 
            this.sweet_UC1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sweet_UC1.Location = new System.Drawing.Point(-2, 3);
            this.sweet_UC1.Name = "sweet_UC1";
            this.sweet_UC1.Size = new System.Drawing.Size(1004, 491);
            this.sweet_UC1.TabIndex = 4;
            // 
            // drink_UC2
            // 
            this.drink_UC2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.drink_UC2.Location = new System.Drawing.Point(0, 3);
            this.drink_UC2.Name = "drink_UC2";
            this.drink_UC2.Size = new System.Drawing.Size(1004, 491);
            this.drink_UC2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Location = new System.Drawing.Point(12, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sweet Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Bisque;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button2.Location = new System.Drawing.Point(12, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Drink Menu ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Bisque;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button3.Location = new System.Drawing.Point(12, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "Food Menu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Bisque;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button4.Location = new System.Drawing.Point(12, 499);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 78);
            this.button4.TabIndex = 10;
            this.button4.Text = "Customer FeedBack ";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Admintrial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1434, 680);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Admintrial";
            this.Text = "Admintrial";
            this.Load += new System.EventHandler(this.Admintrial_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private AD_UC aD_UC1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Drink_UC drink_UC1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Drink_UC drink_UC2;
        private Sweet_UC sweet_UC1;
        private Food_UC food_UC1;
    }
}