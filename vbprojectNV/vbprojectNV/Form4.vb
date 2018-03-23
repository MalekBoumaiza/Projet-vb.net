Public Class Form4

    Dim con As New MySqlConnection("server=localhost;user id=root;database=datavb")

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        con.Open()
        Dim requete As String = "select * from livre "
        Dim cmd As New MySqlCommand(requete, con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGrid.DataSource = table


        Dim requete2 As String = "select * from users where login='" + Form1.log.Text + "' and pwd='" + Form1.pw.Text + "'"
        Dim cmd2 As New MySqlCommand(requete2, con)
        Dim MonReader As MySqlDataReader = cmd2.ExecuteReader()
        If MonReader.Read() Then
            statut.Text = "bienvenu " + MonReader("prenom").ToString + " " + MonReader("nom").ToString + "  vous étes connecté en tant qu'utilisateur"
        End If


    End Sub

   
    
    Private Sub categorie_Click(sender As System.Object, e As System.EventArgs) Handles categorie.Click

        Dim requete As String = "select * from livre where CONCAT(categorie) like '" & textbox.Text & "'"
        Dim cmd As New MySqlCommand(requete, con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGrid.DataSource = table

    End Sub

    Private Sub auteur_Click(sender As System.Object, e As System.EventArgs) Handles auteur.Click
        Dim requete As String = "select * from livre where CONCAT(auteur) like '" & textbox.Text & "'"
        Dim cmd As New MySqlCommand(requete, con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGrid.DataSource = table
    End Sub

    Private Sub titre_Click(sender As System.Object, e As System.EventArgs) Handles titre.Click
        Dim requete As String = "select * from livre where CONCAT(titre) like '" & textbox.Text & "'"
        Dim cmd As New MySqlCommand(requete, con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGrid.DataSource = table
    End Sub

    Private Sub dispo_Click(sender As System.Object, e As System.EventArgs) Handles dispo.Click
        Dim requete As String = "select * from livre where dispo='oui'"
        Dim cmd As New MySqlCommand(requete, con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGrid.DataSource = table
    End Sub

    Private Sub TheEmpireButton3_Click(sender As System.Object, e As System.EventArgs) Handles TheEmpireButton3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    
    Private Sub TheEmpireButton1_Click(sender As System.Object, e As System.EventArgs) Handles emprunter.Click
       
        Dim row As DataGridViewRow
        row = Me.DataGrid.Rows(ee.RowIndex)
        Dim requete As String = "insert into emprunts(isbn) value( '" + row.Cells("isbn").Value.ToString + "' "
        Dim cmd As New MySqlCommand(requete, con)


    End Sub

End Class