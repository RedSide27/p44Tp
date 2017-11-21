Imports System.Data.SqlClient
Public Class frmProgramme
    Private Sub frmProgramme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            daProgramme.Fill(DsProgramme1.T_programme)
            daEtudiants.SelectCommand.Parameters.Item("@NoProg").Value = ProgrammeBindingSource.Item(0).Row("pro_no")
            daEtudiants.Fill(DsProgramme1.T_etudiants)
            txtno.DataBindings.Add("text", ProgrammeBindingSource, "pro_no")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmdNouveau_Click(sender As Object, e As EventArgs) Handles cmdNouveau.Click
        Barrer_Debarrer(True)
        ProgrammeBindingSource.AddNew() ' sa vide l'ecran
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        Try
            If Verif_Champs() = True Then
                ProgrammeBindingSource.EndEdit()
                daProgramme.Update(DsProgramme1.T_programme)
                MsgBox("Table Programme mise a jour")
                cmdAnnuler.PerformClick()
                Err1.Clear()
            End If
        Catch ex As SqlException
            MsgBox(ex.Message & " " & ex.Number)
        Catch ex As Exception
            MsgBox(ex.Message)
            DsProgramme1.T_programme.RejectChanges()
        End Try
    End Sub

    Private Sub cmdAnnuler_Click(sender As Object, e As EventArgs) Handles cmdAnnuler.Click
        Barrer_Debarrer(False)
        Err1.Clear()
        ProgrammeBindingSource.CancelEdit()
    End Sub

    Private Sub cmdModifier_Click(sender As Object, e As EventArgs) Handles cmdModifier.Click
        grpProgramme.Enabled = True
        Barrer_Debarrer(True)
    End Sub

    Private Sub cmdEnlever_Click(sender As Object, e As EventArgs) Handles cmdEnlever.Click
        Try
            If MsgBox("êtes-vous sur de vouloir supprimer le programme ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                ProgrammeBindingSource.RemoveCurrent()
                daProgramme.Update(DsProgramme1.T_programme)
                MsgBox("Clients enlever avec succes")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            DsProgramme1.T_programme.RejectChanges()
        End Try
    End Sub

    Private Sub Barrer_Debarrer(Lock As Boolean)
        grpProgramme.Enabled = Lock
        cmdAnnuler.Enabled = Lock
        cmdEnlever.Enabled = Not Lock
        cmdModifier.Enabled = Not Lock
        cmdOK.Enabled = Lock
        cmdNouveau.Enabled = Not Lock
    End Sub

    Private Sub txtNom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom.KeyPress
        e.Handled = Char.IsDigit(e.KeyChar)
    End Sub

    Private Sub txtNbrUnites_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNbrUnites.KeyPress
        Dim Caractere As String = "0123456789,"
        If (e.KeyChar = Convert.ToChar(Keys.Back)) Then
            Exit Sub
        ElseIf Not Caractere.Contains(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtNbrHeure_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNbrHeure.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Function Verif_Champs() As Boolean
        Err1.Clear()
        Dim x As Boolean = True
        If txtNom.Text = "" Then
            Err1.SetError(txtNom, "Nom Invalide")
            x = False
        End If
        If txtNbrUnites.Text = "" Then
            Err1.SetError(txtNbrUnites, "Nombre D'Unité Invalide")
            x = False
        End If
        If txtNbrHeure.Text = "" Then
            Err1.SetError(txtNbrHeure, "Nombre D'Heure Invalide")
            x = False
        End If
        Return x
    End Function

    Private Sub dgProgramme_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProgramme.CellContentClick
        DsProgramme1.T_etudiants.Clear()

        If dgEtudiants.RowCount = 0 Then
            daEtudiants.SelectCommand.Parameters.Item("@NoProg").Value = ProgrammeBindingSource.Current().Row("pro_no")
            daEtudiants.Fill(DsProgramme1.T_etudiants)

        End If
    End Sub
End Class