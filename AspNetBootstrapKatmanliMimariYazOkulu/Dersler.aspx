<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Dersler.aspx.cs" Inherits="Dersler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="Form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col">
                    <asp:Panel CssClass="headerpanel" ID="Panel1" runat="server">
                        <h2>DERS EKLE</h2>
                    <p>Tüm bilgileri eksiksiz ve doğru girdiğinizden emin olun.</p>
                    <table class="table table-bordered" style="column-fill: auto">
                        <thead>
                            <tr>
                                <th>Ders</th>
                                <th>Minimum Kontenjan</th>
                                <th>Maksimum Kontenjan</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
                                    <asp:TextBox ID="txtdersad" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtdersminkont" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtdersmaxkont" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <div>
                        <asp:Button ID="Button1" CssClass="btn btn-danger" Style="border-style: solid; border-width: 1px; border-radius: 10px; height: 40px; width: 200px; font-size: 15px;" runat="server" Text="Ders Ekle" OnClick="Button1_Click" />
                    </div>
                </div>
                </asp:Panel>
                <div class="col">
                    <h2>Ders Listesi</h2>
                    <table class="table table-bordered table-hover">
                        <tr>
                            <th>Ders ID</th>
                            <th>Ders Adı</th>
                            <th>Minimum Kontenjan</th>
                            <th>Maksimum Kontenjan</th>
                            <th>İşlemler</th>
                        </tr>
                        <tbody>
                            <asp:Repeater ID="Repeater1" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Eval("DERSID") %></td>
                                        <td><%# Eval("DERSAD") %></td>
                                        <td><%# Eval("DERSMINKONT") %></td>
                                        <td><%# Eval("DERSMAXKONT") %></td>
                                        <td>
                                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"~/DersSil.aspx?DERSID="+Eval("DERSID") %>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                                            <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"~/DersGuncelle.aspx?DERSID="+Eval("DERSID") %>' CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>

                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
