<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        TxtUsername = New TextBox()
        TxtPass = New TextBox()
        BtnLogin = New Button()
        PicBoxUsername = New PictureBox()
        PicBoxPass = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicBoxUsername, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicBoxPass, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(188, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(181, 152)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' TxtUsername
        ' 
        TxtUsername.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TxtUsername.Location = New Point(188, 184)
        TxtUsername.Multiline = True
        TxtUsername.Name = "TxtUsername"
        TxtUsername.PlaceholderText = "Username"
        TxtUsername.Size = New Size(181, 37)
        TxtUsername.TabIndex = 1
        ' 
        ' TxtPass
        ' 
        TxtPass.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TxtPass.Location = New Point(188, 239)
        TxtPass.Multiline = True
        TxtPass.Name = "TxtPass"
        TxtPass.PlaceholderText = "Password"
        TxtPass.Size = New Size(181, 37)
        TxtPass.TabIndex = 2
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = Color.Maroon
        BtnLogin.FlatStyle = FlatStyle.Popup
        BtnLogin.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnLogin.ForeColor = SystemColors.ButtonHighlight
        BtnLogin.Location = New Point(230, 301)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(93, 52)
        BtnLogin.TabIndex = 3
        BtnLogin.Text = "Log in"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' PicBoxUsername
        ' 
        PicBoxUsername.BackgroundImage = CType(resources.GetObject("PicBoxUsername.BackgroundImage"), Image)
        PicBoxUsername.BackgroundImageLayout = ImageLayout.Zoom
        PicBoxUsername.Location = New Point(132, 184)
        PicBoxUsername.Name = "PicBoxUsername"
        PicBoxUsername.Size = New Size(50, 37)
        PicBoxUsername.TabIndex = 4
        PicBoxUsername.TabStop = False
        ' 
        ' PicBoxPass
        ' 
        PicBoxPass.BackgroundImage = CType(resources.GetObject("PicBoxPass.BackgroundImage"), Image)
        PicBoxPass.BackgroundImageLayout = ImageLayout.Zoom
        PicBoxPass.Location = New Point(132, 239)
        PicBoxPass.Name = "PicBoxPass"
        PicBoxPass.Size = New Size(50, 37)
        PicBoxPass.TabIndex = 5
        PicBoxPass.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(595, 365)
        Controls.Add(PicBoxPass)
        Controls.Add(PicBoxUsername)
        Controls.Add(BtnLogin)
        Controls.Add(TxtPass)
        Controls.Add(TxtUsername)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PicBoxUsername, ComponentModel.ISupportInitialize).EndInit()
        CType(PicBoxPass, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents PicBoxUsername As PictureBox
    Friend WithEvents PicBoxPass As PictureBox

End Class
