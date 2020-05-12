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
    public partial class Distance_Between_2positions : Form
    {
        public Distance_Between_2positions()
        {
            InitializeComponent();
        }

        private void Distance_Between_2positions_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormProvider.getMain().Show();
        }

        private void calculate_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text = distanceBetweenTwoPositions(Convert.ToDouble(lat1.Text), Convert.ToDouble(long1.Text), Convert.ToDouble(lat2.Text), Convert.ToDouble(long2.Text)).ToString();
            }catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private double distanceBetweenTwoPositions(double lat1,double long1, double lat2, double long2)
        {

            #region Algorithm_1

            /*            double R = 6378; // 6371000 meters -- Adjusting this also improve accuracy

                        double Phi_1 = lat1 * Math.PI / 180;
                        double Phi_2 = lat2 * Math.PI / 180;
                        double delta_Phi = (lat2 - lat1) * Math.PI / 180;
                        double delta_Lambda = (long2 - long1) * Math.PI / 180;

                        // Find a
                        double a = Math.Sin(delta_Phi / 2) * Math.Sin(delta_Phi / 2) +
                                   Math.Cos(Phi_1) * Math.Cos(Phi_2) *
                                   Math.Sin(delta_Lambda / 2) * Math.Sin(delta_Lambda / 2);

                        // Find c
                        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

                        double d = R * c;

                        return d;*/
            #endregion


            #region Algorithm_2
            // Algorithm 2
            double theta = long1 - long2;
            double dist = Math.Sin(deg2rad(lat1)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(lat1)) * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta));
            dist = Math.Acos(dist);
            dist = rad2deg(dist);
            dist = dist * 60 * 1.1515;

            dist = dist * 1.609344;

            return dist;
            #endregion
        }

        #region Support Functions
        private double deg2rad(double deg)
        {
            return (deg * Math.PI / 180.0);
        }

        private double rad2deg(double rad)
        {
            return (rad / Math.PI * 180.0);
        }
        #endregion
    }
}
