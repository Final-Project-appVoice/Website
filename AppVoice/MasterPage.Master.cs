﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppVoice
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        public Bl_Therapist bl_therapist;
        public List<Folder> allFolders;
        private string licenseId;
        public int numOfUnreadMessages;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["therapist_name"] != null && Session["therapist_licenseId"] != null)                      // if therapist is connected
            {
                bl_therapist = new Bl_Therapist();
                licenseId = Session["therapist_licenseId"].ToString();
                userNameLogin.NavigateUrl = "/Pages/TherapistAccount.aspx";
                ProjectName.NavigateUrl = "/Pages/AllFolders.aspx";
                allFolders = bl_therapist.getAllFolders(licenseId);
                numOfUnreadMessages = bl_therapist.getNumOfUnreadMessages(licenseId);
                ShowTherapistNav();
            }
            else                                                        // if no therapist is connected
            {
                userNameLogin.NavigateUrl = "/Default.aspx";
                ProjectName.NavigateUrl = "/Default.aspx";
                ShowGuestNav();
            }
        }
        protected void LogoutClick(object sender, EventArgs e)
        {
            if (Session["therapist_name"] != null && Session["therapist_licenseId"] != null)
            {
                Session.Clear();
            }

            Response.Redirect("/Default.aspx");
        }

        private void ShowGuestNav()
        {
            userNameLogin.Text = "כניסה למערכת";
            Activities.Visible = false;
            Folders.Visible = false;
            Messages.Visible = false;
            About.Visible = true;
            SearchPanel.Visible = false;
            LogoutButton.Visible = false;
        }


        private void ShowTherapistNav()
        {
            userNameLogin.Text = "שלום " + Session["therapist_name"];
            Activities.Visible = true;
            Folders.Visible = true;
            Messages.Visible = true;
            if (numOfUnreadMessages > 0)
            {
                LabelNumMessages.Visible = true;
                LabelNumMessages.Text = numOfUnreadMessages + "";
            }
            else
            {
                LabelNumMessages.Visible = false;
            }
            About.Visible = false;
            SearchPanel.Visible = true;
            LogoutButton.Visible = true;

           

        }
            
    }
}