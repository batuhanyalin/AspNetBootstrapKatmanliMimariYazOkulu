<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Ogretmenler.aspx.cs" Inherits="OgretmenListele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="Form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col">
                    <asp:Panel CssClass="headerpanel" runat="server">
                        <h2>ÖĞRETMEN EKLE</h2>
                    <p>Tüm bilgileri eksiksiz ve doğru girdiğinizden emin olun.</p>
                    <table class="table table-bordered">
                        <thead>
                            <tr>
                                <th>Ad Soyad</th>
                                <th>Branş</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
                                    <asp:TextBox ID="txtadsoyad" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <div>
                        <asp:Button ID="Button1" CssClass="btn btn-danger" Style="border-style: solid; border-width: 1px; border-radius: 10px; height: 40px; width: 200px; font-size: 15px;" runat="server" Text="Öğretmen Ekle" OnClick="Button1_Click" />
                    </div>
                </div>
                </asp:Panel>
                <div class="col">
                    <h2>Öğretmen Listesi</h2>
                    <table class="table table-bordered table-hover">
                        <tr>
                            <th>Öğretmen ID</th>
                            <th>Öğretmen Adı Soyadı</th>
                            <th>Öğretmen Branşı</th>
                             <th>İşlemler</th>
                        </tr>
                        <tbody>
                            <asp:Repeater ID="Repeater1" runat="server">
                                <itemtemplate>
                                    <tr>
                                        <td><%# Eval("OGRTID") %></td>
                                        <td><%# Eval("OGRTADSOYAD") %></td>
                                        <td><%# Eval("BRANSAD") %></td>
                                        <td>
                                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "~/OgretmenSil.aspx?OGRTID="+Eval("OGRTID") %>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                                            <asp:HyperLink ID="HyperLink2" NavigateUrl='<%# "~/OgretmenGuncelle.aspx?OGRTID="+Eval("OGRTID") %>' CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                                        </td>
                                    </tr>
                                </itemtemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>

                </div>
            </div>
        </div>
    </form>
</asp:Content>



