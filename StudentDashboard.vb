Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Text

Public Class StudentDashboard
    Dim Connector As String = "server=localhost;userid=root;password=root;database=msis"

    Private Sub BtnRegistration_Click(sender As Object, e As EventArgs) Handles BtnRegistration.Click
        Me.BackgroundImage = Nothing
        Me.Size = New Point(956, 430)
        LblTitle.Text = "REGISTRATION"

        BtnRegistration.Font = New Font(BtnRegistration.Font, FontStyle.Bold)
        BtnRegistration.ForeColor = Color.Orange
        BtnAddDrop.Font = New Font(BtnAddDrop.Font, FontStyle.Regular)
        BtnAddDrop.ForeColor = Color.White
        BtnClassSchedule.Font = New Font(BtnClassSchedule.Font, FontStyle.Regular)
        BtnClassSchedule.ForeColor = Color.White
        BtnProfile.Font = New Font(BtnProfile.Font, FontStyle.Regular)
        BtnProfile.ForeColor = Color.White
        BtnAssesment.Font = New Font(BtnAssesment.Font, FontStyle.Regular)
        BtnAssesment.ForeColor = Color.White
        BtnGrade.Font = New Font(BtnGrade.Font, FontStyle.Regular)
        BtnGrade.ForeColor = Color.White
        BtnFeedBack.Font = New Font(BtnFeedBack.Font, FontStyle.Regular)
        BtnFeedBack.ForeColor = Color.White
        BtnAcademicSupport.Font = New Font(BtnAcademicSupport.Font, FontStyle.Regular)
        BtnAcademicSupport.ForeColor = Color.White

        PnlAcademicSupport.Visible = False
        PnlFeedback.Visible = False
        TablePnlGrade.Visible = False
        PnlAssesmentInfo.Visible = False
        PnlProfileInfo.Visible = False
        PnlClassSchedule.Visible = False
        RegistrationForm.Visible = True
        PnlAddDropSubject.Visible = False
    End Sub

    Private Sub StudentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CbSem.Items.Clear()
        CbSem.Items.Add("First sem")
        CbSem.Items.Add("Second sem")
        CbSem.DropDownStyle = ComboBoxStyle.DropDownList

        CbTeacherName.Items.Add("Mr. Christopher Manuel Rojas Jr.")
        CbTeacherName.Items.Add("Mr. Adrian M. Cruz")
        CbTeacherName.Items.Add("Mr. Patrick G. Estrada")
        CbTeacherName.Items.Add("Mr. Santos L. Ramon")
        CbTeacherName.Items.Add("Mr. Aeron B. Flores")

        CBGender.Items.Clear()
        CBGender.Items.Add("Male")
        CBGender.Items.Add("Female")
        CBGender.DropDownStyle = ComboBoxStyle.DropDownList

        CbYear.Items.Clear()
        CbYear.Items.Add("1st yr")
        CbYear.Items.Add("2nd yr")
        CbYear.Items.Add("3rd yr")
        CbYear.Items.Add("4th yr")
        CbYear.DropDownStyle = ComboBoxStyle.DropDownList

        CBCourse.Items.Clear()
        CBCourse.Items.Add("BSIT")
        CBCourse.Items.Add("BSEED")
        CBCourse.DropDownStyle = ComboBoxStyle.DropDownList

        FlowPnlStudentDashBoardSidebar.AutoScroll = True
        FlowPnlStudentDashBoardSidebar.VerticalScroll.Enabled = True
        FlowPnlStudentDashBoardSidebar.VerticalScroll.Visible = True
        FlowPnlStudentDashBoardSidebar.AutoScrollMinSize = New Size(0, 600)

        TablePnlGrade.Visible = False

        CmbCategory.Items.Add("What is Academic Support?")
        CmbCategory.Items.Add("How can I get tutoring help?")
        CmbCategory.Items.Add("Where can I find study materials?")
        CmbCategory.Items.Add("Who do I contact for guidance?")
        CmbCategory.Items.Add("How to join school activities?")
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        FirstNameTextBox.Clear()
        LastNameTextBox.Clear()
        TxtMName.Clear()
        TxtAge.Clear()
        CBGender.SelectedIndex = -1
        CbYear.SelectedIndex = -1
        CBCourse.SelectedIndex = -1
        ContactNumberTextBox.Clear()
        EmailTextBox.Clear()

    End Sub

    Private Sub BtnAddDrop_Click(sender As Object, e As EventArgs) Handles BtnAddDrop.Click
        Me.BackgroundImage = Nothing

        BtnRegistration.Font = New Font(BtnRegistration.Font, FontStyle.Regular)
        BtnRegistration.ForeColor = Color.White
        BtnAddDrop.Font = New Font(BtnAddDrop.Font, FontStyle.Bold)
        BtnAddDrop.ForeColor = Color.Orange
        BtnClassSchedule.Font = New Font(BtnClassSchedule.Font, FontStyle.Regular)
        BtnClassSchedule.ForeColor = Color.White
        BtnProfile.Font = New Font(BtnProfile.Font, FontStyle.Regular)
        BtnProfile.ForeColor = Color.White
        BtnAssesment.Font = New Font(BtnAssesment.Font, FontStyle.Regular)
        BtnAssesment.ForeColor = Color.White
        BtnGrade.Font = New Font(BtnGrade.Font, FontStyle.Regular)
        BtnGrade.ForeColor = Color.White
        BtnAcademicSupport.Font = New Font(BtnAcademicSupport.Font, FontStyle.Regular)
        BtnAcademicSupport.ForeColor = Color.White

        PnlAcademicSupport.Visible = False

        Me.Size = New Point(956, 430)
        LblTitle.Text = "ADD/DROP SUBJECT"

        PnlProfileInfo.Visible = False
        PnlClassSchedule.Visible = False
        RegistrationForm.Visible = False
        PnlAddDropSubject.Visible = True
        TablePnlGrade.Visible = False
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        ' Simple email regex pattern
        Dim pattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Return Regex.IsMatch(email, pattern)
    End Function

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Me.BackgroundImage = Nothing

        Me.Size = New Point(956, 430)

        Dim studentFName As String = FirstNameTextBox.Text.Trim()
        Dim studentLName As String = LastNameTextBox.Text.Trim()
        Dim studentMName As String = TxtMName.Text.Trim()
        Dim studentAgeText As String = TxtAge.Text.Trim()
        Dim studentContactNumber As String = ContactNumberTextBox.Text.Trim()
        Dim studentEmail As String = EmailTextBox.Text.Trim()
        Dim studentGender As String = CBGender.Text.Trim()
        Dim studentYear As String = CbYear.Text.Trim()
        Dim studentCourse As String = CBCourse.Text.Trim()
        Dim studentSem As String = CbSem.Text.Trim
        Dim Address As String = TxtAddress.Text.Trim()

        ' === Basic Validation (empty fields) ===
        If String.IsNullOrEmpty(studentFName) OrElse
           String.IsNullOrEmpty(studentLName) OrElse
           String.IsNullOrEmpty(studentMName) OrElse
           String.IsNullOrEmpty(studentAgeText) OrElse
           String.IsNullOrEmpty(studentContactNumber) OrElse
           String.IsNullOrEmpty(studentEmail) OrElse
           String.IsNullOrEmpty(studentGender) OrElse
           String.IsNullOrEmpty(studentYear) OrElse
           String.IsNullOrEmpty(studentCourse) OrElse
           String.IsNullOrEmpty(Address) Then

            MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        ' === Validate Age (must be number) ===
        Dim studentAge As Integer

        If Not Integer.TryParse(studentAgeText, studentAge) Then
            MessageBox.Show("Age must be a number. Please enter a valid age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtAge.Clear()
            TxtAge.Focus()
            Exit Sub
        End If

        'Phone number

        If Not System.Text.RegularExpressions.Regex.IsMatch(studentContactNumber, "^[0-9]{11}$") Then
            MessageBox.Show("Phone number must be exactly 11 digits (numbers only).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ContactNumberTextBox.Clear()
            ContactNumberTextBox.Focus()
            Exit Sub
        End If

        'Email
        If Not IsValidEmail(studentEmail) Then
            MessageBox.Show("Email must be a right format. Please enter a right format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            EmailTextBox.Clear()
            EmailTextBox.Focus()
            Exit Sub
        End If

        ' === SQL Query ===
        Dim query As String =
            "INSERT INTO student_List (LastName, FirstName, MiddleName, Age, Year, Gender, Email, ContactNumber, Course, Sem, Address) " &
            "VALUES (@Lname, @Fname, @Mname, @Age, @Year, @Gender, @Email, @ContactNumber, @Course, @Sem, @Address)"

        Try
            Using conn As New MySqlConnection(Connector)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@LName", studentLName)
                    cmd.Parameters.AddWithValue("@Fname", studentFName)
                    cmd.Parameters.AddWithValue("@Mname", studentMName)
                    cmd.Parameters.AddWithValue("@Age", studentAge) ' << parsed number
                    cmd.Parameters.AddWithValue("@Year", studentYear)
                    cmd.Parameters.AddWithValue("@Gender", studentGender)
                    cmd.Parameters.AddWithValue("@Email", studentEmail)
                    cmd.Parameters.AddWithValue("@ContactNumber", studentContactNumber)
                    cmd.Parameters.AddWithValue("@Course", studentCourse)
                    cmd.Parameters.AddWithValue("@Sem", studentSem)
                    cmd.Parameters.AddWithValue("@Address", Address)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' === Clear all TextBoxes after success ===
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is TextBox Then
                    DirectCast(ctrl, TextBox).Clear()
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        NameTextBox.Text = studentFName & " " & studentMName & " " & studentLName
        TxtCourse.Text = studentCourse
        TxtYear.Text = studentYear & " " & studentSem

        Using conn As New MySqlConnection("server=localhost;userid=root;password=root;database=msis")
            conn.Open()

            Dim studentidQuery As String = "SELECT StudentId FROM student_list ORDER BY StudentId DESC LIMIT 1"
            Using cmd As New MySqlCommand(studentidQuery, conn)
                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    TxtStudentID.Text = result.ToString().PadLeft(4, "0"c)
                Else
                    MessageBox.Show("Walang nakitang StudentId sa table.")
                End If
            End Using

        End Using

        LoadSubjectsForCurrentSelection()

        UpdateSchedule()

        If FirstNameTextBox.Text = "Adrian" Then
            PicStudent.Image = My.Resources.Male_Photo
        End If

        BtnAddDrop.Enabled = True
        BtnDropSubject.Enabled = True
        BtnClassSchedule.Enabled = True
        BtnAssesment.Enabled = True
        BtnProfile.Enabled = True
        BtnGrade.Enabled = True
        BtnFeedBack.Enabled = True
        BtnAcademicSupport.Enabled = True

        Select Case FirstNameTextBox.Text
            Case "Rochelle"
                PicStudent.Image = My.Resources.Rochelle
                lblFullName.Text = FirstNameTextBox.Text & " " & TxtMName.Text & " " & LastNameTextBox.Text
            Case "Danica"
                PicStudent.Image = My.Resources.Danica
                lblFullName.Text = FirstNameTextBox.Text & " " & TxtMName.Text & " " & LastNameTextBox.Text
            Case "Hazel"
                PicStudent.Image = My.Resources.hazel
                lblFullName.Text = FirstNameTextBox.Text & " " & TxtMName.Text & " " & LastNameTextBox.Text
            Case "Harvey"
                PicStudent.Image = My.Resources.harvey
                lblFullName.Text = FirstNameTextBox.Text & " " & TxtMName.Text & " " & LastNameTextBox.Text
        End Select
    End Sub

    ' Helper: clears all schedule labels used by UpdateSchedule
    Private Sub ClearAllScheduleLabels()
        Dim dayLabels As New Dictionary(Of String, Label()) From {
        {"Monday", {TryCast(Me.Controls.Find("LblMondaySchedule1", True).FirstOrDefault(), Label), TryCast(Me.Controls.Find("LblMondaySchedule2", True).FirstOrDefault(), Label)}},
        {"Tuesday", {TryCast(Me.Controls.Find("LblTuesdaySchedule1", True).FirstOrDefault(), Label), TryCast(Me.Controls.Find("LblTuesdaySchedule2", True).FirstOrDefault(), Label)}},
        {"Wednesday", {TryCast(Me.Controls.Find("LblWedSchedule1", True).FirstOrDefault(), Label), TryCast(Me.Controls.Find("LblWedSchedule2", True).FirstOrDefault(), Label)}},
        {"Thursday", {TryCast(Me.Controls.Find("LblThursSchedule1", True).FirstOrDefault(), Label), TryCast(Me.Controls.Find("LblThursSchedule2", True).FirstOrDefault(), Label)}},
        {"Friday", {TryCast(Me.Controls.Find("LblFridaySchedule1", True).FirstOrDefault(), Label), TryCast(Me.Controls.Find("LblFridaySchedule2", True).FirstOrDefault(), Label)}},
        {"Saturday", {TryCast(Me.Controls.Find("LblSatSchedule1", True).FirstOrDefault(), Label), TryCast(Me.Controls.Find("LblSatSchedule2", True).FirstOrDefault(), Label)}}
    }

        For Each pair In dayLabels
            For Each lbl In pair.Value
                If lbl IsNot Nothing Then
                    lbl.Text = ""
                    lbl.Visible = False
                    lbl.BackColor = SystemColors.Control
                    lbl.BorderStyle = BorderStyle.None
                    ' reset position/rowspan if TableLayoutPanel was previously changed
                    Try
                        TableLayoutPanel1.SetRowSpan(lbl, 1)
                        TableLayoutPanel1.SetColumnSpan(lbl, 1)
                        TableLayoutPanel1.SetCellPosition(lbl, New TableLayoutPanelCellPosition(0, 0))
                    Catch ex As Exception
                        ' ignore if not part of table or not yet added
                    End Try
                End If
            Next
        Next
    End Sub
    Public subjecDic As New Dictionary(Of String, String()) From
    {{"BSIT-1st yr-First sem", {"Introduction to Computing", "Computer Programming I", "Purposive Communication",
                                "Reading in Philippine History", "Mathematics in the Modern World", "National Service Training Program I",
                                "Physical Activities"}},
    {"BSIT-1st yr-Second sem", {"Science, Technology & Society", "Computer Programming II", "Ethics in Modern",
                                "Discrete Mathematics", "Introduction to Human Computer Interaction", "National Service Training Program II",
                                "Rhythmic Activities"}},
    {"BSIT-2nd yr-First sem", {"Information Management", "Understanding the self", "The Contemporary World", "The Entrepreneurial Mind", "Quantative Methods",
                               "Object Oriented Programming", "Platform Technologies", "Individual/Dual Sports"}},
    {"BSIT-2nd yr-Second sem", {"Data Structure and Algorithms", "Living IT Era", "Human Computer Interaction II", "Advance Database Systems",
                                "Integrative Programming and Technologies I", "Networking I", "Team Sports"}},
    {"BSIT-3rd yr-First sem", {"Application Development", "Komunikasyon sa Akademikong Filipino", "Art Aprreciation", "Great IT Books Reading",
                               "System Integration Architecture I", "Information Assurance and Security I", "Event Driven Programming"}},
    {"BSIT-3rd yr-Second sem", {"Pagbasa at Pagsulat Tungo sa Pananaliksik", "Web System and Technologies I", "Networking II",
                                "Capstone Project and Research I", "Integrative Programming and Technologies II", "Information Assurance and Security II"}},
    {"BSIT-4th yr-First sem", {"Panitikang Filipino", "Rizal: Life and Works", "Social and Professional Issues", "Capstone Project and Reaserch II",
                                "System Integration Architecture II", "System Administration and Maintenance", "Web System and Technologies II"}},
    {"BSIT-4th yr-Second sem", {"Practicum"}},
    {"BSEED-1st yr-First sem", {"Good Manners and Right Conduct", "Purposive Communication", "Readings in Philippine History",
                                "Mathematics in the Modern World", "Understanding the Self", "National Service Training Program I",
                                "Physical Activities", "The Teaching Profession"}},
    {"BSEED-1st yr-Second sem", {"Science, Technology & Society", "Ethics in Modern Society", "NSTP II", "Assessment in Learning I",
                                 "Facilitating Learner-Centered Teaching", "Rhythmic Activities", "Child and Adolescent Learners",
                                 "Teacher and Community Leadership"}},
    {"BSEED-2nd yr-First sem", {"Research in Education", "Teaching Science: Biology & Chemistry", "Pagtuturo ng Filipino I",
                                "Teaching Social Studies I", "Teaching Math in Primary Grades", "Assessment in Learning II",
                                "Technology for Teaching and Learning I", "Individual/Dual Sports"}},
    {"BSEED-2nd yr-Second sem", {"Teaching Social Studies II", "Pagtuturo ng Filipino II (Panitikan)", "Teaching Math in Intermediate Grades",
                                  "Edukasyong Pantahanan with Entrepreneurship", "Teaching Music in Elementary", "Teaching Arts in Elementary",
                                  "Teacher and School Curriculum", "Team Sports"}},
    {"BSEED-3rd yr-First sem", {"Teaching Multi-grade Classes", "Children and Adolescent Literature", "Teaching PE and Health",
                                "Teaching English: Language Arts", "Content and Pedagogy for Mother Tongue", "Technology for Teaching - Elementary",
                                "Komunikasyon sa Akademikong Filipino", "The Contemporary World"}},
    {"BSEED-3rd yr-Second sem", {"Edukasyong Pantahanan at Pangkabuhayan", "Teaching English through Literature", "Teaching Science: Physics & Earth Science",
                                 "Pagbasa at Pagsulat Tungo sa Pananaliksik", "Environmental Science", "Great Books", "Building New Literacies Across Curriculum"}},
    {"BSEED-4th yr-First sem", {"Field Study 1", "Field Study 2", "Panitikang Filipino", "Art Appreciation", "Buhay at mga Akda ni Rizal", "Entrepreneurial Mind",
                                "Foundation of Special and Inclusive Education"}},
    {"BSEED-4th yr-Second sem", {"Practicum"}}}

    Public AddsubjecDic As New Dictionary(Of String, String()) From
    {{"BSIT-1st yr-First sem", {"Digital Logic and Design"}},
    {"BSIT-1st yr-Second sem", {"Hardware & Systems"}},
    {"BSIT-2nd yr-First sem", {"Business Process Management", "Hardware, Software, and Peripherals"}},
    {"BSIT-2nd yr-Second sem", {"Data Analytics"}},
    {"BSIT-3rd yr-First Sem", {"Professional Elective 1", "Multimedia Systems"}},
    {"BSIT-3rd yr-Second Sem", {"Professional Elective 2", "Multimedia Systems", "Networking III",
                                "Numerical Analysis for ITE", "Effective Communication with Personality Developmen"}},
    {"BSIT-4th yr-First Sem", {"Professional Elective 3", "Professional Elective 4"}},
    {"BSEED-2nd yr-First sem", {"Educational Psychology"}},
    {"BSEED-3rd yr-First sem", {"Teaching Strategies"}},
    {"BSEED-3rd yr-Second sem", {"Classroom Management"}}}

    Private Sub LoadSubjectsForCurrentSelection()
        LstEnrolledSub.Items.Clear()
        LstAvailableSub.Items.Clear()
        Dim key As String = CBCourse.Text & "-" & CbYear.Text() & "-" & CbSem.Text
        If subjecDic.ContainsKey(key) Then
            For Each subj In subjecDic(key)
                LstEnrolledSub.Items.Add(subj)
            Next
        End If
        If AddsubjecDic.ContainsKey(key) Then
            For Each addsub In AddsubjecDic(key)
                LstAvailableSub.Items.Add(addsub)
            Next
        End If
    End Sub
    Private Sub BtnDropSubject_Click(sender As Object, e As EventArgs) Handles BtnDropSubject.Click
        If LstEnrolledSub.SelectedItem IsNot Nothing Then
            Dim selectedSub As String = LstEnrolledSub.SelectedItem.ToString()
            Dim key As String = CBCourse.Text & "-" & CbYear.Text & "-" & CbSem.Text
            If subjecDic.ContainsKey(key) Then
                Dim subs As List(Of String) = subjecDic(key).ToList()
                If subs.Contains(selectedSub) Then
                    Dim result As DialogResult = MessageBox.Show("Are you sure you want to drop this subject: " & selectedSub & "?", "Dropped Subject", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If result = DialogResult.Yes Then
                        subs.Remove(selectedSub)
                        subjecDic(key) = subs.ToArray()
                        LstEnrolledSub.Items.Remove(selectedSub)
                        UpdateSchedule()
                        MessageBox.Show("Successfully dropped the subject: " & selectedSub)
                    Else MessageBox.Show("Cancelled dropping subject.", "Cancelled")
                    End If
                Else MessageBox.Show("Subject not found in list.")
                End If
            End If
        Else MessageBox.Show("Please select a subject to drop.")
        End If
    End Sub
    Private Sub BtnAddSubject_Click(sender As Object, e As EventArgs) Handles BtnAddSubject.Click
        If LstAvailableSub.SelectedItem IsNot Nothing Then
            Dim selectedSub As String = LstAvailableSub.SelectedItem.ToString()
            Dim key As String = CBCourse.Text & "-" & CbYear.Text & "-" & CbSem.Text
            If AddsubjecDic.ContainsKey(key) Then
                Dim availSubs As List(Of String) = AddsubjecDic(key).ToList()
                If availSubs.Contains(selectedSub) Then
                    Dim result As DialogResult = MessageBox.Show("Are you sure you want to add this subject: " & selectedSub & "?", "Add Subject", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result = DialogResult.Yes Then
                        availSubs.Remove(selectedSub)
                        AddsubjecDic(key) = availSubs.ToArray()
                        Dim enrolledSubs As List(Of String) = New List(Of String)
                        If subjecDic.ContainsKey(key) Then
                            enrolledSubs = subjecDic(key).ToList()
                        End If
                        enrolledSubs.Add(selectedSub)
                        subjecDic(key) = enrolledSubs.ToArray()
                        LstEnrolledSub.Items.Add(selectedSub)
                        LstAvailableSub.Items.Remove(selectedSub)
                        UpdateSchedule()
                        MessageBox.Show("Successfully added the subject: " & selectedSub)
                    Else MessageBox.Show("Cancelled adding subject.", "Cancelled")
                    End If
                Else MessageBox.Show("Subject not found in available list.")
                End If
            End If
        Else MessageBox.Show("Please select a subject to add.")
        End If
    End Sub
    Private Sub BtnClassSchedule_Click(sender As Object, e As EventArgs) Handles BtnClassSchedule.Click
        BackgroundImage = Nothing
        BtnRegistration.Font = New Font(BtnRegistration.Font, FontStyle.Regular)
        BtnRegistration.ForeColor = Color.White
        BtnAddDrop.Font = New Font(BtnAddDrop.Font, FontStyle.Regular)
        BtnAddDrop.ForeColor = Color.White
        BtnClassSchedule.Font = New Font(BtnClassSchedule.Font, FontStyle.Bold)
        BtnClassSchedule.ForeColor = Color.Orange
        BtnProfile.Font = New Font(BtnProfile.Font, FontStyle.Regular)
        BtnProfile.ForeColor = Color.White
        BtnAssesment.Font = New Font(BtnAssesment.Font, FontStyle.Regular)
        BtnAssesment.ForeColor = Color.White
        BtnGrade.Font = New Font(BtnGrade.Font, FontStyle.Regular)
        BtnGrade.ForeColor = Color.White
        BtnFeedBack.Font = New Font(BtnFeedBack.Font, FontStyle.Regular)
        BtnFeedBack.ForeColor = Color.White
        FlowPnlStudentDashBoardSidebar.Size = New Size(200, 530)
        Size = New Size(956, 530)
        TxtClassCourse.Text = TxtCourse.Text
        TxtYearSem.Text = TxtYear.Text
        LblTitle.Location = New Point(450, 15)
        LblTitle.BringToFront()
        LblTitle.Text = "CLASS SCHEDULE"
        PnlFeedback.Visible = False
        PnlAssesmentInfo.Visible = False
        PnlProfileInfo.Visible = False
        PnlClassSchedule.Visible = True
        RegistrationForm.Visible = False
        PnlAddDropSubject.Visible = False
        TablePnlGrade.Visible = False

        UpdateSchedule()
    End Sub

    Private Sub UpdateSchedule()
        ClearAllScheduleLabels()

        ' ==================== BSIT - 1st Year - First Semester ====================
        If CBCourse.Text = "BSIT" And CbSem.Text = "First sem" And CbYear.Text = "1st yr" Then

            ' MONDAY: Introduction to Computing (9:00-10:30 AM)
            LblMondayScheduleMorning.Text = "Introduction to Computing" & vbCrLf & "1IT1" & vbCrLf & "RM 309"
            LblMondayScheduleMorning.BackColor = Color.Yellow
            LblMondayScheduleMorning.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondayScheduleMorning, 3)
            TableLayoutPanel1.SetColumn(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetRowSpan(LblMondayScheduleMorning, 3)
            TableLayoutPanel1.SetColumnSpan(LblMondayScheduleMorning, 1)
            LblMondayScheduleMorning.Visible = True

            ' MONDAY: Purposive Communication (12:30-2:00 PM)
            LblMondaySchedule2.Text = "Purposive Communication" & vbCrLf & "1IT1" & vbCrLf & "RM 315"
            LblMondaySchedule2.BackColor = Color.Yellow
            LblMondaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondaySchedule2, 9)
            TableLayoutPanel1.SetColumn(LblMondaySchedule2, 1)
            TableLayoutPanel1.SetRowSpan(LblMondaySchedule2, 3)
            TableLayoutPanel1.SetColumnSpan(LblMondaySchedule2, 1)
            LblMondaySchedule2.Visible = True

            ' TUESDAY: Mathematics in the Modern World (9:00-11:00 AM)
            LblTuesdaySchedule1.Text = "Mathematics in the" & vbCrLf & "Modern World" & vbCrLf & "1IT1" & vbCrLf & "RM 302"
            LblTuesdaySchedule1.BackColor = Color.Yellow
            LblTuesdaySchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblTuesdaySchedule1, 3)
            TableLayoutPanel1.SetColumn(LblTuesdaySchedule1, 2)
            TableLayoutPanel1.SetRowSpan(LblTuesdaySchedule1, 4)
            TableLayoutPanel1.SetColumnSpan(LblTuesdaySchedule1, 1)
            LblTuesdaySchedule1.Visible = True

            ' TUESDAY: Physical Activities (1:30-3:00 PM)
            LblTuesdaySchedule2.Text = "Physical Activities" & vbCrLf & "1IT1" & vbCrLf & "GYM"
            LblTuesdaySchedule2.BackColor = Color.Yellow
            LblTuesdaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblTuesdaySchedule2, 10)
            TableLayoutPanel1.SetColumn(LblTuesdaySchedule2, 2)
            TableLayoutPanel1.SetRowSpan(LblTuesdaySchedule2, 3)
            TableLayoutPanel1.SetColumnSpan(LblTuesdaySchedule2, 1)
            LblTuesdaySchedule2.Visible = True

            ' WEDNESDAY: Reading in Philippine History (9:00-11:00 AM)
            LblWedSchedule2.Text = "Reading in Philippine" & vbCrLf & "History" & vbCrLf & "1IT1" & vbCrLf & "RM 304"
            LblWedSchedule2.BackColor = Color.Yellow
            LblWedSchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblWedSchedule2, 3)
            TableLayoutPanel1.SetColumn(LblWedSchedule2, 3)
            TableLayoutPanel1.SetRowSpan(LblWedSchedule2, 4)
            TableLayoutPanel1.SetColumnSpan(LblWedSchedule2, 1)
            LblWedSchedule2.Visible = True

            ' THURSDAY: National Service Training Program I (9:00-11:00 AM)
            LblThursSchedule1.Text = "National Service" & vbCrLf & "Training Program I" & vbCrLf & "1IT1" & vbCrLf & "RM 306"
            LblThursSchedule1.BackColor = Color.Yellow
            LblThursSchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblThursSchedule1, 3)
            TableLayoutPanel1.SetColumn(LblThursSchedule1, 4)
            TableLayoutPanel1.SetRowSpan(LblThursSchedule1, 4)
            TableLayoutPanel1.SetColumnSpan(LblThursSchedule1, 1)
            LblThursSchedule1.Visible = True

            ' SATURDAY: Computer Programming I (8:00-11:00 AM)
            LblSatSchedule1.Text = "Computer Programming I" & vbCrLf & "1IT1" & vbCrLf & "RM 308"
            LblSatSchedule1.BackColor = Color.Yellow
            LblSatSchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblSatSchedule1, 1)
            TableLayoutPanel1.SetColumn(LblSatSchedule1, 6)
            TableLayoutPanel1.SetRowSpan(LblSatSchedule1, 6)
            TableLayoutPanel1.SetColumnSpan(LblSatSchedule1, 1)
            LblSatSchedule1.Visible = True

            ' ==================== BSIT - 1st Year - Second Semester ====================
        ElseIf CBCourse.Text = "BSIT" And CbSem.Text = "Second sem" And CbYear.Text = "1st yr" Then

            ' MONDAY: Science, Technology & Society (9:00-10:30 AM)
            LblMondayScheduleMorning.Text = "Science, Technology" & vbCrLf & "& Society" & vbCrLf & "1IT1" & vbCrLf & "RM 310"
            LblMondayScheduleMorning.BackColor = Color.Yellow
            LblMondayScheduleMorning.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondayScheduleMorning, 3)
            TableLayoutPanel1.SetColumn(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetRowSpan(LblMondayScheduleMorning, 3)
            TableLayoutPanel1.SetColumnSpan(LblMondayScheduleMorning, 1)
            LblMondayScheduleMorning.Visible = True

            ' MONDAY: Ethics in Modern (1:30-3:00 PM)
            LblMondaySchedule2.Text = "Ethics in Modern" & vbCrLf & "1IT1" & vbCrLf & "RM 312"
            LblMondaySchedule2.BackColor = Color.Yellow
            LblMondaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondaySchedule2, 10)
            TableLayoutPanel1.SetColumn(LblMondaySchedule2, 1)
            TableLayoutPanel1.SetRowSpan(LblMondaySchedule2, 3)
            TableLayoutPanel1.SetColumnSpan(LblMondaySchedule2, 1)
            LblMondaySchedule2.Visible = True

            ' TUESDAY: Computer Programming II (8:00-11:00 AM)
            LblTuesdaySchedule1.Text = "Computer Programming II" & vbCrLf & "1IT1" & vbCrLf & "RM 314"
            LblTuesdaySchedule1.BackColor = Color.Yellow
            LblTuesdaySchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblTuesdaySchedule1, 1)
            TableLayoutPanel1.SetColumn(LblTuesdaySchedule1, 2)
            TableLayoutPanel1.SetRowSpan(LblTuesdaySchedule1, 6)
            TableLayoutPanel1.SetColumnSpan(LblTuesdaySchedule1, 1)
            LblTuesdaySchedule1.Visible = True

            ' TUESDAY: Rhythmic Activities (2:30-4:00 PM)
            LblTuesdaySchedule2.Text = "Rhythmic Activities" & vbCrLf & "1IT1" & vbCrLf & "GYM"
            LblTuesdaySchedule2.BackColor = Color.Yellow
            LblTuesdaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblTuesdaySchedule2, 12)
            TableLayoutPanel1.SetColumn(LblTuesdaySchedule2, 2)
            TableLayoutPanel1.SetRowSpan(LblTuesdaySchedule2, 3)
            TableLayoutPanel1.SetColumnSpan(LblTuesdaySchedule2, 1)
            LblTuesdaySchedule2.Visible = True

            ' WEDNESDAY: Discrete Mathematics (9:00-11:00 AM)
            LblWedSchedule2.Text = "Discrete Mathematics" & vbCrLf & "1IT1" & vbCrLf & "RM 316"
            LblWedSchedule2.BackColor = Color.Yellow
            LblWedSchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblWedSchedule2, 3)
            TableLayoutPanel1.SetColumn(LblWedSchedule2, 3)
            TableLayoutPanel1.SetRowSpan(LblWedSchedule2, 4)
            TableLayoutPanel1.SetColumnSpan(LblWedSchedule2, 1)
            LblWedSchedule2.Visible = True

            ' THURSDAY: Introduction to Human Computer Interaction (9:00-11:00 AM)
            LblThursSchedule1.Text = "Introduction to Human" & vbCrLf & "Computer Interaction" & vbCrLf & "1IT1" & vbCrLf & "RM 318"
            LblThursSchedule1.BackColor = Color.Yellow
            LblThursSchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblThursSchedule1, 3)
            TableLayoutPanel1.SetColumn(LblThursSchedule1, 4)
            TableLayoutPanel1.SetRowSpan(LblThursSchedule1, 4)
            TableLayoutPanel1.SetColumnSpan(LblThursSchedule1, 1)
            LblThursSchedule1.Visible = True

            ' FRIDAY: National Service Training Program II (9:00-11:00 AM)
            LblFridaySchedule2.Text = "National Service" & vbCrLf & "Training Program II" & vbCrLf & "1IT1" & vbCrLf & "RM 320"
            LblFridaySchedule2.BackColor = Color.Yellow
            LblFridaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblFridaySchedule2, 3)
            TableLayoutPanel1.SetColumn(LblFridaySchedule2, 5)
            TableLayoutPanel1.SetRowSpan(LblFridaySchedule2, 4)
            TableLayoutPanel1.SetColumnSpan(LblFridaySchedule2, 1)
            LblFridaySchedule2.Visible = True

            ' ==================== BSIT - 2nd Year - First Semester ====================
        ElseIf CBCourse.Text = "BSIT" And CbSem.Text = "First sem" And CbYear.Text = "2nd yr" Then

            ' MONDAY: Information Management (8:00-10:00 AM)
            LblMondayScheduleMorning.Text = "Information Management" & vbCrLf & "2IT1" & vbCrLf & "RM 300"
            LblMondayScheduleMorning.BackColor = Color.Yellow
            LblMondayScheduleMorning.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetColumn(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetRowSpan(LblMondayScheduleMorning, 4)
            TableLayoutPanel1.SetColumnSpan(LblMondayScheduleMorning, 1)
            LblMondayScheduleMorning.Visible = True

            ' MONDAY: Understanding the self (1:30-3:00 PM)
            LblMondaySchedule2.Text = "Understanding the self" & vbCrLf & "2IT1" & vbCrLf & "RM 302"
            LblMondaySchedule2.BackColor = Color.Yellow
            LblMondaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondaySchedule2, 10)
            TableLayoutPanel1.SetColumn(LblMondaySchedule2, 1)
            TableLayoutPanel1.SetRowSpan(LblMondaySchedule2, 3)
            TableLayoutPanel1.SetColumnSpan(LblMondaySchedule2, 1)
            LblMondaySchedule2.Visible = True

            ' TUESDAY: The Contemporary World (9:00-10:30 AM)
            LblTuesdaySchedule1.Text = "The Contemporary World" & vbCrLf & "2IT1" & vbCrLf & "RM 304"
            LblTuesdaySchedule1.BackColor = Color.Yellow
            LblTuesdaySchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblTuesdaySchedule1, 3)
            TableLayoutPanel1.SetColumn(LblTuesdaySchedule1, 2)
            TableLayoutPanel1.SetRowSpan(LblTuesdaySchedule1, 3)
            TableLayoutPanel1.SetColumnSpan(LblTuesdaySchedule1, 1)
            LblTuesdaySchedule1.Visible = True

            ' TUESDAY: Individual/Dual Sports (2:30-4:00 PM)
            LblTuesdaySchedule2.Text = "Individual/Dual Sports" & vbCrLf & "2IT1" & vbCrLf & "GYM"
            LblTuesdaySchedule2.BackColor = Color.Yellow
            LblTuesdaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblTuesdaySchedule2, 12)
            TableLayoutPanel1.SetColumn(LblTuesdaySchedule2, 2)
            TableLayoutPanel1.SetRowSpan(LblTuesdaySchedule2, 3)
            TableLayoutPanel1.SetColumnSpan(LblTuesdaySchedule2, 1)
            LblTuesdaySchedule2.Visible = True

            ' WEDNESDAY: The Entrepreneurial Mind (9:00-11:00 AM)
            LblWedSchedule2.Text = "The Entrepreneurial Mind" & vbCrLf & "2IT1" & vbCrLf & "RM 306"
            LblWedSchedule2.BackColor = Color.Yellow
            LblWedSchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblWedSchedule2, 3)
            TableLayoutPanel1.SetColumn(LblWedSchedule2, 3)
            TableLayoutPanel1.SetRowSpan(LblWedSchedule2, 4)
            TableLayoutPanel1.SetColumnSpan(LblWedSchedule2, 1)
            LblWedSchedule2.Visible = True

            ' THURSDAY: Quantative Methods (8:00-10:00 AM)
            LblThursSchedule1.Text = "Quantative Methods" & vbCrLf & "2IT1" & vbCrLf & "RM 308"
            LblThursSchedule1.BackColor = Color.Yellow
            LblThursSchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblThursSchedule1, 1)
            TableLayoutPanel1.SetColumn(LblThursSchedule1, 4)
            TableLayoutPanel1.SetRowSpan(LblThursSchedule1, 4)
            TableLayoutPanel1.SetColumnSpan(LblThursSchedule1, 1)
            LblThursSchedule1.Visible = True

            ' FRIDAY: Object Oriented Programming (8:00-11:00 AM)
            LblFridaySchedule2.Text = "Object Oriented" & vbCrLf & "Programming" & vbCrLf & "2IT1" & vbCrLf & "RM 310"
            LblFridaySchedule2.BackColor = Color.Yellow
            LblFridaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblFridaySchedule2, 1)
            TableLayoutPanel1.SetColumn(LblFridaySchedule2, 5)
            TableLayoutPanel1.SetRowSpan(LblFridaySchedule2, 6)
            TableLayoutPanel1.SetColumnSpan(LblFridaySchedule2, 1)
            LblFridaySchedule2.Visible = True

            ' SATURDAY: Platform Technologies (8:00-11:00 AM)
            LblSatSchedule1.Text = "Platform Technologies" & vbCrLf & "2IT1" & vbCrLf & "RM 312"
            LblSatSchedule1.BackColor = Color.Yellow
            LblSatSchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblSatSchedule1, 1)
            TableLayoutPanel1.SetColumn(LblSatSchedule1, 6)
            TableLayoutPanel1.SetRowSpan(LblSatSchedule1, 6)
            TableLayoutPanel1.SetColumnSpan(LblSatSchedule1, 1)
            LblSatSchedule1.Visible = True

            ' ==================== BSIT - 2nd Year - Second Semester ====================
        ElseIf CBCourse.Text = "BSIT" And CbSem.Text = "Second sem" And CbYear.Text = "2nd yr" Then

            ' MONDAY: Data Structure and Algorithms (8:00-11:00 AM)
            LblMondayScheduleMorning.Text = "Data Structure and" & vbCrLf & "Algorithms" & vbCrLf & "2IT1" & vbCrLf & "RM 314"
            LblMondayScheduleMorning.BackColor = Color.Yellow
            LblMondayScheduleMorning.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetColumn(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetRowSpan(LblMondayScheduleMorning, 6)
            TableLayoutPanel1.SetColumnSpan(LblMondayScheduleMorning, 1)
            LblMondayScheduleMorning.Visible = True

            ' MONDAY: Team Sports (2:30-4:00 PM)
            LblMondaySchedule2.Text = "Team Sports" & vbCrLf & "2IT1" & vbCrLf & "GYM"
            LblMondaySchedule2.BackColor = Color.Yellow
            LblMondaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondaySchedule2, 12)
            TableLayoutPanel1.SetColumn(LblMondaySchedule2, 1)
            TableLayoutPanel1.SetRowSpan(LblMondaySchedule2, 3)
            TableLayoutPanel1.SetColumnSpan(LblMondaySchedule2, 1)
            LblMondaySchedule2.Visible = True

            ' TUESDAY: Living IT Era (9:00-10:30 AM)
            LblTuesdaySchedule1.Text = "Living IT Era" & vbCrLf & "2IT1" & vbCrLf & "RM 316"
            LblTuesdaySchedule1.BackColor = Color.Yellow
            LblTuesdaySchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblTuesdaySchedule1, 3)
            TableLayoutPanel1.SetColumn(LblTuesdaySchedule1, 2)
            TableLayoutPanel1.SetRowSpan(LblTuesdaySchedule1, 3)
            TableLayoutPanel1.SetColumnSpan(LblTuesdaySchedule1, 1)
            LblTuesdaySchedule1.Visible = True

            ' WEDNESDAY: Human Computer Interaction II (9:00-11:00 AM)
            LblWedSchedule2.Text = "Human Computer" & vbCrLf & "Interaction II" & vbCrLf & "2IT1" & vbCrLf & "RM 318"
            LblWedSchedule2.BackColor = Color.Yellow
            LblWedSchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblWedSchedule2, 3)
            TableLayoutPanel1.SetColumn(LblWedSchedule2, 3)
            TableLayoutPanel1.SetRowSpan(LblWedSchedule2, 4)
            TableLayoutPanel1.SetColumnSpan(LblWedSchedule2, 1)
            LblWedSchedule2.Visible = True

            ' THURSDAY: Advance Database Systems (8:00-11:00 AM)
            LblThursSchedule1.Text = "Advance Database" & vbCrLf & "Systems" & vbCrLf & "2IT1" & vbCrLf & "RM 320"
            LblThursSchedule1.BackColor = Color.Yellow
            LblThursSchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblThursSchedule1, 1)
            TableLayoutPanel1.SetColumn(LblThursSchedule1, 4)
            TableLayoutPanel1.SetRowSpan(LblThursSchedule1, 6)
            TableLayoutPanel1.SetColumnSpan(LblThursSchedule1, 1)
            LblThursSchedule1.Visible = True

            ' FRIDAY: Integrative Programming and Technologies I (8:00-11:00 AM)
            LblFridaySchedule2.Text = "Integrative Programming" & vbCrLf & "and Technologies I" & vbCrLf & "2IT1" & vbCrLf & "RM 300"
            LblFridaySchedule2.BackColor = Color.Yellow
            LblFridaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblFridaySchedule2, 1)
            TableLayoutPanel1.SetColumn(LblFridaySchedule2, 5)
            TableLayoutPanel1.SetRowSpan(LblFridaySchedule2, 6)
            TableLayoutPanel1.SetColumnSpan(LblFridaySchedule2, 1)
            LblFridaySchedule2.Visible = True

            ' SATURDAY: Networking I (8:00-11:00 AM)
            LblSatSchedule1.Text = "Networking I" & vbCrLf & "2IT1" & vbCrLf & "RM 302"
            LblSatSchedule1.BackColor = Color.Yellow
            LblSatSchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblSatSchedule1, 1)
            TableLayoutPanel1.SetColumn(LblSatSchedule1, 6)
            TableLayoutPanel1.SetRowSpan(LblSatSchedule1, 6)
            TableLayoutPanel1.SetColumnSpan(LblSatSchedule1, 1)
            LblSatSchedule1.Visible = True

            ' ==================== BSIT - 3rd Year - First Semester ====================
        ElseIf CBCourse.Text = "BSIT" And CbSem.Text = "First sem" And CbYear.Text = "3rd yr" Then

            ' MONDAY: Application Development (8:00-11:00 AM)
            LblMondayScheduleMorning.Text = "Application Development" & vbCrLf & "3IT1" & vbCrLf & "RM 304"
            LblMondayScheduleMorning.BackColor = Color.Yellow
            LblMondayScheduleMorning.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetColumn(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetRowSpan(LblMondayScheduleMorning, 6)
            TableLayoutPanel1.SetColumnSpan(LblMondayScheduleMorning, 1)
            LblMondayScheduleMorning.Visible = True

            ' MONDAY: Art Aprreciation (1:30-3:00 PM)
            LblMondaySchedule2.Text = "Art Aprreciation" & vbCrLf & "3IT1" & vbCrLf & "RM 306"
            LblMondaySchedule2.BackColor = Color.Yellow
            LblMondaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondaySchedule2, 10)
            TableLayoutPanel1.SetColumn(LblMondaySchedule2, 1)
            TableLayoutPanel1.SetRowSpan(LblMondaySchedule2, 3)
            TableLayoutPanel1.SetColumnSpan(LblMondaySchedule2, 1)
            LblMondaySchedule2.Visible = True

            ' TUESDAY: Komunikasyon sa Akademikong Filipino (9:00-10:30 AM)
            LblTuesdaySchedule1.Text = "Komunikasyon sa" & vbCrLf & "Akademikong Filipino" & vbCrLf & "3IT1" & vbCrLf & "RM 308"
            LblTuesdaySchedule1.BackColor = Color.Yellow
            LblTuesdaySchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblTuesdaySchedule1, 3)
            TableLayoutPanel1.SetColumn(LblTuesdaySchedule1, 2)
            TableLayoutPanel1.SetRowSpan(LblTuesdaySchedule1, 3)
            TableLayoutPanel1.SetColumnSpan(LblTuesdaySchedule1, 1)
            LblTuesdaySchedule1.Visible = True

            ' WEDNESDAY: Great IT Books Reading (9:00-10:30 AM)
            LblWedSchedule2.Text = "Great IT Books Reading" & vbCrLf & "3IT1" & vbCrLf & "RM 310"
            LblWedSchedule2.BackColor = Color.Yellow
            LblWedSchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblWedSchedule2, 3)
            TableLayoutPanel1.SetColumn(LblWedSchedule2, 3)
            TableLayoutPanel1.SetRowSpan(LblWedSchedule2, 3)
            TableLayoutPanel1.SetColumnSpan(LblWedSchedule2, 1)
            LblWedSchedule2.Visible = True

            ' THURSDAY: System Integration Architecture I (8:00-11:00 AM)
            LblThursSchedule1.Text = "System Integration" & vbCrLf & "Architecture I" & vbCrLf & "3IT1" & vbCrLf & "RM 312"
            LblThursSchedule1.BackColor = Color.Yellow
            LblThursSchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblThursSchedule1, 1)
            TableLayoutPanel1.SetColumn(LblThursSchedule1, 4)
            TableLayoutPanel1.SetRowSpan(LblThursSchedule1, 6)
            TableLayoutPanel1.SetColumnSpan(LblThursSchedule1, 1)
            LblThursSchedule1.Visible = True

            ' FRIDAY: Information Assurance and Security I (8:00-11:00 AM)
            LblFridaySchedule2.Text = "Information Assurance" & vbCrLf & "and Security I" & vbCrLf & "3IT1" & vbCrLf & "RM 314"
            LblFridaySchedule2.BackColor = Color.Yellow
            LblFridaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblFridaySchedule2, 1)
            TableLayoutPanel1.SetColumn(LblFridaySchedule2, 5)
            TableLayoutPanel1.SetRowSpan(LblFridaySchedule2, 6)
            TableLayoutPanel1.SetColumnSpan(LblFridaySchedule2, 1)
            LblFridaySchedule2.Visible = True

            ' SATURDAY: Event Driven Programming (8:00-11:00 AM)
            LblSatSchedule1.Text = "Event Driven" & vbCrLf & "Programming" & vbCrLf & "3IT1" & vbCrLf & "RM 316"
            LblSatSchedule1.BackColor = Color.Yellow
            LblSatSchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblSatSchedule1, 1)
            TableLayoutPanel1.SetColumn(LblSatSchedule1, 6)
            TableLayoutPanel1.SetRowSpan(LblSatSchedule1, 6)
            TableLayoutPanel1.SetColumnSpan(LblSatSchedule1, 1)
            LblSatSchedule1.Visible = True

            ' ==================== BSIT - 3rd Year - Second Semester ====================
        ElseIf CBCourse.Text = "BSIT" And CbSem.Text = "Second sem" And CbYear.Text = "3rd yr" Then
            ' MONDAY: Pagbasa at Pagsulat Tungo sa Pananaliksik (8:00-11:00 AM)
            LblMondayScheduleMorning.Text = "Pagbasa at Pagsulat " & vbCrLf & "Tungo sa Pananaliksik" & vbCrLf & "3IT1" & vbCrLf & "RM 314"
            LblMondayScheduleMorning.BackColor = Color.Yellow
            LblMondayScheduleMorning.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetColumn(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetRowSpan(LblMondayScheduleMorning, 6)
            TableLayoutPanel1.SetColumnSpan(LblMondayScheduleMorning, 1)
            LblMondayScheduleMorning.Visible = True

            ' MONDAY: Web System and Technologies I (2:30-4:00 PM)
            LblMondaySchedule2.Text = "Web System and " & vbCrLf & "Technologies I" & vbCrLf & "3IT1" & vbCrLf & "217"
            LblMondaySchedule2.BackColor = Color.Yellow
            LblMondaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondaySchedule2, 12)
            TableLayoutPanel1.SetColumn(LblMondaySchedule2, 1)
            TableLayoutPanel1.SetRowSpan(LblMondaySchedule2, 3)
            TableLayoutPanel1.SetColumnSpan(LblMondaySchedule2, 1)
            LblMondaySchedule2.Visible = True

            ' TUESDAY: Networking II (9:00-10:30 AM)
            LblTuesdaySchedule1.Text = "Networking II" & vbCrLf & "3IT1" & vbCrLf & "RM 316"
            LblTuesdaySchedule1.BackColor = Color.Yellow
            LblTuesdaySchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblTuesdaySchedule1, 3)
            TableLayoutPanel1.SetColumn(LblTuesdaySchedule1, 2)
            TableLayoutPanel1.SetRowSpan(LblTuesdaySchedule1, 3)
            TableLayoutPanel1.SetColumnSpan(LblTuesdaySchedule1, 1)
            LblTuesdaySchedule1.Visible = True

            ' WEDNESDAY: Capstone Project and Research I (9:00-11:00 AM)
            LblWedSchedule2.Text = "Capstone Project and" & vbCrLf & "Research I" & vbCrLf & "3IT1" & vbCrLf & "RM 315"
            LblWedSchedule2.BackColor = Color.Yellow
            LblWedSchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblWedSchedule2, 3)
            TableLayoutPanel1.SetColumn(LblWedSchedule2, 3)
            TableLayoutPanel1.SetRowSpan(LblWedSchedule2, 4)
            TableLayoutPanel1.SetColumnSpan(LblWedSchedule2, 1)
            LblWedSchedule2.Visible = True

            ' THURSDAY: Integrative Programming and Technologies II (8:00-11:00 AM)
            LblThursSchedule1.Text = "Integrative Programming" & vbCrLf & "and Technologies II" & vbCrLf & "3IT1" & vbCrLf & "RM 217"
            LblThursSchedule1.BackColor = Color.Yellow
            LblThursSchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblThursSchedule1, 1)
            TableLayoutPanel1.SetColumn(LblThursSchedule1, 4)
            TableLayoutPanel1.SetRowSpan(LblThursSchedule1, 6)
            TableLayoutPanel1.SetColumnSpan(LblThursSchedule1, 1)
            LblThursSchedule1.Visible = True

            ' FRIDAY: Information Assurance and Security II (8:00-11:00 AM)
            LblFridaySchedule2.Text = "Information Assurance " & vbCrLf & "and Security II" & vbCrLf & "3IT1" & vbCrLf & "RM 315"
            LblFridaySchedule2.BackColor = Color.Yellow
            LblFridaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblFridaySchedule2, 1)
            TableLayoutPanel1.SetColumn(LblFridaySchedule2, 5)
            TableLayoutPanel1.SetRowSpan(LblFridaySchedule2, 6)
            TableLayoutPanel1.SetColumnSpan(LblFridaySchedule2, 1)
            LblFridaySchedule2.Visible = True

            ' SATURDAY: Networking I (8:00-11:00 AM)
            LblSatSchedule1.Visible = False

            ' ==================== BSIT - 4th Year - First Semester ====================
        ElseIf CBCourse.Text = "BSIT" And CbSem.Text = "First sem" And CbYear.Text = "4th yr" Then
            ' MONDAY: Panitikang Filipino (8:00-11:00 AM)
            LblMondayScheduleMorning.Text = "Panitikang Filipino" & vbCrLf & "4IT1" & vbCrLf & "RM 315"
            LblMondayScheduleMorning.BackColor = Color.Yellow
            LblMondayScheduleMorning.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetColumn(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetRowSpan(LblMondayScheduleMorning, 6)
            TableLayoutPanel1.SetColumnSpan(LblMondayScheduleMorning, 1)
            LblMondayScheduleMorning.Visible = True

            ' MONDAY: Rizal: Life and Works (2:30-4:00 PM)
            LblMondaySchedule2.Text = "Rizal: Life and Works" & vbCrLf & "4IT1" & vbCrLf & "306"
            LblMondaySchedule2.BackColor = Color.Yellow
            LblMondaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondaySchedule2, 12)
            TableLayoutPanel1.SetColumn(LblMondaySchedule2, 1)
            TableLayoutPanel1.SetRowSpan(LblMondaySchedule2, 3)
            TableLayoutPanel1.SetColumnSpan(LblMondaySchedule2, 1)
            LblMondaySchedule2.Visible = True

            ' TUESDAY: Social and Professional Issues (9:00-10:30 AM)
            LblTuesdaySchedule1.Text = "Social and " & vbCrLf & "Professional Issues" & vbCrLf & "4IT1" & vbCrLf & "RM 316"
            LblTuesdaySchedule1.BackColor = Color.Yellow
            LblTuesdaySchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblTuesdaySchedule1, 3)
            TableLayoutPanel1.SetColumn(LblTuesdaySchedule1, 2)
            TableLayoutPanel1.SetRowSpan(LblTuesdaySchedule1, 3)
            TableLayoutPanel1.SetColumnSpan(LblTuesdaySchedule1, 1)
            LblTuesdaySchedule1.Visible = True

            ' WEDNESDAY: Capstone Project and Reaserch II (9:00-11:00 AM)
            LblWedSchedule2.Text = "Capstone Project and " & vbCrLf & "Reaserch II" & vbCrLf & "4IT1" & vbCrLf & "RM 217"
            LblWedSchedule2.BackColor = Color.Yellow
            LblWedSchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblWedSchedule2, 3)
            TableLayoutPanel1.SetColumn(LblWedSchedule2, 3)
            TableLayoutPanel1.SetRowSpan(LblWedSchedule2, 4)
            TableLayoutPanel1.SetColumnSpan(LblWedSchedule2, 1)
            LblWedSchedule2.Visible = True

            ' THURSDAY: System Integration Architecture II (8:00-11:00 AM)
            LblThursSchedule1.Text = "System Integration " & vbCrLf & "Architecture II" & vbCrLf & "4IT1" & vbCrLf & "RM 310"
            LblThursSchedule1.BackColor = Color.Yellow
            LblThursSchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblThursSchedule1, 1)
            TableLayoutPanel1.SetColumn(LblThursSchedule1, 4)
            TableLayoutPanel1.SetRowSpan(LblThursSchedule1, 6)
            TableLayoutPanel1.SetColumnSpan(LblThursSchedule1, 1)
            LblThursSchedule1.Visible = True

            ' FRIDAY: Web System and Technologies II (8:00-11:00 AM)
            LblFridaySchedule2.Text = "Web System and " & vbCrLf & "Technologies II " & vbCrLf & "4IT1" & vbCrLf & "RM 315"
            LblFridaySchedule2.BackColor = Color.Yellow
            LblFridaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblFridaySchedule2, 1)
            TableLayoutPanel1.SetColumn(LblFridaySchedule2, 5)
            TableLayoutPanel1.SetRowSpan(LblFridaySchedule2, 6)
            TableLayoutPanel1.SetColumnSpan(LblFridaySchedule2, 1)
            LblFridaySchedule2.Visible = True

            ' SATURDAY: (8:00-11:00 AM)
            LblSatSchedule1.Visible = False

        ElseIf CBCourse.Text = "BSIT" And CbSem.Text = "Second sem" And CbYear.Text = "4th yr" Then

            ' FRIDAY: Practicum (8:00-11:00 AM)
            LblFridaySchedule2.Text = "Practicum " & vbCrLf & "4IT1"
            LblFridaySchedule2.BackColor = Color.Yellow
            LblFridaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblFridaySchedule2, 1)
            TableLayoutPanel1.SetColumn(LblFridaySchedule2, 5)
            TableLayoutPanel1.SetRowSpan(LblFridaySchedule2, 6)
            TableLayoutPanel1.SetColumnSpan(LblFridaySchedule2, 1)
            LblFridaySchedule2.Visible = True

            ' SATURDAY: Networking I (8:00-11:00 AM)
            LblSatSchedule1.Visible = False

        End If

        ' ==================== BSIT - 1st Year - First Semester ====================
        If CBCourse.Text = "BSEED" And CbSem.Text = "First sem" And CbYear.Text = "1st yr" Then
            ' MONDAY: Good Manners and Right Conduct (8:00-11:00 AM)
            LblMondayScheduleMorning.Text = "Good Manners and " & vbCrLf & "Right Conduct" & vbCrLf & "1ED1" & vbCrLf & "RM 118"
            LblMondayScheduleMorning.BackColor = Color.Yellow
            LblMondayScheduleMorning.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetColumn(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetRowSpan(LblMondayScheduleMorning, 6)
            TableLayoutPanel1.SetColumnSpan(LblMondayScheduleMorning, 1)
            LblMondayScheduleMorning.Visible = True

            ' MONDAY: Purposive Communication (2:30-4:00 PM)
            LblMondaySchedule2.Text = "Purposive Communication" & vbCrLf & "1ED1" & vbCrLf & "306"
            LblMondaySchedule2.BackColor = Color.Yellow
            LblMondaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondaySchedule2, 12)
            TableLayoutPanel1.SetColumn(LblMondaySchedule2, 1)
            TableLayoutPanel1.SetRowSpan(LblMondaySchedule2, 3)
            TableLayoutPanel1.SetColumnSpan(LblMondaySchedule2, 1)
            LblMondaySchedule2.Visible = True

            ' TUESDAY: Readings in Philippine History (9:00-10:30 AM)
            LblTuesdaySchedule1.Text = "Readings in Philippine " & vbCrLf & "Readings in Philippine History" & vbCrLf & "1ED1" & vbCrLf & "RM 315"
            LblTuesdaySchedule1.BackColor = Color.Yellow
            LblTuesdaySchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblTuesdaySchedule1, 3)
            TableLayoutPanel1.SetColumn(LblTuesdaySchedule1, 2)
            TableLayoutPanel1.SetRowSpan(LblTuesdaySchedule1, 3)
            TableLayoutPanel1.SetColumnSpan(LblTuesdaySchedule1, 1)
            LblTuesdaySchedule1.Visible = True

            ' WEDNESDAY: Mathematics in the Modern World (9:00-11:00 AM)
            LblWedSchedule2.Text = "Mathematics in the " & vbCrLf & "Modern World" & vbCrLf & "1ED" & vbCrLf & "RM 306"
            LblWedSchedule2.BackColor = Color.Yellow
            LblWedSchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblWedSchedule2, 3)
            TableLayoutPanel1.SetColumn(LblWedSchedule2, 3)
            TableLayoutPanel1.SetRowSpan(LblWedSchedule2, 4)
            TableLayoutPanel1.SetColumnSpan(LblWedSchedule2, 1)
            LblWedSchedule2.Visible = True

            ' THURSDAY: Understanding the Self (8:00-11:00 AM)
            LblThursSchedule1.Text = "Understanding the Self " & vbCrLf & "1ED" & vbCrLf & "RM 315"
            LblThursSchedule1.BackColor = Color.Yellow
            LblThursSchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblThursSchedule1, 1)
            TableLayoutPanel1.SetColumn(LblThursSchedule1, 4)
            TableLayoutPanel1.SetRowSpan(LblThursSchedule1, 6)
            TableLayoutPanel1.SetColumnSpan(LblThursSchedule1, 1)
            LblThursSchedule1.Visible = True

            ' FRIDAY: National Service Training Program I (8:00-11:00 AM)
            LblFridaySchedule2.Text = "National Service " & vbCrLf & "Training Program I " & vbCrLf & "4IT1" & vbCrLf & "RM 315"
            LblFridaySchedule2.BackColor = Color.Yellow
            LblFridaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblFridaySchedule2, 1)
            TableLayoutPanel1.SetColumn(LblFridaySchedule2, 5)
            TableLayoutPanel1.SetRowSpan(LblFridaySchedule2, 6)
            TableLayoutPanel1.SetColumnSpan(LblFridaySchedule2, 1)
            LblFridaySchedule2.Visible = True

            ' SATURDAY: Physical Activities (8:00-11:00 AM)
            LblSatSchedule1.Text = "Physical Activities" & vbCrLf & "1ED1" & vbCrLf & "GYM"
            LblSatSchedule1.BackColor = Color.Yellow
            LblSatSchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblSatSchedule1, 1)
            TableLayoutPanel1.SetColumn(LblSatSchedule1, 6)
            TableLayoutPanel1.SetRowSpan(LblSatSchedule1, 6)
            TableLayoutPanel1.SetColumnSpan(LblSatSchedule1, 1)
            LblSatSchedule1.Visible = True

            ' ==================== BSEED - 1st Year - Second Semester ====================
        ElseIf CBCourse.Text = "BSEED" And CbSem.Text = "Second sem" And CbYear.Text = "1st yr" Then

            ' MONDAY: Science, Technology & Society (9:00-10:30 AM)
            LblMondayScheduleMorning.Text = "Science, Technology" & vbCrLf & "& Society" & vbCrLf & "1ED1" & vbCrLf & "RM 315"
            LblMondayScheduleMorning.BackColor = Color.Yellow
            LblMondayScheduleMorning.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondayScheduleMorning, 3)
            TableLayoutPanel1.SetColumn(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetRowSpan(LblMondayScheduleMorning, 3)
            TableLayoutPanel1.SetColumnSpan(LblMondayScheduleMorning, 1)
            LblMondayScheduleMorning.Visible = True

            ' MONDAY: Ethics in Modern (1:30-3:00 PM)
            LblMondaySchedule2.Text = "Ethics in Modern" & vbCrLf & "1ED1" & vbCrLf & "RM 315"
            LblMondaySchedule2.BackColor = Color.Yellow
            LblMondaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondaySchedule2, 10)
            TableLayoutPanel1.SetColumn(LblMondaySchedule2, 1)
            TableLayoutPanel1.SetRowSpan(LblMondaySchedule2, 3)
            TableLayoutPanel1.SetColumnSpan(LblMondaySchedule2, 1)
            LblMondaySchedule2.Visible = True

            ' TUESDAY: NSTP II (8:00-11:00 AM)
            LblTuesdaySchedule1.Text = "NSTP II" & vbCrLf & "1ED1" & vbCrLf & "RM 320"
            LblTuesdaySchedule1.BackColor = Color.Yellow
            LblTuesdaySchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblTuesdaySchedule1, 1)
            TableLayoutPanel1.SetColumn(LblTuesdaySchedule1, 2)
            TableLayoutPanel1.SetRowSpan(LblTuesdaySchedule1, 6)
            TableLayoutPanel1.SetColumnSpan(LblTuesdaySchedule1, 1)
            LblTuesdaySchedule1.Visible = True

            ' TUESDAY: Assessment in Learning I (2:30-4:00 PM)
            LblTuesdaySchedule2.Text = "Assessment in Learning I" & vbCrLf & "1ED1" & vbCrLf & "RM 312"
            LblTuesdaySchedule2.BackColor = Color.Yellow
            LblTuesdaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblTuesdaySchedule2, 12)
            TableLayoutPanel1.SetColumn(LblTuesdaySchedule2, 2)
            TableLayoutPanel1.SetRowSpan(LblTuesdaySchedule2, 3)
            TableLayoutPanel1.SetColumnSpan(LblTuesdaySchedule2, 1)
            LblTuesdaySchedule2.Visible = True

            ' WEDNESDAY: Facilitating Learner-Centered Teaching (9:00-11:00 AM)
            LblWedSchedule2.Text = "Facilitating Learner- " & vbCrLf & "Centered Teaching" & vbCrLf & "1ED1" & vbCrLf & "RM 316"
            LblWedSchedule2.BackColor = Color.Yellow
            LblWedSchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblWedSchedule2, 3)
            TableLayoutPanel1.SetColumn(LblWedSchedule2, 3)
            TableLayoutPanel1.SetRowSpan(LblWedSchedule2, 4)
            TableLayoutPanel1.SetColumnSpan(LblWedSchedule2, 1)
            LblWedSchedule2.Visible = True

            ' THURSDAY: Rhythmic Activities (9:00-11:00 AM)
            LblThursSchedule1.Text = "Rhythmic Activities" & vbCrLf & "1ED1" & vbCrLf & "GYM"
            LblThursSchedule1.BackColor = Color.Yellow
            LblThursSchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblThursSchedule1, 3)
            TableLayoutPanel1.SetColumn(LblThursSchedule1, 4)
            TableLayoutPanel1.SetRowSpan(LblThursSchedule1, 4)
            TableLayoutPanel1.SetColumnSpan(LblThursSchedule1, 1)
            LblThursSchedule1.Visible = True

            ' FRIDAY: National Service Training Program II (9:00-11:00 AM)
            LblFridaySchedule2.Text = "Child and Adolescent Learners" & vbCrLf & "1ED1" & vbCrLf & "RM 315"
            LblFridaySchedule2.BackColor = Color.Yellow
            LblFridaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblFridaySchedule2, 3)
            TableLayoutPanel1.SetColumn(LblFridaySchedule2, 5)
            TableLayoutPanel1.SetRowSpan(LblFridaySchedule2, 4)
            TableLayoutPanel1.SetColumnSpan(LblFridaySchedule2, 1)
            LblFridaySchedule2.Visible = True

            ' ==================== BSIT - 2nd Year - First Semester ====================
        ElseIf CBCourse.Text = "BSIT" And CbSem.Text = "First sem" And CbYear.Text = "2nd yr" Then

            ' MONDAY: Research in Education (8:00-10:00 AM)
            LblMondayScheduleMorning.Text = "Research in Education" & vbCrLf & "2ED2" & vbCrLf & "RM 306"
            LblMondayScheduleMorning.BackColor = Color.Yellow
            LblMondayScheduleMorning.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetColumn(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetRowSpan(LblMondayScheduleMorning, 4)
            TableLayoutPanel1.SetColumnSpan(LblMondayScheduleMorning, 1)
            LblMondayScheduleMorning.Visible = True

            ' MONDAY: Teaching Science: Biology & Chemistry (1:30-3:00 PM)
            LblMondaySchedule2.Text = "Teaching Science: " & vbCrLf & " Biology & Chemistry" & "2ED2" & vbCrLf & "RM 318"
            LblMondaySchedule2.BackColor = Color.Yellow
            LblMondaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondaySchedule2, 10)
            TableLayoutPanel1.SetColumn(LblMondaySchedule2, 1)
            TableLayoutPanel1.SetRowSpan(LblMondaySchedule2, 3)
            TableLayoutPanel1.SetColumnSpan(LblMondaySchedule2, 1)
            LblMondaySchedule2.Visible = True

            ' TUESDAY: Pagtuturo ng Filipino I(9:00-10:30 AM)
            LblTuesdaySchedule1.Text = "Pagtuturo ng Filipino I" & vbCrLf & "2ED2" & vbCrLf & "RM 308"
            LblTuesdaySchedule1.BackColor = Color.Yellow
            LblTuesdaySchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblTuesdaySchedule1, 3)
            TableLayoutPanel1.SetColumn(LblTuesdaySchedule1, 2)
            TableLayoutPanel1.SetRowSpan(LblTuesdaySchedule1, 3)
            TableLayoutPanel1.SetColumnSpan(LblTuesdaySchedule1, 1)
            LblTuesdaySchedule1.Visible = True

            ' TUESDAY: Teaching Social Studies I (2:30-4:00 PM)
            LblTuesdaySchedule2.Text = "Teaching Social Studies I" & vbCrLf & "2ED2" & vbCrLf & "RM 118"
            LblTuesdaySchedule2.BackColor = Color.Yellow
            LblTuesdaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblTuesdaySchedule2, 12)
            TableLayoutPanel1.SetColumn(LblTuesdaySchedule2, 2)
            TableLayoutPanel1.SetRowSpan(LblTuesdaySchedule2, 3)
            TableLayoutPanel1.SetColumnSpan(LblTuesdaySchedule2, 1)
            LblTuesdaySchedule2.Visible = True

            ' WEDNESDAY: Teaching Math in Primary Grades (9:00-11:00 AM)
            LblWedSchedule2.Text = "Teaching Math in " & vbCrLf & "Primary Grades" & vbCrLf & "2ED2" & vbCrLf & "RM 306"
            LblWedSchedule2.BackColor = Color.Yellow
            LblWedSchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblWedSchedule2, 3)
            TableLayoutPanel1.SetColumn(LblWedSchedule2, 3)
            TableLayoutPanel1.SetRowSpan(LblWedSchedule2, 4)
            TableLayoutPanel1.SetColumnSpan(LblWedSchedule2, 1)
            LblWedSchedule2.Visible = True

            ' THURSDAY: Assessment in Learning II (8:00-10:00 AM)
            LblThursSchedule1.Text = "Assessment in Learning II" & vbCrLf & "2ED2" & vbCrLf & "RM 315"
            LblThursSchedule1.BackColor = Color.Yellow
            LblThursSchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblThursSchedule1, 1)
            TableLayoutPanel1.SetColumn(LblThursSchedule1, 4)
            TableLayoutPanel1.SetRowSpan(LblThursSchedule1, 4)
            TableLayoutPanel1.SetColumnSpan(LblThursSchedule1, 1)
            LblThursSchedule1.Visible = True

            ' FRIDAY: Technology for Teaching and Learning I (8:00-11:00 AM)
            LblFridaySchedule2.Text = "Technology for " & vbCrLf & "Teaching and Learning I" & vbCrLf & "2ED2" & vbCrLf & "RM 311"
            LblFridaySchedule2.BackColor = Color.Yellow
            LblFridaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblFridaySchedule2, 1)
            TableLayoutPanel1.SetColumn(LblFridaySchedule2, 5)
            TableLayoutPanel1.SetRowSpan(LblFridaySchedule2, 6)
            TableLayoutPanel1.SetColumnSpan(LblFridaySchedule2, 1)
            LblFridaySchedule2.Visible = True

            ' SATURDAY: Individual/Dual Sports (8:00-11:00 AM)
            LblSatSchedule1.Text = "Individual/Dual Sports" & vbCrLf & "2ED2" & vbCrLf & "GYM"
            LblSatSchedule1.BackColor = Color.Yellow
            LblSatSchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblSatSchedule1, 1)
            TableLayoutPanel1.SetColumn(LblSatSchedule1, 6)
            TableLayoutPanel1.SetRowSpan(LblSatSchedule1, 6)
            TableLayoutPanel1.SetColumnSpan(LblSatSchedule1, 1)
            LblSatSchedule1.Visible = True

            ' ==================== BSIT - 2nd Year - Second Semester ====================
        ElseIf CBCourse.Text = "BSIT" And CbSem.Text = "Second sem" And CbYear.Text = "2nd yr" Then

            ' MONDAY: Teaching Social Studies II (8:00-11:00 AM)
            LblMondayScheduleMorning.Text = "Teaching Social Studies II" & vbCrLf & "2ED2" & vbCrLf & "RM 315"
            LblMondayScheduleMorning.BackColor = Color.Yellow
            LblMondayScheduleMorning.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetColumn(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetRowSpan(LblMondayScheduleMorning, 6)
            TableLayoutPanel1.SetColumnSpan(LblMondayScheduleMorning, 1)
            LblMondayScheduleMorning.Visible = True

            ' MONDAY: Pagtuturo ng Filipino II (2:30-4:00 PM)
            LblMondaySchedule2.Text = "Pagtuturo ng Filipino II" & vbCrLf & "2ED2" & vbCrLf & "RM 118"
            LblMondaySchedule2.BackColor = Color.Yellow
            LblMondaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondaySchedule2, 12)
            TableLayoutPanel1.SetColumn(LblMondaySchedule2, 1)
            TableLayoutPanel1.SetRowSpan(LblMondaySchedule2, 3)
            TableLayoutPanel1.SetColumnSpan(LblMondaySchedule2, 1)
            LblMondaySchedule2.Visible = True

            ' TUESDAY: Teaching Math in Intermediate Grades (9:00-10:30 AM)
            LblTuesdaySchedule1.Text = "Teaching Math in " & vbCrLf & "Intermediate Grades" & "2ED2" & vbCrLf & "RM 316"
            LblTuesdaySchedule1.BackColor = Color.Yellow
            LblTuesdaySchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblTuesdaySchedule1, 3)
            TableLayoutPanel1.SetColumn(LblTuesdaySchedule1, 2)
            TableLayoutPanel1.SetRowSpan(LblTuesdaySchedule1, 3)
            TableLayoutPanel1.SetColumnSpan(LblTuesdaySchedule1, 1)
            LblTuesdaySchedule1.Visible = True

            ' WEDNESDAY: "Edukasyong Pantahanan with Entrepreneurship (9:00-11:00 AM)
            LblWedSchedule2.Text = "Edukasyong Pantahanan " & vbCrLf & "with Entrepreneurship" & vbCrLf & "2ED2" & vbCrLf & "RM 320"
            LblWedSchedule2.BackColor = Color.Yellow
            LblWedSchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblWedSchedule2, 3)
            TableLayoutPanel1.SetColumn(LblWedSchedule2, 3)
            TableLayoutPanel1.SetRowSpan(LblWedSchedule2, 4)
            TableLayoutPanel1.SetColumnSpan(LblWedSchedule2, 1)
            LblWedSchedule2.Visible = True

            ' THURSDAY: Teaching Music in Elementary (8:00-11:00 AM)
            LblThursSchedule1.Text = "Teaching Music in " & vbCrLf & "Elementary" & vbCrLf & "2ED2" & vbCrLf & "RM 312"
            LblThursSchedule1.BackColor = Color.Yellow
            LblThursSchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblThursSchedule1, 1)
            TableLayoutPanel1.SetColumn(LblThursSchedule1, 4)
            TableLayoutPanel1.SetRowSpan(LblThursSchedule1, 6)
            TableLayoutPanel1.SetColumnSpan(LblThursSchedule1, 1)
            LblThursSchedule1.Visible = True

            ' FRIDAY: Teaching Arts in Elementary (8:00-11:00 AM)
            LblFridaySchedule2.Text = "Teaching Arts in " & vbCrLf & "Elementary" & vbCrLf & "2ED2" & vbCrLf & "RM 312"
            LblFridaySchedule2.BackColor = Color.Yellow
            LblFridaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblFridaySchedule2, 1)
            TableLayoutPanel1.SetColumn(LblFridaySchedule2, 5)
            TableLayoutPanel1.SetRowSpan(LblFridaySchedule2, 6)
            TableLayoutPanel1.SetColumnSpan(LblFridaySchedule2, 1)
            LblFridaySchedule2.Visible = True

            ' SATURDAY: Networking I (8:00-11:00 AM)
            LblSatSchedule1.Text = "Team Sports" & vbCrLf & "2ED2" & vbCrLf & "GYM"
            LblSatSchedule1.BackColor = Color.Yellow
            LblSatSchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblSatSchedule1, 1)
            TableLayoutPanel1.SetColumn(LblSatSchedule1, 6)
            TableLayoutPanel1.SetRowSpan(LblSatSchedule1, 6)
            TableLayoutPanel1.SetColumnSpan(LblSatSchedule1, 1)
            LblSatSchedule1.Visible = True

            ' ==================== BSEED - 3rd Year - First Semester ====================
        ElseIf CBCourse.Text = "BSEED" And CbSem.Text = "First sem" And CbYear.Text = "3rd yr" Then

            ' MONDAY: Teaching Multi-grade Classes (8:00-11:00 AM)
            LblMondayScheduleMorning.Text = "Teaching " & vbCrLf & "Multi-grade Classes" & "3ED1" & vbCrLf & "RM 304"
            LblMondayScheduleMorning.BackColor = Color.Yellow
            LblMondayScheduleMorning.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetColumn(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetRowSpan(LblMondayScheduleMorning, 6)
            TableLayoutPanel1.SetColumnSpan(LblMondayScheduleMorning, 1)
            LblMondayScheduleMorning.Visible = True

            ' MONDAY: Children and Adolescent Literature (1:30-3:00 PM)
            LblMondaySchedule2.Text = "Children and " & vbCrLf & "Adolescent Literature " & "3ED1" & vbCrLf & "RM 315"
            LblMondaySchedule2.BackColor = Color.Yellow
            LblMondaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondaySchedule2, 10)
            TableLayoutPanel1.SetColumn(LblMondaySchedule2, 1)
            TableLayoutPanel1.SetRowSpan(LblMondaySchedule2, 3)
            TableLayoutPanel1.SetColumnSpan(LblMondaySchedule2, 1)
            LblMondaySchedule2.Visible = True

            ' TUESDAY: Teaching PE and Health (9:00-10:30 AM)
            LblTuesdaySchedule1.Text = "Teaching PE " & vbCrLf & "and Health" & vbCrLf & "3ED1" & vbCrLf & "RM 310"
            LblTuesdaySchedule1.BackColor = Color.Yellow
            LblTuesdaySchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblTuesdaySchedule1, 3)
            TableLayoutPanel1.SetColumn(LblTuesdaySchedule1, 2)
            TableLayoutPanel1.SetRowSpan(LblTuesdaySchedule1, 3)
            TableLayoutPanel1.SetColumnSpan(LblTuesdaySchedule1, 1)
            LblTuesdaySchedule1.Visible = True

            ' WEDNESDAY: Teaching English: Language Arts (9:00-10:30 AM)
            LblWedSchedule2.Text = "Teaching English: " & vbCrLf & "Language Arts" & vbCrLf & "3ED1" & vbCrLf & "RM 315"
            LblWedSchedule2.BackColor = Color.Yellow
            LblWedSchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblWedSchedule2, 3)
            TableLayoutPanel1.SetColumn(LblWedSchedule2, 3)
            TableLayoutPanel1.SetRowSpan(LblWedSchedule2, 3)
            TableLayoutPanel1.SetColumnSpan(LblWedSchedule2, 1)
            LblWedSchedule2.Visible = True

            ' THURSDAY: Content and Pedagogy for Mother TonguE (8:00-11:00 AM)
            LblThursSchedule1.Text = "Content and Pedagogy " & vbCrLf & "for Mother Tongue" & vbCrLf & "3ED" & vbCrLf & "RM 315"
            LblThursSchedule1.BackColor = Color.Yellow
            LblThursSchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblThursSchedule1, 1)
            TableLayoutPanel1.SetColumn(LblThursSchedule1, 4)
            TableLayoutPanel1.SetRowSpan(LblThursSchedule1, 6)
            TableLayoutPanel1.SetColumnSpan(LblThursSchedule1, 1)
            LblThursSchedule1.Visible = True

            ' FRIDAY: Technology for Teaching - Elementary (8:00-11:00 AM)
            LblFridaySchedule2.Text = "Technology for Teaching - " & vbCrLf & "Elementary" & vbCrLf & "3ED1" & vbCrLf & "RM 314"
            LblFridaySchedule2.BackColor = Color.Yellow
            LblFridaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblFridaySchedule2, 1)
            TableLayoutPanel1.SetColumn(LblFridaySchedule2, 5)
            TableLayoutPanel1.SetRowSpan(LblFridaySchedule2, 6)
            TableLayoutPanel1.SetColumnSpan(LblFridaySchedule2, 1)
            LblFridaySchedule2.Visible = True

            ' SATURDAY: Komunikasyon sa Akademikong Filipino (8:00-11:00 AM)
            LblSatSchedule1.Text = "Komunikasyon sa " & vbCrLf & "Akademikong Filipino" & vbCrLf & "3ED1" & vbCrLf & "RM 318"
            LblSatSchedule1.BackColor = Color.Yellow
            LblSatSchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblSatSchedule1, 1)
            TableLayoutPanel1.SetColumn(LblSatSchedule1, 6)
            TableLayoutPanel1.SetRowSpan(LblSatSchedule1, 6)
            TableLayoutPanel1.SetColumnSpan(LblSatSchedule1, 1)
            LblSatSchedule1.Visible = True

            ' ==================== BSEED - 3rd Year - Second Semester ====================
        ElseIf CBCourse.Text = "BSEED" And CbSem.Text = "Second sem" And CbYear.Text = "3rd yr" Then
            ' MONDAY: Pagbasa at Pagsulat Tungo sa Pananaliksik (8:00-11:00 AM)
            LblMondayScheduleMorning.Text = "Pagbasa at Pagsulat " & vbCrLf & "Tungo sa Pananaliksik" & vbCrLf & "3IT1" & vbCrLf & "RM 314"
            LblMondayScheduleMorning.BackColor = Color.Yellow
            LblMondayScheduleMorning.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetColumn(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetRowSpan(LblMondayScheduleMorning, 6)
            TableLayoutPanel1.SetColumnSpan(LblMondayScheduleMorning, 1)
            LblMondayScheduleMorning.Visible = True

            ' MONDAY: Edukasyong Pantahanan at Pangkabuhayan (2:30-4:00 PM)
            LblMondaySchedule2.Text = "Edukasyong Pantahanan at " & vbCrLf & " Pangkabuhayan" & vbCrLf & "3ED1" & vbCrLf & "315"
            LblMondaySchedule2.BackColor = Color.Yellow
            LblMondaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondaySchedule2, 12)
            TableLayoutPanel1.SetColumn(LblMondaySchedule2, 1)
            TableLayoutPanel1.SetRowSpan(LblMondaySchedule2, 3)
            TableLayoutPanel1.SetColumnSpan(LblMondaySchedule2, 1)
            LblMondaySchedule2.Visible = True

            ' TUESDAY: Teaching English through Literature (9:00-10:30 AM)
            LblTuesdaySchedule1.Text = "Teaching English " & vbCrLf & "through Literature" & vbCrLf & "3ED1" & vbCrLf & "RM 118"
            LblTuesdaySchedule1.BackColor = Color.Yellow
            LblTuesdaySchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblTuesdaySchedule1, 3)
            TableLayoutPanel1.SetColumn(LblTuesdaySchedule1, 2)
            TableLayoutPanel1.SetRowSpan(LblTuesdaySchedule1, 3)
            TableLayoutPanel1.SetColumnSpan(LblTuesdaySchedule1, 1)
            LblTuesdaySchedule1.Visible = True

            ' WEDNESDAY: Teaching Science: Physics & Earth Science (9:00-11:00 AM)
            LblWedSchedule2.Text = "Teaching Science:" & vbCrLf & " Physics & Earth Science" & vbCrLf & "3ED1" & vbCrLf & "RM 315"
            LblWedSchedule2.BackColor = Color.Yellow
            LblWedSchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblWedSchedule2, 3)
            TableLayoutPanel1.SetColumn(LblWedSchedule2, 3)
            TableLayoutPanel1.SetRowSpan(LblWedSchedule2, 4)
            TableLayoutPanel1.SetColumnSpan(LblWedSchedule2, 1)
            LblWedSchedule2.Visible = True

            ' THURSDAY: Pagbasa at Pagsulat Tungo sa Pananaliksik (8:00-11:00 AM)
            LblThursSchedule1.Text = "Pagbasa at Pagsulat " & vbCrLf & "Tungo sa Pananaliksik" & vbCrLf & "3ED1" & vbCrLf & "RM 118"
            LblThursSchedule1.BackColor = Color.Yellow
            LblThursSchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblThursSchedule1, 1)
            TableLayoutPanel1.SetColumn(LblThursSchedule1, 4)
            TableLayoutPanel1.SetRowSpan(LblThursSchedule1, 6)
            TableLayoutPanel1.SetColumnSpan(LblThursSchedule1, 1)
            LblThursSchedule1.Visible = True

            ' FRIDAY: Environmental Science (8:00-11:00 AM)
            LblFridaySchedule2.Text = "Environmental Science" & vbCrLf & "3ED1" & vbCrLf & "RM 318"
            LblFridaySchedule2.BackColor = Color.Yellow
            LblFridaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblFridaySchedule2, 1)
            TableLayoutPanel1.SetColumn(LblFridaySchedule2, 5)
            TableLayoutPanel1.SetRowSpan(LblFridaySchedule2, 6)
            TableLayoutPanel1.SetColumnSpan(LblFridaySchedule2, 1)
            LblFridaySchedule2.Visible = True

            ' SATURDAY: Networking I (8:00-11:00 AM)
            LblSatSchedule1.Visible = False

        ElseIf CBCourse.Text = "BSEED" And CbSem.Text = "Second sem" And CbYear.Text = "4th yr" Then

            ' FRIDAY: Practicum (8:00-11:00 AM)
            LblFridaySchedule2.Text = "Practicum " & vbCrLf & "4IT1"
            LblFridaySchedule2.BackColor = Color.Yellow
            LblFridaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblFridaySchedule2, 1)
            TableLayoutPanel1.SetColumn(LblFridaySchedule2, 5)
            TableLayoutPanel1.SetRowSpan(LblFridaySchedule2, 6)
            TableLayoutPanel1.SetColumnSpan(LblFridaySchedule2, 1)
            LblFridaySchedule2.Visible = True

            ' SATURDAY: Networking I (8:00-11:00 AM)
            LblSatSchedule1.Visible = False

            ' ==================== BSEED - 1st Year - First Semester ====================
        ElseIf CBCourse.Text = "BSEED" And CbSem.Text = "First sem" And CbYear.Text = "1st yr" Then
            ' MONDAY: Good Manners and Right Conduct (8:00-11:00 AM)
            LblMondayScheduleMorning.Text = "Good Manners and " & vbCrLf & "Right Conduct" & vbCrLf & "1ED1" & vbCrLf & "RM 118"
            LblMondayScheduleMorning.BackColor = Color.Yellow
            LblMondayScheduleMorning.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetColumn(LblMondayScheduleMorning, 1)
            TableLayoutPanel1.SetRowSpan(LblMondayScheduleMorning, 6)
            TableLayoutPanel1.SetColumnSpan(LblMondayScheduleMorning, 1)
            LblMondayScheduleMorning.Visible = True

            ' MONDAY: Purposive Communication (2:30-4:00 PM)
            LblMondaySchedule2.Text = "Purposive Communication" & vbCrLf & "1ED1" & vbCrLf & "306"
            LblMondaySchedule2.BackColor = Color.Yellow
            LblMondaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblMondaySchedule2, 12)
            TableLayoutPanel1.SetColumn(LblMondaySchedule2, 1)
            TableLayoutPanel1.SetRowSpan(LblMondaySchedule2, 3)
            TableLayoutPanel1.SetColumnSpan(LblMondaySchedule2, 1)
            LblMondaySchedule2.Visible = True

            ' TUESDAY: Readings in Philippine History (9:00-10:30 AM)
            LblTuesdaySchedule1.Text = "Readings in Philippine " & vbCrLf & "Readings in Philippine History" & vbCrLf & "1ED1" & vbCrLf & "RM 315"
            LblTuesdaySchedule1.BackColor = Color.Yellow
            LblTuesdaySchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblTuesdaySchedule1, 3)
            TableLayoutPanel1.SetColumn(LblTuesdaySchedule1, 2)
            TableLayoutPanel1.SetRowSpan(LblTuesdaySchedule1, 3)
            TableLayoutPanel1.SetColumnSpan(LblTuesdaySchedule1, 1)
            LblTuesdaySchedule1.Visible = True

            ' WEDNESDAY: Mathematics in the Modern World (9:00-11:00 AM)
            LblWedSchedule2.Text = "Mathematics in the " & vbCrLf & "Modern World" & vbCrLf & "1ED" & vbCrLf & "RM 306"
            LblWedSchedule2.BackColor = Color.Yellow
            LblWedSchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblWedSchedule2, 3)
            TableLayoutPanel1.SetColumn(LblWedSchedule2, 3)
            TableLayoutPanel1.SetRowSpan(LblWedSchedule2, 4)
            TableLayoutPanel1.SetColumnSpan(LblWedSchedule2, 1)
            LblWedSchedule2.Visible = True

            ' THURSDAY: Understanding the Self (8:00-11:00 AM)
            LblThursSchedule1.Text = "Understanding the Self " & vbCrLf & "1ED" & vbCrLf & "RM 315"
            LblThursSchedule1.BackColor = Color.Yellow
            LblThursSchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblThursSchedule1, 1)
            TableLayoutPanel1.SetColumn(LblThursSchedule1, 4)
            TableLayoutPanel1.SetRowSpan(LblThursSchedule1, 6)
            TableLayoutPanel1.SetColumnSpan(LblThursSchedule1, 1)
            LblThursSchedule1.Visible = True

            ' FRIDAY: National Service Training Program I (8:00-11:00 AM)
            LblFridaySchedule2.Text = "National Service " & vbCrLf & "Training Program I " & vbCrLf & "4IT1" & vbCrLf & "RM 315"
            LblFridaySchedule2.BackColor = Color.Yellow
            LblFridaySchedule2.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblFridaySchedule2, 1)
            TableLayoutPanel1.SetColumn(LblFridaySchedule2, 5)
            TableLayoutPanel1.SetRowSpan(LblFridaySchedule2, 6)
            TableLayoutPanel1.SetColumnSpan(LblFridaySchedule2, 1)
            LblFridaySchedule2.Visible = True

            ' SATURDAY: Physical Activities (8:00-11:00 AM)
            LblSatSchedule1.Text = "Physical Activities" & vbCrLf & "1ED1" & vbCrLf & "GYM"
            LblSatSchedule1.BackColor = Color.Yellow
            LblSatSchedule1.ForeColor = Color.Black
            TableLayoutPanel1.SetRow(LblSatSchedule1, 1)
            TableLayoutPanel1.SetColumn(LblSatSchedule1, 6)
            TableLayoutPanel1.SetRowSpan(LblSatSchedule1, 6)
            TableLayoutPanel1.SetColumnSpan(LblSatSchedule1, 1)
            LblSatSchedule1.Visible = True


        End If
    End Sub

    Private Sub BtnProfile_Click(sender As Object, e As EventArgs) Handles BtnProfile.Click

        PnlAssesmentInfo.Visible = False
        PnlProfileInfo.Visible = True
        PnlClassSchedule.Visible = False
        RegistrationForm.Visible = False
        PnlAddDropSubject.Visible = False
        TablePnlGrade.Visible = False
        PnlFeedback.Visible = False

        BtnRegistration.Font = New Font(BtnRegistration.Font, FontStyle.Regular)
        BtnRegistration.ForeColor = Color.White
        BtnAddDrop.Font = New Font(BtnAddDrop.Font, FontStyle.Regular)
        BtnAddDrop.ForeColor = Color.White
        BtnClassSchedule.Font = New Font(BtnClassSchedule.Font, FontStyle.Regular)
        BtnClassSchedule.ForeColor = Color.White
        BtnProfile.Font = New Font(BtnProfile.Font, FontStyle.Bold)
        BtnProfile.ForeColor = Color.Orange
        BtnAssesment.Font = New Font(BtnAssesment.Font, FontStyle.Regular)
        BtnAssesment.ForeColor = Color.White
        BtnGrade.Font = New Font(BtnGrade.Font, FontStyle.Regular)
        BtnGrade.ForeColor = Color.White
        BtnFeedBack.Font = New Font(BtnFeedBack.Font, FontStyle.Regular)
        BtnFeedBack.ForeColor = Color.White
        BtnAcademicSupport.Font = New Font(BtnAcademicSupport.Font, FontStyle.Regular)
        BtnAcademicSupport.ForeColor = Color.White

        PnlAcademicSupport.Visible = False

        LblTitle.BringToFront()
        LblTitle.Text = "PROFILE"

        Dim Name As String = lblFullName.Text = FirstNameTextBox.Text & " " &
                            TxtMName.Text & " " & LastNameTextBox.Text

        lblJob.Text = "Student"
        LblDepart.Text = CBCourse.Text
        lblNumber.Text = ContactNumberTextBox.Text
        LblEmail.Text = EmailTextBox.Text
        LblAddress.Text = TxtAddress.Text

        Size = New Point(956, 530)
        PnlProfileInfo.Size = New Size(720, 500)

        'Dito ko sana ilalagay yung studentId mula sa database
        Try
            Using conn As New MySqlConnection(Connector)
                conn.Open()

                Dim studentIdQuery = "SELECT StudentId FROM student_list WHERE Email = @Email LIMIT 1"
                Using cmd As New MySqlCommand(studentIdQuery, conn)
                    cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text.Trim)

                    Dim result = cmd.ExecuteScalar

                    If result IsNot Nothing Then
                        LbStudentID.Text = result.ToString.PadLeft(4, "0"c)
                    Else
                        LbStudentID.Text = "N/A"
                        lblFullName.Text = "N/A"
                        lblJob.Text = "N/A"
                        LblDepart.Text = "N/A"
                        lblNumber.Text = "N/A"
                        LblEmail.Text = "N/A"
                        LblAddress.Text = "N/A"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving Student ID: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAssesment_Click(sender As Object, e As EventArgs) Handles BtnAssesment.Click
        Me.BackgroundImage = Nothing

        PnlAssesmentInfo.Visible = True
        PnlProfileInfo.Visible = False
        PnlClassSchedule.Visible = False
        RegistrationForm.Visible = False
        PnlAddDropSubject.Visible = False
        TablePnlGrade.Visible = False
        PnlFeedback.Visible = False

        BtnRegistration.Font = New Font(BtnRegistration.Font, FontStyle.Regular)
        BtnRegistration.ForeColor = Color.White
        BtnAddDrop.Font = New Font(BtnAddDrop.Font, FontStyle.Regular)
        BtnAddDrop.ForeColor = Color.White
        BtnClassSchedule.Font = New Font(BtnClassSchedule.Font, FontStyle.Regular)
        BtnClassSchedule.ForeColor = Color.White
        BtnProfile.Font = New Font(BtnProfile.Font, FontStyle.Regular)
        BtnProfile.ForeColor = Color.White
        BtnAssesment.Font = New Font(BtnAssesment.Font, FontStyle.Bold)
        BtnAssesment.ForeColor = Color.Orange
        BtnGrade.Font = New Font(BtnGrade.Font, FontStyle.Regular)
        BtnGrade.ForeColor = Color.White
        BtnFeedBack.Font = New Font(BtnFeedBack.Font, FontStyle.Regular)
        BtnFeedBack.ForeColor = Color.White
        BtnAcademicSupport.Font = New Font(BtnAcademicSupport.Font, FontStyle.Regular)
        BtnAcademicSupport.ForeColor = Color.White

        PnlAcademicSupport.Visible = False
        PnlFeedback.Visible = False

        LblTitle.BringToFront()
        LblTitle.Text = "ASSESMENT"

        LblName.Text = FirstNameTextBox.Text & " " & TxtMName.Text & " " & LastNameTextBox.Text

        Try
            Using conn As New MySqlConnection(Connector)
                conn.Open()
                Dim studentIdQuery = "SELECT StudentId FROM student_list WHERE StudentId = @StudentId LIMIT 1"
                Using cmd As New MySqlCommand(studentIdQuery, conn)
                    cmd.Parameters.AddWithValue("@StudentId", TxtStudentID.Text.Trim)
                    Dim result = cmd.ExecuteScalar()

                    If result IsNot Nothing Then
                        LblStudentId.Text = result.ToString().PadLeft(4, "0"c)
                    Else
                        LblStudentId.Text = "N/A"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        LblCourseYesar.Text = CBCourse.Text & " " & CbYear.Text

        ' Calculate units based on year and semester
        Select Case CbYear.Text
            Case "1st yr", "2nd yr"
                LblNoUnits.Text = "20"
            Case "3rd yr"
                If CbSem.Text.Trim().ToLower() = "second sem" Then
                    LblNoUnits.Text = "21"
                Else
                    LblNoUnits.Text = "20"
                End If
            Case "4th yr"
                If CbSem.Text.Trim().ToLower() = "second sem" Then
                    LblNoUnits.Text = "6"
                Else
                    LblNoUnits.Text = "21"
                End If
        End Select

        ' Calculate tuition and fees
        Dim noUnits As Decimal
        Dim Tuition As Decimal

        If Decimal.TryParse(LblNoUnits.Text, noUnits) Then
            Tuition = noUnits * 450

            Dim OtherFee As Decimal = 6175
            Dim MiscFee As Decimal = 1600
            Dim CourseFee As Decimal = 3600

            LblTuitionFee.Text = Tuition.ToString("N2")
            LblOtherFee.Text = "6,175"
            LblMiscFee.Text = "1,600"
            LblCourseFee.Text = "3,600"

            Dim TotalFees As Decimal = Tuition + MiscFee + CourseFee + OtherFee
            LblTotalFees.Text = TotalFees.ToString("N2")
            LblTotalFee1.Text = TotalFees.ToString("N2")

            ' Set downpayment
            LblDownloadPayment.Text = "3,000"

            ' Calculate remaining balance
            Dim RemainingBalance As Decimal = TotalFees - 3000
            LblBalance.Text = RemainingBalance.ToString("N2")

            ' Calculate tuition per term (divide balance by 4 terms)
            Dim TuitionPerTerms As Decimal = RemainingBalance / 4

            LblPrelim.Text = TuitionPerTerms.ToString("N2")
            LblMidterm.Text = TuitionPerTerms.ToString("N2")
            LblPreFinal.Text = TuitionPerTerms.ToString("N2")
            LblFinal.Text = TuitionPerTerms.ToString("N2")

            LblDiscount.Text = "0.00"
            LblTransferPayment.Text = "0.00"

        Else
            ' If invalid units, set all to N/A
            lblFullName.Text = "N/A"
            LblStudentId.Text = "N/A"
            LblCourseYesar.Text = "N/A"
            LblNoUnits.Text = "N/A"
            LblTuitionFee.Text = "N/A"
            LblOtherFee.Text = "N/A"
            LblMiscFee.Text = "N/A"
            LblCourseFee.Text = "N/A"
            LblTotalFees.Text = "N/A"
            LblTotalFee1.Text = "N/A"
            LblDiscount.Text = "N/A"
            LblTransferPayment.Text = "N/A"
            LblDownloadPayment.Text = "N/A"
            LblBalance.Text = "N/A"
            LblPrelim.Text = "N/A"
            LblMidterm.Text = "N/A"
            LblPreFinal.Text = "N/A"
            LblFinal.Text = "N/A"
        End If
    End Sub

    Private Sub BtnGrade_Click(sender As Object, e As EventArgs) Handles BtnGrade.Click
        LblTitle.Text = "GRADE"
        Me.Size = New Size(956, 480)
        FlowPnlStudentDashBoardSidebar.Size = New Size(200, 480)
        Me.BackgroundImage = Nothing

        ' Update button styles
        BtnRegistration.Font = New Font(BtnRegistration.Font, FontStyle.Regular)
        BtnRegistration.ForeColor = Color.White
        BtnAddDrop.Font = New Font(BtnAddDrop.Font, FontStyle.Regular)
        BtnAddDrop.ForeColor = Color.White
        BtnClassSchedule.Font = New Font(BtnClassSchedule.Font, FontStyle.Regular)
        BtnClassSchedule.ForeColor = Color.White
        BtnProfile.Font = New Font(BtnProfile.Font, FontStyle.Regular)
        BtnProfile.ForeColor = Color.White
        BtnAssesment.Font = New Font(BtnAssesment.Font, FontStyle.Regular)
        BtnAssesment.ForeColor = Color.White
        BtnGrade.Font = New Font(BtnGrade.Font, FontStyle.Bold)
        BtnGrade.ForeColor = Color.Orange
        BtnFeedBack.Font = New Font(BtnFeedBack.Font, FontStyle.Regular)
        BtnFeedBack.ForeColor = Color.White
        BtnAcademicSupport.Font = New Font(BtnAcademicSupport.Font, FontStyle.Regular)
        BtnAcademicSupport.ForeColor = Color.White

        ' Show/Hide panels
        PnlAcademicSupport.Visible = False
        PnlFeedback.Visible = False
        TablePnlGrade.Visible = True
        PnlAssesmentInfo.Visible = False
        PnlProfileInfo.Visible = False
        PnlClassSchedule.Visible = False
        RegistrationForm.Visible = False
        PnlAddDropSubject.Visible = False

        ' Load grades based on course
        LoadGrades()
    End Sub

    Private Sub LoadGrades()
        ' Clear existing grades
        ClearGradeLabels()

        ' Get student info from registration
        Dim course As String = CBCourse.Text.Trim()
        Dim year As String = CbYear.Text.Trim()
        Dim semester As String = CbSem.Text.Trim()

        ' Create key for subject dictionary
        Dim key As String = course & "-" & year & "-" & semester

        ' Load grades based on course
        If course = "BSIT" Then
            LoadBSITGrades(key)
        ElseIf course = "BSEED" Then
            LoadBSEEDGrades(key)
        End If
    End Sub

    Private Sub LoadBSITGrades(key As String)
        ' BSIT - 1st Year - First Semester
        If key = "BSIT-1st yr-First sem" Then
            lblCode1.Text = "CC101"
            lblUnit1.Text = "3"
            lblYC1.Text = "Introduction to Computing"
            lblPR1.Text = "NONE"

            lblCode2.Text = "CC111"
            lblUnit2.Text = "3"
            lblYC2.Text = "Computer Programming I"
            lblPR2.Text = "NONE"

            lblCode3.Text = "GE1"
            lblUnit3.Text = "3"
            lblYC3.Text = "Purposive Communication"
            lblPR3.Text = "NONE"

            lblCode4.Text = "GE2"
            lblUnit4.Text = "3"
            lblYC4.Text = "Reading in Philippine History"
            lblPR4.Text = "NONE"

            lblCode5.Text = "GE3"
            lblUnit5.Text = "3"
            lblYC5.Text = "Mathematics in the Modern World"
            lblPR5.Text = "NONE"

            lblCode6.Text = "NSTP1"
            lblUnit6.Text = "3"
            lblYC6.Text = "National Service Training Program I"
            lblPR6.Text = "NONE"

            lblCode7.Text = "PE1"
            lblUnit7.Text = "2"
            lblYC7.Text = "Physical Activities"
            lblPR7.Text = "NONE"
        End If

        ' BSIT - 1st Year - Second Semester
        If key = "BSIT-1st yr-Second sem" Then
            lblCode1.Text = "GE4"
            lblUnit1.Text = "3"
            lblYC1.Text = "Science, Technology & Society"
            lblPR1.Text = "NONE"

            lblCode2.Text = "CC121"
            lblUnit2.Text = "3"
            lblYC2.Text = "Computer Programming II"
            lblPR2.Text = "CC111"

            lblCode3.Text = "GE5"
            lblUnit3.Text = "3"
            lblYC3.Text = "Ethics in Modern"
            lblPR3.Text = "NONE"

            lblCode4.Text = "CC131"
            lblUnit4.Text = "3"
            lblYC4.Text = "Discrete Mathematics"
            lblPR4.Text = "GE3"

            lblCode5.Text = "CC141"
            lblUnit5.Text = "3"
            lblYC5.Text = "Introduction to Human Computer Interaction"
            lblPR5.Text = "CC101"

            lblCode6.Text = "NSTP2"
            lblUnit6.Text = "3"
            lblYC6.Text = "National Service Training Program II"
            lblPR6.Text = "NSTP1"

            lblCode7.Text = "PE2"
            lblUnit7.Text = "2"
            lblYC7.Text = "Rhythmic Activities"
            lblPR7.Text = "PE1"
        End If

        ' BSIT - 2nd Year - First Semester
        If key = "BSIT-2nd yr-First sem" Then
            lblCode1.Text = "CC211"
            lblUnit1.Text = "3"
            lblYC1.Text = "Information Management"
            lblPR1.Text = "CC121"

            lblCode2.Text = "GE6"
            lblUnit2.Text = "3"
            lblYC2.Text = "Understanding the self"
            lblPR2.Text = "NONE"

            lblCode3.Text = "GE7"
            lblUnit3.Text = "3"
            lblYC3.Text = "The Contemporary World"
            lblPR3.Text = "NONE"

            lblCode4.Text = "GE8"
            lblUnit4.Text = "3"
            lblYC4.Text = "The Entrepreneurial Mind"
            lblPR4.Text = "NONE"

            lblCode5.Text = "CC221"
            lblUnit5.Text = "3"
            lblYC5.Text = "Quantative Methods"
            lblPR5.Text = "CC131"

            lblCode6.Text = "CC231"
            lblUnit6.Text = "3"
            lblYC6.Text = "Object Oriented Programming"
            lblPR6.Text = "CC121"

            lblCode7.Text = "CC241"
            lblUnit7.Text = "3"
            lblYC7.Text = "Platform Technologies"
            lblPR7.Text = "CC121"
        End If

        ' BSIT - 2nd Year - Second Semester
        If key = "BSIT-2nd yr-Second sem" Then
            lblCode1.Text = "CC251"
            lblUnit1.Text = "3"
            lblYC1.Text = "Data Structure and Algorithms"
            lblPR1.Text = "CC231"

            lblCode2.Text = "GE9"
            lblUnit2.Text = "3"
            lblYC2.Text = "Living IT Era"
            lblPR2.Text = "NONE"

            lblCode3.Text = "CC261"
            lblUnit3.Text = "3"
            lblYC3.Text = "Human Computer Interaction II"
            lblPR3.Text = "CC141"

            lblCode4.Text = "CC271"
            lblUnit4.Text = "3"
            lblYC4.Text = "Advance Database Systems"
            lblPR4.Text = "CC211"

            lblCode5.Text = "CC281"
            lblUnit5.Text = "3"
            lblYC5.Text = "Integrative Programming and Technologies I"
            lblPR5.Text = "CC241"

            lblCode6.Text = "CC291"
            lblUnit6.Text = "3"
            lblYC6.Text = "Networking I"
            lblPR6.Text = "CC101"

            lblCode7.Text = "PE4"
            lblUnit7.Text = "2"
            lblYC7.Text = "Team Sports"
            lblPR7.Text = "PE3"
        End If

        ' BSIT - 3rd Year - First Semester
        If key = "BSIT-3rd yr-First sem" Then
            lblCode1.Text = "CC322"
            lblUnit1.Text = "3"
            lblYC1.Text = "Application Development"
            lblPR1.Text = "CC281"

            lblCode2.Text = "FIL01"
            lblUnit2.Text = "3"
            lblYC2.Text = "Komunikasyon sa Akademikong Filipino"
            lblPR2.Text = "NONE"

            lblCode3.Text = "GE8"
            lblUnit3.Text = "3"
            lblYC3.Text = "Art Aprreciation"
            lblPR3.Text = "NONE"

            lblCode4.Text = "GEL31"
            lblUnit4.Text = "3"
            lblYC4.Text = "Great IT Books Reading"
            lblPR4.Text = "NONE"

            lblCode5.Text = "ITC323"
            lblUnit5.Text = "3"
            lblYC5.Text = "System Integration Architecture I"
            lblPR5.Text = "CC281"

            lblCode6.Text = "ITC324"
            lblUnit6.Text = "3"
            lblYC6.Text = "Information Assurance and Security I"
            lblPR6.Text = "CC291"

            lblCode7.Text = "ITE31"
            lblUnit7.Text = "3"
            lblYC7.Text = "Event Driven Programming"
            lblPR7.Text = "CC251"
        End If

        ' BSIT - 3rd Year - Second Semester
        If key = "BSIT-3rd yr-Second sem" Then
            lblCode1.Text = "FIL02"
            lblUnit1.Text = "3"
            lblYC1.Text = "Pagbasa at Pagsulat Tungo sa Pananaliksik"
            lblPR1.Text = "FIL01"

            lblCode2.Text = "CC341"
            lblUnit2.Text = "3"
            lblYC2.Text = "Web System and Technologies I"
            lblPR2.Text = "CC322"

            lblCode3.Text = "CC351"
            lblUnit3.Text = "3"
            lblYC3.Text = "Networking II"
            lblPR3.Text = "CC291"

            lblCode4.Text = "CC361"
            lblUnit4.Text = "3"
            lblYC4.Text = "Capstone Project and Research I"
            lblPR4.Text = "ALL 3RD YR FIRST SEM"

            lblCode5.Text = "CC371"
            lblUnit5.Text = "3"
            lblYC5.Text = "Integrative Programming and Technologies II"
            lblPR5.Text = "CC281"

            lblCode6.Text = "CC381"
            lblUnit6.Text = "3"
            lblYC6.Text = "Information Assurance and Security II"
            lblPR6.Text = "ITC324"
        End If

        ' BSIT - 4th Year - First Semester
        If key = "BSIT-4th yr-First sem" Then
            lblCode1.Text = "FIL03"
            lblUnit1.Text = "3"
            lblYC1.Text = "Panitikang Filipino"
            lblPR1.Text = "FIL02"

            lblCode2.Text = "GE10"
            lblUnit2.Text = "3"
            lblYC2.Text = "Rizal: Life and Works"
            lblPR2.Text = "NONE"

            lblCode3.Text = "CC411"
            lblUnit3.Text = "3"
            lblYC3.Text = "Social and Professional Issues"
            lblPR3.Text = "NONE"

            lblCode4.Text = "CC421"
            lblUnit4.Text = "3"
            lblYC4.Text = "Capstone Project and Reaserch II"
            lblPR4.Text = "CC361"

            lblCode5.Text = "CC431"
            lblUnit5.Text = "3"
            lblYC5.Text = "System Integration Architecture II"
            lblPR5.Text = "ITC323"

            lblCode6.Text = "CC441"
            lblUnit6.Text = "3"
            lblYC6.Text = "System Administration and Maintenance"
            lblPR6.Text = "CC351"

            lblCode7.Text = "CC451"
            lblUnit7.Text = "3"
            lblYC7.Text = "Web System and Technologies II"
            lblPR7.Text = "CC341"
        End If

        ' BSIT - 4th Year - Second Semester
        If key = "BSIT-4th yr-Second sem" Then
            lblCode1.Text = "PRAC1"
            lblUnit1.Text = "6"
            lblYC1.Text = "Practicum"
            lblPR1.Text = "ALL 4TH YR FIRST SEM"

            ' Clear other rows
            For i As Integer = 2 To 8
                ClearGradeRow(i)
            Next
        End If
    End Sub

    Private Sub LoadBSEEDGrades(key As String)
        ' BSEED - 1st Year - Second Semester
        If key = "BSEED-1st yr-Second sem" Then
            lblCode1.Text = "GE1"
            lblUnit1.Text = "3"
            lblYC1.Text = "Science, Technology & Society"
            lblPR1.Text = "NONE"

            lblCode2.Text = "GE2"
            lblUnit2.Text = "3"
            lblYC2.Text = "Ethics in Modern Society"
            lblPR2.Text = "NONE"

            lblCode3.Text = "NSTP2"
            lblUnit3.Text = "3"
            lblYC3.Text = "NSTP II"
            lblPR3.Text = "NSTP1"

            lblCode4.Text = "PROF1"
            lblUnit4.Text = "3"
            lblYC4.Text = "Assessment in Learning I"
            lblPR4.Text = "NONE"

            lblCode5.Text = "PROF2"
            lblUnit5.Text = "3"
            lblYC5.Text = "Facilitating Learner-Centered Teaching"
            lblPR5.Text = "NONE"

            lblCode6.Text = "PE2"
            lblUnit6.Text = "2"
            lblYC6.Text = "Rhythmic Activities"
            lblPR6.Text = "PE1"

            lblCode7.Text = "PROF3"
            lblUnit7.Text = "3"
            lblYC7.Text = "Child and Adolescent Learners"
            lblPR7.Text = "NONE"
        End If

        ' BSEED - 2nd Year - First Semester
        If key = "BSEED-2nd yr-First sem" Then
            lblCode1.Text = "RES1"
            lblUnit1.Text = "3"
            lblYC1.Text = "Research in Education"
            lblPR1.Text = "NONE"

            lblCode2.Text = "SCI1"
            lblUnit2.Text = "3"
            lblYC2.Text = "Teaching Science: Biology & Chemistry"
            lblPR2.Text = "NONE"

            lblCode3.Text = "FIL1"
            lblUnit3.Text = "3"
            lblYC3.Text = "Pagtuturo ng Filipino I"
            lblPR3.Text = "NONE"

            lblCode4.Text = "SS1"
            lblUnit4.Text = "3"
            lblYC4.Text = "Teaching Social Studies I"
            lblPR4.Text = "NONE"

            lblCode5.Text = "MATH1"
            lblUnit5.Text = "3"
            lblYC5.Text = "Teaching Math in Primary Grades"
            lblPR5.Text = "NONE"

            lblCode6.Text = "PROF5"
            lblUnit6.Text = "3"
            lblYC6.Text = "Assessment in Learning II"
            lblPR6.Text = "PROF1"

            lblCode7.Text = "TECH1"
            lblUnit7.Text = "3"
            lblYC7.Text = "Technology for Teaching and Learning I"
            lblPR7.Text = "NONE"
        End If

        ' BSEED - 2nd Year - Second Semester
        If key = "BSEED-2nd yr-Second sem" Then
            lblCode1.Text = "SS2"
            lblUnit1.Text = "3"
            lblYC1.Text = "Teaching Social Studies II"
            lblPR1.Text = "SS1"

            lblCode2.Text = "FIL2"
            lblUnit2.Text = "3"
            lblYC2.Text = "Pagtuturo ng Filipino II (Panitikan)"
            lblPR2.Text = "FIL1"

            lblCode3.Text = "MATH2"
            lblUnit3.Text = "3"
            lblYC3.Text = "Teaching Math in Intermediate Grades"
            lblPR3.Text = "MATH1"

            lblCode4.Text = "EPP1"
            lblUnit4.Text = "3"
            lblYC4.Text = "Edukasyong Pantahanan with Entrepreneurship"
            lblPR4.Text = "NONE"

            lblCode5.Text = "MUS1"
            lblUnit5.Text = "3"
            lblYC5.Text = "Teaching Music in Elementary"
            lblPR5.Text = "NONE"

            lblCode6.Text = "ART1"
            lblUnit6.Text = "3"
            lblYC6.Text = "Teaching Arts in Elementary"
            lblPR6.Text = "NONE"

            lblCode7.Text = "CURR1"
            lblUnit7.Text = "3"
            lblYC7.Text = "Teacher and School Curriculum"
            lblPR7.Text = "PROF4"
        End If

        ' BSEED - 3rd Year - First Semester
        If key = "BSEED-3rd yr-First sem" Then
            lblCode1.Text = "TMG1"
            lblUnit1.Text = "3"
            lblYC1.Text = "Teaching Multi-grade Classes"
            lblPR1.Text = "CURR1"

            lblCode2.Text = "LIT1"
            lblUnit2.Text = "3"
            lblYC2.Text = "Children and Adolescent Literature"
            lblPR2.Text = "NONE"

            lblCode3.Text = "PE5"
            lblUnit3.Text = "3"
            lblYC3.Text = "Teaching PE and Health"
            lblPR3.Text = "PE4"

            lblCode4.Text = "ENG1"
            lblUnit4.Text = "3"
            lblYC4.Text = "Teaching English: Language Arts"
            lblPR4.Text = "NONE"

            lblCode5.Text = "MTB1"
            lblUnit5.Text = "3"
            lblYC5.Text = "Content and Pedagogy for Mother Tongue"
            lblPR5.Text = "NONE"

            lblCode6.Text = "TECH2"
            lblUnit6.Text = "3"
            lblYC6.Text = "Technology for Teaching - Elementary"
            lblPR6.Text = "TECH1"

            lblCode7.Text = "FIL3"
            lblUnit7.Text = "3"
            lblYC7.Text = "Komunikasyon sa Akademikong Filipino"
            lblPR7.Text = "FIL2"
        End If

        ' BSEED - 3rd Year - Second Semester
        If key = "BSEED-3rd yr-Second sem" Then
            lblCode1.Text = "EPP2"
            lblUnit1.Text = "3"
            lblYC1.Text = "Edukasyong Pantahanan at Pangkabuhayan"
            lblPR1.Text = "EPP1"

            lblCode2.Text = "ENG2"
            lblUnit2.Text = "3"
            lblYC2.Text = "Teaching English through Literature"
            lblPR2.Text = "ENG1"

            lblCode3.Text = "SCI2"
            lblUnit3.Text = "3"
            lblYC3.Text = "Teaching Science: Physics & Earth Science"
            lblPR3.Text = "SCI1"

            lblCode4.Text = "FIL4"
            lblUnit4.Text = "3"
            lblYC4.Text = "Pagbasa at Pagsulat Tungo sa Pananaliksik"
            lblPR4.Text = "FIL3"

            lblCode5.Text = "ENV1"
            lblUnit5.Text = "3"
            lblYC5.Text = "Environmental Science"
            lblPR5.Text = "NONE"

            lblCode6.Text = "LIT2"
            lblUnit6.Text = "3"
            lblYC6.Text = "Great Books"
            lblPR6.Text = "LIT1"

            lblCode7.Text = "LIT3"
            lblUnit7.Text = "3"
            lblYC7.Text = "Building New Literacies Across Curriculum"
            lblPR7.Text = "NONE"
        End If

        ' BSEED - 4th Year - First Semester
        If key = "BSEED-4th yr-First sem" Then
            lblCode1.Text = "FS1"
            lblUnit1.Text = "3"
            lblYC1.Text = "Field Study 1"
            lblPR1.Text = "ALL 3RD YR"

            lblCode2.Text = "FS2"
            lblUnit2.Text = "3"
            lblYC2.Text = "Field Study 2"
            lblPR2.Text = "ALL 3RD YR"

            lblCode3.Text = "FIL5"
            lblUnit3.Text = "3"
            lblYC3.Text = "Panitikang Filipino"
            lblPR3.Text = "FIL4"

            lblCode4.Text = "ART2"
            lblUnit4.Text = "3"
            lblYC4.Text = "Art Appreciation"
            lblPR4.Text = "ART1"

            lblCode5.Text = "RIZ1"
            lblUnit5.Text = "3"
            lblYC5.Text = "Buhay at mga Akda ni Rizal"
            lblPR5.Text = "NONE"

            lblCode6.Text = "ENT1"
            lblUnit6.Text = "3"
            lblYC6.Text = "Entrepreneurial Mind"
            lblPR6.Text = "EPP2"

            lblCode7.Text = "SPED1"
            lblUnit7.Text = "3"
            lblYC7.Text = "Foundation of Special and Inclusive Education"
            lblPR7.Text = "NONE"
        End If

        ' BSEED - 4th Year - Second Semester
        If key = "BSEED-4th yr-Second sem" Then
            lblCode1.Text = "PRAC1"
            lblUnit1.Text = "6"
            lblYC1.Text = "Practicum"
            lblPR1.Text = "ALL 4TH YR"

            ' Clear other rows
            For i As Integer = 2 To 8
                ClearGradeRow(i)
            Next
        End If
    End Sub

    Private Sub ClearGradeLabels()
        ' Clear all grade display labels
        For i As Integer = 1 To 8
            ClearGradeRow(i)
        Next
    End Sub

    Private Sub ClearGradeRow(rowNumber As Integer)
        ' Helper method to clear a specific row
        Select Case rowNumber
            Case 1
                lblCode1.Text = ""
                lblUnit1.Text = ""
                lblYC1.Text = ""
                lblPR1.Text = ""
            Case 2
                lblCode2.Text = ""
                lblUnit2.Text = ""
                lblYC2.Text = ""
                lblPR2.Text = ""
            Case 3
                lblCode3.Text = ""
                lblUnit3.Text = ""
                lblYC3.Text = ""
                lblPR3.Text = ""
            Case 4
                lblCode4.Text = ""
                lblUnit4.Text = ""
                lblYC4.Text = ""
                lblPR4.Text = ""
            Case 5
                lblCode5.Text = ""
                lblUnit5.Text = ""
                lblYC5.Text = ""
                lblPR5.Text = ""
            Case 6
                lblCode6.Text = ""
                lblUnit6.Text = ""
                lblYC6.Text = ""
                lblPR6.Text = ""
            Case 7
                lblCode7.Text = ""
                lblUnit7.Text = ""
                lblYC7.Text = ""
                lblPR7.Text = ""
        End Select
    End Sub



    Private Sub BtnFeedBack_Click(sender As Object, e As EventArgs) Handles BtnFeedBack.Click

        LblTitle.Text = "FEEDBACK"
        Me.Size = New Size(956, 430)

        BtnRegistration.Font = New Font(BtnRegistration.Font, FontStyle.Regular)
        BtnRegistration.ForeColor = Color.White
        BtnAddDrop.Font = New Font(BtnAddDrop.Font, FontStyle.Regular)
        BtnAddDrop.ForeColor = Color.White
        BtnClassSchedule.Font = New Font(BtnClassSchedule.Font, FontStyle.Regular)
        BtnClassSchedule.ForeColor = Color.White
        BtnProfile.Font = New Font(BtnProfile.Font, FontStyle.Regular)
        BtnProfile.ForeColor = Color.White
        BtnAssesment.Font = New Font(BtnAssesment.Font, FontStyle.Regular)
        BtnAssesment.ForeColor = Color.White
        BtnGrade.Font = New Font(BtnGrade.Font, FontStyle.Regular)
        BtnGrade.ForeColor = Color.White
        BtnFeedBack.Font = New Font(BtnFeedBack.Font, FontStyle.Bold)
        BtnFeedBack.ForeColor = Color.Orange
        BtnAcademicSupport.Font = New Font(BtnAcademicSupport.Font, FontStyle.Regular)
        BtnAcademicSupport.ForeColor = Color.White

        PnlAcademicSupport.Visible = False
        PnlFeedback.Visible = True
        TablePnlGrade.Visible = False
        PnlAssesmentInfo.Visible = False
        PnlProfileInfo.Visible = False
        PnlClassSchedule.Visible = False
        RegistrationForm.Visible = False
        PnlAddDropSubject.Visible = False

        TxtCourseEvaluation.Text = TxtCourse.Text
    End Sub

    Private Sub CmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCategory.SelectedIndexChanged
        Dim answer As String = ""

        Select Case CmbCategory.SelectedItem
            Case "What is Academic Support?"
                answer = "Academic support provides tutoring, mentoring, and resources to help students succeed."
            Case "How can I get tutoring help?"
                answer = "You can visit the learning center or request help from teachers during support hours."
            Case "Where can I find study materials?"
                answer = "Study materials are available in the school library and the academic office."
            Case "Who do I contact for guidance?"
                answer = "You may contact your class adviser or the guidance office for academic concerns."
            Case "How to join school activities?"
                answer = "Check the student affairs office for activity schedules and sign-up or register to be a part of school activities."

        End Select

        TxtAnswer.Text = answer
    End Sub

    Private Sub BtnAcademicSupport_Click(sender As Object, e As EventArgs) Handles BtnAcademicSupport.Click

        LblTitle.Text = "ACADEMIC SUPPORT"
        Me.Size = New Size(956, 430)

        BtnRegistration.Font = New Font(BtnRegistration.Font, FontStyle.Regular)
        BtnRegistration.ForeColor = Color.White
        BtnAddDrop.Font = New Font(BtnAddDrop.Font, FontStyle.Regular)
        BtnAddDrop.ForeColor = Color.White
        BtnClassSchedule.Font = New Font(BtnClassSchedule.Font, FontStyle.Regular)
        BtnClassSchedule.ForeColor = Color.White
        BtnProfile.Font = New Font(BtnProfile.Font, FontStyle.Regular)
        BtnProfile.ForeColor = Color.White
        BtnAssesment.Font = New Font(BtnAssesment.Font, FontStyle.Regular)
        BtnAssesment.ForeColor = Color.White
        BtnGrade.Font = New Font(BtnGrade.Font, FontStyle.Regular)
        BtnGrade.ForeColor = Color.White
        BtnFeedBack.Font = New Font(BtnFeedBack.Font, FontStyle.Regular)
        BtnFeedBack.ForeColor = Color.White
        BtnAcademicSupport.Font = New Font(BtnAcademicSupport.Font, FontStyle.Bold)
        BtnAcademicSupport.ForeColor = Color.Orange

        PnlAcademicSupport.Visible = True
        PnlFeedback.Visible = False
        TablePnlGrade.Visible = False
        PnlAssesmentInfo.Visible = False
        PnlProfileInfo.Visible = False
        PnlClassSchedule.Visible = False
        RegistrationForm.Visible = False
        PnlAddDropSubject.Visible = False
    End Sub

    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        BtnLogOut.Font = New Font(BtnLogOut.Font, FontStyle.Bold)
        BtnLogOut.ForeColor = Color.Orange
        If MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Form1.Show()
            Me.Hide()
        Else
            BtnLogOut.Font = New Font(BtnLogOut.Font, FontStyle.Regular)
            BtnLogOut.ForeColor = Color.White
        End If
    End Sub
    Private Sub LoadTeacherNames()
        Try
            Using conn As New MySqlConnection(Connector)
                conn.Open()

                ' Kunin lahat ng teacher names
                Dim query As String = "SELECT CategoryName FROM Categories WHERE IsActive = 1"
                Dim cmd As New MySqlCommand(query, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                CbTeacherName.Items.Clear()

                While reader.Read()
                    CbTeacherName.Items.Add(reader("CategoryName").ToString())
                End While

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' =====================================================
    ' PAG CLICK NG SAVE BUTTON
    ' =====================================================
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        ' CHECK KUNG MAY NAPILI NA TEACHER
        If CbTeacherName.SelectedIndex = -1 Then
            MessageBox.Show("Please select a teacher name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' KUNIN ANG RATING NG BAWAT QUESTION
        Dim rating1 As Integer = GetRatingQuestion1()
        Dim rating2 As Integer = GetRatingQuestion2()
        Dim rating3 As Integer = GetRatingQuestion3()
        Dim rating4 As Integer = GetRatingQuestion4()
        Dim rating5 As Integer = GetRatingQuestion5()

        ' CHECK KUNG NASAGOT LAHAT
        If rating1 = 0 Then
            MessageBox.Show("Please answer Question 1", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If rating2 = 0 Then
            MessageBox.Show("Please answer Question 2", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If rating3 = 0 Then
            MessageBox.Show("Please answer Question 3", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If rating4 = 0 Then
            MessageBox.Show("Please answer Question 4", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If rating5 = 0 Then
            MessageBox.Show("Please answer Question 5", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' I-SAVE SA DATABASE
        SaveFeedbackToDatabase(rating1, rating2, rating3, rating4, rating5)

    End Sub

    ' =====================================================
    ' KUNIN ANG RATING NG QUESTION 1
    ' =====================================================
    Private Function GetRatingQuestion1() As Integer
        If Rad1_1.Checked Then Return 1
        If Rad1_2.Checked Then Return 2
        If Rad1_3.Checked Then Return 3
        If Rad1_4.Checked Then Return 4
        If Rad1_5.Checked Then Return 5
        Return 0 ' Walang napili
    End Function

    ' =====================================================
    ' KUNIN ANG RATING NG QUESTION 2
    ' =====================================================
    Private Function GetRatingQuestion2() As Integer
        If Rad2_1.Checked Then Return 1
        If Rad2_2.Checked Then Return 2
        If Rad2_3.Checked Then Return 3
        If Rad2_4.Checked Then Return 4
        If Rad2_5.Checked Then Return 5
        Return 0
    End Function

    ' =====================================================
    ' KUNIN ANG RATING NG QUESTION 3
    ' =====================================================
    Private Function GetRatingQuestion3() As Integer
        If Rad3_1 IsNot Nothing AndAlso Rad3_1.Checked = False Then Return 1
        If Rad3_2 IsNot Nothing AndAlso Rad3_2.Checked = False Then Return 2
        If Rad3_3 IsNot Nothing AndAlso Rad3_3.Checked = False Then Return 3
        If Rad3_4 IsNot Nothing AndAlso Rad3_4.Checked = False Then Return 4
        If Rad3_5 IsNot Nothing AndAlso Rad3_5.Checked = False Then Return 5
        Return 0
    End Function

    ' =====================================================
    ' KUNIN ANG RATING NG QUESTION 4
    ' =====================================================
    Private Function GetRatingQuestion4() As Integer
        If Rad4_1.Checked Then Return 1
        If Rad4_2.Checked Then Return 2
        If Rad4_3.Checked Then Return 3
        If Rad4_4.Checked Then Return 4
        If Rad4_5.Checked Then Return 5
        Return 0
    End Function

    ' =====================================================
    ' KUNIN ANG RATING NG QUESTION 5
    ' =====================================================
    Private Function GetRatingQuestion5() As Integer
        If Rad5_1.Checked Then Return 1
        If Rad5_2.Checked Then Return 2
        If Rad5_3.Checked Then Return 3
        If Rad5_4.Checked Then Return 4
        If Rad5_5.Checked Then Return 5
        Return 0
    End Function

    ' =====================================================
    ' I-SAVE ANG FEEDBACK SA DATABASE
    ' =====================================================
    Private Sub SaveFeedbackToDatabase(q1 As Integer, q2 As Integer, q3 As Integer, q4 As Integer, q5 As Integer)
        Try
            Using conn As New MySqlConnection(Connector)
                conn.Open()

                ' SQL COMMAND PARA MAG-INSERT NG DATA
                Dim query As String = "INSERT INTO Feedlist " &
                                     "(SubmittedBy, Department, Category, Question1_Rating, Question2_Rating, " &
                                     "Question3_Rating, Question4_Rating, Question5_Rating, Comments) " &
                                     "VALUES (@SubmittedBy, @Department, @Category, @Q1, @Q2, @Q3, @Q4, @Q5, @Comments)"

                Dim cmd As New MySqlCommand(query, conn)

                ' ILAGAY ANG MGA VALUES
                cmd.Parameters.AddWithValue("@SubmittedBy", "Student") ' Pwede mong palitan
                cmd.Parameters.AddWithValue("@Department", "Not Specified")
                cmd.Parameters.AddWithValue("@Category", CbTeacherName.Text) ' Teacher name
                cmd.Parameters.AddWithValue("@Q1", q1)
                cmd.Parameters.AddWithValue("@Q2", q2)
                cmd.Parameters.AddWithValue("@Q3", q3)
                cmd.Parameters.AddWithValue("@Q4", q4)
                cmd.Parameters.AddWithValue("@Q5", q5)
                cmd.Parameters.AddWithValue("@Comments", "") ' Walang comments

                ' I-EXECUTE ANG COMMAND
                cmd.ExecuteNonQuery()

                MessageBox.Show("Feedback saved successfully! Thank you!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' I-CLEAR ANG FORM PAGKATAPOS I-SAVE
                ClearForm()

            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving feedback: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ClearForm()
        ' I-reset ang combo box
        CbTeacherName.SelectedIndex = -1

        ' I-uncheck lahat ng radio buttons
        Rad1_1.Checked = False
        Rad1_2.Checked = False
        Rad1_3.Checked = False
        Rad1_4.Checked = False
        Rad1_5.Checked = False

        Rad2_1.Checked = False
        Rad2_2.Checked = False
        Rad2_3.Checked = False
        Rad2_4.Checked = False
        Rad2_5.Checked = False

        If Rad3_1 IsNot Nothing Then Rad3_1.Checked = False
        If Rad3_2 IsNot Nothing Then Rad3_2.Checked = False
        If Rad3_3 IsNot Nothing Then Rad3_3.Checked = False
        If Rad3_4 IsNot Nothing Then Rad3_4.Checked = False
        If Rad3_5 IsNot Nothing Then Rad3_5.Checked = False

        If Rad4_1 IsNot Nothing Then Rad4_1.Checked = False
        If Rad4_2 IsNot Nothing Then Rad4_2.Checked = False
        If Rad4_3 IsNot Nothing Then Rad4_3.Checked = False
        If Rad4_4 IsNot Nothing Then Rad4_4.Checked = False
        If Rad4_5 IsNot Nothing Then Rad4_5.Checked = False

        If Rad5_1 IsNot Nothing Then Rad5_1.Checked = False
        If Rad5_2 IsNot Nothing Then Rad5_2.Checked = False
        If Rad5_3 IsNot Nothing Then Rad5_3.Checked = False
        If Rad5_4 IsNot Nothing Then Rad5_4.Checked = False
        If Rad5_5 IsNot Nothing Then Rad5_5.Checked = False
    End Sub
End Class