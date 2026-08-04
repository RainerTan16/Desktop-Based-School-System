<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAQs
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FAQs))
        Label1 = New Label()
        CmbFAQs = New ComboBox()
        TxtAns = New TextBox()
        BtnBack = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label1.Font = New Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(78, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(394, 32)
        Label1.TabIndex = 0
        Label1.Text = "PWU ACADEMIC SUPPORT- FAQs"
        ' 
        ' CmbFAQs
        ' 
        CmbFAQs.BackColor = Color.White
        CmbFAQs.FlatStyle = FlatStyle.Popup
        CmbFAQs.Font = New Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CmbFAQs.ForeColor = Color.Black
        CmbFAQs.FormattingEnabled = True
        CmbFAQs.Location = New Point(78, 127)
        CmbFAQs.Name = "CmbFAQs"
        CmbFAQs.Size = New Size(394, 23)
        CmbFAQs.TabIndex = 1
        ' 
        ' TxtAns
        ' 
        TxtAns.BackColor = Color.White
        TxtAns.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtAns.ForeColor = Color.Black
        TxtAns.Location = New Point(54, 186)
        TxtAns.Multiline = True
        TxtAns.Name = "TxtAns"
        TxtAns.ReadOnly = True
        TxtAns.Size = New Size(443, 157)
        TxtAns.TabIndex = 2
        ' 
        ' BtnBack
        ' 
        BtnBack.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        BtnBack.FlatStyle = FlatStyle.Popup
        BtnBack.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold)
        BtnBack.ForeColor = Color.White
        BtnBack.Location = New Point(232, 394)
        BtnBack.Margin = New Padding(3, 2, 3, 2)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(80, 34)
        BtnBack.TabIndex = 18
        BtnBack.Text = "Back"
        BtnBack.UseVisualStyleBackColor = False
        ' 
        ' FAQs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(551, 458)
        Controls.Add(BtnBack)
        Controls.Add(TxtAns)
        Controls.Add(CmbFAQs)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FAQs"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FAQs"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CmbFAQs As ComboBox
    Friend WithEvents TxtAns As TextBox
    Friend WithEvents BtnBack As Button
End Class
