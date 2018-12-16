using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArraysOddNumbers
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            
        }

        protected void arrayOKbutton_Click(object sender, EventArgs e)
        {
            string text = arrayTextbox.Text;
            
            arrayLabel.Text = String.Format("The array is: {0}", text);
            resultLabel.Text = String.Format("The sum of odd numbers in the array is: {0}", SumOfOddNumbers.AddOddNumbers(text));
        }
    }
}