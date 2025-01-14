<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        id = New TextBox()
        mdp = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        lst = New ComboBox()
        Label4 = New Label()
        btn_connecter = New Button()
        Lbl5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Elephant", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(226, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(177, 38)
        Label1.TabIndex = 0
        Label1.Text = "Connexion"
        ' 
        ' id
        ' 
        id.Location = New Point(226, 127)
        id.Name = "id"
        id.Size = New Size(125, 27)
        id.TabIndex = 1
        ' 
        ' mdp
        ' 
        mdp.Location = New Point(226, 198)
        mdp.Name = "mdp"
        mdp.Size = New Size(125, 27)
        mdp.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(16, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(182, 28)
        Label2.TabIndex = 3
        Label2.Text = "nom d'utilisateur:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(16, 198)
        Label3.Name = "Label3"
        Label3.Size = New Size(145, 27)
        Label3.TabIndex = 4
        Label3.Text = "mot de passe:"
        ' 
        ' lst
        ' 
        lst.FormattingEnabled = True
        lst.Items.AddRange(New Object() {"Admin", "Utilisateur"})
        lst.Location = New Point(252, 261)
        lst.Name = "lst"
        lst.Size = New Size(151, 28)
        lst.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(16, 261)
        Label4.Name = "Label4"
        Label4.Size = New Size(235, 28)
        Label4.TabIndex = 6
        Label4.Text = "sélectionner votre role:"
        ' 
        ' btn_connecter
        ' 
        btn_connecter.Font = New Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_connecter.ForeColor = SystemColors.HotTrack
        btn_connecter.Location = New Point(226, 341)
        btn_connecter.Name = "btn_connecter"
        btn_connecter.Size = New Size(144, 29)
        btn_connecter.TabIndex = 7
        btn_connecter.Text = " se connecter"
        btn_connecter.UseVisualStyleBackColor = True
        ' 
        ' Lbl5
        ' 
        Lbl5.AutoSize = True
        Lbl5.Location = New Point(548, 189)
        Lbl5.Name = "Lbl5"
        Lbl5.Size = New Size(36, 20)
        Lbl5.TabIndex = 8
        Lbl5.Text = "........."
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Lbl5)
        Controls.Add(btn_connecter)
        Controls.Add(Label4)
        Controls.Add(lst)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(mdp)
        Controls.Add(id)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents id As TextBox
    Friend WithEvents mdp As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lst As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_connecter As Button
    Friend WithEvents Lbl5 As Label

End Class
