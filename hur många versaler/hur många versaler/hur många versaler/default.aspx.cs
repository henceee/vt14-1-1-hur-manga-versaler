using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hur_många_versaler
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CapsButton_Click(object sender, EventArgs e)
        {
            if (CapsButton.Text == "Bestäm antal versaler")
            {
                CapsTextBox.Enabled = false;
                CapsButton.Text = "Rensa";

                

            }

            else {

                CapsTextBox.Text = "";
                CapsTextBox.Enabled = true;
                CapsButton.Text = "Bestäm antal versaler";
            
            }
           
        }
    }
}