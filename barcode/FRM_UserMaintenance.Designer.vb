<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_UserMaintenance
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
        Me.ResrC000TableAdapter1 = New barcode._PI_SP_AppDataSetTableAdapters.RESRC000TableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTN_Register = New System.Windows.Forms.Button()
        Me.TXT_FullName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CBO_Position = New System.Windows.Forms.ComboBox()
        Me.TXT_Empnum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_Clear = New System.Windows.Forms.Button()
        Me.BTN_Back = New System.Windows.Forms.Button()
        Me.TXT_Site = New System.Windows.Forms.TextBox()
        Me.txt_idnum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ResrC000TableAdapter1
        '
        Me.ResrC000TableAdapter1.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 62)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(411, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USER MAINTENANCE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(116, 352)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 31)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Position"
        '
        'BTN_Register
        '
        Me.BTN_Register.BackColor = System.Drawing.Color.DodgerBlue
        Me.BTN_Register.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Register.ForeColor = System.Drawing.Color.White
        Me.BTN_Register.Location = New System.Drawing.Point(378, 475)
        Me.BTN_Register.Name = "BTN_Register"
        Me.BTN_Register.Size = New System.Drawing.Size(184, 68)
        Me.BTN_Register.TabIndex = 37
        Me.BTN_Register.Text = "REGISTER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "USER"
        Me.BTN_Register.UseVisualStyleBackColor = False
        '
        'TXT_FullName
        '
        Me.TXT_FullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_FullName.Location = New System.Drawing.Point(375, 299)
        Me.TXT_FullName.MaxLength = 50
        Me.TXT_FullName.Name = "TXT_FullName"
        Me.TXT_FullName.Size = New System.Drawing.Size(378, 35)
        Me.TXT_FullName.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(116, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 31)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Full Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(116, 150)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 31)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Site"
        '
        'CBO_Position
        '
        Me.CBO_Position.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBO_Position.FormattingEnabled = True
        Me.CBO_Position.Items.AddRange(New Object() {"Picker", "Packer", "Sorter", "Feeder", "Helper", "Line Leader", "Operator", "Asst. Operator"})
        Me.CBO_Position.Location = New System.Drawing.Point(374, 355)
        Me.CBO_Position.Name = "CBO_Position"
        Me.CBO_Position.Size = New System.Drawing.Size(378, 37)
        Me.CBO_Position.TabIndex = 43
        '
        'TXT_Empnum
        '
        Me.TXT_Empnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Empnum.Location = New System.Drawing.Point(374, 248)
        Me.TXT_Empnum.MaxLength = 50
        Me.TXT_Empnum.Name = "TXT_Empnum"
        Me.TXT_Empnum.ReadOnly = True
        Me.TXT_Empnum.Size = New System.Drawing.Size(378, 35)
        Me.TXT_Empnum.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 31)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "User ID"
        '
        'BTN_Clear
        '
        Me.BTN_Clear.BackColor = System.Drawing.Color.Firebrick
        Me.BTN_Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Clear.ForeColor = System.Drawing.Color.White
        Me.BTN_Clear.Location = New System.Drawing.Point(568, 475)
        Me.BTN_Clear.Name = "BTN_Clear"
        Me.BTN_Clear.Size = New System.Drawing.Size(184, 68)
        Me.BTN_Clear.TabIndex = 47
        Me.BTN_Clear.Text = "CLEAR"
        Me.BTN_Clear.UseVisualStyleBackColor = False
        '
        'BTN_Back
        '
        Me.BTN_Back.BackColor = System.Drawing.Color.Gray
        Me.BTN_Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Back.ForeColor = System.Drawing.Color.Beige
        Me.BTN_Back.Location = New System.Drawing.Point(846, 511)
        Me.BTN_Back.Name = "BTN_Back"
        Me.BTN_Back.Size = New System.Drawing.Size(136, 58)
        Me.BTN_Back.TabIndex = 48
        Me.BTN_Back.Text = "BACK"
        Me.BTN_Back.UseVisualStyleBackColor = False
        '
        'TXT_Site
        '
        Me.TXT_Site.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Site.Location = New System.Drawing.Point(374, 146)
        Me.TXT_Site.MaxLength = 50
        Me.TXT_Site.Name = "TXT_Site"
        Me.TXT_Site.ReadOnly = True
        Me.TXT_Site.Size = New System.Drawing.Size(378, 35)
        Me.TXT_Site.TabIndex = 49
        '
        'txt_idnum
        '
        Me.txt_idnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idnum.Location = New System.Drawing.Point(374, 196)
        Me.txt_idnum.MaxLength = 4
        Me.txt_idnum.Name = "txt_idnum"
        Me.txt_idnum.Size = New System.Drawing.Size(378, 35)
        Me.txt_idnum.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(116, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 31)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "ID#"
        '
        'FRM_UserMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(992, 585)
        Me.Controls.Add(Me.txt_idnum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_Site)
        Me.Controls.Add(Me.BTN_Back)
        Me.Controls.Add(Me.BTN_Clear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_Empnum)
        Me.Controls.Add(Me.CBO_Position)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BTN_Register)
        Me.Controls.Add(Me.TXT_FullName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_UserMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_UserMaintenance"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ResrC000TableAdapter1 As _PI_SP_AppDataSetTableAdapters.RESRC000TableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BTN_Register As Button
    Friend WithEvents TXT_FullName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CBO_Position As ComboBox
    Friend WithEvents TXT_Empnum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_Clear As Button
    Friend WithEvents BTN_Back As Button
    Friend WithEvents TXT_Site As TextBox
    Friend WithEvents txt_idnum As TextBox
    Friend WithEvents Label4 As Label
End Class
