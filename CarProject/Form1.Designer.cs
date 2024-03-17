namespace CarProject
{
    partial class form1
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
            components = new System.ComponentModel.Container();
            road = new Panel();
            panel7 = new Panel();
            car = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            panel13 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            brake = new Panel();
            gas = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            road.SuspendLayout();
            car.SuspendLayout();
            panel11.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // road
            // 
            road.BackColor = SystemColors.ActiveBorder;
            road.Controls.Add(panel7);
            road.Controls.Add(car);
            road.Controls.Add(panel5);
            road.Controls.Add(panel4);
            road.Controls.Add(panel3);
            road.Controls.Add(panel2);
            road.Dock = DockStyle.Left;
            road.Location = new Point(0, 0);
            road.Name = "road";
            road.Size = new Size(250, 590);
            road.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Control;
            panel7.Location = new Point(100, 571);
            panel7.Name = "panel7";
            panel7.Size = new Size(14, 112);
            panel7.TabIndex = 2;
            // 
            // car
            // 
            car.BackColor = SystemColors.ActiveCaptionText;
            car.Controls.Add(panel11);
            car.Controls.Add(panel8);
            car.Location = new Point(143, 404);
            car.Name = "car";
            car.Size = new Size(69, 144);
            car.TabIndex = 1;
            // 
            // panel11
            // 
            panel11.Controls.Add(panel12);
            panel11.Controls.Add(panel13);
            panel11.Dock = DockStyle.Bottom;
            panel11.Location = new Point(0, 124);
            panel11.Name = "panel11";
            panel11.Size = new Size(69, 20);
            panel11.TabIndex = 1;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Red;
            panel12.Dock = DockStyle.Left;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(20, 20);
            panel12.TabIndex = 1;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Red;
            panel13.Dock = DockStyle.Right;
            panel13.Location = new Point(49, 0);
            panel13.Name = "panel13";
            panel13.Size = new Size(20, 20);
            panel13.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(panel10);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(69, 20);
            panel8.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Yellow;
            panel9.Dock = DockStyle.Left;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(20, 20);
            panel9.TabIndex = 1;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Yellow;
            panel10.Dock = DockStyle.Right;
            panel10.Location = new Point(49, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(20, 20);
            panel10.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Location = new Point(100, 436);
            panel5.Name = "panel5";
            panel5.Size = new Size(14, 112);
            panel5.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Location = new Point(100, 289);
            panel4.Name = "panel4";
            panel4.Size = new Size(14, 109);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Location = new Point(100, 150);
            panel3.Name = "panel3";
            panel3.Size = new Size(14, 106);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Location = new Point(100, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(14, 107);
            panel2.TabIndex = 0;
            // 
            // brake
            // 
            brake.BackColor = Color.Red;
            brake.Location = new Point(256, 12);
            brake.Name = "brake";
            brake.Size = new Size(318, 271);
            brake.TabIndex = 3;
            brake.MouseEnter += brake_MouseEnter;
            // 
            // gas
            // 
            gas.BackColor = Color.Lime;
            gas.Location = new Point(256, 318);
            gas.Name = "gas";
            gas.Size = new Size(318, 259);
            gas.TabIndex = 4;
            gas.MouseEnter += gas_MouseEnter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 590);
            Controls.Add(gas);
            Controls.Add(brake);
            Controls.Add(road);
            Name = "form1";
            Text = "Form1";
            road.ResumeLayout(false);
            car.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel road;
        private Panel panel7;
        private Panel car;
        private Panel panel8;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Panel panel9;
        private Panel panel10;
        private Panel brake;
        private Panel gas;
        private System.Windows.Forms.Timer timer1;
    }
}
