﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AllFolders.aspx.cs" Inherits="AppVoice.Pages.AllFolders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container top-padding" dir="rtl">
        <h2><span class="glyphicon glyphicon-folder-open"></span>&nbsp התקיות שלי &nbsp &nbsp
          <asp:LinkButton class="btn btn-warning" OnClick="OnAddFolder_Click" runat="server"><span class="glyphicon glyphicon-plus"></span>&nbsp הוסף תקייה</asp:LinkButton></h2>
        <asp:Panel runat="server">
            <div class="row top-padding" dir="rtl">
                <%for (int i = 0; i < numAllFolders; i++)
                  {
                      AppVoice.Folder folder = allFolders.ElementAt(i);
                      string nameFolder = folder.Name;
                      string folderId = folder.Id.ToString();%>


                <div class='col-md-3'>
                    <div class='thumbnail text-center'>
                        <div class='bg-danger'>
                             <div class='col-md-3'>
                                    <a style="color:grey;" class='btn' onclick="return confirm('האם אתה רוצה למחוק תקייה זו?');" href="/Pages/AllFolders.aspx?deletedId=<%=folderId %>"><span class="glyphicon glyphicon-remove"></span></a>
                                </div>
                            <div class='caption'>
                               
                                <div class='h3'>

                                    <%=nameFolder %>
                                </div>
                                <a class='btn btn-danger' href="/Pages/AllExercises.aspx?id=<%=folderId %>&folder=<%=nameFolder %>" role='button'>פתח</a>

                                <!--   <a class='btn btn-danger' href="/Pages/AllExercises.aspx?id=<%=folderId %>&folder=<%=nameFolder %>" role='button'><span class="glyphicon glyphicon-remove"></span></a> -->
                                

                            </div>
                        </div>
                    </div>
                </div>

                <%} %>
                <asp:Panel ID="NewFolderPanel" runat="server">
                    <div class='col-md-3'>
                        <div class='thumbnail text-center'>
                            <div class='bg-warning'>
                                <div class='caption'>
                                    <asp:TextBox ID="NewFolderTextBox" class="form-control" runat="server"></asp:TextBox>

                                    <asp:Button class="btn btn-warning top-buffer" runat="server" OnClick="OnNewFolder_Click" Text="הוסף תקייה" />
                                    <asp:Button type="button" class="btn btn-default top-buffer" ID="CancelButton" OnClick="OnCancel_Click" runat="server" Text="ביטול"></asp:Button>
                                </div>
                            </div>
                        </div>
                    </div>
                </asp:Panel>
            </div>

        </asp:Panel>
    </div>


    <!-- pop up delete folder -->
    <div class="modal fade deleteFolderModal" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-dialog modal-sm">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">האם אתה בטוח?</h4>
                </div>
                <div class="modal-body text-center">
                    <div class="form-group">
                        האם אתה רוצה למחוק תקייה זו? כל התרגילים הנמצאים בתקייה זו יימחקו. 
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Cancel</button>
                        <asp:Button ID="YesButtonPopup" class="btn btn-danger" runat="server" OnClick="YesPopupButton_Click" Text="מחק תקייה זו" />
                    </div>

                </div>



            </div>
        </div>
    </div>
    <script src="/Scripts/deleteScripts.js"></script>
</asp:Content>
