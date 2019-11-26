using System;
using System.Windows.Forms;
using LSL;
using Tobii.Interaction;
namespace Tobii_Gaze_GUI
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }
        public static Host host;
        public static GazePointDataStream gazePointDataStream;
        public static liblsl.StreamInfo gazeInfo;
        public static liblsl.StreamOutlet gazeOutlet;
        public static double[] data = new double[3];
        public void CreateLSLStream()
        {
            host = new Host();
            gazePointDataStream = host.Streams.CreateGazePointDataStream();
            gazeInfo = new liblsl.StreamInfo(lslHandle.Text, lslType.Text, 3, 90, liblsl.channel_format_t.cf_double64, "TobiiGazeStream");
            gazeOutlet = new liblsl.StreamOutlet(gazeInfo);
        }

        public void ResetLSLStream()
        {
            try
            {
                host.Dispose();
                gazePointDataStream = null;
                gazeInfo = null;
                gazeOutlet = null;
                GC.Collect(); // Call the internal garbage collector
            } catch (Exception e){ _ = System.Windows.Forms.MessageBox.Show("Error: no stream to reset - try starting a stream before you reset."); }
            finally{ CreateLSLStream(); }
            
        }
        private void streamLSLButton_CheckedChanged(object sender, EventArgs e)
        {
            lslHandle.Enabled = !lslHandle.Enabled;
            lslType.Enabled = !lslType.Enabled;
            resetLSLButton.Enabled = !resetLSLButton.Enabled;

            if (streamLSLButton.Checked == true)
            {
                CreateLSLStream();
                gazePointDataStream.GazePoint((gazePointX, gazePointY, timestamp) => SendGazePos(gazePointX, gazePointY, timestamp, gazeOutlet));
            }
            else
            {
                ResetLSLStream();
            }

        }
        private void resetLSLButton_CheckedChanged(object sender, EventArgs e)
        {
            ResetLSLStream();
        }
        private void SendGazePos(double X, double Y, double Timestamp, liblsl.StreamOutlet Outlet)
        {
            data[0] = Timestamp; data[1] = X; data[2] = Y;
            Outlet.push_sample(data);
        }
    }
}
