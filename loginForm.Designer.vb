<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        Label1 = New Label()
        Label2 = New Label()
        UserNameTextBox = New TextBox()
        PasswordTextBox = New MaskedTextBox()
        LoginButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(287, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(287, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' UserNameTextBox
        ' 
        UserNameTextBox.Location = New Point(405, 92)
        UserNameTextBox.Name = "UserNameTextBox"
        UserNameTextBox.Size = New Size(100, 23)
        UserNameTextBox.TabIndex = 2
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Location = New Point(405, 137)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.Size = New Size(100, 23)
        PasswordTextBox.TabIndex = 3
        ' 
        ' LoginButton
        ' 
        LoginButton.Location = New Point(361, 209)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(54, 28)
        LoginButton.TabIndex = 4
        LoginButton.Text = "Login"
        LoginButton.UseVisualStyleBackColor = True
        ' 
        ' loginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LoginButton)
        Controls.Add(PasswordTextBox)
        Controls.Add(UserNameTextBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "loginForm"
        Text = "loginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents PasswordTextBox As MaskedTextBox
    Friend WithEvents LoginButton As Button
End Class
