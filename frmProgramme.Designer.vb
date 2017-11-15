<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgramme
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdEnlever = New System.Windows.Forms.Button()
        Me.cmdModifier = New System.Windows.Forms.Button()
        Me.cmdAnnuler = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdNouveau = New System.Windows.Forms.Button()
        Me.grpProgramme = New System.Windows.Forms.GroupBox()
        Me.txtno = New System.Windows.Forms.MaskedTextBox()
        Me.txtNbrHeure = New System.Windows.Forms.TextBox()
        Me.txtNbrUnites = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblNbrHeure = New System.Windows.Forms.Label()
        Me.lblNbrUnite = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblNo = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.grpProgramme.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdEnlever
        '
        Me.cmdEnlever.Location = New System.Drawing.Point(510, 169)
        Me.cmdEnlever.Name = "cmdEnlever"
        Me.cmdEnlever.Size = New System.Drawing.Size(134, 30)
        Me.cmdEnlever.TabIndex = 11
        Me.cmdEnlever.Text = "Enlever"
        Me.cmdEnlever.UseVisualStyleBackColor = True
        '
        'cmdModifier
        '
        Me.cmdModifier.Location = New System.Drawing.Point(510, 133)
        Me.cmdModifier.Name = "cmdModifier"
        Me.cmdModifier.Size = New System.Drawing.Size(134, 30)
        Me.cmdModifier.TabIndex = 10
        Me.cmdModifier.Text = "Modifier"
        Me.cmdModifier.UseVisualStyleBackColor = True
        '
        'cmdAnnuler
        '
        Me.cmdAnnuler.Enabled = False
        Me.cmdAnnuler.Location = New System.Drawing.Point(510, 97)
        Me.cmdAnnuler.Name = "cmdAnnuler"
        Me.cmdAnnuler.Size = New System.Drawing.Size(134, 30)
        Me.cmdAnnuler.TabIndex = 9
        Me.cmdAnnuler.Text = "Annuler"
        Me.cmdAnnuler.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Enabled = False
        Me.cmdOK.Location = New System.Drawing.Point(510, 61)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(134, 30)
        Me.cmdOK.TabIndex = 8
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdNouveau
        '
        Me.cmdNouveau.Location = New System.Drawing.Point(510, 25)
        Me.cmdNouveau.Name = "cmdNouveau"
        Me.cmdNouveau.Size = New System.Drawing.Size(134, 30)
        Me.cmdNouveau.TabIndex = 7
        Me.cmdNouveau.Text = "Nouveau"
        Me.cmdNouveau.UseVisualStyleBackColor = True
        '
        'grpProgramme
        '
        Me.grpProgramme.Controls.Add(Me.txtno)
        Me.grpProgramme.Controls.Add(Me.txtNbrHeure)
        Me.grpProgramme.Controls.Add(Me.txtNbrUnites)
        Me.grpProgramme.Controls.Add(Me.txtNom)
        Me.grpProgramme.Controls.Add(Me.lblNbrHeure)
        Me.grpProgramme.Controls.Add(Me.lblNbrUnite)
        Me.grpProgramme.Controls.Add(Me.lblNom)
        Me.grpProgramme.Controls.Add(Me.lblNo)
        Me.grpProgramme.Enabled = False
        Me.grpProgramme.Location = New System.Drawing.Point(12, 12)
        Me.grpProgramme.Name = "grpProgramme"
        Me.grpProgramme.Size = New System.Drawing.Size(442, 219)
        Me.grpProgramme.TabIndex = 6
        Me.grpProgramme.TabStop = False
        Me.grpProgramme.Text = "Programme"
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(146, 43)
        Me.txtno.Mask = "LLL.0L"
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(126, 29)
        Me.txtno.TabIndex = 9
        '
        'txtNbrHeure
        '
        Me.txtNbrHeure.Location = New System.Drawing.Point(146, 168)
        Me.txtNbrHeure.Name = "txtNbrHeure"
        Me.txtNbrHeure.Size = New System.Drawing.Size(126, 29)
        Me.txtNbrHeure.TabIndex = 8
        '
        'txtNbrUnites
        '
        Me.txtNbrUnites.Location = New System.Drawing.Point(146, 124)
        Me.txtNbrUnites.Name = "txtNbrUnites"
        Me.txtNbrUnites.Size = New System.Drawing.Size(126, 29)
        Me.txtNbrUnites.TabIndex = 7
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(146, 80)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(255, 29)
        Me.txtNom.TabIndex = 6
        '
        'lblNbrHeure
        '
        Me.lblNbrHeure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNbrHeure.Location = New System.Drawing.Point(16, 168)
        Me.lblNbrHeure.Name = "lblNbrHeure"
        Me.lblNbrHeure.Size = New System.Drawing.Size(124, 29)
        Me.lblNbrHeure.TabIndex = 4
        Me.lblNbrHeure.Text = "Nbr Heure:"
        '
        'lblNbrUnite
        '
        Me.lblNbrUnite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNbrUnite.Location = New System.Drawing.Point(16, 124)
        Me.lblNbrUnite.Name = "lblNbrUnite"
        Me.lblNbrUnite.Size = New System.Drawing.Size(124, 29)
        Me.lblNbrUnite.TabIndex = 3
        Me.lblNbrUnite.Text = "Nbr Unites:"
        '
        'lblNom
        '
        Me.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNom.Location = New System.Drawing.Point(16, 80)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(124, 29)
        Me.lblNom.TabIndex = 2
        Me.lblNom.Text = "Nom:"
        '
        'lblNo
        '
        Me.lblNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNo.Location = New System.Drawing.Point(16, 43)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(124, 29)
        Me.lblNo.TabIndex = 1
        Me.lblNo.Text = "No:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 237)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(672, 616)
        Me.DataGridView1.TabIndex = 12
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(702, 25)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(684, 828)
        Me.DataGridView2.TabIndex = 13
        '
        'frmProgramme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1441, 898)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmdEnlever)
        Me.Controls.Add(Me.cmdModifier)
        Me.Controls.Add(Me.cmdAnnuler)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdNouveau)
        Me.Controls.Add(Me.grpProgramme)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmProgramme"
        Me.Text = "frmProgramme"
        Me.grpProgramme.ResumeLayout(False)
        Me.grpProgramme.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdEnlever As Button
    Friend WithEvents cmdModifier As Button
    Friend WithEvents cmdAnnuler As Button
    Friend WithEvents cmdOK As Button
    Friend WithEvents cmdNouveau As Button
    Friend WithEvents grpProgramme As GroupBox
    Friend WithEvents txtno As MaskedTextBox
    Friend WithEvents txtNbrHeure As TextBox
    Friend WithEvents txtNbrUnites As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents lblNbrHeure As Label
    Friend WithEvents lblNbrUnite As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblNo As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
End Class
