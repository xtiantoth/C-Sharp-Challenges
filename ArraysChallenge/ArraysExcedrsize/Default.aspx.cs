using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArraysExcedrsize
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void changeButton_Click(object sender, EventArgs e)
        {
            string[] myArray = new string[5];
            if (TextBox1.Text == string.Empty || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "")
            {
                resultLabel.Text = "You failed to enter text into one (or more) of the five boxes.";
            }

            else
            {
                myArray[0] = TextBox1.Text;
                myArray[1] = TextBox2.Text;
                myArray[2] = TextBox3.Text;
                myArray[3] = TextBox4.Text;
                myArray[4] = TextBox5.Text;
                resultLabel.Text = string.Format("Box1 ={0}<br /> Box2 ={1}<br /> Box3 ={2}<br /> Box4 ={3}<br /> Box5 ={4}<br />",myArray[0],myArray[1], myArray[2], myArray[3],myArray[4]);
            }
        }
    }
}