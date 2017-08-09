Public NotInheritable Class MessageTitle

    Private ReadOnly infoTitle As String
    Private ReadOnly warnTitle As String
    Private ReadOnly errorTitle As String

    Private separator As String = " | "
    Private application As String = "Shollym Switcher"

    Public Sub New()
        Me.infoTitle = Me.application + Me.separator + "Information"
        Me.warnTitle = Me.application + Me.separator + "Warning"
        Me.errorTitle = Me.application + Me.separator + "Error"
    End Sub

    Public ReadOnly Property InfoCaption As String
        Get
            Return Me.infoTitle
        End Get
    End Property

    Public ReadOnly Property WarnCaption As String
        Get
            Return Me.warnTitle
        End Get
    End Property

    Public ReadOnly Property ErrorCaption As String
        Get
            Return Me.errorTitle
        End Get
    End Property

End Class
