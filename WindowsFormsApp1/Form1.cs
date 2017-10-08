using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Color activeButtonColor = Color.LightSteelBlue;

        List<Graphics> graphics = new List<Graphics>();

        Button[] buttons = new Button[3];
        Button activeButton;
        public Form1()
        {
            InitializeComponent();
            lineButton.BackColor = activeButtonColor;
            buttons[0] = lineButton;
            buttons[1] = circleButton;
            buttons[2] = rectangleButton;
            activeButton = buttons[0];
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            var panel = sender as Panel;


            
        }



        private void lineBtn_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void shapeButtonClicked(object sender, EventArgs e)
        {
            activeButton = sender as Button;
            disableOtherButtons(activeButton);
            startXtext.Text = "";
            startYtext.Text = "";
            endXtext.Text = "";
            endYtext.Text = "";

            switch (activeButton.Name)
            {
                case "lineButton":
                    endXlabel.Text = "end X";
                    endYlabel.Text = "end Y";
                    endXtext.Enabled = true;
                    endYtext.Enabled = true;
                    break;
                case "circleButton":
                    endXlabel.Text = "radius";
                    endYtext.Enabled = false;
                    break;
                case "rectangleButton":
                    endXlabel.Text = "width";
                    endYlabel.Text = "height";
                    endYtext.Enabled = true;
                    break;
                default:
                    
                    break;
            }
        }

        private void disableOtherButtons(Button sender)
        {
            foreach(var b in buttons) {
                if( b == sender ){
                    b.BackColor = activeButtonColor;
                } else
                {
                    b.BackColor = Color.LightGray;
                }   
            }
        }

        private void canvasMouseMove(object sender, MouseEventArgs e)
        {
            positionX.Text = string.Format("X: {0}", e.Location.X);
            positionY.Text = string.Format("Y: {0}", e.Location.Y);
        }

        private void canvasMouseUp(object sender, MouseEventArgs e)
        {
            if (startXtext.Focused)
            {
                startXtext.Text = string.Format("{0}", e.Location.X);
                startYtext.Text = string.Format("{0}", e.Location.Y);
                startXtext.Enabled = false;
                startXtext.Enabled = true;
                startYtext.Enabled = false;
                startYtext.Enabled = true;

                switch (activeButton.Name)
                {
                    case "circleButton":
                        endXtext.Text = "100";
                        endYtext.Text = "";
                        endXtext.Enabled = false;
                        endXtext.Enabled = true;
                        endYtext.Enabled = false;
                        break;
                    case "rectangleButton":
                        endXtext.Text = "200";
                        endYtext.Text = "100";
                        endXtext.Enabled = false;
                        endXtext.Enabled = true;
                        endYtext.Enabled = false;
                        endYtext.Enabled = true;
                        break;
                    default:
                        break;
                }

            } else if (endXtext.Focused)
            {
                switch (activeButton.Name)
                {
                    case "lineButton":
                        endXtext.Text = string.Format("{0}", e.Location.X);
                        endYtext.Text = string.Format("{0}", e.Location.Y);
                        endXtext.Enabled = false;
                        endXtext.Enabled = true;
                        endYtext.Enabled = false;
                        endYtext.Enabled = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void addShape(object sender, MouseEventArgs e)
        {
            SolidBrush sb = new SolidBrush(Color.Black);
            Graphics g = canvas.CreateGraphics();

            switch (activeButton.Name)
            {
                case "lineButton":
                    // add line
                    var x1 = (float)Convert.ToDouble(startXtext.Text);
                    var y1 = (float)Convert.ToDouble(startYtext.Text);
                    var w1 = (float)Convert.ToDouble(endXtext.Text);
                    var h1 = (float)Convert.ToDouble(endYtext.Text);
                    Pen pen = new Pen(Color.Black);
                    pen.Width = 5;
                    g.DrawLine(pen, x1, y1, w1, h1);
                    break;
                case "circleButton":
                    // add circle
                    var x2 = Convert.ToInt32(startXtext.Text);
                    var y2 = Convert.ToInt32(startYtext.Text);
                    var r2 = Convert.ToInt32(endXtext.Text);
                    x2 = x2 - r2;
                    y2 = y2 - r2;
                    g.FillEllipse(sb, x2, y2, r2*2, r2*2);
                    break;
                case "rectangleButton":
                    // add rectangle  
                    var x3 = (float)Convert.ToDouble(startXtext.Text);
                    var y3 = (float)Convert.ToDouble(startYtext.Text);
                    var w3 = (float)Convert.ToDouble(endXtext.Text);
                    var h3 = (float)Convert.ToDouble(endYtext.Text);
                    g.FillRectangle(sb, x3, y3, w3, h3);
                    break;
                default:
                    break;
            }
        }
    }
}
