using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMS1._0.Management.Entries
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnToggleCalender_Click(object sender, EventArgs e)
        {
            if(calDOB.Visible==false&&ddlYearOfBirth.Visible==false)
            {
                calDOB.Visible = true;
                ddlYearOfBirth.Visible = true;
                btnToggleCalender.Text = "Hide Calender";
            }
            else
            {
                if(calDOB.Visible==true&&ddlYearOfBirth.Visible==true)
                {
                    btnToggleCalender.Text = "Show Calender";
                    calDOB.Visible = false;
                    ddlYearOfBirth.Visible = false;
                }
            }
        }

        protected void calDOB_SelectionChanged(object sender, EventArgs e)
        {
            Calendar cal = new Calendar();
            txtDOB.Text = cal.SelectedDate.ToShortDateString() + ddlYearOfBirth.SelectedValue;
            
        }
    }
}