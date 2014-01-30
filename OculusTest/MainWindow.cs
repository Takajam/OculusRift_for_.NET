using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OculusRiftNet;

namespace OculusTest
{
    public partial class MainWindow : Form
    {
        private Ovr ovr;    //Wrapper

        private float yaw;
        public float Yaw
        {
            get { return yaw; }
        }

        private float pitch;
        public float Pitch
        {
            get { return pitch; }
        }

        private float roll;
        public float Roll
        {
            get { return roll; }
        }        

        private bool isTracked = false;
        public bool IsTracked
        {
            get { return isTracked; }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        //Initializing
        private void MainWindow_Load(object sender, EventArgs e)
        {
            ovr = new Ovr();
            ovr.Init();

            labelMonitorName.Text = ovr.HMDInfo.MonitorName;
            labelResolution.Text = ovr.HMDInfo.HResolution.ToString() + " / " + ovr.HMDInfo.VResolution.ToString();
            labelScreenSize.Text = ovr.HMDInfo.HScreenSize.ToString() + " / " + ovr.HMDInfo.VScreenSize.ToString();
            labelEyeToScreenDistance.Text = ovr.HMDInfo.EyeToScreenDistance.ToString();
            labelLensSeparationDistance.Text = ovr.HMDInfo.LensSeparationDistance.ToString();
            labelInterpupillaryDistance.Text = ovr.HMDInfo.InterpupillaryDistance.ToString();
            labelDistortionK.Text = ovr.HMDInfo.DistortionK[0].ToString() + " / " + ovr.HMDInfo.DistortionK[1].ToString() + " / " + ovr.HMDInfo.DistortionK[2].ToString() + " / " + ovr.HMDInfo.DistortionK[3].ToString();
            labelDesktop.Text = ovr.HMDInfo.DesktopX.ToString() + " / " + ovr.HMDInfo.DesktopY.ToString();
        }

        //Closing
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            ovr.Close();
        }

        //Start / Stop tracking
        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (isTracked)
            {
                isTracked = false;
                timerTracking.Stop();
                buttonStartStop.Text = "Tracking Start";
            }
            else
            {
                isTracked = true;
                timerTracking.Start();
                buttonStartStop.Text = "Tracking Stop";
            }
        }

        //Zero setting
        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (isTracked)
            {
                ovr.ResetSensors();
            }
        }

        //Timer
        //Update sensor values & display them each frame
        private void timerTracking_Tick(object sender, EventArgs e)
        {
            if (isTracked)
            {
                ovr.UpdateSensors();
                this.yaw = ovr.Pose.Angles.Yaw;
                this.pitch = ovr.Pose.Angles.Pitch;
                this.roll = ovr.Pose.Angles.Roll;

                labelYawRad.Text = this.yaw.ToString("f5");
                labelPitchRad.Text = this.pitch.ToString("f5");
                labelRollRad.Text = this.roll.ToString("f5");

                labelYawDeg.Text = (180.0f * this.yaw / Math.PI).ToString("f2");
                labelPitchDeg.Text = (180.0f * this.pitch / Math.PI).ToString("f2");
                labelRollDeg.Text = (180.0f * this.roll / Math.PI).ToString("f2");
            }
        }
    }
}
