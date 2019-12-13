namespace GPSR
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNodes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIterations = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxSpeed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMinSpeed = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCostomize = new System.Windows.Forms.CheckBox();
            this.cbIsInfiniteEnergy = new System.Windows.Forms.CheckBox();
            this.txtIdleEnergy = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtReciptionEnergy = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTransmisionEnergy = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEnergy = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1256, 432);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSimulate
            // 
            this.btnSimulate.Location = new System.Drawing.Point(1169, 12);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(75, 23);
            this.btnSimulate.TabIndex = 1;
            this.btnSimulate.Text = "Simulate";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Height";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(56, 5);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 3;
            this.txtHeight.Text = "250";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(53, 30);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 5;
            this.txtWidth.Text = "300";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width";
            // 
            // txtNodes
            // 
            this.txtNodes.Location = new System.Drawing.Point(234, 2);
            this.txtNodes.Name = "txtNodes";
            this.txtNodes.Size = new System.Drawing.Size(68, 20);
            this.txtNodes.TabIndex = 7;
            this.txtNodes.Text = "20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nodes";
            // 
            // txtIterations
            // 
            this.txtIterations.Location = new System.Drawing.Point(234, 26);
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.Size = new System.Drawing.Size(77, 20);
            this.txtIterations.TabIndex = 9;
            this.txtIterations.Text = "10000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Iterations";
            // 
            // txtRange
            // 
            this.txtRange.Location = new System.Drawing.Point(424, 1);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(68, 20);
            this.txtRange.TabIndex = 11;
            this.txtRange.Text = "120";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Node Range";
            // 
            // txtBI
            // 
            this.txtBI.Location = new System.Drawing.Point(422, 27);
            this.txtBI.Name = "txtBI";
            this.txtBI.Size = new System.Drawing.Size(68, 20);
            this.txtBI.TabIndex = 13;
            this.txtBI.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Beacon Interval";
            // 
            // txtMaxSpeed
            // 
            this.txtMaxSpeed.Location = new System.Drawing.Point(641, 5);
            this.txtMaxSpeed.Name = "txtMaxSpeed";
            this.txtMaxSpeed.Size = new System.Drawing.Size(68, 20);
            this.txtMaxSpeed.TabIndex = 15;
            this.txtMaxSpeed.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(543, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Node Max Speed";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtMinSpeed
            // 
            this.txtMinSpeed.Location = new System.Drawing.Point(641, 28);
            this.txtMinSpeed.Name = "txtMinSpeed";
            this.txtMinSpeed.Size = new System.Drawing.Size(68, 20);
            this.txtMinSpeed.TabIndex = 17;
            this.txtMinSpeed.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(543, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Node Min Speed";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCostomize);
            this.groupBox1.Controls.Add(this.cbIsInfiniteEnergy);
            this.groupBox1.Controls.Add(this.txtIdleEnergy);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtReciptionEnergy);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtTransmisionEnergy);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtEnergy);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(740, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 72);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Power Options";
            // 
            // cbCostomize
            // 
            this.cbCostomize.AutoSize = true;
            this.cbCostomize.Checked = true;
            this.cbCostomize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCostomize.Location = new System.Drawing.Point(327, 45);
            this.cbCostomize.Name = "cbCostomize";
            this.cbCostomize.Size = new System.Drawing.Size(74, 17);
            this.cbCostomize.TabIndex = 17;
            this.cbCostomize.Text = "Costomize";
            this.cbCostomize.UseVisualStyleBackColor = true;
            // 
            // cbIsInfiniteEnergy
            // 
            this.cbIsInfiniteEnergy.AutoSize = true;
            this.cbIsInfiniteEnergy.Location = new System.Drawing.Point(326, 14);
            this.cbIsInfiniteEnergy.Name = "cbIsInfiniteEnergy";
            this.cbIsInfiniteEnergy.Size = new System.Drawing.Size(93, 17);
            this.cbIsInfiniteEnergy.TabIndex = 16;
            this.cbIsInfiniteEnergy.Text = "Infinite Energy";
            this.cbIsInfiniteEnergy.UseVisualStyleBackColor = true;
            // 
            // txtIdleEnergy
            // 
            this.txtIdleEnergy.Location = new System.Drawing.Point(273, 12);
            this.txtIdleEnergy.Name = "txtIdleEnergy";
            this.txtIdleEnergy.Size = new System.Drawing.Size(48, 20);
            this.txtIdleEnergy.TabIndex = 15;
            this.txtIdleEnergy.Text = "0.0001";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(202, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Idle Energy";
            // 
            // txtReciptionEnergy
            // 
            this.txtReciptionEnergy.Location = new System.Drawing.Point(273, 43);
            this.txtReciptionEnergy.Name = "txtReciptionEnergy";
            this.txtReciptionEnergy.Size = new System.Drawing.Size(48, 20);
            this.txtReciptionEnergy.TabIndex = 13;
            this.txtReciptionEnergy.Text = "0.01";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(167, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Reception Energy";
            // 
            // txtTransmisionEnergy
            // 
            this.txtTransmisionEnergy.Location = new System.Drawing.Point(112, 46);
            this.txtTransmisionEnergy.Name = "txtTransmisionEnergy";
            this.txtTransmisionEnergy.Size = new System.Drawing.Size(48, 20);
            this.txtTransmisionEnergy.TabIndex = 11;
            this.txtTransmisionEnergy.Text = "0.05";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Transmision Energy";
            // 
            // txtEnergy
            // 
            this.txtEnergy.Location = new System.Drawing.Point(112, 18);
            this.txtEnergy.Name = "txtEnergy";
            this.txtEnergy.Size = new System.Drawing.Size(48, 20);
            this.txtEnergy.TabIndex = 9;
            this.txtEnergy.Text = "2.0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Initial Energy";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(167, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Sohad Qtaitat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 512);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMinSpeed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaxSpeed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIterations);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNodes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSimulate);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNodes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIterations;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMinSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdleEnergy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtReciptionEnergy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTransmisionEnergy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEnergy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbIsInfiniteEnergy;
        private System.Windows.Forms.CheckBox cbCostomize;
        private System.Windows.Forms.Label label13;
    }
}

