using NAudio.Wave;
using NAudio;
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
    public partial class Form1 : Form
    {
        IWavePlayer waveOutDevice;
        AudioFileReader audioFileReader = new AudioFileReader(System.Environment.CurrentDirectory + "\\Resources\\digital-root.wav");
        private Point lastLocation;
        private bool mouseDown;
        private bool status = false;
        private bool chk1 = false;
        private bool chk2 = false;
        private bool chk3 = false;
        private bool chk4 = false;
        private int number1 = 0;
        private int number2 = 0;
        private int number3 = 0;
        private int number4 = 0;
        private int pass = 0;
        private int hit = 0;
        private int turn = 0;
        private int time = 60;

        public Form1()
        {
            InitializeComponent();
            assignFonts();
        }
        public Form1(IWavePlayer player, int x, int y)
        {
            
            InitializeComponent();
            Location = new Point(x, y);    
            waveOutDevice = player;
            assignFonts();
        } 
        
        //Calculation
        private bool numberCheck(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void number2Correction()
        {
            while (true)
            {
                if (numberCheck(number1, number2))
                {
                    number2 = RandomNumber.Between(0, 9);
                }
                else
                {
                    break;
                }
            }
        }
        private void number3Correction()
        {
            while (true)
            {
                if (numberCheck(number1, number3) || numberCheck(number2, number3))
                    {
                        number3 = RandomNumber.Between(0, 9);
                }
                    else
                    {
                        break;
                    }
            }
        }
        private void number4Correction()
        {
            while (true)
            {
                if (numberCheck(number1, number4) || numberCheck(number2, number4) || numberCheck(number3, number4))
                {
                    number4 = RandomNumber.Between(0, 9);
                }
                else
                {
                    break;
                }
            }
        }
        private void scoreCheck()
        {
            hit = 0;
            pass = 0;
            //hits
            if (number1 == int.Parse(num1.Text))
            {
                hit += 1;
                num1.ForeColor = Color.Green;
                chk1 = true;
            }
            else
                num1.ForeColor = Color.DarkRed;
            if (number2 == int.Parse(num2.Text))
            {
                hit += 1;
                num2.ForeColor = Color.Green;
                chk2 = true;
            } 
            else
                num2.ForeColor = Color.DarkRed;
            if (number3 == int.Parse(num3.Text))
            { 
                hit += 1;
                num3.ForeColor = Color.Green;
                chk3 = true;
            }
            else
                num3.ForeColor = Color.DarkRed;
            if (number4 == int.Parse(num4.Text))
            {
                hit += 1;
                num4.ForeColor = Color.Green;
                chk4 = true;
            }
            else
                num4.ForeColor = Color.DarkRed;

            //passes
            if ((number1 == int.Parse(num2.Text) || number1 == int.Parse(num3.Text) || number1 == int.Parse(num4.Text)) && chk1 == false)
                pass += 1; 
            if ((number2 == int.Parse(num1.Text) || number2 == int.Parse(num3.Text) || number2 == int.Parse(num4.Text)) && chk2 == false)
                pass += 1; 
            if ((number3 == int.Parse(num1.Text) || number3 == int.Parse(num2.Text) || number3 == int.Parse(num4.Text)) && chk3 == false)
                pass += 1; 
            if ((number4 == int.Parse(num1.Text) || number4 == int.Parse(num2.Text) || number4 == int.Parse(num3.Text)) && chk4 == false)
                pass += 1; 


            hitnum.Text = "Hits: "+hit.ToString();
            passnum.Text = "Passes: "+pass.ToString();
            turnnum.Text = "Turn: " +turn.ToString();
            turn += 1;
        }
        private void numberRecenter(Control control)
        {
            if (control.Text.Equals("1"))
            {
                if (!(control.Left == 319) || !(control.Left == 428) || !(control.Left == 538) || !(control.Left == 648))
                {
                    control.Left += 14;
                }

            }
            else
            {
                if (!(control.Left == 305) && !(control.Left == 414) && !(control.Left == 524) && !(control.Left == 634))
                {
                    control.Left -= 14;
                }

            }
        }
        //Visiblity
        private void visiblityEnable()
        {
            up1.Visible = true;
            up2.Visible = true;
            up3.Visible = true;
            up4.Visible = true;
            down1.Visible = true;
            down2.Visible = true;
            down3.Visible = true;
            down4.Visible = true;
            num4.Visible = true;
            num3.Visible = true;
            num1.Visible = true;
            num2.Visible = true;
            hitnum.Visible = true;
            passnum.Visible = true;
            turnnum.Visible = true;
            timeTxt.Visible = true;
        }
        //Load and assign font
        private void assignFonts()
        {
            FontLoader.loadFont();
            FontLoader.assignFont( up1, 35);
            FontLoader.assignFont( up2, 35);
            FontLoader.assignFont( up3, 35);
            FontLoader.assignFont( up4, 35);
            FontLoader.assignFont( down1, 35);
            FontLoader.assignFont( down2, 35);
            FontLoader.assignFont( down3, 35);
            FontLoader.assignFont( down4, 35);
            FontLoader.assignFont( num1, 80);
            FontLoader.assignFont( num2, 80);
            FontLoader.assignFont( num3, 80);
            FontLoader.assignFont( num4, 80);
            FontLoader.assignFont( hitnum, 12);
            FontLoader.assignFont( passnum, 12);
            FontLoader.assignFont( turnnum, 12);
            FontLoader.assignFont( timeTxt, 12);
        }
        //Click handler
      
        private void up1_Click(object sender, EventArgs e)
        {
            if (num1.Text == 9.ToString())
            {
                num1.Text = 0.ToString();
            }
            else
            {
                num1.Text = (int.Parse(num1.Text) + 1).ToString();
                numberRecenter(num1);
            }
        }
        private void down1_Click(object sender, EventArgs e)
        {
            if (num1.Text == 0.ToString())
            {
                num1.Text = 9.ToString();
            }
            else
            {
                num1.Text = (int.Parse(num1.Text) - 1).ToString();
                numberRecenter(num1);
            }
        }
        private void up2_Click(object sender, EventArgs e)
        {
            if (num2.Text == 9.ToString())
            {
                num2.Text = 0.ToString();
            }
            else
            {
                num2.Text = (int.Parse(num2.Text) + 1).ToString();
                numberRecenter(num2);
            }
        }
        private void down2_Click(object sender, EventArgs e)
        {
            if (num2.Text == 0.ToString())
            {
                num2.Text = 9.ToString();
            }
            else
            {
                num2.Text = (int.Parse(num2.Text) - 1).ToString();
                numberRecenter(num2);
            }
        }
        private void up3_Click(object sender, EventArgs e)
        {
            if (num3.Text == 9.ToString())
            {
                num3.Text = 0.ToString();
            }
            else
            {
                num3.Text = (int.Parse(num3.Text) + 1).ToString();
                numberRecenter(num3);
            }
        }
        private void down3_Click(object sender, EventArgs e)
        {
            if (num3.Text == 0.ToString())
            {
                num3.Text = 9.ToString();
            }
            else
            {
                num3.Text = (int.Parse(num3.Text) - 1).ToString();
                numberRecenter(num3);
            }
        }
        private void up4_Click(object sender, EventArgs e)
        {
            if (num4.Text == 9.ToString())
            {
                num4.Text = 0.ToString();
            }
            else
            {
                num4.Text = (int.Parse(num4.Text) + 1).ToString();
                numberRecenter(num4);
            }
        }
        private void down4_Click(object sender, EventArgs e)
        {
            if (num4.Text == 0.ToString())
            {
                num4.Text = 9.ToString();
            }
            else
            {
                num4.Text = (int.Parse(num4.Text) - 1).ToString();
                numberRecenter(num4);
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (status == false)
            {
                time = 60;
                turn = 0;
                pass = 0;
                hit = 0;
                timeTxt.Text = time.ToString() + " seconds left";
                turnnum.Text = "Turn: " + turn.ToString();
                turnnum.ForeColor = Color.DimGray;
                passnum.Text = "Passes: " + pass.ToString();
                hitnum.Text = "Hits: " + hit.ToString();
                number1 = RandomNumber.Between(0, 9);
                number2 = RandomNumber.Between(0, 9);
                number3 = RandomNumber.Between(0, 9);
                number4 = RandomNumber.Between(0, 9);
                number2Correction();
                number3Correction();
                number4Correction();
                start.Text = "Check";
                status = true;
                num1.ForeColor = Color.DimGray;
                num2.ForeColor = Color.DimGray;
                num3.ForeColor = Color.DimGray;
                num4.ForeColor = Color.DimGray;
                visiblityEnable();
                turn += 1;
                waveOutDevice.Stop();
                audioFileReader.Volume = 0.01f;
                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();
                timer1.Enabled = true;
            }
            else
            {
                if (turn == 8)
                    turnnum.ForeColor = Color.DarkRed;
                else if (turn == 10)
                {
                    MessageBox.Show("Failure!");
                    status = false;
                    timer1.Enabled = false;
                }
                scoreCheck();
                if (hit == 4)
                {
                    hitnum.ForeColor = Color.Green;
                    MessageBox.Show("Congratulations!");
                    status = false;
                    timer1.Enabled = false;
                }
                    
            }


        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        //Move handlers
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        //Timer update
        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            timeTxt.Text = time.ToString() + " seconds left";
            if (time == 20)
                timeTxt.ForeColor = Color.DarkRed;
            if (time == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Failure!");
                status = false;
            }
               
        }
        #region Hover
        //Hover handlers
        private void up1_MouseLeave(object sender, EventArgs e)
        {
            up1.ForeColor = Color.DimGray;
        }
        private void up2_MouseLeave(object sender, EventArgs e)
        {
            up2.ForeColor = Color.DimGray;
        }
        private void up3_MouseLeave(object sender, EventArgs e)
        {
            up3.ForeColor = Color.DimGray;
        }
        private void up4_MouseLeave(object sender, EventArgs e)
        {
            up4.ForeColor = Color.DimGray;
        }
        private void down1_MouseLeave(object sender, EventArgs e)
        {
            down1.ForeColor = Color.DimGray;
        }
        private void down2_MouseLeave(object sender, EventArgs e)
        {
            down2.ForeColor = Color.DimGray;
        }
        private void down3_MouseLeave(object sender, EventArgs e)
        {
            down3.ForeColor = Color.DimGray;
        }
        private void down4_MouseLeave(object sender, EventArgs e)
        {
            down4.ForeColor = Color.DimGray;
        }
        private void up1_MouseEnter(object sender, EventArgs e)
        {
            up1.ForeColor = Color.DarkRed;
        }
        private void up2_MouseEnter(object sender, EventArgs e)
        {
            up2.ForeColor = Color.DarkRed;
        }
        private void up3_MouseEnter(object sender, EventArgs e)
        {
            up3.ForeColor = Color.DarkRed;
        }
        private void up4_MouseEnter(object sender, EventArgs e)
        {
            up4.ForeColor = Color.DarkRed;
        }
        private void down1_MouseEnter(object sender, EventArgs e)
        {
            down1.ForeColor = Color.DarkRed;
        }
        private void down2_MouseEnter(object sender, EventArgs e)
        {
            down2.ForeColor = Color.DarkRed;
        }
        private void down3_MouseEnter(object sender, EventArgs e)
        {
            down3.ForeColor = Color.DarkRed;
        }
        private void down4_MouseEnter(object sender, EventArgs e)
        {
            down4.ForeColor = Color.DarkRed;
        }
        #endregion 
    }
}
