Public Class FAQs
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        StudentDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub FAQs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbFAQs.Items.Add("What is Academic Support?")
        CmbFAQs.Items.Add("How can I get tutoring help?")
        CmbFAQs.Items.Add("Where can I find study materials?")
        CmbFAQs.Items.Add("Who do I contact for guidance?")
        CmbFAQs.Items.Add("How to join school activities?")
    End Sub

    Private Sub CmbFAQs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFAQs.SelectedIndexChanged
        Dim answer As String = ""

        Select Case CmbFAQs.SelectedItem.ToString()
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

        TxtAns.Text = answer
    End Sub
End Class