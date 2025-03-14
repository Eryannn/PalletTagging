<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_Monitoring_Checklist_Report
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMB_Section = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTP_StartDate = New System.Windows.Forms.DateTimePicker()
        Me.DTP_EndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CMB_Machine = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Section:"
        '
        'CMB_Section
        '
        Me.CMB_Section.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMB_Section.FormattingEnabled = True
        Me.CMB_Section.Items.AddRange(New Object() {"OFFSET", "WEB", "DIGITAL PRESS", "DIE CUTTING", "LAMINATION", "GLUING", "FOLDING", "STITCHING", "PERFECT BINDING", "ERECTING", "MANUAL FINISHING", "BINDERY FINISHING", "STRIPPING", "MANUAL STRIPPING", "MACHINE STRIPPING", "SHEETING/SLITTING", "CUTTING", "3 KNIVES", "INSPECTION MACHINE", "QA"})
        Me.CMB_Section.Location = New System.Drawing.Point(136, 61)
        Me.CMB_Section.Name = "CMB_Section"
        Me.CMB_Section.Size = New System.Drawing.Size(290, 32)
        Me.CMB_Section.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date:"
        '
        'DTP_StartDate
        '
        Me.DTP_StartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_StartDate.Location = New System.Drawing.Point(136, 156)
        Me.DTP_StartDate.Name = "DTP_StartDate"
        Me.DTP_StartDate.Size = New System.Drawing.Size(131, 29)
        Me.DTP_StartDate.TabIndex = 3
        '
        'DTP_EndDate
        '
        Me.DTP_EndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_EndDate.Location = New System.Drawing.Point(299, 156)
        Me.DTP_EndDate.Name = "DTP_EndDate"
        Me.DTP_EndDate.Size = New System.Drawing.Size(131, 29)
        Me.DTP_EndDate.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(273, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "-"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(187, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 38)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Generate Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CMB_Machine
        '
        Me.CMB_Machine.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMB_Machine.FormattingEnabled = True
        Me.CMB_Machine.Items.AddRange(New Object() {"OFFSET", "WEB", "DIGITAL PRESS", "DIE CUTTING", "LAMINATION", "GLUING", "FOLDING", "STITCHING", "PERFECT BINDING", "ERECTING", "MANUAL FINISHING", "BINDERY FINISHING", "STRIPPING", "MANUAL STRIPPING", "MACHINE STRIPPING", "SHEETING/SLITTING", "CUTTING", "3 KNIVES", "INSPECTION MACHINE", "QA"})
        Me.CMB_Machine.Location = New System.Drawing.Point(136, 99)
        Me.CMB_Machine.Name = "CMB_Machine"
        Me.CMB_Machine.Size = New System.Drawing.Size(290, 32)
        Me.CMB_Machine.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Machine:"
        '
        'FRM_Monitoring_Checklist_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 374)
        Me.Controls.Add(Me.CMB_Machine)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DTP_EndDate)
        Me.Controls.Add(Me.DTP_StartDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CMB_Section)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FRM_Monitoring_Checklist_Report"
        Me.Text = "FRM_Monitoring_Checklist_Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CMB_Section As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DTP_StartDate As DateTimePicker
    Friend WithEvents DTP_EndDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CMB_Machine As ComboBox
    Friend WithEvents Label4 As Label
End Class
