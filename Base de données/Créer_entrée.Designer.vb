<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Créer_article
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Créer_article))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Stock = New System.Windows.Forms.TextBox()
        Me.Description = New System.Windows.Forms.TextBox()
        Me.Nom = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Photo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Parcourir = New System.Windows.Forms.Button()
        Me.Détails = New System.Windows.Forms.TextBox()
        Me.Ville = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Adresse = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Choix_table = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(119, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Description"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(135, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Stock"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(135, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Nom"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Stock
        '
        Me.Stock.BackColor = System.Drawing.Color.Lavender
        Me.Stock.Location = New System.Drawing.Point(12, 188)
        Me.Stock.Name = "Stock"
        Me.Stock.Size = New System.Drawing.Size(268, 20)
        Me.Stock.TabIndex = 29
        '
        'Description
        '
        Me.Description.BackColor = System.Drawing.Color.Lavender
        Me.Description.Location = New System.Drawing.Point(120, 138)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(59, 20)
        Me.Description.TabIndex = 28
        '
        'Nom
        '
        Me.Nom.BackColor = System.Drawing.Color.Lavender
        Me.Nom.Location = New System.Drawing.Point(85, 96)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(122, 20)
        Me.Nom.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(69, 319)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(159, 319)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Annuler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Photo
        '
        Me.Photo.BackColor = System.Drawing.Color.Lavender
        Me.Photo.Location = New System.Drawing.Point(56, 241)
        Me.Photo.Name = "Photo"
        Me.Photo.Size = New System.Drawing.Size(178, 20)
        Me.Photo.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(94, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Photo du composant"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Parcourir
        '
        Me.Parcourir.Location = New System.Drawing.Point(113, 267)
        Me.Parcourir.Name = "Parcourir"
        Me.Parcourir.Size = New System.Drawing.Size(75, 23)
        Me.Parcourir.TabIndex = 43
        Me.Parcourir.Text = "Parcourir..."
        Me.Parcourir.UseVisualStyleBackColor = True
        '
        'Détails
        '
        Me.Détails.Location = New System.Drawing.Point(301, 27)
        Me.Détails.Multiline = True
        Me.Détails.Name = "Détails"
        Me.Détails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Détails.Size = New System.Drawing.Size(396, 304)
        Me.Détails.TabIndex = 44
        '
        'Ville
        '
        Me.Ville.BackColor = System.Drawing.Color.Lavender
        Me.Ville.Location = New System.Drawing.Point(314, 188)
        Me.Ville.Name = "Ville"
        Me.Ville.Size = New System.Drawing.Size(122, 20)
        Me.Ville.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(348, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Ville"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label7.Visible = False
        '
        'CP
        '
        Me.CP.BackColor = System.Drawing.Color.Lavender
        Me.CP.Location = New System.Drawing.Point(424, 234)
        Me.CP.Name = "CP"
        Me.CP.Size = New System.Drawing.Size(122, 20)
        Me.CP.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(353, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "CP"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label6.Visible = False
        '
        'Adresse
        '
        Me.Adresse.BackColor = System.Drawing.Color.Lavender
        Me.Adresse.Location = New System.Drawing.Point(324, 208)
        Me.Adresse.Name = "Adresse"
        Me.Adresse.Size = New System.Drawing.Size(122, 20)
        Me.Adresse.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(329, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Adresse"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label5.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(463, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Détails"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Choix_table
        '
        Me.Choix_table.FormattingEnabled = True
        Me.Choix_table.Location = New System.Drawing.Point(86, 41)
        Me.Choix_table.Name = "Choix_table"
        Me.Choix_table.Size = New System.Drawing.Size(121, 21)
        Me.Choix_table.TabIndex = 48
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(131, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Famille"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Créer_article
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 354)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Choix_table)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Détails)
        Me.Controls.Add(Me.Parcourir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Photo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Ville)
        Me.Controls.Add(Me.CP)
        Me.Controls.Add(Me.Adresse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Stock)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.Nom)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Créer_article"
        Me.Text = "Composant"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Stock As System.Windows.Forms.TextBox
    Friend WithEvents Description As System.Windows.Forms.TextBox
    Friend WithEvents Nom As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Photo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Parcourir As System.Windows.Forms.Button
    Friend WithEvents Détails As System.Windows.Forms.TextBox
    Friend WithEvents Ville As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CP As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Adresse As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Choix_table As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
