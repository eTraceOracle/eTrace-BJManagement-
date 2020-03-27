Module Globals
    Public eTraceWS As MaterialReplenishment.eTraceOracleERP = New MaterialReplenishment.eTraceOracleERP
    Public ERPLogin As MaterialReplenishment.ERPLogin = New MaterialReplenishment.ERPLogin
    Public MainFrm As frmMain

    Public Function Get_Len(ByVal x As Decimal) As Integer
        Get_Len = Len(CStr(((x / 1) - (x \ 1)))) - 2
    End Function

    Public Function FixNull(ByVal vMayBeNull As Object) As String
        On Error Resume Next
        FixNull = vbNullString & vMayBeNull
    End Function
    Public Function RoundUD(ByVal numD As Decimal, ByVal places As Integer, ByVal UorD As Boolean) As Decimal
        'UorD - True = up, false = down  
        Dim dr As Decimal
        Try
            Dim r As Decimal = CDec(10 ^ (places + 1)) 'raise to places + 1  
            dr = Math.Truncate(r * numD)
            If UorD Then 'no adjustment for down  
                'up  
                dr += 5
            End If
            dr = Math.Truncate(dr / 10) * 10
            dr = dr / r
        Catch ex As Exception
            Stop
        End Try
        Return dr
    End Function



    '' Comment Section
    '' Purpose:    Rounds a number up
    '' Parameters: num: Double - Number to be rounded up
    '' Returns:    Integer - the number rounded up
    '' Change Log: 
    ''   08-01-08: M. O'Brien - Created
    'Public Function RoundUp(ByVal num As Double) As Integer
    '    Try
    '        'Temp variable to hold the decimal portion of the parameter
    '        Dim temp As Double
    '        'Get the decimal portion
    '        temp = num - Math.Truncate(num)
    '        'If there is a decimal portion then we add 1 to force it to round up
    '        num = IIf(temp > 0, num + 1, num)
    '        'return the truncated version of the double which should be the number rounded up
    '        Return Math.Truncate(num)
    '    Catch ex As Exception
    '        MessageBox.Show("Error occured in: " & ex.StackTrace & vbCrLf & vbCrLf & "Error: " & ex.Message, _
    '            "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return Nothing
    '    End Try
    'End Function
    '' Comment Section
    '' Purpose:    Rounds a number down
    '' Parameters: num: Double - Number to be rounded down
    '' Returns:    Integer - the number rounded down
    '' Change Log: 
    ''   08-01-08: M. O'Brien - Created
    'Public Function RoundDown(ByVal num As Double) As Integer
    '    Try
    '        'return the truncated version of the double which should be the number rounded down
    '        Return Math.Truncate(num)
    '    Catch ex As Exception
    '        MessageBox.Show("Error occured in: " & ex.StackTrace & vbCrLf & vbCrLf & "Error: " & ex.Message, _
    '            "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return Nothing
    '    End Try
    'End Function
End Module
