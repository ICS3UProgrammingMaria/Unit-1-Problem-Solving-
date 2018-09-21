/*
 * Created by: Maria
 * Created on: 14-September-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - Name of Program
 * This program contains a menu strip with various menu items. When you click
 * on a different menu item, the text in the label changes. 
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

namespace SchoolMascotsMaria
{
    public partial class SchoolMascotForm : Form
    {
        public SchoolMascotForm()
        {
            InitializeComponent();
        }

        private void mniStJoes_Click(object sender, EventArgs e)
        {
            //This line changes the school name label to St. joes
            lblSchoolName.Text = "St. Joes";
            lblSchoolMascot.Text = "Ram";
        }

        private void mniImmaculata_Click(object sender, EventArgs e)
        {
            lblSchoolName.Text = "Immacualta";
            //This line changes the mascot label to saints
            lblSchoolMascot.Text = "Saints";
        }

        private void mniStMarks_Click(object sender, EventArgs e)
        {
            lblSchoolName.Text = "St. Marks";
            lblSchoolMascot.Text = "Lions";
        }

        private void mniMotherTeresa_Click(object sender, EventArgs e)
        {
            lblSchoolName.Text = "Mother Teresa";
            lblSchoolMascot.Text = "Titans";
        }
    }
}
