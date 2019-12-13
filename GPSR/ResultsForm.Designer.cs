namespace GPSR
{
    partial class ResultsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPackets = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRecivedTime = new System.Windows.Forms.Label();
            this.lblSentTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDelay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHubCount = new System.Windows.Forms.Label();
            this.flowLayoutPanelHubs = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelModes = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPackets = new System.Windows.Forms.TabPage();
            this.tpNodes = new System.Windows.Forms.TabPage();
            this.dgvNodes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackets)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpPackets.SuspendLayout();
            this.tpNodes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNodes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPackets);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 369);
            this.panel1.TabIndex = 0;
            // 
            // dgvPackets
            // 
            this.dgvPackets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPackets.Location = new System.Drawing.Point(0, 0);
            this.dgvPackets.Name = "dgvPackets";
            this.dgvPackets.Size = new System.Drawing.Size(981, 369);
            this.dgvPackets.TabIndex = 0;
            this.dgvPackets.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.75144F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.24856F));
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblRecivedTime, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSentTime, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSource, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDestination, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDelay, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblHubCount, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelHubs, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelModes, 1, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.26316F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.73684F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(981, 201);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Transmision Modes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Hub Nodes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Recived Time";
            // 
            // lblRecivedTime
            // 
            this.lblRecivedTime.AutoSize = true;
            this.lblRecivedTime.Location = new System.Drawing.Point(114, 54);
            this.lblRecivedTime.Name = "lblRecivedTime";
            this.lblRecivedTime.Size = new System.Drawing.Size(0, 13);
            this.lblRecivedTime.TabIndex = 6;
            // 
            // lblSentTime
            // 
            this.lblSentTime.AutoSize = true;
            this.lblSentTime.Location = new System.Drawing.Point(114, 36);
            this.lblSentTime.Name = "lblSentTime";
            this.lblSentTime.Size = new System.Drawing.Size(0, 13);
            this.lblSentTime.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sent Time";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(114, 6);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(0, 13);
            this.lblSource.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(114, 20);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(0, 13);
            this.lblDestination.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Delay";
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(114, 78);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(0, 13);
            this.lblDelay.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Hub Count";
            // 
            // lblHubCount
            // 
            this.lblHubCount.AutoSize = true;
            this.lblHubCount.Location = new System.Drawing.Point(114, 97);
            this.lblHubCount.Name = "lblHubCount";
            this.lblHubCount.Size = new System.Drawing.Size(0, 13);
            this.lblHubCount.TabIndex = 11;
            // 
            // flowLayoutPanelHubs
            // 
            this.flowLayoutPanelHubs.AutoScroll = true;
            this.flowLayoutPanelHubs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelHubs.Location = new System.Drawing.Point(114, 121);
            this.flowLayoutPanelHubs.Name = "flowLayoutPanelHubs";
            this.flowLayoutPanelHubs.Size = new System.Drawing.Size(858, 15);
            this.flowLayoutPanelHubs.TabIndex = 18;
            // 
            // flowLayoutPanelModes
            // 
            this.flowLayoutPanelModes.AutoScroll = true;
            this.flowLayoutPanelModes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelModes.Location = new System.Drawing.Point(114, 143);
            this.flowLayoutPanelModes.Name = "flowLayoutPanelModes";
            this.flowLayoutPanelModes.Size = new System.Drawing.Size(858, 27);
            this.flowLayoutPanelModes.TabIndex = 19;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPackets);
            this.tabControl1.Controls.Add(this.tpNodes);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(995, 608);
            this.tabControl1.TabIndex = 1;
            // 
            // tpPackets
            // 
            this.tpPackets.Controls.Add(this.panel1);
            this.tpPackets.Controls.Add(this.tableLayoutPanel1);
            this.tpPackets.Location = new System.Drawing.Point(4, 22);
            this.tpPackets.Name = "tpPackets";
            this.tpPackets.Padding = new System.Windows.Forms.Padding(3);
            this.tpPackets.Size = new System.Drawing.Size(987, 582);
            this.tpPackets.TabIndex = 0;
            this.tpPackets.Text = "Packets";
            this.tpPackets.UseVisualStyleBackColor = true;
            // 
            // tpNodes
            // 
            this.tpNodes.Controls.Add(this.dgvNodes);
            this.tpNodes.Location = new System.Drawing.Point(4, 22);
            this.tpNodes.Name = "tpNodes";
            this.tpNodes.Padding = new System.Windows.Forms.Padding(3);
            this.tpNodes.Size = new System.Drawing.Size(987, 582);
            this.tpNodes.TabIndex = 1;
            this.tpNodes.Text = "Nodes";
            this.tpNodes.UseVisualStyleBackColor = true;
            // 
            // dgvNodes
            // 
            this.dgvNodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNodes.Location = new System.Drawing.Point(3, 3);
            this.dgvNodes.Name = "dgvNodes";
            this.dgvNodes.Size = new System.Drawing.Size(981, 576);
            this.dgvNodes.TabIndex = 0;
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 608);
            this.Controls.Add(this.tabControl1);
            this.Name = "ResultsForm";
            this.Text = "ResultsForm";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackets)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpPackets.ResumeLayout(false);
            this.tpPackets.PerformLayout();
            this.tpNodes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNodes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPackets;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSentTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRecivedTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHubCount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHubs;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelModes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPackets;
        private System.Windows.Forms.TabPage tpNodes;
        private System.Windows.Forms.DataGridView dgvNodes;
    }
}