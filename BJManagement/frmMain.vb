Imports System.Windows.Forms
Imports System.Globalization
Imports System.Text
Imports System.IO
Imports System.Resources
Imports System.Xml
Imports System.Math
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports System.Data.OleDb


Public Class frmMain
    Dim FromPath, FromName, FromFile As String
    Dim BJds, ExcelData, BJ_Tmp, BJ_Initial As New DataSet
    Dim BJ_Rs As MaterialReplenishment.BJ_Rs
    Dim dsExcel As DataSet
    Dim DJ_Valid, BJ_Create As Boolean
    Dim RowIndexSLED As Integer
    'Dim DetailTable As Data.DataTable = New Data.DataTable("ItemDetails")
    Public Header As MaterialReplenishment.ProdPickingStructure = New MaterialReplenishment.ProdPickingStructure

    Public Overrides Sub NewSession_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'New Instance of the form
        Dim NewInstance As New frmMain()
        NewInstance.ShowFrm(Me)
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            BindCtlsToProcess(Me, 25)
            Me.WindowState = FormWindowState.Normal

            pnlBody.Visible = True
            grpInput.Visible = True
            grpHeader.Visible = False
            grpItem.Visible = False
            grpActions.Visible = False
            'btnSave.Visible = False
            'btnClear.Visible = False
            'btnExcel.Visible = False
            'btnMO.Visible = True

            AttachHotkey(btnSave, Keys.F8)
            AttachHotkey(btnClear, Keys.F5)

            ERPLogin.User = ERPLoginData.User
            ERPLogin.PWD = ERPLoginData.PWD
            ERPLogin.UserID = ERPLoginData.UserID
            ERPLogin.OrgCode = ERPLoginData.OrgCode
            ERPLogin.Printer = ERPLoginData.Printer
            ERPLogin.Server = ERPLoginData.Server
            ERPLogin.OrgID = ERPLoginData.OrgID

            ERPLogin.AppID_PO = ERPLoginData.AppID_PO
            ERPLogin.RespID_PO = ERPLoginData.RespID_PO
            ERPLogin.AppID_Inv = ERPLoginData.AppID_Inv
            ERPLogin.RespID_Inv = ERPLoginData.RespID_Inv
            ERPLogin.AppID_WIP = ERPLoginData.AppID_WIP
            ERPLogin.RespID_WIP = ERPLoginData.RespID_WIP

            BJds = New DataSet
            txtDJ.Focus()

            Me.TimerStart()

            If ProductionLine() = "" Then
                Me.ShowMessage("^BJM-8@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                Dim UserSettings As New eTraceUI.frmUserSettings(Me)
                UserSettings.ShowDialog(Me)
                Exit Sub
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmMain_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.CenterToScreen()
        If ProductionLine() = "" Then
            Me.ShowMessage("^BJM-8@", eTraceUI.eTraceMessageBar.MessageTypes.Information, AnimationStatus.StopAnim, True, PopUpTypes.Message)
            Dim UserSettings As New eTraceUI.frmUserSettings(Me)
            UserSettings.ShowDialog(Me)
        End If
    End Sub

    Private Sub txtDJ_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDJ.Validated
        Try
            If txtDJ.Text = "" Then
                Exit Sub
            End If
            txtDJ.Enabled = False
            btnCreate.Enabled = False
            btnShow.Enabled = False
            cbxOnlyOpen.Enabled = False

            If BJds Is Nothing OrElse BJds.Tables.Count = 0 Then
                BJds = New DataSet
                dsExcel = New DataSet
                AddHeaderTable()
                AddItemTable()
                AddExcelTable()
            End If

            Me.txtDJ.Text = Me.txtDJ.Text.Trim
            eTraceWS.Timeout = 1000 * 60 * 30
            BJ_Rs = New MaterialReplenishment.BJ_Rs
            BJ_Rs = eTraceWS.BJ_GetBJ(txtDJ.Text.Trim.ToUpper, ProductionLine(), BJds, cbxOnlyOpen.Checked, ERPLogin)

            'If Not BJ_Rs Is Nothing AndAlso Not BJ_Rs.BJInfo Is Nothing AndAlso BJ_Rs.BJInfo.Tables("BJHeader").Rows.Count > 0 Then
            If BJ_Rs.Flag = 0 Then
                BJ_Create = False
                DJ_Valid = True
                grpInput.Enabled = True
                'grpActions.Enabled = True
                'grpHeader.Enabled = True
                'grpItem.Enabled = True
                grpHeader.Visible = True
                grpItem.Visible = True
                grpActions.Visible = True
                'btnSave.Visible = True
                'btnClear.Visible = True
                'btnExcel.Visible = True
                'btnMO.Visible = True

                'BJ_Tmp = New DataSet
                'BJ_Tmp = BJ_Rs.BJInfo.Copy
                BJ_Initial = New DataSet
                BJ_Initial = BJ_Rs.BJInfo.Copy

                dgvHeader.DataSource = BJ_Rs.BJInfo.Tables("BJHeader")
                dgvHeader.Columns("DJReleasedDate").Visible = False
                dgvHeader.Columns("PWC").Visible = False
                dgvHeader.Columns("PWCSubInv").Visible = False
                dgvHeader.Columns("PWCLocator").Visible = False
                dgvHeader.Columns("TLASubInv").Visible = False
                dgvHeader.Columns("TLALocator").Visible = False
                dgvHeader.Columns("CreatedOn").Visible = False
                dgvHeader.Columns("CreatedBy").Visible = False
                dgvHeader.Columns("ChangedOn").Visible = False
                dgvHeader.Columns("ChangedBy").Visible = False
                dgvHeader.Columns("OpenQty").Visible = False

                dgvHeader.Rows(0).Selected = True
                RowIndexSLED = dgvHeader.SelectedCells(0).RowIndex
                'dgvLabels.DataSource = MRListData
                'dgvLabels.DataMember = "CLIDTable"
                'dgvLabels.Columns("InvID").Visible = False
                'dgvLabels.Columns("Line").Visible = False
                dgvItem.DataSource = BJ_Rs.BJInfo.Tables("BJItem")
                dgvItem.Columns("MoveOrder").Visible = False
                dgvItem.Columns("PickedQty").Visible = False
                dgvItem.Columns("Remarks").Visible = False
                dgvItem.Columns("BJ").Visible = False
                dgvItem.Columns("ChangedOn").Visible = False
                dgvItem.Columns("ChangedBy").Visible = False

                Dim cm As CurrencyManager
                cm = CType(BindingContext(dgvItem.DataSource, dgvItem.DataMember), CurrencyManager)
                CType(cm.List, DataView).RowFilter = "BJ= '" & dgvHeader.Rows(RowIndexSLED).Cells("BJ").Value & "'"
                Me.ShowMessage("^BJM-25@", eTraceUI.eTraceMessageBar.MessageTypes.Information, AnimationStatus.StopAnim)
            Else
                btnCreate.Enabled = True
                btnShow.Enabled = True
                cbxOnlyOpen.Enabled = True
                txtDJ.Enabled = True
                btnCreate.Focus()
            End If
        Catch ex As Exception
            txtDJ.Enabled = True
            btnCreate.Enabled = True
            btnShow.Enabled = True
            cbxOnlyOpen.Enabled = True
            eTraceWS.ErrorLogging("BJManagement-txtDJ_Validated", ERPLogin.User.ToUpper, ex.Message & ex.Source)
        End Try
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Try
            If DJ_Valid = True Then
                Me.ShowMessage("^BJM-30@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                Exit Sub
            End If

            If txtDJ.Text = "" Then
                Me.ShowMessage("^APP-16@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                txtDJ.BackColor = Color.DarkOrange
                txtDJ.Focus()
                Exit Sub
            End If

            If BJds Is Nothing OrElse BJds.Tables.Count = 0 Then
                BJds = New DataSet
                dsExcel = New DataSet
                AddHeaderTable()
                AddItemTable()
                AddExcelTable()
            End If

            txtDJ.Enabled = False
            btnCreate.Enabled = False
            btnShow.Enabled = False
            cbxOnlyOpen.Enabled = False
            grpInput.Enabled = False
            'grpActions.Enabled = False
            'grpHeader.Enabled = False
            'grpItem.Enabled = False
            grpHeader.Visible = False
            grpItem.Visible = False
            grpActions.Visible = False
            'btnSave.Visible = False
            'btnClear.Visible = False
            'btnExcel.Visible = False
            'btnMO.Visible = True

            BJ_Rs = New MaterialReplenishment.BJ_Rs
            Me.ShowMessage("^BJM-9@", eTraceUI.eTraceMessageBar.MessageTypes.Information, AnimationStatus.StartAnim)
            bgwCreateBJ.RunWorkerAsync()

        Catch ex As Exception
            eTraceWS.ErrorLogging("BJManagement-btnCreate_Click", ERPLogin.User.ToUpper, ex.Message & ex.Source)
            Me.ShowMessage(ex.Message, eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
        End Try
    End Sub

    Private Sub bgwCreateBJ_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwCreateBJ.DoWork
        Dim DJInfo As MaterialReplenishment.BJ_Rs
        Try
            eTraceWS.Timeout = 1000 * 60 * 30
            DJInfo = eTraceWS.BJ_GetDJInfo(txtDJ.Text.Trim.ToUpper, ProductionLine(), ERPLogin)
            If Not DJInfo.BJInfo Is Nothing AndAlso DJInfo.BJInfo.Tables.Count >= 2 AndAlso DJInfo.BJInfo.Tables("dj_header").Rows.Count > 0 AndAlso FixNull(DJInfo.BJInfo.Tables("dj_header").Rows(0)("DJ")) <> "" Then
                If DJInfo.BJInfo.Tables("dj_header").Rows(0)("status") <> "Released" Then
                    BJ_Rs.BJInfo = Nothing
                    BJ_Rs.Flag = "3"
                    BJ_Rs.ErrMsg = "Invalid DJ status!"
                Else
                    eTraceWS.Timeout = 1000 * 60 * 30
                    BJ_Rs = eTraceWS.CheckBJInfo(txtDJ.Text, ProductionLine(), BJds, ERPLogin)
                    If BJ_Rs.Flag = "90" Then
                        BJ_Rs.BJInfo = Nothing
                        BJ_Rs.ErrMsg = "BJs already exist"
                        BJ_Rs.Flag = "90"
                    Else
                        BJ_Rs = New MaterialReplenishment.BJ_Rs
                        BJ_Rs = eTraceWS.BJ_Creation(DJInfo.BJInfo, BJds, ProductionLine(), ERPLogin)
                    End If
                End If
            Else
                BJ_Rs.BJInfo = Nothing
                BJ_Rs.Flag = "4"
                BJ_Rs.ErrMsg = DJInfo.ErrMsg
            End If
        Catch ex As Exception
            eTraceWS.ErrorLogging("BJManagement-bgwCreateBJ_DoWork", ERPLogin.User.ToUpper, ex.Message & ex.Source)
            BJ_Rs.BJInfo = Nothing
            BJ_Rs.Flag = "5"
            BJ_Rs.ErrMsg = ex.Message & ex.Source
        End Try
    End Sub

    Private Sub bgwCreateBJ_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwCreateBJ.RunWorkerCompleted
        Try
            If BJ_Rs.Flag <> "0" Then
                txtDJ.Enabled = True
                btnCreate.Enabled = True
                btnShow.Enabled = True
                cbxOnlyOpen.Enabled = True
                grpInput.Enabled = True
                'grpActions.Enabled = True
                'grpHeader.Enabled = True
                'grpItem.Enabled = True

                If BJ_Rs.Flag = "1" Then
                    Me.ShowMessage("^BJM-12@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                ElseIf BJ_Rs.Flag = "2" Then
                    Me.ShowMessage("^BJM-13@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                ElseIf BJ_Rs.Flag = "3" Then
                    Me.ShowMessage("^BJM-14@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                ElseIf BJ_Rs.Flag = "4" Then
                    Me.ShowMessage("^BJM-15@" & BJ_Rs.ErrMsg, eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                ElseIf BJ_Rs.Flag = "5" Then
                    Me.ShowMessage("^BJM-13@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                ElseIf BJ_Rs.Flag = "90" Then
                    Me.ShowMessage("^BJM-37@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                End If

                If txtDJ.Text <> "" Then
                    txtDJ.BackColor = Color.DarkOrange
                    txtDJ.Focus()
                End If
            Else
                BJ_Create = True
                txtDJ.Enabled = False
                btnCreate.Enabled = False
                btnShow.Enabled = False
                cbxOnlyOpen.Enabled = False
                grpInput.Enabled = True
                'grpActions.Enabled = True
                'grpHeader.Enabled = True
                'grpItem.Enabled = True
                grpHeader.Visible = True
                grpItem.Visible = True
                grpActions.Visible = True
                'btnSave.Visible = True
                'btnClear.Visible = True
                'btnExcel.Visible = True
                'btnMO.Visible = True

                'BJ_Tmp = New DataSet
                'BJ_Tmp = BJ_Rs.BJInfo.Copy
                BJ_Initial = New DataSet
                BJ_Initial = BJ_Rs.BJInfo.Copy
                dgvHeader.DataSource = BJ_Rs.BJInfo.Tables("BJHeader")
                dgvHeader.Columns("DJReleasedDate").Visible = False
                dgvHeader.Columns("PWC").Visible = False
                dgvHeader.Columns("PWCSubInv").Visible = False
                dgvHeader.Columns("PWCLocator").Visible = False
                dgvHeader.Columns("TLASubInv").Visible = False
                dgvHeader.Columns("TLALocator").Visible = False
                dgvHeader.Columns("CreatedOn").Visible = False
                dgvHeader.Columns("CreatedBy").Visible = False
                dgvHeader.Columns("ChangedOn").Visible = False
                dgvHeader.Columns("ChangedBy").Visible = False
                dgvHeader.Columns("OpenQty").Visible = False

                dgvHeader.Rows(0).Selected = True
                RowIndexSLED = dgvHeader.SelectedCells(0).RowIndex
                'dgvLabels.DataSource = MRListData
                'dgvLabels.DataMember = "CLIDTable"
                'dgvLabels.Columns("InvID").Visible = False
                'dgvLabels.Columns("Line").Visible = False
                dgvItem.DataSource = BJ_Rs.BJInfo.Tables("BJItem")
                dgvItem.Columns("MoveOrder").Visible = False
                dgvItem.Columns("PickedQty").Visible = False
                dgvItem.Columns("Remarks").Visible = False
                dgvItem.Columns("BJ").Visible = False
                dgvItem.Columns("ChangedOn").Visible = False
                dgvItem.Columns("ChangedBy").Visible = False

                Dim cm As CurrencyManager
                cm = CType(BindingContext(dgvItem.DataSource, dgvItem.DataMember), CurrencyManager)
                CType(cm.List, DataView).RowFilter = "BJ= '" & dgvHeader.Rows(RowIndexSLED).Cells("BJ").Value & "'"
                'dgvHeader.DataMember = "BJHeader"
                'dgvItem.DataSource = BJ_Rs.BJInfo.Tables("BJItem")
                'dgvItem.Columns("MoveOrder").Visible = False
                'dgvItem.Columns("PickedQty").Visible = False
                'dgvItem.Columns("Remarks").Visible = False
                'dgvItem.Columns("BJ").Visible = False
                'dgvItem.Columns("ChangedOn").Visible = False
                'dgvItem.Columns("ChangedBy").Visible = False
                'dgvItem.DataMember = "BJItem"

                Me.ShowMessage("^APP-16@", eTraceUI.eTraceMessageBar.MessageTypes.Information, AnimationStatus.StopAnim)
            End If
        Catch ex As Exception
            eTraceWS.ErrorLogging("BJManagement-bgwCreateBJ_RunWorkerCompleted", ERPLogin.User, ex.Message)
            Me.ShowMessage("^BJM-13@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim)
        End Try
    End Sub

    Private Sub dgvHeader_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvHeader.CellClick
        Try
            Dim cm As CurrencyManager
            RowIndexSLED = dgvHeader.CurrentCell.RowIndex
            'dgvLabels.DataSource = MRListData
            'dgvLabels.DataMember = "CLIDTable"
            'dgvLabels.Columns("InvID").Visible = False
            'dgvLabels.Columns("Line").Visible = False
            dgvItem.DataSource = BJ_Rs.BJInfo.Tables("BJItem")
            dgvItem.Columns("MoveOrder").Visible = False
            dgvItem.Columns("PickedQty").Visible = False
            dgvItem.Columns("Remarks").Visible = False
            dgvItem.Columns("BJ").Visible = False
            dgvItem.Columns("ChangedOn").Visible = False
            dgvItem.Columns("ChangedBy").Visible = False

            cm = CType(BindingContext(dgvItem.DataSource, dgvItem.DataMember), CurrencyManager)
            CType(cm.List, DataView).RowFilter = "BJ= '" & dgvHeader.Rows(RowIndexSLED).Cells("BJ").Value & "'"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvHeader_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvHeader.SelectionChanged
        Try
            Dim cm As CurrencyManager
            If dgvHeader.SelectedRows.Count = 1 Then
                RowIndexSLED = dgvHeader.SelectedCells(0).RowIndex
                'dgvLabels.DataSource = MRListData
                'dgvLabels.DataMember = "CLIDTable"
                'dgvLabels.Columns("InvID").Visible = False
                'dgvLabels.Columns("Line").Visible = False
                dgvItem.DataSource = BJ_Rs.BJInfo.Tables("BJItem")
                dgvItem.Columns("MoveOrder").Visible = False
                dgvItem.Columns("PickedQty").Visible = False
                dgvItem.Columns("Remarks").Visible = False
                dgvItem.Columns("BJ").Visible = False
                dgvItem.Columns("ChangedOn").Visible = False
                dgvItem.Columns("ChangedBy").Visible = False

                cm = CType(BindingContext(dgvItem.DataSource, dgvItem.DataMember), CurrencyManager)
                CType(cm.List, DataView).RowFilter = "BJ= '" & dgvHeader.Rows(RowIndexSLED).Cells("BJ").Value & "'"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If btnSave.Enabled Then
            If Me.ShowMessage("^REC-4@", eTraceUI.eTraceMessageBar.MessageTypes.Information, AnimationStatus.NoChange, True, PopUpTypes.Question) = False Then
                Me.ShowMessage("^APP-16@", eTraceUI.eTraceMessageBar.MessageTypes.NoMessage, AnimationStatus.StopAnim)
                Me.DisableValidation = False
                Exit Sub
            End If
        End If
        ResetScreen()
    End Sub

    Private Sub ResetScreen()
        Try
            grpInput.Enabled = True
            grpHeader.Enabled = True
            grpItem.Enabled = True
            grpActions.Enabled = True

            txtDJ.Text = ""
            BJ_Create = False
            DJ_Valid = False
            txtDJ.Enabled = True
            btnCreate.Enabled = True
            btnShow.Enabled = True
            cbxOnlyOpen.Enabled = True

            BJds = New DataSet
            If Not BJ_Rs Is Nothing Then
                BJ_Rs.BJInfo.Clear()
            End If
            BJ_Rs.ErrMsg = ""
            BJ_Rs.Flag = ""

            txtDJ.Focus()
            'dgvHeader.DataSource = Nothing
            'dgvItem.DataSource = Nothing

            'dgvHeader.DataSource = BJds
            'dgvItem.DataSource = BJds
            Me.ShowMessage("^APP-16@", eTraceUI.eTraceMessageBar.MessageTypes.NoMessage, AnimationStatus.StopAnim)
            'Me.txtProdFloor.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvHeader_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvHeader.DataError
        Try
            If e.RowIndex >= 0 Then
                If e.ColumnIndex = 7 Then
                    Me.ShowMessage("^BJM-44@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                    Exit Sub
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvHeader_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvHeader.CellBeginEdit
        BJ_Tmp = New DataSet
        BJ_Tmp = BJ_Rs.BJInfo.Copy
    End Sub

    Private Sub dgvHeader_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvHeader.CellValueChanged
        Try
            Dim QtyDiff As Decimal
            Dim DR() As DataRow

            If e.RowIndex >= 0 Then
                Select Case e.ColumnIndex
                    Case 6   'TotalCmpQty
                        If FixNull(dgvHeader.Rows(e.RowIndex).Cells("CmpQty").Value) <> "" Then
                            'If IsNumeric(FixNull(dgvHeader.Rows(e.RowIndex).Cells("CmpQty").Value)) = False Then
                            '    dgvHeader.Rows(e.RowIndex).Cells("CmpQty").Value = 0
                            '    Exit Sub
                            'End If
                            If dgvHeader.Rows(e.RowIndex).Cells("CmpQty").Value < 0 Then
                                Me.ShowMessage("^BJM-29@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                                dgvHeader.Rows(e.RowIndex).Cells("CmpQty").Value = BJ_Tmp.Tables("BJHeader").Rows(e.RowIndex)("CmpQty")
                                'dgvHeader.Rows(e.RowIndex).Cells("CmpQty").Value = 0
                                Exit Sub
                            End If

                            QtyDiff = dgvHeader.Rows(e.RowIndex).Cells("BJQty").Value - dgvHeader.Rows(e.RowIndex).Cells("CmpQty").Value
                            If QtyDiff < 0 Then
                                Me.ShowMessage("^BJM-16@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                                dgvHeader.Rows(e.RowIndex).Cells("CmpQty").Value = BJ_Tmp.Tables("BJHeader").Rows(e.RowIndex)("CmpQty")
                                'dgvHeader.Rows(e.RowIndex).Cells("CmpQty").Value = 0
                                Exit Sub
                            End If

                            If dgvHeader.Rows(e.RowIndex).Cells("CmpQty").Value = dgvHeader.Rows(e.RowIndex).Cells("BJQty").Value Then
                                dgvHeader.Rows(e.RowIndex).Cells("Status").Value = "Completed"
                                dgvHeader.Rows(e.RowIndex).Cells("SchDate").Value = Date.Now
                            End If

                            If dgvHeader.Rows(e.RowIndex).Cells("CmpQty").Value < dgvHeader.Rows(e.RowIndex).Cells("BJQty").Value Then
                                dgvHeader.Rows(e.RowIndex).Cells("Status").Value = "In-Progress"
                            End If
                        End If
                    Case 7   'CurCmpQty
                        If dgvHeader.Rows(e.RowIndex).Cells("CurCmpQty") Is DBNull.Value OrElse FixNull(dgvHeader.Rows(e.RowIndex).Cells("CmpQty").Value) = "" Then
                            dgvHeader.Rows(e.RowIndex).Cells("CurCmpQty").Value = 0
                            Exit Sub
                        End If

                        If FixNull(dgvHeader.Rows(e.RowIndex).Cells("CurCmpQty").Value) <> "" Then
                            'If IsNumeric(FixNull(dgvHeader.Rows(e.RowIndex).Cells("CmpQty").Value)) = False Then
                            '    dgvHeader.Rows(e.RowIndex).Cells("CmpQty").Value = 0
                            '    Exit Sub
                            'End If
                            If dgvHeader.Rows(e.RowIndex).Cells("CurCmpQty").Value + BJ_Initial.Tables("BJHeader").Rows(e.RowIndex)("CmpQty") < 0 Then
                                Me.ShowMessage("^BJM-45@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                                dgvHeader.Rows(e.RowIndex).Cells("CurCmpQty").Value = 0
                                'dgvHeader.Rows(e.RowIndex).Cells("CmpQty").Value = 0
                                Exit Sub
                            End If

                            If dgvHeader.Rows(e.RowIndex).Cells("CurCmpQty").Value + BJ_Initial.Tables("BJHeader").Rows(e.RowIndex)("CmpQty") > dgvHeader.Rows(e.RowIndex).Cells("BJQty").Value Then
                                Me.ShowMessage("^BJM-46@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                                dgvHeader.Rows(e.RowIndex).Cells("CurCmpQty").Value = 0
                                'dgvHeader.Rows(e.RowIndex).Cells("CmpQty").Value = 0
                                Exit Sub
                            End If

                            dgvHeader.Rows(e.RowIndex).Cells("CmpQty").Value = dgvHeader.Rows(e.RowIndex).Cells("CurCmpQty").Value + BJ_Initial.Tables("BJHeader").Rows(e.RowIndex)("CmpQty")

                            If dgvHeader.Rows(e.RowIndex).Cells("CmpQty").Value <> BJ_Initial.Tables("BJHeader").Rows(e.RowIndex)("CmpQty") Then
                                BJ_Rs.BJInfo.Tables("BJHeader").Rows(e.RowIndex)("ChangedON") = DateTime.Now
                                BJ_Rs.BJInfo.Tables("BJHeader").Rows(e.RowIndex)("ChangedBy") = ERPLogin.User
                            End If
                        End If
                    Case 8    'Status
                        If dgvHeader.Rows(e.RowIndex).Cells("Status").Value = "Completed" AndAlso dgvHeader.Rows(e.RowIndex).Cells("BJQty").Value <> dgvHeader.Rows(e.RowIndex).Cells("CmpQty").Value Then
                            Me.ShowMessage("^BJM-33@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                            dgvHeader.Rows(e.RowIndex).Cells("Status").Value = BJ_Tmp.Tables("BJHeader").Rows(e.RowIndex)("Status")
                            Exit Sub
                        End If

                        If dgvHeader.Rows(e.RowIndex).Cells("Status").Value = "Released" AndAlso dgvHeader.Rows(e.RowIndex).Cells("CmpQty").Value > 0 Then
                            Me.ShowMessage("^BJM-31@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                            dgvHeader.Rows(e.RowIndex).Cells("Status").Value = BJ_Tmp.Tables("BJHeader").Rows(e.RowIndex)("Status")
                            Exit Sub
                        End If

                        If dgvHeader.Rows(e.RowIndex).Cells("Status").Value = "In-Progress" Then
                            'If dgvHeader.Rows(e.RowIndex).Cells("CmpQty").Value = 0 Then
                            '    Me.ShowMessage("^BJM-34@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                            '    dgvHeader.Rows(e.RowIndex).Cells("Status").Value = BJ_Tmp.Tables("BJHeader").Rows(e.RowIndex)("Status")
                            '    Exit Sub
                            'End If

                            If dgvHeader.Rows(e.RowIndex).Cells("CmpQty").Value = dgvHeader.Rows(e.RowIndex).Cells("BJQty").Value Then
                                Me.ShowMessage("^BJM-35@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                                dgvHeader.Rows(e.RowIndex).Cells("Status").Value = BJ_Tmp.Tables("BJHeader").Rows(e.RowIndex)("Status")
                                Exit Sub
                            End If
                        End If

                        If dgvHeader.Rows(e.RowIndex).Cells("Status").Value = "Cancelled" AndAlso BJ_Tmp.Tables("BJHeader").Rows(e.RowIndex)("Status") <> "Cancelled" Then
                            'If dgvHeader.Rows(e.RowIndex).Cells("BJQty").Value = dgvHeader.Rows(e.RowIndex).Cells("CmpQty").Value Then
                            '    Me.ShowMessage("^BJM-36@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                            '    dgvHeader.Rows(e.RowIndex).Cells("Status").Value = BJ_Tmp.Tables("BJHeader").Rows(e.RowIndex)("Status")
                            '    Exit Sub
                            'End If

                            If Me.ShowMessage("^BJM-32@", eTraceUI.eTraceMessageBar.MessageTypes.Information, AnimationStatus.NoChange, True, PopUpTypes.Question) = True Then

                            Else
                                dgvHeader.Rows(e.RowIndex).Cells("Status").Value = BJ_Tmp.Tables("BJHeader").Rows(e.RowIndex)("Status")
                                Exit Sub
                            End If
                        End If

                        If dgvHeader.Rows(e.RowIndex).Cells("Status").Value <> BJ_Tmp.Tables("BJHeader").Rows(e.RowIndex)("Status") Then
                            BJ_Rs.BJInfo.Tables("BJHeader").Rows(e.RowIndex)("ChangedON") = DateTime.Now
                            BJ_Rs.BJInfo.Tables("BJHeader").Rows(e.RowIndex)("ChangedBy") = ERPLogin.User
                        End If
                    Case 9     'SchDate
                        If FixNull(dgvHeader.Rows(e.RowIndex).Cells("SchDate").Value) < Date.Now.Date Then
                            Me.ShowMessage("^BJM-17@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                            dgvHeader.Rows(e.RowIndex).Cells("SchDate").Value = Date.Now.Date
                            Exit Sub
                        Else
                            If dgvHeader.Rows(e.RowIndex).Cells("SchDate").Value <> BJ_Tmp.Tables("BJHeader").Rows(e.RowIndex)("SchDate") Then
                                BJ_Rs.BJInfo.Tables("BJHeader").Rows(e.RowIndex)("ChangedON") = DateTime.Now
                                BJ_Rs.BJInfo.Tables("BJHeader").Rows(e.RowIndex)("ChangedBy") = ERPLogin.User
                            End If
                        End If
                    Case 10     'Remarks
                        If dgvHeader.Rows(e.RowIndex).Cells("Remarks").Value <> BJ_Tmp.Tables("BJHeader").Rows(e.RowIndex)("Remarks") Then
                            BJ_Rs.BJInfo.Tables("BJHeader").Rows(e.RowIndex)("ChangedON") = DateTime.Now
                            BJ_Rs.BJInfo.Tables("BJHeader").Rows(e.RowIndex)("ChangedBy") = ERPLogin.User
                        End If
                End Select

                Me.ShowMessage("^APP-16@", eTraceUI.eTraceMessageBar.MessageTypes.Information, AnimationStatus.NoChange)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddHeaderTable()
        Dim BJHeader As Data.DataTable = New System.Data.DataTable("BJHeader")

        Dim ProdLine As DataColumn = New DataColumn("ProdLine", System.Type.GetType("System.String"))
        BJHeader.Columns.Add(ProdLine)
        Dim DJ As DataColumn = New DataColumn("DJ", System.Type.GetType("System.String"))
        BJHeader.Columns.Add(DJ)
        Dim TLA As DataColumn = New DataColumn("TLA", System.Type.GetType("System.String"))
        BJHeader.Columns.Add(TLA)
        'Dim DJQty As DataColumn = New DataColumn("DJQty", System.Type.GetType("System.Decimal"))
        'BJHeader.Columns.Add(DJQty)
        Dim BJ As DataColumn = New DataColumn("BJ", System.Type.GetType("System.String"))
        BJHeader.Columns.Add(BJ)
        Dim BPA As DataColumn = New DataColumn("BPA", System.Type.GetType("System.String"))
        BJHeader.Columns.Add(BPA)
        Dim BJQty As DataColumn = New DataColumn("BJQty", System.Type.GetType("System.Decimal"))
        BJHeader.Columns.Add(BJQty)
        Dim CmpQty As DataColumn = New DataColumn("CmpQty", System.Type.GetType("System.Decimal"))
        BJHeader.Columns.Add(CmpQty)
        Dim CurCmpQty As DataColumn = New DataColumn("CurCmpQty", System.Type.GetType("System.Decimal"))
        BJHeader.Columns.Add(CurCmpQty)
        Dim Status As DataColumn = New DataColumn("Status", System.Type.GetType("System.String"))
        BJHeader.Columns.Add(Status)
        Dim SchDate As DataColumn = New DataColumn("SchDate", System.Type.GetType("System.DateTime"))
        BJHeader.Columns.Add(SchDate)
        Dim Remarks As DataColumn = New DataColumn("Remarks", System.Type.GetType("System.String"))
        BJHeader.Columns.Add(Remarks)

        Dim DJReleasedDate As DataColumn = New DataColumn("DJReleasedDate", System.Type.GetType("System.DateTime"))
        BJHeader.Columns.Add(DJReleasedDate)
        Dim PWC As DataColumn = New DataColumn("PWC", System.Type.GetType("System.String"))
        BJHeader.Columns.Add(PWC)
        Dim PWCSubInv As DataColumn = New DataColumn("PWCSubInv", System.Type.GetType("System.String"))
        BJHeader.Columns.Add(PWCSubInv)
        Dim PWCLocator As DataColumn = New DataColumn("PWCLocator", System.Type.GetType("System.String"))
        BJHeader.Columns.Add(PWCLocator)
        Dim TLASubInv As DataColumn = New DataColumn("TLASubInv", System.Type.GetType("System.String"))
        BJHeader.Columns.Add(TLASubInv)
        Dim TLALocator As DataColumn = New DataColumn("TLALocator", System.Type.GetType("System.String"))
        BJHeader.Columns.Add(TLALocator)
        Dim CreatedOn As DataColumn = New DataColumn("CreatedOn", System.Type.GetType("System.DateTime"))
        BJHeader.Columns.Add(CreatedOn)
        Dim CreatedBy As DataColumn = New DataColumn("CreatedBy", System.Type.GetType("System.String"))
        BJHeader.Columns.Add(CreatedBy)
        Dim ChangedOn As DataColumn = New DataColumn("ChangedOn", System.Type.GetType("System.DateTime"))
        BJHeader.Columns.Add(ChangedOn)
        Dim ChangedBy As DataColumn = New DataColumn("ChangedBy", System.Type.GetType("System.String"))
        BJHeader.Columns.Add(ChangedBy)
        Dim OpenQty As DataColumn = New DataColumn("OpenQty", System.Type.GetType("System.Decimal"))
        BJHeader.Columns.Add(OpenQty)

        BJds.Tables.Add(BJHeader)
    End Sub

    Private Sub AddItemTable()
        Dim BJItem As Data.DataTable = New Data.DataTable("BJItem")

        Dim Item As DataColumn = New DataColumn("Item", System.Type.GetType("System.String"))
        BJItem.Columns.Add(Item)
        Dim ProcessCode As DataColumn = New DataColumn("ProcessCode", System.Type.GetType("System.String"))
        BJItem.Columns.Add(ProcessCode)
        Dim Usage As DataColumn = New DataColumn("Usage", System.Type.GetType("System.Decimal"))
        BJItem.Columns.Add(Usage)
        Dim ReqQty As DataColumn = New DataColumn("ReqQty", System.Type.GetType("System.Decimal"))
        BJItem.Columns.Add(ReqQty)
        Dim SupplyType As DataColumn = New DataColumn("SupplyType", System.Type.GetType("System.String"))
        BJItem.Columns.Add(SupplyType)

        Dim MoveOrder As DataColumn = New DataColumn("MoveOrder", System.Type.GetType("System.String"))
        BJItem.Columns.Add(MoveOrder)
        Dim PickedQty As DataColumn = New DataColumn("PickedQty", System.Type.GetType("System.Decimal"))
        BJItem.Columns.Add(PickedQty)
        Dim Remarks As DataColumn = New DataColumn("Remarks", System.Type.GetType("System.String"))
        BJItem.Columns.Add(Remarks)

        Dim BJ As DataColumn = New DataColumn("BJ", System.Type.GetType("System.String"))
        BJItem.Columns.Add(BJ)
        Dim ChangedOn As DataColumn = New DataColumn("ChangedOn", System.Type.GetType("System.DateTime"))
        BJItem.Columns.Add(ChangedOn)
        Dim ChangedBy As DataColumn = New DataColumn("ChangedBy", System.Type.GetType("System.String"))
        BJItem.Columns.Add(ChangedBy)

        BJds.Tables.Add(BJItem)
    End Sub

    Private Sub AddExcelTable()
        Dim ExcelItem As Data.DataTable = New Data.DataTable("ExcelItem")

        Dim ProdLine As DataColumn = New DataColumn("ProdLine", System.Type.GetType("System.String"))
        ExcelItem.Columns.Add(ProdLine)
        Dim TLA As DataColumn = New DataColumn("TLA", System.Type.GetType("System.String"))
        ExcelItem.Columns.Add(TLA)
        Dim DJ As DataColumn = New DataColumn("DJ", System.Type.GetType("System.String"))
        ExcelItem.Columns.Add(DJ)
        Dim DJReleasedDate As DataColumn = New DataColumn("DJReleasedDate", System.Type.GetType("System.String"))
        ExcelItem.Columns.Add(DJReleasedDate)
        Dim BJ As DataColumn = New DataColumn("BJ", System.Type.GetType("System.String"))
        ExcelItem.Columns.Add(BJ)
        Dim BJQty As DataColumn = New DataColumn("BJQty", System.Type.GetType("System.Decimal"))
        ExcelItem.Columns.Add(BJQty)
        Dim CmpQty As DataColumn = New DataColumn("CmpQty", System.Type.GetType("System.Decimal"))
        ExcelItem.Columns.Add(CmpQty)
        Dim Status As DataColumn = New DataColumn("Status", System.Type.GetType("System.String"))
        ExcelItem.Columns.Add(Status)
        Dim SchDate As DataColumn = New DataColumn("ScheduleDate", System.Type.GetType("System.String"))
        ExcelItem.Columns.Add(SchDate)
        Dim BPA As DataColumn = New DataColumn("BondPlyAssembly", System.Type.GetType("System.String"))
        ExcelItem.Columns.Add(BPA)
        Dim Item As DataColumn = New DataColumn("Item", System.Type.GetType("System.String"))
        ExcelItem.Columns.Add(Item)
        Dim ProcessCode As DataColumn = New DataColumn("ProcessCode", System.Type.GetType("System.String"))
        ExcelItem.Columns.Add(ProcessCode)
        Dim Usage As DataColumn = New DataColumn("Usage", System.Type.GetType("System.Decimal"))
        ExcelItem.Columns.Add(Usage)
        Dim ReqQty As DataColumn = New DataColumn("ReqQty", System.Type.GetType("System.Decimal"))
        ExcelItem.Columns.Add(ReqQty)
        Dim SupplyType As DataColumn = New DataColumn("SupplyType", System.Type.GetType("System.String"))
        ExcelItem.Columns.Add(SupplyType)

        dsExcel.Tables.Add(ExcelItem)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            'Check if BJ already created by other user
            eTraceWS.Timeout = 1000 * 60 * 30

            If BJ_Create = True Then
                Dim tmp_bj As New MaterialReplenishment.BJ_Rs
                tmp_bj = eTraceWS.CheckBJInfo(txtDJ.Text, ProductionLine(), BJds, ERPLogin)
                If tmp_bj.Flag = "90" Then
                    Me.ShowMessage("^BJM-37@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                    Exit Sub
                Else

                End If
            End If

            If Not BJ_Rs Is Nothing AndAlso Not BJ_Rs.BJInfo Is Nothing AndAlso BJ_Rs.BJInfo.Tables.Count > 0 AndAlso BJ_Rs.BJInfo.Tables(0).Rows.Count > 0 Then
                Me.ShowMessage("^BJM-22@", eTraceUI.eTraceMessageBar.MessageTypes.Information, AnimationStatus.StartAnim)
                grpHeader.Enabled = False
                grpItem.Enabled = False
                grpActions.Enabled = False
                bgwSave.RunWorkerAsync()
            Else
                Me.ShowMessage("^BJM-19@", eTraceUI.eTraceMessageBar.MessageTypes.Abort)
                Exit Sub
            End If
        Catch ex As Exception
            grpHeader.Enabled = True
            grpItem.Enabled = True
            grpActions.Enabled = True
            eTraceWS.ErrorLogging("BJM-btnSave_Click", ERPLogin.User.ToUpper, ex.Message & ex.Source)
        End Try
    End Sub

    Private Sub bgwSave_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwSave.DoWork
        Try
            eTraceWS.Timeout = 1000 * 60 * 30
            e.Result = eTraceWS.BJ_SaveChange(BJ_Rs.BJInfo, BJ_Initial, txtDJ.Text, BJ_Create, ERPLogin)
        Catch ex As Exception
            eTraceWS.ErrorLogging("BJM-bgwPost_DoWork", ERPLogin.User.ToUpper, ex.Message & ex.Source)
        End Try
    End Sub

    Private Sub bgwSave_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwSave.RunWorkerCompleted
        Try
            If e.Result = "" Then
                Me.ShowMessage("^BJM-20@", eTraceUI.eTraceMessageBar.MessageTypes.Information, AnimationStatus.StopAnim, True)
            Else
                If e.Result = "BJs already generated for this DJ by somebody." Then
                    Me.ShowMessage("^BJM-37@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                Else
                    Me.ShowMessage("^BJM-21@" & e.Result.ToString, eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                End If
                grpHeader.Enabled = True
                grpItem.Enabled = True
                grpActions.Enabled = True
                Exit Sub
            End If

            BJ_Rs = eTraceWS.BJ_GetBJ(txtDJ.Text.Trim.ToUpper, ProductionLine(), BJds, cbxOnlyOpen.Checked, ERPLogin)
            BJ_Create = False

            If BJ_Rs.Flag <> "0" Then
                'No BJ record return, might all completed/cancelled, no open.
                dgvHeader.DataSource = BJ_Rs.BJInfo.Tables("BJHeader")
                dgvHeader.Columns("DJReleasedDate").Visible = False
                dgvHeader.Columns("PWC").Visible = False
                dgvHeader.Columns("PWCSubInv").Visible = False
                dgvHeader.Columns("PWCLocator").Visible = False
                dgvHeader.Columns("TLASubInv").Visible = False
                dgvHeader.Columns("TLALocator").Visible = False
                dgvHeader.Columns("CreatedOn").Visible = False
                dgvHeader.Columns("CreatedBy").Visible = False
                dgvHeader.Columns("ChangedOn").Visible = False
                dgvHeader.Columns("ChangedBy").Visible = False
                dgvHeader.Columns("OpenQty").Visible = False

                dgvItem.DataSource = BJ_Rs.BJInfo.Tables("BJItem")
                dgvItem.Columns("MoveOrder").Visible = False
                dgvItem.Columns("PickedQty").Visible = False
                dgvItem.Columns("Remarks").Visible = False
                dgvItem.Columns("BJ").Visible = False
                dgvItem.Columns("ChangedOn").Visible = False
                dgvItem.Columns("ChangedBy").Visible = False
            Else
                BJ_Initial = New DataSet
                BJ_Initial = BJ_Rs.BJInfo.Copy

                dgvHeader.DataSource = BJ_Rs.BJInfo.Tables("BJHeader")
                dgvHeader.Columns("DJReleasedDate").Visible = False
                dgvHeader.Columns("PWC").Visible = False
                dgvHeader.Columns("PWCSubInv").Visible = False
                dgvHeader.Columns("PWCLocator").Visible = False
                dgvHeader.Columns("TLASubInv").Visible = False
                dgvHeader.Columns("TLALocator").Visible = False
                dgvHeader.Columns("CreatedOn").Visible = False
                dgvHeader.Columns("CreatedBy").Visible = False
                dgvHeader.Columns("ChangedOn").Visible = False
                dgvHeader.Columns("ChangedBy").Visible = False
                dgvHeader.Columns("OpenQty").Visible = False

                dgvHeader.Rows(0).Selected = True
                RowIndexSLED = dgvHeader.SelectedCells(0).RowIndex
                'dgvLabels.DataSource = MRListData
                'dgvLabels.DataMember = "CLIDTable"
                'dgvLabels.Columns("InvID").Visible = False
                'dgvLabels.Columns("Line").Visible = False
                dgvItem.DataSource = BJ_Rs.BJInfo.Tables("BJItem")
                dgvItem.Columns("MoveOrder").Visible = False
                dgvItem.Columns("PickedQty").Visible = False
                dgvItem.Columns("Remarks").Visible = False
                dgvItem.Columns("BJ").Visible = False
                dgvItem.Columns("ChangedOn").Visible = False
                dgvItem.Columns("ChangedBy").Visible = False

                Dim cm As CurrencyManager
                cm = CType(BindingContext(dgvItem.DataSource, dgvItem.DataMember), CurrencyManager)
                CType(cm.List, DataView).RowFilter = "BJ= '" & dgvHeader.Rows(RowIndexSLED).Cells("BJ").Value & "'"
                'dgvHeader.DataMember = "BJHeader"
                'dgvItem.DataSource = BJ_Rs.BJInfo.Tables("BJItem")
                'dgvItem.Columns("MoveOrder").Visible = False
                'dgvItem.Columns("PickedQty").Visible = False
                'dgvItem.Columns("Remarks").Visible = False
                'dgvItem.Columns("BJ").Visible = False
                'dgvItem.Columns("ChangedOn").Visible = False
                'dgvItem.Columns("ChangedBy").Visible = False
                'dgvItem.DataMember = "BJItem"
            End If
            grpHeader.Enabled = True
            grpItem.Enabled = True
            grpActions.Enabled = True

        Catch ex As Exception
            grpHeader.Enabled = True
            grpItem.Enabled = True
            grpActions.Enabled = True
            eTraceWS.ErrorLogging("BJM-bgwSave_RunWorkerCompleted", ERPLogin.User.ToUpper, ex.Message & ex.Source)
        End Try
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Try
            If DJ_Valid = True Then
                Exit Sub
            End If

            If BJds Is Nothing OrElse BJds.Tables.Count = 0 Then
                BJds = New DataSet
                dsExcel = New DataSet
                AddHeaderTable()
                AddItemTable()
                AddExcelTable()
            End If

            txtDJ.Enabled = False
            btnCreate.Enabled = False
            btnShow.Enabled = False
            cbxOnlyOpen.Enabled = False
            grpInput.Enabled = False
            'grpActions.Enabled = False
            'grpHeader.Enabled = False
            'grpItem.Enabled = False
            grpHeader.Visible = False
            grpItem.Visible = False
            grpActions.Visible = False
            'btnSave.Visible = False
            'btnClear.Visible = False
            'btnExcel.Visible = False
            'btnMO.Visible = True

            BJ_Rs = New MaterialReplenishment.BJ_Rs
            Me.ShowMessage("^BJM-24@", eTraceUI.eTraceMessageBar.MessageTypes.Information, AnimationStatus.StartAnim)
            bgwShow.RunWorkerAsync()

        Catch ex As Exception
            eTraceWS.ErrorLogging("BJManagement-btnShow_Click", ERPLogin.User.ToUpper, ex.Message & ex.Source)
            Me.ShowMessage(ex.Message, eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
        End Try
    End Sub

    Private Sub bgwShow_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwShow.DoWork
        Dim DJInfo As New DataSet
        Try
            eTraceWS.Timeout = 1000 * 60 * 30
            BJ_Rs = eTraceWS.BJ_GetBJ(txtDJ.Text.Trim.ToUpper, ProductionLine(), BJds, cbxOnlyOpen.Checked, ERPLogin)
        Catch ex As Exception
            eTraceWS.ErrorLogging("BJManagement-bgwShow_DoWork", ERPLogin.User.ToUpper, ex.Message & ex.Source)
            BJ_Rs.BJInfo = Nothing
            BJ_Rs.Flag = "3"
            BJ_Rs.ErrMsg = ex.Message & ex.Source
        End Try
    End Sub

    Private Sub bgwShow_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwShow.RunWorkerCompleted
        Try
            If BJ_Rs.Flag <> "0" Then
                txtDJ.Enabled = True
                btnCreate.Enabled = True
                btnShow.Enabled = True
                cbxOnlyOpen.Enabled = True
                grpInput.Enabled = True
                'grpActions.Enabled = True
                'grpHeader.Enabled = True
                'grpItem.Enabled = True
                If BJ_Rs.Flag = "1" Then
                    Me.ShowMessage("^BJM-26@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                ElseIf BJ_Rs.Flag = "2" Then
                    Me.ShowMessage("^BJM-27@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                ElseIf BJ_Rs.Flag = "3" Then
                    Me.ShowMessage("^BJM-27@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
                End If
                If txtDJ.Text <> "" Then
                    txtDJ.BackColor = Color.DarkOrange
                    txtDJ.Focus()
                End If
            Else
                BJ_Create = False
                txtDJ.Enabled = False
                btnCreate.Enabled = False
                btnShow.Enabled = False
                cbxOnlyOpen.Enabled = False
                grpInput.Enabled = True
                'grpActions.Enabled = True
                'grpHeader.Enabled = True
                'grpItem.Enabled = True
                grpHeader.Visible = True
                grpItem.Visible = True
                grpActions.Visible = True
                'btnSave.Visible = True
                'btnClear.Visible = True
                'btnExcel.Visible = True
                'btnMO.Visible = True

                'BJ_Tmp = New DataSet
                'BJ_Tmp = BJ_Rs.BJInfo.Copy
                BJ_Initial = New DataSet
                BJ_Initial = BJ_Rs.BJInfo.Copy

                'dgvHeader.DataSource = Nothing
                dgvHeader.DataSource = BJ_Rs.BJInfo.Tables("BJHeader")
                'dgvHeader.AutoGenerateColumns = False

                dgvHeader.Columns("DJReleasedDate").Visible = False
                dgvHeader.Columns("PWC").Visible = False
                dgvHeader.Columns("PWCSubInv").Visible = False
                dgvHeader.Columns("PWCLocator").Visible = False
                dgvHeader.Columns("TLASubInv").Visible = False
                dgvHeader.Columns("TLALocator").Visible = False
                dgvHeader.Columns("CreatedOn").Visible = False
                dgvHeader.Columns("CreatedBy").Visible = False
                dgvHeader.Columns("ChangedOn").Visible = False
                dgvHeader.Columns("ChangedBy").Visible = False
                dgvHeader.Columns("OpenQty").Visible = False

                dgvHeader.Rows(0).Selected = True
                RowIndexSLED = dgvHeader.SelectedCells(0).RowIndex
                'dgvLabels.DataSource = MRListData
                'dgvLabels.DataMember = "CLIDTable"
                'dgvLabels.Columns("InvID").Visible = False
                'dgvLabels.Columns("Line").Visible = False
                dgvItem.DataSource = BJ_Rs.BJInfo.Tables("BJItem")
                dgvItem.Columns("MoveOrder").Visible = False
                dgvItem.Columns("PickedQty").Visible = False
                dgvItem.Columns("Remarks").Visible = False
                dgvItem.Columns("BJ").Visible = False
                dgvItem.Columns("ChangedOn").Visible = False
                dgvItem.Columns("ChangedBy").Visible = False

                Dim cm As CurrencyManager
                cm = CType(BindingContext(dgvItem.DataSource, dgvItem.DataMember), CurrencyManager)
                CType(cm.List, DataView).RowFilter = "BJ= '" & dgvHeader.Rows(RowIndexSLED).Cells("BJ").Value & "'"
                'dgvHeader.DataMember = "BJHeader"
                'dgvItem.DataSource = BJ_Rs.BJInfo.Tables("BJItem")
                'dgvItem.Columns("MoveOrder").Visible = False
                'dgvItem.Columns("PickedQty").Visible = False
                'dgvItem.Columns("Remarks").Visible = False
                'dgvItem.Columns("BJ").Visible = False
                'dgvItem.Columns("ChangedOn").Visible = False
                'dgvItem.Columns("ChangedBy").Visible = False
                'dgvItem.DataMember = "BJItem"

                Me.ShowMessage("^BJM-25@", eTraceUI.eTraceMessageBar.MessageTypes.Information, AnimationStatus.StopAnim)
            End If
        Catch ex As Exception
            eTraceWS.ErrorLogging("BJManagement-bgwCreateBJ_RunWorkerCompleted", ERPLogin.User, ex.Message)
            Me.ShowMessage("^BJM-27@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim)
        End Try

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Try
            If Not BJ_Rs Is Nothing AndAlso Not BJ_Rs.BJInfo Is Nothing AndAlso BJ_Rs.BJInfo.Tables.Count > 0 AndAlso BJ_Rs.BJInfo.Tables(0).Rows.Count > 0 Then

            Else
                Me.ShowMessage("^BJM-23@", eTraceUI.eTraceMessageBar.MessageTypes.Abort)
                Exit Sub
            End If

            Dim i As Integer
            Dim dr_Excel() As DataRow = Nothing
            Dim dr As DataRow
            dsExcel.Tables("ExcelItem").Clear()
            For i = 0 To BJ_Rs.BJInfo.Tables("BJHeader").Rows.Count - 1
                dr_Excel = BJ_Rs.BJInfo.Tables("BJItem").Select(" BJ = '" & BJ_Rs.BJInfo.Tables("BJHeader").Rows(i)("BJ") & "'")
                If dr_Excel.Length > 0 Then
                    For Each drExcel As DataRow In dr_Excel
                        dr = dsExcel.Tables("ExcelItem").NewRow
                        dr("ProdLine") = BJ_Rs.BJInfo.Tables("BJHeader").Rows(i)("ProdLine")
                        dr("TLA") = BJ_Rs.BJInfo.Tables("BJHeader").Rows(i)("TLA")
                        dr("DJ") = BJ_Rs.BJInfo.Tables("BJHeader").Rows(i)("DJ")
                        dr("DJReleasedDate") = FixNull(BJ_Rs.BJInfo.Tables("BJHeader").Rows(i)("DJReleasedDate"))
                        dr("BJ") = BJ_Rs.BJInfo.Tables("BJHeader").Rows(i)("BJ")
                        dr("BJQty") = BJ_Rs.BJInfo.Tables("BJHeader").Rows(i)("BJQty")
                        dr("CmpQty") = BJ_Rs.BJInfo.Tables("BJHeader").Rows(i)("CmpQty")
                        dr("Status") = BJ_Rs.BJInfo.Tables("BJHeader").Rows(i)("Status")
                        dr("ScheduleDate") = BJ_Rs.BJInfo.Tables("BJHeader").Rows(i)("SchDate")
                        dr("BondPlyAssembly") = BJ_Rs.BJInfo.Tables("BJHeader").Rows(i)("BPA")
                        dr("Item") = drExcel("Item")
                        dr("ProcessCode") = drExcel("ProcessCode")
                        dr("Usage") = drExcel("Usage")
                        dr("ReqQty") = drExcel("Usage") * BJ_Rs.BJInfo.Tables("BJHeader").Rows(i)("BJQty")
                        dr("SupplyType") = drExcel("SupplyType")
                        dsExcel.Tables("ExcelItem").Rows.Add(dr)
                    Next
                End If
            Next

            'Dim xlapp As New Excel.Application
            'Dim workbooks As Excel.Workbook
            Dim xlapp As New Microsoft.Office.Interop.Excel.Application
            Dim workbooks As Microsoft.Office.Interop.Excel.Workbook

            Dim filename As String
            Dim xlXmlLoadImportToList As LoadOption = LoadOption.PreserveChanges

            xlapp = CreateObject("Excel.Application")

            'xlXmlLoadImportToList()
            SaveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx"        '"xls files (*.xls)|*.xls"
            SaveFileDialog.FilterIndex = 2
            SaveFileDialog.RestoreDirectory = True
            SaveFileDialog.Title = "SaveAs"
            If SaveFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                ''''''''''''''''' This is to replace file name from xls to xlsx''''''''''''''''''
                filename = Strings.Left(SaveFileDialog.FileName.ToString, InStr(SaveFileDialog.FileName.ToString, ".xls") - 1) + ".xlsx"

                'Dim dsExcel As New DataSet

                'dsExcel = BJ_Rs.BJInfo.Copy
                'dsExcel.Tables("BJItem").Columns.Remove("MoveOrder")
                'dsExcel.Tables("BJItem").Columns.Remove("PickedQty")
                'dsExcel.Tables("BJItem").Columns.Remove("Remarks")
                'dsExcel.Tables("BJItem").Columns.Remove("ChangedOn")
                'dsExcel.Tables("BJItem").Columns.Remove("ChangedBy")
                'GenerateExcel(dsExcel.Tables("BJItem"), filename)
                GenerateExcel(dsExcel.Tables("ExcelItem"), filename)

                'xlapp.Visible = True
                'VarRpt.WriteXml(filename)
                'workbooks = xlapp.Workbooks.OpenXML(Filename:=filename, LoadOption:=xlXmlLoadImportToList)
                'workbooks.Worksheets(1).SavecopyAs(SaveFileDialog.FileName)
                'Kill(filename)
                ''Excel.Workbooks.Close()
                ''Excel.Quit()
                'System.Runtime.InteropServices.Marshal.ReleaseComObject(xlapp)
                'xlapp = Nothing
                'GC.Collect()

                'ExportingCellByCellMethod.ExportToExcel(PIListData, SaveFileDialog.FileName)
            End If
            Me.btnExcel.Enabled = True
            Me.ShowMessage("^MMC-156@", eTraceUI.eTraceMessageBar.MessageTypes.Information, AnimationStatus.StopAnim)
        Catch ex As Exception
            Me.btnExcel.Enabled = True
            eTraceWS.ErrorLogging("PickOrderCreation-btnExcel_Click", ERPLogin.User.ToUpper, ex.Message & ex.Source)
            Me.ShowMessage("^MMC-157@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim)
        End Try
    End Sub

    Private Sub GenerateExcel(ByVal dataToExcel As System.Data.DataTable, ByVal fileName As String)
        ''Dim fileName As String = "ByteOfCode"
        Dim currentDirectorypath As String = Environment.CurrentDirectory
        Dim finalFileNameWithPath As String = String.Empty
        ''fileName = String.Format("{0}_{1}", fileName, DateTime.Now.ToString("dd-MM-yyyy"))
        finalFileNameWithPath = fileName ''String.Format("{0}\{1}.xlsx", currentDirectorypath, fileName)
        'Delete existing file with same file name.            
        If File.Exists(finalFileNameWithPath) Then
            File.Delete(finalFileNameWithPath)
        End If
        Dim newFile As System.IO.FileInfo = New FileInfo(finalFileNameWithPath)
        'Step 1 : Create object of ExcelPackage class and pass file path to constructor.  

        Using pck As New OfficeOpenXml.ExcelPackage(newFile)
            Dim ws As OfficeOpenXml.ExcelWorksheet = pck.Workbook.Worksheets.Add("BJ")
            ws.Cells("A1").LoadFromDataTable(dataToExcel, True)
            pck.Save()
        End Using

        ''Using package = New OfficeOpenXml.ExcelPackage(newFile)
        ''    'Step 2 : Add a new worksheet to ExcelPackage object and give a suitable name                
        ''    Dim worksheet As OfficeOpenXml.ExcelWorksheet = package.Workbook.Worksheets.Add(excelSheetName)
        ''    'Step 3 : Start loading datatable form A1 cell of worksheet.        
        ''    worksheet.Cells("A1").LoadFromDataTable(dataToExcel, True, TableStyles.None)
        ''    'Step 4 : (Optional) Set the file properties like title, author and subject      
        ''    package.Workbook.Properties.Title = "This code is part of tutorials available at http://bytesofcode.hubpages.com"
        ''    package.Workbook.Properties.Author = "Bytes Of Code"
        ''    package.Workbook.Properties.Subject = "Register here for more http://hubpages.com/_bytes/user/new/"
        ''    'Step 5 : Save all changes to ExcelPackage object which will create Excel 2007 file.             
        ''    package.Save()
        ''    MessageBox.Show(String.Format("File name '{0}' generated successfully.", fileName), "File generated successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ''End Using
    End Sub

    Private Sub btnMO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMO.Click
        Try
            If Me.ShowMessage("^BJM-40@", eTraceUI.eTraceMessageBar.MessageTypes.Information, AnimationStatus.NoChange, True, PopUpTypes.Question) = True Then
                Me.ShowMessage("^BJM-41@", eTraceUI.eTraceMessageBar.MessageTypes.Information, AnimationStatus.StartAnim)
                grpHeader.Enabled = False
                grpItem.Enabled = False
                grpActions.Enabled = False
                bgwGenMO.RunWorkerAsync()
            Else
                Me.ShowMessage("^APP-16@", eTraceUI.eTraceMessageBar.MessageTypes.NoMessage, AnimationStatus.StopAnim)
                Exit Sub
            End If
        Catch ex As Exception
            grpHeader.Enabled = True
            grpItem.Enabled = True
            grpActions.Enabled = True
            eTraceWS.ErrorLogging("BJM-btnMO_Click", ERPLogin.User.ToUpper, ex.Message & ex.Source)
        End Try
    End Sub

    Private Sub bgwGenMO_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGenMO.DoWork
        Try
            eTraceWS.Timeout = 1000 * 60 * 30
            e.Result = eTraceWS.BJ_GenMO(ProductionLine(), txtDJ.Text, ERPLogin)
        Catch ex As Exception
            eTraceWS.ErrorLogging("BJM-bgwGenMO_DoWork", ERPLogin.User.ToUpper, ex.Message & ex.Source)
        End Try
    End Sub

    Private Sub bgwGenMO_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGenMO.RunWorkerCompleted
        Try
            If e.Result <> "" Then
                grpHeader.Enabled = True
                grpItem.Enabled = True
                grpActions.Enabled = True
                Me.ShowMessage("^BJM-43@" & e.Result, eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim, True)
            Else
                grpHeader.Enabled = True
                grpItem.Enabled = True
                grpActions.Enabled = True

                Me.ShowMessage("^BJM-42@", eTraceUI.eTraceMessageBar.MessageTypes.Information, AnimationStatus.StopAnim, True)
            End If
        Catch ex As Exception
            eTraceWS.ErrorLogging("BJM-bgwGenMO_RunWorkerCompleted", ERPLogin.User, ex.Message)
            Me.ShowMessage("^BJM-43@", eTraceUI.eTraceMessageBar.MessageTypes.Abort, AnimationStatus.StopAnim)
        End Try
    End Sub
End Class