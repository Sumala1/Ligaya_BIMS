<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class residentform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelMain = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.txtMiddleName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblBloodtype = New System.Windows.Forms.Label()
        Me.cmbBloodtype = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblSuffix = New System.Windows.Forms.Label()
        Me.cmbSuffix = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.cmbGender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblBirthDate = New System.Windows.Forms.Label()
        Me.dtpBirthDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblBirthPlace = New System.Windows.Forms.Label()
        Me.txtBirthPlace = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblSitioPurok = New System.Windows.Forms.Label()
        Me.txtSitioPurok = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.txtContactNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.picProfile = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.lblSearchBy = New System.Windows.Forms.Label()
        Me.cmbSearchBy = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvResidents = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.panelMain.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResidents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.White
        Me.panelMain.Controls.Add(Me.lblHeader)
        Me.panelMain.Controls.Add(Me.lblFirstName)
        Me.panelMain.Controls.Add(Me.txtFirstName)
        Me.panelMain.Controls.Add(Me.lblMiddleName)
        Me.panelMain.Controls.Add(Me.txtMiddleName)
        Me.panelMain.Controls.Add(Me.lblLastName)
        Me.panelMain.Controls.Add(Me.txtLastName)
        Me.panelMain.Controls.Add(Me.lblBloodtype)
        Me.panelMain.Controls.Add(Me.cmbBloodtype)
        Me.panelMain.Controls.Add(Me.lblSuffix)
        Me.panelMain.Controls.Add(Me.cmbSuffix)
        Me.panelMain.Controls.Add(Me.lblGender)
        Me.panelMain.Controls.Add(Me.cmbGender)
        Me.panelMain.Controls.Add(Me.lblBirthDate)
        Me.panelMain.Controls.Add(Me.dtpBirthDate)
        Me.panelMain.Controls.Add(Me.lblBirthPlace)
        Me.panelMain.Controls.Add(Me.txtBirthPlace)
        Me.panelMain.Controls.Add(Me.lblSitioPurok)
        Me.panelMain.Controls.Add(Me.txtSitioPurok)
        Me.panelMain.Controls.Add(Me.lblContactNo)
        Me.panelMain.Controls.Add(Me.txtContactNo)
        Me.panelMain.Controls.Add(Me.lblId)
        Me.panelMain.Controls.Add(Me.picProfile)
        Me.panelMain.Controls.Add(Me.btnSave)
        Me.panelMain.Controls.Add(Me.btnUpdate)
        Me.panelMain.Controls.Add(Me.btnDelete)
        Me.panelMain.Controls.Add(Me.btnCancel)
        Me.panelMain.Controls.Add(Me.lblSearchBy)
        Me.panelMain.Controls.Add(Me.cmbSearchBy)
        Me.panelMain.Controls.Add(Me.lblSearch)
        Me.panelMain.Controls.Add(Me.txtSearch)
        Me.panelMain.Controls.Add(Me.btnRefresh)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Padding = New System.Windows.Forms.Padding(12)
        Me.panelMain.Size = New System.Drawing.Size(1085, 608)
        Me.panelMain.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.Location = New System.Drawing.Point(18, 18)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(136, 37)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Profiling:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(24, 74)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.DefaultText = ""
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFirstName.Location = New System.Drawing.Point(24, 87)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PlaceholderText = ""
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.Size = New System.Drawing.Size(216, 36)
        Me.txtFirstName.TabIndex = 1
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Location = New System.Drawing.Point(24, 126)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(72, 13)
        Me.lblMiddleName.TabIndex = 0
        Me.lblMiddleName.Text = "Middle Name:"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMiddleName.DefaultText = ""
        Me.txtMiddleName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMiddleName.Location = New System.Drawing.Point(25, 142)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.PlaceholderText = ""
        Me.txtMiddleName.SelectedText = ""
        Me.txtMiddleName.Size = New System.Drawing.Size(215, 36)
        Me.txtMiddleName.TabIndex = 2
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(24, 178)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.Text = "Last Name:"
        '
        'txtLastName
        '
        Me.txtLastName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.DefaultText = ""
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLastName.Location = New System.Drawing.Point(24, 196)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PlaceholderText = ""
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.Size = New System.Drawing.Size(149, 36)
        Me.txtLastName.TabIndex = 3
        '
        'lblBloodtype
        '
        Me.lblBloodtype.AutoSize = True
        Me.lblBloodtype.Location = New System.Drawing.Point(685, 74)
        Me.lblBloodtype.Name = "lblBloodtype"
        Me.lblBloodtype.Size = New System.Drawing.Size(57, 13)
        Me.lblBloodtype.TabIndex = 0
        Me.lblBloodtype.Text = "Bloodtype:"
        '
        'cmbBloodtype
        '
        Me.cmbBloodtype.BackColor = System.Drawing.Color.Transparent
        Me.cmbBloodtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBloodtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBloodtype.FocusedColor = System.Drawing.Color.Empty
        Me.cmbBloodtype.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbBloodtype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbBloodtype.ItemHeight = 30
        Me.cmbBloodtype.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"})
        Me.cmbBloodtype.Location = New System.Drawing.Point(685, 92)
        Me.cmbBloodtype.Name = "cmbBloodtype"
        Me.cmbBloodtype.Size = New System.Drawing.Size(160, 36)
        Me.cmbBloodtype.TabIndex = 4
        '
        'lblSuffix
        '
        Me.lblSuffix.AutoSize = True
        Me.lblSuffix.Location = New System.Drawing.Point(881, 74)
        Me.lblSuffix.Name = "lblSuffix"
        Me.lblSuffix.Size = New System.Drawing.Size(36, 13)
        Me.lblSuffix.TabIndex = 0
        Me.lblSuffix.Text = "Suffix:"
        '
        'cmbSuffix
        '
        Me.cmbSuffix.BackColor = System.Drawing.Color.Transparent
        Me.cmbSuffix.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSuffix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSuffix.FocusedColor = System.Drawing.Color.Empty
        Me.cmbSuffix.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSuffix.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbSuffix.ItemHeight = 30
        Me.cmbSuffix.Items.AddRange(New Object() {"", "Jr.", "Sr.", "III", "IV"})
        Me.cmbSuffix.Location = New System.Drawing.Point(881, 92)
        Me.cmbSuffix.Name = "cmbSuffix"
        Me.cmbSuffix.Size = New System.Drawing.Size(120, 36)
        Me.cmbSuffix.TabIndex = 5
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(685, 139)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(45, 13)
        Me.lblGender.TabIndex = 0
        Me.lblGender.Text = "Gender:"
        '
        'cmbGender
        '
        Me.cmbGender.BackColor = System.Drawing.Color.Transparent
        Me.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.FocusedColor = System.Drawing.Color.Empty
        Me.cmbGender.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbGender.ItemHeight = 30
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(685, 155)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(160, 36)
        Me.cmbGender.TabIndex = 6
        '
        'lblBirthDate
        '
        Me.lblBirthDate.AutoSize = True
        Me.lblBirthDate.Location = New System.Drawing.Point(682, 195)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(57, 13)
        Me.lblBirthDate.TabIndex = 0
        Me.lblBirthDate.Text = "Birth Date:"
        '
        'dtpBirthDate
        '
        Me.dtpBirthDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpBirthDate.Checked = True
        Me.dtpBirthDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpBirthDate.Location = New System.Drawing.Point(685, 220)
        Me.dtpBirthDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpBirthDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpBirthDate.Name = "dtpBirthDate"
        Me.dtpBirthDate.Size = New System.Drawing.Size(193, 36)
        Me.dtpBirthDate.TabIndex = 7
        Me.dtpBirthDate.Value = New Date(2025, 9, 23, 3, 58, 25, 112)
        '
        'lblBirthPlace
        '
        Me.lblBirthPlace.AutoSize = True
        Me.lblBirthPlace.Location = New System.Drawing.Point(302, 230)
        Me.lblBirthPlace.Name = "lblBirthPlace"
        Me.lblBirthPlace.Size = New System.Drawing.Size(61, 13)
        Me.lblBirthPlace.TabIndex = 0
        Me.lblBirthPlace.Text = "Birth Place:"
        '
        'txtBirthPlace
        '
        Me.txtBirthPlace.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBirthPlace.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBirthPlace.DefaultText = ""
        Me.txtBirthPlace.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBirthPlace.Location = New System.Drawing.Point(305, 248)
        Me.txtBirthPlace.Name = "txtBirthPlace"
        Me.txtBirthPlace.PlaceholderText = ""
        Me.txtBirthPlace.SelectedText = ""
        Me.txtBirthPlace.Size = New System.Drawing.Size(247, 36)
        Me.txtBirthPlace.TabIndex = 8
        '
        'lblSitioPurok
        '
        Me.lblSitioPurok.AutoSize = True
        Me.lblSitioPurok.Location = New System.Drawing.Point(24, 230)
        Me.lblSitioPurok.Name = "lblSitioPurok"
        Me.lblSitioPurok.Size = New System.Drawing.Size(63, 13)
        Me.lblSitioPurok.TabIndex = 0
        Me.lblSitioPurok.Text = "Sitio/Purok:"
        '
        'txtSitioPurok
        '
        Me.txtSitioPurok.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSitioPurok.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSitioPurok.DefaultText = ""
        Me.txtSitioPurok.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSitioPurok.Location = New System.Drawing.Point(24, 248)
        Me.txtSitioPurok.Name = "txtSitioPurok"
        Me.txtSitioPurok.PlaceholderText = ""
        Me.txtSitioPurok.SelectedText = ""
        Me.txtSitioPurok.Size = New System.Drawing.Size(149, 36)
        Me.txtSitioPurok.TabIndex = 9
        '
        'lblContactNo
        '
        Me.lblContactNo.AutoSize = True
        Me.lblContactNo.Location = New System.Drawing.Point(24, 282)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(65, 13)
        Me.lblContactNo.TabIndex = 0
        Me.lblContactNo.Text = "Contact no.:"
        '
        'txtContactNo
        '
        Me.txtContactNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContactNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContactNo.DefaultText = ""
        Me.txtContactNo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtContactNo.Location = New System.Drawing.Point(24, 300)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.PlaceholderText = ""
        Me.txtContactNo.SelectedText = ""
        Me.txtContactNo.Size = New System.Drawing.Size(528, 36)
        Me.txtContactNo.TabIndex = 10
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblId.Location = New System.Drawing.Point(1047, 56)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(27, 19)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "ID:"
        '
        'picProfile
        '
        Me.picProfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picProfile.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProfile.ImageRotate = 0!
        Me.picProfile.Location = New System.Drawing.Point(928, 78)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(130, 130)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfile.TabIndex = 0
        Me.picProfile.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.FillColor = System.Drawing.Color.SeaGreen
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(928, 220)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(130, 36)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "SAVE"
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(928, 258)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(130, 36)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "UPDATE"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.FillColor = System.Drawing.Color.Firebrick
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(928, 296)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(130, 36)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "DELETE"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.FillColor = System.Drawing.Color.Silver
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(27, 538)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(130, 36)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "CANCEL"
        '
        'lblSearchBy
        '
        Me.lblSearchBy.AutoSize = True
        Me.lblSearchBy.Location = New System.Drawing.Point(22, 583)
        Me.lblSearchBy.Name = "lblSearchBy"
        Me.lblSearchBy.Size = New System.Drawing.Size(58, 13)
        Me.lblSearchBy.TabIndex = 0
        Me.lblSearchBy.Text = "Search by:"
        '
        'cmbSearchBy
        '
        Me.cmbSearchBy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbSearchBy.BackColor = System.Drawing.Color.Transparent
        Me.cmbSearchBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchBy.FocusedColor = System.Drawing.Color.Empty
        Me.cmbSearchBy.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSearchBy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbSearchBy.ItemHeight = 30
        Me.cmbSearchBy.Items.AddRange(New Object() {"First Name", "Last Name", "Sitio/Purok", "Contact no."})
        Me.cmbSearchBy.Location = New System.Drawing.Point(24, 817)
        Me.cmbSearchBy.Name = "cmbSearchBy"
        Me.cmbSearchBy.Size = New System.Drawing.Size(180, 36)
        Me.cmbSearchBy.TabIndex = 15
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(219, 583)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(44, 13)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Search:"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.Location = New System.Drawing.Point(220, 817)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = ""
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(658, 36)
        Me.txtSearch.TabIndex = 16
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.FillColor = System.Drawing.Color.Turquoise
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(928, 809)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(130, 36)
        Me.btnRefresh.TabIndex = 17
        Me.btnRefresh.Text = "REFRESH"
        '
        'dgvResidents
        '
        Me.dgvResidents.AllowUserToAddRows = False
        Me.dgvResidents.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvResidents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvResidents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResidents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvResidents.ColumnHeadersHeight = 4
        Me.dgvResidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvResidents.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvResidents.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvResidents.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvResidents.Location = New System.Drawing.Point(0, 608)
        Me.dgvResidents.MultiSelect = False
        Me.dgvResidents.Name = "dgvResidents"
        Me.dgvResidents.ReadOnly = True
        Me.dgvResidents.RowHeadersVisible = False
        Me.dgvResidents.Size = New System.Drawing.Size(1085, 166)
        Me.dgvResidents.TabIndex = 1
        Me.dgvResidents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvResidents.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvResidents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvResidents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvResidents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvResidents.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvResidents.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvResidents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvResidents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvResidents.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvResidents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvResidents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvResidents.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvResidents.ThemeStyle.ReadOnly = True
        Me.dgvResidents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvResidents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvResidents.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvResidents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvResidents.ThemeStyle.RowsStyle.Height = 22
        Me.dgvResidents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvResidents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'residentform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 774)
        Me.Controls.Add(Me.panelMain)
        Me.Controls.Add(Me.dgvResidents)
        Me.Name = "residentform"
        Me.Text = "Resident Profiling"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelMain.ResumeLayout(False)
        Me.panelMain.PerformLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResidents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelMain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgvResidents As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblMiddleName As System.Windows.Forms.Label
    Friend WithEvents txtMiddleName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblBloodtype As System.Windows.Forms.Label
    Friend WithEvents cmbBloodtype As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblSuffix As System.Windows.Forms.Label
    Friend WithEvents cmbSuffix As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents cmbGender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblBirthDate As System.Windows.Forms.Label
    Friend WithEvents dtpBirthDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblBirthPlace As System.Windows.Forms.Label
    Friend WithEvents txtBirthPlace As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblSitioPurok As System.Windows.Forms.Label
    Friend WithEvents txtSitioPurok As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblContactNo As System.Windows.Forms.Label
    Friend WithEvents txtContactNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents picProfile As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblSearchBy As System.Windows.Forms.Label
    Friend WithEvents cmbSearchBy As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnRefresh As Guna.UI2.WinForms.Guna2Button
End Class
