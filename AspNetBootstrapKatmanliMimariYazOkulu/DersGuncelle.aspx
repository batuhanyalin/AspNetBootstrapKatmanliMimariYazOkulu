<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DersGuncelle.aspx.cs" Inherits="DersGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
        <form id="Form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col">
                    <asp:Panel ID="Panel1" CssClass="headerpanel" runat="server">
                        <h2 class="headerpanelbaslikguncelle">DERS BİLGİLERİNİ GÜNCELLE</h2>
                        <p>Tüm bilgileri eksiksiz ve doğru girdiğinizden emin olun.</p>
                                                <table class="table table-bordered" style="column-fill: auto">
                            <tr>
                                <th style="width: 242px">Ders ID</th>
                                <td>
                                    <asp:TextBox ID="txtid" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <th style="width: 242px">Ders Ad</th>
                                <td>
                                    <asp:TextBox ID="txtdersad" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th style="width: 242px">Ders Mimium Kontenjan</th>
                                <td>
                                    <asp:TextBox ID="txtminkont" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <th style="width: 242px">Ders Maksimum Kontenjan</th>
                                <td>
                                    <asp:TextBox ID="txtmaxkont" runat="server"></asp:TextBox>
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

