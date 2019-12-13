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
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }
        public List<Packet> Packets { get; set; }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            Packets.Sort((p1, p2) => p1.HasUsedPerimeter.CompareTo(p2.HasUsedPerimeter));
            dgvPackets.DataSource = Packets;
            dgvNodes.DataSource = Simulation.GetInstance().Nodes;

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if( e.RowIndex < 0 ) return;
            var p = dgvPackets.Rows[e.RowIndex].DataBoundItem as Packet;
            lblDestination.Text = p.Destination.Id.ToString();
            lblSource .Text = p.Source.Id.ToString();
            lblSentTime.Text = p.SentTime.ToString();
            lblRecivedTime.Text = p.RecivedTime.ToString();
            lblDelay.Text = (p.RecivedTime - p.SentTime).ToString();
            lblHubCount.Text = p.Hubes.Count().ToString();
            flowLayoutPanelHubs.Controls.Clear();
            foreach (var item in p.Hubes)
            {
                Label lb = new Label();
                lb.AutoSize = true;
                lb.BorderStyle = BorderStyle.FixedSingle;
                lb.Dock = DockStyle.Left;
                lb.Text = item.Id.ToString();
                flowLayoutPanelHubs.Controls.Add(lb);
            }
            flowLayoutPanelModes.Controls.Clear();
            
            foreach (var item in p.Modes)
            {
                Label lb = new Label();
                lb.AutoSize = true;
                lb.BorderStyle = BorderStyle.FixedSingle;
                lb.Dock = DockStyle.Left;
                lb.Text = item.ToString();
                flowLayoutPanelModes.Controls.Add(lb);
            }
            Simulation simulation = Simulation.GetInstance();
            simulation.drawSimulationPacket(p);



        }
    }
}
