namespace OculusTest
{
    partial class MainWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelYawRad = new System.Windows.Forms.Label();
            this.labelPitchRad = new System.Windows.Forms.Label();
            this.labelRollRad = new System.Windows.Forms.Label();
            this.labelYawDeg = new System.Windows.Forms.Label();
            this.labelPitchDeg = new System.Windows.Forms.Label();
            this.labelMonitorName = new System.Windows.Forms.Label();
            this.labelRollDeg = new System.Windows.Forms.Label();
            this.labelInterpupillaryDistance = new System.Windows.Forms.Label();
            this.labelResolution = new System.Windows.Forms.Label();
            this.labelLensSeparationDistance = new System.Windows.Forms.Label();
            this.labelDesktop = new System.Windows.Forms.Label();
            this.labelDistortionK = new System.Windows.Forms.Label();
            this.labelEyeToScreenDistance = new System.Windows.Forms.Label();
            this.labelScreenSize = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.timerTracking = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(358, 41);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(113, 23);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "Zero Set";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yaw:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pitch:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Roll:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Interpupillary Distance:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lens Separation Distance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "MonitorName:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "Resolution:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "ScreenSize:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "Eye To Screen Distance:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "Distortion K:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "Desktop:";
            // 
            // labelYawRad
            // 
            this.labelYawRad.AutoSize = true;
            this.labelYawRad.Location = new System.Drawing.Point(73, 25);
            this.labelYawRad.Name = "labelYawRad";
            this.labelYawRad.Size = new System.Drawing.Size(43, 12);
            this.labelYawRad.TabIndex = 12;
            this.labelYawRad.Text = "0.00000";
            // 
            // labelPitchRad
            // 
            this.labelPitchRad.AutoSize = true;
            this.labelPitchRad.Location = new System.Drawing.Point(73, 54);
            this.labelPitchRad.Name = "labelPitchRad";
            this.labelPitchRad.Size = new System.Drawing.Size(43, 12);
            this.labelPitchRad.TabIndex = 13;
            this.labelPitchRad.Text = "0.00000";
            // 
            // labelRollRad
            // 
            this.labelRollRad.AutoSize = true;
            this.labelRollRad.Location = new System.Drawing.Point(73, 80);
            this.labelRollRad.Name = "labelRollRad";
            this.labelRollRad.Size = new System.Drawing.Size(43, 12);
            this.labelRollRad.TabIndex = 14;
            this.labelRollRad.Text = "0.00000";
            // 
            // labelYawDeg
            // 
            this.labelYawDeg.AutoSize = true;
            this.labelYawDeg.Location = new System.Drawing.Point(181, 25);
            this.labelYawDeg.Name = "labelYawDeg";
            this.labelYawDeg.Size = new System.Drawing.Size(25, 12);
            this.labelYawDeg.TabIndex = 15;
            this.labelYawDeg.Text = "0.00";
            // 
            // labelPitchDeg
            // 
            this.labelPitchDeg.AutoSize = true;
            this.labelPitchDeg.Location = new System.Drawing.Point(181, 54);
            this.labelPitchDeg.Name = "labelPitchDeg";
            this.labelPitchDeg.Size = new System.Drawing.Size(25, 12);
            this.labelPitchDeg.TabIndex = 16;
            this.labelPitchDeg.Text = "0.00";
            // 
            // labelMonitorName
            // 
            this.labelMonitorName.AutoSize = true;
            this.labelMonitorName.Location = new System.Drawing.Point(163, 24);
            this.labelMonitorName.Name = "labelMonitorName";
            this.labelMonitorName.Size = new System.Drawing.Size(11, 12);
            this.labelMonitorName.TabIndex = 17;
            this.labelMonitorName.Text = "-";
            // 
            // labelRollDeg
            // 
            this.labelRollDeg.AutoSize = true;
            this.labelRollDeg.Location = new System.Drawing.Point(181, 80);
            this.labelRollDeg.Name = "labelRollDeg";
            this.labelRollDeg.Size = new System.Drawing.Size(25, 12);
            this.labelRollDeg.TabIndex = 18;
            this.labelRollDeg.Text = "0.00";
            // 
            // labelInterpupillaryDistance
            // 
            this.labelInterpupillaryDistance.AutoSize = true;
            this.labelInterpupillaryDistance.Location = new System.Drawing.Point(163, 134);
            this.labelInterpupillaryDistance.Name = "labelInterpupillaryDistance";
            this.labelInterpupillaryDistance.Size = new System.Drawing.Size(11, 12);
            this.labelInterpupillaryDistance.TabIndex = 21;
            this.labelInterpupillaryDistance.Text = "-";
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Location = new System.Drawing.Point(163, 46);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(11, 12);
            this.labelResolution.TabIndex = 20;
            this.labelResolution.Text = "-";
            // 
            // labelLensSeparationDistance
            // 
            this.labelLensSeparationDistance.AutoSize = true;
            this.labelLensSeparationDistance.Location = new System.Drawing.Point(163, 112);
            this.labelLensSeparationDistance.Name = "labelLensSeparationDistance";
            this.labelLensSeparationDistance.Size = new System.Drawing.Size(11, 12);
            this.labelLensSeparationDistance.TabIndex = 19;
            this.labelLensSeparationDistance.Text = "-";
            // 
            // labelDesktop
            // 
            this.labelDesktop.AutoSize = true;
            this.labelDesktop.Location = new System.Drawing.Point(163, 178);
            this.labelDesktop.Name = "labelDesktop";
            this.labelDesktop.Size = new System.Drawing.Size(11, 12);
            this.labelDesktop.TabIndex = 23;
            this.labelDesktop.Text = "-";
            // 
            // labelDistortionK
            // 
            this.labelDistortionK.AutoSize = true;
            this.labelDistortionK.Location = new System.Drawing.Point(163, 156);
            this.labelDistortionK.Name = "labelDistortionK";
            this.labelDistortionK.Size = new System.Drawing.Size(11, 12);
            this.labelDistortionK.TabIndex = 22;
            this.labelDistortionK.Text = "-";
            // 
            // labelEyeToScreenDistance
            // 
            this.labelEyeToScreenDistance.AutoSize = true;
            this.labelEyeToScreenDistance.Location = new System.Drawing.Point(163, 90);
            this.labelEyeToScreenDistance.Name = "labelEyeToScreenDistance";
            this.labelEyeToScreenDistance.Size = new System.Drawing.Size(11, 12);
            this.labelEyeToScreenDistance.TabIndex = 26;
            this.labelEyeToScreenDistance.Text = "-";
            // 
            // labelScreenSize
            // 
            this.labelScreenSize.AutoSize = true;
            this.labelScreenSize.Location = new System.Drawing.Point(163, 68);
            this.labelScreenSize.Name = "labelScreenSize";
            this.labelScreenSize.Size = new System.Drawing.Size(11, 12);
            this.labelScreenSize.TabIndex = 25;
            this.labelScreenSize.Text = "-";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(140, 80);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(17, 12);
            this.label29.TabIndex = 31;
            this.label29.Text = "->";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(140, 54);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(17, 12);
            this.label30.TabIndex = 30;
            this.label30.Text = "->";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(140, 25);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(17, 12);
            this.label31.TabIndex = 29;
            this.label31.Text = "->";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.labelYawRad);
            this.groupBox1.Controls.Add(this.labelPitchRad);
            this.groupBox1.Controls.Add(this.labelRollRad);
            this.groupBox1.Controls.Add(this.labelYawDeg);
            this.groupBox1.Controls.Add(this.labelPitchDeg);
            this.groupBox1.Controls.Add(this.labelRollDeg);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 110);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tracking";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.labelDesktop);
            this.groupBox2.Controls.Add(this.labelEyeToScreenDistance);
            this.groupBox2.Controls.Add(this.labelDistortionK);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelInterpupillaryDistance);
            this.groupBox2.Controls.Add(this.labelScreenSize);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.labelMonitorName);
            this.groupBox2.Controls.Add(this.labelLensSeparationDistance);
            this.groupBox2.Controls.Add(this.labelResolution);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 204);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Device Information";
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Location = new System.Drawing.Point(358, 12);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(113, 23);
            this.buttonStartStop.TabIndex = 34;
            this.buttonStartStop.Text = "Tracking Start";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // timerTracking
            // 
            this.timerTracking.Interval = 10;
            this.timerTracking.Tick += new System.EventHandler(this.timerTracking_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 341);
            this.Controls.Add(this.buttonStartStop);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonReset);
            this.Name = "MainWindow";
            this.Text = "Oculus Rift Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelYawRad;
        private System.Windows.Forms.Label labelPitchRad;
        private System.Windows.Forms.Label labelRollRad;
        private System.Windows.Forms.Label labelYawDeg;
        private System.Windows.Forms.Label labelPitchDeg;
        private System.Windows.Forms.Label labelMonitorName;
        private System.Windows.Forms.Label labelRollDeg;
        private System.Windows.Forms.Label labelInterpupillaryDistance;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.Label labelLensSeparationDistance;
        private System.Windows.Forms.Label labelDesktop;
        private System.Windows.Forms.Label labelDistortionK;
        private System.Windows.Forms.Label labelEyeToScreenDistance;
        private System.Windows.Forms.Label labelScreenSize;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.Timer timerTracking;
    }
}

