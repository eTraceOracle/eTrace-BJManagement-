<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits eTraceUI.eTraceForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim TimerStatus1 As eTraceUI.TimerStatus = New eTraceUI.TimerStatus
        Me.pnlBody = New eTraceUI.eTracePanel
        Me.ETracePanel5 = New eTraceUI.eTracePanel
        Me.grpHeader = New eTraceUI.eTraceGroupBox
        Me.dgvHeader = New eTraceUI.eTraceDataGridView
        Me.ETracePanel1 = New eTraceUI.eTracePanel
        Me.grpItem = New eTraceUI.eTraceGroupBox
        Me.dgvItem = New eTraceUI.eTraceDataGridView
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProcessCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Usage = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReqQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SupplyType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grpActions = New eTraceUI.eTraceGroupBox
        Me.tblActions = New eTraceUI.eTraceTableLayoutPanel
        Me.btnSave = New eTraceUI.eTraceButton
        Me.btnClear = New eTraceUI.eTraceButton
        Me.btnExcel = New eTraceUI.eTraceButton
        Me.btnMO = New eTraceUI.eTraceButton
        Me.grpInput = New eTraceUI.eTraceGroupBox
        Me.tblInput = New eTraceUI.eTraceTableLayoutPanel
        Me.lblDJ = New eTraceUI.eTraceLabel
        Me.txtDJ = New eTraceUI.eTraceTextBox
        Me.btnShow = New eTraceUI.eTraceButton
        Me.btnCreate = New eTraceUI.eTraceButton
        Me.cbxOnlyOpen = New eTraceUI.eTraceCheckBox
        Me.bgwSave = New System.ComponentModel.BackgroundWorker
        Me.bgwCreateBJ = New System.ComponentModel.BackgroundWorker
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.OpenExcelFile = New System.Windows.Forms.OpenFileDialog
        Me.bgwUpload = New System.ComponentModel.BackgroundWorker
        Me.bgwShow = New System.ComponentModel.BackgroundWorker
        Me.bgwExcelDownload = New System.ComponentModel.BackgroundWorker
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ETracePanel2 = New eTraceUI.eTracePanel
        Me.ETracePanel3 = New eTraceUI.eTracePanel
        Me.ETraceGroupBox1 = New eTraceUI.eTraceGroupBox
        Me.ETraceDataGridView1 = New eTraceUI.eTraceDataGridView
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ETracePanel4 = New eTraceUI.eTracePanel
        Me.ETraceGroupBox2 = New eTraceUI.eTraceGroupBox
        Me.ETraceDataGridView2 = New eTraceUI.eTraceDataGridView
        Me.Material = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ETraceGroupBox3 = New eTraceUI.eTraceGroupBox
        Me.ETraceTableLayoutPanel1 = New eTraceUI.eTraceTableLayoutPanel
        Me.ETraceButton1 = New eTraceUI.eTraceButton
        Me.ETraceButton2 = New eTraceUI.eTraceButton
        Me.ETraceButton3 = New eTraceUI.eTraceButton
        Me.ETraceGroupBox4 = New eTraceUI.eTraceGroupBox
        Me.ETraceTableLayoutPanel2 = New eTraceUI.eTraceTableLayoutPanel
        Me.ETraceButton4 = New eTraceUI.eTraceButton
        Me.ETraceLabel1 = New eTraceUI.eTraceLabel
        Me.bgwGenMO = New System.ComponentModel.BackgroundWorker
        Me.ProdLine = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DJ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TLA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BJ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BPA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BJQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CmpQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CurCmpQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Status = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.SchDate = New eTraceUI.eTraceDataGridView.CalendarColumn
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnlBody.SuspendLayout()
        Me.ETracePanel5.SuspendLayout()
        Me.grpHeader.SuspendLayout()
        CType(Me.dgvHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ETracePanel1.SuspendLayout()
        Me.grpItem.SuspendLayout()
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpActions.SuspendLayout()
        Me.tblActions.SuspendLayout()
        Me.grpInput.SuspendLayout()
        Me.tblInput.SuspendLayout()
        Me.ETracePanel2.SuspendLayout()
        Me.ETracePanel3.SuspendLayout()
        Me.ETraceGroupBox1.SuspendLayout()
        CType(Me.ETraceDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ETracePanel4.SuspendLayout()
        Me.ETraceGroupBox2.SuspendLayout()
        CType(Me.ETraceDataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ETraceGroupBox3.SuspendLayout()
        Me.ETraceTableLayoutPanel1.SuspendLayout()
        Me.ETraceTableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MessageBar1
        '
        Me.MessageBar1.Location = New System.Drawing.Point(0, 675)
        Me.MessageBar1.Size = New System.Drawing.Size(1028, 22)
        '
        'pnlBody
        '
        Me.pnlBody.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBody.Controls.Add(Me.ETracePanel5)
        Me.pnlBody.Controls.Add(Me.ETracePanel1)
        Me.pnlBody.Controls.Add(Me.grpActions)
        Me.pnlBody.Controls.Add(Me.grpInput)
        Me.pnlBody.Location = New System.Drawing.Point(0, 56)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(1027, 617)
        Me.pnlBody.TabIndex = 3
        '
        'ETracePanel5
        '
        Me.ETracePanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ETracePanel5.Controls.Add(Me.grpHeader)
        Me.ETracePanel5.Location = New System.Drawing.Point(5, 68)
        Me.ETracePanel5.Name = "ETracePanel5"
        Me.ETracePanel5.Size = New System.Drawing.Size(1018, 189)
        Me.ETracePanel5.TabIndex = 6
        '
        'grpHeader
        '
        Me.grpHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpHeader.Controls.Add(Me.dgvHeader)
        Me.grpHeader.Location = New System.Drawing.Point(6, 5)
        Me.grpHeader.Name = "grpHeader"
        Me.grpHeader.Size = New System.Drawing.Size(1006, 178)
        Me.grpHeader.TabIndex = 5
        Me.grpHeader.TabStop = False
        Me.grpHeader.Tag = "^BJM-4@"
        Me.grpHeader.Text = "BJ Header"
        '
        'dgvHeader
        '
        Me.dgvHeader.AllowUserToAddRows = False
        Me.dgvHeader.AllowUserToDeleteRows = False
        Me.dgvHeader.AllowUserToResizeRows = False
        Me.dgvHeader.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHeader.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvHeader.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdLine, Me.DJ, Me.TLA, Me.BJ, Me.BPA, Me.BJQty, Me.CmpQty, Me.CurCmpQty, Me.Status, Me.SchDate, Me.Remarks})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHeader.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHeader.Location = New System.Drawing.Point(3, 16)
        Me.dgvHeader.MultiSelect = False
        Me.dgvHeader.Name = "dgvHeader"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHeader.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvHeader.RowHeadersWidth = 23
        Me.dgvHeader.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvHeader.Size = New System.Drawing.Size(1000, 159)
        Me.dgvHeader.TabIndex = 0
        '
        'ETracePanel1
        '
        Me.ETracePanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ETracePanel1.Controls.Add(Me.grpItem)
        Me.ETracePanel1.Location = New System.Drawing.Point(3, 267)
        Me.ETracePanel1.Name = "ETracePanel1"
        Me.ETracePanel1.Size = New System.Drawing.Size(1018, 285)
        Me.ETracePanel1.TabIndex = 5
        '
        'grpItem
        '
        Me.grpItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpItem.Controls.Add(Me.dgvItem)
        Me.grpItem.Location = New System.Drawing.Point(6, 6)
        Me.grpItem.Name = "grpItem"
        Me.grpItem.Size = New System.Drawing.Size(1007, 273)
        Me.grpItem.TabIndex = 2
        Me.grpItem.TabStop = False
        Me.grpItem.Tag = "^BJM-5@"
        Me.grpItem.Text = "BJ Item"
        '
        'dgvItem
        '
        Me.dgvItem.AllowUserToAddRows = False
        Me.dgvItem.AllowUserToDeleteRows = False
        Me.dgvItem.AllowUserToResizeRows = False
        Me.dgvItem.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.ProcessCode, Me.Usage, Me.ReqQty, Me.SupplyType})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItem.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvItem.Location = New System.Drawing.Point(3, 16)
        Me.dgvItem.Name = "dgvItem"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItem.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvItem.RowHeadersWidth = 23
        Me.dgvItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItem.Size = New System.Drawing.Size(1001, 254)
        Me.dgvItem.TabIndex = 0
        '
        'Item
        '
        Me.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Item.DataPropertyName = "Item"
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.ToolTipText = "Item"
        Me.Item.Width = 52
        '
        'ProcessCode
        '
        Me.ProcessCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ProcessCode.DataPropertyName = "ProcessCode"
        Me.ProcessCode.HeaderText = "ProcessCode"
        Me.ProcessCode.Name = "ProcessCode"
        Me.ProcessCode.ReadOnly = True
        Me.ProcessCode.ToolTipText = "ProcessCode"
        Me.ProcessCode.Width = 95
        '
        'Usage
        '
        Me.Usage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Usage.DataPropertyName = "Usage"
        Me.Usage.HeaderText = "Usage"
        Me.Usage.Name = "Usage"
        Me.Usage.ReadOnly = True
        Me.Usage.ToolTipText = "Usage"
        Me.Usage.Width = 63
        '
        'ReqQty
        '
        Me.ReqQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ReqQty.DataPropertyName = "ReqQty"
        Me.ReqQty.HeaderText = "ReqQty"
        Me.ReqQty.Name = "ReqQty"
        Me.ReqQty.ReadOnly = True
        Me.ReqQty.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReqQty.ToolTipText = "ReqQty"
        Me.ReqQty.Width = 68
        '
        'SupplyType
        '
        Me.SupplyType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SupplyType.DataPropertyName = "SupplyType"
        Me.SupplyType.HeaderText = "SupplyType"
        Me.SupplyType.Name = "SupplyType"
        Me.SupplyType.ReadOnly = True
        Me.SupplyType.ToolTipText = "SupplyType"
        Me.SupplyType.Width = 88
        '
        'grpActions
        '
        Me.grpActions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpActions.Controls.Add(Me.tblActions)
        Me.grpActions.Location = New System.Drawing.Point(5, 558)
        Me.grpActions.Name = "grpActions"
        Me.grpActions.Size = New System.Drawing.Size(1017, 51)
        Me.grpActions.TabIndex = 3
        Me.grpActions.TabStop = False
        Me.grpActions.Tag = "^APP-13@"
        Me.grpActions.Text = "Actions"
        '
        'tblActions
        '
        Me.tblActions.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tblActions.ColumnCount = 5
        Me.tblActions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.tblActions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.tblActions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.tblActions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.tblActions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.tblActions.Controls.Add(Me.btnSave, 0, 0)
        Me.tblActions.Controls.Add(Me.btnClear, 1, 0)
        Me.tblActions.Controls.Add(Me.btnExcel, 2, 0)
        Me.tblActions.Controls.Add(Me.btnMO, 3, 0)
        Me.tblActions.Location = New System.Drawing.Point(3, 16)
        Me.tblActions.Name = "tblActions"
        Me.tblActions.RowCount = 1
        Me.tblActions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblActions.Size = New System.Drawing.Size(1002, 32)
        Me.tblActions.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnSave.Location = New System.Drawing.Point(3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Tag = "^BJM-6@"
        Me.btnSave.Text = "Save [F8]"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnClear.Location = New System.Drawing.Point(109, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Tag = "^BJM-7@"
        Me.btnClear.Text = "Clear [F5]"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnExcel.Location = New System.Drawing.Point(215, 4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(120, 23)
        Me.btnExcel.TabIndex = 2
        Me.btnExcel.Tag = "^MMC-46@"
        Me.btnExcel.Text = "Download to Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnMO
        '
        Me.btnMO.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnMO.Location = New System.Drawing.Point(341, 4)
        Me.btnMO.Name = "btnMO"
        Me.btnMO.Size = New System.Drawing.Size(120, 23)
        Me.btnMO.TabIndex = 3
        Me.btnMO.Tag = "^BJM-39@"
        Me.btnMO.Text = "Generate MO"
        Me.btnMO.UseVisualStyleBackColor = True
        Me.btnMO.Visible = False
        '
        'grpInput
        '
        Me.grpInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInput.Controls.Add(Me.tblInput)
        Me.grpInput.Location = New System.Drawing.Point(5, 5)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(1019, 54)
        Me.grpInput.TabIndex = 0
        Me.grpInput.TabStop = False
        Me.grpInput.Tag = "^APP-27@"
        Me.grpInput.Text = "Input Area"
        '
        'tblInput
        '
        Me.tblInput.ColumnCount = 7
        Me.tblInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.tblInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.tblInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.tblInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.tblInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.tblInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.tblInput.Controls.Add(Me.lblDJ, 0, 0)
        Me.tblInput.Controls.Add(Me.txtDJ, 1, 0)
        Me.tblInput.Controls.Add(Me.btnShow, 3, 0)
        Me.tblInput.Controls.Add(Me.btnCreate, 2, 0)
        Me.tblInput.Controls.Add(Me.cbxOnlyOpen, 5, 0)
        Me.tblInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblInput.Location = New System.Drawing.Point(3, 16)
        Me.tblInput.Name = "tblInput"
        Me.tblInput.RowCount = 1
        Me.tblInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblInput.Size = New System.Drawing.Size(1013, 35)
        Me.tblInput.TabIndex = 0
        '
        'lblDJ
        '
        Me.lblDJ.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDJ.AutoSize = True
        Me.lblDJ.Location = New System.Drawing.Point(3, 11)
        Me.lblDJ.Name = "lblDJ"
        Me.lblDJ.Size = New System.Drawing.Size(20, 13)
        Me.lblDJ.TabIndex = 0
        Me.lblDJ.Tag = ""
        Me.lblDJ.Text = "DJ"
        '
        'txtDJ
        '
        Me.txtDJ.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtDJ.BackColor = System.Drawing.SystemColors.Window
        Me.txtDJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDJ.DataType = Nothing
        Me.txtDJ.ElementTitle = Me.lblDJ
        Me.txtDJ.ErrorColor = System.Drawing.Color.DarkOrange
        Me.txtDJ.ErrorMessage = Nothing
        Me.txtDJ.KeyIn = True
        Me.txtDJ.Location = New System.Drawing.Point(29, 7)
        Me.txtDJ.Name = "txtDJ"
        Me.txtDJ.NoOfDecimals = 0
        Me.txtDJ.ParentControl = Nothing
        Me.txtDJ.RegEx = Nothing
        Me.txtDJ.Required = False
        Me.txtDJ.Size = New System.Drawing.Size(80, 20)
        Me.txtDJ.StatusControl = Nothing
        Me.txtDJ.TabIndex = 0
        Me.txtDJ.Tag = "DJ"
        Me.txtDJ.TextCase = eTraceUI.eTraceTextBox.TextCases.UpperCase
        Me.txtDJ.ValidationType = Nothing
        Me.txtDJ.WarnColor = System.Drawing.Color.Wheat
        '
        'btnShow
        '
        Me.btnShow.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnShow.AutoSize = True
        Me.btnShow.Location = New System.Drawing.Point(184, 6)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(64, 23)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Tag = "^BJM-3@"
        Me.btnShow.Text = "Show BJs"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnCreate.AutoSize = True
        Me.btnCreate.Location = New System.Drawing.Point(115, 6)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(63, 23)
        Me.btnCreate.TabIndex = 1
        Me.btnCreate.Tag = "^BJM-2@"
        Me.btnCreate.Text = "Create BJ"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'cbxOnlyOpen
        '
        Me.cbxOnlyOpen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbxOnlyOpen.AutoSize = True
        Me.cbxOnlyOpen.Checked = True
        Me.cbxOnlyOpen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxOnlyOpen.Location = New System.Drawing.Point(274, 3)
        Me.cbxOnlyOpen.Name = "cbxOnlyOpen"
        Me.cbxOnlyOpen.Size = New System.Drawing.Size(122, 29)
        Me.cbxOnlyOpen.TabIndex = 3
        Me.cbxOnlyOpen.Tag = "^BJM-38@"
        Me.cbxOnlyOpen.Text = "Only show open BJs"
        Me.cbxOnlyOpen.UseVisualStyleBackColor = True
        '
        'bgwSave
        '
        '
        'bgwCreateBJ
        '
        '
        'OpenExcelFile
        '
        Me.OpenExcelFile.FileName = "OpenFileDialog1"
        '
        'bgwShow
        '
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProdLine"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ProdLine"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.ToolTipText = "ProdLine"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DJ"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DJ"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.ToolTipText = "DJ"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TLA"
        Me.DataGridViewTextBoxColumn3.HeaderText = "TLA"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.ToolTipText = "TLA"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "BJ"
        Me.DataGridViewTextBoxColumn4.HeaderText = "BJ"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.ToolTipText = "BJ"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "BPA"
        Me.DataGridViewTextBoxColumn5.HeaderText = "BPA"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.ToolTipText = "BPA"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "BJQty"
        Me.DataGridViewTextBoxColumn6.HeaderText = "BJQty"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.ToolTipText = "BJQty"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CmpQty"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CmpQty"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ToolTipText = "CmpQty"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn8.ToolTipText = "Remarks"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Item"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ToolTipText = "Item"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ProcessCode"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ProcessCode"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ToolTipText = "ProcessCode"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Usage"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Usage"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ToolTipText = "Usage"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "SupplyType"
        Me.DataGridViewTextBoxColumn12.HeaderText = "SupplyType"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ToolTipText = "SupplyType"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "SupplyType"
        Me.DataGridViewTextBoxColumn13.HeaderText = "SupplyType"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ToolTipText = "SupplyType"
        '
        'ETracePanel2
        '
        Me.ETracePanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ETracePanel2.Controls.Add(Me.ETracePanel3)
        Me.ETracePanel2.Controls.Add(Me.ETracePanel4)
        Me.ETracePanel2.Controls.Add(Me.ETraceGroupBox3)
        Me.ETracePanel2.Location = New System.Drawing.Point(0, 0)
        Me.ETracePanel2.Name = "ETracePanel2"
        Me.ETracePanel2.Size = New System.Drawing.Size(200, 100)
        Me.ETracePanel2.TabIndex = 0
        '
        'ETracePanel3
        '
        Me.ETracePanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ETracePanel3.Controls.Add(Me.ETraceGroupBox1)
        Me.ETracePanel3.Location = New System.Drawing.Point(4, 72)
        Me.ETracePanel3.Name = "ETracePanel3"
        Me.ETracePanel3.Size = New System.Drawing.Size(1018, 161)
        Me.ETracePanel3.TabIndex = 6
        '
        'ETraceGroupBox1
        '
        Me.ETraceGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ETraceGroupBox1.Controls.Add(Me.ETraceDataGridView1)
        Me.ETraceGroupBox1.Location = New System.Drawing.Point(5, 5)
        Me.ETraceGroupBox1.Name = "ETraceGroupBox1"
        Me.ETraceGroupBox1.Size = New System.Drawing.Size(998, 150)
        Me.ETraceGroupBox1.TabIndex = 1
        Me.ETraceGroupBox1.TabStop = False
        Me.ETraceGroupBox1.Tag = "^BJM-4@"
        Me.ETraceGroupBox1.Text = "BJ Header"
        '
        'ETraceDataGridView1
        '
        Me.ETraceDataGridView1.AllowUserToAddRows = False
        Me.ETraceDataGridView1.AllowUserToDeleteRows = False
        Me.ETraceDataGridView1.AllowUserToResizeRows = False
        Me.ETraceDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ETraceDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ETraceDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.ETraceDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ETraceDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewComboBoxColumn1, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ETraceDataGridView1.DefaultCellStyle = DataGridViewCellStyle8
        Me.ETraceDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ETraceDataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.ETraceDataGridView1.Name = "ETraceDataGridView1"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ETraceDataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.ETraceDataGridView1.Size = New System.Drawing.Size(992, 131)
        Me.ETraceDataGridView1.TabIndex = 0
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "ProdLine"
        Me.DataGridViewTextBoxColumn14.HeaderText = "ProdLine"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.ToolTipText = "ProdLine"
        Me.DataGridViewTextBoxColumn14.Width = 74
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "DJ"
        Me.DataGridViewTextBoxColumn15.HeaderText = "DJ"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.ToolTipText = "DJ"
        Me.DataGridViewTextBoxColumn15.Width = 45
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "TLA"
        Me.DataGridViewTextBoxColumn16.HeaderText = "TLA"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.ToolTipText = "TLA"
        Me.DataGridViewTextBoxColumn16.Width = 52
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "BJ"
        Me.DataGridViewTextBoxColumn17.HeaderText = "BJ"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.ToolTipText = "BJ"
        Me.DataGridViewTextBoxColumn17.Width = 44
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "BPA"
        Me.DataGridViewTextBoxColumn18.HeaderText = "BPA"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.ToolTipText = "BPA"
        Me.DataGridViewTextBoxColumn18.Width = 53
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "BJQty"
        Me.DataGridViewTextBoxColumn19.HeaderText = "BJQty"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.ToolTipText = "BJQty"
        Me.DataGridViewTextBoxColumn19.Width = 60
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "CmpQty"
        Me.DataGridViewTextBoxColumn20.HeaderText = "CmpQty"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ToolTipText = "CmpQty"
        Me.DataGridViewTextBoxColumn20.Width = 69
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewComboBoxColumn1.DataPropertyName = "Status"
        Me.DataGridViewComboBoxColumn1.HeaderText = "Status"
        Me.DataGridViewComboBoxColumn1.Items.AddRange(New Object() {"Released", "In-Progress", "Completed", "Cancelled"})
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewComboBoxColumn1.ToolTipText = "Status"
        Me.DataGridViewComboBoxColumn1.Width = 62
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "SchDate"
        Me.DataGridViewTextBoxColumn21.HeaderText = "SchDate"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ToolTipText = "SchDate"
        Me.DataGridViewTextBoxColumn21.Width = 74
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ToolTipText = "Remarks"
        Me.DataGridViewTextBoxColumn22.Width = 74
        '
        'ETracePanel4
        '
        Me.ETracePanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ETracePanel4.Controls.Add(Me.ETraceGroupBox2)
        Me.ETracePanel4.Location = New System.Drawing.Point(3, 245)
        Me.ETracePanel4.Name = "ETracePanel4"
        Me.ETracePanel4.Size = New System.Drawing.Size(1018, 301)
        Me.ETracePanel4.TabIndex = 5
        '
        'ETraceGroupBox2
        '
        Me.ETraceGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ETraceGroupBox2.Controls.Add(Me.ETraceDataGridView2)
        Me.ETraceGroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.ETraceGroupBox2.Name = "ETraceGroupBox2"
        Me.ETraceGroupBox2.Size = New System.Drawing.Size(1007, 289)
        Me.ETraceGroupBox2.TabIndex = 2
        Me.ETraceGroupBox2.TabStop = False
        Me.ETraceGroupBox2.Tag = "^BJM-5@"
        Me.ETraceGroupBox2.Text = "BJ Item"
        '
        'ETraceDataGridView2
        '
        Me.ETraceDataGridView2.AllowUserToAddRows = False
        Me.ETraceDataGridView2.AllowUserToResizeRows = False
        Me.ETraceDataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ETraceDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ETraceDataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.ETraceDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ETraceDataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Material, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ETraceDataGridView2.DefaultCellStyle = DataGridViewCellStyle11
        Me.ETraceDataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ETraceDataGridView2.Location = New System.Drawing.Point(3, 16)
        Me.ETraceDataGridView2.Name = "ETraceDataGridView2"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ETraceDataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.ETraceDataGridView2.Size = New System.Drawing.Size(1001, 270)
        Me.ETraceDataGridView2.TabIndex = 0
        '
        'Material
        '
        Me.Material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Material.DataPropertyName = "Material"
        Me.Material.HeaderText = "Item"
        Me.Material.Name = "Material"
        Me.Material.ToolTipText = "Material"
        Me.Material.Width = 52
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "ProcessCode"
        Me.DataGridViewTextBoxColumn23.HeaderText = "ProcessCode"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ToolTipText = "ProcessCode"
        Me.DataGridViewTextBoxColumn23.Width = 95
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Usage"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Usage"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ToolTipText = "Usage"
        Me.DataGridViewTextBoxColumn24.Width = 63
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "SupplyType"
        Me.DataGridViewTextBoxColumn25.HeaderText = "SupplyType"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ToolTipText = "SupplyType"
        Me.DataGridViewTextBoxColumn25.Width = 88
        '
        'ETraceGroupBox3
        '
        Me.ETraceGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ETraceGroupBox3.Controls.Add(Me.ETraceTableLayoutPanel1)
        Me.ETraceGroupBox3.Location = New System.Drawing.Point(5, 559)
        Me.ETraceGroupBox3.Name = "ETraceGroupBox3"
        Me.ETraceGroupBox3.Size = New System.Drawing.Size(1017, 51)
        Me.ETraceGroupBox3.TabIndex = 3
        Me.ETraceGroupBox3.TabStop = False
        Me.ETraceGroupBox3.Tag = "^APP-13@"
        Me.ETraceGroupBox3.Text = "Actions"
        '
        'ETraceTableLayoutPanel1
        '
        Me.ETraceTableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ETraceTableLayoutPanel1.ColumnCount = 4
        Me.ETraceTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.ETraceTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.ETraceTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.ETraceTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.ETraceTableLayoutPanel1.Controls.Add(Me.ETraceButton1, 1, 0)
        Me.ETraceTableLayoutPanel1.Controls.Add(Me.ETraceButton2, 0, 0)
        Me.ETraceTableLayoutPanel1.Controls.Add(Me.ETraceButton3, 2, 0)
        Me.ETraceTableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.ETraceTableLayoutPanel1.Name = "ETraceTableLayoutPanel1"
        Me.ETraceTableLayoutPanel1.RowCount = 1
        Me.ETraceTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ETraceTableLayoutPanel1.Size = New System.Drawing.Size(1002, 32)
        Me.ETraceTableLayoutPanel1.TabIndex = 0
        '
        'ETraceButton1
        '
        Me.ETraceButton1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ETraceButton1.Location = New System.Drawing.Point(109, 4)
        Me.ETraceButton1.Name = "ETraceButton1"
        Me.ETraceButton1.Size = New System.Drawing.Size(120, 23)
        Me.ETraceButton1.TabIndex = 1
        Me.ETraceButton1.Tag = "^MMC-46@"
        Me.ETraceButton1.Text = "Download to Excel"
        Me.ETraceButton1.UseVisualStyleBackColor = True
        '
        'ETraceButton2
        '
        Me.ETraceButton2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ETraceButton2.Location = New System.Drawing.Point(3, 4)
        Me.ETraceButton2.Name = "ETraceButton2"
        Me.ETraceButton2.Size = New System.Drawing.Size(100, 23)
        Me.ETraceButton2.TabIndex = 0
        Me.ETraceButton2.Tag = "^BJM-6@"
        Me.ETraceButton2.Text = "Save [F8]"
        Me.ETraceButton2.UseVisualStyleBackColor = True
        '
        'ETraceButton3
        '
        Me.ETraceButton3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ETraceButton3.Location = New System.Drawing.Point(235, 4)
        Me.ETraceButton3.Name = "ETraceButton3"
        Me.ETraceButton3.Size = New System.Drawing.Size(100, 23)
        Me.ETraceButton3.TabIndex = 2
        Me.ETraceButton3.Tag = "^BJM-7@"
        Me.ETraceButton3.Text = "Clear [F5]"
        Me.ETraceButton3.UseVisualStyleBackColor = True
        '
        'ETraceGroupBox4
        '
        Me.ETraceGroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ETraceGroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.ETraceGroupBox4.Name = "ETraceGroupBox4"
        Me.ETraceGroupBox4.Size = New System.Drawing.Size(200, 100)
        Me.ETraceGroupBox4.TabIndex = 0
        Me.ETraceGroupBox4.TabStop = False
        '
        'ETraceTableLayoutPanel2
        '
        Me.ETraceTableLayoutPanel2.ColumnCount = 6
        Me.ETraceTableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.ETraceTableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.ETraceTableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ETraceTableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.ETraceTableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.ETraceTableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.ETraceTableLayoutPanel2.Controls.Add(Me.ETraceButton4, 4, 0)
        Me.ETraceTableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.ETraceTableLayoutPanel2.Name = "ETraceTableLayoutPanel2"
        Me.ETraceTableLayoutPanel2.RowCount = 1
        Me.ETraceTableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ETraceTableLayoutPanel2.Size = New System.Drawing.Size(200, 100)
        Me.ETraceTableLayoutPanel2.TabIndex = 0
        '
        'ETraceButton4
        '
        Me.ETraceButton4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ETraceButton4.AutoSize = True
        Me.ETraceButton4.Location = New System.Drawing.Point(23, 38)
        Me.ETraceButton4.Name = "ETraceButton4"
        Me.ETraceButton4.Size = New System.Drawing.Size(141, 23)
        Me.ETraceButton4.TabIndex = 13
        Me.ETraceButton4.Tag = "^BJM-3@"
        Me.ETraceButton4.Text = "Show Open BJs"
        Me.ETraceButton4.UseVisualStyleBackColor = True
        '
        'ETraceLabel1
        '
        Me.ETraceLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ETraceLabel1.AutoSize = True
        Me.ETraceLabel1.Location = New System.Drawing.Point(3, 11)
        Me.ETraceLabel1.Name = "ETraceLabel1"
        Me.ETraceLabel1.Size = New System.Drawing.Size(20, 13)
        Me.ETraceLabel1.TabIndex = 0
        Me.ETraceLabel1.Tag = "^BJM-1@"
        Me.ETraceLabel1.Text = "DJ"
        '
        'bgwGenMO
        '
        '
        'ProdLine
        '
        Me.ProdLine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ProdLine.DataPropertyName = "ProdLine"
        Me.ProdLine.HeaderText = "ProdLine"
        Me.ProdLine.Name = "ProdLine"
        Me.ProdLine.ReadOnly = True
        Me.ProdLine.ToolTipText = "ProdLine"
        Me.ProdLine.Width = 74
        '
        'DJ
        '
        Me.DJ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DJ.DataPropertyName = "DJ"
        Me.DJ.HeaderText = "DJ"
        Me.DJ.Name = "DJ"
        Me.DJ.ReadOnly = True
        Me.DJ.ToolTipText = "DJ"
        Me.DJ.Width = 45
        '
        'TLA
        '
        Me.TLA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TLA.DataPropertyName = "TLA"
        Me.TLA.HeaderText = "TLA"
        Me.TLA.Name = "TLA"
        Me.TLA.ReadOnly = True
        Me.TLA.ToolTipText = "TLA"
        Me.TLA.Width = 52
        '
        'BJ
        '
        Me.BJ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.BJ.DataPropertyName = "BJ"
        Me.BJ.HeaderText = "BJ"
        Me.BJ.Name = "BJ"
        Me.BJ.ReadOnly = True
        Me.BJ.ToolTipText = "BJ"
        Me.BJ.Width = 44
        '
        'BPA
        '
        Me.BPA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.BPA.DataPropertyName = "BPA"
        Me.BPA.HeaderText = "BPA"
        Me.BPA.Name = "BPA"
        Me.BPA.ReadOnly = True
        Me.BPA.ToolTipText = "BPA"
        Me.BPA.Width = 53
        '
        'BJQty
        '
        Me.BJQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.BJQty.DataPropertyName = "BJQty"
        Me.BJQty.HeaderText = "BJQty"
        Me.BJQty.Name = "BJQty"
        Me.BJQty.ReadOnly = True
        Me.BJQty.ToolTipText = "BJQty"
        Me.BJQty.Width = 60
        '
        'CmpQty
        '
        Me.CmpQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CmpQty.DataPropertyName = "CmpQty"
        Me.CmpQty.HeaderText = "CmpQty"
        Me.CmpQty.Name = "CmpQty"
        Me.CmpQty.ReadOnly = True
        Me.CmpQty.ToolTipText = "CmpQty"
        Me.CmpQty.Width = 69
        '
        'CurCmpQty
        '
        Me.CurCmpQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CurCmpQty.DataPropertyName = "CurCmpQty"
        Me.CurCmpQty.HeaderText = "CurCmpQty"
        Me.CurCmpQty.Name = "CurCmpQty"
        Me.CurCmpQty.ToolTipText = "CurCmpQty"
        Me.CurCmpQty.Width = 85
        '
        'Status
        '
        Me.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Items.AddRange(New Object() {"Released", "In-Progress", "Completed", "Cancelled"})
        Me.Status.Name = "Status"
        Me.Status.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Status.ToolTipText = "Status"
        Me.Status.Width = 62
        '
        'SchDate
        '
        Me.SchDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SchDate.DataPropertyName = "SchDate"
        Me.SchDate.HeaderText = "SchDate"
        Me.SchDate.Name = "SchDate"
        Me.SchDate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SchDate.ToolTipText = "SchDate"
        Me.SchDate.Width = 55
        '
        'Remarks
        '
        Me.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Remarks.DataPropertyName = "Remarks"
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.ToolTipText = "Remarks"
        Me.Remarks.Width = 74
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1028, 697)
        Me.Controls.Add(Me.pnlBody)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "frmMain"
        TimerStatus1.Frequencies = eTraceUI.Frequencies.Second
        TimerStatus1.Interval = 0
        TimerStatus1.Start = False
        Me.TimerStatus = TimerStatus1
        Me.Controls.SetChildIndex(Me.pnlBody, 0)
        Me.Controls.SetChildIndex(Me.MessageBar1, 0)
        Me.pnlBody.ResumeLayout(False)
        Me.ETracePanel5.ResumeLayout(False)
        Me.grpHeader.ResumeLayout(False)
        CType(Me.dgvHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ETracePanel1.ResumeLayout(False)
        Me.grpItem.ResumeLayout(False)
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpActions.ResumeLayout(False)
        Me.tblActions.ResumeLayout(False)
        Me.grpInput.ResumeLayout(False)
        Me.tblInput.ResumeLayout(False)
        Me.tblInput.PerformLayout()
        Me.ETracePanel2.ResumeLayout(False)
        Me.ETracePanel3.ResumeLayout(False)
        Me.ETraceGroupBox1.ResumeLayout(False)
        CType(Me.ETraceDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ETracePanel4.ResumeLayout(False)
        Me.ETraceGroupBox2.ResumeLayout(False)
        CType(Me.ETraceDataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ETraceGroupBox3.ResumeLayout(False)
        Me.ETraceTableLayoutPanel1.ResumeLayout(False)
        Me.ETraceTableLayoutPanel2.ResumeLayout(False)
        Me.ETraceTableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBody As eTraceUI.eTracePanel
    Friend WithEvents ETracePanel1 As eTraceUI.eTracePanel
    Friend WithEvents grpItem As eTraceUI.eTraceGroupBox
    Friend WithEvents dgvItem As eTraceUI.eTraceDataGridView
    Friend WithEvents grpActions As eTraceUI.eTraceGroupBox
    Friend WithEvents tblActions As eTraceUI.eTraceTableLayoutPanel
    Friend WithEvents btnExcel As eTraceUI.eTraceButton
    Friend WithEvents btnClear As eTraceUI.eTraceButton
    Friend WithEvents grpInput As eTraceUI.eTraceGroupBox
    Friend WithEvents tblInput As eTraceUI.eTraceTableLayoutPanel
    Friend WithEvents btnCreate As eTraceUI.eTraceButton
    Friend WithEvents bgwSave As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwCreateBJ As System.ComponentModel.BackgroundWorker
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenExcelFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents bgwUpload As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwShow As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwExcelDownload As System.ComponentModel.BackgroundWorker
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpHeader As eTraceUI.eTraceGroupBox
    Friend WithEvents dgvHeader As eTraceUI.eTraceDataGridView
    Friend WithEvents ETracePanel2 As eTraceUI.eTracePanel
    Friend WithEvents ETracePanel3 As eTraceUI.eTracePanel
    Friend WithEvents ETraceGroupBox1 As eTraceUI.eTraceGroupBox
    Friend WithEvents ETraceDataGridView1 As eTraceUI.eTraceDataGridView
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ETracePanel4 As eTraceUI.eTracePanel
    Friend WithEvents ETraceGroupBox2 As eTraceUI.eTraceGroupBox
    Friend WithEvents ETraceDataGridView2 As eTraceUI.eTraceDataGridView
    Friend WithEvents Material As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ETraceGroupBox3 As eTraceUI.eTraceGroupBox
    Friend WithEvents ETraceTableLayoutPanel1 As eTraceUI.eTraceTableLayoutPanel
    Friend WithEvents ETraceButton1 As eTraceUI.eTraceButton
    Friend WithEvents ETraceButton2 As eTraceUI.eTraceButton
    Friend WithEvents ETraceButton3 As eTraceUI.eTraceButton
    Friend WithEvents ETraceGroupBox4 As eTraceUI.eTraceGroupBox
    Friend WithEvents ETraceTableLayoutPanel2 As eTraceUI.eTraceTableLayoutPanel
    Friend WithEvents ETraceButton4 As eTraceUI.eTraceButton
    Friend WithEvents ETraceLabel1 As eTraceUI.eTraceLabel
    Friend WithEvents ETracePanel5 As eTraceUI.eTracePanel
    Friend WithEvents cbxOnlyOpen As eTraceUI.eTraceCheckBox
    Friend WithEvents lblDJ As eTraceUI.eTraceLabel
    Friend WithEvents txtDJ As eTraceUI.eTraceTextBox
    Friend WithEvents btnShow As eTraceUI.eTraceButton
    Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProcessCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Usage As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReqQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplyType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSave As eTraceUI.eTraceButton
    Friend WithEvents btnMO As eTraceUI.eTraceButton
    Friend WithEvents bgwGenMO As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProdLine As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DJ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TLA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BJ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BPA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BJQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CmpQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurCmpQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend SchDate As eTraceUI.eTraceDataGridView.CalendarColumn
    Friend WithEvents Remarks As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
