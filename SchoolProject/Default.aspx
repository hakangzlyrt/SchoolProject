<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html lang="tr">
<head>
    <title>ASP.NET YAZ OKULU SİSTEMİ PROJE</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta charset="utf-8" />
    <link rel="shortcut icon" type="image/png" href="web/asp-net.png" />
    <!-- CSS dosyaları düzenlendi -->
    <link href="web/css/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="web/css/style.css" rel="stylesheet" type="text/css" />
    <link href="web/css/fontawesome-all.min.css" rel="stylesheet" type="text/css" />
    <!-- Online font düzenlendi -->
    <link href="https://fonts.googleapis.com/css?family=Lato:100,300,400,700,900" rel="stylesheet">
    <!-- JavaScript fonksiyonu düzenlendi -->
    <script>
        window.addEventListener("load", function () {
            setTimeout(hideURLbar, 0);
        }, false);

        function hideURLbar() {
            window.scrollTo(0, 1);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="sidenav text-center">
            <div class="side_top">
                <img src="web/images/about.jpg" alt="news image" class="img-fluid navimg">
                <h1 class="top_hd mt-2"><a href="index.html">DÜZCE ÜNİVERSİTESİ</a></h1>
                <p class="top_hdp mt-2">OBS SİSTEMİ</p>
            </div>
            <!-- header -->
            <header>
                <div class="nav-top">
                    <nav class="mnu mx-auto">
                        <label for="drop" class="toggle">Menu</label>
                        <input type="checkbox" id="drop">
                        <ul class="menu">
                            <li class="active"><a href="#home" class="scroll">ANASAYFA</a></li>
                            <li class="mt-sm-3"><a href="#recourse" class="scroll">DERS BAŞVURU FORMU</a></li>
                            <li class="mt-sm-3"><a href="#contact" class="scroll">İLETİŞİM</a></li>
                            <li class="mt-sm-3"><a href="AdminLogin.aspx" class="scroll">ÇIKIŞ</a></li>
                        </ul>
                    </nav>
                </div>
            </header>
            <!-- //header -->
        </div>

        <div class="main">
            <div class="banner-text-w3ls" id="home">
                <div class="container">
                    <div class="mx-auto text-center">
                        <h3>ASP.NET YAZ OKULU OBS SİSTEMİ</h3>
                        <p class="banp mx-auto mt-3"></p>
                        <a class="btn btn-primary mt-lg-5 mt-3 agile-link-bnr" href="#recourse" role="button">DERS TALEP SAYFASI İÇİN</a>
                    </div>
                </div>
            </div>

            <!-- about -->
            <section class="slide-wrapper" id="recourse">
                <h2 class="w3_head mb-4">DERS TALEP FORMU </h2>
                <div class="contact_grid_right mt-5 mx-auto text-left">
                    
                </div>
            </section>

            <!-- //news -->

            <!-- contact -->
            <section class="wedo" id="contact">
                <h3 class="w3_head mb-4 text-left">İLETİŞİM</h3>
                <div class="contact_grid_right mt-5 mx-auto text-left">
                    <asp:Panel ID="pnlContactForm" runat="server">
                        <div class="row contact_top">
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtNameSurname" runat="server" placeholder="Ad"></asp:TextBox>
                            </div>
                            <div class="col-sm-6">
                                <asp:TextBox ID="txtEmail" runat="server" placeholder="E-Mail"></asp:TextBox>
                            </div>
                        </div>
                        <asp:TextBox ID="txtSubject" runat="server" placeholder="Konu"></asp:TextBox>
                        <asp:TextBox ID="txtMessage" runat="server" placeholder="Mesajınız" TextMode="MultiLine" Height="50"></asp:TextBox>
                        <asp:Button ID="btnSendMessage" runat="server" CssClass="btn btn-primary" Text="Mesajı Gönder" Width="150" OnClick="btnSendMessage_Click" />
                        <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-danger" Text="Vazgeç" Width="150" />
                        <div class="clearfix"></div>
                    </asp:Panel>
                </div>
                <div class="cpy-right text-center">
                    <p>
                        © 2018 Conjoint. All rights reserved | Design by
                        <a href="http://w3layouts.com">W3layouts.</a>
                    </p>
                </div>
            </section>
            <!-- //contact -->
        </div>
        <!-- JavaScript bağlantıları eklendi -->
        <script src="https://code.jquery.com/jquery-3.6.4.min.js"></script>
        <script src="web/js/bootstrap.bundle.min.js"></script>
    </form>
</body>
</html>
