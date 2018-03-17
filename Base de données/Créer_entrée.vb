Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class Créer_article
    Dim Base_laurent As SqlConnection = New SqlConnection()

    Sub afficher_tables() ' Affichage du nom des tables dans la liste déroulante
        Dim base_laurent As New SqlConnection("server=LAURENT\SQLEXPRESS;database=laurent;user id=sa;password=sa;integrated security=false")
        Dim da As New SqlDataAdapter("SELECT name FROM sysobjects WHERE xtype= 'U' AND name <> 'Images' AND name <> 'Images1' AND name <> 'Images2' AND name <> 'Images3' AND name <> 'Images4' AND name <> 'Images5' AND name <> 'Images6' AND name <> 'Images7' AND name <> 'Images8' AND name <> 'Images9' AND name <> 'Images10' ORDER BY name", base_laurent)
        Dim ds As New DataSet
        da.Fill(ds)
        Choix_table.DisplayMember = "name"
        Choix_table.DataSource = ds.Tables(0)
    End Sub

    Sub parcourir1()
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

    Private Sub Bouton_OK(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim Base_laurent As New SqlConnection("server=LAURENT\SQLEXPRESS;database=laurent;user id=sa;password=sa;integrated security=false")
        Dim fName As String = Photo.Text
        Dim id As Integer = 1
        Dim content As Byte() = General.ImageToStream(fName)

        Base_laurent.Open()

        Dim Détails_modif As String = Détails.Text.Replace("'", "''")
        Dim MyCommand As New SqlCommand("insert into " & Choix_table.Text().ToString() & " values('" & Nom.Text & "','" & Description.Text & "','" & Stock.Text & "','" & Détails_modif & "','" & CP.Text & "','" & Ville.Text & "')", Base_laurent)
        Dim MyCommand_tous As New SqlCommand("insert into tous values('" & Nom.Text & "','" & Description.Text & "','" & Stock.Text & "','" & Détails_modif & "','" & CP.Text & "','" & Ville.Text & "')", Base_laurent)
        Try
            MyCommand.ExecuteNonQuery()
            MyCommand_tous.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Ce composant existe déjà !", MsgBoxStyle.Critical)
        End Try
        Dim MyCommand1 As New SqlCommand("insert into images4 values ('" & Nom.Text & "', (@photo),'" & Nom.Text & "','" & Ville.Text & "','" & CP.Text & "','" & Ville.Text & "')", Base_laurent)

        If Photo.Text <> "" Then
            Try
                MyCommand1.Parameters.AddWithValue("@photo", content)
                MyCommand1.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Cette photo existe déjà !", MsgBoxStyle.Critical)
            End Try
        End If

        MessageBox.Show("Composant ajouté")
        Base_laurent.Close()
        General.effacer_champs()
        General.effacer_liste()
        General.afficher_liste()
        General.Choix_Table.SelectedIndex = Choix_table.SelectedIndex
        General.Colonne_Nom.SelectedItem = Nom.Text
        Me.Close()
    End Sub

    Private Sub Bouton_Annuler(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Lancement_Fenêtre(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = General.Nom_Colonne(0)
        Label2.Text = General.Nom_Colonne(1)
        Label3.Text = General.Nom_Colonne(2)
        Label5.Text = General.Nom_Colonne(3)
        Label6.Text = General.Nom_Colonne(4)
        Label7.Text = General.Nom_Colonne(5)
        afficher_tables()
        Choix_table.SelectedIndex = General.Choix_Table.SelectedIndex
        If General.Nom_Colonne(0).ToString.Contains("Détails") Then
            Label1.Visible = False
            Nom.Visible = False
        Else
            Label1.Visible = True
            Nom.Visible = True
        End If
        If General.Nom_Colonne(1).ToString.Contains("Détails") Then
            Label2.Visible = False
            Description.Visible = False
        Else
            Label2.Visible = True
            Description.Visible = True
        End If
        If General.Nom_Colonne(2).ToString.Contains("Détails") Then
            Label3.Visible = False
            Stock.Visible = False
        Else
            Label3.Visible = True
            Stock.Visible = True
        End If
        If General.Nom_Colonne(3).ToString.Contains("Détails") Then
            Label5.Visible = False
            Adresse.Visible = False
        Else
            Label5.Visible = True
            Adresse.Visible = True
        End If
        If General.Nom_Colonne(4).ToString.Contains("Détails") Then
            Label6.Visible = False
            CP.Visible = False
        Else
            Label6.Visible = True
            CP.Visible = True
        End If
        If General.Nom_Colonne(5).ToString.Contains("Détails") Then
            Label7.Visible = False
            Ville.Visible = False
        Else
            Label7.Visible = True
            Ville.Visible = True
        End If
    End Sub

    Private Sub Parcourir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Parcourir.Click
        parcourir1()
    End Sub

End Class