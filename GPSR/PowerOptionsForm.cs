using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSR
{
    public partial class PowerOptionsForm : Form
    {

        public PowerOptionsForm()
        {
            InitializeComponent();
            
            Initialize();
        }
        private void Initialize()
        {
            Simulation simulation = Simulation.GetInstance();
            int i = 1;
            tableLayoutPanel1.RowCount = simulation.Nodes.Count + 1;
            foreach (var node in simulation.Nodes)
            {
                int tag = node.Id;
                tableLayoutPanel1.RowStyles.Add(new RowStyle());

                CheckBox cbIsInfiniteEnergy = new CheckBox();
               
                cbIsInfiniteEnergy.Dock = DockStyle.Left;
                cbIsInfiniteEnergy.Checked = node.IsInfiniteEnergy;               
                tableLayoutPanel1.Controls.Add(cbIsInfiniteEnergy);
                tableLayoutPanel1.SetColumn(cbIsInfiniteEnergy, 5);
                tableLayoutPanel1.SetRow(cbIsInfiniteEnergy, i);



                TextBox txtIdleEnergy = new TextBox() { Width = 75 ,Tag = tag};               
                txtIdleEnergy.Dock = DockStyle.Left;
                txtIdleEnergy.Text = node.IdleConsumption.ToString();                
                tableLayoutPanel1.Controls.Add(txtIdleEnergy);
                tableLayoutPanel1.SetColumn(txtIdleEnergy, 4);
                tableLayoutPanel1.SetRow(txtIdleEnergy, i);


                TextBox txtReciptionEnergy = new TextBox() { Width = 75, Tag = tag };              
                txtReciptionEnergy.Dock = DockStyle.Left;
                txtReciptionEnergy.Text = node.ReceptionConsumption.ToString();                
                tableLayoutPanel1.Controls.Add(txtReciptionEnergy);
                tableLayoutPanel1.SetColumn(txtReciptionEnergy, 3);
                tableLayoutPanel1.SetRow(txtReciptionEnergy, i);


                TextBox txtTransmisionEnergy = new TextBox() { Width = 75, Tag = tag  };               
                txtTransmisionEnergy.Dock = DockStyle.Left;
                txtTransmisionEnergy.Text = node.TransmisionConsumption.ToString();                
                tableLayoutPanel1.Controls.Add(txtTransmisionEnergy);
                tableLayoutPanel1.SetColumn(txtTransmisionEnergy, 2);
                tableLayoutPanel1.SetRow(txtTransmisionEnergy, i);


                TextBox txtEnergy = new TextBox() { Width = 75, Tag = tag  };
                txtEnergy.Dock = DockStyle.Left;
                txtEnergy.Text = node.Energy.ToString();
                tableLayoutPanel1.Controls.Add(txtEnergy);
                tableLayoutPanel1.SetColumn(txtEnergy, 1);
                tableLayoutPanel1.SetRow(txtEnergy, i);


                Label lblId = new Label() { Width = 20, Tag = tag };              
                lblId.Dock = DockStyle.Left;
                lblId.Text = node.Id.ToString();              
                tableLayoutPanel1.Controls.Add(lblId);
                tableLayoutPanel1.SetColumn(lblId, 0);
                tableLayoutPanel1.SetRow(lblId, i);
                i++;

               

            }
          
        }
       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < tableLayoutPanel1.RowCount; i++)
            {
                Label lblId = tableLayoutPanel1.GetControlFromPosition(0, i) as Label;
                TextBox txtEnergy = tableLayoutPanel1.GetControlFromPosition(1, i) as TextBox;
                TextBox txtTransmisionEnergy = tableLayoutPanel1.GetControlFromPosition(2, i) as TextBox;
                TextBox txtReciptionEnergy = tableLayoutPanel1.GetControlFromPosition(3, i) as TextBox;
                TextBox txtIdleEnergy = tableLayoutPanel1.GetControlFromPosition(4, i) as TextBox;
                CheckBox cbIsInfiniteEnergy = tableLayoutPanel1.GetControlFromPosition(5, i) as CheckBox;
                int id = Convert.ToInt32(lblId.Text);
                Node node = Simulation.GetInstance().Nodes.Single(n => n.Id == id);
                node.Energy = (float)Convert.ToDouble(txtEnergy.Text);
                node.TransmisionConsumption = (float)Convert.ToDouble(txtTransmisionEnergy.Text);
                node.ReceptionConsumption = (float)Convert.ToDouble(txtReciptionEnergy.Text);
                node.IdleConsumption = (float)Convert.ToDouble(txtIdleEnergy.Text);
                node.IsInfiniteEnergy = cbIsInfiniteEnergy.Checked;

            }
            Close();
        }
    }
}
