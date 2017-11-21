Public Class frmEtudiants
    Private Sub frmEtudiants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        daEtudiants.Fill(DsEtudiants1.T_etudiants)
    End Sub

    Private Sub cmdNouveau_Click(sender As Object, e As EventArgs) Handles cmdNouveau.Click
        Barrer_Debarrer(True)
        EtudiantsBindingSource.AddNew()
    End Sub

    Private Sub Barrer_Debarrer(Lock As Boolean)
        grpEtudiants.Enabled = Lock
        cmdAnnuler.Enabled = Lock
        cmdEnlever.Enabled = Not Lock
        cmdModifier.Enabled = Not Lock
        cmdOK.Enabled = Lock
        cmdNouveau.Enabled = Not Lock
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        Try
            EtudiantsBindingSource.EndEdit()
            daEtudiants.Update(DsEtudiants1.T_etudiants)
            MsgBox("Table Programme mise a jour")
            cmdAnnuler.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message)
            DsEtudiants1.T_etudiants.RejectChanges()
        End Try
    End Sub
End Class