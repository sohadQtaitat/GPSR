using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSR
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
          
        }
       
        Simulation simulation;
        Bitmap image;
        private void btnSimulate_Click(object sender, EventArgs e)
        {
            simulation = Simulation.GetInstance();
            simulation.Height = Convert.ToInt32(txtHeight.Text);
            simulation.Width = Convert.ToInt32(txtWidth.Text);
            simulation.NodeCount = Convert.ToInt32(txtNodes.Text);
            simulation.Iterations = Convert.ToInt32(txtIterations .Text);
            simulation.DeltaT = 0.05f;
            simulation.BeaconInterval = simulation.DeltaT * Convert.ToInt32(txtBI.Text); ;
            float maxSpeed = (float)Convert.ToDouble(txtMaxSpeed.Text);
            float minSpeed = (float)Convert.ToDouble(txtMinSpeed.Text); 
            simulation.MaxNodeSpeed = new PointF(maxSpeed, maxSpeed);
            simulation.MinNodeSpeed = new PointF(minSpeed,minSpeed);
            simulation.NodeRange =(float) Convert.ToDouble(txtRange.Text);

            simulation.Energy = (float)Convert.ToDouble(txtEnergy.Text);
            simulation.TransmisionConsumption = (float)Convert.ToDouble(txtTransmisionEnergy.Text);
            simulation.ReceptionConsumption = (float)Convert.ToDouble(txtReciptionEnergy.Text);
            simulation.IdleConsumption = (float)Convert.ToDouble(txtIdleEnergy.Text);
            simulation.IsInfiniteEnergy = cbIsInfiniteEnergy.Checked;

            simulation.InitilizeSimulation();
            if (cbCostomize.Checked)
            {
                PowerOptionsForm frm = new GPSR.PowerOptionsForm();
                frm.ShowDialog();
            }
            simulation.g = Graphics.FromHwnd(pictureBox1.Handle);
            simulation.Simulate();
            //Bitmap img = new Bitmap(simulation.Width*5, simulation.Height*5);
            //Graphics g2 = Graphics.FromImage(img);
            //simulation.g = g2;
            //simulation.drawSimulation();
            //pictureBox1.Image = img;
          //  g2.Dispose();
            ResultsForm frmResults = new ResultsForm() { Packets = simulation.Packets };
            frmResults.Show();
            frmResultSummary frm2 = new GPSR.frmResultSummary();
            frm2.ResultSummary = simulation.ResultSummery;
            frm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Width = Width - 100;
            pictureBox1.Height = Height - 150;
            pictureBox1.Left = 50;
            pictureBox1.Top = 100;
        }
        
        
        
        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = image;
            
            Bitmap b = new Bitmap(image);
            Edge.DrawFullGraph(b);
            pictureBox1.Image = b;
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = image;

            Bitmap b = new Bitmap(image);
            Edge.DrawRngGraph(b);
            pictureBox1.Image = b;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = image;

            Bitmap b = new Bitmap(image);
            Edge.DrawGGraph(b);
            pictureBox1.Image = b;
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            simulation = Simulation.GetInstance();
            simulation.Height = 250;
            simulation.Width = 300;
            simulation.NodeCount = 15;
            simulation.Iterations = 100000;
            simulation.DeltaT = 0.05f;
            simulation.BeaconInterval = 5;
            simulation.MaxNodeSpeed = new PointF(5, 5);
            simulation.MinNodeSpeed = new PointF(1, 1);
            simulation.NodeRange = 120;
            simulation.InitilizeSimulation();
            simulation.g = Graphics.FromHwnd(pictureBox1.Handle);
            simulation.Simulate();
            image = simulation.drawSimulation();
            pictureBox1.Image = image;
           

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomize_Click(object sender, EventArgs e)
        {
          
            
        }
    }
   
}
