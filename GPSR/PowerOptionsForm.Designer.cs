namespace GPSR
{
    partial class PowerOptionsForm
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
            this.lblInifiniteEnergy = new System.Windows.Forms.Label();
            this.lblIdleEnergy = new System.Windows.Forms.Label();
            this.lblRxEnergy = new System.Windows.Forms.Label();
            this.lblTxEnergy = new System.Windows.Forms.Label();
            this.lblInitEnergy = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInifiniteEnergy
            // 
            this.lblInifiniteEnergy.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblInifiniteEnergy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInifiniteEnergy.Location = new System.Drawing.Point(662, 3);
            this.lblInifiniteEnergy.Name = "lblInifiniteEnergy";
            this.lblInifiniteEnergy.Size = new System.Drawing.Size(125, 26);
            this.lblInifiniteEnergy.TabIndex = 15;
            this.lblInifiniteEnergy.Text = "Infinite Energy";
            // 
            // lblIdleEnergy
            // 
            this.lblIdleEnergy.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblIdleEnergy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdleEnergy.Location = new System.Drawing.Point(549, 3);
            this.lblIdleEnergy.Name = "lblIdleEnergy";
            this.lblIdleEnergy.Size = new System.Drawing.Size(104, 26);
            this.lblIdleEnergy.TabIndex = 14;
            this.lblIdleEnergy.Text = "Idle Energy";
            // 
            // lblRxEnergy
            // 
            this.lblRxEnergy.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRxEnergy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRxEnergy.Location = new System.Drawing.Point(377, 3);
            this.lblRxEnergy.Name = "lblRxEnergy";
            this.lblRxEnergy.Size = new System.Drawing.Size(163, 26);
            this.lblRxEnergy.TabIndex = 13;
            this.lblRxEnergy.Text = "Recieption Energy";
            // 
            // lblTxEnergy
            // 
            this.lblTxEnergy.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTxEnergy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxEnergy.Location = new System.Drawing.Point(201, 3);
            this.lblTxEnergy.Name = "lblTxEnergy";
            this.lblTxEnergy.Size = new System.Drawing.Size(167, 26);
            this.lblTxEnergy.TabIndex = 12;
            this.lblTxEnergy.Text = "Transmision Energy";
            // 
            // lblInitEnergy
            // 
            this.lblInitEnergy.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblInitEnergy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitEnergy.Location = new System.Drawing.Point(67, 3);
            this.lblInitEnergy.Name = "lblInitEnergy";
            this.lblInitEnergy.Size = new System.Drawing.Size(125, 26);
            this.lblInitEnergy.TabIndex = 11;
            this.lblInitEnergy.Text = "Initial Energy";
            // 
            // lblId
            // 
            this.lblId.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(6, 3);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(52, 26);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "Id";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblInifiniteEnergy, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblIdleEnergy, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRxEnergy, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTxEnergy, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblInitEnergy, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblId, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(861, 32);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 48);
            this.panel1.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(653, 13);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 32);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(513, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PowerOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(861, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PowerOptionsForm";
            this.Text = "PowerOptionsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

          
        private System.Windows.Forms.Label lblInitEnergy;
        private System.Windows.Forms.Label lblInifiniteEnergy;
        private System.Windows.Forms.Label lblIdleEnergy;
        private System.Windows.Forms.Label lblRxEnergy;
        private System.Windows.Forms.Label lblTxEnergy;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}