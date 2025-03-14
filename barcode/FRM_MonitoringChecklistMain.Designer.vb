<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_MonitoringChecklistMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_MonitoringChecklistMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TXT_OrigSectionCode = New System.Windows.Forms.TextBox()
        Me.TXT_OrigSection = New System.Windows.Forms.TextBox()
        Me.LBL_Section = New System.Windows.Forms.Label()
        Me.CHK_CkeckedUSer = New System.Windows.Forms.CheckBox()
        Me.LBL_SectionName = New System.Windows.Forms.Label()
        Me.LBL_oper_numOperator = New System.Windows.Forms.Label()
        Me.LBL_DummyCodeSection = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_empname = New System.Windows.Forms.Label()
        Me.lbl_empnum = New System.Windows.Forms.Label()
        Me.LBL_Title = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_date = New System.Windows.Forms.DateTimePicker()
        Me.BTN_SaveHeader = New System.Windows.Forms.Button()
        Me.PBox_QRCode = New System.Windows.Forms.PictureBox()
        Me.TXT_CreatedBy = New System.Windows.Forms.TextBox()
        Me.LBL_CreatedBy = New System.Windows.Forms.Label()
        Me.txt_jobname_ext = New System.Windows.Forms.TextBox()
        Me.txt_shift = New System.Windows.Forms.TextBox()
        Me.txt_operator = New System.Windows.Forms.TextBox()
        Me.txt_um = New System.Windows.Forms.TextBox()
        Me.txt_jobqty = New System.Windows.Forms.TextBox()
        Me.txt_jobname = New System.Windows.Forms.TextBox()
        Me.txt_job = New System.Windows.Forms.TextBox()
        Me.txt_machine = New System.Windows.Forms.TextBox()
        Me.TXT_MCNO = New System.Windows.Forms.TextBox()
        Me.BTN_AddMCNo = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BTN_NxtProcess = New System.Windows.Forms.Button()
        Me.BTN_SuperIntendent = New System.Windows.Forms.Button()
        Me.BTN_Supervisor = New System.Windows.Forms.Button()
        Me.BTN_Operator = New System.Windows.Forms.Button()
        Me.PNL_MonitoringChecklistOperatorMain = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PBox_QRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.TXT_OrigSectionCode)
        Me.Panel1.Controls.Add(Me.TXT_OrigSection)
        Me.Panel1.Controls.Add(Me.LBL_Section)
        Me.Panel1.Controls.Add(Me.CHK_CkeckedUSer)
        Me.Panel1.Controls.Add(Me.LBL_SectionName)
        Me.Panel1.Controls.Add(Me.LBL_oper_numOperator)
        Me.Panel1.Controls.Add(Me.LBL_DummyCodeSection)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.lbl_empname)
        Me.Panel1.Controls.Add(Me.lbl_empnum)
        Me.Panel1.Controls.Add(Me.LBL_Title)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1868, 48)
        Me.Panel1.TabIndex = 0
        '
        'TXT_OrigSectionCode
        '
        Me.TXT_OrigSectionCode.BackColor = System.Drawing.SystemColors.Highlight
        Me.TXT_OrigSectionCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_OrigSectionCode.Location = New System.Drawing.Point(1209, 11)
        Me.TXT_OrigSectionCode.Name = "TXT_OrigSectionCode"
        Me.TXT_OrigSectionCode.Size = New System.Drawing.Size(100, 13)
        Me.TXT_OrigSectionCode.TabIndex = 131
        Me.TXT_OrigSectionCode.Visible = False
        '
        'TXT_OrigSection
        '
        Me.TXT_OrigSection.BackColor = System.Drawing.SystemColors.Highlight
        Me.TXT_OrigSection.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_OrigSection.Location = New System.Drawing.Point(1088, 11)
        Me.TXT_OrigSection.Name = "TXT_OrigSection"
        Me.TXT_OrigSection.Size = New System.Drawing.Size(100, 13)
        Me.TXT_OrigSection.TabIndex = 130
        Me.TXT_OrigSection.Visible = False
        '
        'LBL_Section
        '
        Me.LBL_Section.AutoSize = True
        Me.LBL_Section.BackColor = System.Drawing.SystemColors.Highlight
        Me.LBL_Section.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LBL_Section.Location = New System.Drawing.Point(945, 21)
        Me.LBL_Section.Name = "LBL_Section"
        Me.LBL_Section.Size = New System.Drawing.Size(45, 13)
        Me.LBL_Section.TabIndex = 129
        Me.LBL_Section.Text = "Label10"
        Me.LBL_Section.Visible = False
        '
        'CHK_CkeckedUSer
        '
        Me.CHK_CkeckedUSer.AutoSize = True
        Me.CHK_CkeckedUSer.ForeColor = System.Drawing.SystemColors.Highlight
        Me.CHK_CkeckedUSer.Location = New System.Drawing.Point(1786, 7)
        Me.CHK_CkeckedUSer.Name = "CHK_CkeckedUSer"
        Me.CHK_CkeckedUSer.Size = New System.Drawing.Size(79, 17)
        Me.CHK_CkeckedUSer.TabIndex = 128
        Me.CHK_CkeckedUSer.Text = "CheckUser"
        Me.CHK_CkeckedUSer.UseVisualStyleBackColor = True
        Me.CHK_CkeckedUSer.Visible = False
        '
        'LBL_SectionName
        '
        Me.LBL_SectionName.AutoSize = True
        Me.LBL_SectionName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LBL_SectionName.ForeColor = System.Drawing.Color.White
        Me.LBL_SectionName.Location = New System.Drawing.Point(293, 16)
        Me.LBL_SectionName.Name = "LBL_SectionName"
        Me.LBL_SectionName.Size = New System.Drawing.Size(69, 19)
        Me.LBL_SectionName.TabIndex = 127
        Me.LBL_SectionName.Text = "Label10"
        '
        'LBL_oper_numOperator
        '
        Me.LBL_oper_numOperator.AutoSize = True
        Me.LBL_oper_numOperator.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LBL_oper_numOperator.Location = New System.Drawing.Point(1381, 18)
        Me.LBL_oper_numOperator.Name = "LBL_oper_numOperator"
        Me.LBL_oper_numOperator.Size = New System.Drawing.Size(54, 13)
        Me.LBL_oper_numOperator.TabIndex = 126
        Me.LBL_oper_numOperator.Text = "oper_num"
        Me.LBL_oper_numOperator.Visible = False
        '
        'LBL_DummyCodeSection
        '
        Me.LBL_DummyCodeSection.AutoSize = True
        Me.LBL_DummyCodeSection.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LBL_DummyCodeSection.Location = New System.Drawing.Point(606, 25)
        Me.LBL_DummyCodeSection.Name = "LBL_DummyCodeSection"
        Me.LBL_DummyCodeSection.Size = New System.Drawing.Size(43, 13)
        Me.LBL_DummyCodeSection.TabIndex = 125
        Me.LBL_DummyCodeSection.Text = "Section"
        Me.LBL_DummyCodeSection.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(22, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 124
        Me.PictureBox2.TabStop = False
        '
        'lbl_empname
        '
        Me.lbl_empname.AutoSize = True
        Me.lbl_empname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_empname.ForeColor = System.Drawing.Color.White
        Me.lbl_empname.Location = New System.Drawing.Point(1630, 16)
        Me.lbl_empname.Name = "lbl_empname"
        Me.lbl_empname.Size = New System.Drawing.Size(88, 19)
        Me.lbl_empname.TabIndex = 8
        Me.lbl_empname.Text = "emp name"
        '
        'lbl_empnum
        '
        Me.lbl_empnum.AutoSize = True
        Me.lbl_empnum.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_empnum.ForeColor = System.Drawing.Color.White
        Me.lbl_empnum.Location = New System.Drawing.Point(1534, 16)
        Me.lbl_empnum.Name = "lbl_empnum"
        Me.lbl_empnum.Size = New System.Drawing.Size(80, 19)
        Me.lbl_empnum.TabIndex = 7
        Me.lbl_empnum.Text = "emp num"
        '
        'LBL_Title
        '
        Me.LBL_Title.AutoSize = True
        Me.LBL_Title.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LBL_Title.ForeColor = System.Drawing.Color.White
        Me.LBL_Title.Location = New System.Drawing.Point(78, 16)
        Me.LBL_Title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_Title.Name = "LBL_Title"
        Me.LBL_Title.Size = New System.Drawing.Size(223, 19)
        Me.LBL_Title.TabIndex = 3
        Me.LBL_Title.Text = "MONITORING CHECKLIST - "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txt_date)
        Me.Panel2.Controls.Add(Me.BTN_SaveHeader)
        Me.Panel2.Controls.Add(Me.PBox_QRCode)
        Me.Panel2.Controls.Add(Me.TXT_CreatedBy)
        Me.Panel2.Controls.Add(Me.LBL_CreatedBy)
        Me.Panel2.Controls.Add(Me.txt_jobname_ext)
        Me.Panel2.Controls.Add(Me.txt_shift)
        Me.Panel2.Controls.Add(Me.txt_operator)
        Me.Panel2.Controls.Add(Me.txt_um)
        Me.Panel2.Controls.Add(Me.txt_jobqty)
        Me.Panel2.Controls.Add(Me.txt_jobname)
        Me.Panel2.Controls.Add(Me.txt_job)
        Me.Panel2.Controls.Add(Me.txt_machine)
        Me.Panel2.Controls.Add(Me.TXT_MCNO)
        Me.Panel2.Controls.Add(Me.BTN_AddMCNo)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1868, 132)
        Me.Panel2.TabIndex = 1
        '
        'txt_date
        '
        Me.txt_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date.Location = New System.Drawing.Point(1141, 19)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(176, 35)
        Me.txt_date.TabIndex = 0
        '
        'BTN_SaveHeader
        '
        Me.BTN_SaveHeader.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTN_SaveHeader.Enabled = False
        Me.BTN_SaveHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SaveHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BTN_SaveHeader.Location = New System.Drawing.Point(1323, 14)
        Me.BTN_SaveHeader.Name = "BTN_SaveHeader"
        Me.BTN_SaveHeader.Size = New System.Drawing.Size(98, 41)
        Me.BTN_SaveHeader.TabIndex = 32
        Me.BTN_SaveHeader.Text = "Save"
        Me.BTN_SaveHeader.UseVisualStyleBackColor = False
        '
        'PBox_QRCode
        '
        Me.PBox_QRCode.BackColor = System.Drawing.Color.Transparent
        Me.PBox_QRCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBox_QRCode.Location = New System.Drawing.Point(857, -3)
        Me.PBox_QRCode.Name = "PBox_QRCode"
        Me.PBox_QRCode.Size = New System.Drawing.Size(156, 132)
        Me.PBox_QRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBox_QRCode.TabIndex = 31
        Me.PBox_QRCode.TabStop = False
        '
        'TXT_CreatedBy
        '
        Me.TXT_CreatedBy.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TXT_CreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CreatedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CreatedBy.Location = New System.Drawing.Point(1552, 81)
        Me.TXT_CreatedBy.Name = "TXT_CreatedBy"
        Me.TXT_CreatedBy.ReadOnly = True
        Me.TXT_CreatedBy.Size = New System.Drawing.Size(298, 26)
        Me.TXT_CreatedBy.TabIndex = 29
        '
        'LBL_CreatedBy
        '
        Me.LBL_CreatedBy.AutoSize = True
        Me.LBL_CreatedBy.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CreatedBy.Location = New System.Drawing.Point(1428, 84)
        Me.LBL_CreatedBy.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_CreatedBy.Name = "LBL_CreatedBy"
        Me.LBL_CreatedBy.Size = New System.Drawing.Size(110, 20)
        Me.LBL_CreatedBy.TabIndex = 28
        Me.LBL_CreatedBy.Text = "SUPERVISOR:"
        '
        'txt_jobname_ext
        '
        Me.txt_jobname_ext.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_jobname_ext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_jobname_ext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jobname_ext.Location = New System.Drawing.Point(169, 97)
        Me.txt_jobname_ext.Name = "txt_jobname_ext"
        Me.txt_jobname_ext.ReadOnly = True
        Me.txt_jobname_ext.Size = New System.Drawing.Size(682, 26)
        Me.txt_jobname_ext.TabIndex = 27
        '
        'txt_shift
        '
        Me.txt_shift.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_shift.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_shift.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_shift.Location = New System.Drawing.Point(1141, 95)
        Me.txt_shift.Name = "txt_shift"
        Me.txt_shift.ReadOnly = True
        Me.txt_shift.Size = New System.Drawing.Size(45, 26)
        Me.txt_shift.TabIndex = 26
        '
        'txt_operator
        '
        Me.txt_operator.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_operator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_operator.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_operator.Location = New System.Drawing.Point(1552, 50)
        Me.txt_operator.Name = "txt_operator"
        Me.txt_operator.ReadOnly = True
        Me.txt_operator.Size = New System.Drawing.Size(188, 26)
        Me.txt_operator.TabIndex = 25
        '
        'txt_um
        '
        Me.txt_um.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_um.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_um.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_um.Location = New System.Drawing.Point(1263, 63)
        Me.txt_um.Name = "txt_um"
        Me.txt_um.ReadOnly = True
        Me.txt_um.Size = New System.Drawing.Size(54, 26)
        Me.txt_um.TabIndex = 23
        '
        'txt_jobqty
        '
        Me.txt_jobqty.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_jobqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_jobqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jobqty.Location = New System.Drawing.Point(1141, 63)
        Me.txt_jobqty.Name = "txt_jobqty"
        Me.txt_jobqty.ReadOnly = True
        Me.txt_jobqty.Size = New System.Drawing.Size(116, 26)
        Me.txt_jobqty.TabIndex = 22
        '
        'txt_jobname
        '
        Me.txt_jobname.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_jobname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_jobname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jobname.Location = New System.Drawing.Point(169, 65)
        Me.txt_jobname.Name = "txt_jobname"
        Me.txt_jobname.ReadOnly = True
        Me.txt_jobname.Size = New System.Drawing.Size(386, 26)
        Me.txt_jobname.TabIndex = 21
        '
        'txt_job
        '
        Me.txt_job.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_job.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_job.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_job.Location = New System.Drawing.Point(169, 37)
        Me.txt_job.Name = "txt_job"
        Me.txt_job.ReadOnly = True
        Me.txt_job.Size = New System.Drawing.Size(386, 26)
        Me.txt_job.TabIndex = 20
        '
        'txt_machine
        '
        Me.txt_machine.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_machine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_machine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_machine.Location = New System.Drawing.Point(169, 10)
        Me.txt_machine.Name = "txt_machine"
        Me.txt_machine.ReadOnly = True
        Me.txt_machine.Size = New System.Drawing.Size(233, 26)
        Me.txt_machine.TabIndex = 19
        '
        'TXT_MCNO
        '
        Me.TXT_MCNO.BackColor = System.Drawing.Color.White
        Me.TXT_MCNO.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_MCNO.ForeColor = System.Drawing.Color.DarkRed
        Me.TXT_MCNO.Location = New System.Drawing.Point(1552, 17)
        Me.TXT_MCNO.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_MCNO.Multiline = True
        Me.TXT_MCNO.Name = "TXT_MCNO"
        Me.TXT_MCNO.ReadOnly = True
        Me.TXT_MCNO.Size = New System.Drawing.Size(164, 25)
        Me.TXT_MCNO.TabIndex = 18
        Me.TXT_MCNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_AddMCNo
        '
        Me.BTN_AddMCNo.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTN_AddMCNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_AddMCNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AddMCNo.ForeColor = System.Drawing.Color.White
        Me.BTN_AddMCNo.Location = New System.Drawing.Point(1720, 14)
        Me.BTN_AddMCNo.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_AddMCNo.Name = "BTN_AddMCNo"
        Me.BTN_AddMCNo.Size = New System.Drawing.Size(130, 31)
        Me.BTN_AddMCNo.TabIndex = 16
        Me.BTN_AddMCNo.Text = "Generate MC No"
        Me.BTN_AddMCNo.UseVisualStyleBackColor = False
        Me.BTN_AddMCNo.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1081, 99)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "SHIFT:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1443, 54)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "OPERATOR:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1470, 22)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "MC NO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1061, 67)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "JOB QTY:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1084, 25)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "DATE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(75, 69)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "JOB NAME:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "JOB:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(82, 14)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "MACHINE:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Controls.Add(Me.BTN_NxtProcess)
        Me.Panel3.Controls.Add(Me.BTN_SuperIntendent)
        Me.Panel3.Controls.Add(Me.BTN_Supervisor)
        Me.Panel3.Controls.Add(Me.BTN_Operator)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 180)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1868, 53)
        Me.Panel3.TabIndex = 2
        '
        'BTN_NxtProcess
        '
        Me.BTN_NxtProcess.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_NxtProcess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_NxtProcess.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_NxtProcess.Location = New System.Drawing.Point(1313, 8)
        Me.BTN_NxtProcess.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_NxtProcess.Name = "BTN_NxtProcess"
        Me.BTN_NxtProcess.Size = New System.Drawing.Size(373, 38)
        Me.BTN_NxtProcess.TabIndex = 13
        Me.BTN_NxtProcess.Text = "NXT PROCESS SV"
        Me.BTN_NxtProcess.UseVisualStyleBackColor = False
        '
        'BTN_SuperIntendent
        '
        Me.BTN_SuperIntendent.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_SuperIntendent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_SuperIntendent.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SuperIntendent.Location = New System.Drawing.Point(936, 8)
        Me.BTN_SuperIntendent.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_SuperIntendent.Name = "BTN_SuperIntendent"
        Me.BTN_SuperIntendent.Size = New System.Drawing.Size(373, 38)
        Me.BTN_SuperIntendent.TabIndex = 12
        Me.BTN_SuperIntendent.Text = "SUPERINTENDENT"
        Me.BTN_SuperIntendent.UseVisualStyleBackColor = False
        '
        'BTN_Supervisor
        '
        Me.BTN_Supervisor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_Supervisor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Supervisor.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Supervisor.Location = New System.Drawing.Point(559, 8)
        Me.BTN_Supervisor.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_Supervisor.Name = "BTN_Supervisor"
        Me.BTN_Supervisor.Size = New System.Drawing.Size(373, 38)
        Me.BTN_Supervisor.TabIndex = 11
        Me.BTN_Supervisor.Text = "SUPERVISOR"
        Me.BTN_Supervisor.UseVisualStyleBackColor = False
        '
        'BTN_Operator
        '
        Me.BTN_Operator.BackColor = System.Drawing.Color.White
        Me.BTN_Operator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Operator.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Operator.ForeColor = System.Drawing.SystemColors.Highlight
        Me.BTN_Operator.Location = New System.Drawing.Point(182, 8)
        Me.BTN_Operator.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_Operator.Name = "BTN_Operator"
        Me.BTN_Operator.Size = New System.Drawing.Size(373, 38)
        Me.BTN_Operator.TabIndex = 10
        Me.BTN_Operator.Text = "OPERATOR"
        Me.BTN_Operator.UseVisualStyleBackColor = False
        '
        'PNL_MonitoringChecklistOperatorMain
        '
        Me.PNL_MonitoringChecklistOperatorMain.Location = New System.Drawing.Point(16, 239)
        Me.PNL_MonitoringChecklistOperatorMain.Name = "PNL_MonitoringChecklistOperatorMain"
        Me.PNL_MonitoringChecklistOperatorMain.Size = New System.Drawing.Size(1840, 820)
        Me.PNL_MonitoringChecklistOperatorMain.TabIndex = 3
        '
        'FRM_MonitoringChecklistMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1868, 1061)
        Me.Controls.Add(Me.PNL_MonitoringChecklistOperatorMain)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FRM_MonitoringChecklistMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_MonitoringChecklistMain"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PBox_QRCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LBL_Title As Label
    Friend WithEvents lbl_empname As Label
    Friend WithEvents lbl_empnum As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BTN_NxtProcess As Button
    Friend WithEvents BTN_SuperIntendent As Button
    Friend WithEvents BTN_Supervisor As Button
    Friend WithEvents BTN_Operator As Button
    Friend WithEvents PNL_MonitoringChecklistOperatorMain As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_MCNO As TextBox
    Friend WithEvents BTN_AddMCNo As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txt_jobname As TextBox
    Friend WithEvents txt_job As TextBox
    Friend WithEvents txt_machine As TextBox
    Friend WithEvents txt_shift As TextBox
    Friend WithEvents txt_operator As TextBox
    Friend WithEvents txt_um As TextBox
    Friend WithEvents txt_jobqty As TextBox
    Friend WithEvents txt_jobname_ext As TextBox
    Friend WithEvents LBL_DummyCodeSection As Label
    Friend WithEvents LBL_oper_numOperator As Label
    Friend WithEvents LBL_SectionName As Label
    Friend WithEvents TXT_CreatedBy As TextBox
    Friend WithEvents LBL_CreatedBy As Label
    Friend WithEvents PBox_QRCode As PictureBox
    Friend WithEvents CHK_CkeckedUSer As CheckBox
    Friend WithEvents LBL_Section As Label
    Friend WithEvents TXT_OrigSection As TextBox
    Friend WithEvents TXT_OrigSectionCode As TextBox
    Friend WithEvents BTN_SaveHeader As Button
    Friend WithEvents txt_date As DateTimePicker
End Class