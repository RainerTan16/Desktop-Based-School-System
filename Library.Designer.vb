<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Library
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Library))
        btnReturn = New Button()
        btnBorrow = New Button()
        listCatalog = New ListBox()
        lblHead = New Label()
        BtnBack = New Button()
        SuspendLayout()
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnReturn.FlatStyle = FlatStyle.Popup
        btnReturn.Font = New Font("Segoe UI Historic", 9.75F, FontStyle.Bold)
        btnReturn.ForeColor = Color.White
        btnReturn.Location = New Point(315, 322)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(92, 38)
        btnReturn.TabIndex = 7
        btnReturn.Text = "RETURN"
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' btnBorrow
        ' 
        btnBorrow.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnBorrow.FlatStyle = FlatStyle.Popup
        btnBorrow.Font = New Font("Segoe UI Historic", 9.75F, FontStyle.Bold)
        btnBorrow.ForeColor = Color.White
        btnBorrow.Location = New Point(202, 322)
        btnBorrow.Name = "btnBorrow"
        btnBorrow.Size = New Size(92, 38)
        btnBorrow.TabIndex = 6
        btnBorrow.Text = "BORROW"
        btnBorrow.UseVisualStyleBackColor = False
        ' 
        ' listCatalog
        ' 
        listCatalog.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        listCatalog.FormattingEnabled = True
        listCatalog.Location = New Point(187, 75)
        listCatalog.Name = "listCatalog"
        listCatalog.Size = New Size(276, 228)
        listCatalog.TabIndex = 5
        ' 
        ' lblHead
        ' 
        lblHead.AutoSize = True
        lblHead.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        lblHead.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHead.ForeColor = Color.White
        lblHead.Location = New Point(202, 33)
        lblHead.Name = "lblHead"
        lblHead.Size = New Size(220, 25)
        lblHead.TabIndex = 4
        lblHead.Text = "PWU LIBRARY SYSTEM"
        ' 
        ' BtnBack
        ' 
        BtnBack.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        BtnBack.FlatStyle = FlatStyle.Popup
        BtnBack.Font = New Font("Segoe UI Historic", 9.75F, FontStyle.Bold)
        BtnBack.ForeColor = Color.White
        BtnBack.Location = New Point(429, 322)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(92, 38)
        BtnBack.TabIndex = 8
        BtnBack.Text = "BACK"
        BtnBack.UseVisualStyleBackColor = False
        ' 
        ' Library
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(650, 393)
        Controls.Add(BtnBack)
        Controls.Add(btnReturn)
        Controls.Add(btnBorrow)
        Controls.Add(listCatalog)
        Controls.Add(lblHead)
        FormBorderStyle = FormBorderStyle.None
        Name = "Library"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Library"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents btnBorrow As Button
    Friend WithEvents listCatalog As ListBox
    Friend WithEvents lblHead As Label
    Friend WithEvents BtnBack As Button
End Class
