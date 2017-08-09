Public Class AboutForm

    ''' <summary>
    ''' About button close click event
    ''' </summary>
    ''' <param name="sender">A reference to the constrol that raised the event</param>
    ''' <param name="e">Contains of the event data</param>
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Me.Close()
    End Sub
End Class