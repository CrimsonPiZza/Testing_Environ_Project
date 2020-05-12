using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_Environ_Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void GNSS_DataConversion_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.getGNSS_DataConversion().Show();
        }

        private void Two_Positions_Distance_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.getDistance_Between_2Positions().Show();
        }
    }
}
