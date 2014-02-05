using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1._1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Beräknar antalet versaler för textbox och presenterar för användaren
        protected void Button_Click(object sender, EventArgs e)
        {
            if (Input.Text != "")
            {
                var caps = Model.TextAnalyzer.GetNumberOfCapitals(Input.Text);
                Output.Text = "Texten innehåller " + caps.ToString() + " versaler.";
                Input.Enabled = false;
                Button.Text = "Rensa";
            }
            else
            {
                Input.Enabled = true;
            }

        }
    }
}