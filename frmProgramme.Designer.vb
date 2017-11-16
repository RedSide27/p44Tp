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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProgramme))
        Me.cmdEnlever = New System.Windows.Forms.Button()
        Me.cmdModifier = New System.Windows.Forms.Button()
        Me.cmdAnnuler = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdNouveau = New System.Windows.Forms.Button()
        Me.grpProgramme = New System.Windows.Forms.GroupBox()
        Me.txtno = New System.Windows.Forms.MaskedTextBox()
        Me.ProgrammeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProgramme1 = New p44Tp.DsProgramme()
        Me.txtNbrHeure = New System.Windows.Forms.TextBox()
        Me.txtNbrUnites = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblNbrHeure = New System.Windows.Forms.Label()
        Me.lblNbrUnite = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblNo = New System.Windows.Forms.Label()
        Me.dgProgramme = New System.Windows.Forms.DataGridView()
        Me.PronoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronbrunitesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronbrheuresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.cnProgramme = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daProgramme = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.daEtudiants = New System.Data.SqlClient.SqlDataAdapter()
        Me.dgEtudiants = New System.Windows.Forms.DataGridView()
        Me.EtudaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuprenomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtunomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TetudiantsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Err1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpProgramme.SuspendLayout()
        CType(Me.ProgrammeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProgramme1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgProgramme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEtudiants, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TetudiantsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Err1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProgrammeBindingSource, "pro_no", True))
        Me.txtno.Location = New System.Drawing.Point(146, 43)
        Me.txtno.Mask = "LLL.0L"
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(126, 29)
        Me.txtno.TabIndex = 9
        '
        'ProgrammeBindingSource
        '
        Me.ProgrammeBindingSource.DataMember = "T_programme"
        Me.ProgrammeBindingSource.DataSource = Me.DsProgramme1
        '
        'DsProgramme1
        '
        Me.DsProgramme1.DataSetName = "DsProgramme"
        Me.DsProgramme1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtNbrHeure
        '
        Me.txtNbrHeure.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProgrammeBindingSource, "pro_nbr_heures", True))
        Me.txtNbrHeure.Location = New System.Drawing.Point(146, 168)
        Me.txtNbrHeure.Name = "txtNbrHeure"
        Me.txtNbrHeure.Size = New System.Drawing.Size(126, 29)
        Me.txtNbrHeure.TabIndex = 8
        '
        'txtNbrUnites
        '
        Me.txtNbrUnites.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProgrammeBindingSource, "pro_nbr_unites", True))
        Me.txtNbrUnites.Location = New System.Drawing.Point(146, 124)
        Me.txtNbrUnites.Name = "txtNbrUnites"
        Me.txtNbrUnites.Size = New System.Drawing.Size(126, 29)
        Me.txtNbrUnites.TabIndex = 7
        '
        'txtNom
        '
        Me.txtNom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProgrammeBindingSource, "pro_nom", True))
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
        'dgProgramme
        '
        Me.dgProgramme.AllowUserToAddRows = False
        Me.dgProgramme.AllowUserToDeleteRows = False
        Me.dgProgramme.AutoGenerateColumns = False
        Me.dgProgramme.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgProgramme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProgramme.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PronoDataGridViewTextBoxColumn, Me.PronomDataGridViewTextBoxColumn, Me.PronbrunitesDataGridViewTextBoxColumn, Me.PronbrheuresDataGridViewTextBoxColumn})
        Me.dgProgramme.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ProgrammeBindingSource, "pro_no", True))
        Me.dgProgramme.DataSource = Me.ProgrammeBindingSource
        Me.dgProgramme.Location = New System.Drawing.Point(12, 237)
        Me.dgProgramme.Name = "dgProgramme"
        Me.dgProgramme.ReadOnly = True
        Me.dgProgramme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProgramme.ShowEditingIcon = False
        Me.dgProgramme.Size = New System.Drawing.Size(672, 616)
        Me.dgProgramme.TabIndex = 12
        '
        'PronoDataGridViewTextBoxColumn
        '
        Me.PronoDataGridViewTextBoxColumn.DataPropertyName = "pro_no"
        Me.PronoDataGridViewTextBoxColumn.HeaderText = "No"
        Me.PronoDataGridViewTextBoxColumn.Name = "PronoDataGridViewTextBoxColumn"
        Me.PronoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PronomDataGridViewTextBoxColumn
        '
        Me.PronomDataGridViewTextBoxColumn.DataPropertyName = "pro_nom"
        Me.PronomDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.PronomDataGridViewTextBoxColumn.Name = "PronomDataGridViewTextBoxColumn"
        Me.PronomDataGridViewTextBoxColumn.ReadOnly = True
        Me.PronomDataGridViewTextBoxColumn.Width = 229
        '
        'PronbrunitesDataGridViewTextBoxColumn
        '
        Me.PronbrunitesDataGridViewTextBoxColumn.DataPropertyName = "pro_nbr_unites"
        Me.PronbrunitesDataGridViewTextBoxColumn.HeaderText = "Nbr Unités"
        Me.PronbrunitesDataGridViewTextBoxColumn.Name = "PronbrunitesDataGridViewTextBoxColumn"
        Me.PronbrunitesDataGridViewTextBoxColumn.ReadOnly = True
        Me.PronbrunitesDataGridViewTextBoxColumn.Width = 150
        '
        'PronbrheuresDataGridViewTextBoxColumn
        '
        Me.PronbrheuresDataGridViewTextBoxColumn.DataPropertyName = "pro_nbr_heures"
        Me.PronbrheuresDataGridViewTextBoxColumn.HeaderText = "Nbr Heures"
        Me.PronbrheuresDataGridViewTextBoxColumn.Name = "PronbrheuresDataGridViewTextBoxColumn"
        Me.PronbrheuresDataGridViewTextBoxColumn.ReadOnly = True
        Me.PronbrheuresDataGridViewTextBoxColumn.Width = 150
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        T_programme.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            T_programme"
        Me.SqlSelectCommand1.Connection = Me.cnProgramme
        '
        'cnProgramme
        '
        Me.cnProgramme.ConnectionString = "Data Source=.;Initial Catalog=tp_p44;Integrated Security=True"
        Me.cnProgramme.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.cnProgramme
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@pro_nom", System.Data.SqlDbType.VarChar, 0, "pro_nom"), New System.Data.SqlClient.SqlParameter("@pro_nbr_unites", System.Data.SqlDbType.Float, 0, "pro_nbr_unites"), New System.Data.SqlClient.SqlParameter("@pro_nbr_heures", System.Data.SqlDbType.Int, 0, "pro_nbr_heures")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.cnProgramme
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@pro_nom", System.Data.SqlDbType.VarChar, 0, "pro_nom"), New System.Data.SqlClient.SqlParameter("@pro_nbr_unites", System.Data.SqlDbType.Float, 0, "pro_nbr_unites"), New System.Data.SqlClient.SqlParameter("@pro_nbr_heures", System.Data.SqlDbType.Int, 0, "pro_nbr_heures"), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_unites", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_unites", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.cnProgramme
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_unites", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_unites", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daProgramme
        '
        Me.daProgramme.DeleteCommand = Me.SqlDeleteCommand1
        Me.daProgramme.InsertCommand = Me.SqlInsertCommand1
        Me.daProgramme.SelectCommand = Me.SqlSelectCommand1
        Me.daProgramme.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_programme", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("pro_nom", "pro_nom"), New System.Data.Common.DataColumnMapping("pro_nbr_unites", "pro_nbr_unites"), New System.Data.Common.DataColumnMapping("pro_nbr_heures", "pro_nbr_heures")})})
        Me.daProgramme.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT        etu_da, pro_no, etu_prenom, etu_nom" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            T_etudiants" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "W" &
    "HERE        (pro_no = @NoProg)"
        Me.SqlSelectCommand2.Connection = Me.cnProgramme
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NoProg", System.Data.SqlDbType.VarChar, 6, "pro_no")})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.cnProgramme
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@etu_da", System.Data.SqlDbType.VarChar, 0, "etu_da"), New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@etu_prenom", System.Data.SqlDbType.VarChar, 0, "etu_prenom"), New System.Data.SqlClient.SqlParameter("@etu_nom", System.Data.SqlDbType.VarChar, 0, "etu_nom")})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.cnProgramme
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@etu_da", System.Data.SqlDbType.VarChar, 0, "etu_da"), New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@etu_prenom", System.Data.SqlDbType.VarChar, 0, "etu_prenom"), New System.Data.SqlClient.SqlParameter("@etu_nom", System.Data.SqlDbType.VarChar, 0, "etu_nom"), New System.Data.SqlClient.SqlParameter("@Original_etu_da", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_da", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_prenom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_prenom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_nom", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM [T_etudiants] WHERE (([etu_da] = @Original_etu_da) AND ([pro_no] = @O" &
    "riginal_pro_no) AND ([etu_prenom] = @Original_etu_prenom) AND ([etu_nom] = @Orig" &
    "inal_etu_nom))"
        Me.SqlDeleteCommand2.Connection = Me.cnProgramme
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_etu_da", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_da", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_prenom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_prenom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_nom", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daEtudiants
        '
        Me.daEtudiants.DeleteCommand = Me.SqlDeleteCommand2
        Me.daEtudiants.InsertCommand = Me.SqlInsertCommand2
        Me.daEtudiants.SelectCommand = Me.SqlSelectCommand2
        Me.daEtudiants.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_etudiants", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("etu_da", "etu_da"), New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("etu_prenom", "etu_prenom"), New System.Data.Common.DataColumnMapping("etu_nom", "etu_nom")})})
        Me.daEtudiants.UpdateCommand = Me.SqlUpdateCommand2
        '
        'dgEtudiants
        '
        Me.dgEtudiants.AllowUserToAddRows = False
        Me.dgEtudiants.AllowUserToDeleteRows = False
        Me.dgEtudiants.AutoGenerateColumns = False
        Me.dgEtudiants.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgEtudiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEtudiants.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EtudaDataGridViewTextBoxColumn, Me.PronoDataGridViewTextBoxColumn1, Me.EtuprenomDataGridViewTextBoxColumn, Me.EtunomDataGridViewTextBoxColumn})
        Me.dgEtudiants.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.TetudiantsBindingSource, "pro_no", True))
        Me.dgEtudiants.DataSource = Me.TetudiantsBindingSource
        Me.dgEtudiants.Location = New System.Drawing.Point(702, 25)
        Me.dgEtudiants.Name = "dgEtudiants"
        Me.dgEtudiants.ReadOnly = True
        Me.dgEtudiants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEtudiants.Size = New System.Drawing.Size(684, 828)
        Me.dgEtudiants.TabIndex = 13
        '
        'EtudaDataGridViewTextBoxColumn
        '
        Me.EtudaDataGridViewTextBoxColumn.DataPropertyName = "etu_da"
        Me.EtudaDataGridViewTextBoxColumn.HeaderText = "DA"
        Me.EtudaDataGridViewTextBoxColumn.Name = "EtudaDataGridViewTextBoxColumn"
        Me.EtudaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PronoDataGridViewTextBoxColumn1
        '
        Me.PronoDataGridViewTextBoxColumn1.DataPropertyName = "pro_no"
        Me.PronoDataGridViewTextBoxColumn1.HeaderText = "No Prog."
        Me.PronoDataGridViewTextBoxColumn1.Name = "PronoDataGridViewTextBoxColumn1"
        Me.PronoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PronoDataGridViewTextBoxColumn1.Width = 150
        '
        'EtuprenomDataGridViewTextBoxColumn
        '
        Me.EtuprenomDataGridViewTextBoxColumn.DataPropertyName = "etu_prenom"
        Me.EtuprenomDataGridViewTextBoxColumn.HeaderText = "Prénom"
        Me.EtuprenomDataGridViewTextBoxColumn.Name = "EtuprenomDataGridViewTextBoxColumn"
        Me.EtuprenomDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtuprenomDataGridViewTextBoxColumn.Width = 191
        '
        'EtunomDataGridViewTextBoxColumn
        '
        Me.EtunomDataGridViewTextBoxColumn.DataPropertyName = "etu_nom"
        Me.EtunomDataGridViewTextBoxColumn.HeaderText = "etu_nom"
        Me.EtunomDataGridViewTextBoxColumn.Name = "EtunomDataGridViewTextBoxColumn"
        Me.EtunomDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtunomDataGridViewTextBoxColumn.Width = 200
        '
        'TetudiantsBindingSource
        '
        Me.TetudiantsBindingSource.DataMember = "T_etudiants"
        Me.TetudiantsBindingSource.DataSource = Me.DsProgramme1
        '
        'Err1
        '
        Me.Err1.ContainerControl = Me
        '
        'frmProgramme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1441, 898)
        Me.Controls.Add(Me.dgEtudiants)
        Me.Controls.Add(Me.dgProgramme)
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
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpProgramme.ResumeLayout(False)
        Me.grpProgramme.PerformLayout()
        CType(Me.ProgrammeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProgramme1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgProgramme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEtudiants, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TetudiantsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Err1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdEnlever As Button
    Friend WithEvents cmdModifier As Button
    Friend WithEvents cmdAnnuler As Button
    Friend WithEvents cmdOK As Button
    Friend WithEvents cmdNouveau As Button
    Friend WithEvents grpProgramme As GroupBox
    Friend WithEvents txtNbrHeure As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents lblNbrHeure As Label
    Friend WithEvents lblNbrUnite As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblNo As Label
    Friend WithEvents dgProgramme As DataGridView
    Friend WithEvents ProgrammeBindingSource As BindingSource
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents cnProgramme As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents daProgramme As SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As SqlClient.SqlCommand
    Friend WithEvents daEtudiants As SqlClient.SqlDataAdapter
    Friend WithEvents dgEtudiants As DataGridView
    Friend WithEvents TetudiantsBindingSource As BindingSource
    Friend WithEvents PronoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronbrunitesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronbrheuresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DsProgramme1 As DsProgramme
    Friend WithEvents EtudaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EtuprenomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtunomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Err1 As ErrorProvider
    Friend WithEvents txtNbrUnites As TextBox
    Friend WithEvents txtno As MaskedTextBox
End Class
