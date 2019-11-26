using System;
using System.Windows.Forms;
using Tobii_Gaze_GUI;

public class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        Application.EnableVisualStyles();
        Application.Run(new GUI());
    }
}