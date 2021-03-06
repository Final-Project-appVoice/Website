﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="NewExercise.aspx.cs" Inherits="AppVoice.NewExercise" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2><span class="glyphicon glyphicon-edit"></span>&nbsp הוספת תרגיל</h2>

        <div class="col-md-6 col-md-offset-6">
            <ul class="list-unstyled form-group">
                <li class="row">

                    <span class="glyphicon glyphicon-info-sign"></span>&nbsp *כותרת תרגיל                
                                <asp:TextBox CssClass="form-control" ID="TitleExerciseTextBox" runat="server"></asp:TextBox>
                    <div class="col-md-4">
                        <asp:Label class="errorMessage top-buffer" ID="TitleExerciseLabelError" CssClass="errorMessage" runat="server" Text="יש למלא שדה זה!"></asp:Label>
                    </div>
                </li>

                <li class="row top-buffer">

                    <span class="glyphicon glyphicon-user"></span>&nbsp *סוג תרגיל                
                        <asp:DropDownList CssClass="form-control" runat="server" ID="DropDownListFolder"></asp:DropDownList>
                    <asp:TextBox CssClass="form-control" ID="TextBoxFolder" runat="server" Enabled="false"></asp:TextBox>

                </li>

                <li class="row top-buffer">
                    <span class="glyphicon glyphicon-pencil"></span>&nbsp תיאור התרגיל   
                        <asp:TextBox CssClass="input-group-lg form-control" TextMode="MultiLine" Height="150px" ID="DescriptionTextBox" runat="server"></asp:TextBox>
                </li>

                <li class="row top-buffer">

                    <span class="glyphicon glyphicon-link"></span>&nbsp הוספת לינק                 
                    <asp:TextBox CssClass="input-group-lg form-control" ID="LinkTextBox" runat="server"></asp:TextBox>      
                </li>

                <li class="row top-buffer">

                    <span class="glyphicon glyphicon-picture"></span>&nbsp הוספת תמונה                 
                        <asp:FileUpload ID="PictureUpload" CssClass="top-buffer" runat="server" Height="25px" />
                    <asp:Label runat="server" ID="ImageNameLabel"></asp:Label>
                </li>

                <li class="row top-buffer">

                    <span class="glyphicon glyphicon-file"></span>&nbsp הוספת קובץ                 
                        <asp:FileUpload ID="FileUpload" CssClass="top-buffer" runat="server" Height="25px" />
                    <asp:Label runat="server" ID="FileNameLabel"></asp:Label>
                </li>

                <li class="row top-buffer">

                    <span class="glyphicon glyphicon-facetime-video"></span>&nbsp הקלטת וידאו?                 
                        <asp:CheckBox runat="server" ID="VideoCheckBox" />

                </li>
                <li class="row top-buffer text-center">
                    <asp:Button class="btn btn-success" ID="RegButton" runat="server" OnClick="OnSaveButton_Click" Text="הוסף תרגיל" />
                </li>


            </ul>
        </div>
    </div>

</asp:Content>
