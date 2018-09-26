/*
 * Created by: Maria 
 * Created on: 21-09-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - Area and perimeter
 * This program calculates the area and the perimeter
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

namespace AreaPerimeterMaria
{
    public partial class frmAreaPerimeter : Form
    {
        public frmAreaPerimeter()
        {
            InitializeComponent();
            this.lblPerimeter.Hide();
            this.lblArea.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare local variables
            double length, width, area, perimeter;

            //Convert the string from each text box to a double
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtWidth.Text);

            //Calculate the area and the perimeter
            area = length * width;
            perimeter = length + length + width + width;

            //Insert the area and the perimeter into their respective labels
            this.lblAreaAnswer.Text = Convert.ToString(area) + " squared meters";
            this.lblPerimeterAnswer.Text = Convert.ToString(perimeter) + " squared meters";

            //Display the perimeter and area labels with their respective answers
            this.lblPerimeter.Show();
            this.lblArea.Show();
            this.lblPerimeterAnswer.Show();
            this.lblAreaAnswer.Show();
        }
    }
}



