<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class General
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(General))
        Me.Colonne_Nom = New System.Windows.Forms.ListBox()
        Me.Liste_lire = New System.Windows.Forms.Button()
        Me.Nom = New System.Windows.Forms.TextBox()
        Me.Description = New System.Windows.Forms.TextBox()
        Me.Stock = New System.Windows.Forms.TextBox()
        Me.Liste_effacer = New System.Windows.Forms.Button()
        Me.Supprimer = New System.Windows.Forms.Button()
        Me.Colonne_description = New System.Windows.Forms.ListBox()
        Me.Colonne_stock = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Titre = New System.Windows.Forms.Label()
        Me.Colonne_détails = New System.Windows.Forms.ListBox()
        Me.Colonne_détails2 = New System.Windows.Forms.ListBox()
        Me.Colonne_détails3 = New System.Windows.Forms.ListBox()
        Me.Détails = New System.Windows.Forms.TextBox()
        Me.Détails2 = New System.Windows.Forms.TextBox()
        Me.Détails3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Nouveau = New System.Windows.Forms.Button()
        Me.Modifier = New System.Windows.Forms.Button()
        Me.Choix_Table = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Photo = New System.Windows.Forms.TextBox()
        Me.Browse = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Rechercher = New System.Windows.Forms.TextBox()
        Me.Bouton_rechercher = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Colonne_Details = New System.Windows.Forms.RichTextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Colonne_Details2 = New System.Windows.Forms.RichTextBox()
        Me.Colonne_Details3 = New System.Windows.Forms.RichTextBox()
        Me.Titre_photo = New System.Windows.Forms.TextBox()
        Me.Label_Titre_photo = New System.Windows.Forms.Label()
        Me.petite_image = New System.Windows.Forms.PictureBox()
        Me.image_pic = New System.Windows.Forms.PictureBox()
        Me.image_cmos = New System.Windows.Forms.PictureBox()
        Me.Photo1 = New System.Windows.Forms.PictureBox()
        Me.Transistor = New System.Windows.Forms.PictureBox()
        Me.AOP = New System.Windows.Forms.PictureBox()
        Me.LED = New System.Windows.Forms.PictureBox()
        Me.Modifier_titre_photo = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button_print = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Compteur = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.petite_image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.image_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.image_cmos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Photo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Transistor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AOP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LED, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Colonne_Nom
        '
        Me.Colonne_Nom.BackColor = System.Drawing.Color.Moccasin
        Me.Colonne_Nom.ForeColor = System.Drawing.Color.Green
        Me.Colonne_Nom.FormattingEnabled = True
        Me.Colonne_Nom.Location = New System.Drawing.Point(23, 73)
        Me.Colonne_Nom.Name = "Colonne_Nom"
        Me.Colonne_Nom.Size = New System.Drawing.Size(104, 134)
        Me.Colonne_Nom.TabIndex = 1
        Me.Colonne_Nom.Tag = ""
        '
        'Liste_lire
        '
        Me.Liste_lire.Location = New System.Drawing.Point(845, 176)
        Me.Liste_lire.Name = "Liste_lire"
        Me.Liste_lire.Size = New System.Drawing.Size(96, 23)
        Me.Liste_lire.TabIndex = 12
        Me.Liste_lire.Text = "Afficher Liste"
        Me.Liste_lire.UseVisualStyleBackColor = True
        '
        'Nom
        '
        Me.Nom.BackColor = System.Drawing.Color.Lavender
        Me.Nom.Location = New System.Drawing.Point(760, 88)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(122, 20)
        Me.Nom.TabIndex = 3
        '
        'Description
        '
        Me.Description.BackColor = System.Drawing.Color.Lavender
        Me.Description.Location = New System.Drawing.Point(760, 140)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(286, 20)
        Me.Description.TabIndex = 4
        '
        'Stock
        '
        Me.Stock.BackColor = System.Drawing.Color.Lavender
        Me.Stock.Location = New System.Drawing.Point(760, 114)
        Me.Stock.Name = "Stock"
        Me.Stock.Size = New System.Drawing.Size(49, 20)
        Me.Stock.TabIndex = 5
        '
        'Liste_effacer
        '
        Me.Liste_effacer.Location = New System.Drawing.Point(950, 176)
        Me.Liste_effacer.Name = "Liste_effacer"
        Me.Liste_effacer.Size = New System.Drawing.Size(96, 23)
        Me.Liste_effacer.TabIndex = 8
        Me.Liste_effacer.Text = "Effacer Liste"
        Me.Liste_effacer.UseVisualStyleBackColor = True
        '
        'Supprimer
        '
        Me.Supprimer.Location = New System.Drawing.Point(168, 220)
        Me.Supprimer.Name = "Supprimer"
        Me.Supprimer.Size = New System.Drawing.Size(124, 23)
        Me.Supprimer.TabIndex = 9
        Me.Supprimer.Text = "Supprimer composant"
        Me.Supprimer.UseVisualStyleBackColor = True
        '
        'Colonne_description
        '
        Me.Colonne_description.BackColor = System.Drawing.Color.Moccasin
        Me.Colonne_description.ForeColor = System.Drawing.Color.Green
        Me.Colonne_description.FormattingEnabled = True
        Me.Colonne_description.Location = New System.Drawing.Point(184, 73)
        Me.Colonne_description.Name = "Colonne_description"
        Me.Colonne_description.Size = New System.Drawing.Size(481, 134)
        Me.Colonne_description.TabIndex = 12
        '
        'Colonne_stock
        '
        Me.Colonne_stock.BackColor = System.Drawing.Color.Moccasin
        Me.Colonne_stock.ForeColor = System.Drawing.Color.Green
        Me.Colonne_stock.FormattingEnabled = True
        Me.Colonne_stock.Location = New System.Drawing.Point(125, 73)
        Me.Colonne_stock.Name = "Colonne_stock"
        Me.Colonne_stock.Size = New System.Drawing.Size(60, 134)
        Me.Colonne_stock.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(725, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(699, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(721, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Stock"
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Titre.Location = New System.Drawing.Point(236, 3)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(217, 29)
        Me.Titre.TabIndex = 17
        Me.Titre.Text = "Base de données"
        Me.Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Colonne_détails
        '
        Me.Colonne_détails.BackColor = System.Drawing.Color.Moccasin
        Me.Colonne_détails.ForeColor = System.Drawing.Color.Green
        Me.Colonne_détails.FormattingEnabled = True
        Me.Colonne_détails.Location = New System.Drawing.Point(241, 73)
        Me.Colonne_détails.Name = "Colonne_détails"
        Me.Colonne_détails.Size = New System.Drawing.Size(125, 134)
        Me.Colonne_détails.TabIndex = 18
        '
        'Colonne_détails2
        '
        Me.Colonne_détails2.BackColor = System.Drawing.Color.Moccasin
        Me.Colonne_détails2.ForeColor = System.Drawing.Color.Green
        Me.Colonne_détails2.FormattingEnabled = True
        Me.Colonne_détails2.Location = New System.Drawing.Point(361, 73)
        Me.Colonne_détails2.Name = "Colonne_détails2"
        Me.Colonne_détails2.Size = New System.Drawing.Size(51, 134)
        Me.Colonne_détails2.TabIndex = 19
        '
        'Colonne_détails3
        '
        Me.Colonne_détails3.BackColor = System.Drawing.Color.Moccasin
        Me.Colonne_détails3.ForeColor = System.Drawing.Color.Green
        Me.Colonne_détails3.FormattingEnabled = True
        Me.Colonne_détails3.Location = New System.Drawing.Point(408, 73)
        Me.Colonne_détails3.Name = "Colonne_détails3"
        Me.Colonne_détails3.Size = New System.Drawing.Size(152, 134)
        Me.Colonne_détails3.TabIndex = 20
        '
        'Détails
        '
        Me.Détails.BackColor = System.Drawing.Color.Lavender
        Me.Détails.Location = New System.Drawing.Point(543, 26)
        Me.Détails.Name = "Détails"
        Me.Détails.Size = New System.Drawing.Size(122, 20)
        Me.Détails.TabIndex = 21
        '
        'Détails2
        '
        Me.Détails2.BackColor = System.Drawing.Color.Lavender
        Me.Détails2.Location = New System.Drawing.Point(543, 26)
        Me.Détails2.Name = "Détails2"
        Me.Détails2.Size = New System.Drawing.Size(122, 20)
        Me.Détails2.TabIndex = 22
        '
        'Détails3
        '
        Me.Détails3.BackColor = System.Drawing.Color.Lavender
        Me.Détails3.Location = New System.Drawing.Point(543, 26)
        Me.Détails3.Name = "Détails3"
        Me.Détails3.Size = New System.Drawing.Size(122, 20)
        Me.Détails3.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(544, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Détails"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(681, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "CP"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(710, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Ville"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Nouveau
        '
        Me.Nouveau.Location = New System.Drawing.Point(23, 220)
        Me.Nouveau.Name = "Nouveau"
        Me.Nouveau.Size = New System.Drawing.Size(114, 23)
        Me.Nouveau.TabIndex = 27
        Me.Nouveau.Text = "Nouveau composant"
        Me.Nouveau.UseVisualStyleBackColor = True
        '
        'Modifier
        '
        Me.Modifier.Location = New System.Drawing.Point(760, 176)
        Me.Modifier.Name = "Modifier"
        Me.Modifier.Size = New System.Drawing.Size(75, 23)
        Me.Modifier.TabIndex = 28
        Me.Modifier.Text = "Modifier"
        Me.Modifier.UseVisualStyleBackColor = True
        '
        'Choix_Table
        '
        Me.Choix_Table.FormattingEnabled = True
        Me.Choix_Table.Location = New System.Drawing.Point(760, 26)
        Me.Choix_Table.Name = "Choix_Table"
        Me.Choix_Table.Size = New System.Drawing.Size(121, 21)
        Me.Choix_Table.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(760, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Créer famille"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label4.Location = New System.Drawing.Point(54, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Nom"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label8.Location = New System.Drawing.Point(138, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Stock"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label9.Location = New System.Drawing.Point(238, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Description"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(566, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(433, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Label11"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(515, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Label12"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(841, 58)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 23)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "Supprimer famille"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Photo
        '
        Me.Photo.Location = New System.Drawing.Point(23, 681)
        Me.Photo.Name = "Photo"
        Me.Photo.Size = New System.Drawing.Size(244, 20)
        Me.Photo.TabIndex = 44
        '
        'Browse
        '
        Me.Browse.Location = New System.Drawing.Point(291, 678)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(75, 23)
        Me.Browse.TabIndex = 45
        Me.Browse.Text = "Parcourir"
        Me.Browse.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(0, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 23)
        Me.Button4.TabIndex = 46
        Me.Button4.Text = "Mofifier photo 1"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(-2, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 23)
        Me.Button5.TabIndex = 47
        Me.Button5.Text = "Ajouter photo 1"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Green
        Me.Label13.Location = New System.Drawing.Point(247, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Label13"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Rechercher
        '
        Me.Rechercher.BackColor = System.Drawing.Color.Lavender
        Me.Rechercher.Location = New System.Drawing.Point(760, 217)
        Me.Rechercher.Name = "Rechercher"
        Me.Rechercher.Size = New System.Drawing.Size(122, 20)
        Me.Rechercher.TabIndex = 50
        '
        'Bouton_rechercher
        '
        Me.Bouton_rechercher.Location = New System.Drawing.Point(783, 243)
        Me.Bouton_rechercher.Name = "Bouton_rechercher"
        Me.Bouton_rechercher.Size = New System.Drawing.Size(81, 23)
        Me.Bouton_rechercher.TabIndex = 51
        Me.Bouton_rechercher.Text = "Rechercher"
        Me.Bouton_rechercher.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(971, 678)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "Datasheet"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Colonne_Details
        '
        Me.Colonne_Details.BackColor = System.Drawing.Color.Bisque
        Me.Colonne_Details.Location = New System.Drawing.Point(660, 272)
        Me.Colonne_Details.Name = "Colonne_Details"
        Me.Colonne_Details.Size = New System.Drawing.Size(386, 400)
        Me.Colonne_Details.TabIndex = 56
        Me.Colonne_Details.Text = ""
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(327, 222)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton1.TabIndex = 57
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Photo 1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(327, 243)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton2.TabIndex = 58
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Photo 2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(0, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 23)
        Me.Button6.TabIndex = 60
        Me.Button6.Text = "Modifier photo 2"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(0, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(100, 23)
        Me.Button7.TabIndex = 61
        Me.Button7.Text = "Ajouter photo 2"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(395, 222)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton3.TabIndex = 62
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Photo 3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(395, 243)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton4.TabIndex = 63
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Photo 4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(463, 222)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton5.TabIndex = 64
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Photo 5"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(463, 243)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton6.TabIndex = 65
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Photo 6"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(531, 222)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton7.TabIndex = 66
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "Photo 7"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(531, 243)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton8.TabIndex = 67
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "Photo 8"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(599, 222)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton9.TabIndex = 68
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = "Photo 9"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(599, 243)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(68, 17)
        Me.RadioButton10.TabIndex = 69
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "Photo 10"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(0, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(100, 23)
        Me.Button8.TabIndex = 70
        Me.Button8.Text = "Ajouter photo 3"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(0, 0)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(100, 23)
        Me.Button9.TabIndex = 71
        Me.Button9.Text = "Modifier photo 3"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(0, 0)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(100, 23)
        Me.Button10.TabIndex = 72
        Me.Button10.Text = "Ajouter photo 4"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(0, 0)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(100, 23)
        Me.Button11.TabIndex = 73
        Me.Button11.Text = "Modifier photo 4"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(0, 0)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(100, 23)
        Me.Button12.TabIndex = 74
        Me.Button12.Text = "Ajouter photo 5"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(0, 0)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(100, 23)
        Me.Button13.TabIndex = 75
        Me.Button13.Text = "Modifier photo 5"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(0, 0)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(100, 23)
        Me.Button14.TabIndex = 76
        Me.Button14.Text = "Ajouter photo 6"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(0, 0)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(100, 23)
        Me.Button15.TabIndex = 77
        Me.Button15.Text = "Modifier photo 6"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(0, 0)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(100, 23)
        Me.Button16.TabIndex = 78
        Me.Button16.Text = "Ajouter photo 7"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(0, 0)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(100, 23)
        Me.Button17.TabIndex = 79
        Me.Button17.Text = "Modifier photo 7"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(0, 0)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(100, 23)
        Me.Button18.TabIndex = 80
        Me.Button18.Text = "Ajouter photo 8"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(0, 0)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(100, 23)
        Me.Button19.TabIndex = 81
        Me.Button19.Text = "Modifier photo 8"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(0, 0)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(100, 23)
        Me.Button20.TabIndex = 82
        Me.Button20.Text = "Ajouter photo 9"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.Location = New System.Drawing.Point(0, 0)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(100, 23)
        Me.Button21.TabIndex = 83
        Me.Button21.Text = "Modifier photo 9"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.Location = New System.Drawing.Point(0, 0)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(100, 23)
        Me.Button22.TabIndex = 84
        Me.Button22.Text = "Ajouter photo 10"
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button23
        '
        Me.Button23.Location = New System.Drawing.Point(-2, 0)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(100, 23)
        Me.Button23.TabIndex = 85
        Me.Button23.Text = "Modifier photo 10"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button23)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button22)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button21)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button20)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button19)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.Button18)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.Button17)
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Controls.Add(Me.Button16)
        Me.GroupBox1.Controls.Add(Me.Button12)
        Me.GroupBox1.Controls.Add(Me.Button15)
        Me.GroupBox1.Controls.Add(Me.Button13)
        Me.GroupBox1.Controls.Add(Me.Button14)
        Me.GroupBox1.Location = New System.Drawing.Point(378, 678)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(100, 23)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        '
        'Colonne_Details2
        '
        Me.Colonne_Details2.BackColor = System.Drawing.Color.Bisque
        Me.Colonne_Details2.Location = New System.Drawing.Point(660, 272)
        Me.Colonne_Details2.Name = "Colonne_Details2"
        Me.Colonne_Details2.Size = New System.Drawing.Size(386, 400)
        Me.Colonne_Details2.TabIndex = 95
        Me.Colonne_Details2.Text = ""
        '
        'Colonne_Details3
        '
        Me.Colonne_Details3.BackColor = System.Drawing.Color.Bisque
        Me.Colonne_Details3.Location = New System.Drawing.Point(660, 272)
        Me.Colonne_Details3.Name = "Colonne_Details3"
        Me.Colonne_Details3.Size = New System.Drawing.Size(386, 400)
        Me.Colonne_Details3.TabIndex = 96
        Me.Colonne_Details3.Text = ""
        '
        'Titre_photo
        '
        Me.Titre_photo.BackColor = System.Drawing.Color.Lavender
        Me.Titre_photo.Location = New System.Drawing.Point(921, 217)
        Me.Titre_photo.Name = "Titre_photo"
        Me.Titre_photo.Size = New System.Drawing.Size(125, 20)
        Me.Titre_photo.TabIndex = 97
        '
        'Label_Titre_photo
        '
        Me.Label_Titre_photo.AutoSize = True
        Me.Label_Titre_photo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Titre_photo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label_Titre_photo.Location = New System.Drawing.Point(532, 682)
        Me.Label_Titre_photo.Name = "Label_Titre_photo"
        Me.Label_Titre_photo.Size = New System.Drawing.Size(77, 15)
        Me.Label_Titre_photo.TabIndex = 99
        Me.Label_Titre_photo.Text = "Titre Photo"
        '
        'petite_image
        '
        Me.petite_image.Location = New System.Drawing.Point(971, 26)
        Me.petite_image.Name = "petite_image"
        Me.petite_image.Size = New System.Drawing.Size(87, 73)
        Me.petite_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.petite_image.TabIndex = 55
        Me.petite_image.TabStop = False
        '
        'image_pic
        '
        Me.image_pic.Image = CType(resources.GetObject("image_pic.Image"), System.Drawing.Image)
        Me.image_pic.InitialImage = Nothing
        Me.image_pic.Location = New System.Drawing.Point(971, 26)
        Me.image_pic.Name = "image_pic"
        Me.image_pic.Size = New System.Drawing.Size(87, 73)
        Me.image_pic.TabIndex = 54
        Me.image_pic.TabStop = False
        Me.image_pic.Visible = False
        '
        'image_cmos
        '
        Me.image_cmos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.image_cmos.Image = CType(resources.GetObject("image_cmos.Image"), System.Drawing.Image)
        Me.image_cmos.InitialImage = Nothing
        Me.image_cmos.Location = New System.Drawing.Point(971, 26)
        Me.image_cmos.Name = "image_cmos"
        Me.image_cmos.Size = New System.Drawing.Size(87, 73)
        Me.image_cmos.TabIndex = 53
        Me.image_cmos.TabStop = False
        Me.image_cmos.Visible = False
        '
        'Photo1
        '
        Me.Photo1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Photo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Photo1.Location = New System.Drawing.Point(23, 272)
        Me.Photo1.Name = "Photo1"
        Me.Photo1.Size = New System.Drawing.Size(631, 400)
        Me.Photo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Photo1.TabIndex = 43
        Me.Photo1.TabStop = False
        '
        'Transistor
        '
        Me.Transistor.Image = CType(resources.GetObject("Transistor.Image"), System.Drawing.Image)
        Me.Transistor.Location = New System.Drawing.Point(971, 26)
        Me.Transistor.Name = "Transistor"
        Me.Transistor.Size = New System.Drawing.Size(87, 73)
        Me.Transistor.TabIndex = 100
        Me.Transistor.TabStop = False
        Me.Transistor.Visible = False
        '
        'AOP
        '
        Me.AOP.Image = CType(resources.GetObject("AOP.Image"), System.Drawing.Image)
        Me.AOP.Location = New System.Drawing.Point(971, 26)
        Me.AOP.Name = "AOP"
        Me.AOP.Size = New System.Drawing.Size(87, 73)
        Me.AOP.TabIndex = 101
        Me.AOP.TabStop = False
        Me.AOP.Visible = False
        '
        'LED
        '
        Me.LED.Image = CType(resources.GetObject("LED.Image"), System.Drawing.Image)
        Me.LED.Location = New System.Drawing.Point(971, 26)
        Me.LED.Name = "LED"
        Me.LED.Size = New System.Drawing.Size(87, 73)
        Me.LED.TabIndex = 102
        Me.LED.TabStop = False
        Me.LED.Visible = False
        '
        'Modifier_titre_photo
        '
        Me.Modifier_titre_photo.Location = New System.Drawing.Point(949, 243)
        Me.Modifier_titre_photo.Name = "Modifier_titre_photo"
        Me.Modifier_titre_photo.Size = New System.Drawing.Size(75, 23)
        Me.Modifier_titre_photo.TabIndex = 103
        Me.Modifier_titre_photo.Text = "Titre photo"
        Me.Modifier_titre_photo.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(715, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 13)
        Me.Label14.TabIndex = 104
        Me.Label14.Text = "Famille"
        '
        'Button_print
        '
        Me.Button_print.Location = New System.Drawing.Point(890, 678)
        Me.Button_print.Name = "Button_print"
        Me.Button_print.Size = New System.Drawing.Size(75, 23)
        Me.Button_print.TabIndex = 105
        Me.Button_print.Text = "Imprimer"
        Me.Button_print.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'Compteur
        '
        Me.Compteur.AutoSize = True
        Me.Compteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Compteur.ForeColor = System.Drawing.Color.Red
        Me.Compteur.Location = New System.Drawing.Point(337, 58)
        Me.Compteur.Name = "Compteur"
        Me.Compteur.Size = New System.Drawing.Size(60, 13)
        Me.Compteur.TabIndex = 106
        Me.Compteur.Text = "Compteur"
        '
        'General
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 713)
        Me.Controls.Add(Me.Compteur)
        Me.Controls.Add(Me.Button_print)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Modifier_titre_photo)
        Me.Controls.Add(Me.LED)
        Me.Controls.Add(Me.AOP)
        Me.Controls.Add(Me.Transistor)
        Me.Controls.Add(Me.Label_Titre_photo)
        Me.Controls.Add(Me.Titre_photo)
        Me.Controls.Add(Me.Colonne_Details3)
        Me.Controls.Add(Me.Colonne_Details2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RadioButton10)
        Me.Controls.Add(Me.RadioButton9)
        Me.Controls.Add(Me.RadioButton8)
        Me.Controls.Add(Me.RadioButton7)
        Me.Controls.Add(Me.RadioButton6)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Colonne_Details)
        Me.Controls.Add(Me.petite_image)
        Me.Controls.Add(Me.image_pic)
        Me.Controls.Add(Me.image_cmos)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Bouton_rechercher)
        Me.Controls.Add(Me.Rechercher)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Browse)
        Me.Controls.Add(Me.Photo)
        Me.Controls.Add(Me.Photo1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Choix_Table)
        Me.Controls.Add(Me.Modifier)
        Me.Controls.Add(Me.Nouveau)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Détails3)
        Me.Controls.Add(Me.Détails2)
        Me.Controls.Add(Me.Détails)
        Me.Controls.Add(Me.Colonne_détails3)
        Me.Controls.Add(Me.Colonne_détails2)
        Me.Controls.Add(Me.Colonne_détails)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Colonne_stock)
        Me.Controls.Add(Me.Colonne_description)
        Me.Controls.Add(Me.Supprimer)
        Me.Controls.Add(Me.Liste_effacer)
        Me.Controls.Add(Me.Stock)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.Nom)
        Me.Controls.Add(Me.Liste_lire)
        Me.Controls.Add(Me.Colonne_Nom)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "General"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Base de données - Composants électroniques"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.petite_image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.image_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.image_cmos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Photo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Transistor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AOP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LED, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Colonne_Nom As System.Windows.Forms.ListBox
    Friend WithEvents Liste_lire As System.Windows.Forms.Button
    Friend WithEvents Nom As System.Windows.Forms.TextBox
    Friend WithEvents Description As System.Windows.Forms.TextBox
    Friend WithEvents Stock As System.Windows.Forms.TextBox
    Friend WithEvents Liste_effacer As System.Windows.Forms.Button
    Friend WithEvents Supprimer As System.Windows.Forms.Button
    Friend WithEvents Colonne_description As System.Windows.Forms.ListBox
    Friend WithEvents Colonne_stock As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Titre As System.Windows.Forms.Label
    Friend WithEvents Colonne_détails As System.Windows.Forms.ListBox
    Friend WithEvents Colonne_détails2 As System.Windows.Forms.ListBox
    Friend WithEvents Colonne_détails3 As System.Windows.Forms.ListBox
    Friend WithEvents Détails As System.Windows.Forms.TextBox
    Friend WithEvents Détails2 As System.Windows.Forms.TextBox
    Friend WithEvents Détails3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Nouveau As System.Windows.Forms.Button
    Friend WithEvents Modifier As System.Windows.Forms.Button
    Friend WithEvents Choix_Table As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Photo1 As System.Windows.Forms.PictureBox
    Friend WithEvents Photo As System.Windows.Forms.TextBox
    Friend WithEvents Browse As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Rechercher As System.Windows.Forms.TextBox
    Friend WithEvents Bouton_rechercher As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents image_cmos As System.Windows.Forms.PictureBox
    Friend WithEvents image_pic As System.Windows.Forms.PictureBox
    Friend WithEvents petite_image As System.Windows.Forms.PictureBox
    Friend WithEvents Colonne_Details As System.Windows.Forms.RichTextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Colonne_Details2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Colonne_Details3 As System.Windows.Forms.RichTextBox
    Friend WithEvents Titre_photo As System.Windows.Forms.TextBox
    Friend WithEvents Label_Titre_photo As System.Windows.Forms.Label
    Friend WithEvents Transistor As System.Windows.Forms.PictureBox
    Friend WithEvents AOP As System.Windows.Forms.PictureBox
    Friend WithEvents LED As System.Windows.Forms.PictureBox
    Friend WithEvents Modifier_titre_photo As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button_print As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Compteur As System.Windows.Forms.Label

End Class
