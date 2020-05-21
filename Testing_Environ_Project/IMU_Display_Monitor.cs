using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Testing_Environ_Project
{
    public partial class IMU_Display_Monitor : Form
    {

        public static Thread thr;
        public float acx;
        public float acy;
        public float acz;
        public float gyx;
        public float gyy;
        public float gyz;
        public float mgx;
        public float mgy;
        public float mgz;
        public double _pitch;
        public double _yaw;
        public double _roll;
        public class ExThread
        {
            public ExThread(ZenClientHandle_t zenHandle)
            {
                mZenHandle = zenHandle;
            }

            // Non-static method 
            public void sensorEventThread()
            {
                try
                {
                    while (true)
                    {
                        ZenEvent zenEvent = new ZenEvent();
                        //Console.WriteLine(mZenHandle);
                        if (OpenZen.ZenWaitForNextEvent(mZenHandle, zenEvent))
                        {
                            if (zenEvent.component.handle == 0)
                            {
                                // if the handle is on, its not a sensor event but a system wide 
                                // event
                                switch (zenEvent.eventType)
                                {
                                    case (int)ZenSensorEvent.ZenSensorEvent_SensorFound:
                                        Console.WriteLine("found sensor event event " + zenEvent.data.sensorFound.name);
                                        mFoundSensors.Add(zenEvent.data.sensorFound);
                                        break;
                                    case (int)ZenSensorEvent.ZenSensorEvent_SensorListingProgress:
                                        if (zenEvent.data.sensorListingProgress.progress == 1.0)
                                        {
                                            mSearchDone = true;
                                        }
                                        break;
                                }
                            }
                            else
                            {
                                switch (zenEvent.eventType)
                                {
                                    case (int)ZenImuEvent.ZenImuEvent_Sample:
                                        mImuEventCount++;

                                        if (mImuEventCount % 100 == 0)
                                            continue;
                                        // read acceleration
                                        OpenZenFloatArray fa = OpenZenFloatArray.frompointer(zenEvent.data.imuData.a);
                                        // read euler angles
                                        OpenZenFloatArray fg = OpenZenFloatArray.frompointer(zenEvent.data.imuData.g);
                                        // read quaternion
                                        OpenZenFloatArray fb = OpenZenFloatArray.frompointer(zenEvent.data.imuData.b);

                                        // Output Data
                                        IMU_Display_Monitor imu = FormProvider.getIMU_Display_Monitor();

                                        // Accelerometer
                                        imu.acx = fa.getitem(0);
                                        imu.acy = fa.getitem(1);
                                        imu.acz= fa.getitem(2);

                                        // Gyroscope
                                        imu.gyx = fg.getitem(0);
                                        imu.gyy = fg.getitem(1);
                                        imu.gyz = fg.getitem(2);

                                        // Magnetometer
                                        imu.mgx = fb.getitem(0);
                                        imu.mgy = fb.getitem(1);
                                        imu.mgz = fb.getitem(2);

                                        break;
                                }
                            }
                        }
                    }
                }
                catch (ThreadAbortException)
                {
                }
            }

            public bool mSearchDone = false;
            public uint mImuEventCount = 0;
            public List<ZenSensorDesc> mFoundSensors = new List<ZenSensorDesc>();
            ZenClientHandle_t mZenHandle;
        }


        public IMU_Display_Monitor()
        {
            InitializeComponent();
            main();
        }

        public static void main()
        {
            // Start of Code
            ZenClientHandle_t zenHandle = new ZenClientHandle_t();
            OpenZen.ZenInit(zenHandle);

            ExThread obj = new ExThread(zenHandle);

            // Creating thread 
            // Using thread class 
            thr = new Thread(new ThreadStart(obj.sensorEventThread));
            thr.Start();

            // start sensor listing, new sensors will be reported as Events in our event thread
            OpenZen.ZenListSensorsAsync(zenHandle);

            while (!obj.mSearchDone)
            {
                Console.WriteLine("Searching for sensors ...");
                Thread.Sleep(1000);
            }

            ZenSensorInitError sensorInitError = ZenSensorInitError.ZenSensorInitError_Max;
            // try three connection attempts
            for (int i = 0; i < 3; i++)
            {
                ZenSensorHandle_t sensorHandle = new ZenSensorHandle_t();
                sensorInitError = OpenZen.ZenObtainSensor(zenHandle, obj.mFoundSensors[0], sensorHandle);
                if (sensorInitError == ZenSensorInitError.ZenSensorInitError_None)
                {
                    Console.WriteLine("Succesfully connected to sensor");
                    break;
                }
            }

            if (sensorInitError != ZenSensorInitError.ZenSensorInitError_None)
            {
                Console.WriteLine("Could not connect to sensor");
                System.Environment.Exit(1);
            }
        }

        private void data_Setter_Tick(object sender, EventArgs e)
        {
            // Accelerometer
            accx.Text = acx.ToString();
            accy.Text = acy.ToString();
            accz.Text = acz.ToString();

            // Gyrocscope
            gysx.Text = gyx.ToString();
            gysy.Text = gyy.ToString();
            gysz.Text = gyz.ToString();

            // Magmetometer
            mgtx.Text = mgx.ToString();
            mgty.Text = mgy.ToString();
            mgtz.Text = mgz.ToString();

            // Pitch
            getPitch();

            // Roll
            getRoll();

            // Yaw
            getYaw();
        }

        public void getPitch()
        {
            // 1st Formula
            //_pitch = 180 * Math.Atan2(acx, Math.Sqrt(Math.Pow(acy, 2) + Math.Pow(acz, 2))) / Math.PI;

            // 2nd Formula
            _pitch = Math.Atan2(-acx, Math.Sqrt(acy * acy + acz * acz)) * 180 / Math.PI;
            
            this.pitch.Text = _pitch.ToString();
        }

        public void getRoll()
        {
            // 1st Formula
            //_roll = 180 * Math.Atan2(acy, Math.Sqrt(Math.Pow(acx, 2) + Math.Pow(acz, 2))) / Math.PI;

            // 2nd Formula
            _roll = Math.Atan2(acy, acz) * 180 / Math.PI;

            this.roll.Text = _roll.ToString();
        }

        public void getYaw()
        {
            // 1st Fromula
            //double mag_x = mgx * Math.Cos(_pitch) + mgy * Math.Sin(_roll) * Math.Sin(_pitch) + mgz * Math.Cos(_roll) * Math.Sin(_pitch);
            //double mag_y = mgy * Math.Cos(_roll) - mgz * Math.Sin(_roll);
            //_yaw = 180 * Math.Atan2(-mag_y, mag_x) / Math.PI;

            // 2nd Formula
            _yaw = 180 * Math.Atan2(mgy, mgx) / Math.PI;

            this.yaw.Text = _yaw.ToString();
        }

        private void IMU_Display_Monitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            thr.Abort();
            FormProvider.getMain().Show();
        }
    }
}
