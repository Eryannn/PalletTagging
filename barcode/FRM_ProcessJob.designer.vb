<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_ProcessJob
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_ProcessJob))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_empname = New System.Windows.Forms.Label()
        Me.lbl_empnum = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PNL_InfoProcessJob = New System.Windows.Forms.Panel()
        Me.txt_jobqty = New System.Windows.Forms.TextBox()
        Me.txt_jobname = New System.Windows.Forms.TextBox()
        Me.txt_machine = New System.Windows.Forms.TextBox()
        Me.txt_joborder = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_suffix = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_opernum = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BTN_UserMaintenance = New System.Windows.Forms.Button()
        Me.BTN_AddFinishingDailyOut = New System.Windows.Forms.Button()
        Me.btn_printpallet = New System.Windows.Forms.Button()
        Me.btn_generateqr = New System.Windows.Forms.Button()
        Me.BTN_MonitoringChecklistSummary = New System.Windows.Forms.Button()
        Me.BTN_AddMonitoringChecklist = New System.Windows.Forms.Button()
        Me.BTN_Logout = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL_InfoProcessJob.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.lbl_empname)
        Me.Panel1.Controls.Add(Me.lbl_empnum)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1011, 89)
        Me.Panel1.TabIndex = 1
        '
        'lbl_empname
        '
        Me.lbl_empname.AutoSize = True
        Me.lbl_empname.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_empname.ForeColor = System.Drawing.Color.White
        Me.lbl_empname.Location = New System.Drawing.Point(830, 38)
        Me.lbl_empname.Name = "lbl_empname"
        Me.lbl_empname.Size = New System.Drawing.Size(154, 18)
        Me.lbl_empname.TabIndex = 127
        Me.lbl_empname.Text = "Pedrick DIvinagracia"
        '
        'lbl_empnum
        '
        Me.lbl_empnum.AutoSize = True
        Me.lbl_empnum.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_empnum.ForeColor = System.Drawing.Color.White
        Me.lbl_empnum.Location = New System.Drawing.Point(753, 38)
        Me.lbl_empnum.Name = "lbl_empnum"
        Me.lbl_empnum.Size = New System.Drawing.Size(71, 18)
        Me.lbl_empnum.TabIndex = 126
        Me.lbl_empnum.Text = "PPR0977"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(27, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(82, 68)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 125
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(114, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PROCESS JOB"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'PNL_InfoProcessJob
        '
        Me.PNL_InfoProcessJob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PNL_InfoProcessJob.Controls.Add(Me.txt_jobqty)
        Me.PNL_InfoProcessJob.Controls.Add(Me.txt_jobname)
        Me.PNL_InfoProcessJob.Controls.Add(Me.txt_machine)
        Me.PNL_InfoProcessJob.Controls.Add(Me.txt_joborder)
        Me.PNL_InfoProcessJob.Controls.Add(Me.Label8)
        Me.PNL_InfoProcessJob.Controls.Add(Me.Label7)
        Me.PNL_InfoProcessJob.Controls.Add(Me.Label11)
        Me.PNL_InfoProcessJob.Controls.Add(Me.Label6)
        Me.PNL_InfoProcessJob.Controls.Add(Me.Label5)
        Me.PNL_InfoProcessJob.Controls.Add(Me.Label10)
        Me.PNL_InfoProcessJob.Controls.Add(Me.Label4)
        Me.PNL_InfoProcessJob.Controls.Add(Me.Label9)
        Me.PNL_InfoProcessJob.Controls.Add(Me.txt_suffix)
        Me.PNL_InfoProcessJob.Controls.Add(Me.Label3)
        Me.PNL_InfoProcessJob.Controls.Add(Me.txt_opernum)
        Me.PNL_InfoProcessJob.Location = New System.Drawing.Point(27, 111)
        Me.PNL_InfoProcessJob.Name = "PNL_InfoProcessJob"
        Me.PNL_InfoProcessJob.Size = New System.Drawing.Size(957, 229)
        Me.PNL_InfoProcessJob.TabIndex = 21
        '
        'txt_jobqty
        '
        Me.txt_jobqty.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_jobqty.Enabled = False
        Me.txt_jobqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jobqty.Location = New System.Drawing.Point(236, 175)
        Me.txt_jobqty.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_jobqty.Multiline = True
        Me.txt_jobqty.Name = "txt_jobqty"
        Me.txt_jobqty.Size = New System.Drawing.Size(672, 33)
        Me.txt_jobqty.TabIndex = 21
        '
        'txt_jobname
        '
        Me.txt_jobname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_jobname.Enabled = False
        Me.txt_jobname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jobname.Location = New System.Drawing.Point(236, 146)
        Me.txt_jobname.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_jobname.Multiline = True
        Me.txt_jobname.Name = "txt_jobname"
        Me.txt_jobname.Size = New System.Drawing.Size(672, 25)
        Me.txt_jobname.TabIndex = 20
        '
        'txt_machine
        '
        Me.txt_machine.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_machine.Enabled = False
        Me.txt_machine.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_machine.Location = New System.Drawing.Point(236, 21)
        Me.txt_machine.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_machine.Multiline = True
        Me.txt_machine.Name = "txt_machine"
        Me.txt_machine.Size = New System.Drawing.Size(672, 25)
        Me.txt_machine.TabIndex = 19
        '
        'txt_joborder
        '
        Me.txt_joborder.BackColor = System.Drawing.Color.White
        Me.txt_joborder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_joborder.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_joborder.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_joborder.Location = New System.Drawing.Point(236, 51)
        Me.txt_joborder.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_joborder.MaxLength = 10
        Me.txt_joborder.Multiline = True
        Me.txt_joborder.Name = "txt_joborder"
        Me.txt_joborder.Size = New System.Drawing.Size(672, 25)
        Me.txt_joborder.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(133, 175)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "JOB QTY:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(119, 146)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "JOB NAME:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(203, 112)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 17)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(85, 118)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "OPERATION NO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(109, 87)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "JOB SUFFIX:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(203, 51)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 17)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(109, 57)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "JOB ORDER:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(203, 80)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "*"
        '
        'txt_suffix
        '
        Me.txt_suffix.BackColor = System.Drawing.Color.White
        Me.txt_suffix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_suffix.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_suffix.Location = New System.Drawing.Point(236, 80)
        Me.txt_suffix.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_suffix.MaxLength = 2
        Me.txt_suffix.Multiline = True
        Me.txt_suffix.Name = "txt_suffix"
        Me.txt_suffix.Size = New System.Drawing.Size(672, 25)
        Me.txt_suffix.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "RESOURCE / MACHINE:"
        '
        'txt_opernum
        '
        Me.txt_opernum.BackColor = System.Drawing.Color.White
        Me.txt_opernum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_opernum.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_opernum.Location = New System.Drawing.Point(236, 112)
        Me.txt_opernum.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_opernum.MaxLength = 3
        Me.txt_opernum.Multiline = True
        Me.txt_opernum.Name = "txt_opernum"
        Me.txt_opernum.Size = New System.Drawing.Size(672, 25)
        Me.txt_opernum.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.BTN_UserMaintenance)
        Me.Panel3.Controls.Add(Me.BTN_AddFinishingDailyOut)
        Me.Panel3.Controls.Add(Me.btn_printpallet)
        Me.Panel3.Controls.Add(Me.btn_generateqr)
        Me.Panel3.Controls.Add(Me.BTN_MonitoringChecklistSummary)
        Me.Panel3.Controls.Add(Me.BTN_AddMonitoringChecklist)
        Me.Panel3.Location = New System.Drawing.Point(27, 361)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(957, 203)
        Me.Panel3.TabIndex = 22
        '
        'BTN_UserMaintenance
        '
        Me.BTN_UserMaintenance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_UserMaintenance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_UserMaintenance.ForeColor = System.Drawing.SystemColors.Highlight
        Me.BTN_UserMaintenance.Location = New System.Drawing.Point(263, 105)
        Me.BTN_UserMaintenance.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_UserMaintenance.Name = "BTN_UserMaintenance"
        Me.BTN_UserMaintenance.Size = New System.Drawing.Size(211, 72)
        Me.BTN_UserMaintenance.TabIndex = 12
        Me.BTN_UserMaintenance.Text = "USER MAINTENANCE"
        Me.BTN_UserMaintenance.UseVisualStyleBackColor = False
        Me.BTN_UserMaintenance.Visible = False
        '
        'BTN_AddFinishingDailyOut
        '
        Me.BTN_AddFinishingDailyOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_AddFinishingDailyOut.Enabled = False
        Me.BTN_AddFinishingDailyOut.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AddFinishingDailyOut.ForeColor = System.Drawing.SystemColors.Highlight
        Me.BTN_AddFinishingDailyOut.Location = New System.Drawing.Point(48, 105)
        Me.BTN_AddFinishingDailyOut.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_AddFinishingDailyOut.Name = "BTN_AddFinishingDailyOut"
        Me.BTN_AddFinishingDailyOut.Size = New System.Drawing.Size(211, 72)
        Me.BTN_AddFinishingDailyOut.TabIndex = 11
        Me.BTN_AddFinishingDailyOut.Text = "ADD FINISHING DAILY OUTPUT REPORT"
        Me.BTN_AddFinishingDailyOut.UseVisualStyleBackColor = False
        '
        'btn_printpallet
        '
        Me.btn_printpallet.Enabled = False
        Me.btn_printpallet.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_printpallet.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_printpallet.Location = New System.Drawing.Point(263, 29)
        Me.btn_printpallet.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_printpallet.Name = "btn_printpallet"
        Me.btn_printpallet.Size = New System.Drawing.Size(211, 72)
        Me.btn_printpallet.TabIndex = 9
        Me.btn_printpallet.Text = "PRINT PALLET TAGS"
        Me.btn_printpallet.UseVisualStyleBackColor = False
        '
        'btn_generateqr
        '
        Me.btn_generateqr.Enabled = False
        Me.btn_generateqr.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_generateqr.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_generateqr.Location = New System.Drawing.Point(693, 29)
        Me.btn_generateqr.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_generateqr.Name = "btn_generateqr"
        Me.btn_generateqr.Size = New System.Drawing.Size(211, 72)
        Me.btn_generateqr.TabIndex = 10
        Me.btn_generateqr.Text = "GENERATE JOB BARCODE"
        Me.btn_generateqr.UseVisualStyleBackColor = False
        '
        'BTN_MonitoringChecklistSummary
        '
        Me.BTN_MonitoringChecklistSummary.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_MonitoringChecklistSummary.ForeColor = System.Drawing.SystemColors.Highlight
        Me.BTN_MonitoringChecklistSummary.Location = New System.Drawing.Point(478, 29)
        Me.BTN_MonitoringChecklistSummary.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_MonitoringChecklistSummary.Name = "BTN_MonitoringChecklistSummary"
        Me.BTN_MonitoringChecklistSummary.Size = New System.Drawing.Size(211, 72)
        Me.BTN_MonitoringChecklistSummary.TabIndex = 8
        Me.BTN_MonitoringChecklistSummary.Text = "MONITORING CHECKLIST SUMMARY"
        Me.BTN_MonitoringChecklistSummary.UseVisualStyleBackColor = False
        '
        'BTN_AddMonitoringChecklist
        '
        Me.BTN_AddMonitoringChecklist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_AddMonitoringChecklist.Enabled = False
        Me.BTN_AddMonitoringChecklist.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AddMonitoringChecklist.ForeColor = System.Drawing.SystemColors.Highlight
        Me.BTN_AddMonitoringChecklist.Location = New System.Drawing.Point(48, 29)
        Me.BTN_AddMonitoringChecklist.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_AddMonitoringChecklist.Name = "BTN_AddMonitoringChecklist"
        Me.BTN_AddMonitoringChecklist.Size = New System.Drawing.Size(211, 72)
        Me.BTN_AddMonitoringChecklist.TabIndex = 7
        Me.BTN_AddMonitoringChecklist.Text = "ADD MONITORING CHECKLIST"
        Me.BTN_AddMonitoringChecklist.UseVisualStyleBackColor = False
        '
        'BTN_Logout
        '
        Me.BTN_Logout.BackColor = System.Drawing.Color.Transparent
        Me.BTN_Logout.ForeColor = System.Drawing.SystemColors.Highlight
        Me.BTN_Logout.Location = New System.Drawing.Point(866, 583)
        Me.BTN_Logout.Name = "BTN_Logout"
        Me.BTN_Logout.Size = New System.Drawing.Size(118, 45)
        Me.BTN_Logout.TabIndex = 23
        Me.BTN_Logout.Text = "Logout"
        Me.BTN_Logout.UseVisualStyleBackColor = False
        '
        'FRM_ProcessJob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 640)
        Me.Controls.Add(Me.BTN_Logout)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PNL_InfoProcessJob)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FRM_ProcessJob"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = resources.GetString("$this.Text")
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL_InfoProcessJob.ResumeLayout(False)
        Me.PNL_InfoProcessJob.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_empname As Label
    Friend WithEvents lbl_empnum As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PNL_InfoProcessJob As Panel
    Friend WithEvents txt_machine As TextBox
    Friend WithEvents txt_joborder As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_suffix As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_opernum As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_printpallet As Button
    Friend WithEvents btn_generateqr As Button
    Friend WithEvents BTN_MonitoringChecklistSummary As Button
    Friend WithEvents BTN_AddMonitoringChecklist As Button
    Friend WithEvents txt_jobqty As TextBox
    Friend WithEvents txt_jobname As TextBox
    Friend WithEvents BTN_Logout As Button
    Friend WithEvents BTN_AddFinishingDailyOut As Button
    Friend WithEvents BTN_UserMaintenance As Button
End Class
