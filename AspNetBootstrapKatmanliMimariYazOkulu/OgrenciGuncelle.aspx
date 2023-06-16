<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciGuncelle.aspx.cs" Inherits="OgrenciGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="Form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col">
                    <asp:Panel ID="Panel1" CssClass="headerpanel" runat="server">
                        <asp:Label ID="Label1" CssClass="headerpanelbaslikguncelle" runat="server" Text="ÖĞRENCİ BİLGİLERİNİ GÜNCELLE"></asp:Label>
                        <div style="padding-left: 10px">
                            <asp:Image ID="Image1" runat="server" Height="109px" Width="102px" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="lbladsoyad" CssClass="listedetaybaslik" runat="server" Text="Label"></asp:Label>
                        </div>

                        <table class="table table-bordered" style="column-fill: auto">
                            <tr>
                                <th>ID</th>
                                <td>
                                    <asp:TextBox ID="txtid" runat="server"></asp:TextBox></td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <th>Ad</th>
                                <td>
                                    <asp:TextBox ID="txtad" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>Soyad</th>
                                <td>
                                    <asp:TextBox ID="txtsoyad" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>Numara</th>
                                <td>
                                    <asp:TextBox ID="txtogrno" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>Şifre</th>
                                <td>
                                    <asp:TextBox ID="txtsifre" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>Bakiye</th>
                                <td>
                                    <asp:TextBox ID="txtbakiye" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>Fotoğraf</th>

                                <td>
                                    <asp:FileUpload ID="FileUpload1" runat="server" />
                                </td>
                            </tr>
                        </table>

                        <div>
                            <asp:Button ID="btnguncelle" CssClass="btn btn-primary" runat="server" Text="Güncelle" OnClick="btnguncelle_Click" />
                        </div>
                    </asp:Panel>
                </div>
            </div>
        </div>
    </form>
</asp:Content>

