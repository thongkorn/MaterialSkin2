<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMaterialSkin2
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaterialSkin2))
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MaterialTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialTabControl1.ImageList = Me.ImageList1
        Me.MaterialTabControl1.Location = New System.Drawing.Point(3, 64)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Multiline = True
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.Padding = New System.Drawing.Point(10, 10)
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(593, 528)
        Me.MaterialTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.ImageKey = "icons8_home_50px.png"
        Me.TabPage1.Location = New System.Drawing.Point(4, 53)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(585, 471)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "HOME"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.ImageKey = "icons8_user_50px.png"
        Me.TabPage2.Location = New System.Drawing.Point(4, 53)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(585, 471)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "USERS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8_home_50px.png")
        Me.ImageList1.Images.SetKeyName(1, "icons8_user_50px.png")
        '
        'frmMaterialSkin2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 595)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.DrawerShowIconsWhenHidden = True
        Me.DrawerTabControl = Me.MaterialTabControl1
        Me.Name = "frmMaterialSkin2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MaterialSkin 2"
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ImageList1 As ImageList
End Class
