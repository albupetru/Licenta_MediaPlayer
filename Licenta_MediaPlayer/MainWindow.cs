using System;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Globalization;
using System.Threading.Tasks;
using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;
using MediaToolkit.Util;

namespace Licenta_MediaPlayer
{
    public partial class MainWindow : Form
    {
        //bool mouseOnVolumeTrackbar;
        int soundVolume = 100;
        bool muted = false;
        bool paused = false;
        bool userIsPositioningTrackBar = false;
        bool isFullscreen = false;
        bool isRecording = false;
        int recordStartPoint = 0;
        string recordFolder = Application.StartupPath + @"\rec";
        string MRL = "";
        string RecordingFileName = "";
        string currentlyPlayedFilePath = "";
        string lastRecordedFilePath = "";

        public MainWindow()
        {
            InitializeComponent();
            //if (this.myVlcControl != null) { this.myVlcControl.Dispose(); this.myVlcControl = null; }
            //this.myVlcControl = new Vlc.DotNet.Forms.VlcControl();
            myVlcControl.VlcLibDirectoryNeeded += OnVlcControlNeedsLibDirectory;
            myVlcControl.EndInit(); //endinit cere ca folderul sa fie setat pt vlccontrol prealabil
        }

        private void OnVlcControlNeedsLibDirectory(object sender, Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs e)
        {
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            if (currentDirectory == null)
                return;

            // de revenit asupra "problemei" 64 biti
            /*if (AssemblyName.GetAssemblyName(currentAssembly.Location).ProcessorArchitecture == ProcessorArchitecture.X86)
            {*/
            e.VlcLibDirectory = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"lib\x86\")); //new DirectoryInfo(Path.Combine(currentDirectory, @"lib\x86\"));
            /*}
            else
            { e.VlcLibDirectory = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"lib\x64\"));//new DirectoryInfo(Path.Combine(currentDirectory, @"lib\x64\"));
            }*/
        }/**/

        private void playPause()
        {
            if (paused)
            {
                myVlcControl.Pause();
                paused = false;
                button_play.Text = "Pause";
            }
            else
            {
                myVlcControl.Pause();
                paused = true;
                button_play.Text = "Play";
            }
        }
        private void button_play_Click(object sender, EventArgs e)
        {
            playPause();
            trackBarElapsed.Focus();
        }

        private void button_volume_MouseEnter(object sender, EventArgs e)
        {
            /*trackBarVolume.Show();
            mouseOnVolumeTrackbar = true;*/
        }

        private void trackBarVolume_MouseLeave(object sender, EventArgs e)
        {
           /* trackBarVolume.Hide();
            mouseOnVolumeTrackbar = false;*/
        }

        private void button_volume_MouseLeave(object sender, EventArgs e)
        {
            //if(mouseOnVolumeTrackbar)
            //  trackBarVolume.Hide();
        }

        private void button_volume_Click(object sender, EventArgs e)
        {
            if (!muted)
            {
                soundVolume = trackBarVolume.Value;
                trackBarVolume.Value = 0;
                muted = true;
            }
            else
            {
                trackBarVolume.Value = soundVolume;
                muted = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog oDialog = new OpenFileDialog();
            //ofDialog.Filter = ; 
            //ofDialog.InitialDirectory
            if (oDialog.ShowDialog() == DialogResult.OK)
            {
                playMedia(oDialog.FileName);
                MRL = myVlcControl.GetCurrentMedia().Mrl;                
            }
        }

        private void playMedia(string filePath)
        {
            myVlcControl.Play(new FileInfo(filePath));
            currentlyPlayedFilePath = filePath;
            Text = filePath;
            paused = false;
            button_play.Text = "Pause";
            trackBarElapsed.InvokeIfRequired(t => t.Maximum = (int)(myVlcControl.GetCurrentMedia().Duration.TotalSeconds));
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            button_play.Text = "Play";
            myVlcControl.Stop();
        }

        private void OnVlcMediaLengthChanged(object sender, Vlc.DotNet.Core.VlcMediaPlayerLengthChangedEventArgs e)
        {
            label_toElapse.InvokeIfRequired(l => l.Text = new DateTime(new TimeSpan((long)e.NewLength).Ticks).ToString("T"));
            //trackBarElapsed.InvokeIfRequired (t => t.Maximum= (int)(myVlcControl.GetCurrentMedia().Duration.TotalMilliseconds));  // schimbarea aici a dimensiunii seekbarului
                                                                                                                                    // esueaza (probabil ca informatiile fisierului
                                                                                                                                    // sunt incarcate dupa acest punct
        }

        private void OnVlcPositionChanged(object sender, Vlc.DotNet.Core.VlcMediaPlayerPositionChangedEventArgs e)
        {
            if (userIsPositioningTrackBar == false)
            {
                var position = myVlcControl.GetCurrentMedia().Duration.Ticks * e.NewPosition;
                label_elapsed.InvokeIfRequired(l => l.Text = new DateTime((long)position).ToString("T"));
                trackBarElapsed.InvokeIfRequired(t => t.Value = (int)(myVlcControl.Time/1000));
                //trackBarElapsed.InvokeIfRequired(t => t.Value = (int)(myVlcControl.Position*(float)myVlcControl.GetCurrentMedia().Duration.TotalMilliseconds));
                if (isRecording)
                    label_rec_duration.InvokeIfRequired(l => l.Text = (trackBarElapsed.Value - recordStartPoint) / 60 + ":" + (trackBarElapsed.Value - recordStartPoint) % 60);
                    //label_rec_duration.InvokeIfRequired(l => l.Text = new DateTime( (long)((trackBarElapsed.Value - recordStartPoint)*10000000)).ToString("T"));
            }
        }

        private void OnVlcPaused(object sender, Vlc.DotNet.Core.VlcMediaPlayerPausedEventArgs e)
        {

        }

        private void OnVlcStopped(object sender, Vlc.DotNet.Core.VlcMediaPlayerStoppedEventArgs e)
        {
            label_elapsed.Text = "00:00:00";
            label_toElapse.Text = "00:00:00";
        }

        private void OnVlcPlaying(object sender, Vlc.DotNet.Core.VlcMediaPlayerPlayingEventArgs e)
        {
            trackBarElapsed.InvokeIfRequired(t => t.Maximum = (int)(myVlcControl.GetCurrentMedia().Duration.TotalSeconds)); // de fiecare data cand clipul porneste/iese din pauza
                                                                                                                            // as putea folosi o variabila globala...
        }

        private void trackBarVolume_ValueChanged(object sender, EventArgs e)
        {
            myVlcControl.InvokeIfRequired(v => v.Audio.Volume = trackBarVolume.Value);
        }

        private void trackBarElapsed_MouseDown(object sender, MouseEventArgs e)
        {
            // sari la locatia clickuita
            double dblValue = ((double)e.X / (double)trackBarElapsed.Width) * (trackBarElapsed.Maximum - trackBarElapsed.Minimum);
            trackBarElapsed.Value = Convert.ToInt32(dblValue);
            //trackBarElapsed.InvokeIfRequired(t => t.Value = Convert.ToInt32(dblValue));

            userIsPositioningTrackBar = true;
        }

        private void trackBarElapsed_MouseUp(object sender, MouseEventArgs e)
        {
            myVlcControl.InvokeIfRequired(v => v.Time = 1000*Convert.ToInt32(trackBarElapsed.Value, CultureInfo.CurrentCulture));
            myVlcControl.Play();

            userIsPositioningTrackBar = false;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        
        void RecordMedia()
        {
            vlcStop();
            RecordingFileName = "";
            string finalfilename = "";
            //int trackBarMarker = Convert.ToInt32(trackBarElapsed.Value, CultureInfo.CurrentCulture);

            if (this.myVlcControl!= null && !string.IsNullOrEmpty(MRL) && !string.IsNullOrEmpty(recordFolder))
            {
                try
                {

                    if (Directory.Exists(recordFolder))
                    { // video files directory
                        // pot sa folosesc vlcdotnet pt a inregistra streamuri
                        string data = "";
                        try { data = ("-" + label_elapsed.Text + "-" + GetClock()).Replace(':', '-'); } catch { data = ""; }
                        finalfilename = recordFolder + "\\" + "REC" + data + ".mp4";
                        //int trckelsp = trackBarElapsed.Value;
                        int trackBarMarker = Convert.ToInt32(trackBarElapsed.Value, CultureInfo.CurrentCulture); // am salvat poz de playback inainte sa dau record

                        var options = new string[] {@":sout=#duplicate{dst=display,dst=std{access=file,mux=ts,dst='" + finalfilename + @"'}}",
                                                     @":start-time=" + trackBarMarker}; 
                                                                                    // pt formatele (video) nesuportate de VLC salveaza doar audio ex: .mkv
                                                                                    // pt 3gp nu face export audio
                                                                                    // wmv de asemenea nu merge (sau nu ia audio si video poate fi vazut doar pe anumite playere?) 
                        // play & record
                        RecordingFileName = finalfilename;
                        try
                        {
                            if (!this.myVlcControl.IsPlaying)
                            {                               
                                this.myVlcControl.Play(new Uri(MRL), options);
                                //createDelay(1000);                                                             
                            };
                        }
                        catch
                        {
                            vlcStop();
                        }
                    }

                }
                catch { }
            }

            //getMediaDuration();
        }

        void RecordMediaToolkit(int start, int end)
        {
            RecordingFileName = "";
            string finalfilename = "";
            int trackBarMarker = Convert.ToInt32(trackBarElapsed.Value, CultureInfo.CurrentCulture);

            if (this.myVlcControl != null && !string.IsNullOrEmpty(MRL) && !string.IsNullOrEmpty(recordFolder))
            {
                try
                {

                    if (Directory.Exists(recordFolder))
                    { 
                        string data;
                        try { data = ("-" + label_elapsed.Text + "-" + GetClock()).Replace(':', '-'); } catch { data = ""; }
                        finalfilename = recordFolder + "\\" + "REC" + data + Path.GetExtension(currentlyPlayedFilePath);
                        lastRecordedFilePath = finalfilename;

                        var inputFile = new MediaFile { Filename = currentlyPlayedFilePath };
                        var outputFile = new MediaFile { Filename = finalfilename };

                        using (var engine = new Engine())
                        {
                            engine.GetMetadata(inputFile);

                            var options = new ConversionOptions();

                            options.CutMedia(TimeSpan.FromSeconds(start), TimeSpan.FromSeconds(end-start));

                            engine.Convert(inputFile, outputFile, options);
                        }
                    }

                }
                catch { }
            }

        }

        void vlcStop()
        {
            RecordingFileName = "";
            myVlcControl.Stop();
        }

        private void button_record_Click(object sender, EventArgs e)
        {
            //RecordMedia();
            if (myVlcControl.IsPlaying)
                if (isRecording)
                {
                    RecordMediaToolkit(recordStartPoint, Convert.ToInt32(trackBarElapsed.Value, CultureInfo.CurrentCulture));
                    isRecording = false;
                    recordStartPoint = 0;
                    button_play.Enabled = true;
                    button_stop.Enabled = true;
                    button_share.Enabled = true;
                    panelRec.Hide();
                    myVlcControl.Pause();
                    button_play.Text = "Play";
                }
                else
                {
                    recordStartPoint = Convert.ToInt32(trackBarElapsed.Value, CultureInfo.CurrentCulture);
                    isRecording = true;
                    button_play.Enabled = false;
                    button_stop.Enabled = false;
                    button_share.Enabled = false;
                    panelRec.Show();
                }
        }

        string GetClock()
        {
            string ClockInstring = "";
            // Get current time:
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            int sec = DateTime.Now.Second;
            // Format current time into string:
            ClockInstring = (hour < 10) ? "0" + hour.ToString() : hour.ToString();
            ClockInstring += ":" + ((min < 10) ? "0" + min.ToString() : min.ToString());
            ClockInstring += ":" + ((sec < 10) ? "0" + sec.ToString() : sec.ToString());
            return ClockInstring;
        }

        private void shareToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill; // deoarece MouseEvent-urile sunt dezactivate in timp ce Vlccontrol reda media
                                          // folosesc un panou ce acopera tot vlccontrolul si are ca mouse event fullscreen pe 2xclick
            //panel1.BackColor = System.Drawing.Color.Transparent;
            myVlcControl.Controls.Add(panel1);
        }

        private void myVlcControl_Click_1(object sender, EventArgs e)
        {
            
        }

        private void fullscreen()
        {        
            if (isFullscreen)
            {
                this.MaximizeBox = true;
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                isFullscreen = false;
                myVlcControl.Dock = DockStyle.None;
                menuStrip1.Visible = true;
                panelBottom.Visible = true;
                // cod pt redimensionarea corecta a vlccontrolului
                myVlcControl.Width = this.Width - 16; // 16 px pt margini
                myVlcControl.Height = this.Height - 130; // 130 de px ocupati pe verticala de celelalte controale
                myVlcControl.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);
            }
            else
            {
                this.MaximizeBox = false;
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                myVlcControl.Dock = DockStyle.Fill;
                menuStrip1.Visible = false;
                panelBottom.Visible = false;
                isFullscreen = true;
            }
        }


        private void button_fullscreen_Click(object sender, EventArgs e)
        {
            fullscreen();
        }


        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            fullscreen();
        }


        private void MainWindow_DoubleClick(object sender, EventArgs e)
        {
            fullscreen();
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fullscreen();
            else if (e.KeyCode == Keys.Space)
                playPause();
            else if (e.KeyCode == Keys.Escape && isFullscreen)
                fullscreen();
        }

        private void panelTime_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBottom_MouseEnter(object sender, EventArgs e)
        {
            if (isFullscreen) panelBottom.Visible = true;
        }

        private void panelBottom_MouseLeave(object sender, EventArgs e)
        {
            if (isFullscreen) panelBottom.Visible = false;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (isFullscreen)
            {
                panelBottom.Visible = !panelBottom.Visible;
                menuStrip1.Visible = !menuStrip1.Visible;
            }
        }

        private void button_share_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to share the last recorded file?\n(Tip: Choose No to share another clip!)", "Confirmation", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                //...
                if(lastRecordedFilePath!="")
                {
                    shareOnFacebook(lastRecordedFilePath);
                }
                else
                {
                    DialogResult result2 = MessageBox.Show("There were no clips recorded in this session!\nDo you want to pick a previously recorded clip?", "", MessageBoxButtons.YesNo);
                    if(result2 == DialogResult.Yes)
                    {
                        string fn = browseFileToUpload();
                        if (fn!=null)
                            shareOnFacebook(fn);
                    }
                }
            }
            else if (result == DialogResult.No)
            {
                string fn = browseFileToUpload();
                if (fn != null)
                    shareOnFacebook(fn);
            }
            else// cod pt dialogresult.cancel
            {
                //...
            }
        }

        private string browseFileToUpload()
        {
            OpenFileDialog oDialog = new OpenFileDialog();
            //oDialog.Filter = ; 
            oDialog.InitialDirectory = recordFolder;
            oDialog.Title = "Choose a file to share";
            if (oDialog.ShowDialog() == DialogResult.OK)
            {
                return oDialog.FileName;
            }
            return null;
        }

        private void shareOnFacebook(string filePath)
        {
            FacebookBrowserLogin fbl = new FacebookBrowserLogin(filePath);
            fbl.Show();
        }
    }

}
