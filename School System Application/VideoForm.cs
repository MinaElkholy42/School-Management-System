using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace School_System_Application
{
    public partial class VideoForm : Form
    {
        // this variable to hold the path of the video
        string path;
        public VideoForm()
        {
            InitializeComponent();
            // initialize the path of the video 
            path = "school.mp4";
        }

        private void VideoForm_Load(object sender, EventArgs e)
        {
            // check if the video in the path of the application 
            if(!File.Exists(path)) // case the video not in the path
            {
                // make file stream to create the video file 
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                // make binary writer to write the bytes of the video uisng the file stream
                BinaryWriter bw = new BinaryWriter(fs);
                // write the bytes of the video using the binary writer from the resources to the file stream 
                bw.Write(Properties.Resources.School_4);
                // close the binary writer 
                bw.Close();
                // close the file stream 
                fs.Close();
            }

            // set the path of the video to the media player 
            MediaPlayer.URL = path;
            // play the video from the ctl controls of the media player 
            MediaPlayer.Ctlcontrols.play();
        }

        private void MediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // in case the video has stopped
            if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                // move to the next form 
                MainPersonalForm mf = new MainPersonalForm(false); // make object from the next form 
                this.Hide(); // hide the current from 
                mf.TopLevel = true; // make the personal form on the top of all levels 
                mf.Show(); // show the main personal from
            }
        }

        private void MediaPlayer_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {
            // in case the enterd button is Enter
            if (e.nKeyCode == (short)Keys.Enter)
                // stop the playing of the video 
                MediaPlayer.Ctlcontrols.stop(); 
        }
    }
}
