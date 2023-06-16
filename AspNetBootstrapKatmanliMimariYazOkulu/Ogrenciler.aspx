<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Ogrenciler.aspx.cs" Inherits="OgrenciListe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="Form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col">
                    <asp:Panel CssClass="headerpanel" runat="server">
                        <h2>ÖĞRENCİ EKLE</h2>
                    <p>Tüm bilgileri eksiksiz ve doğru girdiğinizden emin olun.</p>
                    <table class="table table-bordered" style="column-fill: auto; width: 100%;">
                        <thead>
                            <tr>
                                <th>Ad</th>
                                <th>Soyad</th>
                                <th>Numara</th>
                                <th>Şifre</th>
                                <th>Fotoğraf</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
                                    <asp:TextBox ID="txtad" runat="server" Width="125px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtsoyad" runat="server" Width="125px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtogrno" runat="server" Width="125px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtsifre" runat="server" Width="125px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:FileUpload ID="FileUpload1" runat="server" Width="193px" />
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <div>
                        <asp:Button ID="Button1" OnClick="Button1_Click1" CssClass="btn btn-danger" Style="border-style: solid; border-width: 1px; border-radius: 10px; height: 40px; width: 200px; font-size: 15px;" runat="server" Text="Öğrenci Ekle" />
                    </div>
                </div>
                </asp:Panel>
                <div class="col">
                    <h2>Öğrenci Listesi</h2>
                    <table class="table table-bordered table-hover">
                        <tr>
                            <th>Öğrenci ID</th>
                            <th>Adı</th>
                            <th>Soyadı</th>
                            <th>Numara</th>
                            <th>Şifre</th>
                            <th>Bakiye</th>
                            <th>Fotoğraf</th>
                            <th>İşlemler</th>
                        </tr>
                        <tbody>
                            <asp:Repeater ID="Repeater1" runat="server">
                                <itemtemplate>
                                    <tr>
                                        <td><%# Eval("OGRID") %></td>
                                        <td><%# Eval("OGRAD") %></td>
                                        <td><%# Eval("OGRSOYAD") %></td>
                                        <td><%# Eval("OGRNO") %></td>
                                        <td><%# Eval("OGRSIFRE") %></td>
                                        <td><%# Eval("OGRBAKIYE") %></td>
                                        <td>
                                            <asp:Image ID="Image1" Height="100px" Width="90px" ImageUrl='<%# Eval("OGRFOTO") %>' runat="server" />
                                        </td>
                                        <td>
                                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "~/OgrenciSil.aspx?OGRID="+Eval("OGRID") %>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                                            <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"~/OgrenciGuncelle.aspx?OGRID="+Eval("OGRID") %>' CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
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
