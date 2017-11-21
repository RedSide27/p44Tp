<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEtudiants
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
        Me.components = New System.ComponentModel.Container()
        Me.cmdEnlever = New System.Windows.Forms.Button()
        Me.cmdModifier = New System.Windows.Forms.Button()
        Me.cmdAnnuler = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdNouveau = New System.Windows.Forms.Button()
        Me.grpEtudiants = New System.Windows.Forms.GroupBox()
        Me.cboNoProgramme = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.mskTel = New System.Windows.Forms.MaskedTextBox()
        Me.mskCp = New System.Windows.Forms.MaskedTextBox()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblCodePostal = New System.Windows.Forms.Label()
        Me.cboProvince = New System.Windows.Forms.ComboBox()
        Me.lblProvince = New System.Windows.Forms.Label()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.lblVille = New System.Windows.Forms.Label()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.lblNoProg = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblDA = New System.Windows.Forms.Label()
        Me.dgEtudiants = New System.Windows.Forms.DataGridView()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.grpEtudiants.SuspendLayout()
        CType(Me.dgEtudiants, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdEnlever
        '
        Me.cmdEnlever.Location = New System.Drawing.Point(1186, 156)
        Me.cmdEnlever.Name = "cmdEnlever"
        Me.cmdEnlever.Size = New System.Drawing.Size(134, 30)
        Me.cmdEnlever.TabIndex = 22
        Me.cmdEnlever.Text = "Enlever"
        Me.cmdEnlever.UseVisualStyleBackColor = True
        '
        'cmdModifier
        '
        Me.cmdModifier.Location = New System.Drawing.Point(1186, 120)
        Me.cmdModifier.Name = "cmdModifier"
        Me.cmdModifier.Size = New System.Drawing.Size(134, 30)
        Me.cmdModifier.TabIndex = 21
        Me.cmdModifier.Text = "Modifier"
        Me.cmdModifier.UseVisualStyleBackColor = True
        '
        'cmdAnnuler
        '
        Me.cmdAnnuler.Enabled = False
        Me.cmdAnnuler.Location = New System.Drawing.Point(1186, 84)
        Me.cmdAnnuler.Name = "cmdAnnuler"
        Me.cmdAnnuler.Size = New System.Drawing.Size(134, 30)
        Me.cmdAnnuler.TabIndex = 20
        Me.cmdAnnuler.Text = "Annuler"
        Me.cmdAnnuler.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Enabled = False
        Me.cmdOK.Location = New System.Drawing.Point(1186, 48)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(134, 30)
        Me.cmdOK.TabIndex = 19
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdNouveau
        '
        Me.cmdNouveau.Location = New System.Drawing.Point(1186, 12)
        Me.cmdNouveau.Name = "cmdNouveau"
        Me.cmdNouveau.Size = New System.Drawing.Size(134, 30)
        Me.cmdNouveau.TabIndex = 18
        Me.cmdNouveau.Text = "Nouveau"
        Me.cmdNouveau.UseVisualStyleBackColor = True
        '
        'grpEtudiants
        '
        Me.grpEtudiants.Controls.Add(Me.cboNoProgramme)
        Me.grpEtudiants.Controls.Add(Me.TextBox1)
        Me.grpEtudiants.Controls.Add(Me.mskTel)
        Me.grpEtudiants.Controls.Add(Me.mskCp)
        Me.grpEtudiants.Controls.Add(Me.lblTelephone)
        Me.grpEtudiants.Controls.Add(Me.lblCodePostal)
        Me.grpEtudiants.Controls.Add(Me.cboProvince)
        Me.grpEtudiants.Controls.Add(Me.lblProvince)
        Me.grpEtudiants.Controls.Add(Me.txtAdresse)
        Me.grpEtudiants.Controls.Add(Me.lblAdresse)
        Me.grpEtudiants.Controls.Add(Me.txtVille)
        Me.grpEtudiants.Controls.Add(Me.lblVille)
        Me.grpEtudiants.Controls.Add(Me.txtPrenom)
        Me.grpEtudiants.Controls.Add(Me.lblPrenom)
        Me.grpEtudiants.Controls.Add(Me.lblNoProg)
        Me.grpEtudiants.Controls.Add(Me.txtNom)
        Me.grpEtudiants.Controls.Add(Me.txtNo)
        Me.grpEtudiants.Controls.Add(Me.lblNom)
        Me.grpEtudiants.Controls.Add(Me.lblDA)
        Me.grpEtudiants.Location = New System.Drawing.Point(12, 12)
        Me.grpEtudiants.Name = "grpEtudiants"
        Me.grpEtudiants.Size = New System.Drawing.Size(1051, 325)
        Me.grpEtudiants.TabIndex = 17
        Me.grpEtudiants.TabStop = False
        Me.grpEtudiants.Text = "Étudiants"
        '
        'cboNoProgramme
        '
        Me.cboNoProgramme.FormattingEnabled = True
        Me.cboNoProgramme.Location = New System.Drawing.Point(146, 82)
        Me.cboNoProgramme.Name = "cboNoProgramme"
        Me.cboNoProgramme.Size = New System.Drawing.Size(126, 30)
        Me.cboNoProgramme.TabIndex = 23
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(146, 188)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(126, 29)
        Me.TextBox1.TabIndex = 22
        '
        'mskTel
        '
        Me.mskTel.Location = New System.Drawing.Point(541, 196)
        Me.mskTel.Mask = "(000) 000-0000"
        Me.mskTel.Name = "mskTel"
        Me.mskTel.Size = New System.Drawing.Size(141, 29)
        Me.mskTel.TabIndex = 10
        '
        'mskCp
        '
        Me.mskCp.Location = New System.Drawing.Point(541, 161)
        Me.mskCp.Mask = "L0L-0L0"
        Me.mskCp.Name = "mskCp"
        Me.mskCp.Size = New System.Drawing.Size(91, 29)
        Me.mskCp.TabIndex = 9
        '
        'lblTelephone
        '
        Me.lblTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTelephone.Location = New System.Drawing.Point(411, 196)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(124, 29)
        Me.lblTelephone.TabIndex = 20
        Me.lblTelephone.Text = "Telephone:"
        '
        'lblCodePostal
        '
        Me.lblCodePostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodePostal.Location = New System.Drawing.Point(411, 159)
        Me.lblCodePostal.Name = "lblCodePostal"
        Me.lblCodePostal.Size = New System.Drawing.Size(124, 29)
        Me.lblCodePostal.TabIndex = 18
        Me.lblCodePostal.Text = "Code Postal"
        '
        'cboProvince
        '
        Me.cboProvince.FormattingEnabled = True
        Me.cboProvince.Location = New System.Drawing.Point(541, 122)
        Me.cboProvince.Name = "cboProvince"
        Me.cboProvince.Size = New System.Drawing.Size(255, 30)
        Me.cboProvince.TabIndex = 8
        '
        'lblProvince
        '
        Me.lblProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProvince.Location = New System.Drawing.Point(411, 123)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(124, 29)
        Me.lblProvince.TabIndex = 16
        Me.lblProvince.Text = "Province"
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(541, 41)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(362, 29)
        Me.txtAdresse.TabIndex = 6
        '
        'lblAdresse
        '
        Me.lblAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdresse.Location = New System.Drawing.Point(411, 43)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(124, 29)
        Me.lblAdresse.TabIndex = 14
        Me.lblAdresse.Text = "Adresse:"
        '
        'txtVille
        '
        Me.txtVille.Location = New System.Drawing.Point(541, 82)
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(300, 29)
        Me.txtVille.TabIndex = 7
        '
        'lblVille
        '
        Me.lblVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVille.Location = New System.Drawing.Point(411, 84)
        Me.lblVille.Name = "lblVille"
        Me.lblVille.Size = New System.Drawing.Size(124, 29)
        Me.lblVille.TabIndex = 12
        Me.lblVille.Text = "Ville:"
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(146, 121)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(255, 29)
        Me.txtPrenom.TabIndex = 3
        '
        'lblPrenom
        '
        Me.lblPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrenom.Location = New System.Drawing.Point(16, 123)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(124, 29)
        Me.lblPrenom.TabIndex = 9
        Me.lblPrenom.Text = "Prénom:"
        '
        'lblNoProg
        '
        Me.lblNoProg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNoProg.Location = New System.Drawing.Point(16, 84)
        Me.lblNoProg.Name = "lblNoProg"
        Me.lblNoProg.Size = New System.Drawing.Size(124, 29)
        Me.lblNoProg.TabIndex = 7
        Me.lblNoProg.Text = "No. Prog:"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(146, 154)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(255, 29)
        Me.txtNom.TabIndex = 4
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(146, 43)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(126, 29)
        Me.txtNo.TabIndex = 1
        '
        'lblNom
        '
        Me.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNom.Location = New System.Drawing.Point(16, 156)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(124, 29)
        Me.lblNom.TabIndex = 2
        Me.lblNom.Text = "Nom:"
        '
        'lblDA
        '
        Me.lblDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDA.Location = New System.Drawing.Point(16, 43)
        Me.lblDA.Name = "lblDA"
        Me.lblDA.Size = New System.Drawing.Size(124, 29)
        Me.lblDA.TabIndex = 1
        Me.lblDA.Text = "DA:"
        '
        'dgEtudiants
        '
        Me.dgEtudiants.AllowUserToAddRows = False
        Me.dgEtudiants.AllowUserToDeleteRows = False
        Me.dgEtudiants.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgEtudiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEtudiants.Location = New System.Drawing.Point(12, 367)
        Me.dgEtudiants.MultiSelect = False
        Me.dgEtudiants.Name = "dgEtudiants"
        Me.dgEtudiants.ReadOnly = True
        Me.dgEtudiants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEtudiants.Size = New System.Drawing.Size(1310, 486)
        Me.dgEtudiants.TabIndex = 23
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'frmEtudiants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1441, 898)
        Me.Controls.Add(Me.dgEtudiants)
        Me.Controls.Add(Me.cmdEnlever)
        Me.Controls.Add(Me.cmdModifier)
        Me.Controls.Add(Me.cmdAnnuler)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdNouveau)
        Me.Controls.Add(Me.grpEtudiants)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmEtudiants"
        Me.Text = "frmEtudiants"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpEtudiants.ResumeLayout(False)
        Me.grpEtudiants.PerformLayout()
        CType(Me.dgEtudiants, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdEnlever As Button
    Friend WithEvents cmdModifier As Button
    Friend WithEvents cmdAnnuler As Button
    Friend WithEvents cmdOK As Button
    Friend WithEvents cmdNouveau As Button
    Friend WithEvents grpEtudiants As GroupBox
    Friend WithEvents mskTel As MaskedTextBox
    Friend WithEvents mskCp As MaskedTextBox
    Friend WithEvents lblTelephone As Label
    Friend WithEvents lblCodePostal As Label
    Friend WithEvents cboProvince As ComboBox
    Friend WithEvents lblProvince As Label
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents lblAdresse As Label
    Friend WithEvents txtVille As TextBox
    Friend WithEvents lblVille As Label
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents lblPrenom As Label
    Friend WithEvents lblNoProg As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtNo As TextBox
    Friend WithEvents lblNom As Label
    Friend WithEvents lblDA As Label
    Friend WithEvents dgEtudiants As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cboNoProgramme As ComboBox
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
End Class
