<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Drop
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
        DropSubject = New Button()
        AddSubject = New Button()
        Cancel = New Button()
        SaveChanges = New Button()
        Label2 = New Label()
        Label1 = New Label()
        EnrolledSubjects = New ListBox()
        AvailableSubjects = New ListBox()
        AddDropSubjects = New Label()
        StudentInformation = New GroupBox()
        NameTextBox = New TextBox()
        Name = New Label()
        CourseYearComboBox = New ComboBox()
        StudentIDTextBox = New TextBox()
        CourseYear = New Label()
        StudentID = New Label()
        StudentInformation.SuspendLayout()
        SuspendLayout()
        ' 
        ' DropSubject
        ' 
        DropSubject.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        DropSubject.FlatStyle = FlatStyle.Popup
        DropSubject.Font = New Font("Segoe UI Historic", 9F, FontStyle.Bold)
        DropSubject.ForeColor = Color.White
        DropSubject.Location = New Point(809, 330)
        DropSubject.Margin = New Padding(3, 2, 3, 2)
        DropSubject.Name = "DropSubject"
        DropSubject.Size = New Size(101, 30)
        DropSubject.TabIndex = 19
        DropSubject.Text = "Drop Subject"
        DropSubject.UseVisualStyleBackColor = False
        ' 
        ' AddSubject
        ' 
        AddSubject.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        AddSubject.FlatStyle = FlatStyle.Popup
        AddSubject.Font = New Font("Segoe UI Historic", 9F, FontStyle.Bold)
        AddSubject.ForeColor = Color.White
        AddSubject.Location = New Point(381, 330)
        AddSubject.Margin = New Padding(3, 2, 3, 2)
        AddSubject.Name = "AddSubject"
        AddSubject.Size = New Size(95, 30)
        AddSubject.TabIndex = 18
        AddSubject.Text = "Add Subject"
        AddSubject.UseVisualStyleBackColor = False
        ' 
        ' Cancel
        ' 
        Cancel.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Cancel.FlatStyle = FlatStyle.Popup
        Cancel.Font = New Font("Segoe UI Historic", 9F, FontStyle.Bold)
        Cancel.ForeColor = Color.White
        Cancel.Location = New Point(647, 404)
        Cancel.Margin = New Padding(3, 2, 3, 2)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(162, 30)
        Cancel.TabIndex = 17
        Cancel.Text = "Cancel"
        Cancel.UseVisualStyleBackColor = False
        ' 
        ' SaveChanges
        ' 
        SaveChanges.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        SaveChanges.FlatStyle = FlatStyle.Popup
        SaveChanges.Font = New Font("Segoe UI Historic", 9F, FontStyle.Bold)
        SaveChanges.ForeColor = Color.White
        SaveChanges.Location = New Point(218, 404)
        SaveChanges.Margin = New Padding(3, 2, 3, 2)
        SaveChanges.Name = "SaveChanges"
        SaveChanges.Size = New Size(162, 30)
        SaveChanges.TabIndex = 16
        SaveChanges.Text = "Save Changes"
        SaveChanges.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(647, 214)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 17)
        Label2.TabIndex = 15
        Label2.Text = "Enrolled Subjects"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(218, 214)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 17)
        Label1.TabIndex = 14
        Label1.Text = "Available Subjects"
        ' 
        ' EnrolledSubjects
        ' 
        EnrolledSubjects.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        EnrolledSubjects.FormattingEnabled = True
        EnrolledSubjects.ItemHeight = 13
        EnrolledSubjects.Location = New Point(552, 239)
        EnrolledSubjects.Margin = New Padding(3, 2, 3, 2)
        EnrolledSubjects.Name = "EnrolledSubjects"
        EnrolledSubjects.Size = New Size(358, 121)
        EnrolledSubjects.TabIndex = 13
        ' 
        ' AvailableSubjects
        ' 
        AvailableSubjects.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AvailableSubjects.FormattingEnabled = True
        AvailableSubjects.ItemHeight = 13
        AvailableSubjects.Location = New Point(118, 239)
        AvailableSubjects.Margin = New Padding(3, 2, 3, 2)
        AvailableSubjects.Name = "AvailableSubjects"
        AvailableSubjects.Size = New Size(358, 121)
        AvailableSubjects.TabIndex = 12
        ' 
        ' AddDropSubjects
        ' 
        AddDropSubjects.AutoSize = True
        AddDropSubjects.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AddDropSubjects.Location = New Point(438, 40)
        AddDropSubjects.Name = "AddDropSubjects"
        AddDropSubjects.Size = New Size(126, 17)
        AddDropSubjects.TabIndex = 11
        AddDropSubjects.Text = "Add/Drop Subjects"
        ' 
        ' StudentInformation
        ' 
        StudentInformation.BackColor = Color.Transparent
        StudentInformation.Controls.Add(NameTextBox)
        StudentInformation.Controls.Add(Name)
        StudentInformation.Controls.Add(CourseYearComboBox)
        StudentInformation.Controls.Add(StudentIDTextBox)
        StudentInformation.Controls.Add(CourseYear)
        StudentInformation.Controls.Add(StudentID)
        StudentInformation.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StudentInformation.Location = New Point(118, 70)
        StudentInformation.Margin = New Padding(3, 2, 3, 2)
        StudentInformation.Name = "StudentInformation"
        StudentInformation.Padding = New Padding(3, 2, 3, 2)
        StudentInformation.Size = New Size(792, 130)
        StudentInformation.TabIndex = 10
        StudentInformation.TabStop = False
        StudentInformation.Text = "Student Information"
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(412, 29)
        NameTextBox.Margin = New Padding(3, 2, 3, 2)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(179, 23)
        NameTextBox.TabIndex = 5
        ' 
        ' Name
        ' 
        Name.AutoSize = True
        Name.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name.Location = New Point(366, 33)
        Name.Name = "Name"
        Name.Size = New Size(38, 13)
        Name.TabIndex = 4
        Name.Text = "Name:"
        ' 
        ' CourseYearComboBox
        ' 
        CourseYearComboBox.FormattingEnabled = True
        CourseYearComboBox.Location = New Point(135, 68)
        CourseYearComboBox.Margin = New Padding(3, 2, 3, 2)
        CourseYearComboBox.Name = "CourseYearComboBox"
        CourseYearComboBox.Size = New Size(179, 25)
        CourseYearComboBox.TabIndex = 3
        ' 
        ' StudentIDTextBox
        ' 
        StudentIDTextBox.Location = New Point(135, 29)
        StudentIDTextBox.Margin = New Padding(3, 2, 3, 2)
        StudentIDTextBox.Name = "StudentIDTextBox"
        StudentIDTextBox.Size = New Size(179, 23)
        StudentIDTextBox.TabIndex = 2
        ' 
        ' CourseYear
        ' 
        CourseYear.AutoSize = True
        CourseYear.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CourseYear.Location = New Point(40, 72)
        CourseYear.Name = "CourseYear"
        CourseYear.Size = New Size(70, 13)
        CourseYear.TabIndex = 1
        CourseYear.Text = "Course/Year:"
        ' 
        ' StudentID
        ' 
        StudentID.AutoSize = True
        StudentID.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StudentID.Location = New Point(50, 33)
        StudentID.Name = "StudentID"
        StudentID.Size = New Size(61, 13)
        StudentID.TabIndex = 0
        StudentID.Text = "Student ID:"
        ' 
        ' Add_Drop
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1028, 475)
        Controls.Add(DropSubject)
        Controls.Add(AddSubject)
        Controls.Add(Cancel)
        Controls.Add(SaveChanges)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(EnrolledSubjects)
        Controls.Add(AvailableSubjects)
        Controls.Add(AddDropSubjects)
        Controls.Add(StudentInformation)
        FormBorderStyle = FormBorderStyle.None
        'Name = "Add_Drop"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add_Drop"
        StudentInformation.ResumeLayout(False)
        StudentInformation.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DropSubject As Button
    Friend WithEvents AddSubject As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents SaveChanges As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EnrolledSubjects As ListBox
    Friend WithEvents AvailableSubjects As ListBox
    Friend WithEvents AddDropSubjects As Label
    Friend WithEvents StudentInformation As GroupBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Name As Label
    Friend WithEvents CourseYearComboBox As ComboBox
    Friend WithEvents StudentIDTextBox As TextBox
    Friend WithEvents CourseYear As Label
    Friend WithEvents StudentID As Label
End Class
