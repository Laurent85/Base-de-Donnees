Imports System.Data
Imports System.Data.SqlClient

Public Class Creer_table

    Private Sub Bouton_OK(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim base_laurent As New SqlConnection("server=LAURENT\SQLEXPRESS;database=laurent;user id=sa;password=sa;integrated security=false")
        Dim MyCommand As New SqlCommand("Create Table " & TextBox1.Text & "(Nom Varchar(50) PRIMARY KEY, Stock Int, Description Varchar(max), Détails Varchar(max), Détails1 Varchar(max), Détails2 Varchar(max))", base_laurent)
        base_laurent.Open()
        MyCommand.ExecuteNonQuery()
        base_laurent.Close()
        Me.Close()
        General.afficher_tables()
        MessageBox.Show("Création table OK")
    End Sub
End Class