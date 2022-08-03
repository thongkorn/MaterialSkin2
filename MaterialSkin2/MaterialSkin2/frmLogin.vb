#Region "ABOUT"
' / --------------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: http://www.facebook.com/g2gnet (for Thailand)
' / Facebook: http://www.facebook.com/commonindy (Worldwide)
' / More Info: http://www.g2gsoft.com
' /
' / Purpose: Login form with MaterialSkin 2.
' / Microsoft Visual Basic .NET (2017)
' /
' / This is open source code under @CopyLeft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / --------------------------------------------------------------------------------
#End Region

'// Download packages.
'// https://www.nuget.org/packages/MaterialSkin.2/

Imports MaterialSkin

Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "MaterialSkin 2 - Login System"
        '// Code sample.
        '// https://www.nuget.org/packages/MaterialSkin.2/
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue300, Primary.Blue500, Primary.Blue500, Accent.Blue400, TextShade.WHITE)
    End Sub

    Private Sub swPassword_CheckedChanged(sender As Object, e As EventArgs) Handles swPassword.CheckedChanged
        txtPassword.Focus()
        txtPassword.Password = Not swPassword.Checked
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        MessageBox.Show("OK, You can login to system.", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        GC.SuppressFinalize(Me)
        Application.Exit()
    End Sub

    Private Sub txtUserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUserName.KeyPress
        '// Press ENTER
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True    '// No beep
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        '// Press ENTER
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True    '// No beep
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class
