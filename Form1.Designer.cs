namespace RATING
{
    partial class Form1
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
            this.STAR1 = new System.Windows.Forms.PictureBox();
            this.STAR2 = new System.Windows.Forms.PictureBox();
            this.STAR4 = new System.Windows.Forms.PictureBox();
            this.STAR3 = new System.Windows.Forms.PictureBox();
            this.STAR5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.STAR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STAR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STAR4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STAR3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STAR5)).BeginInit();
            this.SuspendLayout();
            // 
            // STAR1
            // 
            this.STAR1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.STAR1.Image = global::RATING.Properties.Resources.white_star;
            this.STAR1.Location = new System.Drawing.Point(68, 117);
            this.STAR1.Name = "STAR1";
            this.STAR1.Size = new System.Drawing.Size(75, 60);
            this.STAR1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.STAR1.TabIndex = 0;
            this.STAR1.TabStop = false;
            this.STAR1.Click += new System.EventHandler(this.STAR1_Click);
            // 
            // STAR2
            // 
            this.STAR2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.STAR2.Image = global::RATING.Properties.Resources.white_star;
            this.STAR2.Location = new System.Drawing.Point(187, 117);
            this.STAR2.Name = "STAR2";
            this.STAR2.Size = new System.Drawing.Size(75, 60);
            this.STAR2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.STAR2.TabIndex = 1;
            this.STAR2.TabStop = false;
            this.STAR2.Click += new System.EventHandler(this.STAR2_Click);
            // 
            // STAR4
            // 
            this.STAR4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.STAR4.Image = global::RATING.Properties.Resources.white_star;
            this.STAR4.Location = new System.Drawing.Point(415, 117);
            this.STAR4.Name = "STAR4";
            this.STAR4.Size = new System.Drawing.Size(75, 60);
            this.STAR4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.STAR4.TabIndex = 3;
            this.STAR4.TabStop = false;
            this.STAR4.Click += new System.EventHandler(this.STAR4_Click);
            // 
            // STAR3
            // 
            this.STAR3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.STAR3.Image = global::RATING.Properties.Resources.white_star;
            this.STAR3.Location = new System.Drawing.Point(300, 117);
            this.STAR3.Name = "STAR3";
            this.STAR3.Size = new System.Drawing.Size(75, 60);
            this.STAR3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.STAR3.TabIndex = 2;
            this.STAR3.TabStop = false;
            this.STAR3.Click += new System.EventHandler(this.STAR3_Click);
            // 
            // STAR5
            // 
            this.STAR5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.STAR5.Image = global::RATING.Properties.Resources.white_star;
            this.STAR5.Location = new System.Drawing.Point(533, 117);
            this.STAR5.Name = "STAR5";
            this.STAR5.Size = new System.Drawing.Size(75, 60);
            this.STAR5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.STAR5.TabIndex = 4;
            this.STAR5.TabStop = false;
            this.STAR5.Click += new System.EventHandler(this.STAR5_Click);
            this.STAR5.DoubleClick += new System.EventHandler(this.STAR5_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "RATINGS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox1.Location = new System.Drawing.Point(68, 229);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(661, 144);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Add a comment...";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(629, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.STAR5);
            this.Controls.Add(this.STAR4);
            this.Controls.Add(this.STAR3);
            this.Controls.Add(this.STAR2);
            this.Controls.Add(this.STAR1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.STAR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STAR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STAR4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STAR3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STAR5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox STAR1;
        private System.Windows.Forms.PictureBox STAR2;
        private System.Windows.Forms.PictureBox STAR4;
        private System.Windows.Forms.PictureBox STAR3;
        private System.Windows.Forms.PictureBox STAR5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

