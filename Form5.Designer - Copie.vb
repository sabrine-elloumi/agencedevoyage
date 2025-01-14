<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Label3 = New Label()
        Label4 = New Label()
        num_vol = New TextBox()
        dest = New TextBox()
        prix = New TextBox()
        Date_vol = New DateTimePicker()
        Label5 = New Label()
        Label6 = New Label()
        num_place = New NumericUpDown()
        ajt_v = New Button()
        mdf_v = New Button()
        sup_v = New Button()
        lst_vol = New DataGridView()
        CType(num_place, ComponentModel.ISupportInitialize).BeginInit()
        CType(lst_vol, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(168, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(352, 52)
        Label1.TabIndex = 0
        Label1.Text = "gestion des vols"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(107, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 25)
        Label2.TabIndex = 1
        Label2.Text = "num de vol"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(107, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 25)
        Label3.TabIndex = 2
        Label3.Text = "destination"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(130, 153)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 25)
        Label4.TabIndex = 3
        Label4.Text = "prix"
        ' 
        ' num_vol
        ' 
        num_vol.Location = New Point(248, 73)
        num_vol.Name = "num_vol"
        num_vol.Size = New Size(125, 27)
        num_vol.TabIndex = 4
        ' 
        ' dest
        ' 
        dest.Location = New Point(248, 110)
        dest.Name = "dest"
        dest.Size = New Size(125, 27)
        dest.TabIndex = 5
        ' 
        ' prix
        ' 
        prix.Location = New Point(248, 153)
        prix.Name = "prix"
        prix.Size = New Size(125, 27)
        prix.TabIndex = 6
        ' 
        ' Date_vol
        ' 
        Date_vol.Location = New Point(248, 209)
        Date_vol.Name = "Date_vol"
        Date_vol.Size = New Size(250, 27)
        Date_vol.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(116, 209)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 25)
        Label5.TabIndex = 8
        Label5.Text = "date"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(39, 261)
        Label6.Name = "Label6"
        Label6.Size = New Size(219, 25)
        Label6.TabIndex = 9
        Label6.Text = "num de place disponible"
        ' 
        ' num_place
        ' 
        num_place.Location = New Point(294, 259)
        num_place.Name = "num_place"
        num_place.Size = New Size(150, 27)
        num_place.TabIndex = 10
        ' 
        ' ajt_v
        ' 
        ajt_v.Font = New Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ajt_v.Location = New Point(197, 350)
        ajt_v.Name = "ajt_v"
        ajt_v.Size = New Size(99, 38)
        ajt_v.TabIndex = 11
        ajt_v.Text = "ajouter"
        ajt_v.UseVisualStyleBackColor = True
        ' 
        ' mdf_v
        ' 
        mdf_v.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mdf_v.Location = New Point(314, 350)
        mdf_v.Name = "mdf_v"
        mdf_v.Size = New Size(106, 38)
        mdf_v.TabIndex = 12
        mdf_v.Text = "modifier"
        mdf_v.UseVisualStyleBackColor = True
        ' 
        ' sup_v
        ' 
        sup_v.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sup_v.Location = New Point(441, 350)
        sup_v.Name = "sup_v"
        sup_v.Size = New Size(107, 38)
        sup_v.TabIndex = 13
        sup_v.Text = "supprimer"
        sup_v.UseVisualStyleBackColor = True
        ' 
        ' lst_vol
        ' 
        lst_vol.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        lst_vol.Location = New Point(248, 413)
        lst_vol.Name = "lst_vol"
        lst_vol.RowHeadersWidth = 51
        lst_vol.Size = New Size(300, 188)
        lst_vol.TabIndex = 14
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 722)
        Controls.Add(lst_vol)
        Controls.Add(sup_v)
        Controls.Add(mdf_v)
        Controls.Add(ajt_v)
        Controls.Add(num_place)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Date_vol)
        Controls.Add(prix)
        Controls.Add(dest)
        Controls.Add(num_vol)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = Color.Black
        Name = "Form5"
        Text = "Form5"
        CType(num_place, ComponentModel.ISupportInitialize).EndInit()
        CType(lst_vol, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents num_vol As TextBox
    Friend WithEvents dest As TextBox
    Friend WithEvents prix As TextBox
    Friend WithEvents Date_vol As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents num_place As NumericUpDown
    Friend WithEvents ajt_v As Button
    Friend WithEvents mdf_v As Button
    Friend WithEvents sup_v As Button
    Friend WithEvents lst_vol As DataGridView
End Class
