<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_SuperIntendentFinishing
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.TXT_FullQtyStartPC = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.TXT_FullOtherSpecify = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.TXT_FullGlueBottle = New System.Windows.Forms.TextBox()
        Me.RgrpmbR000TableAdapter1 = New barcode._PI_SP_AppDataSetTableAdapters.RGRPMBR000TableAdapter()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ResrC000TableAdapter1 = New barcode._PI_SP_AppDataSetTableAdapters.RESRC000TableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_QNR = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_NCR = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_Nonconformity = New System.Windows.Forms.TextBox()
        Me.CHK_Resorting = New System.Windows.Forms.CheckBox()
        Me.CHK_StrippingE = New System.Windows.Forms.CheckBox()
        Me.CHK_StrippingD = New System.Windows.Forms.CheckBox()
        Me.CHK_StrippingC = New System.Windows.Forms.CheckBox()
        Me.CHK_StrippingB = New System.Windows.Forms.CheckBox()
        Me.CHK_StrippingA = New System.Windows.Forms.CheckBox()
        Me.CHK_Stripping = New System.Windows.Forms.CheckBox()
        Me.CHK_LaminaB = New System.Windows.Forms.CheckBox()
        Me.CHK_LaminaA = New System.Windows.Forms.CheckBox()
        Me.CHK_Expertfold110 = New System.Windows.Forms.CheckBox()
        Me.CHK_Sun850 = New System.Windows.Forms.CheckBox()
        Me.CHK_Sun1300 = New System.Windows.Forms.CheckBox()
        Me.CHK_Mouse650 = New System.Windows.Forms.CheckBox()
        Me.CHK_Expertfold80 = New System.Windows.Forms.CheckBox()
        Me.CHK_Media68 = New System.Windows.Forms.CheckBox()
        Me.CHK_Ambition50 = New System.Windows.Forms.CheckBox()
        Me.CHK_Gluing = New System.Windows.Forms.CheckBox()
        Me.RBT_ManualFinishing = New System.Windows.Forms.RichTextBox()
        Me.CHK_ManualFinising = New System.Windows.Forms.CheckBox()
        Me.CHK_FinishedGoods = New System.Windows.Forms.CheckBox()
        Me.TXT_FullWP = New System.Windows.Forms.TextBox()
        Me.CHK_WP = New System.Windows.Forms.CheckBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.CHK_FullPalletTag = New System.Windows.Forms.CheckBox()
        Me.CHK_FullCutLabel = New System.Windows.Forms.CheckBox()
        Me.CHK_GoodEquipments = New System.Windows.Forms.CheckBox()
        Me.TXT_FullRagsQty = New System.Windows.Forms.TextBox()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.TXT_FullBallpenQty = New System.Windows.Forms.TextBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.CHK_GoodCleaingMaterials = New System.Windows.Forms.CheckBox()
        Me.CHk_GoodWearsProperlyTuckedIn = New System.Windows.Forms.CheckBox()
        Me.CHK_GoodWearHairCover = New System.Windows.Forms.CheckBox()
        Me.CHk_GoodHandWashed = New System.Windows.Forms.CheckBox()
        Me.CHK_GoodWith20WallClearance = New System.Windows.Forms.CheckBox()
        Me.CHk_GoodInPlasticPallets = New System.Windows.Forms.CheckBox()
        Me.CHK_GoodProperlyTagged = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CHK_GoodWeighingScale = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CHK_GoodBundlingMachine = New System.Windows.Forms.CheckBox()
        Me.CHK_GoodJSortingTable = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CHK_GoodForeignMaterials = New System.Windows.Forms.CheckBox()
        Me.CHK_GoodExcessiveDust = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CHK_FullCorrugatedBox = New System.Windows.Forms.CheckBox()
        Me.CHK_FullKraftPaper = New System.Windows.Forms.CheckBox()
        Me.CHK_FullSticker = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CHK_FullWorkingTable = New System.Windows.Forms.CheckBox()
        Me.CHK_FullChairs = New System.Windows.Forms.CheckBox()
        Me.CHK_FullWasteBinss = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_VerifiedSuperIntendent = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TXT_Supervisor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BTN_VerifySupervisor = New System.Windows.Forms.Button()
        Me.BTN_Back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(1194, 274)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(126, 18)
        Me.Label55.TabIndex = 2052
        Me.Label55.Text = "quantity start (pc)"
        '
        'TXT_FullQtyStartPC
        '
        Me.TXT_FullQtyStartPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_FullQtyStartPC.Location = New System.Drawing.Point(1321, 273)
        Me.TXT_FullQtyStartPC.Name = "TXT_FullQtyStartPC"
        Me.TXT_FullQtyStartPC.Size = New System.Drawing.Size(56, 22)
        Me.TXT_FullQtyStartPC.TabIndex = 2051
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(978, 274)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(117, 18)
        Me.Label54.TabIndex = 2050
        Me.Label54.Text = "Others (specify)"
        '
        'TXT_FullOtherSpecify
        '
        Me.TXT_FullOtherSpecify.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_FullOtherSpecify.Location = New System.Drawing.Point(1097, 272)
        Me.TXT_FullOtherSpecify.Name = "TXT_FullOtherSpecify"
        Me.TXT_FullOtherSpecify.Size = New System.Drawing.Size(56, 22)
        Me.TXT_FullOtherSpecify.TabIndex = 2049
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(732, 274)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(140, 18)
        Me.Label53.TabIndex = 2048
        Me.Label53.Text = "Glue bottle qty start"
        '
        'TXT_FullGlueBottle
        '
        Me.TXT_FullGlueBottle.AcceptsReturn = True
        Me.TXT_FullGlueBottle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_FullGlueBottle.Location = New System.Drawing.Point(878, 272)
        Me.TXT_FullGlueBottle.Name = "TXT_FullGlueBottle"
        Me.TXT_FullGlueBottle.Size = New System.Drawing.Size(56, 22)
        Me.TXT_FullGlueBottle.TabIndex = 2047
        '
        'RgrpmbR000TableAdapter1
        '
        Me.RgrpmbR000TableAdapter1.ClearBeforeFill = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ResrC000TableAdapter1
        '
        Me.ResrC000TableAdapter1.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1329, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 18)
        Me.Label6.TabIndex = 1923
        Me.Label6.Text = "QNR#"
        '
        'TXT_QNR
        '
        Me.TXT_QNR.Location = New System.Drawing.Point(1446, 110)
        Me.TXT_QNR.Name = "TXT_QNR"
        Me.TXT_QNR.Size = New System.Drawing.Size(123, 20)
        Me.TXT_QNR.TabIndex = 1922
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1329, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 18)
        Me.Label5.TabIndex = 1921
        Me.Label5.Text = "NCR#:"
        '
        'TXT_NCR
        '
        Me.TXT_NCR.Location = New System.Drawing.Point(1446, 84)
        Me.TXT_NCR.Name = "TXT_NCR"
        Me.TXT_NCR.Size = New System.Drawing.Size(123, 20)
        Me.TXT_NCR.TabIndex = 1920
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1329, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 18)
        Me.Label4.TabIndex = 1919
        Me.Label4.Text = "Nonconformity:"
        '
        'TXT_Nonconformity
        '
        Me.TXT_Nonconformity.Location = New System.Drawing.Point(1446, 58)
        Me.TXT_Nonconformity.Name = "TXT_Nonconformity"
        Me.TXT_Nonconformity.Size = New System.Drawing.Size(123, 20)
        Me.TXT_Nonconformity.TabIndex = 1918
        '
        'CHK_Resorting
        '
        Me.CHK_Resorting.AutoSize = True
        Me.CHK_Resorting.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_Resorting.Location = New System.Drawing.Point(1321, 34)
        Me.CHK_Resorting.Name = "CHK_Resorting"
        Me.CHK_Resorting.Size = New System.Drawing.Size(109, 23)
        Me.CHK_Resorting.TabIndex = 1917
        Me.CHK_Resorting.Text = "Resorting:"
        Me.CHK_Resorting.UseVisualStyleBackColor = True
        '
        'CHK_StrippingE
        '
        Me.CHK_StrippingE.AutoSize = True
        Me.CHK_StrippingE.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_StrippingE.Location = New System.Drawing.Point(1153, 85)
        Me.CHK_StrippingE.Name = "CHK_StrippingE"
        Me.CHK_StrippingE.Size = New System.Drawing.Size(105, 22)
        Me.CHK_StrippingE.TabIndex = 1916
        Me.CHK_StrippingE.Text = "Stripping E"
        Me.CHK_StrippingE.UseVisualStyleBackColor = True
        '
        'CHK_StrippingD
        '
        Me.CHK_StrippingD.AutoSize = True
        Me.CHK_StrippingD.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_StrippingD.Location = New System.Drawing.Point(1153, 62)
        Me.CHK_StrippingD.Name = "CHK_StrippingD"
        Me.CHK_StrippingD.Size = New System.Drawing.Size(106, 22)
        Me.CHK_StrippingD.TabIndex = 1915
        Me.CHK_StrippingD.Text = "Stripping D"
        Me.CHK_StrippingD.UseVisualStyleBackColor = True
        '
        'CHK_StrippingC
        '
        Me.CHK_StrippingC.AutoSize = True
        Me.CHK_StrippingC.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_StrippingC.Location = New System.Drawing.Point(1038, 108)
        Me.CHK_StrippingC.Name = "CHK_StrippingC"
        Me.CHK_StrippingC.Size = New System.Drawing.Size(106, 22)
        Me.CHK_StrippingC.TabIndex = 1914
        Me.CHK_StrippingC.Text = "Stripping C"
        Me.CHK_StrippingC.UseVisualStyleBackColor = True
        '
        'CHK_StrippingB
        '
        Me.CHK_StrippingB.AutoSize = True
        Me.CHK_StrippingB.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_StrippingB.Location = New System.Drawing.Point(1038, 85)
        Me.CHK_StrippingB.Name = "CHK_StrippingB"
        Me.CHK_StrippingB.Size = New System.Drawing.Size(105, 22)
        Me.CHK_StrippingB.TabIndex = 1913
        Me.CHK_StrippingB.Text = "Stripping B"
        Me.CHK_StrippingB.UseVisualStyleBackColor = True
        '
        'CHK_StrippingA
        '
        Me.CHK_StrippingA.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.CHK_StrippingA.AutoSize = True
        Me.CHK_StrippingA.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_StrippingA.Location = New System.Drawing.Point(1038, 62)
        Me.CHK_StrippingA.Name = "CHK_StrippingA"
        Me.CHK_StrippingA.Size = New System.Drawing.Size(104, 22)
        Me.CHK_StrippingA.TabIndex = 1912
        Me.CHK_StrippingA.Text = "Stripping A"
        Me.CHK_StrippingA.UseVisualStyleBackColor = True
        '
        'CHK_Stripping
        '
        Me.CHK_Stripping.AutoSize = True
        Me.CHK_Stripping.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_Stripping.Location = New System.Drawing.Point(1020, 34)
        Me.CHK_Stripping.Name = "CHK_Stripping"
        Me.CHK_Stripping.Size = New System.Drawing.Size(98, 23)
        Me.CHK_Stripping.TabIndex = 1911
        Me.CHK_Stripping.Text = "Stripping"
        Me.CHK_Stripping.UseVisualStyleBackColor = True
        '
        'CHK_LaminaB
        '
        Me.CHK_LaminaB.AutoSize = True
        Me.CHK_LaminaB.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_LaminaB.Location = New System.Drawing.Point(796, 106)
        Me.CHK_LaminaB.Name = "CHK_LaminaB"
        Me.CHK_LaminaB.Size = New System.Drawing.Size(94, 22)
        Me.CHK_LaminaB.TabIndex = 1910
        Me.CHK_LaminaB.Text = "Lamina B"
        Me.CHK_LaminaB.UseVisualStyleBackColor = True
        '
        'CHK_LaminaA
        '
        Me.CHK_LaminaA.AutoSize = True
        Me.CHK_LaminaA.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_LaminaA.Location = New System.Drawing.Point(796, 81)
        Me.CHK_LaminaA.Name = "CHK_LaminaA"
        Me.CHK_LaminaA.Size = New System.Drawing.Size(93, 22)
        Me.CHK_LaminaA.TabIndex = 1909
        Me.CHK_LaminaA.Text = "Lamina A"
        Me.CHK_LaminaA.UseVisualStyleBackColor = True
        '
        'CHK_Expertfold110
        '
        Me.CHK_Expertfold110.AutoSize = True
        Me.CHK_Expertfold110.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_Expertfold110.Location = New System.Drawing.Point(796, 58)
        Me.CHK_Expertfold110.Name = "CHK_Expertfold110"
        Me.CHK_Expertfold110.Size = New System.Drawing.Size(127, 22)
        Me.CHK_Expertfold110.TabIndex = 1908
        Me.CHK_Expertfold110.Text = "Expertfold 110"
        Me.CHK_Expertfold110.UseVisualStyleBackColor = True
        '
        'CHK_Sun850
        '
        Me.CHK_Sun850.AutoSize = True
        Me.CHK_Sun850.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_Sun850.Location = New System.Drawing.Point(685, 106)
        Me.CHK_Sun850.Name = "CHK_Sun850"
        Me.CHK_Sun850.Size = New System.Drawing.Size(85, 22)
        Me.CHK_Sun850.TabIndex = 1907
        Me.CHK_Sun850.Text = "Sun 850"
        Me.CHK_Sun850.UseVisualStyleBackColor = True
        '
        'CHK_Sun1300
        '
        Me.CHK_Sun1300.AutoSize = True
        Me.CHK_Sun1300.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_Sun1300.Location = New System.Drawing.Point(685, 81)
        Me.CHK_Sun1300.Name = "CHK_Sun1300"
        Me.CHK_Sun1300.Size = New System.Drawing.Size(94, 22)
        Me.CHK_Sun1300.TabIndex = 1906
        Me.CHK_Sun1300.Text = "Sun 1300"
        Me.CHK_Sun1300.UseVisualStyleBackColor = True
        '
        'CHK_Mouse650
        '
        Me.CHK_Mouse650.AutoSize = True
        Me.CHK_Mouse650.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_Mouse650.Location = New System.Drawing.Point(685, 58)
        Me.CHK_Mouse650.Name = "CHK_Mouse650"
        Me.CHK_Mouse650.Size = New System.Drawing.Size(105, 22)
        Me.CHK_Mouse650.TabIndex = 1905
        Me.CHK_Mouse650.Text = "Mouse 650"
        Me.CHK_Mouse650.UseVisualStyleBackColor = True
        '
        'CHK_Expertfold80
        '
        Me.CHK_Expertfold80.AutoSize = True
        Me.CHK_Expertfold80.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_Expertfold80.Location = New System.Drawing.Point(564, 104)
        Me.CHK_Expertfold80.Name = "CHK_Expertfold80"
        Me.CHK_Expertfold80.Size = New System.Drawing.Size(119, 22)
        Me.CHK_Expertfold80.TabIndex = 1904
        Me.CHK_Expertfold80.Text = "Expertfold 80"
        Me.CHK_Expertfold80.UseVisualStyleBackColor = True
        '
        'CHK_Media68
        '
        Me.CHK_Media68.AutoSize = True
        Me.CHK_Media68.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_Media68.Location = New System.Drawing.Point(564, 79)
        Me.CHK_Media68.Name = "CHK_Media68"
        Me.CHK_Media68.Size = New System.Drawing.Size(93, 22)
        Me.CHK_Media68.TabIndex = 1903
        Me.CHK_Media68.Text = "Media 68"
        Me.CHK_Media68.UseVisualStyleBackColor = True
        '
        'CHK_Ambition50
        '
        Me.CHK_Ambition50.AutoSize = True
        Me.CHK_Ambition50.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_Ambition50.Location = New System.Drawing.Point(564, 56)
        Me.CHK_Ambition50.Name = "CHK_Ambition50"
        Me.CHK_Ambition50.Size = New System.Drawing.Size(111, 22)
        Me.CHK_Ambition50.TabIndex = 1902
        Me.CHK_Ambition50.Text = "Ambition 50"
        Me.CHK_Ambition50.UseVisualStyleBackColor = True
        '
        'CHK_Gluing
        '
        Me.CHK_Gluing.AutoSize = True
        Me.CHK_Gluing.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_Gluing.Location = New System.Drawing.Point(564, 34)
        Me.CHK_Gluing.Name = "CHK_Gluing"
        Me.CHK_Gluing.Size = New System.Drawing.Size(78, 23)
        Me.CHK_Gluing.TabIndex = 1901
        Me.CHK_Gluing.Text = "Gluing"
        Me.CHK_Gluing.UseVisualStyleBackColor = True
        '
        'RBT_ManualFinishing
        '
        Me.RBT_ManualFinishing.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBT_ManualFinishing.Location = New System.Drawing.Point(319, 62)
        Me.RBT_ManualFinishing.Name = "RBT_ManualFinishing"
        Me.RBT_ManualFinishing.Size = New System.Drawing.Size(153, 65)
        Me.RBT_ManualFinishing.TabIndex = 1900
        Me.RBT_ManualFinishing.Text = ""
        '
        'CHK_ManualFinising
        '
        Me.CHK_ManualFinising.AutoSize = True
        Me.CHK_ManualFinising.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_ManualFinising.Location = New System.Drawing.Point(319, 34)
        Me.CHK_ManualFinising.Name = "CHK_ManualFinising"
        Me.CHK_ManualFinising.Size = New System.Drawing.Size(158, 23)
        Me.CHK_ManualFinising.TabIndex = 1899
        Me.CHK_ManualFinising.Text = "Manual Finishing"
        Me.CHK_ManualFinising.UseVisualStyleBackColor = True
        '
        'CHK_FinishedGoods
        '
        Me.CHK_FinishedGoods.AutoSize = True
        Me.CHK_FinishedGoods.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_FinishedGoods.Location = New System.Drawing.Point(98, 66)
        Me.CHK_FinishedGoods.Name = "CHK_FinishedGoods"
        Me.CHK_FinishedGoods.Size = New System.Drawing.Size(138, 22)
        Me.CHK_FinishedGoods.TabIndex = 1898
        Me.CHK_FinishedGoods.Text = "Finished Goods"
        Me.CHK_FinishedGoods.UseVisualStyleBackColor = True
        '
        'TXT_FullWP
        '
        Me.TXT_FullWP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_FullWP.Location = New System.Drawing.Point(149, 40)
        Me.TXT_FullWP.Name = "TXT_FullWP"
        Me.TXT_FullWP.Size = New System.Drawing.Size(123, 22)
        Me.TXT_FullWP.TabIndex = 1897
        '
        'CHK_WP
        '
        Me.CHK_WP.AutoSize = True
        Me.CHK_WP.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_WP.Location = New System.Drawing.Point(98, 40)
        Me.CHK_WP.Name = "CHK_WP"
        Me.CHK_WP.Size = New System.Drawing.Size(57, 22)
        Me.CHK_WP.TabIndex = 1896
        Me.CHK_WP.Text = "WP:"
        Me.CHK_WP.UseVisualStyleBackColor = True
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(442, 273)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(163, 18)
        Me.Label52.TabIndex = 1889
        Me.Label52.Text = "Ragsquantity start (pc)"
        '
        'CHK_FullPalletTag
        '
        Me.CHK_FullPalletTag.AutoSize = True
        Me.CHK_FullPalletTag.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_FullPalletTag.Location = New System.Drawing.Point(890, 230)
        Me.CHK_FullPalletTag.Name = "CHK_FullPalletTag"
        Me.CHK_FullPalletTag.Size = New System.Drawing.Size(92, 22)
        Me.CHK_FullPalletTag.TabIndex = 1888
        Me.CHK_FullPalletTag.Text = "Pallet tag"
        Me.CHK_FullPalletTag.UseVisualStyleBackColor = True
        '
        'CHK_FullCutLabel
        '
        Me.CHK_FullCutLabel.AutoSize = True
        Me.CHK_FullCutLabel.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_FullCutLabel.Location = New System.Drawing.Point(692, 230)
        Me.CHK_FullCutLabel.Name = "CHK_FullCutLabel"
        Me.CHK_FullCutLabel.Size = New System.Drawing.Size(88, 22)
        Me.CHK_FullCutLabel.TabIndex = 1887
        Me.CHK_FullCutLabel.Text = "Cut label"
        Me.CHK_FullCutLabel.UseVisualStyleBackColor = True
        '
        'CHK_GoodEquipments
        '
        Me.CHK_GoodEquipments.AutoSize = True
        Me.CHK_GoodEquipments.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_GoodEquipments.Location = New System.Drawing.Point(692, 407)
        Me.CHK_GoodEquipments.Name = "CHK_GoodEquipments"
        Me.CHK_GoodEquipments.Size = New System.Drawing.Size(113, 22)
        Me.CHK_GoodEquipments.TabIndex = 1886
        Me.CHK_GoodEquipments.Text = "Equipment's"
        Me.CHK_GoodEquipments.UseVisualStyleBackColor = True
        '
        'TXT_FullRagsQty
        '
        Me.TXT_FullRagsQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_FullRagsQty.Location = New System.Drawing.Point(617, 271)
        Me.TXT_FullRagsQty.Name = "TXT_FullRagsQty"
        Me.TXT_FullRagsQty.Size = New System.Drawing.Size(56, 22)
        Me.TXT_FullRagsQty.TabIndex = 1885
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(145, 270)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(182, 18)
        Me.Label82.TabIndex = 1884
        Me.Label82.Text = "Ballpen quantity start (pc)"
        '
        'TXT_FullBallpenQty
        '
        Me.TXT_FullBallpenQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_FullBallpenQty.Location = New System.Drawing.Point(333, 271)
        Me.TXT_FullBallpenQty.Name = "TXT_FullBallpenQty"
        Me.TXT_FullBallpenQty.Size = New System.Drawing.Size(56, 22)
        Me.TXT_FullBallpenQty.TabIndex = 1883
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.Location = New System.Drawing.Point(124, 247)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(240, 18)
        Me.Label83.TabIndex = 1882
        Me.Label83.Text = "C. Operational Loose Item control"
        '
        'CHK_GoodCleaingMaterials
        '
        Me.CHK_GoodCleaingMaterials.AutoSize = True
        Me.CHK_GoodCleaingMaterials.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_GoodCleaingMaterials.Location = New System.Drawing.Point(499, 406)
        Me.CHK_GoodCleaingMaterials.Name = "CHK_GoodCleaingMaterials"
        Me.CHK_GoodCleaingMaterials.Size = New System.Drawing.Size(157, 22)
        Me.CHK_GoodCleaingMaterials.TabIndex = 1875
        Me.CHK_GoodCleaingMaterials.Text = "Cleaning materials"
        Me.CHK_GoodCleaingMaterials.UseVisualStyleBackColor = True
        '
        'CHk_GoodWearsProperlyTuckedIn
        '
        Me.CHk_GoodWearsProperlyTuckedIn.AutoSize = True
        Me.CHk_GoodWearsProperlyTuckedIn.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHk_GoodWearsProperlyTuckedIn.Location = New System.Drawing.Point(693, 387)
        Me.CHk_GoodWearsProperlyTuckedIn.Name = "CHk_GoodWearsProperlyTuckedIn"
        Me.CHk_GoodWearsProperlyTuckedIn.Size = New System.Drawing.Size(256, 22)
        Me.CHk_GoodWearsProperlyTuckedIn.TabIndex = 1874
        Me.CHk_GoodWearsProperlyTuckedIn.Text = "Wears Properly tucked in uniform"
        Me.CHk_GoodWearsProperlyTuckedIn.UseVisualStyleBackColor = True
        '
        'CHK_GoodWearHairCover
        '
        Me.CHK_GoodWearHairCover.AutoSize = True
        Me.CHK_GoodWearHairCover.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_GoodWearHairCover.Location = New System.Drawing.Point(500, 387)
        Me.CHK_GoodWearHairCover.Name = "CHK_GoodWearHairCover"
        Me.CHK_GoodWearHairCover.Size = New System.Drawing.Size(149, 22)
        Me.CHK_GoodWearHairCover.TabIndex = 1873
        Me.CHK_GoodWearHairCover.Text = "wears hair covers"
        Me.CHK_GoodWearHairCover.UseVisualStyleBackColor = True
        '
        'CHk_GoodHandWashed
        '
        Me.CHk_GoodHandWashed.AutoSize = True
        Me.CHk_GoodHandWashed.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHk_GoodHandWashed.Location = New System.Drawing.Point(1090, 389)
        Me.CHk_GoodHandWashed.Name = "CHk_GoodHandWashed"
        Me.CHk_GoodHandWashed.Size = New System.Drawing.Size(119, 22)
        Me.CHk_GoodHandWashed.TabIndex = 1872
        Me.CHk_GoodHandWashed.Text = "hand washed"
        Me.CHk_GoodHandWashed.UseVisualStyleBackColor = True
        '
        'CHK_GoodWith20WallClearance
        '
        Me.CHK_GoodWith20WallClearance.AutoSize = True
        Me.CHK_GoodWith20WallClearance.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_GoodWith20WallClearance.Location = New System.Drawing.Point(894, 369)
        Me.CHK_GoodWith20WallClearance.Name = "CHK_GoodWith20WallClearance"
        Me.CHK_GoodWith20WallClearance.Size = New System.Drawing.Size(178, 22)
        Me.CHK_GoodWith20WallClearance.TabIndex = 1871
        Me.CHK_GoodWith20WallClearance.Text = "with 20 wall clearance"
        Me.CHK_GoodWith20WallClearance.UseVisualStyleBackColor = True
        '
        'CHk_GoodInPlasticPallets
        '
        Me.CHk_GoodInPlasticPallets.AutoSize = True
        Me.CHk_GoodInPlasticPallets.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHk_GoodInPlasticPallets.Location = New System.Drawing.Point(693, 368)
        Me.CHk_GoodInPlasticPallets.Name = "CHk_GoodInPlasticPallets"
        Me.CHk_GoodInPlasticPallets.Size = New System.Drawing.Size(138, 22)
        Me.CHk_GoodInPlasticPallets.TabIndex = 1870
        Me.CHk_GoodInPlasticPallets.Text = "In Plastic pallets"
        Me.CHk_GoodInPlasticPallets.UseVisualStyleBackColor = True
        '
        'CHK_GoodProperlyTagged
        '
        Me.CHK_GoodProperlyTagged.AutoSize = True
        Me.CHK_GoodProperlyTagged.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_GoodProperlyTagged.Location = New System.Drawing.Point(500, 368)
        Me.CHK_GoodProperlyTagged.Name = "CHK_GoodProperlyTagged"
        Me.CHK_GoodProperlyTagged.Size = New System.Drawing.Size(136, 22)
        Me.CHK_GoodProperlyTagged.TabIndex = 1869
        Me.CHK_GoodProperlyTagged.Text = "properly tagged"
        Me.CHK_GoodProperlyTagged.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label18.Location = New System.Drawing.Point(118, 408)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(210, 18)
        Me.Label18.TabIndex = 1864
        Me.Label18.Text = "E. Safety - Proper storage of:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label17.Location = New System.Drawing.Point(118, 389)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(189, 18)
        Me.Label17.TabIndex = 1863
        Me.Label17.Text = "D. Hygine - Machine crew:"
        '
        'CHK_GoodWeighingScale
        '
        Me.CHK_GoodWeighingScale.AutoSize = True
        Me.CHK_GoodWeighingScale.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_GoodWeighingScale.Location = New System.Drawing.Point(894, 347)
        Me.CHK_GoodWeighingScale.Name = "CHK_GoodWeighingScale"
        Me.CHK_GoodWeighingScale.Size = New System.Drawing.Size(130, 22)
        Me.CHK_GoodWeighingScale.TabIndex = 1862
        Me.CHK_GoodWeighingScale.Text = "weighing scale"
        Me.CHK_GoodWeighingScale.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label16.Location = New System.Drawing.Point(117, 370)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(211, 18)
        Me.Label16.TabIndex = 1861
        Me.Label16.Text = "C. Preservation - Papers are:"
        '
        'CHK_GoodBundlingMachine
        '
        Me.CHK_GoodBundlingMachine.AutoSize = True
        Me.CHK_GoodBundlingMachine.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_GoodBundlingMachine.Location = New System.Drawing.Point(693, 347)
        Me.CHK_GoodBundlingMachine.Name = "CHK_GoodBundlingMachine"
        Me.CHK_GoodBundlingMachine.Size = New System.Drawing.Size(150, 22)
        Me.CHK_GoodBundlingMachine.TabIndex = 1860
        Me.CHK_GoodBundlingMachine.Text = "Bundling machine"
        Me.CHK_GoodBundlingMachine.UseVisualStyleBackColor = True
        '
        'CHK_GoodJSortingTable
        '
        Me.CHK_GoodJSortingTable.AutoSize = True
        Me.CHK_GoodJSortingTable.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_GoodJSortingTable.Location = New System.Drawing.Point(500, 347)
        Me.CHK_GoodJSortingTable.Name = "CHK_GoodJSortingTable"
        Me.CHK_GoodJSortingTable.Size = New System.Drawing.Size(115, 22)
        Me.CHK_GoodJSortingTable.TabIndex = 1859
        Me.CHK_GoodJSortingTable.Text = "Sorting table"
        Me.CHK_GoodJSortingTable.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(118, 347)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(267, 18)
        Me.Label13.TabIndex = 1858
        Me.Label13.Text = "B. Sanitation - Used Saniquat mix for:"
        '
        'CHK_GoodForeignMaterials
        '
        Me.CHK_GoodForeignMaterials.AutoSize = True
        Me.CHK_GoodForeignMaterials.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_GoodForeignMaterials.Location = New System.Drawing.Point(694, 327)
        Me.CHK_GoodForeignMaterials.Name = "CHK_GoodForeignMaterials"
        Me.CHK_GoodForeignMaterials.Size = New System.Drawing.Size(140, 22)
        Me.CHK_GoodForeignMaterials.TabIndex = 1857
        Me.CHK_GoodForeignMaterials.Text = "Forein materials"
        Me.CHK_GoodForeignMaterials.UseVisualStyleBackColor = True
        '
        'CHK_GoodExcessiveDust
        '
        Me.CHK_GoodExcessiveDust.AutoSize = True
        Me.CHK_GoodExcessiveDust.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_GoodExcessiveDust.Location = New System.Drawing.Point(500, 325)
        Me.CHK_GoodExcessiveDust.Name = "CHK_GoodExcessiveDust"
        Me.CHK_GoodExcessiveDust.Size = New System.Drawing.Size(194, 22)
        Me.CHK_GoodExcessiveDust.TabIndex = 1856
        Me.CHK_GoodExcessiveDust.Text = "Excessive dust, dirt, etc."
        Me.CHK_GoodExcessiveDust.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label14.Location = New System.Drawing.Point(119, 326)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(378, 18)
        Me.Label14.TabIndex = 1855
        Me.Label14.Text = "A. Housekeeping - Machine/work areas are free from:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(94, 303)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(283, 20)
        Me.Label15.TabIndex = 1854
        Me.Label15.Text = "2. GOOD MANUFACTURING PRACTICE"
        '
        'CHK_FullCorrugatedBox
        '
        Me.CHK_FullCorrugatedBox.AutoSize = True
        Me.CHK_FullCorrugatedBox.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_FullCorrugatedBox.Location = New System.Drawing.Point(490, 230)
        Me.CHK_FullCorrugatedBox.Name = "CHK_FullCorrugatedBox"
        Me.CHK_FullCorrugatedBox.Size = New System.Drawing.Size(135, 22)
        Me.CHK_FullCorrugatedBox.TabIndex = 1853
        Me.CHK_FullCorrugatedBox.Text = "Corrugated box"
        Me.CHK_FullCorrugatedBox.UseVisualStyleBackColor = True
        '
        'CHK_FullKraftPaper
        '
        Me.CHK_FullKraftPaper.AutoSize = True
        Me.CHK_FullKraftPaper.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_FullKraftPaper.Location = New System.Drawing.Point(326, 228)
        Me.CHK_FullKraftPaper.Name = "CHK_FullKraftPaper"
        Me.CHK_FullKraftPaper.Size = New System.Drawing.Size(105, 22)
        Me.CHK_FullKraftPaper.TabIndex = 1852
        Me.CHK_FullKraftPaper.Text = "Kraft paper"
        Me.CHK_FullKraftPaper.UseVisualStyleBackColor = True
        '
        'CHK_FullSticker
        '
        Me.CHK_FullSticker.AutoSize = True
        Me.CHK_FullSticker.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_FullSticker.Location = New System.Drawing.Point(146, 229)
        Me.CHK_FullSticker.Name = "CHK_FullSticker"
        Me.CHK_FullSticker.Size = New System.Drawing.Size(76, 22)
        Me.CHK_FullSticker.TabIndex = 1851
        Me.CHK_FullSticker.Text = "Sticker"
        Me.CHK_FullSticker.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(124, 208)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(563, 18)
        Me.Label12.TabIndex = 1850
        Me.Label12.Text = "B. Machine/work area is clear from materials that will not be used for the next j" &
    "ob:"
        '
        'CHK_FullWorkingTable
        '
        Me.CHK_FullWorkingTable.AutoSize = True
        Me.CHK_FullWorkingTable.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_FullWorkingTable.Location = New System.Drawing.Point(490, 186)
        Me.CHK_FullWorkingTable.Name = "CHK_FullWorkingTable"
        Me.CHK_FullWorkingTable.Size = New System.Drawing.Size(123, 22)
        Me.CHK_FullWorkingTable.TabIndex = 1849
        Me.CHK_FullWorkingTable.Text = "Working table"
        Me.CHK_FullWorkingTable.UseVisualStyleBackColor = True
        '
        'CHK_FullChairs
        '
        Me.CHK_FullChairs.AutoSize = True
        Me.CHK_FullChairs.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_FullChairs.Location = New System.Drawing.Point(326, 186)
        Me.CHK_FullChairs.Name = "CHK_FullChairs"
        Me.CHK_FullChairs.Size = New System.Drawing.Size(73, 22)
        Me.CHK_FullChairs.TabIndex = 1848
        Me.CHK_FullChairs.Text = "Chairs"
        Me.CHK_FullChairs.UseVisualStyleBackColor = True
        '
        'CHK_FullWasteBinss
        '
        Me.CHK_FullWasteBinss.AutoSize = True
        Me.CHK_FullWasteBinss.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CHK_FullWasteBinss.Location = New System.Drawing.Point(146, 188)
        Me.CHK_FullWasteBinss.Name = "CHK_FullWasteBinss"
        Me.CHK_FullWasteBinss.Size = New System.Drawing.Size(104, 22)
        Me.CHK_FullWasteBinss.TabIndex = 1847
        Me.CHK_FullWasteBinss.Text = "Waste bins"
        Me.CHK_FullWasteBinss.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(124, 167)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(736, 18)
        Me.Label11.TabIndex = 1846
        Me.Label11.Text = "A. Machine/work area is clear from stocks/printed sheets (good, spoilages and red" &
    "-tag) from previous job:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(94, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(193, 20)
        Me.Label10.TabIndex = 1845
        Me.Label10.Text = "1. FULL LINE CLEARANCE"
        '
        'TXT_VerifiedSuperIntendent
        '
        Me.TXT_VerifiedSuperIntendent.Enabled = False
        Me.TXT_VerifiedSuperIntendent.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_VerifiedSuperIntendent.Location = New System.Drawing.Point(1388, 471)
        Me.TXT_VerifiedSuperIntendent.Name = "TXT_VerifiedSuperIntendent"
        Me.TXT_VerifiedSuperIntendent.Size = New System.Drawing.Size(332, 38)
        Me.TXT_VerifiedSuperIntendent.TabIndex = 2057
        Me.TXT_VerifiedSuperIntendent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(1144, 479)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(222, 20)
        Me.Label20.TabIndex = 2056
        Me.Label20.Text = "Verified  by (Superintendent)"
        '
        'TXT_Supervisor
        '
        Me.TXT_Supervisor.Enabled = False
        Me.TXT_Supervisor.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Supervisor.Location = New System.Drawing.Point(258, 471)
        Me.TXT_Supervisor.Name = "TXT_Supervisor"
        Me.TXT_Supervisor.Size = New System.Drawing.Size(332, 35)
        Me.TXT_Supervisor.TabIndex = 2055
        Me.TXT_Supervisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(366, 509)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 2054
        Me.Label1.Text = "Supervisor"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(120, 482)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(128, 20)
        Me.Label19.TabIndex = 2053
        Me.Label19.Text = "CONDUCTED BY:"
        '
        'BTN_VerifySupervisor
        '
        Me.BTN_VerifySupervisor.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTN_VerifySupervisor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_VerifySupervisor.ForeColor = System.Drawing.Color.White
        Me.BTN_VerifySupervisor.Location = New System.Drawing.Point(1462, 515)
        Me.BTN_VerifySupervisor.Name = "BTN_VerifySupervisor"
        Me.BTN_VerifySupervisor.Size = New System.Drawing.Size(189, 44)
        Me.BTN_VerifySupervisor.TabIndex = 2058
        Me.BTN_VerifySupervisor.Text = "VERIFY"
        Me.BTN_VerifySupervisor.UseVisualStyleBackColor = False
        '
        'BTN_Back
        '
        Me.BTN_Back.BackColor = System.Drawing.Color.Transparent
        Me.BTN_Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Back.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.BTN_Back.ForeColor = System.Drawing.SystemColors.Highlight
        Me.BTN_Back.Location = New System.Drawing.Point(98, 712)
        Me.BTN_Back.Name = "BTN_Back"
        Me.BTN_Back.Size = New System.Drawing.Size(191, 46)
        Me.BTN_Back.TabIndex = 2059
        Me.BTN_Back.Text = "Back"
        Me.BTN_Back.UseVisualStyleBackColor = False
        '
        'UC_SuperIntendentFinishing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BTN_Back)
        Me.Controls.Add(Me.BTN_VerifySupervisor)
        Me.Controls.Add(Me.TXT_VerifiedSuperIntendent)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TXT_Supervisor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.TXT_FullQtyStartPC)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.TXT_FullOtherSpecify)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.TXT_FullGlueBottle)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXT_QNR)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_NCR)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_Nonconformity)
        Me.Controls.Add(Me.CHK_Resorting)
        Me.Controls.Add(Me.CHK_StrippingE)
        Me.Controls.Add(Me.CHK_StrippingD)
        Me.Controls.Add(Me.CHK_StrippingC)
        Me.Controls.Add(Me.CHK_StrippingB)
        Me.Controls.Add(Me.CHK_StrippingA)
        Me.Controls.Add(Me.CHK_Stripping)
        Me.Controls.Add(Me.CHK_LaminaB)
        Me.Controls.Add(Me.CHK_LaminaA)
        Me.Controls.Add(Me.CHK_Expertfold110)
        Me.Controls.Add(Me.CHK_Sun850)
        Me.Controls.Add(Me.CHK_Sun1300)
        Me.Controls.Add(Me.CHK_Mouse650)
        Me.Controls.Add(Me.CHK_Expertfold80)
        Me.Controls.Add(Me.CHK_Media68)
        Me.Controls.Add(Me.CHK_Ambition50)
        Me.Controls.Add(Me.CHK_Gluing)
        Me.Controls.Add(Me.RBT_ManualFinishing)
        Me.Controls.Add(Me.CHK_ManualFinising)
        Me.Controls.Add(Me.CHK_FinishedGoods)
        Me.Controls.Add(Me.TXT_FullWP)
        Me.Controls.Add(Me.CHK_WP)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.CHK_FullPalletTag)
        Me.Controls.Add(Me.CHK_FullCutLabel)
        Me.Controls.Add(Me.CHK_GoodEquipments)
        Me.Controls.Add(Me.TXT_FullRagsQty)
        Me.Controls.Add(Me.Label82)
        Me.Controls.Add(Me.TXT_FullBallpenQty)
        Me.Controls.Add(Me.Label83)
        Me.Controls.Add(Me.CHK_GoodCleaingMaterials)
        Me.Controls.Add(Me.CHk_GoodWearsProperlyTuckedIn)
        Me.Controls.Add(Me.CHK_GoodWearHairCover)
        Me.Controls.Add(Me.CHk_GoodHandWashed)
        Me.Controls.Add(Me.CHK_GoodWith20WallClearance)
        Me.Controls.Add(Me.CHk_GoodInPlasticPallets)
        Me.Controls.Add(Me.CHK_GoodProperlyTagged)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.CHK_GoodWeighingScale)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CHK_GoodBundlingMachine)
        Me.Controls.Add(Me.CHK_GoodJSortingTable)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.CHK_GoodForeignMaterials)
        Me.Controls.Add(Me.CHK_GoodExcessiveDust)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.CHK_FullCorrugatedBox)
        Me.Controls.Add(Me.CHK_FullKraftPaper)
        Me.Controls.Add(Me.CHK_FullSticker)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CHK_FullWorkingTable)
        Me.Controls.Add(Me.CHK_FullChairs)
        Me.Controls.Add(Me.CHK_FullWasteBinss)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Name = "UC_SuperIntendentFinishing"
        Me.Size = New System.Drawing.Size(1840, 840)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label55 As Label
    Friend WithEvents TXT_FullQtyStartPC As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents TXT_FullOtherSpecify As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents TXT_FullGlueBottle As TextBox
    Friend WithEvents RgrpmbR000TableAdapter1 As _PI_SP_AppDataSetTableAdapters.RGRPMBR000TableAdapter
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ResrC000TableAdapter1 As _PI_SP_AppDataSetTableAdapters.RESRC000TableAdapter
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_QNR As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_NCR As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_Nonconformity As TextBox
    Friend WithEvents CHK_Resorting As CheckBox
    Friend WithEvents CHK_StrippingE As CheckBox
    Friend WithEvents CHK_StrippingD As CheckBox
    Friend WithEvents CHK_StrippingC As CheckBox
    Friend WithEvents CHK_StrippingB As CheckBox
    Friend WithEvents CHK_StrippingA As CheckBox
    Friend WithEvents CHK_Stripping As CheckBox
    Friend WithEvents CHK_LaminaB As CheckBox
    Friend WithEvents CHK_LaminaA As CheckBox
    Friend WithEvents CHK_Expertfold110 As CheckBox
    Friend WithEvents CHK_Sun850 As CheckBox
    Friend WithEvents CHK_Sun1300 As CheckBox
    Friend WithEvents CHK_Mouse650 As CheckBox
    Friend WithEvents CHK_Expertfold80 As CheckBox
    Friend WithEvents CHK_Media68 As CheckBox
    Friend WithEvents CHK_Ambition50 As CheckBox
    Friend WithEvents CHK_Gluing As CheckBox
    Friend WithEvents RBT_ManualFinishing As RichTextBox
    Friend WithEvents CHK_ManualFinising As CheckBox
    Friend WithEvents CHK_FinishedGoods As CheckBox
    Friend WithEvents TXT_FullWP As TextBox
    Friend WithEvents CHK_WP As CheckBox
    Friend WithEvents Label52 As Label
    Friend WithEvents CHK_FullPalletTag As CheckBox
    Friend WithEvents CHK_FullCutLabel As CheckBox
    Friend WithEvents CHK_GoodEquipments As CheckBox
    Friend WithEvents TXT_FullRagsQty As TextBox
    Friend WithEvents Label82 As Label
    Friend WithEvents TXT_FullBallpenQty As TextBox
    Friend WithEvents Label83 As Label
    Friend WithEvents CHK_GoodCleaingMaterials As CheckBox
    Friend WithEvents CHk_GoodWearsProperlyTuckedIn As CheckBox
    Friend WithEvents CHK_GoodWearHairCover As CheckBox
    Friend WithEvents CHk_GoodHandWashed As CheckBox
    Friend WithEvents CHK_GoodWith20WallClearance As CheckBox
    Friend WithEvents CHk_GoodInPlasticPallets As CheckBox
    Friend WithEvents CHK_GoodProperlyTagged As CheckBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents CHK_GoodWeighingScale As CheckBox
    Friend WithEvents Label16 As Label
    Friend WithEvents CHK_GoodBundlingMachine As CheckBox
    Friend WithEvents CHK_GoodJSortingTable As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents CHK_GoodForeignMaterials As CheckBox
    Friend WithEvents CHK_GoodExcessiveDust As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents CHK_FullCorrugatedBox As CheckBox
    Friend WithEvents CHK_FullKraftPaper As CheckBox
    Friend WithEvents CHK_FullSticker As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CHK_FullWorkingTable As CheckBox
    Friend WithEvents CHK_FullChairs As CheckBox
    Friend WithEvents CHK_FullWasteBinss As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TXT_VerifiedSuperIntendent As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TXT_Supervisor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents BTN_VerifySupervisor As Button
    Friend WithEvents BTN_Back As Button
End Class
