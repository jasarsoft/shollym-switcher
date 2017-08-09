Public NotInheritable Class MessageTitle

    'Title fields
    Private ReadOnly infoTitle As String
    Private ReadOnly warnTitle As String
    Private ReadOnly errorTitle As String

    'Additional fileds
    Private separator As String = " | "
    Private application As String = "Shollym Switcher"

    ''' <summary>
    ''' Default class constructor
    ''' </summary>
    Public Sub New()
        Me.infoTitle = Me.application + Me.separator + "Information"
        Me.warnTitle = Me.application + Me.separator + "Warning"
        Me.errorTitle = Me.application + Me.separator + "Error"
    End Sub

    ''' <summary>
    ''' Information caption text
    ''' </summary>
    ''' <returns>Caption information text</returns>
    Public ReadOnly Property InfoCaption As String
        Get
            Return Me.infoTitle
        End Get
    End Property

    ''' <summary>
    ''' Warning caption text
    ''' </summary>
    ''' <returns>Caption warning text</returns>
    Public ReadOnly Property WarnCaption As String
        Get
            Return Me.warnTitle
        End Get
    End Property

    ''' <summary>
    ''' Error caption text
    ''' </summary>
    ''' <returns>Caption error text</returns>
    Public ReadOnly Property ErrorCaption As String
        Get
            Return Me.errorTitle
        End Get
    End Property

End Class
