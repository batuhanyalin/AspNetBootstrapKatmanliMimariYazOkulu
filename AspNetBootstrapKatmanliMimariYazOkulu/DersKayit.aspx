<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DersKayit.aspx.cs" Inherits="DersKayit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="Form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col">
                    <asp:Panel ID="Panel1" CssClass="headerpanel" runat="server">
                        <h2 class="headerpanelbaslikguncelle" >DERS KAYIT EKRANI
                        </h2>
                        <table class="table table-bordered" style="column-fill: auto">
                            <tr>
                                <th>Öğrenci</th>
                                <td>
                                    <asp:DropDownList ID="DropDownList1" runat="server" Width="189px"></asp:DropDownList>
                            </tr>
                            <tr>
                                <th>Ders</th>
                                <td>
                                    <asp:DropDownList ID="DropDownList2" runat="server" Width="190px"></asp:DropDownList>
                                </td>
                            </tr>
                        </table>
                        <div>
                            <asp:Button ID="btnkayit" CssClass="btn btn-primary" runat="server" Text="Ders Kayıt Oluştur" OnClick="btnkayit_Click" />
                        </div>
                    </asp:Panel>
                </div>
                <div class="col">
                    <h2>Başvuru Listesi</h2>
                    <table class="table table-bordered table-hover">
                        <tr>
                            <th>Başvuru ID</th>
                            <th>Öğrenci</th>
                            <th>Ders</th>
                        </tr>
                        <tbody>
                            <asp:Repeater ID="Repeater1" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Eval("BASVURUID") %></td>
                                        <td><%# Eval("OGRENCIAD") %></td>
                                        <td><%# Eval("DERSAD") %></td>
                                        <td>
                                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"~/DersKayitSil.aspx?DERSID="+Eval("BASVURUID") %>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                                            <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"~/DersKayitGuncelle.aspx?DERSID="+Eval("BASVURUID") %>' CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>

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

