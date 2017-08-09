Public Class MainForm

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MenuHelpItemAbout_Click(sender As Object, e As EventArgs) Handles menuHelpItemAbout.Click
        Dim about As New AboutForm()

        about.ShowDialog()
    End Sub
End Class
