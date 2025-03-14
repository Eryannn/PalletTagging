<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_MonitoringChecklistSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_MonitoringChecklistSummary))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TXT_MachineName = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TXT_OperName = New System.Windows.Forms.TextBox()
        Me.LBL_Empname = New System.Windows.Forms.Label()
        Me.TXT_CheckMcNo = New System.Windows.Forms.TextBox()
        Me.LBL_EmpNum = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmb_machine = New System.Windows.Forms.ComboBox()
        Me.CBO_SectionSummary = New System.Windows.Forms.ComboBox()
        Me.dtp_enddate = New System.Windows.Forms.DateTimePicker()
        Me.dtp_startdate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_Process = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BTN_Back = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Machine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.McNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dates = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Shift = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JOB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Operators = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConductedBySuperv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerifiedBySuperIntendent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AckByNextProSupv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTN_Update = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ResrC000TableAdapter1 = New barcode._PI_SP_AppDataSetTableAdapters.RESRC000TableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.TXT_MachineName)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.TXT_OperName)
        Me.Panel1.Controls.Add(Me.LBL_Empname)
        Me.Panel1.Controls.Add(Me.TXT_CheckMcNo)
        Me.Panel1.Controls.Add(Me.LBL_EmpNum)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1868, 84)
        Me.Panel1.TabIndex = 1
        '
        'TXT_MachineName
        '
        Me.TXT_MachineName.BackColor = System.Drawing.SystemColors.Highlight
        Me.TXT_MachineName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_MachineName.Location = New System.Drawing.Point(1461, 15)
        Me.TXT_MachineName.Name = "TXT_MachineName"
        Me.TXT_MachineName.Size = New System.Drawing.Size(100, 13)
        Me.TXT_MachineName.TabIndex = 167
        Me.TXT_MachineName.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(84, 84)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 124
        Me.PictureBox2.TabStop = False
        '
        'TXT_OperName
        '
        Me.TXT_OperName.BackColor = System.Drawing.SystemColors.Highlight
        Me.TXT_OperName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_OperName.Location = New System.Drawing.Point(1654, 12)
        Me.TXT_OperName.Name = "TXT_OperName"
        Me.TXT_OperName.Size = New System.Drawing.Size(100, 13)
        Me.TXT_OperName.TabIndex = 166
        Me.TXT_OperName.Visible = False
        '
        'LBL_Empname
        '
        Me.LBL_Empname.AutoSize = True
        Me.LBL_Empname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Empname.ForeColor = System.Drawing.Color.White
        Me.LBL_Empname.Location = New System.Drawing.Point(1666, 36)
        Me.LBL_Empname.Name = "LBL_Empname"
        Me.LBL_Empname.Size = New System.Drawing.Size(88, 19)
        Me.LBL_Empname.TabIndex = 8
        Me.LBL_Empname.Text = "emp name"
        '
        'TXT_CheckMcNo
        '
        Me.TXT_CheckMcNo.BackColor = System.Drawing.SystemColors.Highlight
        Me.TXT_CheckMcNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_CheckMcNo.Location = New System.Drawing.Point(1768, 15)
        Me.TXT_CheckMcNo.Name = "TXT_CheckMcNo"
        Me.TXT_CheckMcNo.Size = New System.Drawing.Size(100, 13)
        Me.TXT_CheckMcNo.TabIndex = 165
        Me.TXT_CheckMcNo.Visible = False
        '
        'LBL_EmpNum
        '
        Me.LBL_EmpNum.AutoSize = True
        Me.LBL_EmpNum.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EmpNum.ForeColor = System.Drawing.Color.White
        Me.LBL_EmpNum.Location = New System.Drawing.Point(1570, 36)
        Me.LBL_EmpNum.Name = "LBL_EmpNum"
        Me.LBL_EmpNum.Size = New System.Drawing.Size(80, 19)
        Me.LBL_EmpNum.TabIndex = 7
        Me.LBL_EmpNum.Text = "emp num"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(92, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(443, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "MONITORING CHECKLIST SUMMARY"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.cmb_machine)
        Me.Panel2.Controls.Add(Me.CBO_SectionSummary)
        Me.Panel2.Controls.Add(Me.dtp_enddate)
        Me.Panel2.Controls.Add(Me.dtp_startdate)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.BTN_Process)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1868, 195)
        Me.Panel2.TabIndex = 2
        '
        'cmb_machine
        '
        Me.cmb_machine.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_machine.FormattingEnabled = True
        Me.cmb_machine.Items.AddRange(New Object() {"OFFSET", "WEB", "DIGITAL PRESS", "DIE CUTTING", "LAMINATION", "GLUING", "FOLDING", "STITCHING", "PERFECT BINDING", "ERECTING", "MANUAL FINISHING", "BINDERY FINISHING", "STRIPPING", "MANUAL STRIPPING", "MACHINE STRIPPING", "SHEETING/SLITTING", "CUTTING", "3 KNIVES", "INSPECTION MACHINE", "QA"})
        Me.cmb_machine.Location = New System.Drawing.Point(263, 56)
        Me.cmb_machine.Name = "cmb_machine"
        Me.cmb_machine.Size = New System.Drawing.Size(290, 33)
        Me.cmb_machine.TabIndex = 167
        '
        'CBO_SectionSummary
        '
        Me.CBO_SectionSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBO_SectionSummary.FormattingEnabled = True
        Me.CBO_SectionSummary.Items.AddRange(New Object() {"OFFSET", "WEB", "DIGITAL PRESS", "DIE CUTTING", "LAMINATION", "GLUING", "FOLDING", "FINISHING", "STITCHING", "PERFECT BINDING", "ERECTING", "MANUAL FINISHING", "BINDERY FINISHING", "STRIPPING", "MANUAL STRIPPING", "MACHINE STRIPPING", "SHEETING/SLITTING", "CUTTING", "3 KNIVES", "INSPECTION MACHINE", "QA"})
        Me.CBO_SectionSummary.Location = New System.Drawing.Point(263, 15)
        Me.CBO_SectionSummary.Name = "CBO_SectionSummary"
        Me.CBO_SectionSummary.Size = New System.Drawing.Size(290, 33)
        Me.CBO_SectionSummary.TabIndex = 163
        '
        'dtp_enddate
        '
        Me.dtp_enddate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_enddate.CustomFormat = "M/dd/yyyy"
        Me.dtp_enddate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_enddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_enddate.Location = New System.Drawing.Point(418, 98)
        Me.dtp_enddate.Name = "dtp_enddate"
        Me.dtp_enddate.Size = New System.Drawing.Size(135, 31)
        Me.dtp_enddate.TabIndex = 162
        '
        'dtp_startdate
        '
        Me.dtp_startdate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_startdate.CustomFormat = "M/dd/yyyy"
        Me.dtp_startdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_startdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_startdate.Location = New System.Drawing.Point(263, 98)
        Me.dtp_startdate.Name = "dtp_startdate"
        Me.dtp_startdate.Size = New System.Drawing.Size(142, 31)
        Me.dtp_startdate.TabIndex = 161
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(391, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 23)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "-"
        '
        'BTN_Process
        '
        Me.BTN_Process.BackColor = System.Drawing.Color.White
        Me.BTN_Process.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Process.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Process.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Process.ForeColor = System.Drawing.SystemColors.Highlight
        Me.BTN_Process.Location = New System.Drawing.Point(334, 138)
        Me.BTN_Process.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_Process.Name = "BTN_Process"
        Me.BTN_Process.Size = New System.Drawing.Size(132, 33)
        Me.BTN_Process.TabIndex = 17
        Me.BTN_Process.Text = "PROCESS"
        Me.BTN_Process.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(73, 99)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "DATE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(72, 56)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "RESOURCE/MACHINE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(72, 26)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "SECTION"
        '
        'BTN_Back
        '
        Me.BTN_Back.BackColor = System.Drawing.Color.White
        Me.BTN_Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Back.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Back.ForeColor = System.Drawing.SystemColors.Highlight
        Me.BTN_Back.Location = New System.Drawing.Point(33, 916)
        Me.BTN_Back.Name = "BTN_Back"
        Me.BTN_Back.Size = New System.Drawing.Size(155, 46)
        Me.BTN_Back.TabIndex = 164
        Me.BTN_Back.Text = "BACK"
        Me.BTN_Back.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Machine, Me.McNo, Me.Dates, Me.Shift, Me.JOB, Me.JobName, Me.Operators, Me.ConductedBySuperv, Me.VerifiedBySuperIntendent, Me.AckByNextProSupv})
        Me.DataGridView1.Location = New System.Drawing.Point(37, 285)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1799, 621)
        Me.DataGridView1.TabIndex = 3
        '
        'Machine
        '
        Me.Machine.FillWeight = 150.0!
        Me.Machine.HeaderText = "MACHINE"
        Me.Machine.Name = "Machine"
        Me.Machine.ReadOnly = True
        Me.Machine.Width = 170
        '
        'McNo
        '
        Me.McNo.FillWeight = 150.0!
        Me.McNo.HeaderText = "MC NO."
        Me.McNo.Name = "McNo"
        Me.McNo.ReadOnly = True
        Me.McNo.Width = 170
        '
        'Dates
        '
        Me.Dates.HeaderText = "DATE"
        Me.Dates.Name = "Dates"
        Me.Dates.ReadOnly = True
        Me.Dates.Width = 150
        '
        'Shift
        '
        Me.Shift.HeaderText = "SHIFT"
        Me.Shift.Name = "Shift"
        Me.Shift.ReadOnly = True
        Me.Shift.Width = 50
        '
        'JOB
        '
        Me.JOB.HeaderText = "JOB"
        Me.JOB.Name = "JOB"
        Me.JOB.ReadOnly = True
        Me.JOB.Width = 170
        '
        'JobName
        '
        Me.JobName.HeaderText = "JOB NAME"
        Me.JobName.Name = "JobName"
        Me.JobName.ReadOnly = True
        Me.JobName.Width = 250
        '
        'Operators
        '
        Me.Operators.HeaderText = "OPERATOR"
        Me.Operators.Name = "Operators"
        Me.Operators.ReadOnly = True
        Me.Operators.Width = 220
        '
        'ConductedBySuperv
        '
        Me.ConductedBySuperv.HeaderText = "CONDUCTED BY SUPERVISOR"
        Me.ConductedBySuperv.Name = "ConductedBySuperv"
        Me.ConductedBySuperv.ReadOnly = True
        Me.ConductedBySuperv.Width = 210
        '
        'VerifiedBySuperIntendent
        '
        Me.VerifiedBySuperIntendent.HeaderText = "VERIFIED BY SUPERINTENDENT"
        Me.VerifiedBySuperIntendent.Name = "VerifiedBySuperIntendent"
        Me.VerifiedBySuperIntendent.ReadOnly = True
        Me.VerifiedBySuperIntendent.Width = 210
        '
        'AckByNextProSupv
        '
        Me.AckByNextProSupv.HeaderText = "ACK BY NEXT PROCESS SUPV"
        Me.AckByNextProSupv.Name = "AckByNextProSupv"
        Me.AckByNextProSupv.ReadOnly = True
        Me.AckByNextProSupv.Width = 210
        '
        'BTN_Update
        '
        Me.BTN_Update.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTN_Update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Update.Enabled = False
        Me.BTN_Update.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Update.ForeColor = System.Drawing.Color.White
        Me.BTN_Update.Location = New System.Drawing.Point(1685, 915)
        Me.BTN_Update.Name = "BTN_Update"
        Me.BTN_Update.Size = New System.Drawing.Size(147, 47)
        Me.BTN_Update.TabIndex = 4
        Me.BTN_Update.Text = "UPDATE"
        Me.BTN_Update.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 1037)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1868, 24)
        Me.Panel6.TabIndex = 166
        '
        'ResrC000TableAdapter1
        '
        Me.ResrC000TableAdapter1.ClearBeforeFill = True
        '
        'FRM_MonitoringChecklistSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1868, 1061)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.BTN_Back)
        Me.Controls.Add(Me.BTN_Update)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FRM_MonitoringChecklistSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_MonitoringChecklistSummary"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LBL_Empname As Label
    Friend WithEvents LBL_EmpNum As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_Process As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dtp_enddate As DateTimePicker
    Friend WithEvents dtp_startdate As DateTimePicker
    Friend WithEvents BTN_Update As Button
    Friend WithEvents CBO_Section As ComboBox
    Friend WithEvents CBO_SectionSummary As ComboBox
    Friend WithEvents BTN_Back As Button
    Friend WithEvents ResrC000TableAdapter1 As _PI_SP_AppDataSetTableAdapters.RESRC000TableAdapter
    Friend WithEvents TXT_CheckMcNo As TextBox
    Friend WithEvents TXT_OperName As TextBox
    Friend WithEvents cmb_machine As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Machine As DataGridViewTextBoxColumn
    Friend WithEvents McNo As DataGridViewTextBoxColumn
    Friend WithEvents Dates As DataGridViewTextBoxColumn
    Friend WithEvents Shift As DataGridViewTextBoxColumn
    Friend WithEvents JOB As DataGridViewTextBoxColumn
    Friend WithEvents JobName As DataGridViewTextBoxColumn
    Friend WithEvents Operators As DataGridViewTextBoxColumn
    Friend WithEvents ConductedBySuperv As DataGridViewTextBoxColumn
    Friend WithEvents VerifiedBySuperIntendent As DataGridViewTextBoxColumn
    Friend WithEvents AckByNextProSupv As DataGridViewTextBoxColumn
    Friend WithEvents TXT_MachineName As TextBox
End Class
