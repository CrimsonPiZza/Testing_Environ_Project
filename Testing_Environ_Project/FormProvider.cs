using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Environ_Project
{
    class FormProvider
    {
        private static Main mainForm;
        private static GNSS_DataConversion gnss_DataConversion;
        private static Distance_Between_2positions distance_Between_2Positions;
        private static IMU_Display_Monitor imu_Display_Monitor;
        
        public static Main getMain()
        {
            if (mainForm == null)
            {
                mainForm = new Main();
                return mainForm;
            }
            return mainForm;
        }

        public static GNSS_DataConversion getGNSS_DataConversion()
        {
            if (gnss_DataConversion == null || gnss_DataConversion.IsDisposed)
            {
                gnss_DataConversion = new GNSS_DataConversion();
                return gnss_DataConversion;
            }
            return gnss_DataConversion;
        }

        public static Distance_Between_2positions getDistance_Between_2Positions()
        {
            if (distance_Between_2Positions == null || distance_Between_2Positions.IsDisposed)
            {
                distance_Between_2Positions = new Distance_Between_2positions();
                return distance_Between_2Positions;
            }
            return distance_Between_2Positions;
        }

        public static IMU_Display_Monitor getIMU_Display_Monitor()
        {
            if (imu_Display_Monitor == null || imu_Display_Monitor.IsDisposed)
            {
                imu_Display_Monitor = new IMU_Display_Monitor();
                return imu_Display_Monitor;
            }
            return imu_Display_Monitor;
        }
    }
}
