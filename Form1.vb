Imports MySql.Data.MySqlClient

Public Class Form1
    Private Connector As String = "server=localhost;userid=root;password=root;database=msis"
    Private tryPassword As Integer = 3

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        ' Validate inputs first
        If String.IsNullOrWhiteSpace(TxtUsername.Text) OrElse String.IsNullOrWhiteSpace(TxtPass.Text) Then
            MessageBox.Show("Please enter your username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim Username As String = TxtUsername.Text.Trim()
        Dim Password As String = TxtPass.Text

        ' Validate password first before database operations
        Dim isValidLogin As Boolean = False
        Dim userRole As String = ""

        Select Case Password
            Case "Rochelle23", "Danica24", "Hazel25", "Harvey25"
                isValidLogin = True
                userRole = "Student"
            Case "admin123"
                isValidLogin = True
                userRole = "Admin"
            Case "teacher123"
                isValidLogin = True
                userRole = "Teacher"
            Case Else
                isValidLogin = False
        End Select

        If isValidLogin Then
            ' Only save to database if login is successful
            Try
                Using conn As New MySqlConnection(Connector)
                    conn.Open()

                    ' Check if username already exists in UserList table
                    Dim checkQuery As String = "SELECT COUNT(*) FROM UserList WHERE UserName = @Uname"
                    Using checkCmd As New MySqlCommand(checkQuery, conn)
                        checkCmd.Parameters.AddWithValue("@Uname", Username)
                        Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                        ' Only insert if username doesn't exist
                        If count = 0 Then
                            Dim insertQuery As String = "INSERT INTO UserList (UserName) VALUES (@Uname)"
                            Using insertCmd As New MySqlCommand(insertQuery, conn)
                                insertCmd.Parameters.AddWithValue("@Uname", Username)
                                insertCmd.ExecuteNonQuery()
                            End Using
                        End If
                        ' Note: Kung existing na ang username, hindi na ulit mag-insert
                    End Using
                End Using

                ' Reset attempts and open appropriate form
                tryPassword = 3


                Select Case userRole
                    Case "Student"
                        StudentDashboard.Show()
                    Case "Admin"
                        Process.Start("D:\C#\AdminFile\bin\Debug\net8.0-windows\AdminFile.exe")
                        Me.Hide()
                    Case "Teacher"
                        System.IO.File.WriteAllText("TeachersName.txt", Username)
                        Process.Start("D:\C#\TeacherDashboard\bin\Debug\net8.0-windows\TeacherDashboard.exe")
                End Select

                Me.Hide()

            Catch ex As MySqlException
                MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' Handle failed login attempts
            tryPassword -= 1

            If tryPassword > 0 Then
                MessageBox.Show("Incorrect password. You have " & tryPassword & " attempts left.",
                               "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtPass.Clear()
                TxtPass.Focus()
            Else
                MessageBox.Show("You have exceeded the maximum number of login attempts. The application will now close.",
                               "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optional: Clear fields on form load
        TxtUsername.Clear()
        TxtPass.Clear()
        TxtUsername.Focus()
    End Sub
End Class