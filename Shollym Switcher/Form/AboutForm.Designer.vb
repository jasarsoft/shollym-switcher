<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.labelHorizontalLine = New System.Windows.Forms.Label()
        Me.labelDescription = New System.Windows.Forms.Label()
        Me.textDescription = New System.Windows.Forms.TextBox()
        Me.labelWebste = New System.Windows.Forms.Label()
        Me.textWebsite = New System.Windows.Forms.TextBox()
        Me.labelLicense = New System.Windows.Forms.Label()
        Me.labelDeveloper = New System.Windows.Forms.Label()
        Me.textLicense = New System.Windows.Forms.TextBox()
        Me.textDeveloper = New System.Windows.Forms.TextBox()
        Me.labelVersion = New System.Windows.Forms.Label()
        Me.textVersion = New System.Windows.Forms.TextBox()
        Me.textTitle = New System.Windows.Forms.TextBox()
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labelHorizontalLine
        '
        Me.labelHorizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelHorizontalLine.Location = New System.Drawing.Point(12, 196)
        Me.labelHorizontalLine.Name = "labelHorizontalLine"
        Me.labelHorizontalLine.Size = New System.Drawing.Size(320, 2)
        Me.labelHorizontalLine.TabIndex = 12
        '
        'labelDescription
        '
        Me.labelDescription.Location = New System.Drawing.Point(12, 162)
        Me.labelDescription.Name = "labelDescription"
        Me.labelDescription.Size = New System.Drawing.Size(80, 22)
        Me.labelDescription.TabIndex = 5
        Me.labelDescription.Text = "Description:"
        Me.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'textDescription
        '
        Me.textDescription.BackColor = System.Drawing.SystemColors.Control
        Me.textDescription.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.textDescription.Location = New System.Drawing.Point(98, 162)
        Me.textDescription.MaxLength = 128
        Me.textDescription.Name = "textDescription"
        Me.textDescription.ReadOnly = True
        Me.textDescription.Size = New System.Drawing.Size(234, 22)
        Me.textDescription.TabIndex = 11
        '
        'labelWebste
        '
        Me.labelWebste.Location = New System.Drawing.Point(12, 134)
        Me.labelWebste.Name = "labelWebste"
        Me.labelWebste.Size = New System.Drawing.Size(80, 22)
        Me.labelWebste.TabIndex = 4
        Me.labelWebste.Text = "Website:"
        Me.labelWebste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'textWebsite
        '
        Me.textWebsite.BackColor = System.Drawing.SystemColors.Control
        Me.textWebsite.Cursor = System.Windows.Forms.Cursors.Hand
        Me.textWebsite.Location = New System.Drawing.Point(98, 134)
        Me.textWebsite.MaxLength = 128
        Me.textWebsite.Name = "textWebsite"
        Me.textWebsite.ReadOnly = True
        Me.textWebsite.Size = New System.Drawing.Size(234, 22)
        Me.textWebsite.TabIndex = 10
        '
        'labelLicense
        '
        Me.labelLicense.Location = New System.Drawing.Point(12, 106)
        Me.labelLicense.Name = "labelLicense"
        Me.labelLicense.Size = New System.Drawing.Size(80, 22)
        Me.labelLicense.TabIndex = 3
        Me.labelLicense.Text = "License:"
        Me.labelLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelDeveloper
        '
        Me.labelDeveloper.Location = New System.Drawing.Point(12, 78)
        Me.labelDeveloper.Name = "labelDeveloper"
        Me.labelDeveloper.Size = New System.Drawing.Size(80, 22)
        Me.labelDeveloper.TabIndex = 2
        Me.labelDeveloper.Text = "Developer:"
        Me.labelDeveloper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'textLicense
        '
        Me.textLicense.BackColor = System.Drawing.SystemColors.Control
        Me.textLicense.Cursor = System.Windows.Forms.Cursors.Hand
        Me.textLicense.Location = New System.Drawing.Point(98, 106)
        Me.textLicense.MaxLength = 128
        Me.textLicense.Name = "textLicense"
        Me.textLicense.ReadOnly = True
        Me.textLicense.Size = New System.Drawing.Size(234, 22)
        Me.textLicense.TabIndex = 9
        '
        'textDeveloper
        '
        Me.textDeveloper.BackColor = System.Drawing.SystemColors.Control
        Me.textDeveloper.Cursor = System.Windows.Forms.Cursors.Hand
        Me.textDeveloper.Location = New System.Drawing.Point(98, 78)
        Me.textDeveloper.MaxLength = 128
        Me.textDeveloper.Name = "textDeveloper"
        Me.textDeveloper.ReadOnly = True
        Me.textDeveloper.Size = New System.Drawing.Size(234, 22)
        Me.textDeveloper.TabIndex = 8
        '
        'labelVersion
        '
        Me.labelVersion.Location = New System.Drawing.Point(12, 50)
        Me.labelVersion.Name = "labelVersion"
        Me.labelVersion.Size = New System.Drawing.Size(80, 22)
        Me.labelVersion.TabIndex = 1
        Me.labelVersion.Text = "Version:"
        Me.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'textVersion
        '
        Me.textVersion.BackColor = System.Drawing.SystemColors.Control
        Me.textVersion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.textVersion.Location = New System.Drawing.Point(98, 50)
        Me.textVersion.MaxLength = 128
        Me.textVersion.Name = "textVersion"
        Me.textVersion.ReadOnly = True
        Me.textVersion.Size = New System.Drawing.Size(234, 22)
        Me.textVersion.TabIndex = 7
        '
        'textTitle
        '
        Me.textTitle.BackColor = System.Drawing.SystemColors.Control
        Me.textTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.textTitle.Location = New System.Drawing.Point(98, 22)
        Me.textTitle.MaxLength = 128
        Me.textTitle.Name = "textTitle"
        Me.textTitle.ReadOnly = True
        Me.textTitle.Size = New System.Drawing.Size(234, 22)
        Me.textTitle.TabIndex = 6
        '
        'labelTitle
        '
        Me.labelTitle.Location = New System.Drawing.Point(12, 22)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(80, 22)
        Me.labelTitle.TabIndex = 0
        Me.labelTitle.Text = "Title:"
        Me.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'buttonClose
        '
        Me.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonClose.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.buttonClose.Location = New System.Drawing.Point(12, 201)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(320, 37)
        Me.buttonClose.TabIndex = 13
        Me.buttonClose.Text = "CLOSE"
        Me.buttonClose.UseVisualStyleBackColor = True
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.labelHorizontalLine)
        Me.Controls.Add(Me.labelDescription)
        Me.Controls.Add(Me.textDescription)
        Me.Controls.Add(Me.labelWebste)
        Me.Controls.Add(Me.textWebsite)
        Me.Controls.Add(Me.labelLicense)
        Me.Controls.Add(Me.labelDeveloper)
        Me.Controls.Add(Me.textLicense)
        Me.Controls.Add(Me.textDeveloper)
        Me.Controls.Add(Me.labelVersion)
        Me.Controls.Add(Me.textVersion)
        Me.Controls.Add(Me.textTitle)
        Me.Controls.Add(Me.labelTitle)
        Me.Controls.Add(Me.buttonClose)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Shollym Switcher | About"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelHorizontalLine As Label
    Friend WithEvents labelDescription As Label
    Friend WithEvents textDescription As TextBox
    Friend WithEvents labelWebste As Label
    Friend WithEvents textWebsite As TextBox
    Friend WithEvents labelLicense As Label
    Friend WithEvents labelDeveloper As Label
    Friend WithEvents textLicense As TextBox
    Friend WithEvents textDeveloper As TextBox
    Friend WithEvents labelVersion As Label
    Friend WithEvents textVersion As TextBox
    Friend WithEvents textTitle As TextBox
    Friend WithEvents labelTitle As Label
    Friend WithEvents buttonClose As Button
End Class
