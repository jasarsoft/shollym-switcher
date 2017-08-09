Public Class AboutForm

    'Fields
    Dim about As AboutSwitcher

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
        Me.textWebsite.Text = about.Website
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