<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registration))
        RegistrationForm = New GroupBox()
        TxtAge = New TextBox()
        Label4 = New Label()
        CBCourse = New ComboBox()
        Label3 = New Label()
        CbYear = New ComboBox()
        Label2 = New Label()
        BtnBack = New Button()
        TxtMName = New TextBox()
        Label1 = New Label()
        Clear = New Button()
        Register = New Button()
        EmailTextBox = New TextBox()
        ContactNumberTextBox = New TextBox()
        CBGender = New ComboBox()
        LastNameTextBox = New TextBox()
        FirstNameTextBox = New TextBox()
        Email = New Label()
        ContactNumber = New Label()
        Gender = New Label()
        LastName = New Label()
        FirstName = New Label()
        RegistrationForm.SuspendLayout()
        SuspendLayout()
        ' 
        ' RegistrationForm
        ' 
        RegistrationForm.BackColor = Color.Transparent
        RegistrationForm.Controls.Add(TxtAge)
        RegistrationForm.Controls.Add(Label4)
        RegistrationForm.Controls.Add(CBCourse)
        RegistrationForm.Controls.Add(Label3)
        RegistrationForm.Controls.Add(CbYear)
        RegistrationForm.Controls.Add(Label2)
        RegistrationForm.Controls.Add(BtnBack)
        RegistrationForm.Controls.Add(TxtMName)
        RegistrationForm.Controls.Add(Label1)
        RegistrationForm.Controls.Add(Clear)
        RegistrationForm.Controls.Add(Register)
        RegistrationForm.Controls.Add(EmailTextBox)
        RegistrationForm.Controls.Add(ContactNumberTextBox)
        RegistrationForm.Controls.Add(CBGender)
        RegistrationForm.Controls.Add(LastNameTextBox)
        RegistrationForm.Controls.Add(FirstNameTextBox)
        RegistrationForm.Controls.Add(Email)
        RegistrationForm.Controls.Add(ContactNumber)
        RegistrationForm.Controls.Add(Gender)
        RegistrationForm.Controls.Add(LastName)
        RegistrationForm.Controls.Add(FirstName)
        RegistrationForm.Font = New Font("Segoe UI Historic", 9.75F, FontStyle.Bold)
        RegistrationForm.Location = New Point(22, 11)
        RegistrationForm.Margin = New Padding(3, 2, 3, 2)
        RegistrationForm.Name = "RegistrationForm"
        RegistrationForm.Padding = New Padding(3, 2, 3, 2)
        RegistrationForm.Size = New Size(699, 348)
        RegistrationForm.TabIndex = 1
        RegistrationForm.TabStop = False
        RegistrationForm.Text = "Registration Form"
        ' 
        ' TxtAge
        ' 
        TxtAge.Location = New Point(156, 145)
        TxtAge.Margin = New Padding(3, 2, 3, 2)
        TxtAge.Name = "TxtAge"
        TxtAge.Size = New Size(186, 25)
        TxtAge.TabIndex = 23
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Historic", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(45, 153)
        Label4.Name = "Label4"
        Label4.Size = New Size(38, 17)
        Label4.TabIndex = 22
        Label4.Text = "Age:"
        ' 
        ' CBCourse
        ' 
        CBCourse.DisplayMember = "Male"
        CBCourse.FlatStyle = FlatStyle.Popup
        CBCourse.FormattingEnabled = True
        CBCourse.Items.AddRange(New Object() {"Male", "Female"})
        CBCourse.Location = New Point(156, 264)
        CBCourse.Margin = New Padding(3, 2, 3, 2)
        CBCourse.Name = "CBCourse"
        CBCourse.Size = New Size(101, 25)
        CBCourse.TabIndex = 21
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Historic", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(67, 267)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 17)
        Label3.TabIndex = 20
        Label3.Text = "Course:"
        ' 
        ' CbYear
        ' 
        CbYear.DisplayMember = "Male"
        CbYear.FlatStyle = FlatStyle.Popup
        CbYear.FormattingEnabled = True
        CbYear.Items.AddRange(New Object() {"Male", "Female"})
        CbYear.Location = New Point(156, 225)
        CbYear.Margin = New Padding(3, 2, 3, 2)
        CbYear.Name = "CbYear"
        CbYear.Size = New Size(101, 25)
        CbYear.TabIndex = 19
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Historic", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(67, 228)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 17)
        Label2.TabIndex = 18
        Label2.Text = "Year:"
        ' 
        ' BtnBack
        ' 
        BtnBack.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        BtnBack.FlatStyle = FlatStyle.Popup
        BtnBack.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold)
        BtnBack.ForeColor = Color.White
        BtnBack.Location = New Point(332, 303)
        BtnBack.Margin = New Padding(3, 2, 3, 2)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(80, 34)
        BtnBack.TabIndex = 17
        BtnBack.Text = "Back"
        BtnBack.UseVisualStyleBackColor = False
        ' 
        ' TxtMName
        ' 
        TxtMName.Location = New Point(156, 107)
        TxtMName.Margin = New Padding(3, 2, 3, 2)
        TxtMName.Name = "TxtMName"
        TxtMName.Size = New Size(186, 25)
        TxtMName.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Historic", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(45, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 17)
        Label1.TabIndex = 15
        Label1.Text = "Middle Name:"
        ' 
        ' Clear
        ' 
        Clear.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Clear.FlatStyle = FlatStyle.Popup
        Clear.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold)
        Clear.ForeColor = Color.White
        Clear.Location = New Point(237, 303)
        Clear.Margin = New Padding(3, 2, 3, 2)
        Clear.Name = "Clear"
        Clear.Size = New Size(80, 34)
        Clear.TabIndex = 14
        Clear.Text = "Clear"
        Clear.UseVisualStyleBackColor = False
        ' 
        ' Register
        ' 
        Register.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Register.FlatStyle = FlatStyle.Popup
        Register.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold)
        Register.ForeColor = Color.White
        Register.Location = New Point(118, 303)
        Register.Margin = New Padding(3, 2, 3, 2)
        Register.Name = "Register"
        Register.Size = New Size(101, 34)
        Register.TabIndex = 13
        Register.Text = "Register"
        Register.UseVisualStyleBackColor = False
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.Location = New Point(505, 62)
        EmailTextBox.Margin = New Padding(3, 2, 3, 2)
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.Size = New Size(186, 25)
        EmailTextBox.TabIndex = 11
        ' 
        ' ContactNumberTextBox
        ' 
        ContactNumberTextBox.Location = New Point(503, 26)
        ContactNumberTextBox.Margin = New Padding(3, 2, 3, 2)
        ContactNumberTextBox.Name = "ContactNumberTextBox"
        ContactNumberTextBox.Size = New Size(186, 25)
        ContactNumberTextBox.TabIndex = 10
        ' 
        ' CBGender
        ' 
        CBGender.DisplayMember = "Male"
        CBGender.FlatStyle = FlatStyle.Popup
        CBGender.FormattingEnabled = True
        CBGender.Items.AddRange(New Object() {"Male", "Female"})
        CBGender.Location = New Point(156, 194)
        CBGender.Margin = New Padding(3, 2, 3, 2)
        CBGender.Name = "CBGender"
        CBGender.Size = New Size(101, 25)
        CBGender.TabIndex = 9
        ' 
        ' LastNameTextBox
        ' 
        LastNameTextBox.Location = New Point(156, 66)
        LastNameTextBox.Margin = New Padding(3, 2, 3, 2)
        LastNameTextBox.Name = "LastNameTextBox"
        LastNameTextBox.Size = New Size(186, 25)
        LastNameTextBox.TabIndex = 8
        ' 
        ' FirstNameTextBox
        ' 
        FirstNameTextBox.Location = New Point(156, 26)
        FirstNameTextBox.Margin = New Padding(3, 2, 3, 2)
        FirstNameTextBox.Name = "FirstNameTextBox"
        FirstNameTextBox.Size = New Size(186, 25)
        FirstNameTextBox.TabIndex = 7
        ' 
        ' Email
        ' 
        Email.AutoSize = True
        Email.Font = New Font("Segoe UI Historic", 9.75F, FontStyle.Bold)
        Email.Location = New Point(431, 63)
        Email.Name = "Email"
        Email.Size = New Size(48, 17)
        Email.TabIndex = 5
        Email.Text = "Email:"
        ' 
        ' ContactNumber
        ' 
        ContactNumber.AutoSize = True
        ContactNumber.Font = New Font("Segoe UI Historic", 9.75F, FontStyle.Bold)
        ContactNumber.Location = New Point(360, 29)
        ContactNumber.Name = "ContactNumber"
        ContactNumber.Size = New Size(122, 17)
        ContactNumber.TabIndex = 4
        ContactNumber.Text = "Contact Number:"
        ' 
        ' Gender
        ' 
        Gender.AutoSize = True
        Gender.Font = New Font("Segoe UI Historic", 9.75F, FontStyle.Bold)
        Gender.Location = New Point(67, 197)
        Gender.Name = "Gender"
        Gender.Size = New Size(61, 17)
        Gender.TabIndex = 3
        Gender.Text = "Gender:"
        ' 
        ' LastName
        ' 
        LastName.AutoSize = True
        LastName.Font = New Font("Segoe UI Historic", 9.75F, FontStyle.Bold)
        LastName.Location = New Point(45, 69)
        LastName.Name = "LastName"
        LastName.Size = New Size(83, 17)
        LastName.TabIndex = 2
        LastName.Text = "Last Name:"
        ' 
        ' FirstName
        ' 
        FirstName.AutoSize = True
        FirstName.Font = New Font("Segoe UI Historic", 9.75F, FontStyle.Bold)
        FirstName.Location = New Point(45, 29)
        FirstName.Name = "FirstName"
        FirstName.Size = New Size(85, 17)
        FirstName.TabIndex = 1
        FirstName.Text = "First Name:"
        ' 
        ' Registration
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(753, 370)
        Controls.Add(RegistrationForm)
        FormBorderStyle = FormBorderStyle.None
        Name = "Registration"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registration"
        RegistrationForm.ResumeLayout(False)
        RegistrationForm.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents RegistrationForm As GroupBox
    Friend WithEvents Clear As Button
    Friend WithEvents Register As Button
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents ContactNumberTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents Email As Label
    Friend WithEvents ContactNumber As Label
    Friend WithEvents Gender As Label
    Friend WithEvents LastName As Label
    Friend WithEvents FirstName As Label
    Friend WithEvents CBGender As ComboBox
    Friend WithEvents TxtMName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents CbYear As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CBCourse As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtAge As TextBox
    Friend WithEvents Label4 As Label
End Class
