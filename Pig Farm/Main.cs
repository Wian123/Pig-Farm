using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pig_Farm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void programParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Parameters pa = new Parameters();
            pa.Show();
        }

        private void animalClassesAndBreedsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classes_and_Breeds CaB = new Classes_and_Breeds();
            CaB.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void housingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Housing hous = new Housing();
            hous.Show();
        }

        private void herdsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Herds herds = new Herds();
            herds.Show();
        }

        private void medicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medical med = new Medical();
            med.Show();
        }

        private void feedingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Feeding feed = new Feeding();
            feed.Show();
        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cullingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Culling cul = new Culling();
            cul.Show();
        }

        private void marketingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marketing mar = new Marketing();
            mar.Show();
        }
    }
}
