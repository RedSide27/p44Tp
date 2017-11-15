Public Class frmEtudiants
    Private Sub frmEtudiants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        daEtudiants.Fill(DsEtudiants1.T_etudiants)
    End Sub
End Class