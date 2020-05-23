/* Student Name: Varun Dua
 * Student ID: 19230587
 * Date: 23/09/2019
 * Assignment: 1
 * Assignment: Write a program that allows a user to input their name 
 * and student number, when the display button is clicked a message 
 * of your own choosing is displayed which includes the users name in a label. 
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class WelcomePage : System.Windows.Forms.Form
    {
        int count = 0;   //Counter for the number of clicks on the image.
        public WelcomePage()
        {
            InitializeComponent();
            NameBox.Select();   //Set focus on the Name text box
        }

        /*Event handler to display Welcome Home page once the application is loaded. Access keys
         * are used for Display, Clear and Exit buttons. Clear button is disabled and Image and certain other
         * elements are made not visible.*/
        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            DisplayButton.Text = "&Display";
            ClearButton.Text = "&Clear";
            ExitButton.Text = "E&xit";
            ClearButton.Enabled = false;
            ImageBox.Visible = false;
            MessageLabel.Visible = false;
            IdLabel.Visible = false;
            ColorBox.Visible = false;
            PicLabel.Visible = false;
        }

        /*Welcome Panel background color is set to White. Panel contains Labels for Name, Student number
         * and text boxes for the same, along with Display button.*/
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            WelcomePanel.BackColor = Color.White;
        }

        /*Event handler for Exit button*/
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Event handler to change the image and label in the Picture box on a click. It uses the counter (count)
         * initilaized above to keep track of the number of clicks on the image, 
         * and thus change the image and label accordingly.*/
        private void ImageBox_Click(object sender, EventArgs e)
        {
          //  Assignment1.Properties.Resources.Im1;
            Image def = Image.FromFile(@"D:\Business Application Programming\Class programs\Assignment1\Assignment1\Resources\Im1.jpg");
            Image chg = Image.FromFile(@"D:\Business Application Programming\Class programs\Assignment1\Assignment1\Resources\Im2.jpg");
            String LabelDef = "Click Me!";
            String LabelChg = "Howya!";
            
            if (count == 0)
            {
                ImageBox.Image = chg;
                PicLabel.Text = LabelChg;
                count++;
            }
            else if(count%2!=0)
            {
                ImageBox.Image = def;
                PicLabel.Text = LabelDef;
                count++;
            }
            else
            {
                ImageBox.Image = chg;
                PicLabel.Text = LabelChg;
                count++;
            }
           
        }

      
        /*Event handler to Display Image, Message labels and Radio buttons on click of Display button*/
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            WelcomePanel.Visible = false;
            ImageBox.Visible = true;
            MessageLabel.Visible = true;
            IdLabel.Visible = true;
            ColorBox.Visible = true;
            PicLabel.Visible = true;
            ClearButton.Enabled = true;
            String StdName = NameBox.Text.ToString();
            String StdNum = StudentIdBox.Text.ToString();
            MessageLabel.Text = "Welcome " + StdName + " to MS806.\nHave a nice day.";
            IdLabel.Text = "[" + StdNum + "]";
            WelcomePage.ActiveForm.Text = "Welcome " + StdName;
        }
        /*Pink button Event handler*/
        private void PinkButton_CheckedChanged(object sender, EventArgs e)
        {
            MessageLabel.ForeColor = Color.Pink;
            IdLabel.ForeColor = Color.Pink;
            PicLabel.ForeColor = Color.Pink;
        }
        /*Royal Blue button Event handler*/
        private void RoyalBlueButton_CheckedChanged(object sender, EventArgs e)
        {
            MessageLabel.ForeColor = Color.RoyalBlue;
            IdLabel.ForeColor = Color.RoyalBlue;
            PicLabel.ForeColor = Color.RoyalBlue;
        }
        /*Chocolate button Event handler*/
        private void ChocolateButton_CheckedChanged(object sender, EventArgs e)
        {
            MessageLabel.ForeColor = Color.Chocolate;
            IdLabel.ForeColor = Color.Chocolate;
            PicLabel.ForeColor = Color.Chocolate;
        }
        /*Green button Event handler*/
        private void GreenButton_CheckedChanged(object sender, EventArgs e)
        {
            MessageLabel.ForeColor = Color.Green;
            IdLabel.ForeColor = Color.Green;
            PicLabel.ForeColor = Color.Green;
        }
        /*Event handler to Clear Image, Message labels and Radio buttons, and display the welcome page
         * on click of Clear button*/
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ChocolateButton.Checked = false;
            PinkButton.Checked = false;
            RoyalBlueButton.Checked = false;
            GreenButton.Checked = false;
            ClearButton.Enabled = false;
            ImageBox.Visible = false;
            MessageLabel.Visible = false;
            IdLabel.Visible = false;
            ColorBox.Visible = false;
            PicLabel.Visible = false;
            WelcomePanel.Visible = true;
            MessageLabel.ForeColor = Color.Black;
            IdLabel.ForeColor = Color.Black;
            PicLabel.ForeColor = Color.Black;
            NameBox.Text = null;
            StudentIdBox.Text = null;
            WelcomePage.ActiveForm.Text = "Welcome";
            ImageBox.Image = Image.FromFile(@"D:\Business Application Programming\Class programs\Assignment1\Assignment1\Resources\Im1.jpg"); 
            PicLabel.Text = "Click Me!";            //Change the image back to original image
            count = 0;
            NameBox.Select();                 //Set focus on the Name text box
        }

       
    }
}
