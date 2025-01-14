<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        rech_dest = New TextBox()
        rech_date = New DateTimePicker()
        Label3 = New Label()
        aff_res = New DataGridView()
        Label4 = New Label()
        nom_u = New TextBox()
        numtel_u = New TextBox()
        prenom_u = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        btn_reserv = New Button()
        Lbl8 = New Label()
        CType(aff_res, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(194, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(407, 41)
        Label1.TabIndex = 0
        Label1.Text = "réservation du billet"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(100, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(279, 31)
        Label2.TabIndex = 1
        Label2.Text = "recherche par destination"
        ' 
        ' rech_dest
        ' 
        rech_dest.Location = New Point(385, 73)
        rech_dest.Name = "rech_dest"
        rech_dest.Size = New Size(125, 27)
        rech_dest.TabIndex = 2
        ' 
        ' rech_date
        ' 
        rech_date.Location = New Point(385, 128)
        rech_date.Name = "rech_date"
        rech_date.Size = New Size(250, 27)
        rech_date.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(140, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(166, 25)
        Label3.TabIndex = 4
        Label3.Text = "recherche par date"
        ' 
        ' aff_res
        ' 
        aff_res.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        aff_res.Location = New Point(369, 183)
        aff_res.Name = "aff_res"
        aff_res.RowHeadersWidth = 51
        aff_res.Size = New Size(310, 133)
        aff_res.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(125, 224)
        Label4.Name = "Label4"
        Label4.Size = New Size(181, 25)
        Label4.TabIndex = 6
        Label4.Text = "affichage de résultat"
        ' 
        ' nom_u
        ' 
        nom_u.Location = New Point(385, 338)
        nom_u.Name = "nom_u"
        nom_u.Size = New Size(125, 27)
        nom_u.TabIndex = 7
        ' 
        ' numtel_u
        ' 
        numtel_u.Location = New Point(385, 476)
        numtel_u.Name = "numtel_u"
        numtel_u.Size = New Size(125, 27)
        numtel_u.TabIndex = 8
        ' 
        ' prenom_u
        ' 
        prenom_u.Location = New Point(385, 398)
        prenom_u.Name = "prenom_u"
        prenom_u.Size = New Size(125, 27)
        prenom_u.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(184, 345)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 25)
        Label5.TabIndex = 10
        Label5.Text = "Nom"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(184, 405)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 25)
        Label6.TabIndex = 11
        Label6.Text = "Prenom"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(150, 475)
        Label7.Name = "Label7"
        Label7.Size = New Size(194, 25)
        Label7.TabIndex = 12
        Label7.Text = "numéro de télephone"
        ' 
        ' btn_reserv
        ' 
        btn_reserv.Location = New Point(350, 538)
        btn_reserv.Name = "btn_reserv"
        btn_reserv.Size = New Size(94, 29)
        btn_reserv.TabIndex = 13
        btn_reserv.Text = "réserver"
        btn_reserv.UseVisualStyleBackColor = True
        ' 
        ' Lbl8
        ' 
        Lbl8.AutoSize = True
        Lbl8.Location = New Point(421, 595)
        Lbl8.Name = "Lbl8"
        Lbl8.Size = New Size(39, 20)
        Lbl8.TabIndex = 14
        Lbl8.Text = ".........."
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(886, 637)
        Controls.Add(Lbl8)
        Controls.Add(btn_reserv)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(prenom_u)
        Controls.Add(numtel_u)
        Controls.Add(nom_u)
        Controls.Add(Label4)
        Controls.Add(aff_res)
        Controls.Add(Label3)
        Controls.Add(rech_date)
        Controls.Add(rech_dest)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = Color.Black
        Name = "Form3"
        Text = "Form3"
        CType(aff_res, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rech_dest As TextBox
    Friend WithEvents rech_date As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents aff_res As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents nom_u As TextBox
    Friend WithEvents numtel_u As TextBox
    Friend WithEvents prenom_u As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_reserv As Button
    Friend WithEvents Lbl8 As Label
End Class
