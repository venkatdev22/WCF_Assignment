using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobWebClient
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            JobService.JobServiceClient client = new JobService.JobServiceClient("BasicHttpBinding_IJobService");

            GridView1.DataSource = null;
            GridView1.DataBind();

            Label2.Text = "<span style=\"color: red; font - weight:bold\"\"> Result Via HTTP:</span><br/>";
            if (string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                var jobOpenings = client.OpeningJobs();
                if (jobOpenings.Count() > 0)
                {
                    GridView1.DataSource = jobOpenings;
                    GridView1.DataBind();
                }
                else
                    Label2.Text += "No Search results found!";
            }
            else
            {
                var jobOpeningsByRole = client.OpeningJobsByRole(TextBox1.Text);
                if (jobOpeningsByRole.Count() > 0)
                {
                    GridView1.DataSource = jobOpeningsByRole;
                    GridView1.DataBind();
                }
                else
                    Label2.Text += "No Search results found!";
            }
        }
    }
}
