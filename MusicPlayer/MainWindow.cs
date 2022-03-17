using MusicPlayer.Music;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            List<Album> al = new List<Album>();
            for (int k = 1; k <= 5; k++)
            {

                Album a1 = new Album($"This is album {k}");
                List<Song> s = a1.Songs;
                for(int i = 1; i <= 5; i++)
                {
                    s.Add(new Song($"Song {i}"));
                }
                al.Add(a1);
            }
            List<Album> l6 = al;
            string str = "";
            
            foreach(var a in al)
            {
                str += a.Name + "\n";
                foreach(var s in a.Songs)
                {
                    str += s.Name + "\n";
                }
            }

            InitializeComponent();
            label1.Text = str;
        }


        private void returnTrueIfDone()
        {
            Thread.Sleep(30000);
            label1.Invoke((MethodInvoker)
                (
                    () =>
                    {
                        label1.Text = "True";
                    }
                )
            );
        }
        private void ImportMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(returnTrueIfDone);
            t.Start();
        }
    }
}
