using System;
using System.Windows.Forms;
using LSL;
using Tobii.Interaction;
using Tobii.Interaction.Framework;

namespace Tobii_Gaze_GUI
{
    public partial class GUI : Form
    {
        private static Host host;
        private static GazePointDataStream gazePointDataStream;
        private static FixationDataStream fixationDataStream;
        private static liblsl.StreamInfo gazeInfo;
        private static liblsl.StreamOutlet gazeOutlet;
        private static liblsl.StreamInfo fixationInfo;
        private static liblsl.StreamOutlet fixationOutlet;
        public static Timer uptime_timer = new Timer();

        public GUI()
        {
            InitializeComponent();
        }
        
        public void CreateLSLStream()
        {
            host = new Host();
            gazePointDataStream = host.Streams.CreateGazePointDataStream();
            fixationDataStream = host.Streams.CreateFixationDataStream();

            gazeInfo = new liblsl.StreamInfo(lslHandle.Text, lslType.Text, 3, 90, liblsl.channel_format_t.cf_double64, "TobiiGazeStream");
            gazeOutlet = new liblsl.StreamOutlet(gazeInfo);

            fixationInfo = new liblsl.StreamInfo(lslFixationHandle.Text, lslFixationTypeHandle.Text, 5, 0, liblsl.channel_format_t.cf_double64, "TobiiFixationStream");
            fixationOutlet = new liblsl.StreamOutlet(fixationInfo);
        }

        public void ResetLSLStream()
        {
            try
            {
                host.Dispose();
                gazePointDataStream = null;
                gazeInfo = null;
                gazeOutlet = null;
                fixationDataStream = null;
                fixationInfo = null;
                fixationOutlet = null;
                GC.Collect(); // Call the internal garbage collector
            }
            catch (Exception) { _ = MessageBox.Show("Error: no stream to reset - try starting a stream before you reset."); }
            finally{ CreateLSLStream(); }
            
        }
        private void streamLSLButton_CheckedChanged(object sender, EventArgs e)
        {
            lslHandle.Enabled = !lslHandle.Enabled;
            lslType.Enabled = !lslType.Enabled;
            lslFixationHandle.Enabled = !lslFixationHandle.Enabled;
            lslFixationTypeHandle.Enabled = !lslFixationTypeHandle.Enabled;
            resetLSLButton.Enabled = !resetLSLButton.Enabled;

            if (streamLSLButton.Checked == true)
            {
                ResetTimer(uptime_timer);

                CreateLSLStream();
                gazePointDataStream.GazePoint((gazePointX, gazePointY, timestamp) => SendGazePos(gazePointX, gazePointY, timestamp, gazeOutlet));
                // Fixation - Output looks like this:
                // Timestamp, Type, FixX, FixY
                var fixationBeginTime = 0d;
                var ID = 0;
                fixationDataStream.Next += (o, fixation) =>
                {
                    double[] data = new double[5];

                    // On the Next event, data comes as FixationData objects, wrapped in a StreamData<T> object.
                    var fixationPointX = fixation.Data.X;
                    var fixationPointY = fixation.Data.Y;

                    // Handle each type of fixation data (BEGIN - DATA - END)
                    switch (fixation.Data.EventType)
                    {
                        case FixationDataEventType.Begin:
                            // TYPE 0 - BEGIN
                            fixationBeginTime = fixation.Data.Timestamp;
                            data[0] = fixation.Data.Timestamp;
                            data[1] = 0; // begin code - 0
                            data[2] = fixationPointX; data[3] = fixationPointY;
                            data[4] = ID;
                            break;

                        case FixationDataEventType.Data:
                            // TYPE 1 - DATA
                            data[0] = fixation.Data.Timestamp;
                            data[1] = 1; // data code - 1
                            data[2] = fixationPointX; data[3] = fixationPointY;
                            data[4] = ID;
                            break;

                        case FixationDataEventType.End:
                            // TYPE 2 - END
                            data[0] = fixation.Data.Timestamp;
                            data[1] = 2; // end code - 2
                            data[2] = fixationPointX; data[3] = fixationPointY;
                            data[4] = ID;
                            ID = ID + 1; // Increment the data counter - this says we have one full fixation completed now.
                            break;
                        default:
                            throw new InvalidOperationException("Unknown fixation event type, which doesn't have explicit handling.");
                    }
                    numFixations.Text = ID.ToString();
                    fixationOutlet.push_sample(data);
                    
                };
            }
            else
            {
                ResetLSLStream();
                uptime_timer.Stop();
            }
        }
        private void resetLSLButton_CheckedChanged(object sender, EventArgs e)
        {
            ResetLSLStream();
        }
        private void SendGazePos(double X, double Y, double Timestamp, liblsl.StreamOutlet Outlet)
        {
            double[] data = new double[3];
            data[0] = Timestamp; data[1] = X; data[2] = Y;
            Outlet.push_sample(data);
        }

        private void UpdateUptime(object sender, EventArgs e)
        {
            double uptime = double.Parse(uptimeTextbox.Text) + (uptime_timer.Interval / 1000d);
            uptimeTextbox.Text = uptime.ToString();
        }

        private void ResetTimer(Timer timer)
        {
            timer.Interval = 100; // ms
            timer.Tick -= new EventHandler(UpdateUptime);
            timer.Tick += new EventHandler(UpdateUptime);
            // check if timer has an eventhandler already
            uptimeTextbox.Text = "0";
            timer.Stop();
            timer.Start();
        }
    }
}
