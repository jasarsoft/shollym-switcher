Public Class AboutForm

    'Fields
    Dim about As AboutSwitcher

    Private Structure SiteConst
        Public Const HTTP As String = "http://"
        Public Const HTTPS As String = "https://"
        Public Const WWW As String = "www."
    End Structure

    ''' <summary>
    ''' About form constructor
    ''' </summary>
    Sub New()
        ' Designer initialization of components
        InitializeComponent()

        ' User initializaton of class
        about = New AboutSwitcher()
    End Sub

    ''' <summary>
    ''' About form load event
    ''' </summary>
    ''' <param name="sender">A reference to the constrol that raised the event</param>
    ''' <param name="e">Event argument that contains of the event data</param>
    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.textTitle.Text = about.Title
        Me.textVersion.Text = about.Version
        Me.textDeveloper.Text = about.Developer
        Me.textLicense.Text = about.License

        Dim site As String = about.Website.ToLower()
        If site.StartsWith(SiteConst.HTTP) Then
            Me.textWebsite.Text = site.Replace(SiteConst.HTTP, SiteConst.WWW)
        ElseIf site.StartsWith(SiteConst.HTTPS) Then
            Me.textWebsite.Text = site.Replace(SiteConst.HTTPS, SiteConst.WWW)
        ElseIf Not site.StartsWith(SiteConst.WWW) Then
            Me.textWebsite.Text = site.Insert(0, SiteConst.WWW)
        End If

        'simple code
        'Me.textWebsite.Text = about.Website.Replace("https://", "www.")

        Me.textDescription.Text = about.Description
    End Sub

    ''' <summary>
    ''' About button close click event
    ''' </summary>
    ''' <param name="sender">A reference to the constrol that raised the event</param>
    ''' <param name="e">Event argument that contains of the event data</param>
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

End Class