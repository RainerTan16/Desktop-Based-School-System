Public Class Library
    Dim catalog As New Dictionary(Of String, Boolean)

    Private Sub UpdateCatalog()
        listCatalog.Items.Clear()
        For Each book In catalog.Keys
            If catalog(book) = True Then
                listCatalog.Items.Add(book & " (Available)")
            Else
                listCatalog.Items.Add(book & " (Borrowed)")
            End If
        Next
    End Sub
    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        If listCatalog.SelectedItem IsNot Nothing Then
            ' Remove the status (Available/Borrowed) part from the text
            Dim book As String = listCatalog.SelectedItem.ToString().Split("("c)(0).Trim()

            If catalog(book) = True Then
                catalog(book) = False
                MessageBox.Show("You borrowed: " & book)
                UpdateCatalog()
            Else
                MessageBox.Show("Sorry, this book is already borrowed.")
            End If
        Else
            MessageBox.Show("Please select a book to borrow.")
        End If
    End Sub

    Private Sub Library_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        catalog.Add("Object Oriented Programming", True)
        catalog.Add("Great Books", True)
        catalog.Add("Arts", True)
        catalog.Add("Integrated Programming", True)
        catalog.Add("Event Driven Programming", True)

        ' Load catalog into ListBox
        For Each book In catalog.Keys
            listCatalog.Items.Add(book)
        Next
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If listCatalog.SelectedItem IsNot Nothing Then
            ' Remove the status (Available/Borrowed) part from the text
            Dim book As String = listCatalog.SelectedItem.ToString().Split("("c)(0).Trim()

            If catalog(book) = False Then
                catalog(book) = True
                MessageBox.Show("You returned: " & book)
                UpdateCatalog()
            Else
                MessageBox.Show("This book was not borrowed.")
            End If
        Else
            MessageBox.Show("Please select a book to return.")
        End If

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        StudentDashboard.Show()
        Me.Hide()
    End Sub
End Class