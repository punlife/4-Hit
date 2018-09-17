using _4_Hit.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;

namespace _4_Hit
{
    public partial class MainMenu : Form
    {

        IWavePlayer waveOutDevice = new WaveOut();
        AudioFileReader audioFileReader = new AudioFileReader("1-01-virtue-s-last-reward-orchestra-.mp3");
        private PrivateFontCollection fonts = new PrivateFontCollection();
        private Point lastLocation;
        private bool mouseDown;        

        public MainMenu()
        {
            InitializeComponent();

            FontLoader.loadFont();
            FontLoader.assignFont(startButton, 20);
            FontLoader.assignFont(helpButton, 20);
            FontLoader.assignFont(exitButton, 20);
            startButton.Left = 475;
            helpButton.Left = 485;
            exitButton.Left = 485;
            
        }

        private void visiblityEnable()
        {
            helpButton.Visible = true;
            exitButton.Visible = true;
            startButton.Visible = true;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {     
            audioFileReader.Volume = 0.001f;
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
        }

        //Moving the form
        private void MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void MainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void MainMenu_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        //Form Progression
        private void startButton_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1(waveOutDevice, Location.X, Location.Y);
            game.Tag = this;
            game.Show(this);
            Hide();
        }
        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpScreen help = new HelpScreen(waveOutDevice, Location.X, Location.Y);
            help.Tag = this;
            help.Show(this);
            Hide();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Mouse Hover handlers
        private void startButton_MouseLeave(object sender, EventArgs e)
        {
            startButton.ForeColor = Color.DimGray;
        }
        private void helpButton_MouseLeave(object sender, EventArgs e)
        {
            helpButton.ForeColor = Color.DimGray;
        }
        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.ForeColor = Color.DimGray;
        }

        private void startButton_MouseEnter(object sender, EventArgs e)
        {
            startButton.ForeColor = Color.DarkRed;
        }

        private void helpButton_MouseEnter(object sender, EventArgs e)
        {
            helpButton.ForeColor = Color.DarkRed;
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.ForeColor = Color.DarkRed;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            audioFileReader.Volume += 0.0001f;
            if (audioFileReader.Volume == 0.005f)
            {
                timer1.Enabled = false;
            }
        }
    }
}
