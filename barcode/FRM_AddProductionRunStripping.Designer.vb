<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_AddProductionRunStripping
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_MCNoChecker = New System.Windows.Forms.TextBox()
        Me.TXT_CheckMCNo = New System.Windows.Forms.TextBox()
        Me.TXT_DummySite = New System.Windows.Forms.TextBox()
        Me.TXT_DummyResNo = New System.Windows.Forms.TextBox()
        Me.TXT_DummySasNo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.RBT_TomNA = New System.Windows.Forms.RadioButton()
        Me.RBT_TomX = New System.Windows.Forms.RadioButton()
        Me.RBT_TomCheck = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_Tom = New System.Windows.Forms.TextBox()
        Me.RBT_PrintedSheetAlignmentNA = New System.Windows.Forms.RadioButton()
        Me.RBT_PrintedSheetAlignmentX = New System.Windows.Forms.RadioButton()
        Me.RBT_PrintedSheetAlignmentCheck = New System.Windows.Forms.RadioButton()
        Me.RBT_PinMarkingsNA = New System.Windows.Forms.RadioButton()
        Me.RBT_PinMarkingsChecX = New System.Windows.Forms.RadioButton()
        Me.RBT_PinMarkingsCheck = New System.Windows.Forms.RadioButton()
        Me.TXT_SasNo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TXT_ResNo = New System.Windows.Forms.TextBox()
        Me.BTN_Cancel = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CBO_FromTime = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BTN_SaveProductionRun = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_PrintedSheetAlignment = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_PinMarkings = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TXT_MCNoChecker)
        Me.Panel2.Controls.Add(Me.TXT_CheckMCNo)
        Me.Panel2.Controls.Add(Me.TXT_DummySite)
        Me.Panel2.Controls.Add(Me.TXT_DummyResNo)
        Me.Panel2.Controls.Add(Me.TXT_DummySasNo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(821, 41)
        Me.Panel2.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Add to Production Run"
        '
        'TXT_MCNoChecker
        '
        Me.TXT_MCNoChecker.BackColor = System.Drawing.Color.DodgerBlue
        Me.TXT_MCNoChecker.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_MCNoChecker.Location = New System.Drawing.Point(1383, 9)
        Me.TXT_MCNoChecker.Name = "TXT_MCNoChecker"
        Me.TXT_MCNoChecker.Size = New System.Drawing.Size(105, 13)
        Me.TXT_MCNoChecker.TabIndex = 43
        Me.TXT_MCNoChecker.Visible = False
        '
        'TXT_CheckMCNo
        '
        Me.TXT_CheckMCNo.BackColor = System.Drawing.Color.DodgerBlue
        Me.TXT_CheckMCNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_CheckMCNo.Location = New System.Drawing.Point(1032, 9)
        Me.TXT_CheckMCNo.Name = "TXT_CheckMCNo"
        Me.TXT_CheckMCNo.Size = New System.Drawing.Size(105, 13)
        Me.TXT_CheckMCNo.TabIndex = 39
        Me.TXT_CheckMCNo.Visible = False
        '
        'TXT_DummySite
        '
        Me.TXT_DummySite.BackColor = System.Drawing.Color.DodgerBlue
        Me.TXT_DummySite.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_DummySite.Location = New System.Drawing.Point(921, 9)
        Me.TXT_DummySite.Name = "TXT_DummySite"
        Me.TXT_DummySite.Size = New System.Drawing.Size(105, 13)
        Me.TXT_DummySite.TabIndex = 40
        Me.TXT_DummySite.Visible = False
        '
        'TXT_DummyResNo
        '
        Me.TXT_DummyResNo.BackColor = System.Drawing.Color.DodgerBlue
        Me.TXT_DummyResNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_DummyResNo.Location = New System.Drawing.Point(1143, 9)
        Me.TXT_DummyResNo.Name = "TXT_DummyResNo"
        Me.TXT_DummyResNo.Size = New System.Drawing.Size(105, 13)
        Me.TXT_DummyResNo.TabIndex = 41
        Me.TXT_DummyResNo.Visible = False
        '
        'TXT_DummySasNo
        '
        Me.TXT_DummySasNo.BackColor = System.Drawing.Color.DodgerBlue
        Me.TXT_DummySasNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_DummySasNo.Location = New System.Drawing.Point(1252, 9)
        Me.TXT_DummySasNo.Name = "TXT_DummySasNo"
        Me.TXT_DummySasNo.Size = New System.Drawing.Size(105, 13)
        Me.TXT_DummySasNo.TabIndex = 42
        Me.TXT_DummySasNo.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(78, 405)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 20)
        Me.Label14.TabIndex = 87
        Me.Label14.Text = "RES Number:"
        '
        'RBT_TomNA
        '
        Me.RBT_TomNA.AutoSize = True
        Me.RBT_TomNA.Checked = True
        Me.RBT_TomNA.Location = New System.Drawing.Point(207, 30)
        Me.RBT_TomNA.Name = "RBT_TomNA"
        Me.RBT_TomNA.Size = New System.Drawing.Size(49, 24)
        Me.RBT_TomNA.TabIndex = 13
        Me.RBT_TomNA.TabStop = True
        Me.RBT_TomNA.Text = "N/A"
        Me.RBT_TomNA.UseVisualStyleBackColor = True
        '
        'RBT_TomX
        '
        Me.RBT_TomX.AutoSize = True
        Me.RBT_TomX.Location = New System.Drawing.Point(138, 30)
        Me.RBT_TomX.Name = "RBT_TomX"
        Me.RBT_TomX.Size = New System.Drawing.Size(35, 24)
        Me.RBT_TomX.TabIndex = 12
        Me.RBT_TomX.Text = "X"
        Me.RBT_TomX.UseVisualStyleBackColor = True
        '
        'RBT_TomCheck
        '
        Me.RBT_TomCheck.AutoSize = True
        Me.RBT_TomCheck.Location = New System.Drawing.Point(65, 30)
        Me.RBT_TomCheck.Name = "RBT_TomCheck"
        Me.RBT_TomCheck.Size = New System.Drawing.Size(36, 24)
        Me.RBT_TomCheck.TabIndex = 11
        Me.RBT_TomCheck.Text = "✓"
        Me.RBT_TomCheck.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(378, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Quantity:"
        '
        'TXT_Tom
        '
        Me.TXT_Tom.Enabled = False
        Me.TXT_Tom.Location = New System.Drawing.Point(459, 30)
        Me.TXT_Tom.Name = "TXT_Tom"
        Me.TXT_Tom.Size = New System.Drawing.Size(100, 26)
        Me.TXT_Tom.TabIndex = 9
        Me.TXT_Tom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RBT_PrintedSheetAlignmentNA
        '
        Me.RBT_PrintedSheetAlignmentNA.AutoSize = True
        Me.RBT_PrintedSheetAlignmentNA.Checked = True
        Me.RBT_PrintedSheetAlignmentNA.Location = New System.Drawing.Point(207, 29)
        Me.RBT_PrintedSheetAlignmentNA.Name = "RBT_PrintedSheetAlignmentNA"
        Me.RBT_PrintedSheetAlignmentNA.Size = New System.Drawing.Size(49, 24)
        Me.RBT_PrintedSheetAlignmentNA.TabIndex = 8
        Me.RBT_PrintedSheetAlignmentNA.TabStop = True
        Me.RBT_PrintedSheetAlignmentNA.Text = "N/A"
        Me.RBT_PrintedSheetAlignmentNA.UseVisualStyleBackColor = True
        '
        'RBT_PrintedSheetAlignmentX
        '
        Me.RBT_PrintedSheetAlignmentX.AutoSize = True
        Me.RBT_PrintedSheetAlignmentX.Location = New System.Drawing.Point(138, 29)
        Me.RBT_PrintedSheetAlignmentX.Name = "RBT_PrintedSheetAlignmentX"
        Me.RBT_PrintedSheetAlignmentX.Size = New System.Drawing.Size(35, 24)
        Me.RBT_PrintedSheetAlignmentX.TabIndex = 7
        Me.RBT_PrintedSheetAlignmentX.Text = "X"
        Me.RBT_PrintedSheetAlignmentX.UseVisualStyleBackColor = True
        '
        'RBT_PrintedSheetAlignmentCheck
        '
        Me.RBT_PrintedSheetAlignmentCheck.AutoSize = True
        Me.RBT_PrintedSheetAlignmentCheck.Location = New System.Drawing.Point(68, 32)
        Me.RBT_PrintedSheetAlignmentCheck.Name = "RBT_PrintedSheetAlignmentCheck"
        Me.RBT_PrintedSheetAlignmentCheck.Size = New System.Drawing.Size(36, 24)
        Me.RBT_PrintedSheetAlignmentCheck.TabIndex = 6
        Me.RBT_PrintedSheetAlignmentCheck.Text = "✓"
        Me.RBT_PrintedSheetAlignmentCheck.UseVisualStyleBackColor = True
        '
        'RBT_PinMarkingsNA
        '
        Me.RBT_PinMarkingsNA.AutoSize = True
        Me.RBT_PinMarkingsNA.Checked = True
        Me.RBT_PinMarkingsNA.Location = New System.Drawing.Point(210, 30)
        Me.RBT_PinMarkingsNA.Name = "RBT_PinMarkingsNA"
        Me.RBT_PinMarkingsNA.Size = New System.Drawing.Size(49, 24)
        Me.RBT_PinMarkingsNA.TabIndex = 2
        Me.RBT_PinMarkingsNA.TabStop = True
        Me.RBT_PinMarkingsNA.Text = "N/A"
        Me.RBT_PinMarkingsNA.UseVisualStyleBackColor = True
        '
        'RBT_PinMarkingsChecX
        '
        Me.RBT_PinMarkingsChecX.AutoSize = True
        Me.RBT_PinMarkingsChecX.Location = New System.Drawing.Point(141, 30)
        Me.RBT_PinMarkingsChecX.Name = "RBT_PinMarkingsChecX"
        Me.RBT_PinMarkingsChecX.Size = New System.Drawing.Size(35, 24)
        Me.RBT_PinMarkingsChecX.TabIndex = 1
        Me.RBT_PinMarkingsChecX.Text = "X"
        Me.RBT_PinMarkingsChecX.UseVisualStyleBackColor = True
        '
        'RBT_PinMarkingsCheck
        '
        Me.RBT_PinMarkingsCheck.AutoSize = True
        Me.RBT_PinMarkingsCheck.Location = New System.Drawing.Point(68, 30)
        Me.RBT_PinMarkingsCheck.Name = "RBT_PinMarkingsCheck"
        Me.RBT_PinMarkingsCheck.Size = New System.Drawing.Size(36, 24)
        Me.RBT_PinMarkingsCheck.TabIndex = 0
        Me.RBT_PinMarkingsCheck.Text = "✓"
        Me.RBT_PinMarkingsCheck.UseVisualStyleBackColor = True
        '
        'TXT_SasNo
        '
        Me.TXT_SasNo.Location = New System.Drawing.Point(506, 400)
        Me.TXT_SasNo.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_SasNo.Multiline = True
        Me.TXT_SasNo.Name = "TXT_SasNo"
        Me.TXT_SasNo.Size = New System.Drawing.Size(164, 25)
        Me.TXT_SasNo.TabIndex = 90
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(394, 405)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 20)
        Me.Label15.TabIndex = 89
        Me.Label15.Text = "SAS Number:"
        '
        'TXT_ResNo
        '
        Me.TXT_ResNo.Location = New System.Drawing.Point(190, 400)
        Me.TXT_ResNo.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_ResNo.Multiline = True
        Me.TXT_ResNo.Name = "TXT_ResNo"
        Me.TXT_ResNo.Size = New System.Drawing.Size(164, 25)
        Me.TXT_ResNo.TabIndex = 88
        '
        'BTN_Cancel
        '
        Me.BTN_Cancel.BackColor = System.Drawing.Color.Gainsboro
        Me.BTN_Cancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Cancel.ForeColor = System.Drawing.Color.Black
        Me.BTN_Cancel.Location = New System.Drawing.Point(24, 461)
        Me.BTN_Cancel.Name = "BTN_Cancel"
        Me.BTN_Cancel.Size = New System.Drawing.Size(99, 56)
        Me.BTN_Cancel.TabIndex = 91
        Me.BTN_Cancel.Text = "Back"
        Me.BTN_Cancel.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RBT_TomNA)
        Me.GroupBox3.Controls.Add(Me.RBT_TomX)
        Me.GroupBox3.Controls.Add(Me.RBT_TomCheck)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TXT_Tom)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(76, 304)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(683, 72)
        Me.GroupBox3.TabIndex = 79
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Torn (Punit)"
        '
        'CBO_FromTime
        '
        Me.CBO_FromTime.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBO_FromTime.FormattingEnabled = True
        Me.CBO_FromTime.Items.AddRange(New Object() {"0100", "0130", "0200", "0230", "0300", "0330", "0400", "0430", "0500", "0530", "0600", "0630", "0700", "0730", "0800", "0830", "0900", "0930", "1000", "1030", "1100", "1130", "1200", "1230"})
        Me.CBO_FromTime.Location = New System.Drawing.Point(141, 89)
        Me.CBO_FromTime.Name = "CBO_FromTime"
        Me.CBO_FromTime.Size = New System.Drawing.Size(191, 33)
        Me.CBO_FromTime.TabIndex = 76
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 18)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "From:"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"0100", "0130", "0200", "0230", "0300", "0330", "0400", "0430", "0500", "0530", "0600", "0630", "0700", "0730", "0800", "0830", "0900", "0930", "1000", "1030", "1100", "1130", "1200", "1230"})
        Me.ComboBox1.Location = New System.Drawing.Point(394, 91)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(191, 33)
        Me.ComboBox1.TabIndex = 86
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(350, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 18)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "To:"
        '
        'BTN_SaveProductionRun
        '
        Me.BTN_SaveProductionRun.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTN_SaveProductionRun.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SaveProductionRun.ForeColor = System.Drawing.Color.White
        Me.BTN_SaveProductionRun.Location = New System.Drawing.Point(671, 472)
        Me.BTN_SaveProductionRun.Name = "BTN_SaveProductionRun"
        Me.BTN_SaveProductionRun.Size = New System.Drawing.Size(122, 45)
        Me.BTN_SaveProductionRun.TabIndex = 84
        Me.BTN_SaveProductionRun.Text = "Save"
        Me.BTN_SaveProductionRun.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.RBT_PrintedSheetAlignmentNA)
        Me.GroupBox2.Controls.Add(Me.TXT_PrintedSheetAlignment)
        Me.GroupBox2.Controls.Add(Me.RBT_PrintedSheetAlignmentX)
        Me.GroupBox2.Controls.Add(Me.RBT_PrintedSheetAlignmentCheck)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(76, 226)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(683, 72)
        Me.GroupBox2.TabIndex = 78
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Printed sheet alignment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(378, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Quantity:"
        '
        'TXT_PrintedSheetAlignment
        '
        Me.TXT_PrintedSheetAlignment.Enabled = False
        Me.TXT_PrintedSheetAlignment.Location = New System.Drawing.Point(459, 29)
        Me.TXT_PrintedSheetAlignment.Name = "TXT_PrintedSheetAlignment"
        Me.TXT_PrintedSheetAlignment.Size = New System.Drawing.Size(100, 26)
        Me.TXT_PrintedSheetAlignment.TabIndex = 14
        Me.TXT_PrintedSheetAlignment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXT_PinMarkings)
        Me.GroupBox1.Controls.Add(Me.RBT_PinMarkingsNA)
        Me.GroupBox1.Controls.Add(Me.RBT_PinMarkingsChecX)
        Me.GroupBox1.Controls.Add(Me.RBT_PinMarkingsCheck)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(76, 148)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(683, 72)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pin Markings (akat ng pins)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(378, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Quantity:"
        '
        'TXT_PinMarkings
        '
        Me.TXT_PinMarkings.Enabled = False
        Me.TXT_PinMarkings.Location = New System.Drawing.Point(459, 25)
        Me.TXT_PinMarkings.Name = "TXT_PinMarkings"
        Me.TXT_PinMarkings.Size = New System.Drawing.Size(100, 26)
        Me.TXT_PinMarkings.TabIndex = 16
        Me.TXT_PinMarkings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FRM_AddProductionRunStripping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(821, 537)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TXT_SasNo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TXT_ResNo)
        Me.Controls.Add(Me.BTN_Cancel)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CBO_FromTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BTN_SaveProductionRun)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_AddProductionRunStripping"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_AddProductionRunStripping"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_MCNoChecker As TextBox
    Friend WithEvents TXT_CheckMCNo As TextBox
    Friend WithEvents TXT_DummySite As TextBox
    Friend WithEvents TXT_DummyResNo As TextBox
    Friend WithEvents TXT_DummySasNo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents RBT_TomNA As RadioButton
    Friend WithEvents RBT_TomX As RadioButton
    Friend WithEvents RBT_TomCheck As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_Tom As TextBox
    Friend WithEvents RBT_PrintedSheetAlignmentNA As RadioButton
    Friend WithEvents RBT_PrintedSheetAlignmentX As RadioButton
    Friend WithEvents RBT_PrintedSheetAlignmentCheck As RadioButton
    Friend WithEvents RBT_PinMarkingsNA As RadioButton
    Friend WithEvents RBT_PinMarkingsChecX As RadioButton
    Friend WithEvents RBT_PinMarkingsCheck As RadioButton
    Friend WithEvents TXT_SasNo As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TXT_ResNo As TextBox
    Friend WithEvents BTN_Cancel As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CBO_FromTime As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BTN_SaveProductionRun As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_PrintedSheetAlignment As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_PinMarkings As TextBox
End Class
