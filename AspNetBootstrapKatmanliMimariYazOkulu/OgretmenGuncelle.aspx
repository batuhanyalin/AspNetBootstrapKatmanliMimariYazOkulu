<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgretmenGuncelle.aspx.cs" Inherits="OgretmenGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
        <form id="Form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col">
                    <asp:Panel ID="Panel1" CssClass="headerpanel" runat="server">
                        <h2 class="headerpanelbaslikguncelle">ÖĞRETMEN BİLGİLERİNİ GÜNCELLE</h2>
                        <p>Tüm bilgileri eksiksiz ve doğru girdiğinizden emin olun.</p>
                                               <table class="table table-bordered" style="column-fill: auto">
                            <tr>
                                <th>ID</th>
                                <td>
                                    <asp:TextBox ID="txtid" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <th>Ad Soyad</th>
                                <td>
                                    <asp:TextBox ID="txtadsoyad" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th>Branş</th>
                                <td>
                                    <asp:DropDownList ID="DropDrownList1" runat="server" Width="187px"></asp:DropDownList>
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

