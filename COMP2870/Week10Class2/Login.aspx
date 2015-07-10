<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
                <asp:LoginView ID="LoginView1" runat="server">
                    <AnonymousTemplate>        <asp:Login ID="Login1" runat="server">
        </asp:Login>
        <br />

        <asp:CreateUserWizard ID="CreateUserWizard1" runat="server">
            <WizardSteps>
                <asp:CreateUserWizardStep runat="server" />
                <asp:CompleteWizardStep runat="server" />
            </WizardSteps>
        </asp:CreateUserWizard></AnonymousTemplate>
                    
                    <LoggedInTemplate>You are already logged in <asp:LoginStatus ID="LoginStatus1" runat="server" /></LoggedInTemplate>
        </asp:LoginView>
        

                <br />
        

    </div>

        

    </form>
</body>
</html>
