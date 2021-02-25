namespace rotate1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbCenter = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbArr = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NudX = new System.Windows.Forms.NumericUpDown();
            this.NudY = new System.Windows.Forms.NumericUpDown();
            this.NudR = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ch = new System.Windows.Forms.CheckBox();
            this.tb = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.pbCenter);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pbArr);
            this.panel1.Location = new System.Drawing.Point(45, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 333);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pbCenter
            // 
            this.pbCenter.Location = new System.Drawing.Point(274, 151);
            this.pbCenter.Name = "pbCenter";
            this.pbCenter.Size = new System.Drawing.Size(10, 10);
            this.pbCenter.TabIndex = 2;
            this.pbCenter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbCenter_MouseDown);
            this.pbCenter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbCenter_MouseMove);
            this.pbCenter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbCenter_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(-73, -99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // pbArr
            // 
            this.pbArr.Image = ((System.Drawing.Image)(resources.GetObject("pbArr.Image")));
            this.pbArr.Location = new System.Drawing.Point(149, 115);
            this.pbArr.Name = "pbArr";
            this.pbArr.Size = new System.Drawing.Size(61, 49);
            this.pbArr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArr.TabIndex = 0;
            this.pbArr.TabStop = false;
            this.pbArr.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbArr_MouseDown);
            this.pbArr.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbArr_MouseMove);
            this.pbArr.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbArr_MouseUp);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paramethers";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "R";
            // 
            // NudX
            // 
            this.NudX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NudX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NudX.Location = new System.Drawing.Point(646, 136);
            this.NudX.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.NudX.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NudX.Name = "NudX";
            this.NudX.Size = new System.Drawing.Size(120, 22);
            this.NudX.TabIndex = 5;
            this.NudX.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NudX.ValueChanged += new System.EventHandler(this.NudX_ValueChanged);
            // 
            // NudY
            // 
            this.NudY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NudY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NudY.Location = new System.Drawing.Point(646, 189);
            this.NudY.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.NudY.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NudY.Name = "NudY";
            this.NudY.Size = new System.Drawing.Size(120, 22);
            this.NudY.TabIndex = 6;
            this.NudY.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NudY.ValueChanged += new System.EventHandler(this.NudY_ValueChanged);
            // 
            // NudR
            // 
            this.NudR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NudR.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NudR.Location = new System.Drawing.Point(646, 233);
            this.NudR.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudR.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NudR.Name = "NudR";
            this.NudR.Size = new System.Drawing.Size(120, 22);
            this.NudR.TabIndex = 7;
            this.NudR.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NudR.ValueChanged += new System.EventHandler(this.NudR_ValueChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(159, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(366, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "RESET";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(609, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ch
            // 
            this.ch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ch.AutoSize = true;
            this.ch.Location = new System.Drawing.Point(535, 270);
            this.ch.Name = "ch";
            this.ch.Size = new System.Drawing.Size(78, 21);
            this.ch.TabIndex = 11;
            this.ch.Text = "rotation";
            this.ch.UseVisualStyleBackColor = true;
            // 
            // tb
            // 
            this.tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb.Location = new System.Drawing.Point(535, 308);
            this.tb.Minimum = 5;
            this.tb.Name = "tb";
            this.tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb.Size = new System.Drawing.Size(127, 56);
            this.tb.TabIndex = 12;
            this.tb.Value = 5;
            this.tb.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.ch);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NudR);
            this.Controls.Add(this.NudY);
            this.Controls.Add(this.NudX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Движение по кругу";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbArr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NudX;
        private System.Windows.Forms.NumericUpDown NudY;
        private System.Windows.Forms.NumericUpDown NudR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pbArr;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox ch;
        private System.Windows.Forms.Panel pbCenter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar tb;
    }
}

