Imports MySql.Data.MySqlClient

Public Class Form1

    Dim con As New MySqlConnection("server=localhost;user id=root;database=datavb")

    Private Sub inscri_Click(sender As System.Object, e As System.EventArgs) Handles inscri.Click
        Form2.Show()
        Me.Hide()
    End Sub

   
  
    Private Sub connexion_Click(sender As System.Object, e As System.EventArgs) Handles connexion.Click


        con.Open()
        Dim requete As String = "select * from users where login='" + log.Text + "' and pwd='" + pw.Text + "'"
        Dim cmd As New MySqlCommand(requete, con)
        Dim MonReader As MySqlDataReader = cmd.ExecuteReader()

        If MonReader.Read() Then

            If (MonReader("profil").ToString) = "admin" Then

                Form3.Show()
                Me.Hide()
            Else

                Form4.Show()
                Me.Hide()
            End If

        Else
            MsgBox("Aucun utilisateur trouvé")
        End If
        con.Close()
    End Sub

End Class
