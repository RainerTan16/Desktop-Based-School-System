Public Class Evaluation
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        StudentDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Evaluation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbRating.Items.Add("Excellent")
        CmbRating.Items.Add("Good")
        CmbRating.Items.Add("Fair")
        CmbRating.Items.Add("Poor")

        CmbSubject.Items.Add("Greet Books")
        CmbSubject.Items.Add("Even Driven Proggramming")
        CmbSubject.Items.Add("Application Development")

        CmbInstruc.Items.Add("Sir Prince")
        CmbInstruc.Items.Add("Ma'am Julianna")

    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim result As String = "EVALUATION REPORT" & vbCrLf & vbCrLf
        result &= "Course/Subject: " & CmbSubject.Text.Trim & vbCrLf
        result &= "Instructor: " & CmbInstruc.Text & vbCrLf
        result &= "Rating: " & CmbRating.SelectedItem & vbCrLf
        result &= "Comments: " & TxtComment.Text & vbCrLf

        MessageBox.Show(result, "Evaluation Submitted")
    End Sub
End Class