Public Class frmProgramme
    Private Sub cmdNouveau_Click(sender As Object, e As EventArgs) Handles cmdNouveau.Click

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

    End Sub

    Private Sub cmdAnnuler_Click(sender As Object, e As EventArgs) Handles cmdAnnuler.Click

    End Sub

    Private Sub cmdModifier_Click(sender As Object, e As EventArgs) Handles cmdModifier.Click

    End Sub

    Private Sub cmdEnlever_Click(sender As Object, e As EventArgs) Handles cmdEnlever.Click

    End Sub

    Private Sub Barrer_Debarrer(Lock As Boolean)
        grpProgramme.Enabled = Lock
        cmdAnnuler.Enabled = Lock
        cmdEnlever.Enabled = Not Lock
        cmdModifier.Enabled = Not Lock
        cmdOK.Enabled = Lock
        cmdNouveau.Enabled = Not Lock
    End Sub

    Private Sub frmProgramme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        daProgramme.Fill(DsProgramme1.T_programme)
        'daEtudiants.Fill(DsProgramme1.T_etudiants)
    End Sub

    Private Sub dgProgramme_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProgramme.CellContentClick

    End Sub
End Class