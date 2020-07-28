<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <title>Tara Instruments</title> 

    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport"/>
    <!-- Bootstrap 3.3.6 -->
    <link rel="stylesheet" href="../../bootstrap/css/bootstrap.min.css"/>
    <!-- Font Awesome -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.5.0/css/font-awesome.min.css"/>
    <!-- Ionicons -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/ionicons/2.0.1/css/ionicons.min.css"/>
    <!-- Theme style -->
    <link rel="stylesheet" href="../../dist/css/AdminLTE.min.css"/>
    <!-- iCheck -->
    <link rel="stylesheet" href="../../plugins/iCheck/square/blue.css"/>
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
    <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
    <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body class="hold-transition login-page">
    <form id="frm" runat="server">
         <div class="login-box">
             <div class="login-logo">
                <%--    <a href="../../index2.html"><b>Admin</b>LTE</a>--%>
                <asp:Image ID="Image1" Height="100px" Width="300px" ImageUrl="~/images/logo.png" runat="server" />
            </div>
         <div class="login-box-body">
                <p class="login-box-msg">Member Login</p>

                <div class="form-group has-feedback">
                    <%--<input type="email" class="form-control" placeholder="Email">--%>
                    <asp:TextBox ID="txtuname" class="form-control" placeholder="Email" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtuname"
                        Display="Dynamic" ErrorMessage="Please Enter Name" Text="(*) Required" ValidationGroup="login" SetFocusOnError="true" ForeColor="Red"
                        CssClass="validate"></asp:RequiredFieldValidator>
                    <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
                </div>
                <div class="form-group has-feedback">
                    <%--<input type="password" class="form-control" placeholder="Password">--%>
                    <asp:TextBox ID="txtpwd" class="form-control" placeholder="Password" TextMode="Password" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpwd"
                        Display="Dynamic" ErrorMessage="Please password" Text="(*) Required" ValidationGroup="login" SetFocusOnError="true" ForeColor="Red"
                        CssClass="validate"></asp:RequiredFieldValidator>
                    <span class="glyphicon glyphicon-lock form-control-feedback"></span>
                </div>
                <div class="row">
                    <div class="col-xs-8">
                        <div class="checkbox icheck">
                        </div>
                    </div>
                    <!-- /.col -->
                    <div class="col-xs-4">
                        <%--   <button type="submit" class="btn btn-primary btn-block btn-flat">Login</button>--%>
                        <asp:Button ID="btnlogin" class="btn btn-primary btn-block btn-flat" ValidationGroup="login" OnClick="btnlogin_Click" runat="server" Text="Login" />
                    </div>
                    <!-- /.col -->
                </div>


                <!-- /.social-auth-links -->
                <br />
                <u><a href="#">I forgot my password</a></u>
                <u><a href="register.html" style="margin-left: 20px" class="text-center">Register a new membership</a></u>

</div>

                <!-- /.login-box -->
                <!-- jQuery 2.2.3 -->
                <script src="../../plugins/jQuery/jquery-2.2.3.min.js"></script>
                <!-- Bootstrap 3.3.6 -->
                <script src="../../bootstrap/js/bootstrap.min.js"></script>
                <!-- iCheck -->
                <script src="../../plugins/iCheck/icheck.min.js"></script>
                <script>
                    $(function () {
                        $('input').iCheck({
                            checkboxClass: 'icheckbox_square-blue',
                            radioClass: 'iradio_square-blue',
                            increaseArea: '20%' // optional
                        });
                    });
                </script>
  
    </form>
</body>
</html>
