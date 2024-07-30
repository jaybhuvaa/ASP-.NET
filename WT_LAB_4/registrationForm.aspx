<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrationForm.aspx.cs" Inherits="WT_LAB_4.registrationForm" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            Name:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name cannot be empty" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name cannot contain numbers" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^[a-zA-Z\s]*$"></asp:RegularExpressionValidator>
            <br /><br />
            Mobile No.:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Please enter a valid mobile number" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^[6-9][0-9]{9}$"></asp:RegularExpressionValidator>
            <br /><br />
            Email:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Please enter a valid email" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"></asp:RegularExpressionValidator>
            <br /><br />
            Address:
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br /><br />
            Password:
            <asp:TextBox ID="TextBox5" runat="server" TextMode="Password"></asp:TextBox>
            <asp:HiddenField ID="HiddenFieldPassword" runat="server" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TextBox5" ErrorMessage="Password must be at least 8 characters long, contain at least one uppercase letter and one number" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^(?=.*[A-Z])(?=.*\d).{8,}$"></asp:RegularExpressionValidator>
            <br /><br />
            Confirm Password:
            <asp:TextBox ID="TextBox6" runat="server" TextMode="Password"></asp:TextBox>
            <asp:HiddenField ID="HiddenFieldConfirmPassword" runat="server" />
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TextBox6" ControlToCompare="TextBox5" ErrorMessage="Passwords do not match" ForeColor="Red" SetFocusOnError="True"></asp:CompareValidator>
            <br /><br />
            Country:
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="-1">Select Country</asp:ListItem>
                <asp:ListItem>India</asp:ListItem>
                <asp:ListItem>USA</asp:ListItem>
            </asp:DropDownList>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Please select a country" ForeColor="Red" ClientValidationFunction="validateDropDown"></asp:CustomValidator>
            <br /><br />
            State:
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList>
            <asp:CustomValidator ID="CustomValidator2" runat="server" ControlToValidate="DropDownList2" ErrorMessage="Please select a state" ForeColor="Red" ClientValidationFunction="validateDropDown"></asp:CustomValidator>
            <br /><br />
            City:
            <asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList>
            <asp:CustomValidator ID="CustomValidator3" runat="server" ControlToValidate="DropDownList3" ErrorMessage="Please select a city" ForeColor="Red" ClientValidationFunction="validateDropDown"></asp:CustomValidator>
            <br /><br />
            Certificates:
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem>GRE</asp:ListItem>
                <asp:ListItem>IELTS</asp:ListItem>
                <asp:ListItem>GATE</asp:ListItem>
            </asp:CheckBoxList>
            <asp:Label ID="CheckBoxListValidator" runat="server" ForeColor="Red" Text=""></asp:Label>
            <br /><br />
            Gender:
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
            <br /><br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" OnClientClick="return validateCheckBoxList();" />
            <br /><br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>

    <script type="text/javascript">
        function validateDropDown(sender, args) {
            if (args.Value == "-1") {
                args.IsValid = false;
            } else {
                args.IsValid = true;
            }
        }

        function validateCheckBoxList() {
            var checkBoxList = document.getElementById('<%= CheckBoxList1.ClientID %>');
            var checkboxes = checkBoxList.getElementsByTagName('input');
            var isChecked = false;
            for (var i = 0; i < checkboxes.length; i++) {
                if (checkboxes[i].checked) {
                    isChecked = true;
                    break;
                }
            }
            if (!isChecked) {
                document.getElementById('<%= CheckBoxListValidator.ClientID %>').innerText = "Please select at least one certificate";
            }
            return isChecked;
        }

        // Script to retain password values on postback
        document.getElementById('<%= TextBox5.ClientID %>').value = document.getElementById('<%= HiddenFieldPassword.ClientID %>').value;
        document.getElementById('<%= TextBox6.ClientID %>').value = document.getElementById('<%= HiddenFieldConfirmPassword.ClientID %>').value;

        // Function to set hidden field values before postback
        function setPasswordHiddenFields() {
            document.getElementById('<%= HiddenFieldPassword.ClientID %>').value = document.getElementById('<%= TextBox5.ClientID %>').value;
            document.getElementById('<%= HiddenFieldConfirmPassword.ClientID %>').value = document.getElementById('<%= TextBox6.ClientID %>').value;
        }

        document.getElementById('<%= form1.ClientID %>').onsubmit = setPasswordHiddenFields;
    </script>
</body>
</html>
