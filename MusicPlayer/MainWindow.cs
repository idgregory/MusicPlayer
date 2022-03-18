using MusicPlayer.Music;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {

            //List<Album> al = new List<Album>();
            //for (int k = 1; k <= 5; k++)
            //{

            //    Album a1 = new Album($"This is album {k}");
            //    List<Song> s = a1.Songs;
            //    for(int i = 1; i <= 5; i++)
            //    {
            //        s.Add(new Song($"Song {i}"));
            //    }
            //    al.Add(a1);
            //}
            //List<Album> l6 = al;
            //string str = "";
            
            //foreach(var a in al)
            //{
            //    str += a.Name + "\n";
            //    foreach(var s in a.Songs)
            //    {
            //        str += "\t" + s.Name + "\n";
            //    }
            //}

            InitializeComponent();
            //label1.Text = str;
        }

        private WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();
        private void returnTrueIfDone()
        {
            label1.Invoke((MethodInvoker) (() =>{label1.Text = "Import";}));
        }
        private void ImportMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(returnTrueIfDone);
            t.Start();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            if (Player.status.ToLower().Contains("playing")) 
            {
                this.Player.controls.pause();
                playBtn.Text = "Play";
            }
            else if(Player.status.ToLower().Contains("pause"))
            {
                this.Player.controls.play();
                playBtn.Text = "Pause";
            }
            else
            {
                playBtn.Text = "Pause";
                Player.URL = "G:\\Music\\Led Zeppelin\\Physical Graffiti [Disc 2]\\04 Ten Years Gone.mp3";
                Player.controls.play();
            }
            //switch(this.Player.status)
            //{
            //    case "Paused":
            //        this.Player.controls.play();
            //    playBtn.Text = "Pause";
            //    Debugger.Break();
            //    break;
            //    case "Play":

            //    Debugger.Break();
            //    break;
            //    case "":
            //        playBtn.Text = "Pause";
            //    Player.URL = "G:\\Music\\Led Zeppelin\\Physical Graffiti [Disc 2]\\04 Ten Years Gone.mp3";
            //    Player.controls.play();
            //    Debugger.Break();
            //    break;

            //}


        }

        private void VolBar_Scroll(object sender, EventArgs e)
        {
            Player.settings.volume = VolBar.Value;
        }
    }
}
