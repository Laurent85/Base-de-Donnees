Imports System.Data
Imports System.Data.SqlClient
Imports System.IO ' Pour les images

Public Class General
    ' Connection Base Laurent SQL server
    Dim base_laurent As New SqlConnection("server=LAURENT\SQLEXPRESS;database=laurent;user id=sa;password=sa;integrated security=false")
    Private GI_Sync_X_centerLine As Integer
    Dim s As String

    '**************************************************
    '          LES DATAREADER
    '**************************************************

    Sub afficher_liste() ' Affichage de la liste des articles
        Label4.Text = Nom_Colonne(0)
        Label8.Text = Nom_Colonne(1)
        Label9.Text = Nom_Colonne(2)
        Label10.Text = Nom_Colonne(3)
        Label11.Text = Nom_Colonne(4)
        Label12.Text = Nom_Colonne(5)
        Label1.Text = Nom_Colonne(0)
        Label2.Text = Nom_Colonne(2)
        Label3.Text = Nom_Colonne(1)
        Label5.Text = Nom_Colonne(3)
        Label6.Text = Nom_Colonne(4)
        Label7.Text = Nom_Colonne(5)
        Try
            Dim base_laurent As New SqlConnection("server=LAURENT\SQLEXPRESS;database=laurent;user id=sa;password=sa;integrated security=false")
            Titre.Text = Choix_Table.Text().ToString()
            Dim MyCommand As New SqlCommand("SELECT * FROM  " & Choix_Table.Text().ToString() & " ORDER BY " & Nom_Colonne(0) & "", base_laurent)
            base_laurent.Open()
            Dim MyReader As SqlDataReader = MyCommand.ExecuteReader()

            Do While MyReader.Read()
                Colonne_Nom.Items.Add(MyReader.Item(Nom_Colonne(0)))
                Colonne_stock.Items.Add(MyReader.Item(Nom_Colonne(1)))
                Colonne_description.Items.Add(MyReader.Item(Nom_Colonne(2)))
                Colonne_détails.Items.Add(MyReader.Item(Nom_Colonne(3)))
                Colonne_détails2.Items.Add(MyReader.Item(Nom_Colonne(4)))
                Colonne_détails3.Items.Add(MyReader.Item(Nom_Colonne(5)))
            Loop

            MyReader.Close()

            ' Compteur de lignes dans la table correspondante
            Dim lignes As Integer
            Dim MyCommand1 As New SqlCommand("SELECT COUNT(*) FROM " & Choix_Table.Text().ToString() & "", base_laurent)
            lignes = DirectCast(MyCommand1.ExecuteScalar, Integer)
            Label13.Text = (String.Format(lignes & " enregistrement(s)"))
            base_laurent.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erreur")
        End Try

        If Nom_Colonne(0).ToString.Contains("Détails") Then
            Label1.Visible = False
            Nom.Visible = False
        Else
            Label1.Visible = True
            Nom.Visible = True
        End If
        If Nom_Colonne(1).ToString.Contains("description") Then
            Label2.Visible = False
            Description.Visible = True
        Else
            Label2.Visible = True
            Colonne_Details.Visible = True
        End If
        If Nom_Colonne(2).ToString.Contains("Détails") Then
            Label2.Visible = False
            Description.Visible = False
        Else
            Label3.Visible = True
            Stock.Visible = True
        End If
        If Nom_Colonne(3).ToString.Contains("Détails") Then
            Label5.Visible = False
            Détails.Visible = False
        Else
            Label5.Visible = True
            Détails.Visible = True
        End If
        If Nom_Colonne(4).ToString.Contains("Détails") Then
            Label6.Visible = False
            Détails2.Visible = False
        Else
            Label6.Visible = True
            Détails2.Visible = True
        End If
        If Nom_Colonne(5).ToString.Contains("Détails") Then
            Label7.Visible = False
            Détails3.Visible = False
        Else
            Label7.Visible = True
            Détails3.Visible = True
        End If
        Try
        Catch
        End Try
    End Sub

    Public Sub couleur_radiobutton()
        ' Affiche radioButton en rouge si il existe une photo
        Dim i As Integer
        For i = 1 To 10

            Dim j As String = i.ToString()
            Dim objectName As String = "Radiobutton" + j
            Dim p As RadioButton
            p = Me.Controls(objectName)
            p.ForeColor = Color.Black
            base_laurent.Open()
            Dim MyCommand As New SqlCommand("SELECT Nom FROM  images" & j & "", base_laurent)
            Dim MyReader As SqlDataReader = MyCommand.ExecuteReader()
            Do While MyReader.Read()
                If MyReader.Item(0).ToString() = Nom.Text.ToString() Then
                    p.ForeColor = Color.Red
                End If
            Loop
            MyReader.Close()
            base_laurent.Close()
        Next i
    End Sub

    Private Sub Bouton_rechercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bouton_rechercher.Click
        ' Recherche d'un mot dans nom, description ou détails
        effacer_liste()
        Try
            Dim base_laurent As New SqlConnection("server=LAURENT\SQLEXPRESS;database=laurent;user id=sa;password=sa;integrated security=false")
            Titre.Text = Choix_Table.Text().ToString()
            Dim MyCommand As New SqlCommand("SELECT * FROM " & Choix_Table.Text().ToString() & " WHERE description LIKE '%" & Rechercher.Text & "%' OR nom LIKE '%" & Rechercher.Text & "%' OR Détails LIKE '%" & Rechercher.Text & "%' OR Détails1 LIKE '%" & Rechercher.Text & "%' OR Détails2 LIKE '%" & Rechercher.Text & "%'", base_laurent)
            base_laurent.Open()
            Dim MyReader As SqlDataReader = MyCommand.ExecuteReader()
            Do While MyReader.Read()
                Colonne_Nom.Items.Add(MyReader.Item(Nom_Colonne(0)))
                Colonne_stock.Items.Add(MyReader.Item(Nom_Colonne(1)))
                Colonne_description.Items.Add(MyReader.Item(Nom_Colonne(2)))
                Colonne_détails.Items.Add(MyReader.Item(Nom_Colonne(3)))
                Colonne_détails2.Items.Add(MyReader.Item(Nom_Colonne(4)))
                Colonne_détails3.Items.Add(MyReader.Item(Nom_Colonne(5)))
            Loop
            MyReader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erreur")
        End Try
        Compteur.Text = Colonne_Nom.Items.Count & " réponses"
    End Sub

    Sub titre_photos()
        Dim Mycommand As New SqlCommand("SELECT Null1 FROM images" & s & " WHERE Nom= '" & Colonne_Nom.SelectedItem & "'", base_laurent)
        base_laurent.Open()
        Dim Myreader As SqlDataReader = Mycommand.ExecuteReader()

        If Not Photo1.Image Is Nothing Then
            Do While Myreader.Read()
                Label_Titre_photo.Text = Myreader(0)
            Loop
        Else
            Label_Titre_photo.Text = ""
        End If
        Myreader.Close()
        base_laurent.Close()
    End Sub

    '**************************************************
    '          LES DATASET
    '**************************************************

    Public Function Nom_Colonne(ByVal i As Integer) ' Retourne le nom des colonnes en fonction du choix de la table
        Dim ds As New DataSet
        Dim Affiche_nomcolonne As String = ""
        Dim da As New SqlDataAdapter("SELECT column_name FROM INFORMATION_SCHEMA.Columns where TABLE_NAME = '" & Choix_Table.Text().ToString() & "'", base_laurent)
        da.Fill(ds)
        Affiche_nomcolonne = ds.Tables(0).Rows(i).Item(0)
        Return Affiche_nomcolonne
    End Function

    Sub afficher_tables() ' Affichage du nom des tables dans la liste déroulante
        Dim da As New SqlDataAdapter("SELECT name FROM sysobjects WHERE xtype= 'U' AND name <> 'Images' AND name <> 'Images1' AND name <> 'Images2' AND name <> 'Images3' AND name <> 'Images4' AND name <> 'Images5' AND name <> 'Images6' AND name <> 'Images7' AND name <> 'Images8' AND name <> 'Images9' AND name <> 'Images10' ORDER BY name", base_laurent)
        Dim ds As New DataSet
        da.Fill(ds)
        Choix_Table.DisplayMember = "name"
        Choix_Table.DataSource = ds.Tables(0)
    End Sub

    Private Sub Colonne_nom_selection(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Colonne_Nom.SelectedIndexChanged
        ' Sélection d'un article
        Colonne_Details.Text = Nothing
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter("select " & Nom_Colonne(0) & "," & Nom_Colonne(1) & "," & Nom_Colonne(2) & "," & Nom_Colonne(3) & "," & Nom_Colonne(4) & "," & Nom_Colonne(5) & " from " & (Choix_Table.Text().ToString()) & " where " & Nom_Colonne(0) & "='" & Colonne_Nom.SelectedItem & "'", base_laurent)
        da.Fill(ds, Choix_Table.Text().ToString())

        If ds.Tables(Choix_Table.Text().ToString()).Rows.Count > 0 Then
            Try
                Nom.Text = ds.Tables(Choix_Table.Text().ToString()).Rows(0).Item(0)
                Stock.Text = ds.Tables(Choix_Table.Text().ToString()).Rows(0)(1)
                Description.Text = ds.Tables(Choix_Table.Text().ToString()).Rows(0)(2)
                Détails.Text = ds.Tables(Choix_Table.Text().ToString()).Rows(0)(3)
                Détails2.Text = ds.Tables(Choix_Table.Text().ToString()).Rows(0)(4)
                Détails3.Text = ds.Tables(Choix_Table.Text().ToString()).Rows(0)(5)

                Colonne_description.SelectedIndex = Colonne_Nom.SelectedIndex
                Colonne_stock.SelectedIndex = Colonne_Nom.SelectedIndex
                Colonne_détails.SelectedIndex = Colonne_Nom.SelectedIndex
                Colonne_détails2.SelectedIndex = Colonne_Nom.SelectedIndex
                Colonne_détails3.SelectedIndex = Colonne_Nom.SelectedIndex

                Colonne_Details.Text = Colonne_détails.SelectedItem
                Colonne_Details2.Text = Colonne_détails2.SelectedItem
                Colonne_Details3.Text = Colonne_détails3.SelectedItem
            Catch ex As Exception
            End Try
        End If
        titre_automatique()
        Colonne_description.Refresh()
        Colonne_stock.Refresh()
        photos_invisibles()
        Affichage_images(4)
        RadioButton4.Checked = True
        couleur_radiobutton()
        Surlignage_jaune()
        update_bouton_photos()
        update_radiobutton()
    End Sub

    Private Sub Colonne_Description_Selection(ByVal sender As Object, ByVal e As System.EventArgs) Handles Colonne_description.SelectedIndexChanged
        ' Actualisation de la colonne "Description" au changement de sélection d'un article
        Colonne_Details.Text = Nothing
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter("SELECT " & Nom_Colonne(0) & "," & Nom_Colonne(1) & "," & Nom_Colonne(2) & "," & Nom_Colonne(3) & "," & Nom_Colonne(4) & "," & Nom_Colonne(5) & " from " & (Choix_Table.Text().ToString()) & " where " & Nom_Colonne(0) & "='" & Colonne_Nom.SelectedItem & "'", base_laurent)
        da.Fill(ds, Choix_Table.Text().ToString())

        If ds.Tables(Choix_Table.Text().ToString()).Rows.Count > 0 Then
            Try
                Nom.Text = ds.Tables(Choix_Table.Text().ToString()).Rows(0).Item(0)
                Stock.Text = ds.Tables(Choix_Table.Text().ToString()).Rows(0)(1)
                Description.Text = ds.Tables(Choix_Table.Text().ToString()).Rows(0)(2)
                Détails.Text = ds.Tables(Choix_Table.Text().ToString()).Rows(0)(3)
                Détails2.Text = ds.Tables(Choix_Table.Text().ToString()).Rows(0)(4)
                Détails3.Text = ds.Tables(Choix_Table.Text().ToString()).Rows(0)(5)

                Colonne_Nom.SelectedIndex = Colonne_description.SelectedIndex
                Colonne_stock.SelectedIndex = Colonne_description.SelectedIndex
                Colonne_détails.SelectedIndex = Colonne_description.SelectedIndex
                Colonne_détails2.SelectedIndex = Colonne_description.SelectedIndex
                Colonne_détails3.SelectedIndex = Colonne_description.SelectedIndex

                Colonne_Details.Text = Colonne_détails.SelectedItem
                Colonne_Details2.Text = Colonne_détails2.SelectedItem
                Colonne_Details3.Text = Colonne_détails3.SelectedItem

            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Colonne_Stock_Selection(ByVal sender As Object, ByVal e As System.EventArgs) Handles Colonne_stock.SelectedIndexChanged
        ' Actualisation de la colonne "Stock" au changement de sélection d'un article
        Colonne_Details.Text = Nothing
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter("SELECT " & Nom_Colonne(0) & "," & Nom_Colonne(1) & "," & Nom_Colonne(2) & "," & Nom_Colonne(3) & "," & Nom_Colonne(4) & "," & Nom_Colonne(5) & " from " & (Choix_Table.Text().ToString()) & " where " & Nom_Colonne(0) & "='" & Colonne_Nom.SelectedItem & "'", base_laurent)
        da.Fill(ds, Choix_Table.Text().ToString())

        If ds.Tables(Choix_Table.Text().ToString()).Rows.Count > 0 Then
            Try
                Nom.Text = ds.Tables(Choix_Table.Text().ToString()).Rows(0).Item(0)
                Stock.Text = ds.Tables(Choix_Table.Text().ToString()).Rows(0)(1)
                Description.Text = ds.Tables(Choix_Table.Text().ToString()).Rows(0)(2)
                Détails.Text = ds.Tables(Choix_Table.Text().ToString()).Rows(0)(3)
                Détails2.Text = ds.Tables(Choix_Table.Text().ToString()).Rows(0)(4)
                Détails3.Text = ds.Tables(Choix_Table.Text().ToString()).Rows(0)(5)

                Colonne_Nom.SelectedIndex = Colonne_stock.SelectedIndex
                Colonne_description.SelectedIndex = Colonne_stock.SelectedIndex
                Colonne_détails.SelectedIndex = Colonne_stock.SelectedIndex
                Colonne_détails2.SelectedIndex = Colonne_stock.SelectedIndex
                Colonne_détails3.SelectedIndex = Colonne_stock.SelectedIndex

                Colonne_Details.Text = Colonne_détails.SelectedItem
                Colonne_Details2.Text = Colonne_détails2.SelectedItem
                Colonne_Details3.Text = Colonne_détails3.SelectedItem

            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Affichage_images(ByVal k As String)
        ' Affichage de l'image correspondante
        Dim image As New DataSet
        Dim dAdapter As New SqlClient.SqlDataAdapter("SELECT photo FROM images" & k & " WHERE Nom= '" & Colonne_Nom.SelectedItem & "'", base_laurent)

        dAdapter.Fill(image)

        If Colonne_Nom.SelectedIndex <> -1 Then
            Try
                Dim bits As Byte() = CType(image.Tables(0).Rows(0).Item(0), Byte())
                Dim memorybits As New MemoryStream(bits)
                Dim bitmap As New Bitmap(memorybits)
                Dim pSizeMode As PictureBoxSizeMode = PictureBoxSizeMode.CenterImage

                Photo1.Image = Nothing
                pSizeMode = PictureBoxSizeMode.CenterImage
                Dim imgOrg As Bitmap
                Dim imgShow As Bitmap
                Dim g As Graphics
                Dim divideBy, divideByH, divideByW As Double
                imgOrg = DirectCast(bitmap, Bitmap)

                divideByW = imgOrg.Width / Photo1.Width
                divideByH = imgOrg.Height / Photo1.Height
                If divideByW > 1 Or divideByH > 1 Then
                    If divideByW > divideByH Then
                        divideBy = divideByW
                    Else
                        divideBy = divideByH
                    End If

                    imgShow = New Bitmap(CInt(CDbl(imgOrg.Width) / divideBy), CInt(CDbl(imgOrg.Height) / divideBy))
                    imgShow.SetResolution(imgOrg.HorizontalResolution, imgOrg.VerticalResolution)
                    g = Graphics.FromImage(imgShow)
                    g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                    g.DrawImage(imgOrg, New Rectangle(0, 0, CInt(CDbl(imgOrg.Width) / divideBy), CInt(CDbl(imgOrg.Height) / divideBy)), 0, 0, imgOrg.Width, imgOrg.Height, GraphicsUnit.Pixel)
                    g.Dispose()
                Else
                    imgShow = New Bitmap(imgOrg.Width, imgOrg.Height)
                    imgShow.SetResolution(imgOrg.HorizontalResolution, imgOrg.VerticalResolution)
                    g = Graphics.FromImage(imgShow)
                    g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                    g.DrawImage(imgOrg, New Rectangle(0, 0, imgOrg.Width, imgOrg.Height), 0, 0, imgOrg.Width, imgOrg.Height, GraphicsUnit.Pixel)
                    g.Dispose()
                End If

                imgOrg.Dispose()
                Photo1.Image = imgShow
                s = k

            Catch ex As Exception
                Photo1.Image = Nothing
            End Try
        End If
        If Not s Is Nothing Then
            titre_photos()
        End If

    End Sub

    Private Sub titre_automatique()
        If Not Titre_photo.Text Is Nothing Then
            Dim base_laurent As New SqlConnection("server=LAURENT\SQLEXPRESS;database=laurent;user id=sa;password=sa;integrated security=false")
            Dim MyCommand As New SqlCommand("UPDATE images4 SET Null1 = '" & Nom.Text & "' WHERE " & Nom_Colonne(0) & "='" & Colonne_Nom.SelectedItem & "'", base_laurent)
            base_laurent.Open()
            MyCommand.ExecuteNonQuery()
            base_laurent.Close()
        End If
    End Sub

    '**************************************************
    '   LES MODIFICATIONS (INSERT - UPDATE - DELETE)
    '**************************************************

    Sub Bouton_OK_image(ByVal i As String)
        ' Insertion d'une photo dans un article
        Dim j As String = i.ToString()
        Dim objectName As String = "Radiobutton" + j
        Dim p As RadioButton
        p = Me.Controls(objectName)
        Dim fName As String = Photo.Text
        Dim id As Integer = 1
        Dim content As Byte() = ImageToStream(fName)

        base_laurent.Open()
        Dim MyCommand As New SqlCommand("INSERT INTO images" & i & " VALUES ('" & Nom.Text & "', @photo, '" & Titre_photo.Text & "', '" & Nom.Text & "', '" & Nom.Text & "', '" & Nom.Text & "')", base_laurent)
        If Photo.Text <> "" Then
            Try
                If System.IO.File.Exists(fName) Then
                    MyCommand.Parameters.AddWithValue("@photo", content)
                    MyCommand.ExecuteNonQuery()
                End If

            Catch ex As Exception
                MsgBox("Cette photo existe déjà !", MsgBoxStyle.Critical)
            End Try
        End If
        MessageBox.Show("Photo ajoutée")
        base_laurent.Close()
        effacer_liste()
        afficher_liste()
        Colonne_Nom.SelectedItem = Nom.Text
        couleur_radiobutton()
        update_radiobutton()
        p.Checked = True

    End Sub

    Sub Bouton_modifier_image(ByVal i As String)
        ' Remplacement d'une image par une autre
        Dim j As String = i.ToString()
        Dim objectName As String = "Radiobutton" + j
        Dim p As RadioButton
        p = Me.Controls(objectName)
        Dim fName As String = Photo.Text
        Dim id As Integer = 1
        Dim content As Byte() = ImageToStream(fName)

        base_laurent.Open()
        If Photo.Text = "" Then
            Dim MyCommand As New SqlCommand("DELETE FROM Images" & i & " WHERE Nom = '" & Nom.Text & "'", base_laurent)
            Dim a As Long
            a = MsgBox("Etes vous sur de vouloir supprimer la photo du composant " & Nom.Text & " ?", vbYesNo)

            If (a = 6) Then
                ' il a cliqué sur OUI
                MyCommand.ExecuteNonQuery()
                MessageBox.Show("La photo du composant " & Nom.Text & " a été supprimé")
            Else
                ' il a cliqué sur NON
            End If
        Else
            Dim MyCommand As New SqlCommand("UPDATE images" & i & " SET Photo = @photo WHERE Nom = '" & Nom.Text & "'", base_laurent)
            MyCommand.Parameters.AddWithValue("@photo", content)
            MyCommand.ExecuteNonQuery()
            MessageBox.Show("Photo modifiée")
        End If
        base_laurent.Close()
        Affichage_images(i)
        couleur_radiobutton()
        update_radiobutton()
        p.Checked = True
    End Sub

    Private Sub Bouton_Modifier(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modifier.Click
        ' Modification d'un article
        Dim i As Integer
        Dim a As Integer = 0
        a = Colonne_Nom.SelectedIndex

        base_laurent.Open()
        Try
            Dim Colonne_Details_modif As String = Colonne_Details.Text.Replace("'", "''")
            Dim Colonne_Details2_modif As String = Colonne_Details2.Text.Replace("'", "''")
            Dim Colonne_Details3_modif As String = Colonne_Details3.Text.Replace("'", "''")
            Dim colonne_Détails_modif As String = Colonne_détails.SelectedItem.Replace("'", "''")
            Dim colonne_Détails2_modif As String = Colonne_détails2.SelectedItem.Replace("'", "''")
            Dim colonne_Détails3_modif As String = Colonne_détails3.SelectedItem.Replace("'", "''")
            Dim MyCommand As New SqlCommand("UPDATE " & Choix_Table.Text().ToString() & " SET " & Nom_Colonne(0) & " = '" & Nom.Text & "' , " & Nom_Colonne(1) & "= '" & Stock.Text & "' , " & Nom_Colonne(2) & "= '" & Description.Text & "' , " & Nom_Colonne(3) & "= '" & Colonne_Details_modif & "' , " & Nom_Colonne(4) & "= '" & Colonne_Details2_modif & "' , " & Nom_Colonne(5) & "= '" & Colonne_Details3_modif & "'where " & Nom_Colonne(0) & "='" & Colonne_Nom.SelectedItem & "' and " & Nom_Colonne(1) & "='" & Colonne_stock.SelectedItem & "' and " & Nom_Colonne(2) & "='" & Colonne_description.SelectedItem & "' and " & Nom_Colonne(3) & "='" & colonne_Détails_modif & "' and " & Nom_Colonne(4) & "='" & colonne_Détails2_modif & "' and " & Nom_Colonne(5) & "='" & colonne_Détails3_modif & "'", base_laurent)
            Dim MyCommand_tous As New SqlCommand("UPDATE tous SET " & Nom_Colonne(0) & " = '" & Nom.Text & "' , " & Nom_Colonne(1) & "= '" & Stock.Text & "' , " & Nom_Colonne(2) & "= '" & Description.Text & "' , " & Nom_Colonne(3) & "= '" & Colonne_Details_modif & "' , " & Nom_Colonne(4) & "= '" & Colonne_Details2_modif & "' , " & Nom_Colonne(5) & "= '" & Colonne_Details3_modif & "'where " & Nom_Colonne(0) & "='" & Colonne_Nom.SelectedItem & "' and " & Nom_Colonne(1) & "='" & Colonne_stock.SelectedItem & "' and " & Nom_Colonne(2) & "='" & Colonne_description.SelectedItem & "' and " & Nom_Colonne(3) & "='" & colonne_Détails_modif & "' and " & Nom_Colonne(4) & "='" & colonne_Détails2_modif & "' and " & Nom_Colonne(5) & "='" & colonne_Détails3_modif & "'", base_laurent)
            MyCommand.ExecuteNonQuery()
            MyCommand_tous.ExecuteNonQuery()
            For i = 1 To 10
                Dim j As String = i.ToString()
                MyCommand = New SqlCommand("UPDATE images" & j & " SET " & Nom_Colonne(0) & " = '" & Nom.Text & "' where " & Nom_Colonne(0) & "='" & Colonne_Nom.SelectedItem & "'", base_laurent)
                MyCommand.ExecuteNonQuery()
            Next
            MessageBox.Show("Modification effectuée")
        Catch
        End Try

        base_laurent.Close()

        ' Actualisation de l'image et du texte après la modification
        Titre_photo.Text = ""
        Affichage_images(s)
        effacer_champs()
        effacer_liste()
        afficher_liste()
        Colonne_Nom.SelectedIndex = a
    End Sub

    Private Sub Modifier_titre_photo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modifier_titre_photo.Click
        ' Modification du titre de la photo en cours
        Dim j As String = s.ToString()
        Dim objectName As String = "Radiobutton" + j
        Dim p As RadioButton
        p = Me.Controls(objectName)
        Dim a As Integer = 0
        a = Colonne_Nom.SelectedIndex

        base_laurent.Open()
        Try
            Dim Titre_photo_modif As String = Titre_photo.Text.Replace("'", "''")
            Dim MyCommand As New SqlCommand("UPDATE images" & s & " SET Null1 = '" & Titre_photo_modif & "' WHERE " & Nom_Colonne(0) & "='" & Colonne_Nom.SelectedItem & "'", base_laurent)
            MyCommand.ExecuteNonQuery()
            MessageBox.Show("Titre modifié")
        Catch
        End Try

        base_laurent.Close()

        ' Actualisation de l'image et du texte après la modification
        Titre_photo.Text = ""
        Affichage_images(s)
        effacer_champs()
        effacer_liste()
        afficher_liste()
        Colonne_Nom.SelectedIndex = a
        p.Checked = True
    End Sub

    Private Sub Bouton_SupprimerEntrée(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Supprimer.Click
        ' Suppression d'un article
        base_laurent.Open()

        Dim MyCommand As New SqlCommand("DELETE from " & Choix_Table.Text().ToString() & " WHERE " & Nom_Colonne(0) & "= '" & Nom.Text & "' ", base_laurent)
        Dim MyCommand_tous As New SqlCommand("DELETE from tous WHERE " & Nom_Colonne(0) & "= '" & Nom.Text & "' ", base_laurent)
        Dim a As Long
        a = MsgBox("Etes vous sur de vouloir supprimer le composant " & Nom.Text & " ?", vbYesNo)

        If (a = 6) Then
            ' il a cliqué sur OUI
            MyCommand.ExecuteNonQuery()
            MyCommand_tous.ExecuteNonQuery()
            MessageBox.Show("Le composant " & Nom.Text & " a été supprimé")
        Else
            ' il a cliqué sur NON
        End If

        base_laurent.Close()
        effacer_liste()
        effacer_champs()
        afficher_liste()
        photos_invisibles()
        update_radiobutton()
        Colonne_Nom.SelectedIndex = 0
    End Sub

    Private Sub Bouton_SupprimerTable(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' Suppression d'une table
        base_laurent.Open()

        Dim MyCommand As New SqlCommand("DROP TABLE " & Choix_Table.Text().ToString() & "", base_laurent)
        Dim a As Long
        a = MsgBox("Etes vous sur de vouloir supprimer la famille " & Choix_Table.Text().ToString() & " ?", vbYesNo)

        If (a = 6) Then
            ' il a cliqué sur OUI
            MyCommand.ExecuteNonQuery()
            MessageBox.Show("Famille " & Choix_Table.Text().ToString() & " supprimée")
        Else
            ' il a cliqué sur NON
        End If
        base_laurent.Close()
        Photo1.Image = Nothing
        afficher_tables()
    End Sub

    '**************************************************
    '       OUVERTURE FENETRE PRINCIPALE
    '**************************************************

    Private Sub Général() Handles Me.Load
        afficher_tables()
        affichage_colonnes()
        update_bouton_photos()
        Compteur.Visible = False
        My.Computer.Keyboard.SendKeys("{TAB}", False)

        ' Routine permettant de synchroniser les scrollbar des 3 colonnes
        Colonne_Nom.DrawMode = DrawMode.OwnerDrawFixed
        Colonne_Nom.ItemHeight += 5
        Colonne_description.DrawMode = DrawMode.OwnerDrawFixed
        Colonne_description.ItemHeight += 5
        Colonne_stock.DrawMode = DrawMode.OwnerDrawFixed
        Colonne_stock.ItemHeight += 5
        GI_Sync_X_centerLine = (Colonne_Nom.Left + Colonne_Nom.Width + Colonne_stock.Left) \ 2
        Timer1.Interval = 30    ' milliseconds; because video refresh is about 30 frames/sec
        Timer1.Enabled = True   ' start timer ticks
        GI_Sync_X_centerLine = (Colonne_stock.Left + Colonne_stock.Width + Colonne_description.Left) \ 2
        Timer1.Interval = 30    ' milliseconds; because video refresh is about 30 frames/sec
        Timer1.Enabled = True   ' start timer ticks
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' Timer servant à synchroniser les 3 scrollbar en même temps
        Try
            If (Colonne_Nom.TopIndex <> Colonne_stock.TopIndex) Then            ' out-of-sync
                If (Colonne_Nom.Items.Count = Colonne_stock.Items.Count) Then   ' both are scrollable
                    If ((MousePosition.X - Me.Location.X) < GI_Sync_X_centerLine) Then ' mouse is on the left one
                        Colonne_stock.TopIndex = Colonne_Nom.TopIndex       ' move the right one to match
                    Else
                        Colonne_Nom.TopIndex = Colonne_stock.TopIndex       ' & v.v.
                    End If
                End If
            End If

            If (Colonne_stock.TopIndex <> Colonne_description.TopIndex) Then            ' out-of-sync
                If (Colonne_stock.Items.Count = Colonne_description.Items.Count) Then   ' both are scrollable
                    If ((MousePosition.X - Me.Location.X) < GI_Sync_X_centerLine) Then ' mouse is on the left one
                        Colonne_description.TopIndex = Colonne_stock.TopIndex       ' move the right one to match
                    Else
                        Colonne_stock.TopIndex = Colonne_description.TopIndex       ' & v.v.
                    End If
                End If
            End If
        Catch
        End Try
    End Sub

    Public Function ImageToStream(ByVal fileName As String) As Byte() ' Enregistrement image dans SQL
        Dim stream As New MemoryStream()
        'tryagain:
        Try
            Dim image As New Bitmap(fileName)
            image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Catch ex As Exception
            'GoTo tryagain
        End Try
        Return stream.ToArray()
    End Function

    Sub update_radiobutton() ' Bouton "OK" ou Bouton "Modifier" Photos
        If Photo1.Image Is Nothing And RadioButton1.Checked = True Then
            Button5.Visible = True ' Création photo 1
        ElseIf Not Photo1.Image Is Nothing And RadioButton1.Checked = True Then
            Button4.Visible = True ' Remplacement photo 1
        ElseIf Photo1.Image Is Nothing And RadioButton2.Checked = True Then
            Button7.Visible = True ' Création photo 2
        ElseIf Not Photo1.Image Is Nothing And RadioButton2.Checked = True Then
            Button6.Visible = True ' Remplacement photo 2
        ElseIf Photo1.Image Is Nothing And RadioButton3.Checked = True Then
            Button8.Visible = True ' Création photo 3
        ElseIf Not Photo1.Image Is Nothing And RadioButton3.Checked = True Then
            Button9.Visible = True ' Remplacement photo 3
        ElseIf Photo1.Image Is Nothing And RadioButton4.Checked = True Then
            Button10.Visible = True ' Création photo 4
        ElseIf Not Photo1.Image Is Nothing And RadioButton4.Checked = True Then
            Button11.Visible = True ' Remplacement photo 4
        ElseIf Photo1.Image Is Nothing And RadioButton5.Checked = True Then
            Button12.Visible = True ' Création photo 5
        ElseIf Not Photo1.Image Is Nothing And RadioButton5.Checked = True Then
            Button13.Visible = True ' Remplacement photo 5
        ElseIf Photo1.Image Is Nothing And RadioButton6.Checked = True Then
            Button14.Visible = True ' Création photo 6
        ElseIf Not Photo1.Image Is Nothing And RadioButton6.Checked = True Then
            Button15.Visible = True ' Remplacement photo 6
        ElseIf Photo1.Image Is Nothing And RadioButton7.Checked = True Then
            Button16.Visible = True ' Création photo 7
        ElseIf Not Photo1.Image Is Nothing And RadioButton7.Checked = True Then
            Button17.Visible = True ' Remplacement photo 7
        ElseIf Photo1.Image Is Nothing And RadioButton8.Checked = True Then
            Button18.Visible = True ' Création photo 8
        ElseIf Not Photo1.Image Is Nothing And RadioButton8.Checked = True Then
            Button19.Visible = True ' Remplacement photo 8
        ElseIf Photo1.Image Is Nothing And RadioButton9.Checked = True Then
            Button20.Visible = True ' Création photo 9
        ElseIf Not Photo1.Image Is Nothing And RadioButton9.Checked = True Then
            Button21.Visible = True ' Remplacement photo 9
        ElseIf Photo1.Image Is Nothing And RadioButton10.Checked = True Then
            Button22.Visible = True ' Création photo 10
        ElseIf Not Photo1.Image Is Nothing And RadioButton10.Checked = True Then
            Button23.Visible = True ' Remplacement photo 10
        End If
    End Sub

    Sub affichage_colonnes() ' On ne laisse que les 3 premières colonnes visibles, on cache les autres
        If Label10.Text.Contains("Détails") Then
            Label10.Visible = False
            Colonne_détails.Visible = False
        End If
        If Label11.Text.Contains("Détails") Then
            Label11.Visible = False
            Colonne_détails2.Visible = False
        End If
        If Label12.Text.Contains("Détails") Then
            Label12.Visible = False
            Colonne_détails3.Visible = False
        End If
    End Sub

    Sub parcourir() ' Bouton parcourir pour les photos
        Dim FileDialog As OpenFileDialog = New OpenFileDialog()
        FileDialog.Title = "Select A File"
        FileDialog.InitialDirectory = "\\laurent\Weo\files\"
        FileDialog.Filter = "Images (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"
        FileDialog.FilterIndex = 2
        FileDialog.RestoreDirectory = True
        FileDialog.ShowDialog()
        Photo.Text = FileDialog.FileName()
        Photo.Focus()
    End Sub

    Sub effacer_liste() ' Effacement de la liste des articles
        Dim li(0) As Object
        For Each Obj As Object In Colonne_Nom.Items
            li(UBound(li)) = Obj
            ReDim Preserve li(li.Length)
        Next
        For Each Obj As Object In li
            Colonne_Nom.Items.Remove(Obj)
        Next
        For Each Obj As Object In Colonne_description.Items
            li(UBound(li)) = Obj
            ReDim Preserve li(li.Length)
        Next
        For Each Obj As Object In li
            Colonne_description.Items.Remove(Obj)
        Next
        For Each Obj As Object In Colonne_stock.Items
            li(UBound(li)) = Obj
            ReDim Preserve li(li.Length)
        Next
        For Each Obj As Object In li
            Colonne_stock.Items.Remove(Obj)
        Next
        For Each Obj As Object In Colonne_détails.Items
            li(UBound(li)) = Obj
            ReDim Preserve li(li.Length)
        Next
        For Each Obj As Object In li
            Colonne_détails.Items.Remove(Obj)
        Next
        For Each Obj As Object In Colonne_détails2.Items
            li(UBound(li)) = Obj
            ReDim Preserve li(li.Length)
        Next
        For Each Obj As Object In li
            Colonne_détails2.Items.Remove(Obj)
        Next
        For Each Obj As Object In Colonne_détails3.Items
            li(UBound(li)) = Obj
            ReDim Preserve li(li.Length)
        Next
        For Each Obj As Object In li
            Colonne_détails3.Items.Remove(Obj)
        Next
    End Sub

    Sub effacer_champs() ' Effacer le contenu des textbox de droite
        Nom.Text = ""
        Colonne_Details.Text = ""
        Description.Text = ""
        Stock.Text = ""
        Détails.Text = ""
        Détails2.Text = ""
        Détails3.Text = ""
    End Sub

    Private Sub Bouton_LireBD(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Liste_lire.Click
        ' Actualistation de la liste des articles
        effacer_liste()
        afficher_liste()
    End Sub

    Private Sub Bouton_Nouveau(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nouveau.Click
        ' Création d'un article
        Créer_article.Show()
    End Sub

    Private Sub Bouton_EffacerListe(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Liste_effacer.Click
        ' Effacer la liste courante des articles
        effacer_liste()
        effacer_champs()
    End Sub

    Private Sub Bouton_CréerTable(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Création d'une table
        Creer_table.Show()
    End Sub

    Public Sub Surlignage_jaune()
        ' Surlignage en jaune des mots clé recherchés
        If Rechercher.Text <> "" Then
            Dim textEnd As Integer = Colonne_Details.TextLength
            Dim textEnd2 As Integer = Colonne_Details2.TextLength
            Dim textEnd3 As Integer = Colonne_Details3.TextLength
            Dim index As Integer = 0
            Dim index2 As Integer = 0
            Dim index3 As Integer = 0
            Dim lastIndex As Integer = Colonne_Details.Text.LastIndexOf(Rechercher.Text)
            Dim lastIndex2 As Integer = Colonne_Details2.Text.LastIndexOf(Rechercher.Text)
            Dim lastIndex3 As Integer = Colonne_Details3.Text.LastIndexOf(Rechercher.Text)

            While index < lastIndex
                Colonne_Details.Find(Rechercher.Text, index, textEnd, RichTextBoxFinds.None)
                Colonne_Details.SelectionBackColor = Color.Yellow
                Colonne_Details.SelectionColor = Color.Red
                Colonne_Details.SelectionFont = New Font(Colonne_Details.SelectionFont, FontStyle.Bold)
                'Colonne_Details.SelectedText = UCase(Colonne_Details.SelectedText)
                index = Colonne_Details.Text.IndexOf(Rechercher.Text, index) + 1
            End While
            While index2 < lastIndex2
                Colonne_Details2.Find(Rechercher.Text, index2, textEnd2, RichTextBoxFinds.None)
                Colonne_Details2.SelectionBackColor = Color.Yellow
                Colonne_Details2.SelectionColor = Color.Red
                Colonne_Details2.SelectionFont = New Font(Colonne_Details2.SelectionFont, FontStyle.Bold)
                'Colonne_Details2.SelectedText = UCase(Colonne_Details2.SelectedText)
                index2 = Colonne_Details2.Text.IndexOf(Rechercher.Text, index2) + 1
            End While
            While index3 < lastIndex3
                Colonne_Details3.Find(Rechercher.Text, index3, textEnd3, RichTextBoxFinds.None)
                Colonne_Details3.SelectionBackColor = Color.Yellow
                Colonne_Details3.SelectionColor = Color.Red
                Colonne_Details3.SelectionFont = New Font(Colonne_Details3.SelectionFont, FontStyle.Bold)
                'Colonne_Details3.SelectedText = UCase(Colonne_Details3.SelectedText)
                index3 = Colonne_Details3.Text.IndexOf(Rechercher.Text, index3) + 1
            End While
        End If
    End Sub

    Private Sub Liste_déroulante_Tables(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Choix_Table.SelectedIndexChanged
        ' Au changement d'une table via la liste déroulante :
        effacer_liste()
        Photo1.Image = Nothing

        If Choix_Table.Text().ToString() = "CMOS" Then
            petite_image.Image = image_cmos.Image
        ElseIf Choix_Table.Text().ToString() = "Microcontroleurs" Then
            petite_image.Image = image_pic.Image
        ElseIf Choix_Table.Text().ToString() = "Transistors" Then
            petite_image.Image = Transistor.Image
        ElseIf Choix_Table.Text().ToString() = "Circuits_linéaires" Then
            petite_image.Image = AOP.Image
        ElseIf Choix_Table.Text().ToString() = "Optoélectronique" Then
            petite_image.Image = LED.Image
        ElseIf Choix_Table.Text().ToString() = "Circuits_TTL" Then
            petite_image.Image = image_cmos.Image
        Else : petite_image.Image = Nothing
        End If

        If Choix_Table.DisplayMember = "name" Then
            effacer_champs()
            afficher_liste()
            couleur_radiobutton()
        End If
        My.Computer.Keyboard.SendKeys("{TAB}", True)
        Try
            Colonne_Nom.SelectedIndex = 0
        Catch
        End Try
        Me.TopMost = False
    End Sub

    ' Routine pour imprimer la photo
    <System.Runtime.InteropServices.DllImport("gdi32.dll")> _
    Public Shared Function BitBlt(ByVal hdcDest As IntPtr, ByVal nXDest As Integer, ByVal nYDest As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hdcSrc As IntPtr, _
 ByVal nXSrc As Integer, ByVal nYSrc As Integer, ByVal dwRop As Integer) As Long
    End Function
    'capture écran
    Private memoryImage As Bitmap
    Private Sub CaptureScreen()
        Dim mygraphics As Graphics = Me.Photo1.CreateGraphics()
        Dim s As Size = Me.Photo1.Size
        memoryImage = New Bitmap(s.Width, s.Height, mygraphics)
        Dim memoryGraphics As Graphics = Graphics.FromImage(memoryImage)
        Dim dc1 As IntPtr = mygraphics.GetHdc()
        Dim dc2 As IntPtr = memoryGraphics.GetHdc()
        BitBlt(dc2, 0, 0, Me.Photo1.ClientRectangle.Width, Me.Photo1.ClientRectangle.Height, dc1, _
         0, 0, 13369376)
        mygraphics.ReleaseHdc(dc1)
        memoryGraphics.ReleaseHdc(dc2)
    End Sub
    Private Sub printDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(memoryImage, 0, 0)
    End Sub
    Private Sub printButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_print.Click
        CaptureScreen()
        PrintDocument1.Print()
    End Sub

    ' Configuration des boutons OK et Modifier image
    Private Sub Bouton_Modifier_photo1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Bouton_modifier_image(1)
    End Sub

    Private Sub Bouton_Modifier_photo2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Bouton_modifier_image(2)
    End Sub

    Private Sub Bouton_Modifier_photo3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Bouton_modifier_image(3)
    End Sub

    Private Sub Bouton_Modifier_photo4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Bouton_modifier_image(4)
    End Sub

    Private Sub Bouton_Modifier_photo5(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Bouton_modifier_image(5)
    End Sub

    Private Sub Bouton_Modifier_photo6(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Bouton_modifier_image(6)
    End Sub

    Private Sub Bouton_Modifier_photo7(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Bouton_modifier_image(7)
    End Sub

    Private Sub Bouton_Modifier_photo8(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Bouton_modifier_image(8)
    End Sub

    Private Sub Bouton_Modifier_photo9(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Bouton_modifier_image(9)
    End Sub

    Private Sub Bouton_Modifier_photo10(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Bouton_modifier_image(10)
    End Sub

    Private Sub Bouton_OK_photo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Bouton_OK_image(1)
    End Sub

    Private Sub Bouton_OK_photo2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Bouton_OK_image(2)
    End Sub

    Private Sub Bouton_OK_photo3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Bouton_OK_image(3)
    End Sub

    Private Sub Bouton_OK_photo4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Bouton_OK_image(4)
    End Sub

    Private Sub Bouton_OK_photo5(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Bouton_OK_image(5)
    End Sub

    Private Sub Bouton_OK_photo6(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Bouton_OK_image(6)
    End Sub

    Private Sub Bouton_OK_photo7(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Bouton_OK_image(7)
    End Sub

    Private Sub Bouton_OK_photo8(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Bouton_OK_image(8)
    End Sub

    Private Sub Bouton_OK_photo9(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Bouton_OK_image(9)
    End Sub

    Private Sub Bouton_OK_photo10(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Bouton_OK_image(10)
    End Sub

    Private Sub Bouton_parcourir(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browse.Click
        ' Appel de la fonction parcourir lors du click
        parcourir()
    End Sub

    Private Sub Bouton_datasheet(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Ouvrir le fichier PDF datasheet correspondant
        Dim proc As New Diagnostics.Process
        proc.StartInfo.UseShellExecute = True
        ' Définition du fichier à ouvrir 
        proc.StartInfo.FileName = "\\laurent\Documents\electronique\Datasheets\" & Choix_Table.Text().ToString() & "\" & Nom.Text & ".pdf"
        Try
            proc.Start()
        Catch ex As Exception
            MsgBox("Pas de datasheet disponible")
        End Try
    End Sub

    Private Sub colonne_nom_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Colonne_Nom.SelectedIndexChanged
        ' Actualisation de la colonne "Nom" au changement de sélection d'un article
        Colonne_Nom.Refresh()
    End Sub

    Private Sub colonne_nom_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles Colonne_Nom.DrawItem
        ' Affichage des lignes horizontales de couleur dans la colonne "Nom" (une sur 2)
        Try
            If e.Index Mod 2 = 0 Then
                e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds)
            End If
            If Colonne_Nom.SelectedIndex = e.Index Then
                e.Graphics.FillRectangle(Brushes.Blue, e.Bounds)
                e.Graphics.DrawString(Colonne_Nom.Items(e.Index).ToString, Me.Font, Brushes.White, 0, e.Bounds.Y + 2)
            Else
                e.Graphics.DrawString(Colonne_Nom.Items(e.Index).ToString, Me.Font, Brushes.Black, 0, e.Bounds.Y + 2)
            End If
        Catch
        End Try
    End Sub

    Private Sub Colonne_Description_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles Colonne_description.DrawItem
        ' Affichage des lignes horizontales de couleur dans la colonne "Description" (une sur 2)
        If e.Index Mod 2 = 0 Then
            e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds)
        End If
        If Colonne_description.SelectedIndex = e.Index Then
            e.Graphics.FillRectangle(Brushes.Blue, e.Bounds)
            e.Graphics.DrawString(Colonne_description.Items(e.Index).ToString, Me.Font, Brushes.White, 0, e.Bounds.Y + 2)
        Else
            e.Graphics.DrawString(Colonne_description.Items(e.Index).ToString, Me.Font, Brushes.Black, 0, e.Bounds.Y + 2)
        End If
    End Sub

    Private Sub Colonne_Stock_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles Colonne_stock.DrawItem
        ' Affichage des lignes horizontales de couleur dans la colonne "Stock" (une sur 2)
        If e.Index Mod 2 = 0 Then
            e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds)
        End If
        If Colonne_stock.SelectedIndex = e.Index Then
            e.Graphics.FillRectangle(Brushes.Blue, e.Bounds)
            e.Graphics.DrawString(Colonne_stock.Items(e.Index).ToString, Me.Font, Brushes.White, 0, e.Bounds.Y + 2)
        Else
            e.Graphics.DrawString(Colonne_stock.Items(e.Index).ToString, Me.Font, Brushes.Black, 0, e.Bounds.Y + 2)
        End If
    End Sub

    Sub update_bouton_photos() ' On met tous les boutons OK et Modifier invisibles par défaut
        For Each bouton As Object In GroupBox1.Controls
            If TypeName(bouton) = "Button" Then
                bouton.visible = False
            End If
        Next
    End Sub

    Sub photos_invisibles()
        ' Par défaut tous les détails sont invisibles
        Colonne_Details.Visible = False
        Colonne_Details2.Visible = False
        Colonne_Details3.Visible = False
    End Sub

    ' Selon le Radiobutton coché, on rend visible ou non la photo
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        photos_invisibles()
        If RadioButton1.Checked = True Then
            Colonne_Details.Visible = True
            If Rechercher.Text <> "" Then
                Colonne_Details.Text = LCase(Colonne_Details.Text)
            End If
            Surlignage_jaune()
            Photo1.Size = New Size(631, 400)
            Affichage_images(1)
        End If
        update_bouton_photos()
        update_radiobutton()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        photos_invisibles()
        If RadioButton2.Checked = True Then
            Colonne_Details2.Visible = True
            If Rechercher.Text <> "" Then
                Colonne_Details2.Text = LCase(Colonne_Details2.Text)
            End If
            Surlignage_jaune()
            Photo1.Size = New Size(631, 400)
            Affichage_images(2)
        End If
        update_bouton_photos()
        update_radiobutton()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        photos_invisibles()
        If RadioButton3.Checked = True Then
            Colonne_Details3.Visible = True
            If Rechercher.Text <> "" Then
                Colonne_Details3.Text = LCase(Colonne_Details3.Text)
            End If
            Surlignage_jaune()
            Photo1.Size = New Size(631, 400)
            Affichage_images(3)
        End If
        update_bouton_photos()
        update_radiobutton()
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        photos_invisibles()
        If RadioButton4.Checked = True Then
            Photo1.Size = New Size(1023, 400)
            Affichage_images(4)
        End If
        update_bouton_photos()
        update_radiobutton()
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        photos_invisibles()
        If RadioButton5.Checked = True Then
            Photo1.Size = New Size(1023, 400)
            Affichage_images(5)
        End If
        update_bouton_photos()
        update_radiobutton()
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        photos_invisibles()
        If RadioButton6.Checked = True Then
            Photo1.Size = New Size(1023, 400)
            Affichage_images(6)
        End If
        update_bouton_photos()
        update_radiobutton()
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        photos_invisibles()
        If RadioButton7.Checked = True Then
            Photo1.Size = New Size(1023, 400)
            Affichage_images(7)
        End If
        update_bouton_photos()
        update_radiobutton()
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        photos_invisibles()
        If RadioButton8.Checked = True Then
            Photo1.Size = New Size(1023, 400)
            Affichage_images(8)
        End If
        update_bouton_photos()
        update_radiobutton()
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        photos_invisibles()
        If RadioButton9.Checked = True Then
            Photo1.Size = New Size(1023, 400)
            Affichage_images(9)
        End If
        update_bouton_photos()
        update_radiobutton()
    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged
        photos_invisibles()
        If RadioButton10.Checked = True Then
            Photo1.Size = New Size(1023, 400)
            Affichage_images(10)
        End If
        update_bouton_photos()
        update_radiobutton()
    End Sub

    Private Sub Rechercher_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rechercher.TextChanged
        If Rechercher.Text <> "" Then
            Compteur.Text = ""
            Compteur.Visible = True
        Else
            Compteur.Visible = False
        End If
    End Sub

End Class


