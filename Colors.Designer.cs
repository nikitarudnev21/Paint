namespace LabDrawRudnev
{
    partial class Colors
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
            this.ScrollRed = new System.Windows.Forms.HScrollBar();
            this.ScrollGreen = new System.Windows.Forms.HScrollBar();
            this.numericBlue = new System.Windows.Forms.NumericUpDown();
            this.ScrollBlue = new System.Windows.Forms.HScrollBar();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericGreen = new System.Windows.Forms.NumericUpDown();
            this.numericRed = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrollRed
            // 
            this.ScrollRed.LargeChange = 1;
            this.ScrollRed.Location = new System.Drawing.Point(75, 38);
            this.ScrollRed.Maximum = 255;
            this.ScrollRed.Name = "ScrollRed";
            this.ScrollRed.Size = new System.Drawing.Size(170, 28);
            this.ScrollRed.TabIndex = 0;
            this.ScrollRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollRed_Scroll);
            this.ScrollRed.ValueChanged += new System.EventHandler(this.ScrollRed_ValueChanged);
            // 
            // ScrollGreen
            // 
            this.ScrollGreen.LargeChange = 1;
            this.ScrollGreen.Location = new System.Drawing.Point(75, 89);
            this.ScrollGreen.Maximum = 255;
            this.ScrollGreen.Name = "ScrollGreen";
            this.ScrollGreen.Size = new System.Drawing.Size(170, 28);
            this.ScrollGreen.TabIndex = 2;
            this.ScrollGreen.ValueChanged += new System.EventHandler(this.ScrollGreen_ValueChanged);
            // 
            // numericBlue
            // 
            this.numericBlue.BackColor = System.Drawing.Color.Chocolate;
            this.numericBlue.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.numericBlue.Location = new System.Drawing.Point(261, 136);
            this.numericBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericBlue.Name = "numericBlue";
            this.numericBlue.Size = new System.Drawing.Size(46, 28);
            this.numericBlue.TabIndex = 5;
            this.numericBlue.ValueChanged += new System.EventHandler(this.NumericBlue_ValueChanged);
            // 
            // ScrollBlue
            // 
            this.ScrollBlue.LargeChange = 1;
            this.ScrollBlue.Location = new System.Drawing.Point(75, 135);
            this.ScrollBlue.Maximum = 255;
            this.ScrollBlue.Name = "ScrollBlue";
            this.ScrollBlue.Size = new System.Drawing.Size(170, 28);
            this.ScrollBlue.TabIndex = 4;
            this.ScrollBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBlue_Scroll);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chocolate;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(15, 186);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "Ok";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(100, 186);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Chocolate;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(326, 186);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 42);
            this.button3.TabIndex = 12;
            this.button3.Text = "Other Colors";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(10, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Red";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Green";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Blue";
            // 
            // numericGreen
            // 
            this.numericGreen.BackColor = System.Drawing.Color.Chocolate;
            this.numericGreen.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.numericGreen.Location = new System.Drawing.Point(261, 89);
            this.numericGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericGreen.Name = "numericGreen";
            this.numericGreen.Size = new System.Drawing.Size(46, 28);
            this.numericGreen.TabIndex = 16;
            this.numericGreen.ValueChanged += new System.EventHandler(this.NumericGreen_ValueChanged);
            // 
            // numericRed
            // 
            this.numericRed.BackColor = System.Drawing.Color.Chocolate;
            this.numericRed.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.numericRed.Location = new System.Drawing.Point(261, 39);
            this.numericRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericRed.Name = "numericRed";
            this.numericRed.Size = new System.Drawing.Size(46, 28);
            this.numericRed.TabIndex = 17;
            this.numericRed.ValueChanged += new System.EventHandler(this.NumericRed_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(336, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 125);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Colors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(466, 295);
            this.Controls.Add(this.numericRed);
            this.Controls.Add(this.numericGreen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericBlue);
            this.Controls.Add(this.ScrollBlue);
            this.Controls.Add(this.ScrollGreen);
            this.Controls.Add(this.ScrollRed);
            this.Name = "Colors";
            this.Text = "Colors";
            this.Load += new System.EventHandler(this.Colors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar ScrollRed;
        private System.Windows.Forms.HScrollBar ScrollGreen;
        private System.Windows.Forms.NumericUpDown numericBlue;
        private System.Windows.Forms.HScrollBar ScrollBlue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericGreen;
        private System.Windows.Forms.NumericUpDown numericRed;
    }
}