<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtUserName = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtPassword = New MaterialSkin.Controls.MaterialTextBox()
        Me.btnLogin = New MaterialSkin.Controls.MaterialButton()
        Me.btnExit = New MaterialSkin.Controls.MaterialButton()
        Me.swPassword = New MaterialSkin.Controls.MaterialSwitch()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(176, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(153, 174)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(158, 19)
        Me.MaterialLabel1.TabIndex = 1
        Me.MaterialLabel1.Text = "Login to Your Account"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Button
        Me.MaterialLabel2.Location = New System.Drawing.Point(102, 202)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(74, 17)
        Me.MaterialLabel2.TabIndex = 2
        Me.MaterialLabel2.Text = "USERNAME"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Button
        Me.MaterialLabel3.Location = New System.Drawing.Point(102, 287)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(75, 17)
        Me.MaterialLabel3.TabIndex = 3
        Me.MaterialLabel3.Text = "PASSWORD"
        '
        'txtUserName
        '
        Me.txtUserName.AnimateReadOnly = False
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserName.Depth = 0
        Me.txtUserName.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtUserName.LeadingIcon = Nothing
        Me.txtUserName.Location = New System.Drawing.Point(105, 224)
        Me.txtUserName.MaxLength = 50
        Me.txtUserName.MouseState = MaterialSkin.MouseState.OUT
        Me.txtUserName.Multiline = False
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(242, 50)
        Me.txtUserName.TabIndex = 0
        Me.txtUserName.Text = ""
        Me.txtUserName.TrailingIcon = Nothing
        '
        'txtPassword
        '
        Me.txtPassword.AnimateReadOnly = False
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Depth = 0
        Me.txtPassword.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtPassword.LeadingIcon = Nothing
        Me.txtPassword.Location = New System.Drawing.Point(105, 309)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.MouseState = MaterialSkin.MouseState.OUT
        Me.txtPassword.Multiline = False
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Password = True
        Me.txtPassword.Size = New System.Drawing.Size(242, 50)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.Text = ""
        Me.txtPassword.TrailingIcon = Nothing
        '
        'btnLogin
        '
        Me.btnLogin.AutoSize = False
        Me.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnLogin.Depth = 0
        Me.btnLogin.HighEmphasis = True
        Me.btnLogin.Icon = Nothing
        Me.btnLogin.Location = New System.Drawing.Point(105, 402)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnLogin.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnLogin.Size = New System.Drawing.Size(242, 36)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnLogin.UseAccentColor = False
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = False
        Me.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnExit.Depth = 0
        Me.btnExit.HighEmphasis = True
        Me.btnExit.Icon = Nothing
        Me.btnExit.Location = New System.Drawing.Point(105, 450)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnExit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnExit.Size = New System.Drawing.Size(242, 36)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnExit.UseAccentColor = False
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'swPassword
        '
        Me.swPassword.AutoSize = True
        Me.swPassword.Depth = 0
        Me.swPassword.Location = New System.Drawing.Point(105, 359)
        Me.swPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.swPassword.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.swPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.swPassword.Name = "swPassword"
        Me.swPassword.Ripple = True
        Me.swPassword.Size = New System.Drawing.Size(171, 37)
        Me.swPassword.TabIndex = 2
        Me.swPassword.Text = "Show password"
        Me.swPassword.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 503)
        Me.Controls.Add(Me.swPassword)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MaterialSkin 2 Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtUserName As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtPassword As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents btnLogin As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnExit As MaterialSkin.Controls.MaterialButton
    Friend WithEvents swPassword As MaterialSkin.Controls.MaterialSwitch
End Class
