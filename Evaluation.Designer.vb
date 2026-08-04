<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Evaluation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Evaluation))
        Label1 = New Label()
        Label2 = New Label()
        CmbSubject = New ComboBox()
        CmbInstruc = New ComboBox()
        Label3 = New Label()
        CmbRating = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        TxtComment = New TextBox()
        BtnSubmit = New Button()
        BtnBack = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label1.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(91, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(278, 25)
        Label1.TabIndex = 0
        Label1.Text = "SCHOOL EVALUATION FORM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(26, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 20)
        Label2.TabIndex = 1
        Label2.Text = "Subject:"
        ' 
        ' CmbSubject
        ' 
        CmbSubject.FormattingEnabled = True
        CmbSubject.Location = New Point(122, 136)
        CmbSubject.Name = "CmbSubject"
        CmbSubject.Size = New Size(247, 23)
        CmbSubject.TabIndex = 2
        ' 
        ' CmbInstruc
        ' 
        CmbInstruc.FormattingEnabled = True
        CmbInstruc.Location = New Point(122, 181)
        CmbInstruc.Name = "CmbInstruc"
        CmbInstruc.Size = New Size(247, 23)
        CmbInstruc.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(26, 184)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 20)
        Label3.TabIndex = 3
        Label3.Text = "Instructor:"
        ' 
        ' CmbRating
        ' 
        CmbRating.FormattingEnabled = True
        CmbRating.Location = New Point(122, 229)
        CmbRating.Name = "CmbRating"
        CmbRating.Size = New Size(247, 23)
        CmbRating.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(26, 232)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 20)
        Label4.TabIndex = 5
        Label4.Text = "Rating:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(26, 311)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 20)
        Label5.TabIndex = 7
        Label5.Text = "Comment:"
        ' 
        ' TxtComment
        ' 
        TxtComment.Location = New Point(122, 311)
        TxtComment.Multiline = True
        TxtComment.Name = "TxtComment"
        TxtComment.Size = New Size(247, 85)
        TxtComment.TabIndex = 8
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        BtnSubmit.FlatStyle = FlatStyle.Popup
        BtnSubmit.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnSubmit.ForeColor = Color.White
        BtnSubmit.Location = New Point(101, 431)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(75, 42)
        BtnSubmit.TabIndex = 9
        BtnSubmit.Text = "Submit"
        BtnSubmit.UseVisualStyleBackColor = False
        ' 
        ' BtnBack
        ' 
        BtnBack.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        BtnBack.FlatStyle = FlatStyle.Popup
        BtnBack.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnBack.ForeColor = Color.White
        BtnBack.Location = New Point(240, 431)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(75, 42)
        BtnBack.TabIndex = 10
        BtnBack.Text = "Back"
        BtnBack.UseVisualStyleBackColor = False
        ' 
        ' Evaluation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(465, 498)
        Controls.Add(BtnBack)
        Controls.Add(BtnSubmit)
        Controls.Add(TxtComment)
        Controls.Add(Label5)
        Controls.Add(CmbRating)
        Controls.Add(Label4)
        Controls.Add(CmbInstruc)
        Controls.Add(Label3)
        Controls.Add(CmbSubject)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Evaluation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Evaluation"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbSubject As ComboBox
    Friend WithEvents CmbInstruc As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbRating As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtComment As TextBox
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnBack As Button
End Class
