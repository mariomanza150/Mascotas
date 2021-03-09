Public Class Landing
    Private Sub pic_pet_Click(sender As Object, e As EventArgs) Handles pic_pet.Click
        Pets.Show()
        Me.Close()
    End Sub

    Private Sub pic_race_Click(sender As Object, e As EventArgs) Handles pic_race.Click
        Races.Show()
        Me.Close()
    End Sub

    Private Sub bttn_exit_Click(sender As Object, e As EventArgs) Handles bttn_exit.Click
        Me.Close()
    End Sub
End Class
