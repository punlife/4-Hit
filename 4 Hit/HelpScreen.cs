using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _4_Hit
{
    public partial class HelpScreen : Form
    {
        IWavePlayer waveOutDevice;
        private Point lastLocation;
        private bool mouseDown;

        public HelpScreen()
        {
            InitializeComponent();
            FontLoader.loadFont();
            FontLoader.assignFont(label1, 12);
            FontLoader.assignFont(startButton, 20);
        }
        public HelpScreen(IWavePlayer waveOutDevice, int x, int y)
        {
            InitializeComponent();
            Location = new Point(x, y);
            FontLoader.loadFont();
            FontLoader.assignFont(label1, 12);
            FontLoader.assignFont(startButton, 20);
            this.waveOutDevice = waveOutDevice;
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1(waveOutDevice, Location.X, Location.Y);
            game.Tag = this;
            game.Show(this);
            Hide();
        }
        private void HelpScreen_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void HelpScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void HelpScreen_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }


        private void startButton_MouseLeave(object sender, EventArgs e)
        {
            startButton.ForeColor = Color.DimGray;
        }
        private void startButton_MouseEnter(object sender, EventArgs e)
        {
            startButton.ForeColor = Color.DarkRed;
        }
    }
}
