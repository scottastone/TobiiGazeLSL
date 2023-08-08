using System;
using System.Drawing;
using System.Windows.Forms;
using LSL;
using Tobii.Interaction;
using Tobii.Interaction.Framework;

namespace Tobii_Gaze_GUI
{
    public partial class GUI : Form
    {
        // Tobii streams
        private static Host host;
        private static GazePointDataStream gazePointDataStream;
        private static FixationDataStream fixationDataStream;
        private static EyePositionStream eyePositionStream;
        private static HeadPoseStream headPoseStream;

        // LSL info / outlets
        private static liblsl.StreamInfo gazeInfo;
        private static liblsl.StreamOutlet gazeOutlet;
        private static liblsl.StreamInfo fixationInfo;
        private static liblsl.StreamOutlet fixationOutlet;
        private static liblsl.StreamInfo mouseInfo;
        private static liblsl.StreamOutlet mouseOutlet;
        private static liblsl.StreamInfo eyePositionInfo;
        private static liblsl.StreamOutlet eyePositionOutlet;

        // Timers & internal variables
        private static Timer mouse_timer = new Timer();
        private static Timer uptime_timer = new Timer();
        private static Timer data_sent_timer = new Timer();
        private static Timer eyes_visible_timer = new Timer();
        private static UInt64 data_sent_count = 0;
        private static double gazeX, gazeY;
        private static Int32 mousePointX, mousePointY;
        private static double fixationBeginTime = 0d;
        private static UInt64 Fixation_ID = 0;
        private static bool hasLeftEye;
        private static bool hasRightEye;

        public GUI()
        {
            InitializeComponent();
        }
        
        public void CreateLSLStream()
        {
            host = new Host();
            if (streamGaze.Checked == true)
            {
                gazePointDataStream = host.Streams.CreateGazePointDataStream();
                gazeInfo = new liblsl.StreamInfo(lslHandle.Text, lslType.Text, 3, 90, liblsl.channel_format_t.cf_double64, "TobiiGazeStream");
                gazeOutlet = new liblsl.StreamOutlet(gazeInfo);
            }

            if (streamFixation.Checked == true)
            {
                fixationDataStream = host.Streams.CreateFixationDataStream();
                fixationInfo = new liblsl.StreamInfo(lslFixationHandle.Text, lslFixationTypeHandle.Text, 5, 0, liblsl.channel_format_t.cf_double64, "TobiiFixationStream");
                fixationOutlet = new liblsl.StreamOutlet(fixationInfo);
            }

            if (streamEyePos.Checked == true)
            {
                eyePositionStream = host.Streams.CreateEyePositionStream();
                eyePositionInfo = new liblsl.StreamInfo(lslEyePositionHandle.Text, lslEyePositionTypeHandle.Text, 6, 0, liblsl.channel_format_t.cf_double64, "TobiiEyePositionStream");
                eyePositionOutlet = new liblsl.StreamOutlet(eyePositionInfo);
            }

            if (streamMouse.Checked == true)
            {
                mouseInfo = new liblsl.StreamInfo(lslMouseHandle.Text, lslMouseTypeHandle.Text, 2, int.Parse(lslMouseSampleRate.Text), liblsl.channel_format_t.cf_int32, "MouseStream");
                mouseOutlet = new liblsl.StreamOutlet(mouseInfo);
            }

        }

        public static void ResetLSLStream()
        {
            try
            {
                // Does this need to do anything?
                /*
                host.Dispose();
                gazePointDataStream = null;
                gazeInfo            = null;
                fixationInfo        = null;
                fixationOutlet      = null;
                mouseInfo           = null;
                mouseOutlet         = null;
                gazeOutlet          = null;
                fixationDataStream  = null;
                eyePositionInfo     = null;
                eyePositionOutlet   = null;
                */
            }
            catch (Exception e)
            {
                _ = MessageBox.Show($"{e.Message}"); 
            }
            
        }
        private void StreamLSLButton_CheckedChanged(object sender, EventArgs e)
        {
            lslHandle.Enabled                = !lslHandle.Enabled;
            lslType.Enabled                  = !lslType.Enabled;
            lslFixationHandle.Enabled        = !lslFixationHandle.Enabled;
            lslFixationTypeHandle.Enabled    = !lslFixationTypeHandle.Enabled;
            lslMouseHandle.Enabled           = !lslMouseHandle.Enabled;
            lslMouseTypeHandle.Enabled       = !lslMouseTypeHandle.Enabled;
            lslMouseSampleRate.Enabled       = !lslMouseSampleRate.Enabled;
            lslEyePositionHandle.Enabled     = !lslEyePositionHandle.Enabled;
            lslEyePositionTypeHandle.Enabled = !lslEyePositionTypeHandle.Enabled;
            resetLSLButton.Enabled           = !resetLSLButton.Enabled;
            streamGaze.Enabled               = !streamGaze.Enabled;
            streamFixation.Enabled           = !streamFixation.Enabled;
            streamMouse.Enabled              = !streamMouse.Enabled;
            streamEyePos.Enabled             = !streamEyePos.Enabled;

            if (streamLSLButton.Checked == true)
            {
                ResetUptimeTimer(uptime_timer, 100);
                ResetDataSentTimer();
                CreateLSLStream();

                // Streams - TODO: add check box to select what streams we want
                if (streamGaze.Checked == true)
                    gazePointDataStream.GazePoint((gazePointX, gazePointY, timestamp) => SendGazePos(gazePointX, gazePointY, timestamp));

                if (streamFixation.Checked == true)
                    fixationDataStream.Next += (o, fixation) => SendFixationPos(o, fixation);

                if (streamMouse.Checked == true)
                    StartMouseTracking(mouse_timer, int.Parse(lslMouseSampleRate.Text));

                if (streamEyePos.Checked == true)
                    eyePositionStream.EyePosition((data) => SendEyePosition(data));
            }
            else
            {
                ResetLSLStream();
                uptime_timer.Stop();
                data_sent_timer.Stop();
            }
        }
        private void resetLSLButton_CheckedChanged(object sender, EventArgs e)
        {
            ResetLSLStream();
        }
        private void SendGazePos(double X, double Y, double Timestamp)
        {
            double[] data = new double[3];
            data[0] = Timestamp; data[1] = X; data[2] = Y;
            gazeOutlet.push_sample(data);

            gazeX = X; gazeY = Y;
            IncrementDataCounter();
        }

        private void SendFixationPos(object o, StreamData<FixationData> fixation)
        {
            double[] data = new double[5];

            double fixationPointX = fixation.Data.X;
            double fixationPointY = fixation.Data.Y;

            // Handle each type of fixation data (BEGIN - DATA - END)
            switch (fixation.Data.EventType)
            {
                case FixationDataEventType.Begin:
                    // TYPE 0 - BEGIN
                    fixationBeginTime = fixation.Data.Timestamp;
                    data[0] = fixation.Data.Timestamp;
                    data[1] = 0; // begin code - 0
                    data[2] = fixationPointX;
                    data[3] = fixationPointY;
                    data[4] = Fixation_ID;
                    break;

                case FixationDataEventType.Data:
                    // TYPE 1 - DATA
                    data[0] = fixation.Data.Timestamp;
                    data[1] = 1; // data code - 1
                    data[2] = fixationPointX;
                    data[3] = fixationPointY;
                    data[4] = Fixation_ID;
                    break;

                case FixationDataEventType.End:
                    // TYPE 2 - END
                    data[0] = fixation.Data.Timestamp;
                    data[1] = 2; // end code - 2
                    data[2] = fixationPointX;
                    data[3] = fixationPointY;
                    data[4] = Fixation_ID;
                    Fixation_ID = Fixation_ID + 1; // Increment the data counter - this says we have one full fixation completed now.
                    break;
                default:
                    throw new InvalidOperationException(message: "Unknown fixation event type, which doesn't have explicit handling.");
            }
            numFixations.Text = Fixation_ID.ToString();
            fixationOutlet.push_sample(data);
            IncrementDataCounter();
        }
        
        private void SendEyePosition(EyePositionData data)
        {
            double[] eye_pos = new double[7];
            double rightEyeX = data.RightEyeNormalized.X;
            double rightEyeY = data.RightEyeNormalized.Y;
            double rightEyeZ = data.RightEyeNormalized.Z;

            double leftEyeX  = data.LeftEyeNormalized.X;
            double leftEyeY  = data.LeftEyeNormalized.Y;
            double leftEyeZ  = data.LeftEyeNormalized.Z;

            hasLeftEye = data.HasLeftEyePosition;
            hasRightEye = data.HasRightEyePosition;

            eye_pos[0] = rightEyeX;
            eye_pos[1] = rightEyeY;
            eye_pos[2] = rightEyeZ;
            eye_pos[3] = leftEyeX;
            eye_pos[4] = leftEyeY;
            eye_pos[5] = leftEyeZ;
            eye_pos[6] = leftEyeX;

            eyePositionOutlet.push_sample(eye_pos);
            IncrementDataCounter();
        }

        private void UpdateUptime(object sender, EventArgs e)
        {
            double uptime = double.Parse(uptimeTextbox.Text) + (uptime_timer.Interval / 1000d);
            uptimeTextbox.Text = uptime.ToString();
        }

        private void ResetUptimeTimer(Timer timer, int interval)
        {
            timer.Interval = interval; // ms
            timer.Tick -= new EventHandler(UpdateUptime);
            timer.Tick += new EventHandler(UpdateUptime);
            uptimeTextbox.Text = "0";
            timer.Stop();
            timer.Start();
        }

        private void UpdateMousePos(object sender, EventArgs e)
        {
            // Mouse tracking cursor
            Point position = Cursor.Position;
            Int32[] pos = new Int32[2];
            pos[0] = position.X;
            pos[1] = position.Y;
            mousePointX = position.X;
            mousePointY = position.Y;
            mouseOutlet.push_sample(pos);
            IncrementDataCounter();
        }

        private void StartMouseTracking(Timer timer, int frequency)
        {
            timer.Stop();
            timer.Interval = 1000 / frequency; // TODO: what if it's not an int? eg 60hz?
            timer.Tick -= new EventHandler(UpdateMousePos);
            timer.Tick += new EventHandler(UpdateMousePos);
            timer.Start();
        }
        private void lslMouseSampleRate_TextChanged(object sender, EventArgs e)
        {
            // make sure it is only numbers and between 1 and 1000 hz
            if (lslMouseSampleRate.Text is "")
                return;

            var sampleRate = double.Parse(lslMouseSampleRate.Text);

            if (sampleRate > 1000)
                lslMouseSampleRate.Text = "1000";

            if (sampleRate < 0)
                lslMouseSampleRate.Text = "1";
        }

        private void lslMouseSampleRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is a numeric digit or a control key (e.g., backspace, delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Mark the event as handled, so the character is not inserted into the text box
                e.Handled = true;
            }
        }

        private void UpdateDataSent(object sender, EventArgs e)
        {
            //dataPacketsSent.Text = data_sent_count.ToString();
            dataSentCounter.Text = data_sent_count.ToString();
            gazeXBox.Text = $"{gazeX}";
            gazeYBox.Text = $"{gazeY}";
            mouseXBox.Text = $"{mousePointX}";
            mouseYBox.Text = $"{mousePointY}";

            // Check if the eyes are visible and update the color
            if (hasLeftEye == true)
            {
                leftEyeVisible.BackColor = Color.Lime;
            }
            else
            {
                leftEyeVisible.BackColor = Color.Crimson;
            }

            if (hasRightEye == true)
            {
                rightEyeVisible.BackColor = Color.Lime;
            }
            else
            {
                rightEyeVisible.BackColor = Color.Crimson;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResetDataSentTimer()
        {
            data_sent_count = 0;
            //dataPacketsSent.Text = data_sent_count.ToString();
            dataSentCounter.Text = data_sent_count.ToString();

            data_sent_timer.Stop();
            data_sent_timer.Interval = 50;
            data_sent_timer.Tick -= new EventHandler(UpdateDataSent);
            data_sent_timer.Tick += new EventHandler(UpdateDataSent);
            data_sent_timer.Start();
        }

        private void IncrementDataCounter()
        {
            data_sent_count++;
        }
    }
}
