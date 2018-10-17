using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWebClient
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HelloService.HelloServiceClient client = new HelloService.HelloServiceClient("BasicHttpBinding_IHelloService");
            Label2.Text = "<span style=\"color: red; font - weight:bold\"\"> Result Via HTTP:</span><br/>";
            Label3.Text = client.SayHello(TextBox1.Text);
            Label4.Text = client.TodayProgram(TextBox1.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HelloService.HelloServiceClient client = new HelloService.HelloServiceClient("NetTcpBinding_IHelloService");
            Label2.Text = string.Empty; Label3.Text = string.Empty;Label4.Text = string.Empty;
            Label2.Text = "<span style=\"color: red; font - weight:bold\"\"> Result Via TCP:</span><br/>";
            Label3.Text = client.SayHello(TextBox1.Text);
            Label4.Text = client.TodayProgram(TextBox1.Text);
        }
    }
}