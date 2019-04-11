namespace _4_Hit
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
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.Label();
            this.num4 = new System.Windows.Forms.Label();
            this.hitnum = new System.Windows.Forms.Label();
            this.passnum = new System.Windows.Forms.Label();
            this.up1 = new System.Windows.Forms.Label();
            this.down1 = new System.Windows.Forms.Label();
            this.down2 = new System.Windows.Forms.Label();
            this.up2 = new System.Windows.Forms.Label();
            this.down3 = new System.Windows.Forms.Label();
            this.up3 = new System.Windows.Forms.Label();
            this.down4 = new System.Windows.Forms.Label();
            this.up4 = new System.Windows.Forms.Label();
            this.turnnum = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.BackColor = System.Drawing.Color.Transparent;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.ForeColor = System.Drawing.Color.DimGray;
            this.num1.Location = new System.Drawing.Point(305, 223);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(110, 120);
            this.num1.TabIndex = 0;
            this.num1.Text = "0";
            this.num1.Visible = false;
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.BackColor = System.Drawing.Color.Transparent;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.ForeColor = System.Drawing.Color.DimGray;
            this.num2.Location = new System.Drawing.Point(414, 223);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(110, 120);
            this.num2.TabIndex = 2;
            this.num2.Text = "0";
            this.num2.Visible = false;
            // 
            // num3
            // 
            this.num3.AutoSize = true;
            this.num3.BackColor = System.Drawing.Color.Transparent;
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.ForeColor = System.Drawing.Color.DimGray;
            this.num3.Location = new System.Drawing.Point(524, 222);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(110, 120);
            this.num3.TabIndex = 3;
            this.num3.Text = "0";
            this.num3.Visible = false;
            // 
            // num4
            // 
            this.num4.AutoSize = true;
            this.num4.BackColor = System.Drawing.Color.Transparent;
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.ForeColor = System.Drawing.Color.DimGray;
            this.num4.Location = new System.Drawing.Point(634, 223);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(110, 120);
            this.num4.TabIndex = 4;
            this.num4.Text = "0";
            this.num4.Visible = false;
            // 
            // hitnum
            // 
            this.hitnum.AutoSize = true;
            this.hitnum.BackColor = System.Drawing.Color.Transparent;
            this.hitnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitnum.ForeColor = System.Drawing.Color.DimGray;
            this.hitnum.Location = new System.Drawing.Point(328, 414);
            this.hitnum.Name = "hitnum";
            this.hitnum.Size = new System.Drawing.Size(54, 20);
            this.hitnum.TabIndex = 5;
            this.hitnum.Text = "Hits: 0";
            this.hitnum.Visible = false;
            // 
            // passnum
            // 
            this.passnum.AutoSize = true;
            this.passnum.BackColor = System.Drawing.Color.Transparent;
            this.passnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passnum.ForeColor = System.Drawing.Color.DimGray;
            this.passnum.Location = new System.Drawing.Point(635, 414);
            this.passnum.Name = "passnum";
            this.passnum.Size = new System.Drawing.Size(78, 20);
            this.passnum.TabIndex = 6;
            this.passnum.Text = "Passes: 0";
            this.passnum.Visible = false;
            // 
            // up1
            // 
            this.up1.AutoSize = true;
            this.up1.BackColor = System.Drawing.Color.Transparent;
            this.up1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up1.ForeColor = System.Drawing.Color.DimGray;
            this.up1.Location = new System.Drawing.Point(322, 180);
            this.up1.Name = "up1";
            this.up1.Size = new System.Drawing.Size(49, 54);
            this.up1.TabIndex = 7;
            this.up1.Text = "/\\";
            this.up1.Visible = false;
            this.up1.Click += new System.EventHandler(this.up1_Click);
            this.up1.MouseEnter += new System.EventHandler(this.up1_MouseEnter);
            this.up1.MouseLeave += new System.EventHandler(this.up1_MouseLeave);
            // 
            // down1
            // 
            this.down1.AutoSize = true;
            this.down1.BackColor = System.Drawing.Color.Transparent;
            this.down1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.down1.ForeColor = System.Drawing.Color.DimGray;
            this.down1.Location = new System.Drawing.Point(320, 343);
            this.down1.Name = "down1";
            this.down1.Size = new System.Drawing.Size(49, 54);
            this.down1.TabIndex = 8;
            this.down1.Text = "\\/";
            this.down1.Visible = false;
            this.down1.Click += new System.EventHandler(this.down1_Click);
            this.down1.MouseEnter += new System.EventHandler(this.down1_MouseEnter);
            this.down1.MouseLeave += new System.EventHandler(this.down1_MouseLeave);
            // 
            // down2
            // 
            this.down2.AutoSize = true;
            this.down2.BackColor = System.Drawing.Color.Transparent;
            this.down2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.down2.ForeColor = System.Drawing.Color.DimGray;
            this.down2.Location = new System.Drawing.Point(429, 343);
            this.down2.Name = "down2";
            this.down2.Size = new System.Drawing.Size(49, 54);
            this.down2.TabIndex = 10;
            this.down2.Text = "\\/";
            this.down2.Visible = false;
            this.down2.Click += new System.EventHandler(this.down2_Click);
            this.down2.MouseEnter += new System.EventHandler(this.down2_MouseEnter);
            this.down2.MouseLeave += new System.EventHandler(this.down2_MouseLeave);
            // 
            // up2
            // 
            this.up2.AutoSize = true;
            this.up2.BackColor = System.Drawing.Color.Transparent;
            this.up2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up2.ForeColor = System.Drawing.Color.DimGray;
            this.up2.Location = new System.Drawing.Point(431, 180);
            this.up2.Name = "up2";
            this.up2.Size = new System.Drawing.Size(49, 54);
            this.up2.TabIndex = 9;
            this.up2.Text = "/\\";
            this.up2.Visible = false;
            this.up2.Click += new System.EventHandler(this.up2_Click);
            this.up2.MouseEnter += new System.EventHandler(this.up2_MouseEnter);
            this.up2.MouseLeave += new System.EventHandler(this.up2_MouseLeave);
            // 
            // down3
            // 
            this.down3.AutoSize = true;
            this.down3.BackColor = System.Drawing.Color.Transparent;
            this.down3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.down3.ForeColor = System.Drawing.Color.DimGray;
            this.down3.Location = new System.Drawing.Point(539, 343);
            this.down3.Name = "down3";
            this.down3.Size = new System.Drawing.Size(49, 54);
            this.down3.TabIndex = 12;
            this.down3.Text = "\\/";
            this.down3.Visible = false;
            this.down3.Click += new System.EventHandler(this.down3_Click);
            this.down3.MouseEnter += new System.EventHandler(this.down3_MouseEnter);
            this.down3.MouseLeave += new System.EventHandler(this.down3_MouseLeave);
            // 
            // up3
            // 
            this.up3.AutoSize = true;
            this.up3.BackColor = System.Drawing.Color.Transparent;
            this.up3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up3.ForeColor = System.Drawing.Color.DimGray;
            this.up3.Location = new System.Drawing.Point(541, 180);
            this.up3.Name = "up3";
            this.up3.Size = new System.Drawing.Size(49, 54);
            this.up3.TabIndex = 11;
            this.up3.Text = "/\\";
            this.up3.Visible = false;
            this.up3.Click += new System.EventHandler(this.up3_Click);
            this.up3.MouseEnter += new System.EventHandler(this.up3_MouseEnter);
            this.up3.MouseLeave += new System.EventHandler(this.up3_MouseLeave);
            // 
            // down4
            // 
            this.down4.AutoSize = true;
            this.down4.BackColor = System.Drawing.Color.Transparent;
            this.down4.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.down4.ForeColor = System.Drawing.Color.DimGray;
            this.down4.Location = new System.Drawing.Point(650, 343);
            this.down4.Name = "down4";
            this.down4.Size = new System.Drawing.Size(49, 54);
            this.down4.TabIndex = 14;
            this.down4.Text = "\\/";
            this.down4.Visible = false;
            this.down4.Click += new System.EventHandler(this.down4_Click);
            this.down4.MouseEnter += new System.EventHandler(this.down4_MouseEnter);
            this.down4.MouseLeave += new System.EventHandler(this.down4_MouseLeave);
            // 
            // up4
            // 
            this.up4.AutoSize = true;
            this.up4.BackColor = System.Drawing.Color.Transparent;
            this.up4.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up4.ForeColor = System.Drawing.Color.DimGray;
            this.up4.Location = new System.Drawing.Point(650, 180);
            this.up4.Name = "up4";
            this.up4.Size = new System.Drawing.Size(49, 54);
            this.up4.TabIndex = 13;
            this.up4.Text = "/\\";
            this.up4.Visible = false;
            this.up4.Click += new System.EventHandler(this.up4_Click);
            this.up4.MouseEnter += new System.EventHandler(this.up4_MouseEnter);
            this.up4.MouseLeave += new System.EventHandler(this.up4_MouseLeave);
            // 
            // turnnum
            // 
            this.turnnum.AutoSize = true;
            this.turnnum.BackColor = System.Drawing.Color.Transparent;
            this.turnnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnnum.ForeColor = System.Drawing.Color.DimGray;
            this.turnnum.Location = new System.Drawing.Point(480, 414);
            this.turnnum.Name = "turnnum";
            this.turnnum.Size = new System.Drawing.Size(58, 20);
            this.turnnum.TabIndex = 20;
            this.turnnum.Text = "Turn: 0";
            this.turnnum.Visible = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(764, 251);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(16, 108);
            this.exit.TabIndex = 19;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.FlatAppearance.BorderSize = 0;
            this.start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(282, 251);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(17, 108);
            this.start.TabIndex = 1;
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeTxt
            // 
            this.timeTxt.AutoSize = true;
            this.timeTxt.BackColor = System.Drawing.Color.Transparent;
            this.timeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTxt.ForeColor = System.Drawing.Color.DimGray;
            this.timeTxt.Location = new System.Drawing.Point(442, 156);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Size = new System.Drawing.Size(117, 20);
            this.timeTxt.TabIndex = 21;
            this.timeTxt.Text = "60 seconds left";
            this.timeTxt.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 601);
            this.Controls.Add(this.timeTxt);
            this.Controls.Add(this.turnnum);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.down4);
            this.Controls.Add(this.up4);
            this.Controls.Add(this.down3);
            this.Controls.Add(this.up3);
            this.Controls.Add(this.down2);
            this.Controls.Add(this.up2);
            this.Controls.Add(this.down1);
            this.Controls.Add(this.up1);
            this.Controls.Add(this.passnum);
            this.Controls.Add(this.hitnum);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.start);
            this.Controls.Add(this.num1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "4 hit";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label num3;
        private System.Windows.Forms.Label num4;
        private System.Windows.Forms.Label hitnum;
        private System.Windows.Forms.Label passnum;
        private System.Windows.Forms.Label up1;
        private System.Windows.Forms.Label down1;
        private System.Windows.Forms.Label down2;
        private System.Windows.Forms.Label up2;
        private System.Windows.Forms.Label down3;
        private System.Windows.Forms.Label up3;
        private System.Windows.Forms.Label down4;
        private System.Windows.Forms.Label up4;
        private System.Windows.Forms.Label turnnum;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeTxt;
    }
}

