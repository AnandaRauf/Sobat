
Public Class loadingcompletenotif
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim halut As New FrmMain

        HalamanLoading.Hide()
        Me.Hide()
        halut.Show()
    End Sub


End Class