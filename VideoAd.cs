using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PopupPersonalGain
{
    public partial class VideoAd : LBForm
    {

        private VLCPlayer vp;
        private Configuracion cfg;

        private Dictionary<string, uint> keysdic = new Dictionary<string, uint>(),
            modsdic = new Dictionary<string, uint>();
        string[] play, pause, stop, floadkey, volup, voldown, ffward, fbward, hidewin, showwin;

        public VideoAd()
        {
            InitializeComponent();
            try
            {
                vp = new VLCPlayer("plugins");
                vp.SetRenderWindow((int)videobase.Handle);
            }
            catch (Exception ee)
            {
                MessageBox.Show("VLC components cannot be loaded! \n" + ee.Message);
                Environment.Exit(1);
                return;
            }
            foreach (Keys foo in Enum.GetValues(typeof(Keys)))
            {
                if (!keysdic.ContainsKey(foo.ToString())) keysdic.Add(foo.ToString(), (uint)foo);
            }
            foreach (HotKey.LosModifiers foo in Enum.GetValues(typeof(HotKey.LosModifiers)))
            {
                if (!modsdic.ContainsKey(foo.ToString())) modsdic.Add(foo.ToString(), (uint)foo);
            }
        }

        public void RegOptKey(string[] codigo, int id)
        {
            uint modk = 0, kk = 0;
            foreach (string ss in codigo)
            {
                if (keysdic.ContainsKey(ss) && !modsdic.ContainsKey(ss)) kk |= keysdic[ss];
                if (modsdic.ContainsKey(ss)) modk |= modsdic[ss];
            }
            HotKey.RegisterHotKey(this.Handle, id, (HotKey.LosModifiers)modk, (Keys)kk);
        }

        #region Events

        private void VideoAd_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Size.Width - this.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Size.Height - this.Height;
            this.SetDesktopLocation(x, y);
            videobase.BackColor = Color.GhostWhite;
            fondo.BackColor = Color.White;


            if (!File.Exists("cfg.json"))
            {
                MessageBox.Show("Please provide configuration file which is named 'cfg.json' under this directory!");
                Environment.Exit(0);
                return;
            }
            using (StreamReader sr = new StreamReader("cfg.json"))
            {
                string jsonstr = sr.ReadToEnd();
                if ((cfg = JsonConvert.DeserializeObject<Configuracion>(jsonstr)) == null)
                {
                    MessageBox.Show("The grammar of json file may not be correct!");
                    Environment.Exit(0);
                    return;
                }
            }

            play = cfg.shortcuts.play.Split('+');
            pause = cfg.shortcuts.pause.Split('+');
            stop = cfg.shortcuts.stop.Split('+');
            floadkey = cfg.shortcuts.floadkey.Split('+');
            volup = cfg.shortcuts.volup.Split('+');
            voldown = cfg.shortcuts.voldown.Split('+');
            ffward = cfg.shortcuts.ffward.Split('+');
            fbward = cfg.shortcuts.fbward.Split('+');
            hidewin = cfg.shortcuts.hidewin.Split('+');
            showwin = cfg.shortcuts.showwin.Split('+');

            RegOptKey(play, 1001);
            RegOptKey(pause, 1002);
            RegOptKey(stop, 1003);
            RegOptKey(floadkey, 1004);
            RegOptKey(volup, 1005);
            RegOptKey(voldown, 1006);
            RegOptKey(ffward, 1007);
            RegOptKey(fbward, 1008);
            RegOptKey(hidewin, 1009);
            RegOptKey(showwin, 1010);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            for (int i = 1001; i <= 1010; i++) HotKey.UnregisterHotKey(this.Handle, i);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://research.ke.com/121/ArticleDetail?id=473");
            linkLabel1.LinkVisited = true;
        }

        #endregion

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 1001: // play
                            if (this.WindowState == FormWindowState.Normal) vp.Play();
                            break;
                        case 1002: // pause
                            if (this.WindowState == FormWindowState.Normal) vp.Pause();
                            break;
                        case 1003: // stop
                            if (this.WindowState == FormWindowState.Normal) vp.Stop();
                            break;
                        case 1004: // load file with opendialog
                            if (this.WindowState == FormWindowState.Normal)
                            {
                                OpenFileDialog dlg = new OpenFileDialog();
                                dlg.Filter = "Video Files (*.mp4;*.mkv;*.avi;*.flv;*.webm;*.rmvb)|*.mp4;*.mkv;*.avi;*.flv;*.webm;*.rmvb|All Files (*.*)|*.*";
                                if (dlg.ShowDialog() == DialogResult.OK)
                                {
                                    vp.LoadFile(dlg.FileName);
                                }

                            }
                            break;
                        case 1005: // volume up
                            if (this.WindowState == FormWindowState.Normal) vp.SetVolume(vp.GetVolume() + 1);
                            break;
                        case 1006: // volume down
                            if (this.WindowState == FormWindowState.Normal) vp.SetVolume(vp.GetVolume() - 1);
                            break;
                        case 1007: // fast forward
                            if (this.WindowState == FormWindowState.Normal)
                            {
                                double delta = vp.Duration() / 50.0 * 1.0;
                                if (vp.GetPlayTime() + delta <= vp.Duration())
                                {
                                    vp.SetPlayTime(vp.GetPlayTime() + delta);
                                }
                                else
                                {
                                    vp.Stop();
                                }
                            }
                            break;
                        case 1008: // fast backward
                            if (this.WindowState == FormWindowState.Normal)
                            {
                                double delta2 = vp.Duration() / 50.0 * 1.0;
                                if (vp.GetPlayTime() - delta2 >= 0)
                                {
                                    vp.SetPlayTime(vp.GetPlayTime() - delta2);
                                }
                                else
                                {
                                    vp.SetPlayTime(0);
                                }
                            }
                            break;
                        case 1009: // boss key: hide window and minimize it
                            if (this.WindowState == FormWindowState.Normal)
                            {
                                vp.Pause();
                                this.WindowState = FormWindowState.Minimized;
                            }
                            break;
                        case 1010: // your boss has just left and you can enjoy yourself :) 
                            if (this.WindowState == FormWindowState.Minimized)
                            {
                                this.WindowState = FormWindowState.Normal;
                                vp.Play();
                            }
                            break;
                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);
        }

        private void layeredButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
