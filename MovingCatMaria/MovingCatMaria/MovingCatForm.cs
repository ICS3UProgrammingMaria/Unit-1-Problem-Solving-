/*
 * Created by: Maria 
 * Created on: 18-09-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Moving Cat
 * This program changes the picture of the cat based on 
 * what mni you click, it also includes an exit feature.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingCatMaria
{
    public partial class frmMovingCat : Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
        }

        private void mniCat1_Click(object sender, EventArgs e)
        {
            //Grabs the image from its location and displays it
            this.picCat.Image = Properties.Resources.cat1;
        }

        private void mniCat2_Click(object sender, EventArgs e)
        {
            //Takes the second cat picture and displays it
            this.picCat.Image = Properties.Resources.cat2;
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //Closes the program
            this.Close();
        }
    }
}
