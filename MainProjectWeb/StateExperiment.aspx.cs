using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MainProjectWeb
{
    public partial class StateExperiment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["Hello"] != null)
                ltrView.Text = ViewState["Hello"].ToString();
           if (Session["Hello"] != null)
                ltrSession.Text = Session["Hello"].ToString();
           if (Application["Hello"] != null)
                ltrApplication.Text = Application["Hello"].ToString();
        }

        protected void bnRun_Click(object sender, EventArgs e)
        {
            ViewState.Add("Hello", "This is ViewState!");
            Session.Add("Hello", "This is SessionState!");
            Application.Add("Hello", "This is ApplicationState!");

        }
        string chat
        {
            get
            {
                if (Session["chat"] == null)
                    return null;
                return Session["chat"].ToString();
            }
            set
            {
                if (Session["chat"] == null)
                    Session.Add("chat", value);
                else
                    Session["chat"] = value;
            }
        }

        protected void bnRefresh_Click(object sender, EventArgs e)
        {
            ltrChat.Text = chat;
        }
        protected void bnSend_Click(object sender, EventArgs e)
        {
            chat += txtChatBox.Text + "<br/>";
            bnRefresh_Click(this, e);
            txtChatBox.Text = "";
        }
    }
}