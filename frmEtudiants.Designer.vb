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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEtudiants))
        Me.cmdEnlever = New System.Windows.Forms.Button()
        Me.cmdModifier = New System.Windows.Forms.Button()
        Me.cmdAnnuler = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdNouveau = New System.Windows.Forms.Button()
        Me.grpEtudiants = New System.Windows.Forms.GroupBox()
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
        Me.grpSexe = New System.Windows.Forms.GroupBox()
        Me.optMasculin = New System.Windows.Forms.RadioButton()
        Me.optFeminin = New System.Windows.Forms.RadioButton()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.lblNoProg = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblDA = New System.Windows.Forms.Label()
        Me.dgEtudiants = New System.Windows.Forms.DataGridView()
        Me.EtudiantsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daEtudiants = New System.Data.SqlClient.SqlDataAdapter()
        Me.cnEtudiants = New System.Data.SqlClient.SqlConnection()
        Me.DsEtudiants1 = New p44Tp.DsEtudiants()
        Me.EtudaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuprenomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtunomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtusexeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuadresseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuvilleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuprovinceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtutelephoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtucodepostalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtProg = New System.Windows.Forms.MaskedTextBox()
        Me.grpEtudiants.SuspendLayout()
        Me.grpSexe.SuspendLayout()
        CType(Me.dgEtudiants, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EtudiantsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEtudiants1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.grpEtudiants.Controls.Add(Me.txtProg)
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
        Me.grpEtudiants.Controls.Add(Me.grpSexe)
        Me.grpEtudiants.Controls.Add(Me.txtPrenom)
        Me.grpEtudiants.Controls.Add(Me.lblPrenom)
        Me.grpEtudiants.Controls.Add(Me.lblNoProg)
        Me.grpEtudiants.Controls.Add(Me.txtNom)
        Me.grpEtudiants.Controls.Add(Me.txtNo)
        Me.grpEtudiants.Controls.Add(Me.lblNom)
        Me.grpEtudiants.Controls.Add(Me.lblDA)
        Me.grpEtudiants.Enabled = False
        Me.grpEtudiants.Location = New System.Drawing.Point(12, 12)
        Me.grpEtudiants.Name = "grpEtudiants"
        Me.grpEtudiants.Size = New System.Drawing.Size(1051, 325)
        Me.grpEtudiants.TabIndex = 17
        Me.grpEtudiants.TabStop = False
        Me.grpEtudiants.Text = "Étudiants"
        '
        'mskTel
        '
        Me.mskTel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "etu_telephone", True))
        Me.mskTel.Location = New System.Drawing.Point(541, 196)
        Me.mskTel.Mask = "(000) 000-0000"
        Me.mskTel.Name = "mskTel"
        Me.mskTel.Size = New System.Drawing.Size(141, 29)
        Me.mskTel.TabIndex = 10
        '
        'mskCp
        '
        Me.mskCp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "etu_codepostal", True))
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
        Me.cboProvince.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "etu_province", True))
        Me.cboProvince.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EtudiantsBindingSource, "etu_province", True))
        Me.cboProvince.FormattingEnabled = True
        Me.cboProvince.Items.AddRange(New Object() {"Alberta", "Colombie-Britanique", "Ontario", "Québec", "Nouvelle-Écosse", "Terre-Neuve-et-Labrador", "Manitoba", "Nouveau-Brunswick", "Île-du-Prince-Édouard", "Saskatchewan"})
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
        Me.txtAdresse.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "etu_adresse", True))
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
        Me.txtVille.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "etu_ville", True))
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
        'grpSexe
        '
        Me.grpSexe.Controls.Add(Me.optMasculin)
        Me.grpSexe.Controls.Add(Me.optFeminin)
        Me.grpSexe.Location = New System.Drawing.Point(146, 194)
        Me.grpSexe.Name = "grpSexe"
        Me.grpSexe.Size = New System.Drawing.Size(157, 117)
        Me.grpSexe.TabIndex = 5
        Me.grpSexe.TabStop = False
        Me.grpSexe.Text = "Sexe"
        '
        'optMasculin
        '
        Me.optMasculin.AutoSize = True
        Me.optMasculin.Location = New System.Drawing.Point(16, 71)
        Me.optMasculin.Name = "optMasculin"
        Me.optMasculin.Size = New System.Drawing.Size(108, 26)
        Me.optMasculin.TabIndex = 1
        Me.optMasculin.TabStop = True
        Me.optMasculin.Text = "Masculin"
        Me.optMasculin.UseVisualStyleBackColor = True
        '
        'optFeminin
        '
        Me.optFeminin.AutoSize = True
        Me.optFeminin.Location = New System.Drawing.Point(16, 28)
        Me.optFeminin.Name = "optFeminin"
        Me.optFeminin.Size = New System.Drawing.Size(99, 26)
        Me.optFeminin.TabIndex = 0
        Me.optFeminin.TabStop = True
        Me.optFeminin.Text = "Féminin"
        Me.optFeminin.UseVisualStyleBackColor = True
        '
        'txtPrenom
        '
        Me.txtPrenom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "etu_prenom", True))
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
        Me.txtNom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "etu_nom", True))
        Me.txtNom.Location = New System.Drawing.Point(146, 154)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(255, 29)
        Me.txtNom.TabIndex = 4
        '
        'txtNo
        '
        Me.txtNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "etu_da", True))
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
        Me.dgEtudiants.AutoGenerateColumns = False
        Me.dgEtudiants.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgEtudiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEtudiants.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EtudaDataGridViewTextBoxColumn, Me.PronoDataGridViewTextBoxColumn, Me.EtuprenomDataGridViewTextBoxColumn, Me.EtunomDataGridViewTextBoxColumn, Me.EtusexeDataGridViewTextBoxColumn, Me.EtuadresseDataGridViewTextBoxColumn, Me.EtuvilleDataGridViewTextBoxColumn, Me.EtuprovinceDataGridViewTextBoxColumn, Me.EtutelephoneDataGridViewTextBoxColumn, Me.EtucodepostalDataGridViewTextBoxColumn})
        Me.dgEtudiants.DataSource = Me.EtudiantsBindingSource
        Me.dgEtudiants.Location = New System.Drawing.Point(12, 367)
        Me.dgEtudiants.MultiSelect = False
        Me.dgEtudiants.Name = "dgEtudiants"
        Me.dgEtudiants.ReadOnly = True
        Me.dgEtudiants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEtudiants.Size = New System.Drawing.Size(1310, 486)
        Me.dgEtudiants.TabIndex = 23
        '
        'EtudiantsBindingSource
        '
        Me.EtudiantsBindingSource.DataMember = "T_etudiants"
        Me.EtudiantsBindingSource.DataSource = Me.DsEtudiants1
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        T_etudiants.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            T_etudiants"
        Me.SqlSelectCommand1.Connection = Me.cnEtudiants
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.cnEtudiants
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@etu_da", System.Data.SqlDbType.VarChar, 0, "etu_da"), New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@etu_nom", System.Data.SqlDbType.VarChar, 0, "etu_nom"), New System.Data.SqlClient.SqlParameter("@etu_prenom", System.Data.SqlDbType.VarChar, 0, "etu_prenom"), New System.Data.SqlClient.SqlParameter("@etu_sexe", System.Data.SqlDbType.[Char], 0, "etu_sexe"), New System.Data.SqlClient.SqlParameter("@etu_adresse", System.Data.SqlDbType.VarChar, 0, "etu_adresse"), New System.Data.SqlClient.SqlParameter("@etu_ville", System.Data.SqlDbType.VarChar, 0, "etu_ville"), New System.Data.SqlClient.SqlParameter("@etu_province", System.Data.SqlDbType.VarChar, 0, "etu_province"), New System.Data.SqlClient.SqlParameter("@etu_telephone", System.Data.SqlDbType.VarChar, 0, "etu_telephone"), New System.Data.SqlClient.SqlParameter("@etu_codepostal", System.Data.SqlDbType.VarChar, 0, "etu_codepostal")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.cnEtudiants
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@etu_da", System.Data.SqlDbType.VarChar, 0, "etu_da"), New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@etu_nom", System.Data.SqlDbType.VarChar, 0, "etu_nom"), New System.Data.SqlClient.SqlParameter("@etu_prenom", System.Data.SqlDbType.VarChar, 0, "etu_prenom"), New System.Data.SqlClient.SqlParameter("@etu_sexe", System.Data.SqlDbType.[Char], 0, "etu_sexe"), New System.Data.SqlClient.SqlParameter("@etu_adresse", System.Data.SqlDbType.VarChar, 0, "etu_adresse"), New System.Data.SqlClient.SqlParameter("@etu_ville", System.Data.SqlDbType.VarChar, 0, "etu_ville"), New System.Data.SqlClient.SqlParameter("@etu_province", System.Data.SqlDbType.VarChar, 0, "etu_province"), New System.Data.SqlClient.SqlParameter("@etu_telephone", System.Data.SqlDbType.VarChar, 0, "etu_telephone"), New System.Data.SqlClient.SqlParameter("@etu_codepostal", System.Data.SqlDbType.VarChar, 0, "etu_codepostal"), New System.Data.SqlClient.SqlParameter("@Original_etu_da", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_da", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_prenom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_prenom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_sexe", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_sexe", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_adresse", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_adresse", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_ville", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_ville", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_province", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_province", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_telephone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_telephone", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_codepostal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_codepostal", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.cnEtudiants
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_etu_da", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_da", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_prenom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_prenom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_sexe", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_sexe", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_adresse", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_adresse", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_ville", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_ville", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_province", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_province", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_telephone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_telephone", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_codepostal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_codepostal", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daEtudiants
        '
        Me.daEtudiants.DeleteCommand = Me.SqlDeleteCommand1
        Me.daEtudiants.InsertCommand = Me.SqlInsertCommand1
        Me.daEtudiants.SelectCommand = Me.SqlSelectCommand1
        Me.daEtudiants.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_etudiants", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("etu_da", "etu_da"), New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("etu_nom", "etu_nom"), New System.Data.Common.DataColumnMapping("etu_prenom", "etu_prenom"), New System.Data.Common.DataColumnMapping("etu_sexe", "etu_sexe"), New System.Data.Common.DataColumnMapping("etu_adresse", "etu_adresse"), New System.Data.Common.DataColumnMapping("etu_ville", "etu_ville"), New System.Data.Common.DataColumnMapping("etu_province", "etu_province"), New System.Data.Common.DataColumnMapping("etu_telephone", "etu_telephone"), New System.Data.Common.DataColumnMapping("etu_codepostal", "etu_codepostal")})})
        Me.daEtudiants.UpdateCommand = Me.SqlUpdateCommand1
        '
        'cnEtudiants
        '
        Me.cnEtudiants.ConnectionString = "Data Source=.;Initial Catalog=tp_p44;Integrated Security=True"
        Me.cnEtudiants.FireInfoMessageEventOnUserErrors = False
        '
        'DsEtudiants1
        '
        Me.DsEtudiants1.DataSetName = "DsEtudiants"
        Me.DsEtudiants1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EtudaDataGridViewTextBoxColumn
        '
        Me.EtudaDataGridViewTextBoxColumn.DataPropertyName = "etu_da"
        Me.EtudaDataGridViewTextBoxColumn.HeaderText = "DA"
        Me.EtudaDataGridViewTextBoxColumn.Name = "EtudaDataGridViewTextBoxColumn"
        Me.EtudaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PronoDataGridViewTextBoxColumn
        '
        Me.PronoDataGridViewTextBoxColumn.DataPropertyName = "pro_no"
        Me.PronoDataGridViewTextBoxColumn.HeaderText = "No Prog."
        Me.PronoDataGridViewTextBoxColumn.Name = "PronoDataGridViewTextBoxColumn"
        Me.PronoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtuprenomDataGridViewTextBoxColumn
        '
        Me.EtuprenomDataGridViewTextBoxColumn.DataPropertyName = "etu_prenom"
        Me.EtuprenomDataGridViewTextBoxColumn.HeaderText = "Prénom"
        Me.EtuprenomDataGridViewTextBoxColumn.Name = "EtuprenomDataGridViewTextBoxColumn"
        Me.EtuprenomDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtuprenomDataGridViewTextBoxColumn.Width = 150
        '
        'EtunomDataGridViewTextBoxColumn
        '
        Me.EtunomDataGridViewTextBoxColumn.DataPropertyName = "etu_nom"
        Me.EtunomDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.EtunomDataGridViewTextBoxColumn.Name = "EtunomDataGridViewTextBoxColumn"
        Me.EtunomDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtunomDataGridViewTextBoxColumn.Width = 150
        '
        'EtusexeDataGridViewTextBoxColumn
        '
        Me.EtusexeDataGridViewTextBoxColumn.DataPropertyName = "etu_sexe"
        Me.EtusexeDataGridViewTextBoxColumn.HeaderText = "Sexe"
        Me.EtusexeDataGridViewTextBoxColumn.Name = "EtusexeDataGridViewTextBoxColumn"
        Me.EtusexeDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtusexeDataGridViewTextBoxColumn.Width = 60
        '
        'EtuadresseDataGridViewTextBoxColumn
        '
        Me.EtuadresseDataGridViewTextBoxColumn.DataPropertyName = "etu_adresse"
        Me.EtuadresseDataGridViewTextBoxColumn.HeaderText = "Adresse"
        Me.EtuadresseDataGridViewTextBoxColumn.Name = "EtuadresseDataGridViewTextBoxColumn"
        Me.EtuadresseDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtuadresseDataGridViewTextBoxColumn.Width = 211
        '
        'EtuvilleDataGridViewTextBoxColumn
        '
        Me.EtuvilleDataGridViewTextBoxColumn.DataPropertyName = "etu_ville"
        Me.EtuvilleDataGridViewTextBoxColumn.HeaderText = "Ville"
        Me.EtuvilleDataGridViewTextBoxColumn.Name = "EtuvilleDataGridViewTextBoxColumn"
        Me.EtuvilleDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtuvilleDataGridViewTextBoxColumn.Width = 150
        '
        'EtuprovinceDataGridViewTextBoxColumn
        '
        Me.EtuprovinceDataGridViewTextBoxColumn.DataPropertyName = "etu_province"
        Me.EtuprovinceDataGridViewTextBoxColumn.HeaderText = "Province"
        Me.EtuprovinceDataGridViewTextBoxColumn.Name = "EtuprovinceDataGridViewTextBoxColumn"
        Me.EtuprovinceDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtuprovinceDataGridViewTextBoxColumn.Width = 125
        '
        'EtutelephoneDataGridViewTextBoxColumn
        '
        Me.EtutelephoneDataGridViewTextBoxColumn.DataPropertyName = "etu_telephone"
        Me.EtutelephoneDataGridViewTextBoxColumn.HeaderText = "Téléphone"
        Me.EtutelephoneDataGridViewTextBoxColumn.Name = "EtutelephoneDataGridViewTextBoxColumn"
        Me.EtutelephoneDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtutelephoneDataGridViewTextBoxColumn.Width = 120
        '
        'EtucodepostalDataGridViewTextBoxColumn
        '
        Me.EtucodepostalDataGridViewTextBoxColumn.DataPropertyName = "etu_codepostal"
        Me.EtucodepostalDataGridViewTextBoxColumn.HeaderText = "Code Postal"
        Me.EtucodepostalDataGridViewTextBoxColumn.Name = "EtucodepostalDataGridViewTextBoxColumn"
        Me.EtucodepostalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'txtProg
        '
        Me.txtProg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EtudiantsBindingSource, "pro_no", True))
        Me.txtProg.Location = New System.Drawing.Point(146, 82)
        Me.txtProg.Mask = "LLL.0L"
        Me.txtProg.Name = "txtProg"
        Me.txtProg.Size = New System.Drawing.Size(126, 29)
        Me.txtProg.TabIndex = 21
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
        Me.grpSexe.ResumeLayout(False)
        Me.grpSexe.PerformLayout()
        CType(Me.dgEtudiants, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EtudiantsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEtudiants1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents grpSexe As GroupBox
    Friend WithEvents optMasculin As RadioButton
    Friend WithEvents optFeminin As RadioButton
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents lblPrenom As Label
    Friend WithEvents lblNoProg As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtNo As TextBox
    Friend WithEvents lblNom As Label
    Friend WithEvents lblDA As Label
    Friend WithEvents dgEtudiants As DataGridView
    Friend WithEvents EtudiantsBindingSource As BindingSource
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents cnEtudiants As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents daEtudiants As SqlClient.SqlDataAdapter
    Friend WithEvents DsEtudiants1 As DsEtudiants
    Friend WithEvents EtudaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuprenomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtunomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtusexeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuadresseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuvilleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuprovinceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtutelephoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtucodepostalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtProg As MaskedTextBox
End Class
