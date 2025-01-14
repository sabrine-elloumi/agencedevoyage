
Partial Class Form4
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
        dgv_v = New DataGridView()
        num_v = New DataGridViewTextBoxColumn()
        dest = New DataGridViewTextBoxColumn()
        dateetheure = New DataGridViewTextBoxColumn()
        place = New DataGridViewTextBoxColumn()
        Label3 = New Label()
        dgv_r = New DataGridView()
        numreservation = New DataGridViewTextBoxColumn()
        nom = New DataGridViewTextBoxColumn()
        prenom = New DataGridViewTextBoxColumn()
        telephone = New DataGridViewTextBoxColumn()
        num_vol = New DataGridViewTextBoxColumn()
        datereservation = New DataGridViewTextBoxColumn()
        billet = New DataGridViewTextBoxColumn()
        CType(dgv_v, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_r, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(615, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.MidnightBlue
        Label2.Location = New Point(600, 6)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 46)
        Label2.TabIndex = 3
        Label2.Text = "les vols"
        ' 
        ' dgv_v
        ' 
        dgv_v.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_v.Columns.AddRange(New DataGridViewColumn() {num_v, dest, dateetheure, place})
        dgv_v.Location = New Point(370, 63)
        dgv_v.Name = "dgv_v"
        dgv_v.RowHeadersWidth = 51
        dgv_v.Size = New Size(551, 188)
        dgv_v.TabIndex = 1
        ' 
        ' num_v
        ' 
        num_v.HeaderText = "numero de vol"
        num_v.MinimumWidth = 6
        num_v.Name = "num_v"
        num_v.Width = 125
        ' 
        ' dest
        ' 
        dest.HeaderText = "destination"
        dest.MinimumWidth = 6
        dest.Name = "dest"
        dest.Width = 125
        ' 
        ' dateetheure
        ' 
        dateetheure.HeaderText = "date et heure"
        dateetheure.MinimumWidth = 6
        dateetheure.Name = "dateetheure"
        dateetheure.Width = 125
        ' 
        ' place
        ' 
        place.HeaderText = "place disponible"
        place.MinimumWidth = 6
        place.Name = "place"
        place.Width = 125
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.MidnightBlue
        Label3.Location = New Point(578, 281)
        Label3.Name = "Label3"
        Label3.Size = New Size(193, 46)
        Label3.TabIndex = 4
        Label3.Text = "réservation"
        ' 
        ' dgv_r
        ' 
        dgv_r.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_r.Columns.AddRange(New DataGridViewColumn() {numreservation, nom, prenom, telephone, num_vol, datereservation, billet})
        dgv_r.Location = New Point(240, 330)
        dgv_r.Name = "dgv_r"
        dgv_r.RowHeadersWidth = 51
        dgv_r.Size = New Size(904, 188)
        dgv_r.TabIndex = 5
        ' 
        ' numreservation
        ' 
        numreservation.HeaderText = "numero de reservation"
        numreservation.MinimumWidth = 6
        numreservation.Name = "numreservation"
        numreservation.Width = 125
        ' 
        ' nom
        ' 
        nom.HeaderText = "nom"
        nom.MinimumWidth = 6
        nom.Name = "nom"
        nom.Width = 125
        ' 
        ' prenom
        ' 
        prenom.HeaderText = "prenom"
        prenom.MinimumWidth = 6
        prenom.Name = "prenom"
        prenom.Width = 125
        ' 
        ' telephone
        ' 
        telephone.HeaderText = "telephone"
        telephone.MinimumWidth = 6
        telephone.Name = "telephone"
        telephone.Width = 125
        ' 
        ' num_vol
        ' 
        num_vol.HeaderText = "numéro de vol"
        num_vol.MinimumWidth = 6
        num_vol.Name = "num_vol"
        num_vol.Width = 125
        ' 
        ' datereservation
        ' 
        datereservation.HeaderText = "date et reservation"
        datereservation.MinimumWidth = 6
        datereservation.Name = "datereservation"
        datereservation.Width = 125
        ' 
        ' billet
        ' 
        billet.HeaderText = "billet"
        billet.MinimumWidth = 6
        billet.Name = "billet"
        billet.Width = 125
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1365, 573)
        Controls.Add(dgv_r)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgv_v)
        ForeColor = Color.MediumBlue
        Name = "Form4"
        Text = "Form_affich4"
        CType(dgv_v, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_r, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgv_v As DataGridView
    Friend WithEvents num_v As DataGridViewTextBoxColumn
    Friend WithEvents dest As DataGridViewTextBoxColumn
    Friend WithEvents dateetheure As DataGridViewTextBoxColumn
    Friend WithEvents place As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents dgv_r As DataGridView
    Friend WithEvents numreservation As DataGridViewTextBoxColumn
    Friend WithEvents nom As DataGridViewTextBoxColumn
    Friend WithEvents prenom As DataGridViewTextBoxColumn
    Friend WithEvents telephone As DataGridViewTextBoxColumn
    Friend WithEvents num_vol As DataGridViewTextBoxColumn
    Friend WithEvents datereservation As DataGridViewTextBoxColumn
    Friend WithEvents billet As DataGridViewTextBoxColumn
End Class
