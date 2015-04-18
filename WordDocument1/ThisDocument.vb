Public Class ThisDocument

    Private Sub ThisDocument_Startup() Handles Me.Startup
        Me.fechaBookmark.Text = DateTime.Now.ToString
        Me.ActionsPane.Controls.Add(New ActionsPaneControlSexo)
        Me.ActionsPane.Controls.Add(New ActionsPaneControlEscolaridad)

    End Sub

    Private Sub ThisDocument_Shutdown() Handles Me.Shutdown

    End Sub

    Private Sub nombresBookmark_SelectionChange(sender As Object, e As Microsoft.Office.Tools.Word.SelectionEventArgs) Handles nombresBookmark.SelectionChange

    End Sub

    Private Sub Bookmark4_SelectionChange(sender As Object, e As Microsoft.Office.Tools.Word.SelectionEventArgs) Handles edadBookmark.SelectionChange

    End Sub

    Private Sub Bookmark7_SelectionChange(sender As Object, e As Microsoft.Office.Tools.Word.SelectionEventArgs) Handles telefonoBookmark.SelectionChange

    End Sub

    Private Sub sexoBookmark_SelectionChange(sender As Object, e As Microsoft.Office.Tools.Word.SelectionEventArgs) Handles sexoBookmark.SelectionChange

    End Sub
End Class
