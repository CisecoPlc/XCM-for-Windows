Imports System.Globalization

Public Class frmMain
    Dim com1 As IO.Ports.SerialPort
    Dim millis As Long
    Dim lastWritten As String
    Dim countSerialMonitor As Integer
    Dim nonNumberEntered As Boolean
    Dim enterPressed As Boolean
    Dim guardChangeOK As Boolean
    Dim XRFVersion As Single
    Dim NodeType As Single
    Dim bUSBVersion As Boolean
    Dim bChanSupported As Boolean


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'lblError.Text = " "      ' clear the error label
        Me.Text += " " & My.Application.Info.Version.ToString
        lblVR.Text = ""
        lblBD.Text = ""
        lblCC.Text = ""
        lblCH.Text = ""
        lblCN.Text = ""
        lblCS.Text = ""
        lblDR.Text = ""
        lblEA.Text = ""
        lblEK.Text = ""
        lblEE.Text = ""
        lblFC.Text = ""
        lblID.Text = ""
        lblI2.Text = ""
        lblNT.Text = ""
        lblPK.Text = ""
        lblPL.Text = ""
        lblRO.Text = ""
        lblSM.Text = ""
        lblFreq.Text = ""

        '######################################################
        Dim buttonToolTip As New ToolTip()
        buttonToolTip.UseFading = True
        buttonToolTip.UseAnimation = True
        buttonToolTip.IsBalloon = True
        buttonToolTip.ShowAlways = True
        buttonToolTip.AutoPopDelay = 15000
        buttonToolTip.InitialDelay = 100
        buttonToolTip.ReshowDelay = 500
        buttonToolTip.IsBalloon = True


        buttonToolTip.ToolTipTitle = "Default node type is normal"
        buttonToolTip.SetToolTip(Label11, "Setting to repeater mode disables the normal serial function and allows for the bridging or extension of networks")



        buttonToolTip.ToolTipTitle = "Default sleep mode is Sleep Off"
        buttonToolTip.SetToolTip(Label14, "Sleep pin high means the device needs a voltage supplied to sleep pin to send to sleep, sleep pin low means you need to pull it to ground")

        '######################################################

        cmbWrapSerialMonitor.Text = 72

    End Sub

    Function OpenSerialPort() As Boolean
        ' open the chosen serial port
        If PortChooser.SelectedItem Is Nothing Then
            outputError("Please select a port")
            Return False
        End If
        Try
            If Not com1 Is Nothing Then com1.Close()
            delay(500)
            com1 = My.Computer.Ports.OpenSerialPort(PortChooser.SelectedItem.ToString, cmbBaudRate.Text)
        Catch
            outputError("Failed to open serial port " & PortChooser.SelectedItem.ToString)
            Return False
        End Try
        Return True
    End Function

    Sub CloseSerialPort()
        ' open the chosen serial port
        com1.Close()
    End Sub

    Sub GetSerialPortNames()
        'Dim TempString As String
        ' Show all available COM ports.
        PortChooser.Items.Clear()
        PortChooser.Items.Add("")
        For Each sp As String In My.Computer.Ports.SerialPortNames
            'TempString = sp
            'If Len(TempString) = 4 Then
            '    TempString = Microsoft.VisualBasic.Right(TempString, 1)
            '    TempString = "COM0" + TempString
            'End If
            'sp = TempString
            PortChooser.Items.Add(sp)
        Next
    End Sub

    Private Sub addToTextbox(ByVal msg As String)
        ' add line to the text box
        rtxtLog.AppendText(msg & vbCrLf)
        ' ensure that the textbox scrolls
        'rtxtLog.SelectionStart = rtxtLog.TextLength
        rtxtLog.ScrollToCaret()
        Application.DoEvents()  ' allow the text box to scroll
    End Sub

    Private Sub outputError(ByVal msg As String)
        ' out put an error to the user
        'lblError.Text = msg
        If msg <> "" Then
            addToTextbox(msg)
        End If
        ToolStripStatusLabel1.Text = msg
    End Sub

    Function ReceiveSerialData(ByVal timeout As Integer) As Char
        Dim Incoming As Char
        Try
            com1.ReadTimeout = timeout
            Incoming = Microsoft.VisualBasic.ChrW(com1.ReadChar())
            Debug.Print(Incoming & ":" & CInt(Microsoft.VisualBasic.AscW(Incoming)))
        Catch ex As TimeoutException
            Incoming = Microsoft.VisualBasic.ChrW(1)
        End Try
        Return Incoming
    End Function

    Private Function EnterAtMode() As Boolean
        Dim c As Char
        OpenSerialPort()
        delay(1200)
        com1.Write(txtGuard.Text)
        com1.Write(txtGuard.Text)
        com1.Write(txtGuard.Text)
        delay(1200)
        While c <> Microsoft.VisualBasic.ChrW(1) ' this copes with streaming data coming in
            c = ReceiveSerialData(100)        ' throw away anything in the buffer
        End While
        com1.Write("AT" & vbCr)     ' now confirm we are in at mode
        Return waitForOK()
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        millis = millis + 10    ' tick every 10 mS
    End Sub

    Private Sub delay(ByVal ticks As Long)
        Dim t1 As Long = millis
        While millis - t1 < ticks
            Application.DoEvents()
        End While
    End Sub

    Private Function waitForOK() As Boolean
        Dim c As Char
        Dim s As String = ""
        'addToTextbox("waitforok")
        While True
            c = ReceiveSerialData(200) ' should get OK after 200 mS
            'addToTextbox("got " & Asc(c).ToString & c)
            If c = "O" Then
                c = ReceiveSerialData(100) ' now the K
                If c = "K" Then
                    c = ReceiveSerialData(100) ' now the \r
                    If c = vbCr Then
                        Exit While
                    End If
                End If
            End If
            If c = Microsoft.VisualBasic.ChrW(1) Then
                outputError("No valid response received")
                'com1.Close()        ' close the com port
                'addToTextbox(s)
                Return False
            End If
            s = s + c
        End While
        Return True
    End Function

    Private Function readData(ByVal cmd As String) As String
        Dim s As String = ""
        Dim c As Char = " "
        com1.Write("AT" & cmd & vbCr)
        While True
            c = ReceiveSerialData(100)
            If c = vbCr Then
                Exit While
            ElseIf c = Microsoft.VisualBasic.ChrW(1) Then
                outputError("timed out waiting for response")
                Return ""
            ElseIf cmd = "RI" And c = Microsoft.VisualBasic.ChrW(0) Then
                c = "." ' Bad initialisation in Xrf
            End If
            If cmd <> "EA" Or (cmd = "EA" And c <> Microsoft.VisualBasic.ChrW(0)) Then
                s = s + c
            End If
        End While
        waitForOK()
        Return s
    End Function

    Private Sub getdata(ByVal cmd As String)
        addToTextbox("Reading AT" & cmd)
        Dim s As String = readData(cmd)
        Dim con() As Control
        con = Me.Controls.Find("lbl" & cmd, True)
        con(0).Text = s
        Try
            con = Me.Controls.Find("txt" & cmd, True)
            con(0).Text = s
        Catch
        End Try
    End Sub

    Private Sub writedata(ByVal cmd As String)
        Dim s As String = ""
        Dim c As Char = " "
        Dim conLbl() As Control
        Dim conTxt() As Control

        s = readData(cmd)
        conLbl = Me.Controls.Find("lbl" & cmd, True)
        conTxt = Me.Controls.Find("txt" & cmd, True)
        If lastWritten = "EA" And cmd = "EK" Then
            getdata(cmd)
        End If
        If cmd = "BD" Or cmd = "RO" Then
            If Convert.ToInt32(s, 16) = Convert.ToInt32(conTxt(0).Text, 16) Then
                Exit Sub 'as they are the same there is nothing to do
            End If
        ElseIf s = conTxt(0).Text And conLbl(0).Text = conTxt(0).Text Then
            Exit Sub 'as they are the same there is nothing to do
        End If

        com1.Write("AT" & cmd & " " & conTxt(0).Text & vbCr)
        lastWritten = cmd
        addToTextbox("Writing AT" & cmd)
        If waitForOK() Then
            com1.Write("AT" & cmd & vbCr)
            s = ""
            While True
                c = ReceiveSerialData(100)
                If c = vbCr Then
                    Exit While
                ElseIf c = Microsoft.VisualBasic.ChrW(1) Then
                    ' we have timed out
                    outputError("timed out waiting for response")
                    Exit Sub
                End If
                s = s + c
            End While
            If waitForOK() Then
                If cmd = "EK" Then
                    getdata("EA")
                End If
                conLbl(0).Text = s
                If cmd = "EA" Then
                    If s.Substring(0, conTxt(0).Text.Length) <> conTxt(0).Text Then
                        outputError("response is not the same")
                    End If
                ElseIf cmd = "BD" Or cmd = "RO" Then
                    If Convert.ToInt32(s, 16) <> Convert.ToInt32(conTxt(0).Text, 16) Then
                        outputError("response is not the same")
                    End If
                Else
                    If s <> conTxt(0).Text Then
                        outputError("response is not the same")
                    End If
                End If
                If cmd = "CC" Then
                    txtGuard.Text = s
                End If
            End If
        End If
    End Sub

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        outputError("")
        If TabControl1.SelectedTab.Name = "SerialMonitor" Then
            switchMonitor(False) ' monitor on / off
        End If
        Me.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        If OpenSerialPort() Then
            If EnterAtMode() Then
                getdata("VR")
                Dim s As String = lblVR.Text.Replace("B", "0")
                XRFVersion = Convert.ToSingle(s, CultureInfo.GetCultureInfoByIetfLanguageTag("en-US").NumberFormat())
                getdata("NT")
                If lblNT.Text <> "ERR" Then
                    NodeType = Convert.ToSingle(lblNT.Text, CultureInfo.GetCultureInfoByIetfLanguageTag("en-US").NumberFormat())
                Else
                    NodeType = 8
                End If
                getdata("BD")
                If lblBD.Text = "ERR" Then  ' usb version
                    outputError("")
                    bUSBVersion = True
                    gboxSerial.Text = "Serial, sleep and flow control - not valid as this is a USB device"
                    gboxSerial.Enabled = False
                Else                    ' not USB version
                    bUSBVersion = False
                    gboxSerial.Text = "Serial, sleep and flow control"
                    gboxSerial.Enabled = True
                    getdata("SM")
                    getdata("FC")
                End If
                If XRFVersion >= 0.28 Or NodeType >= 8 Or bUSBVersion Then
                    bChanSupported = True
                    getdata("CN")
                    getdata("CS")
                Else
                    bChanSupported = False
                End If
                If (XRFVersion > 0.4) Or bUSBVersion Then
                    gboxRP1.Enabled = True
                    gboxRP2.Enabled = True
                    gboxRP3.Enabled = True
                    getdata("RI")
                    getdata("RP")
                    getdata("RC")
                    getdata("MY")
                Else
                    gboxRP1.Enabled = False
                    gboxRP2.Enabled = False
                    gboxRP3.Enabled = False
                End If
                getdata("CC")
                getdata("CH")
                getdata("DR")
                getdata("EA")
                getdata("EK")
                getdata("EE")
                getdata("ID")
                getdata("I2")
                getdata("PK")
                getdata("PL")
                getdata("RO")
                com1.Write("ATDN" & vbCr)
                waitForOK()
            End If
            CloseSerialPort()
        End If
        Me.Cursor = Cursors.Default
        Me.Enabled = True
        If TabControl1.SelectedTab.Name = "SerialMonitor" Then
            switchMonitor(True) ' monitor on / off
        End If
    End Sub

    Private Sub btnWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWrite.Click
        outputError("")
        If TabControl1.SelectedTab.Name = "SerialMonitor" Then
            switchMonitor(False) ' monitor on / off
        End If
        Me.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        If OpenSerialPort() Then
            If EnterAtMode() Then
                If Not bUSBVersion Then
                    writedata("BD")
                    writedata("SM")
                    writedata("FC")
                End If
                writedata("CC")
                writedata("CH")
                If lblVR.Text = "" Or bChanSupported Then
                    writedata("CN")
                    writedata("CS")
                End If
                writedata("DR")
                writedata("EA")
                writedata("EK")
                writedata("EE")
                writedata("ID")
                writedata("I2")
                writedata("NT")
                writedata("PK")
                writedata("PL")
                writedata("RO")
                If XRFVersion > 0.4 Or bUSBVersion Then
                    writedata("RI")
                    writedata("RP")
                    writedata("RC")
                    writedata("MY")
                End If
                com1.Write("ATDN" & vbCr)
                waitForOK()
            End If
            CloseSerialPort()
        End If
        Me.Cursor = Cursors.Default
        Me.Enabled = True
        If TabControl1.SelectedTab.Name = "SerialMonitor" Then
            switchMonitor(True) ' monitor on / off
        End If
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        outputError("")
        If TabControl1.SelectedTab.Name = "SerialMonitor" Then
            switchMonitor(False) ' monitor on / off
        End If
        Me.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        If OpenSerialPort() Then
            If EnterAtMode() Then
                com1.Write("ATAC" & vbCr)
                If waitForOK() Then
                    outputError("Config applied")
                End If
                If Not bUSBVersion Then
                    cmbBaudRate.Text = Convert.ToInt32(lblBD.Text, 16).ToString
                    com1.BaudRate = cmbBaudRate.Text
                End If
                com1.Write("ATDN" & vbCr)
                waitForOK()
            End If
            CloseSerialPort()
        End If
        Me.Cursor = Cursors.Default
        Me.Enabled = True
        If TabControl1.SelectedTab.Name = "SerialMonitor" Then
            switchMonitor(True) ' monitor on / off
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        outputError("")
        If TabControl1.SelectedTab.Name = "SerialMonitor" Then
            switchMonitor(False) ' monitor on / off
        End If
        Me.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        If OpenSerialPort() Then
            If EnterAtMode() Then
                com1.Write("ATWR" & vbCr)
                If waitForOK() Then
                    outputError("Config saved")
                Else
                    Return
                End If
            End If
            CloseSerialPort()
        End If
        Me.Cursor = Cursors.Default
        Me.Enabled = True
        If TabControl1.SelectedTab.Name = "SerialMonitor" Then
            switchMonitor(True) ' monitor on / off
        End If
    End Sub

    Private Sub txtBD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBD.KeyDown
        checkHex(e)
    End Sub

    Private Sub txtBD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBD.KeyPress
        ' Check for the flag being set in the KeyDown event.
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
        End If
    End Sub

    Private Sub txtBD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBD.TextChanged
        cmbBD.Text = Convert.ToInt32(txtBD.Text, 16)
    End Sub

    Private Sub cmbBD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbBD.KeyDown
        checkNum(e)
    End Sub

    Private Sub cmbBD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbBD.KeyPress
        ' Check for the flag being set in the KeyDown event.
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
        End If
    End Sub

    Private Sub cmbBD_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBD.TextChanged
        txtBD.Text = Convert.ToInt32(cmbBD.Text).ToString("X")
    End Sub

    Private Sub txtFC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFC.TextChanged
        If txtFC.Text = "1" Then
            rbtnFCOn.Checked = True
            rbtnFCOff.Checked = False
        ElseIf txtFC.Text = "0" Then
            rbtnFCOn.Checked = False
            rbtnFCOff.Checked = True
        Else
            txtFC.Text = lblFC.Text
        End If
    End Sub

    Private Sub rbtnFCOn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnFCOn.CheckedChanged
        If rbtnFCOn.Checked Then
            txtFC.Text = "1"
        Else
            txtFC.Text = "0"
        End If
    End Sub

    Private Sub txtNT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNT.TextChanged
        If txtNT.Text = "0" Then
            cmbNT.Text = "Normal"
        ElseIf txtNT.Text = "2" Then
            cmbNT.Text = "Repeater"
        Else
            txtNT.Text = lblNT.Text
        End If
    End Sub

    Private Sub cmbNT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNT.SelectedIndexChanged
        If cmbNT.SelectedIndex = 0 Then
            txtNT.Text = 0
        Else
            txtNT.Text = 2
        End If
    End Sub

    Private Sub txtCH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCH.TextChanged
        If txtCH.Text >= "1" And txtCH.Text <= "6" Then
            cmbCH.SelectedIndex = txtCH.Text - 1
        Else
            txtCH.Text = lblCH.Text
        End If
        calcFreq()
    End Sub

    Private Sub cmbCH_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCH.SelectedIndexChanged
        txtCH.Text = cmbCH.SelectedIndex + 1
        calcFreq()
    End Sub

    Private Sub cmbPL_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPL.SelectedIndexChanged
        txtPL.Text = cmbPL.SelectedIndex
    End Sub

    Private Sub txtPL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPL.TextChanged
        If txtPL.Text >= "0" And txtPL.Text <= "8" Then
            cmbPL.SelectedIndex = txtPL.Text
        Else
            txtPL.Text = lblPL.Text
        End If
    End Sub

    Private Sub cmbDR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDR.SelectedIndexChanged
        txtDR.Text = cmbDR.SelectedIndex + 1
    End Sub

    Private Sub txtDR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDR.TextChanged
        If txtDR.Text >= "1" And txtDR.Text <= "5" Then
            cmbDR.SelectedIndex = txtDR.Text - 1
        Else
            txtDR.Text = lblDR.Text
        End If
    End Sub

    Private Sub btnPortSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPortSearch.Click
        Dim bfound = False
        outputError("")
        If DialogResult.Yes = MessageBox.Show("This can take quite some time to search all the available COM ports, are you sure?", "Search for XRF", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            Me.Enabled = False
            GetSerialPortNames()
            For Each sp As String In PortChooser.Items
                addToTextbox("Trying port " & sp)
                PortChooser.Text = sp
                outputError("")
                Application.DoEvents()
                If OpenSerialPort() Then
                    addToTextbox("Port opened OK")
                    If EnterAtMode() Then
                        ' found a modem
                        addToTextbox("Entered AT mode OK")
                        lblVR.Text = ""
                        getdata("VR")
                        If lblVR.Text.Length > 2 Then
                            If lblVR.Text.Substring(1, 1) = "." Then
                                ' most probably an XRF
                                addToTextbox("Found a XRF")
                                bfound = True
                                Exit For
                            End If
                        End If
                        addToTextbox("Exiting AT mode")
                        com1.Write("ATDN") ' exit AT mode
                        waitForOK()
                    End If
                    com1.Close()
                End If
            Next
            If Not bfound Then
                PortChooser.Text = ""
                outputError("No XRF modules located")
            Else
                outputError("XRF located on port " & PortChooser.Text)
                If TabControl1.SelectedTab.Name = "SerialMonitor" Then
                    switchMonitor(True)
                End If
            End If
            Me.Enabled = True
        End If
    End Sub

    Private Sub btnfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfile.Click
        'help the user lookup the hex file name
        'help the user lookup the hex file name
        FileChooser.CheckFileExists = True
        FileChooser.Filter = "Bin files|*.bin|Hex files|*.hex"
        FileChooser.DefaultExt = "bin"
        If FileChooser.ShowDialog() = DialogResult.OK Then
            txtfilename.Text = FileChooser.FileName
        End If
    End Sub

    Private Sub switchMonitor(ByVal bOn As Boolean)
        tmrMonitor.Enabled = False  'stop monitoring
        outputError("")     ' clear any existing error
        If Not com1 Is Nothing Then com1.Close() ' close com port
        If Not bOn Then
            txtSendSerialMonitor.Enabled = False
            rtxtSerialMonitor.Enabled = False
            btnSendSerialMonitor.Enabled = False
            btnClearSerialMonitor.Enabled = False
            cmbWrapSerialMonitor.Enabled = False
        Else
            If Not OpenSerialPort() Then
                outputError("Failed to open serial port")
                txtSendSerialMonitor.Enabled = False
                rtxtSerialMonitor.Enabled = False
                btnSendSerialMonitor.Enabled = False
                btnClearSerialMonitor.Enabled = False
                cmbWrapSerialMonitor.Enabled = False
                Return
            End If
            tmrMonitor.Enabled = True ' switch on monitoring
            txtSendSerialMonitor.Enabled = True
            rtxtSerialMonitor.Enabled = True
            btnSendSerialMonitor.Enabled = True
            btnClearSerialMonitor.Enabled = True
            cmbWrapSerialMonitor.Enabled = True
        End If
    End Sub

    Private Sub writeSerialMonitorTyped(ByVal c As Char)
        Dim savedCol As System.Drawing.Color
        savedCol = rtxtSerialMonitor.SelectionColor
        rtxtSerialMonitor.SelectionColor = Color.Red
        writeSerialMonitor(c)
        rtxtSerialMonitor.SelectionColor = savedCol
    End Sub
    Private Sub writeSerialMonitor(ByVal c As Char)
        Dim wrapPos As Integer
        If c = vbCr Or c = vbLf Then
            countSerialMonitor = 0
            If c = vbCr Then
                rtxtSerialMonitor.AppendText(vbCrLf)    ' display it
            Else
                rtxtSerialMonitor.AppendText(c)    ' display it
            End If
        Else
            If c >= " " Then
                rtxtSerialMonitor.AppendText(c)    ' display it
            Else
                rtxtSerialMonitor.AppendText(".")    ' display it
            End If
            countSerialMonitor += 1
        End If
        If cmbWrapSerialMonitor.Text <> "none" And cmbWrapSerialMonitor.Text <> "" Then
            wrapPos = Convert.ToInt16(cmbWrapSerialMonitor.Text)
            If countSerialMonitor >= wrapPos Then
                rtxtSerialMonitor.AppendText(vbCrLf)
                countSerialMonitor = 0
            End If
        End If
        'rtxtSerialMonitor.SelectionLength = 0
        'rtxtSerialMonitor.SelectionStart = rtxtLog.TextLength
        'rtxtSerialMonitor.ScrollToCaret()
    End Sub

    Private Sub tmrMonitor_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMonitor.Tick
        Dim c As Char
        Dim bWritten As Boolean = False
        Try
            While com1.BytesToRead > 0  ' have received some data
                c = ReceiveSerialData(100) ' read it
                writeSerialMonitor(c)
                bWritten = True
            End While
            If bWritten Then
                rtxtSerialMonitor.ScrollToCaret()
                bWritten = False
            End If
        Catch
            ' we had an error - so assume the serial line is down
            switchMonitor(False)
            outputError("Com port not available")
        End Try
        rtxtLog.SelectionStart = rtxtLog.TextLength
        rtxtLog.ScrollToCaret()
        Application.DoEvents()  ' allow the text box to scroll
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        Me.Enabled = False
        programEEPROM(False)    ' program without verification
        Me.Enabled = True
    End Sub

    Private Function countFileLines() As Integer
        ' counts number of line in the file for the prograss bar maximum
        Dim sr As New System.IO.StreamReader(txtfilename.Text)
        Dim strIn As String
        Dim numLines As Integer
        Do While Not sr.EndOfStream
            strIn = sr.ReadLine()       ' get first line
            numLines += 1
        Loop
        sr.Close()
        Return numLines
    End Function

    Private Function ValidateFile() As Integer
        ' Validates type of file
        Dim strIn As String
        Dim ret As Long = 0
        If txtfilename.Text.EndsWith(".bin") Then
            ret = 3     '' type 3 encrypting bootloader
            Try
                Dim sr As New System.IO.StreamReader(txtfilename.Text)

                Do While Not sr.EndOfStream
                    strIn = sr.ReadLine()       ' get next line
                    If strIn.Length <> 67 Then
                        ret = -4    ' ensure correct size
                        Exit Do
                    End If
                    For i = 0 To 66
                        Dim c = strIn.Chars(i)  ' validate all chars
                        If c < ";" Or c > "z" Then
                            ret = -5
                            Exit Do
                        End If
                    Next
                Loop
                sr.Close()
            Catch
                ret = -3
            End Try
        Else
            Try
                Dim sr As New System.IO.StreamReader(txtfilename.Text)

                Do While Not sr.EndOfStream
                    strIn = sr.ReadLine()       ' get next line
                    If strIn.StartsWith(":") Then
                        If strIn.Substring(7, 2) = "00" Then ' this is an action line
                            If strIn.Substring(3, 4) = "0000" Then
                                ret = 1    ' type 1 - standard
                            ElseIf strIn.Substring(3, 4) = "1000" Then
                                ret = 2     ' type 2 - new bootloader
                            Else
                                ret = -1  ' unknown
                            End If
                            Exit Do
                        End If
                    Else
                        Exit Do
                    End If
                Loop
                sr.Close()
            Catch
                ret = -2
            End Try
        End If
        Return ret
    End Function

    Private Sub programEEPROM(ByVal verify As Boolean)
        Dim c As Char
        If txtfilename.Text = "" Then
            outputError("Error - no file specified")
            Return
        End If
        Dim Filetype As Integer = ValidateFile()
        If Filetype <= 0 Then
            outputError("Error - file is not a recognised type")
            Return
        End If
        outputError("")
        ProgressBar1.Value = 0
        If Not OpenSerialPort() Then
            Return
        End If
        If rbtnXRF.Checked Then      ' we need to put it into program mode
            If Not EnterAtMode() Then
                com1.Close()        ' close the com port
                Return
            End If
            com1.Write("ATPG" & vbCr)
            If Not waitForOK() Then
                outputError("Failed to enter Prog mode")
                Return
            End If
            addToTextbox("Entered programming mode")
        End If

        outputError("")     ' clear any existing error
        If cmbBaudRate.Text <> "9600" Then
            com1.BaudRate = 9600    ' force 9600
            cmbBaudRate.Text = "9600"    ' for the end of uploading - needed for commit
        End If
        delay(70)         ' 50 ticks should be enough for a reset
        Dim cmd As String = ""
        Dim bVersion2 As Boolean = False
        Dim bVersion3 As Boolean = False
        com1.Write("~Y")       ' request version number (version 2 - ~ enters bootloader)
        c = ReceiveSerialData(400) ' should get cmd echoed rapidly
        If c = "2" Then
            bVersion2 = True
            rbtnXRF.Checked = False
            rbtnBOOT.Checked = True
        ElseIf c = "3" Then
            bVersion3 = True
            rbtnXRF.Checked = False
            rbtnBOOT.Checked = True
        ElseIf c = "~" Then      ' need to flush characters as this is V1
            cmd = c
            While c <> Microsoft.VisualBasic.ChrW(1)
                c = ReceiveSerialData(200)  'flush RYR
                If c <> Microsoft.VisualBasic.ChrW(1) Then cmd = cmd + c
            End While
            If cmd <> "~Y" Then
                addToTextbox("Response received:" + cmd)
            End If
        Else
            cmd = c
            While c <> Microsoft.VisualBasic.ChrW(1)
                c = ReceiveSerialData(200)  'flush RYR
                If c <> Microsoft.VisualBasic.ChrW(1) Then cmd = cmd + c
            End While
            outputError("Bootloader did not respond :" + cmd)
            If Filetype <> 1 Then
                com1.Close()        ' close the com port
                Return
            End If
        End If
        If (bVersion2 And (Filetype > 2)) Or (bVersion3 And (Filetype <> 3)) Then
            outputError("Error - file is the wrong hex version")
            com1.Close()        ' close the com port
            Return
        End If
        If verify Then
            cmd = "V"       ' verify
        Else
            cmd = "W"       ' write
        End If
        com1.Write(cmd)     ' send command to Device
        c = ReceiveSerialData(400) ' should get cmd echoed rapidly
        If c <> cmd Then
            ' error
            If verify Then
                outputError("Error entering verify mode")
            Else
                outputError("Error entering write mode")
            End If
            com1.Close()      ' tidy up
            Return          ' and exit
        End If

        If verify Then
            outputError("Entered verify mode")
        Else
            outputError("Entered Write mode")
            addToTextbox("Erasing EEPROM")
        End If

        ' wait for ready (character 'R')
        c = Microsoft.VisualBasic.ChrW(1)
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = 80
        ' this should be instant for verify but we go through the same loop anyway
        While c = Microsoft.VisualBasic.ChrW(1) And ProgressBar1.Value < 80
            c = ReceiveSerialData(1000)  ' give it upto 80 seconds to erase the device
            ProgressBar1.Value += 1
        End While

        ' ok we got a character or timed out
        If verify Then
            If c = Microsoft.VisualBasic.ChrW(1) Then
                outputError("Timeout waiting for Device ready")
                com1.Close()
                Return
            ElseIf c = "R" Then
                addToTextbox("Verifying HEX")
            Else
                outputError("Incorrect response from Device (" & c & ")")
                com1.Close()
                Return
            End If
        Else    ' must be write
            If c = Microsoft.VisualBasic.ChrW(1) Then
                outputError("Timeout while erasing EEPROM")
                com1.Close()
                Return
            ElseIf c = "X" Then
                outputError("Verify error while erasing EEPROM")
                Return
            ElseIf c = "R" Then
                addToTextbox("Writing HEX")
            Else
                outputError("Incorrect response from Device (" & c & ")")
                com1.Close()
                Return
            End If
        End If

        ' set up progress bar for write/verify
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = countFileLines() + 1

        ' open the file
        Dim sr As New System.IO.StreamReader(txtfilename.Text)
        Dim strIn As String

        strIn = sr.ReadLine()       ' get first line
        ProgressBar1.Value += 1

        Do While c = "R" And strIn <> ""    ' while Device is ready and there is something to send
            com1.Write(strIn)       ' send the line to the Device
            Debug.Print("Sending:" + strIn + vbCrLf)
            Application.DoEvents()
            c = ReceiveSerialData(20000) ' give it time to repply
            If c = "A" Then           ' data received OK
                ' get the next line from the file
                If sr.EndOfStream Then
                    ' we've done here - should receive 'R' follwed by 'y'
                    strIn = ""
                    c = ReceiveSerialData(1000)     ' grab the 'R'
                    If c <> "R" Then
                        Exit Do ' if it is not a 'R' get out
                    End If
                Else
                    strIn = sr.ReadLine()       ' get next line
                    ProgressBar1.Value += 1  'bump the progress pointer
                End If
            ElseIf c = "N" Then         ' data not received OK - serial line corruption
                ' just log it and loop again - will retry
                outputError("Serial error - retrying")
            Else
                outputError("Incorrect response from Device (" & c & ")")
                Exit Do     '' oops do not know what to do
            End If
            c = ReceiveSerialData(10000) ' now get the response character
            If c = "X" Then             ' X is verify error
                outputError("Verify error during ")
                outputError(strIn)     ' output line which failed
                c = ReceiveSerialData(1000) ' expect a 'n' character here - will cause exit from loop
            End If
        Loop

        sr.Close()          ' close the file stream
        com1.Close()        ' close the com port


        'now say if we suceeded or not
        If verify Then
            cmd = "verifying"
        Else
            cmd = "writing"
        End If
        If c = "n" Then
            outputError("Error during " & cmd)
            Return
        ElseIf c = "y" Then
            outputError("Success " & cmd)
        Else
            outputError("Unknown error during " & cmd & " response:" & c)
        End If
    End Sub

    Private Sub btnVerify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerify.Click
        Me.Enabled = False
        programEEPROM(True) ' go and verify
        Me.Enabled = True
    End Sub

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        Me.Enabled = False
        outputError("")
        If rbtnXRF.Checked Then      ' we need to put it into program mode
            If OpenSerialPort() Then
                If EnterAtMode() Then
                    com1.Write("ATPC" & vbCr)
                    outputError("Program committed - XRF has been restarted")
                    rbtnXRF.Checked = True
                    rbtnBOOT.Checked = False
                End If
                com1.Close()        ' close the com port
            End If
        Else
            If OpenSerialPort() Then
                com1.Write("X")
                outputError("Program committed - XRF has been restarted.")
                rbtnXRF.Checked = True
                rbtnBOOT.Checked = False
                com1.Close()        ' close the com port
            End If
        End If
        Me.Enabled = True
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab.Name = "SerialMonitor" Then
            switchMonitor(True) ' monitor on / off
            btnTest.Enabled = False
            btnWrite.Enabled = False
            btnApply.Enabled = False
            btnSave.Enabled = False
        Else
            switchMonitor(False) ' monitor on / off
            If TabControl1.SelectedTab.Name = "UploadFirmware" Then
                btnTest.Enabled = False
                btnWrite.Enabled = False
                btnApply.Enabled = False
                btnSave.Enabled = False
            Else
                btnTest.Enabled = True
                btnWrite.Enabled = True
                btnApply.Enabled = True
                btnSave.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnSendSerialMonitor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendSerialMonitor.Click
        outputError("")
        For Each c As Char In txtSendSerialMonitor.Text
            writeSerialMonitorTyped(c)
        Next
        rtxtSerialMonitor.ScrollToCaret()
        com1.Write(txtSendSerialMonitor.Text)
    End Sub

    Private Sub btnClearSerialMonitor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearSerialMonitor.Click
        outputError("")
        rtxtSerialMonitor.Clear()
        countSerialMonitor = 0
    End Sub

    Private Sub txtSM_TextChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSM.TextChanged
        If txtSM.Text >= "0" And txtSM.Text <= "2" Then
            cmbSM.SelectedIndex = txtSM.Text
        Else
            txtSM.Text = lblSM.Text
        End If
    End Sub

    Private Sub cmbSM_SelectedIndexChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSM.SelectedIndexChanged
        txtSM.Text = cmbSM.SelectedIndex
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub rbtnEEOn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnEEOn.CheckedChanged
        If rbtnEEOn.Checked Then
            txtEE.Text = "1"
        Else
            txtEE.Text = "0"
        End If
    End Sub

    Private Sub txtEE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEE.TextChanged
        If txtEE.Text = "1" Then
            rbtnEEOn.Checked = True
            rbtnEEOff.Checked = False
        ElseIf txtEE.Text = "0" Then
            rbtnEEOn.Checked = False
            rbtnEEOff.Checked = True
        Else
            txtEE.Text = lblEE.Text
        End If
    End Sub

    Private Sub btnLoadFromFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadFromFile.Click

    End Sub

    Private Sub btnSaveToFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveToFile.Click

    End Sub

    Private Sub checkHex(ByVal e As System.Windows.Forms.KeyEventArgs)
        ' Initialize the flag to false.
        nonNumberEntered = False

        ' Determine whether the keystroke is a backspace.
        If e.KeyCode <> Keys.Back Then
            ' Determine whether the keystroke is a number from the top of the keyboard.
            If (e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9) Then
                ' Determine whether the keystroke is a number from the keypad.
                If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                    ' determine if a hex char is pressed
                    If (e.KeyCode < Keys.A OrElse e.KeyCode > Keys.F) Then
                        ' A non-numerical keystroke was pressed. 
                        ' Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub checkNum(ByVal e As System.Windows.Forms.KeyEventArgs)
        ' Initialize the flag to false.
        nonNumberEntered = False

        ' Determine whether the keystroke is a backspace.
        If e.KeyCode <> Keys.Back Then
            ' Determine whether the keystroke is a number from the top of the keyboard.
            If (e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9) Then
                ' Determine whether the keystroke is a number from the keypad.
                If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                    ' A non-numerical keystroke was pressed. 
                    ' Set the flag to true and evaluate in KeyPress event.
                    nonNumberEntered = True
                End If
            End If
        End If
    End Sub

    Private Sub txtEK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEK.KeyDown
        checkHex(e)
    End Sub

    Private Sub txtEK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEK.KeyPress
        ' Check for the flag being set in the KeyDown event.
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
        End If
    End Sub

    Private Sub txtEK_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEK.Validating
        If txtEK.Text <> lblEK.Text And txtEK.TextLength <> 32 Then
            ' user has changed key
            'wrong length
            e.Cancel = True
            txtEK.Select(txtEK.TextLength, 0)
            outputError("Encryption key must be 32 hex characters")
        Else
            outputError("")
        End If
    End Sub

    Private Sub txtID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtID.KeyDown
        checkHex(e)
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress
        ' Check for the flag being set in the KeyDown event.
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
        End If
    End Sub

    Private Sub txtI2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtI2.KeyDown
        checkHex(e)
    End Sub

    Private Sub txtI2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtI2.KeyPress
        ' Check for the flag being set in the KeyDown event.
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
        End If
    End Sub

    Private Sub txtPK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPK.KeyDown
        checkHex(e)
    End Sub

    Private Sub txtPK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPK.KeyPress
        ' Check for the flag being set in the KeyDown event.
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
        End If
    End Sub

    Private Sub txtPK_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPK.TextChanged
        cmbPK.Text = Convert.ToInt32(txtPK.Text, 16)
    End Sub

    Private Sub cmbPK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbPK.KeyDown
        checkNum(e)
    End Sub

    Private Sub cmbPK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPK.KeyPress
        ' Check for the flag being set in the KeyDown event.
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
        End If
    End Sub

    Private Sub cmbPK_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPK.TextChanged
        txtPK.Text = Convert.ToInt32(cmbPK.Text).ToString("X")
    End Sub

    Private Sub txtRO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRO.KeyDown
        checkHex(e)
    End Sub

    Private Sub txtRO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRO.TextChanged
        cmbRO.Text = Convert.ToInt32(txtRO.Text, 16)
    End Sub

    Private Sub txtRO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRO.KeyPress
        ' Check for the flag being set in the KeyDown event.
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
        End If
    End Sub

    Private Sub cmbRO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbRO.KeyDown
        checkNum(e)
    End Sub

    Private Sub cmbRO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbRO.KeyPress
        ' Check for the flag being set in the KeyDown event.
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
        End If
    End Sub

    Private Sub cmbRO_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbRO.TextChanged
        txtRO.Text = Convert.ToInt32(cmbRO.Text).ToString("X")
    End Sub

    Private Sub txtCC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCC.KeyPress
        If Not guardChangeOK Then
            If DialogResult.Yes = MessageBox.Show("Changing the guard character is a last resort, are you really sure you want to do this?", "", MessageBoxButtons.YesNo) Then
                guardChangeOK = True
            Else
                e.Handled = True ' ignore the character
            End If
        End If
    End Sub

    Private Sub txtCC_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCC.Leave
        If txtCC.Text = "" Then
            txtCC.Text = txtGuard.Text
        End If
    End Sub

    Private Sub txtGuard_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGuard.KeyPress
        If Not guardChangeOK Then
            If DialogResult.Yes = MessageBox.Show("Only change this if you have set a different guard character (ATCC) on the XRF. Continue?", "", MessageBoxButtons.YesNo) Then
                guardChangeOK = True
            Else
                e.Handled = True ' ignore the character
            End If
        End If
    End Sub

    Private Sub cmbBaudRate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbBaudRate.KeyDown
        checkNum(e)
    End Sub

    Private Sub cmbBaudRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbBaudRate.KeyPress
        ' Check for the flag being set in the KeyDown event.
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
        End If
    End Sub

    Private Sub txtSendSerialMonitor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSendSerialMonitor.KeyPress
        If e.KeyChar = vbCr Then
            For Each c As Char In txtSendSerialMonitor.Text
                writeSerialMonitorTyped(c)
            Next
            writeSerialMonitorTyped(vbCr)
            rtxtSerialMonitor.ScrollToCaret()
            com1.Write(txtSendSerialMonitor.Text)
            e.Handled = True
        End If
    End Sub

    Private Sub rtxtSerialMonitor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtxtSerialMonitor.KeyPress
        If e.KeyChar <> vbCr Then
            writeSerialMonitorTyped(e.KeyChar)
            rtxtSerialMonitor.ScrollToCaret()
        End If
        com1.Write(e.KeyChar)
        e.Handled = True
    End Sub

    Private Sub PortChooser_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles PortChooser.DropDown
        GetSerialPortNames()    ' set up the drop down
    End Sub

    Private Sub PortChooser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PortChooser.SelectedIndexChanged
        If btnPortSearch.Enabled Then       ' only do if not in search
            If TabControl1.SelectedTab.Name = "SerialMonitor" Then
                switchMonitor(True)
            End If
        End If
    End Sub

    Private Sub cmbWrapSerialMonitor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbWrapSerialMonitor.KeyDown
        checkNum(e)
    End Sub

    Private Sub cmbWrapSerialMonitor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbWrapSerialMonitor.KeyPress
        ' Check for the flag being set in the KeyDown event.
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
        End If
    End Sub

    Private Sub cmbWrapSerialMonitor_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbWrapSerialMonitor.TextChanged
        If cmbWrapSerialMonitor.Text <> "none" And cmbWrapSerialMonitor.Text <> "" Then
            Dim wrapPos As Integer = Convert.ToInt16(cmbWrapSerialMonitor.Text)
            If countSerialMonitor >= wrapPos Then
                rtxtSerialMonitor.AppendText(vbCrLf)
                countSerialMonitor = 0
            End If
        End If
    End Sub

    Private Sub txtCS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCS.KeyDown
        checkHex(e)
    End Sub

    Private Sub txtCS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCS.KeyPress
        ' Check for the flag being set in the KeyDown event.
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
        End If
    End Sub

    Private Sub txtCS_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCS.TextChanged
        cmbCS.Text = Convert.ToInt32(txtCS.Text, 16)
        calcFreq()
    End Sub

    Private Sub cmbCS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCS.KeyDown
        checkNum(e)
    End Sub

    Private Sub cmbCS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCS.KeyPress
        ' Check for the flag being set in the KeyDown event.
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
        End If
    End Sub

    Private Sub cmbCS_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCS.TextChanged
        If (cmbCS.Text > 255) Then
            cmbCS.Text = 255
        End If
        txtCS.Text = Convert.ToInt32(cmbCS.Text).ToString("X")
        calcFreq()
    End Sub

    Private Sub txtCN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCN.KeyDown
        checkHex(e)
    End Sub

    Private Sub txtCN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCN.KeyPress
        ' Check for the flag being set in the KeyDown event.
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
        End If
    End Sub

    Private Sub txtCN_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCN.TextChanged
        txtnCN.Text = Convert.ToInt32(txtCN.Text, 16)
        calcFreq()
    End Sub

    Private Sub txtnCN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnCN.KeyDown
        checkNum(e)
    End Sub

    Private Sub txtnCN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnCN.KeyPress
        ' Check for the flag being set in the KeyDown event.
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
        End If
    End Sub

    Private Sub txtnCN_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnCN.TextChanged
        If (txtnCN.Text > 255) Then
            txtnCN.Text = 255
        End If
        txtCN.Text = Convert.ToInt32(txtnCN.Text).ToString("X")
        calcFreq()
    End Sub

    Private Sub calcFreq()
        Dim freq As Single
        Try
            freq = Convert.ToSingle(cmbCH.Text)
            freq += (Convert.ToInt32(cmbCS.Text) * Convert.ToInt32(txtnCN.Text)) / 1000
            lblFreq.Text = freq.ToString
        Catch
            lblFreq.Text = ""
        End Try
    End Sub

    Private Sub btnProgAdvanced_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProgAdvanced.Click
        rbtnXRF.Visible = True
        rbtnBOOT.Visible = True
    End Sub

    Private Sub txtRP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRP.TextChanged
        If txtRP.Text = "1" Then
            rbtnRPon.Checked = True
            rbtnRPoff.Checked = False
        ElseIf txtRP.Text = "0" Then
            rbtnRPon.Checked = False
            rbtnRPoff.Checked = True
        Else
            txtRP.Text = lblRP.Text
        End If
    End Sub

    Private Sub rbtnRPon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnRPon.CheckedChanged
        If rbtnRPon.Checked Then
            txtRP.Text = "1"
        Else
            txtRP.Text = "0"
        End If
    End Sub

    Private Sub txtRC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRC.KeyDown
        checkHex(e)
    End Sub

    Private Sub txtRC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRC.KeyPress
        ' Check for the flag being set in the KeyDown event.
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
        End If
    End Sub

    Private Sub cmbBaudRate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBaudRate.SelectedIndexChanged
        If btnPortSearch.Enabled Then       ' only do if not in search
            If Not TabControl1.SelectedTab Is Nothing Then
                If TabControl1.SelectedTab.Name = "SerialMonitor" Then
                    switchMonitor(True)
                End If
            End If
        End If
    End Sub
End Class
