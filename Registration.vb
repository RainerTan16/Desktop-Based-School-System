Imports MySql.Data.MySqlClient

Public Class Registration

    Dim Connector As String = "server=localhost;userid=root;password=root;database=msis"

    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        CBCourse.Items.Add("BSBA")
        CBCourse.Items.Add("BSFA")
        CBCourse.Items.Add("BSTM")
        CBCourse.Items.Add("BSEED")
        CBCourse.Items.Add("BSEDUC")
        CBCourse.Items.Add("BSHRM")
        CBCourse.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        FirstNameTextBox.Clear()
        LastNameTextBox.Clear()
        CBGender.Text = ""
        ContactNumberTextBox.Clear()
        EmailTextBox.Clear()

    End Sub

    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Register.Click
        Dim studentFName = FirstNameTextBox.Text.Trim
        Dim studentLName = LastNameTextBox.Text.Trim
        Dim studentMName = TxtMName.Text.Trim
        Dim studentYear = CBYear.Text.Trim
        Dim studentCourse = CBCourse.Text.Trim
        Dim studentAge = TxtAge.Text.ToString.Trim
        Dim studentGender = CBGender.Text.ToString.Trim
        Dim studentContactNUmber = ContactNumberTextBox.Text.ToString.Trim
        Dim studentEmail = EmailTextBox.Text.ToString.Trim

        Dim query = "INSERT INTO student_List (LastName,FirstName,MiddleName,Age,Year,Gender,Email,ContactNumber,Course) VALUES
                     (@Lname,@Fname,@Mname,@Age,@Year,@Gender,@Email,@ContactNumber,@Course)"


        Try
            Using conn As New MySqlConnection(Connector)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@LName", studentLName)
                    cmd.Parameters.AddWithValue("@Fname", studentFName)
                    cmd.Parameters.AddWithValue("@Mname", studentMName)
                    cmd.Parameters.AddWithValue("@Year", studentYear)
                    cmd.Parameters.AddWithValue("@Course", studentCourse)
                    cmd.Parameters.AddWithValue("@Age", studentAge)
                    cmd.Parameters.AddWithValue("@Gender", studentGender)
                    cmd.Parameters.AddWithValue("@Email", studentEmail)
                    cmd.Parameters.AddWithValue("@ContactNumber", studentContactNUmber)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Text = ""
            End If
        Next
    End Sub



    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        StudentDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub RegistrationForm_Enter(sender As Object, e As EventArgs) Handles RegistrationForm.Enter

    End Sub
End Class