''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Permission is hereby granted, free of charge, to any person obtaining
' a copy of this software and associated documentation files (the
' "Software"), to deal in the Software without restriction, including
' without limitation the rights to use, copy, modify, merge, publish,
' distribute, sublicense, and/or sell copies of the Software, and to
' permit persons to whom the Software is furnished to do so, subject to
' the following conditions:
'
' The above copyright notice and this permission notice shall be
' included in all copies or substantial portions of the Software.
'
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
' EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
' MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
' NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
' LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
' OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
' WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container
        Me.PortChooser = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnTest = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmbBaudRate = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblCH = New System.Windows.Forms.Label
        Me.lblDR = New System.Windows.Forms.Label
        Me.lblEA = New System.Windows.Forms.Label
        Me.lblEK = New System.Windows.Forms.Label
        Me.lblEE = New System.Windows.Forms.Label
        Me.lblID = New System.Windows.Forms.Label
        Me.lblI2 = New System.Windows.Forms.Label
        Me.lblNT = New System.Windows.Forms.Label
        Me.lblPL = New System.Windows.Forms.Label
        Me.btnWrite = New System.Windows.Forms.Button
        Me.txtCH = New System.Windows.Forms.TextBox
        Me.txtEA = New System.Windows.Forms.TextBox
        Me.txtEK = New System.Windows.Forms.TextBox
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtI2 = New System.Windows.Forms.TextBox
        Me.txtNT = New System.Windows.Forms.TextBox
        Me.txtPK = New System.Windows.Forms.TextBox
        Me.txtPL = New System.Windows.Forms.TextBox
        Me.txtRO = New System.Windows.Forms.TextBox
        Me.txtDR = New System.Windows.Forms.TextBox
        Me.txtEE = New System.Windows.Forms.TextBox
        Me.btnApply = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.lblPK = New System.Windows.Forms.Label
        Me.lblRO = New System.Windows.Forms.Label
        Me.txtBD = New System.Windows.Forms.TextBox
        Me.lblFC = New System.Windows.Forms.Label
        Me.lblBD = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbBD = New System.Windows.Forms.ComboBox
        Me.txtFC = New System.Windows.Forms.TextBox
        Me.gboxSerial = New System.Windows.Forms.GroupBox
        Me.cmbSM = New System.Windows.Forms.ComboBox
        Me.txtSM = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.lblSM = New System.Windows.Forms.Label
        Me.rbtnFCOff = New System.Windows.Forms.RadioButton
        Me.rbtnFCOn = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbtnEEOff = New System.Windows.Forms.RadioButton
        Me.rbtnEEOn = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.lblFreq = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtnCN = New System.Windows.Forms.TextBox
        Me.lblCN = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.txtCN = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.cmbCS = New System.Windows.Forms.ComboBox
        Me.lblCS = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.txtCS = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.cmbRO = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.cmbPK = New System.Windows.Forms.ComboBox
        Me.cmbDR = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.cmbPL = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.cmbCH = New System.Windows.Forms.ComboBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cmbNT = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblCC = New System.Windows.Forms.Label
        Me.txtCC = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.General = New System.Windows.Forms.TabPage
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Label64 = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.lblVR = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Advanced = New System.Windows.Forms.TabPage
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.Label87 = New System.Windows.Forms.Label
        Me.Label88 = New System.Windows.Forms.Label
        Me.Label85 = New System.Windows.Forms.Label
        Me.Label86 = New System.Windows.Forms.Label
        Me.Label84 = New System.Windows.Forms.Label
        Me.Label83 = New System.Windows.Forms.Label
        Me.Label82 = New System.Windows.Forms.Label
        Me.Label81 = New System.Windows.Forms.Label
        Me.Label80 = New System.Windows.Forms.Label
        Me.Label79 = New System.Windows.Forms.Label
        Me.Label78 = New System.Windows.Forms.Label
        Me.Label77 = New System.Windows.Forms.Label
        Me.Label76 = New System.Windows.Forms.Label
        Me.Label75 = New System.Windows.Forms.Label
        Me.Label74 = New System.Windows.Forms.Label
        Me.Label73 = New System.Windows.Forms.Label
        Me.Label72 = New System.Windows.Forms.Label
        Me.Label71 = New System.Windows.Forms.Label
        Me.Label69 = New System.Windows.Forms.Label
        Me.Label68 = New System.Windows.Forms.Label
        Me.Label66 = New System.Windows.Forms.Label
        Me.gboxRP3 = New System.Windows.Forms.GroupBox
        Me.txtRC = New System.Windows.Forms.TextBox
        Me.Label67 = New System.Windows.Forms.Label
        Me.lblRC = New System.Windows.Forms.Label
        Me.gboxRP2 = New System.Windows.Forms.GroupBox
        Me.lblMY = New System.Windows.Forms.Label
        Me.Label70 = New System.Windows.Forms.Label
        Me.txtMY = New System.Windows.Forms.TextBox
        Me.gboxRP1 = New System.Windows.Forms.GroupBox
        Me.rbtnRPoff = New System.Windows.Forms.RadioButton
        Me.rbtnRPon = New System.Windows.Forms.RadioButton
        Me.txtRP = New System.Windows.Forms.TextBox
        Me.Label65 = New System.Windows.Forms.Label
        Me.lblRP = New System.Windows.Forms.Label
        Me.lblRI = New System.Windows.Forms.Label
        Me.labelRI = New System.Windows.Forms.Label
        Me.txtRI = New System.Windows.Forms.TextBox
        Me.Log = New System.Windows.Forms.TabPage
        Me.rtxtLog = New System.Windows.Forms.RichTextBox
        Me.UploadFirmware = New System.Windows.Forms.TabPage
        Me.btnProgAdvanced = New System.Windows.Forms.Button
        Me.rbtnBOOT = New System.Windows.Forms.RadioButton
        Me.rbtnXRF = New System.Windows.Forms.RadioButton
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.btnCommit = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.btnVerify = New System.Windows.Forms.Button
        Me.btnGo = New System.Windows.Forms.Button
        Me.Label26 = New System.Windows.Forms.Label
        Me.btnfile = New System.Windows.Forms.Button
        Me.txtfilename = New System.Windows.Forms.TextBox
        Me.SerialMonitor = New System.Windows.Forms.TabPage
        Me.rtxtSerialMonitor = New System.Windows.Forms.RichTextBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label61 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.lblWrap = New System.Windows.Forms.Label
        Me.cmbWrapSerialMonitor = New System.Windows.Forms.ComboBox
        Me.btnClearSerialMonitor = New System.Windows.Forms.Button
        Me.btnSendSerialMonitor = New System.Windows.Forms.Button
        Me.txtSendSerialMonitor = New System.Windows.Forms.TextBox
        Me.btnLoadFromFile = New System.Windows.Forms.Button
        Me.btnSaveToFile = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnPortSearch = New System.Windows.Forms.Button
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.FileChooser = New System.Windows.Forms.OpenFileDialog
        Me.tmrMonitor = New System.Windows.Forms.Timer(Me.components)
        Me.txtGuard = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label89 = New System.Windows.Forms.Label
        Me.gboxSerial.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.General.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Advanced.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.gboxRP3.SuspendLayout()
        Me.gboxRP2.SuspendLayout()
        Me.gboxRP1.SuspendLayout()
        Me.Log.SuspendLayout()
        Me.UploadFirmware.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.SerialMonitor.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'PortChooser
        '
        Me.PortChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PortChooser.FormattingEnabled = True
        Me.PortChooser.Location = New System.Drawing.Point(79, 6)
        Me.PortChooser.Name = "PortChooser"
        Me.PortChooser.Size = New System.Drawing.Size(111, 21)
        Me.PortChooser.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(5, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Port"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(250, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Baud rate"
        '
        'btnTest
        '
        Me.btnTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTest.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTest.ForeColor = System.Drawing.Color.DarkRed
        Me.btnTest.Location = New System.Drawing.Point(485, 5)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(65, 45)
        Me.btnTest.TabIndex = 8
        Me.btnTest.Text = "Download config"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'cmbBaudRate
        '
        Me.cmbBaudRate.FormattingEnabled = True
        Me.cmbBaudRate.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200"})
        Me.cmbBaudRate.Location = New System.Drawing.Point(315, 6)
        Me.cmbBaudRate.Name = "cmbBaudRate"
        Me.cmbBaudRate.Size = New System.Drawing.Size(71, 21)
        Me.cmbBaudRate.TabIndex = 9
        Me.cmbBaudRate.Text = "9600"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(398, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Frequency (ATCH)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Data rate (ATDR)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Encryption key - text based (ATEA)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Encryption key - hex (ATEK)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Encryption enabled (ATEE)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Node type (ATNT)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Pan ID 2 (ATI2)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Pan ID (ATID)"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 13)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Power level (ATPL)"
        '
        'lblCH
        '
        Me.lblCH.AutoSize = True
        Me.lblCH.Location = New System.Drawing.Point(538, 20)
        Me.lblCH.Name = "lblCH"
        Me.lblCH.Size = New System.Drawing.Size(13, 13)
        Me.lblCH.TabIndex = 27
        Me.lblCH.Text = "0"
        '
        'lblDR
        '
        Me.lblDR.AutoSize = True
        Me.lblDR.Location = New System.Drawing.Point(155, 46)
        Me.lblDR.Name = "lblDR"
        Me.lblDR.Size = New System.Drawing.Size(13, 13)
        Me.lblDR.TabIndex = 28
        Me.lblDR.Text = "0"
        '
        'lblEA
        '
        Me.lblEA.AutoSize = True
        Me.lblEA.Location = New System.Drawing.Point(188, 48)
        Me.lblEA.Name = "lblEA"
        Me.lblEA.Size = New System.Drawing.Size(183, 13)
        Me.lblEA.TabIndex = 29
        Me.lblEA.Text = "WWWWWWWWWWWWWWWW"
        '
        'lblEK
        '
        Me.lblEK.AutoSize = True
        Me.lblEK.Location = New System.Drawing.Point(188, 74)
        Me.lblEK.Name = "lblEK"
        Me.lblEK.Size = New System.Drawing.Size(263, 13)
        Me.lblEK.TabIndex = 30
        Me.lblEK.Text = "DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD"
        '
        'lblEE
        '
        Me.lblEE.AutoSize = True
        Me.lblEE.Location = New System.Drawing.Point(159, 22)
        Me.lblEE.Name = "lblEE"
        Me.lblEE.Size = New System.Drawing.Size(13, 13)
        Me.lblEE.TabIndex = 31
        Me.lblEE.Text = "0"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(135, 42)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(33, 13)
        Me.lblID.TabIndex = 33
        Me.lblID.Text = "5AA5"
        '
        'lblI2
        '
        Me.lblI2.AutoSize = True
        Me.lblI2.Location = New System.Drawing.Point(135, 64)
        Me.lblI2.Name = "lblI2"
        Me.lblI2.Size = New System.Drawing.Size(33, 13)
        Me.lblI2.TabIndex = 34
        Me.lblI2.Text = "A55A"
        '
        'lblNT
        '
        Me.lblNT.AutoSize = True
        Me.lblNT.Location = New System.Drawing.Point(155, 20)
        Me.lblNT.Name = "lblNT"
        Me.lblNT.Size = New System.Drawing.Size(13, 13)
        Me.lblNT.TabIndex = 35
        Me.lblNT.Text = "2"
        '
        'lblPL
        '
        Me.lblPL.AutoSize = True
        Me.lblPL.Location = New System.Drawing.Point(155, 22)
        Me.lblPL.Name = "lblPL"
        Me.lblPL.Size = New System.Drawing.Size(13, 13)
        Me.lblPL.TabIndex = 37
        Me.lblPL.Text = "0"
        '
        'btnWrite
        '
        Me.btnWrite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnWrite.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWrite.Location = New System.Drawing.Point(554, 5)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(65, 45)
        Me.btnWrite.TabIndex = 41
        Me.btnWrite.Text = "Upload config"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'txtCH
        '
        Me.txtCH.Location = New System.Drawing.Point(557, 17)
        Me.txtCH.MaxLength = 1
        Me.txtCH.Name = "txtCH"
        Me.txtCH.Size = New System.Drawing.Size(17, 20)
        Me.txtCH.TabIndex = 43
        '
        'txtEA
        '
        Me.txtEA.Location = New System.Drawing.Point(451, 45)
        Me.txtEA.MaxLength = 16
        Me.txtEA.Name = "txtEA"
        Me.txtEA.Size = New System.Drawing.Size(243, 20)
        Me.txtEA.TabIndex = 44
        '
        'txtEK
        '
        Me.txtEK.Location = New System.Drawing.Point(451, 71)
        Me.txtEK.MaxLength = 32
        Me.txtEK.Name = "txtEK"
        Me.txtEK.Size = New System.Drawing.Size(243, 20)
        Me.txtEK.TabIndex = 45
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(174, 39)
        Me.txtID.MaxLength = 4
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(36, 20)
        Me.txtID.TabIndex = 47
        '
        'txtI2
        '
        Me.txtI2.Location = New System.Drawing.Point(174, 61)
        Me.txtI2.MaxLength = 4
        Me.txtI2.Name = "txtI2"
        Me.txtI2.Size = New System.Drawing.Size(36, 20)
        Me.txtI2.TabIndex = 48
        '
        'txtNT
        '
        Me.txtNT.Location = New System.Drawing.Point(175, 17)
        Me.txtNT.MaxLength = 1
        Me.txtNT.Name = "txtNT"
        Me.txtNT.Size = New System.Drawing.Size(17, 20)
        Me.txtNT.TabIndex = 49
        '
        'txtPK
        '
        Me.txtPK.Location = New System.Drawing.Point(174, 69)
        Me.txtPK.MaxLength = 2
        Me.txtPK.Name = "txtPK"
        Me.txtPK.Size = New System.Drawing.Size(31, 20)
        Me.txtPK.TabIndex = 50
        '
        'txtPL
        '
        Me.txtPL.Location = New System.Drawing.Point(174, 18)
        Me.txtPL.MaxLength = 1
        Me.txtPL.Name = "txtPL"
        Me.txtPL.Size = New System.Drawing.Size(17, 20)
        Me.txtPL.TabIndex = 51
        '
        'txtRO
        '
        Me.txtRO.Location = New System.Drawing.Point(175, 94)
        Me.txtRO.MaxLength = 4
        Me.txtRO.Name = "txtRO"
        Me.txtRO.Size = New System.Drawing.Size(30, 20)
        Me.txtRO.TabIndex = 52
        '
        'txtDR
        '
        Me.txtDR.Location = New System.Drawing.Point(175, 43)
        Me.txtDR.MaxLength = 1
        Me.txtDR.Name = "txtDR"
        Me.txtDR.Size = New System.Drawing.Size(17, 20)
        Me.txtDR.TabIndex = 55
        '
        'txtEE
        '
        Me.txtEE.BackColor = System.Drawing.SystemColors.Window
        Me.txtEE.Location = New System.Drawing.Point(178, 18)
        Me.txtEE.Name = "txtEE"
        Me.txtEE.Size = New System.Drawing.Size(17, 20)
        Me.txtEE.TabIndex = 56
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.Location = New System.Drawing.Point(623, 5)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(65, 45)
        Me.btnApply.TabIndex = 57
        Me.btnApply.Text = "Apply changes (ATAC)"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(692, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(65, 45)
        Me.btnSave.TabIndex = 58
        Me.btnSave.Text = "Write config (ATWR)"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 13)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Packet timeout (ATRO)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(15, 72)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(99, 13)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Packet size (ATPK)"
        '
        'lblPK
        '
        Me.lblPK.AutoSize = True
        Me.lblPK.Location = New System.Drawing.Point(149, 72)
        Me.lblPK.Name = "lblPK"
        Me.lblPK.Size = New System.Drawing.Size(19, 13)
        Me.lblPK.TabIndex = 36
        Me.lblPK.Text = "00"
        '
        'lblRO
        '
        Me.lblRO.AutoSize = True
        Me.lblRO.Location = New System.Drawing.Point(137, 97)
        Me.lblRO.Name = "lblRO"
        Me.lblRO.Size = New System.Drawing.Size(31, 13)
        Me.lblRO.TabIndex = 38
        Me.lblRO.Text = "0064"
        '
        'txtBD
        '
        Me.txtBD.Location = New System.Drawing.Point(178, 21)
        Me.txtBD.Name = "txtBD"
        Me.txtBD.Size = New System.Drawing.Size(46, 20)
        Me.txtBD.TabIndex = 42
        '
        'lblFC
        '
        Me.lblFC.AutoSize = True
        Me.lblFC.Location = New System.Drawing.Point(159, 75)
        Me.lblFC.Name = "lblFC"
        Me.lblFC.Size = New System.Drawing.Size(13, 13)
        Me.lblFC.TabIndex = 32
        Me.lblFC.Text = "0"
        '
        'lblBD
        '
        Me.lblBD.AutoSize = True
        Me.lblBD.Location = New System.Drawing.Point(129, 24)
        Me.lblBD.Name = "lblBD"
        Me.lblBD.Size = New System.Drawing.Size(43, 13)
        Me.lblBD.TabIndex = 25
        Me.lblBD.Text = "115200"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Flow control (ATFC)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Baud Rate (ATBD)"
        '
        'cmbBD
        '
        Me.cmbBD.FormattingEnabled = True
        Me.cmbBD.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200"})
        Me.cmbBD.Location = New System.Drawing.Point(237, 21)
        Me.cmbBD.MaxLength = 6
        Me.cmbBD.Name = "cmbBD"
        Me.cmbBD.Size = New System.Drawing.Size(61, 21)
        Me.cmbBD.TabIndex = 59
        '
        'txtFC
        '
        Me.txtFC.Location = New System.Drawing.Point(178, 72)
        Me.txtFC.MaxLength = 1
        Me.txtFC.Name = "txtFC"
        Me.txtFC.Size = New System.Drawing.Size(17, 20)
        Me.txtFC.TabIndex = 46
        '
        'gboxSerial
        '
        Me.gboxSerial.Controls.Add(Me.cmbSM)
        Me.gboxSerial.Controls.Add(Me.txtSM)
        Me.gboxSerial.Controls.Add(Me.Label14)
        Me.gboxSerial.Controls.Add(Me.lblSM)
        Me.gboxSerial.Controls.Add(Me.rbtnFCOff)
        Me.gboxSerial.Controls.Add(Me.rbtnFCOn)
        Me.gboxSerial.Controls.Add(Me.txtFC)
        Me.gboxSerial.Controls.Add(Me.cmbBD)
        Me.gboxSerial.Controls.Add(Me.Label3)
        Me.gboxSerial.Controls.Add(Me.Label10)
        Me.gboxSerial.Controls.Add(Me.lblBD)
        Me.gboxSerial.Controls.Add(Me.lblFC)
        Me.gboxSerial.Controls.Add(Me.txtBD)
        Me.gboxSerial.Location = New System.Drawing.Point(6, 98)
        Me.gboxSerial.Name = "gboxSerial"
        Me.gboxSerial.Size = New System.Drawing.Size(394, 113)
        Me.gboxSerial.TabIndex = 60
        Me.gboxSerial.TabStop = False
        Me.gboxSerial.Text = "Serial, sleep and flow control"
        '
        'cmbSM
        '
        Me.cmbSM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSM.FormattingEnabled = True
        Me.cmbSM.Items.AddRange(New Object() {"Sleep Off", "Sleep pin high", "Sleep pin low"})
        Me.cmbSM.Location = New System.Drawing.Point(201, 46)
        Me.cmbSM.Name = "cmbSM"
        Me.cmbSM.Size = New System.Drawing.Size(105, 21)
        Me.cmbSM.TabIndex = 68
        '
        'txtSM
        '
        Me.txtSM.Location = New System.Drawing.Point(178, 46)
        Me.txtSM.MaxLength = 1
        Me.txtSM.Name = "txtSM"
        Me.txtSM.Size = New System.Drawing.Size(17, 20)
        Me.txtSM.TabIndex = 67
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 13)
        Me.Label14.TabIndex = 65
        Me.Label14.Text = "Sleep mode (ATSM)"
        '
        'lblSM
        '
        Me.lblSM.AutoSize = True
        Me.lblSM.Location = New System.Drawing.Point(159, 49)
        Me.lblSM.Name = "lblSM"
        Me.lblSM.Size = New System.Drawing.Size(13, 13)
        Me.lblSM.TabIndex = 66
        Me.lblSM.Text = "0"
        '
        'rbtnFCOff
        '
        Me.rbtnFCOff.AutoSize = True
        Me.rbtnFCOff.Location = New System.Drawing.Point(244, 71)
        Me.rbtnFCOff.Name = "rbtnFCOff"
        Me.rbtnFCOff.Size = New System.Drawing.Size(39, 17)
        Me.rbtnFCOff.TabIndex = 61
        Me.rbtnFCOff.TabStop = True
        Me.rbtnFCOff.Text = "Off"
        Me.rbtnFCOff.UseVisualStyleBackColor = True
        '
        'rbtnFCOn
        '
        Me.rbtnFCOn.AutoSize = True
        Me.rbtnFCOn.Location = New System.Drawing.Point(201, 71)
        Me.rbtnFCOn.Name = "rbtnFCOn"
        Me.rbtnFCOn.Size = New System.Drawing.Size(39, 17)
        Me.rbtnFCOn.TabIndex = 60
        Me.rbtnFCOn.TabStop = True
        Me.rbtnFCOn.Text = "On"
        Me.rbtnFCOn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtnEEOff)
        Me.GroupBox2.Controls.Add(Me.txtEK)
        Me.GroupBox2.Controls.Add(Me.rbtnEEOn)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lblEA)
        Me.GroupBox2.Controls.Add(Me.lblEK)
        Me.GroupBox2.Controls.Add(Me.lblEE)
        Me.GroupBox2.Controls.Add(Me.txtEA)
        Me.GroupBox2.Controls.Add(Me.txtEE)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 217)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(709, 99)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Encryption"
        '
        'rbtnEEOff
        '
        Me.rbtnEEOff.AutoSize = True
        Me.rbtnEEOff.Location = New System.Drawing.Point(244, 18)
        Me.rbtnEEOff.Name = "rbtnEEOff"
        Me.rbtnEEOff.Size = New System.Drawing.Size(39, 17)
        Me.rbtnEEOff.TabIndex = 70
        Me.rbtnEEOff.TabStop = True
        Me.rbtnEEOff.Text = "Off"
        Me.rbtnEEOff.UseVisualStyleBackColor = True
        '
        'rbtnEEOn
        '
        Me.rbtnEEOn.AutoSize = True
        Me.rbtnEEOn.Location = New System.Drawing.Point(201, 18)
        Me.rbtnEEOn.Name = "rbtnEEOn"
        Me.rbtnEEOn.Size = New System.Drawing.Size(39, 17)
        Me.rbtnEEOn.TabIndex = 69
        Me.rbtnEEOn.TabStop = True
        Me.rbtnEEOn.Text = "On"
        Me.rbtnEEOn.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.lblFreq)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.txtnCN)
        Me.GroupBox3.Controls.Add(Me.lblCN)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.txtCN)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.cmbCS)
        Me.GroupBox3.Controls.Add(Me.lblCS)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.txtCS)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.cmbRO)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.cmbPK)
        Me.GroupBox3.Controls.Add(Me.cmbDR)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.cmbPL)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.cmbCH)
        Me.GroupBox3.Controls.Add(Me.txtCH)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.lblRO)
        Me.GroupBox3.Controls.Add(Me.lblCH)
        Me.GroupBox3.Controls.Add(Me.lblPK)
        Me.GroupBox3.Controls.Add(Me.txtPL)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.lblPL)
        Me.GroupBox3.Controls.Add(Me.txtDR)
        Me.GroupBox3.Controls.Add(Me.txtPK)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtRO)
        Me.GroupBox3.Controls.Add(Me.lblDR)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 194)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(701, 122)
        Me.GroupBox3.TabIndex = 62
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Radio"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(557, 96)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(29, 13)
        Me.Label34.TabIndex = 86
        Me.Label34.Text = "MHz"
        '
        'lblFreq
        '
        Me.lblFreq.AutoSize = True
        Me.lblFreq.Location = New System.Drawing.Point(514, 95)
        Me.lblFreq.Name = "lblFreq"
        Me.lblFreq.Size = New System.Drawing.Size(37, 13)
        Me.lblFreq.TabIndex = 85
        Me.lblFreq.Text = "00000"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(398, 96)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(102, 13)
        Me.Label31.TabIndex = 84
        Me.Label31.Text = "Effective Frequency"
        '
        'txtnCN
        '
        Me.txtnCN.Location = New System.Drawing.Point(602, 67)
        Me.txtnCN.MaxLength = 3
        Me.txtnCN.Name = "txtnCN"
        Me.txtnCN.Size = New System.Drawing.Size(31, 20)
        Me.txtnCN.TabIndex = 83
        '
        'lblCN
        '
        Me.lblCN.AutoSize = True
        Me.lblCN.Location = New System.Drawing.Point(532, 70)
        Me.lblCN.Name = "lblCN"
        Me.lblCN.Size = New System.Drawing.Size(19, 13)
        Me.lblCN.TabIndex = 81
        Me.lblCN.Text = "00"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(398, 70)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(122, 13)
        Me.Label35.TabIndex = 80
        Me.Label35.Text = "Channel number (ATCN)"
        '
        'txtCN
        '
        Me.txtCN.Location = New System.Drawing.Point(557, 67)
        Me.txtCN.MaxLength = 2
        Me.txtCN.Name = "txtCN"
        Me.txtCN.Size = New System.Drawing.Size(31, 20)
        Me.txtCN.TabIndex = 82
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(659, 42)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(26, 13)
        Me.Label30.TabIndex = 79
        Me.Label30.Text = "kHz"
        '
        'cmbCS
        '
        Me.cmbCS.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCS.FormattingEnabled = True
        Me.cmbCS.Items.AddRange(New Object() {"25", "50", "100", "150", "200", "250"})
        Me.cmbCS.Location = New System.Drawing.Point(602, 43)
        Me.cmbCS.MaxLength = 3
        Me.cmbCS.Name = "cmbCS"
        Me.cmbCS.Size = New System.Drawing.Size(59, 21)
        Me.cmbCS.TabIndex = 78
        '
        'lblCS
        '
        Me.lblCS.AutoSize = True
        Me.lblCS.Location = New System.Drawing.Point(532, 46)
        Me.lblCS.Name = "lblCS"
        Me.lblCS.Size = New System.Drawing.Size(19, 13)
        Me.lblCS.TabIndex = 76
        Me.lblCS.Text = "00"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(398, 46)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(123, 13)
        Me.Label32.TabIndex = 75
        Me.Label32.Text = "Channel spacing (ATCS)"
        '
        'txtCS
        '
        Me.txtCS.Location = New System.Drawing.Point(557, 43)
        Me.txtCS.MaxLength = 2
        Me.txtCS.Name = "txtCS"
        Me.txtCS.Size = New System.Drawing.Size(31, 20)
        Me.txtCS.TabIndex = 77
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(283, 96)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(22, 13)
        Me.Label25.TabIndex = 74
        Me.Label25.Text = "mS"
        '
        'cmbRO
        '
        Me.cmbRO.BackColor = System.Drawing.SystemColors.Window
        Me.cmbRO.FormattingEnabled = True
        Me.cmbRO.Items.AddRange(New Object() {"50", "100", "150", "200", "250", "500", "1000", "2500", "5000"})
        Me.cmbRO.Location = New System.Drawing.Point(219, 93)
        Me.cmbRO.Name = "cmbRO"
        Me.cmbRO.Size = New System.Drawing.Size(59, 21)
        Me.cmbRO.TabIndex = 73
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(283, 72)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(33, 13)
        Me.Label21.TabIndex = 72
        Me.Label21.Text = "chars"
        '
        'cmbPK
        '
        Me.cmbPK.BackColor = System.Drawing.SystemColors.Window
        Me.cmbPK.FormattingEnabled = True
        Me.cmbPK.Items.AddRange(New Object() {"12", "20", "80", "140", "160", "240"})
        Me.cmbPK.Location = New System.Drawing.Point(219, 69)
        Me.cmbPK.Name = "cmbPK"
        Me.cmbPK.Size = New System.Drawing.Size(59, 21)
        Me.cmbPK.TabIndex = 71
        '
        'cmbDR
        '
        Me.cmbDR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDR.FormattingEnabled = True
        Me.cmbDR.Items.AddRange(New Object() {"250", "38.4", "1.2", "100", "50"})
        Me.cmbDR.Location = New System.Drawing.Point(219, 42)
        Me.cmbDR.Name = "cmbDR"
        Me.cmbDR.Size = New System.Drawing.Size(59, 21)
        Me.cmbDR.TabIndex = 70
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(283, 47)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(30, 13)
        Me.Label20.TabIndex = 69
        Me.Label20.Text = "kbps"
        '
        'cmbPL
        '
        Me.cmbPL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPL.FormattingEnabled = True
        Me.cmbPL.Items.AddRange(New Object() {"-30", "-20", "-15", "-10", "-5", "0", "5", "7", "10"})
        Me.cmbPL.Location = New System.Drawing.Point(219, 17)
        Me.cmbPL.Name = "cmbPL"
        Me.cmbPL.Size = New System.Drawing.Size(59, 21)
        Me.cmbPL.TabIndex = 68
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(282, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 13)
        Me.Label19.TabIndex = 67
        Me.Label19.Text = "dBm"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(659, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 13)
        Me.Label18.TabIndex = 66
        Me.Label18.Text = "MHz"
        '
        'cmbCH
        '
        Me.cmbCH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCH.FormattingEnabled = True
        Me.cmbCH.Items.AddRange(New Object() {"915", "903", "868", "433.5", "868.3", "315"})
        Me.cmbCH.Location = New System.Drawing.Point(602, 16)
        Me.cmbCH.Name = "cmbCH"
        Me.cmbCH.Size = New System.Drawing.Size(59, 21)
        Me.cmbCH.TabIndex = 65
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmbNT)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.lblNT)
        Me.GroupBox4.Controls.Add(Me.txtNT)
        Me.GroupBox4.Controls.Add(Me.txtI2)
        Me.GroupBox4.Controls.Add(Me.txtID)
        Me.GroupBox4.Controls.Add(Me.lblI2)
        Me.GroupBox4.Controls.Add(Me.lblID)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 14)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(378, 86)
        Me.GroupBox4.TabIndex = 63
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Mode"
        '
        'cmbNT
        '
        Me.cmbNT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNT.FormattingEnabled = True
        Me.cmbNT.Items.AddRange(New Object() {"Normal", "Repeater"})
        Me.cmbNT.Location = New System.Drawing.Point(219, 15)
        Me.cmbNT.Name = "cmbNT"
        Me.cmbNT.Size = New System.Drawing.Size(105, 21)
        Me.cmbNT.TabIndex = 63
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Guard Character (ATCC)"
        '
        'lblCC
        '
        Me.lblCC.AutoSize = True
        Me.lblCC.Location = New System.Drawing.Point(155, 19)
        Me.lblCC.Name = "lblCC"
        Me.lblCC.Size = New System.Drawing.Size(13, 13)
        Me.lblCC.TabIndex = 66
        Me.lblCC.Text = "+"
        '
        'txtCC
        '
        Me.txtCC.BackColor = System.Drawing.SystemColors.Window
        Me.txtCC.Location = New System.Drawing.Point(174, 16)
        Me.txtCC.MaxLength = 1
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(16, 20)
        Me.txtCC.TabIndex = 67
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.General)
        Me.TabControl1.Controls.Add(Me.Advanced)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.Log)
        Me.TabControl1.Controls.Add(Me.UploadFirmware)
        Me.TabControl1.Controls.Add(Me.SerialMonitor)
        Me.TabControl1.Location = New System.Drawing.Point(12, 33)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(745, 348)
        Me.TabControl1.TabIndex = 64
        '
        'General
        '
        Me.General.Controls.Add(Me.GroupBox8)
        Me.General.Controls.Add(Me.GroupBox5)
        Me.General.Controls.Add(Me.gboxSerial)
        Me.General.Controls.Add(Me.GroupBox2)
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(737, 322)
        Me.General.TabIndex = 0
        Me.General.Text = "General"
        Me.General.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label64)
        Me.GroupBox8.Controls.Add(Me.Label63)
        Me.GroupBox8.Controls.Add(Me.Label62)
        Me.GroupBox8.Controls.Add(Me.Label57)
        Me.GroupBox8.Controls.Add(Me.Label56)
        Me.GroupBox8.Controls.Add(Me.Label55)
        Me.GroupBox8.Controls.Add(Me.Label54)
        Me.GroupBox8.Location = New System.Drawing.Point(406, 14)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(309, 197)
        Me.GroupBox8.TabIndex = 63
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Button Actions"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.ForeColor = System.Drawing.Color.DarkRed
        Me.Label64.Location = New System.Drawing.Point(17, 141)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(27, 13)
        Me.Label64.TabIndex = 78
        Me.Label64.Text = "TIP:"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.ForeColor = System.Drawing.Color.DarkRed
        Me.Label63.Location = New System.Drawing.Point(16, 173)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(257, 13)
        Me.Label63.TabIndex = 77
        Me.Label63.Text = "and a simple power cycle will restore your old settings"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.ForeColor = System.Drawing.Color.DarkRed
        Me.Label62.Location = New System.Drawing.Point(17, 157)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(246, 13)
        Me.Label62.TabIndex = 76
        Me.Label62.Text = "By not using ATWR you can ""try out"" new settings"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.ForeColor = System.Drawing.Color.DarkRed
        Me.Label57.Location = New System.Drawing.Point(17, 79)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(239, 13)
        Me.Label57.TabIndex = 75
        Me.Label57.Text = "ATWR = Write the current memory into EEPROM"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.ForeColor = System.Drawing.Color.DarkRed
        Me.Label56.Location = New System.Drawing.Point(17, 60)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(277, 13)
        Me.Label56.TabIndex = 74
        Me.Label56.Text = "Apply = Make the XRF use the settings in current memory"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.ForeColor = System.Drawing.Color.DarkRed
        Me.Label55.Location = New System.Drawing.Point(17, 41)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(258, 13)
        Me.Label55.TabIndex = 73
        Me.Label55.Text = "Upload = Write the current settings to current memory"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.ForeColor = System.Drawing.Color.DarkRed
        Me.Label54.Location = New System.Drawing.Point(17, 22)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(239, 13)
        Me.Label54.TabIndex = 72
        Me.Label54.Text = "Download = Get the settings from current memory"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblVR)
        Me.GroupBox5.Controls.Add(Me.Label28)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 14)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(394, 78)
        Me.GroupBox5.TabIndex = 62
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "General"
        '
        'lblVR
        '
        Me.lblVR.AutoSize = True
        Me.lblVR.Location = New System.Drawing.Point(129, 20)
        Me.lblVR.Name = "lblVR"
        Me.lblVR.Size = New System.Drawing.Size(34, 13)
        Me.lblVR.TabIndex = 71
        Me.lblVR.Text = "Vxxxx"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(12, 20)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(65, 13)
        Me.Label28.TabIndex = 70
        Me.Label28.Text = "XRF version"
        '
        'Advanced
        '
        Me.Advanced.Controls.Add(Me.GroupBox7)
        Me.Advanced.Controls.Add(Me.GroupBox6)
        Me.Advanced.Controls.Add(Me.GroupBox3)
        Me.Advanced.Controls.Add(Me.GroupBox4)
        Me.Advanced.Location = New System.Drawing.Point(4, 22)
        Me.Advanced.Name = "Advanced"
        Me.Advanced.Padding = New System.Windows.Forms.Padding(3)
        Me.Advanced.Size = New System.Drawing.Size(737, 322)
        Me.Advanced.TabIndex = 1
        Me.Advanced.Text = "Advanced"
        Me.Advanced.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label51)
        Me.GroupBox7.Controls.Add(Me.Label24)
        Me.GroupBox7.Controls.Add(Me.Label23)
        Me.GroupBox7.Controls.Add(Me.Label22)
        Me.GroupBox7.Location = New System.Drawing.Point(400, 14)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(307, 174)
        Me.GroupBox7.TabIndex = 69
        Me.GroupBox7.TabStop = False
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.DarkRed
        Me.Label51.Location = New System.Drawing.Point(23, 67)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(251, 20)
        Me.Label51.TabIndex = 73
        Me.Label51.Text = "Modification to these settings "
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.DarkRed
        Me.Label24.Location = New System.Drawing.Point(23, 120)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(233, 20)
        Me.Label24.TabIndex = 72
        Me.Label24.Text = "only change those you need"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.DarkRed
        Me.Label23.Location = New System.Drawing.Point(23, 93)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(260, 20)
        Me.Label23.TabIndex = 71
        Me.Label23.Text = "can render the device unusable"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.DarkRed
        Me.Label22.Location = New System.Drawing.Point(23, 27)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(113, 24)
        Me.Label22.TabIndex = 70
        Me.Label22.Text = "WARNING!"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.txtCC)
        Me.GroupBox6.Controls.Add(Me.lblCC)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 112)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(378, 76)
        Me.GroupBox6.TabIndex = 68
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Special"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox12)
        Me.TabPage1.Controls.Add(Me.gboxRP3)
        Me.TabPage1.Controls.Add(Me.gboxRP2)
        Me.TabPage1.Controls.Add(Me.gboxRP1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(737, 322)
        Me.TabPage1.TabIndex = 5
        Me.TabPage1.Text = "Remote Programming"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.Label87)
        Me.GroupBox12.Controls.Add(Me.Label88)
        Me.GroupBox12.Controls.Add(Me.Label85)
        Me.GroupBox12.Controls.Add(Me.Label86)
        Me.GroupBox12.Controls.Add(Me.Label84)
        Me.GroupBox12.Controls.Add(Me.Label83)
        Me.GroupBox12.Controls.Add(Me.Label82)
        Me.GroupBox12.Controls.Add(Me.Label81)
        Me.GroupBox12.Controls.Add(Me.Label80)
        Me.GroupBox12.Controls.Add(Me.Label79)
        Me.GroupBox12.Controls.Add(Me.Label78)
        Me.GroupBox12.Controls.Add(Me.Label77)
        Me.GroupBox12.Controls.Add(Me.Label76)
        Me.GroupBox12.Controls.Add(Me.Label75)
        Me.GroupBox12.Controls.Add(Me.Label74)
        Me.GroupBox12.Controls.Add(Me.Label73)
        Me.GroupBox12.Controls.Add(Me.Label72)
        Me.GroupBox12.Controls.Add(Me.Label71)
        Me.GroupBox12.Controls.Add(Me.Label69)
        Me.GroupBox12.Controls.Add(Me.Label68)
        Me.GroupBox12.Controls.Add(Me.Label66)
        Me.GroupBox12.Location = New System.Drawing.Point(392, 10)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(331, 306)
        Me.GroupBox12.TabIndex = 3
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Remote programming"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Location = New System.Drawing.Point(173, 280)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(37, 13)
        Me.Label87.TabIndex = 20
        Me.Label87.Text = "19200"
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Location = New System.Drawing.Point(74, 280)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(64, 13)
        Me.Label88.TabIndex = 19
        Me.Label88.Text = "Arduino 168"
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Location = New System.Drawing.Point(173, 267)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(37, 13)
        Me.Label85.TabIndex = 18
        Me.Label85.Text = "57600"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Location = New System.Drawing.Point(74, 267)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(64, 13)
        Me.Label86.TabIndex = 17
        Me.Label86.Text = "Arduino 328"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Location = New System.Drawing.Point(173, 254)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(43, 13)
        Me.Label84.TabIndex = 16
        Me.Label84.Text = "115200"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Location = New System.Drawing.Point(74, 254)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(66, 13)
        Me.Label83.TabIndex = 15
        Me.Label83.Text = "Arduino Uno"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Location = New System.Drawing.Point(6, 254)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(58, 13)
        Me.Label82.TabIndex = 14
        Me.Label82.Text = "Baud rates"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Location = New System.Drawing.Point(40, 156)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(231, 13)
        Me.Label81.TabIndex = 13
        Me.Label81.Text = "Set the appropriate baud rate for the bootloader"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(40, 95)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(231, 13)
        Me.Label80.TabIndex = 12
        Me.Label80.Text = "Set the appropriate baud rate for the bootloader"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Location = New System.Drawing.Point(6, 55)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(308, 13)
        Me.Label79.TabIndex = 11
        Me.Label79.Text = "of the host and the target will be remotely reset and programmed"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Location = New System.Drawing.Point(6, 42)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(285, 13)
        Me.Label78.TabIndex = 10
        Me.Label78.Text = "Once the parameters are set up then just use the COM port"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Location = New System.Drawing.Point(6, 29)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(276, 13)
        Me.Label77.TabIndex = 9
        Me.Label77.Text = "program to wirelessly program Arduino and PIC controllers"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Location = New System.Drawing.Point(6, 16)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(308, 13)
        Me.Label76.TabIndex = 8
        Me.Label76.Text = "Remote programming allows you to use the Arduino IDE or other"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Location = New System.Drawing.Point(6, 223)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(302, 13)
        Me.Label75.TabIndex = 7
        Me.Label75.Text = "normal radio traffic, the offset should be the same in all devices"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Location = New System.Drawing.Point(6, 208)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(259, 13)
        Me.Label74.TabIndex = 6
        Me.Label74.Text = "programming does not occupy the same frequency as"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(6, 193)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(245, 13)
        Me.Label73.TabIndex = 5
        Me.Label73.Text = "It may be helpful to set a channel offset so that the"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Location = New System.Drawing.Point(40, 169)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(113, 13)
        Me.Label72.TabIndex = 4
        Me.Label72.Text = "Set the ID of this node"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Location = New System.Drawing.Point(40, 121)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(101, 13)
        Me.Label71.TabIndex = 3
        Me.Label71.Text = "Enable remote reset"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(40, 108)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(147, 13)
        Me.Label69.TabIndex = 2
        Me.Label69.Text = "Set the ID of the remote node"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(6, 79)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(93, 13)
        Me.Label68.TabIndex = 1
        Me.Label68.Text = "On the host (local)"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(6, 143)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(110, 13)
        Me.Label66.TabIndex = 0
        Me.Label66.Text = "On the target (remote)"
        '
        'gboxRP3
        '
        Me.gboxRP3.Controls.Add(Me.txtRC)
        Me.gboxRP3.Controls.Add(Me.Label67)
        Me.gboxRP3.Controls.Add(Me.lblRC)
        Me.gboxRP3.Location = New System.Drawing.Point(11, 228)
        Me.gboxRP3.Name = "gboxRP3"
        Me.gboxRP3.Size = New System.Drawing.Size(359, 62)
        Me.gboxRP3.TabIndex = 2
        Me.gboxRP3.TabStop = False
        Me.gboxRP3.Text = "Common settings"
        '
        'txtRC
        '
        Me.txtRC.Location = New System.Drawing.Point(171, 27)
        Me.txtRC.MaxLength = 2
        Me.txtRC.Name = "txtRC"
        Me.txtRC.Size = New System.Drawing.Size(31, 20)
        Me.txtRC.TabIndex = 72
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(12, 30)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(113, 13)
        Me.Label67.TabIndex = 70
        Me.Label67.Text = "Channel offset (ATRC)"
        '
        'lblRC
        '
        Me.lblRC.AutoSize = True
        Me.lblRC.Location = New System.Drawing.Point(146, 30)
        Me.lblRC.Name = "lblRC"
        Me.lblRC.Size = New System.Drawing.Size(19, 13)
        Me.lblRC.TabIndex = 71
        Me.lblRC.Text = "00"
        '
        'gboxRP2
        '
        Me.gboxRP2.Controls.Add(Me.lblMY)
        Me.gboxRP2.Controls.Add(Me.Label70)
        Me.gboxRP2.Controls.Add(Me.txtMY)
        Me.gboxRP2.Location = New System.Drawing.Point(11, 146)
        Me.gboxRP2.Name = "gboxRP2"
        Me.gboxRP2.Size = New System.Drawing.Size(359, 64)
        Me.gboxRP2.TabIndex = 1
        Me.gboxRP2.TabStop = False
        Me.gboxRP2.Text = "Remote settings"
        '
        'lblMY
        '
        Me.lblMY.AutoSize = True
        Me.lblMY.Location = New System.Drawing.Point(146, 28)
        Me.lblMY.Name = "lblMY"
        Me.lblMY.Size = New System.Drawing.Size(18, 13)
        Me.lblMY.TabIndex = 71
        Me.lblMY.Text = "ID"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(12, 28)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(86, 13)
        Me.Label70.TabIndex = 70
        Me.Label70.Text = "Node ID (ATMY)"
        '
        'txtMY
        '
        Me.txtMY.Location = New System.Drawing.Point(171, 25)
        Me.txtMY.MaxLength = 2
        Me.txtMY.Name = "txtMY"
        Me.txtMY.Size = New System.Drawing.Size(31, 20)
        Me.txtMY.TabIndex = 72
        '
        'gboxRP1
        '
        Me.gboxRP1.Controls.Add(Me.rbtnRPoff)
        Me.gboxRP1.Controls.Add(Me.rbtnRPon)
        Me.gboxRP1.Controls.Add(Me.txtRP)
        Me.gboxRP1.Controls.Add(Me.Label65)
        Me.gboxRP1.Controls.Add(Me.lblRP)
        Me.gboxRP1.Controls.Add(Me.lblRI)
        Me.gboxRP1.Controls.Add(Me.labelRI)
        Me.gboxRP1.Controls.Add(Me.txtRI)
        Me.gboxRP1.Location = New System.Drawing.Point(11, 10)
        Me.gboxRP1.Name = "gboxRP1"
        Me.gboxRP1.Size = New System.Drawing.Size(358, 117)
        Me.gboxRP1.TabIndex = 0
        Me.gboxRP1.TabStop = False
        Me.gboxRP1.Text = "Host settings"
        '
        'rbtnRPoff
        '
        Me.rbtnRPoff.AutoSize = True
        Me.rbtnRPoff.Location = New System.Drawing.Point(237, 75)
        Me.rbtnRPoff.Name = "rbtnRPoff"
        Me.rbtnRPoff.Size = New System.Drawing.Size(39, 17)
        Me.rbtnRPoff.TabIndex = 66
        Me.rbtnRPoff.TabStop = True
        Me.rbtnRPoff.Text = "Off"
        Me.rbtnRPoff.UseVisualStyleBackColor = True
        '
        'rbtnRPon
        '
        Me.rbtnRPon.AutoSize = True
        Me.rbtnRPon.Location = New System.Drawing.Point(194, 75)
        Me.rbtnRPon.Name = "rbtnRPon"
        Me.rbtnRPon.Size = New System.Drawing.Size(39, 17)
        Me.rbtnRPon.TabIndex = 65
        Me.rbtnRPon.TabStop = True
        Me.rbtnRPon.Text = "On"
        Me.rbtnRPon.UseVisualStyleBackColor = True
        '
        'txtRP
        '
        Me.txtRP.Location = New System.Drawing.Point(171, 76)
        Me.txtRP.MaxLength = 1
        Me.txtRP.Name = "txtRP"
        Me.txtRP.Size = New System.Drawing.Size(17, 20)
        Me.txtRP.TabIndex = 64
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(12, 79)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(139, 13)
        Me.Label65.TabIndex = 62
        Me.Label65.Text = "Enable remote reset (ATRP)"
        '
        'lblRP
        '
        Me.lblRP.AutoSize = True
        Me.lblRP.Location = New System.Drawing.Point(152, 79)
        Me.lblRP.Name = "lblRP"
        Me.lblRP.Size = New System.Drawing.Size(13, 13)
        Me.lblRP.TabIndex = 63
        Me.lblRP.Text = "0"
        '
        'lblRI
        '
        Me.lblRI.AutoSize = True
        Me.lblRI.Location = New System.Drawing.Point(146, 31)
        Me.lblRI.Name = "lblRI"
        Me.lblRI.Size = New System.Drawing.Size(18, 13)
        Me.lblRI.TabIndex = 52
        Me.lblRI.Text = "ID"
        '
        'labelRI
        '
        Me.labelRI.AutoSize = True
        Me.labelRI.Location = New System.Drawing.Point(12, 31)
        Me.labelRI.Name = "labelRI"
        Me.labelRI.Size = New System.Drawing.Size(92, 13)
        Me.labelRI.TabIndex = 51
        Me.labelRI.Text = "Remote ID (ATRI)"
        '
        'txtRI
        '
        Me.txtRI.Location = New System.Drawing.Point(171, 28)
        Me.txtRI.MaxLength = 2
        Me.txtRI.Name = "txtRI"
        Me.txtRI.Size = New System.Drawing.Size(31, 20)
        Me.txtRI.TabIndex = 53
        '
        'Log
        '
        Me.Log.Controls.Add(Me.rtxtLog)
        Me.Log.Location = New System.Drawing.Point(4, 22)
        Me.Log.Name = "Log"
        Me.Log.Size = New System.Drawing.Size(737, 322)
        Me.Log.TabIndex = 2
        Me.Log.Text = "Log Window"
        Me.Log.UseVisualStyleBackColor = True
        '
        'rtxtLog
        '
        Me.rtxtLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtLog.ForeColor = System.Drawing.Color.Blue
        Me.rtxtLog.Location = New System.Drawing.Point(2, 3)
        Me.rtxtLog.Name = "rtxtLog"
        Me.rtxtLog.ReadOnly = True
        Me.rtxtLog.Size = New System.Drawing.Size(734, 316)
        Me.rtxtLog.TabIndex = 0
        Me.rtxtLog.Text = ""
        '
        'UploadFirmware
        '
        Me.UploadFirmware.Controls.Add(Me.btnProgAdvanced)
        Me.UploadFirmware.Controls.Add(Me.rbtnBOOT)
        Me.UploadFirmware.Controls.Add(Me.rbtnXRF)
        Me.UploadFirmware.Controls.Add(Me.GroupBox9)
        Me.UploadFirmware.Controls.Add(Me.Label29)
        Me.UploadFirmware.Controls.Add(Me.btnCommit)
        Me.UploadFirmware.Controls.Add(Me.ProgressBar1)
        Me.UploadFirmware.Controls.Add(Me.btnVerify)
        Me.UploadFirmware.Controls.Add(Me.btnGo)
        Me.UploadFirmware.Controls.Add(Me.Label26)
        Me.UploadFirmware.Controls.Add(Me.btnfile)
        Me.UploadFirmware.Controls.Add(Me.txtfilename)
        Me.UploadFirmware.Location = New System.Drawing.Point(4, 22)
        Me.UploadFirmware.Name = "UploadFirmware"
        Me.UploadFirmware.Size = New System.Drawing.Size(737, 322)
        Me.UploadFirmware.TabIndex = 3
        Me.UploadFirmware.Text = "Upload Firmware"
        Me.UploadFirmware.UseVisualStyleBackColor = True
        '
        'btnProgAdvanced
        '
        Me.btnProgAdvanced.Location = New System.Drawing.Point(648, 176)
        Me.btnProgAdvanced.Name = "btnProgAdvanced"
        Me.btnProgAdvanced.Size = New System.Drawing.Size(75, 23)
        Me.btnProgAdvanced.TabIndex = 28
        Me.btnProgAdvanced.Text = "Advanced"
        Me.btnProgAdvanced.UseVisualStyleBackColor = True
        '
        'rbtnBOOT
        '
        Me.rbtnBOOT.AutoSize = True
        Me.rbtnBOOT.Location = New System.Drawing.Point(17, 124)
        Me.rbtnBOOT.Name = "rbtnBOOT"
        Me.rbtnBOOT.Size = New System.Drawing.Size(347, 17)
        Me.rbtnBOOT.TabIndex = 27
        Me.rbtnBOOT.Text = "XRF in bootloader mode (only applicable to the bootloader version 2)"
        Me.rbtnBOOT.UseVisualStyleBackColor = True
        Me.rbtnBOOT.Visible = False
        '
        'rbtnXRF
        '
        Me.rbtnXRF.AutoSize = True
        Me.rbtnXRF.Checked = True
        Me.rbtnXRF.Location = New System.Drawing.Point(17, 101)
        Me.rbtnXRF.Name = "rbtnXRF"
        Me.rbtnXRF.Size = New System.Drawing.Size(237, 17)
        Me.rbtnXRF.TabIndex = 26
        Me.rbtnXRF.TabStop = True
        Me.rbtnXRF.Text = "XRF in application mode (Serial or aPDevice)"
        Me.rbtnXRF.UseVisualStyleBackColor = True
        Me.rbtnXRF.Visible = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label60)
        Me.GroupBox9.Controls.Add(Me.Label59)
        Me.GroupBox9.Controls.Add(Me.Label58)
        Me.GroupBox9.Location = New System.Drawing.Point(6, 197)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(717, 122)
        Me.GroupBox9.TabIndex = 25
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Warning"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.DarkRed
        Me.Label60.Location = New System.Drawing.Point(18, 84)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(622, 20)
        Me.Label60.TabIndex = 76
        Me.Label60.Text = "an incomplete upload will require the device to be reprogramed at the factory"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.DarkRed
        Me.Label59.Location = New System.Drawing.Point(18, 56)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(526, 20)
        Me.Label59.TabIndex = 75
        Me.Label59.Text = "when updating never use batteries, always a stable power supply"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.DarkRed
        Me.Label58.Location = New System.Drawing.Point(16, 27)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(488, 20)
        Me.Label58.TabIndex = 74
        Me.Label58.Text = "We recomend that firmware is only updated when necessary"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(12, 41)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(48, 13)
        Me.Label29.TabIndex = 24
        Me.Label29.Text = "Progress"
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCommit.Location = New System.Drawing.Point(648, 100)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(75, 23)
        Me.btnCommit.TabIndex = 22
        Me.btnCommit.Text = "Commit"
        Me.btnCommit.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 56)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(717, 24)
        Me.ProgressBar1.TabIndex = 20
        '
        'btnVerify
        '
        Me.btnVerify.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVerify.Location = New System.Drawing.Point(567, 100)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(75, 23)
        Me.btnVerify.TabIndex = 17
        Me.btnVerify.Text = "Verify"
        Me.btnVerify.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGo.Location = New System.Drawing.Point(485, 100)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 16
        Me.btnGo.Text = "Program"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(3, 14)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(79, 13)
        Me.Label26.TabIndex = 15
        Me.Label26.Text = "HEX File Name"
        '
        'btnfile
        '
        Me.btnfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnfile.Location = New System.Drawing.Point(697, 8)
        Me.btnfile.Name = "btnfile"
        Me.btnfile.Size = New System.Drawing.Size(26, 23)
        Me.btnfile.TabIndex = 14
        Me.btnfile.Text = "..."
        Me.btnfile.UseVisualStyleBackColor = True
        '
        'txtfilename
        '
        Me.txtfilename.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtfilename.Location = New System.Drawing.Point(88, 11)
        Me.txtfilename.Name = "txtfilename"
        Me.txtfilename.Size = New System.Drawing.Size(603, 20)
        Me.txtfilename.TabIndex = 13
        '
        'SerialMonitor
        '
        Me.SerialMonitor.Controls.Add(Me.rtxtSerialMonitor)
        Me.SerialMonitor.Controls.Add(Me.CheckBox1)
        Me.SerialMonitor.Controls.Add(Me.TextBox1)
        Me.SerialMonitor.Controls.Add(Me.Label61)
        Me.SerialMonitor.Controls.Add(Me.Label50)
        Me.SerialMonitor.Controls.Add(Me.Label49)
        Me.SerialMonitor.Controls.Add(Me.Label41)
        Me.SerialMonitor.Controls.Add(Me.Label42)
        Me.SerialMonitor.Controls.Add(Me.Label40)
        Me.SerialMonitor.Controls.Add(Me.Label46)
        Me.SerialMonitor.Controls.Add(Me.Label47)
        Me.SerialMonitor.Controls.Add(Me.Label48)
        Me.SerialMonitor.Controls.Add(Me.Label43)
        Me.SerialMonitor.Controls.Add(Me.Label44)
        Me.SerialMonitor.Controls.Add(Me.Label45)
        Me.SerialMonitor.Controls.Add(Me.Label39)
        Me.SerialMonitor.Controls.Add(Me.Label38)
        Me.SerialMonitor.Controls.Add(Me.Label37)
        Me.SerialMonitor.Controls.Add(Me.Label36)
        Me.SerialMonitor.Controls.Add(Me.Label33)
        Me.SerialMonitor.Controls.Add(Me.lblWrap)
        Me.SerialMonitor.Controls.Add(Me.cmbWrapSerialMonitor)
        Me.SerialMonitor.Controls.Add(Me.btnClearSerialMonitor)
        Me.SerialMonitor.Controls.Add(Me.btnSendSerialMonitor)
        Me.SerialMonitor.Controls.Add(Me.txtSendSerialMonitor)
        Me.SerialMonitor.Location = New System.Drawing.Point(4, 22)
        Me.SerialMonitor.Name = "SerialMonitor"
        Me.SerialMonitor.Size = New System.Drawing.Size(737, 322)
        Me.SerialMonitor.TabIndex = 4
        Me.SerialMonitor.Text = "Serial Monitor"
        Me.SerialMonitor.UseVisualStyleBackColor = True
        '
        'rtxtSerialMonitor
        '
        Me.rtxtSerialMonitor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtSerialMonitor.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtSerialMonitor.ForeColor = System.Drawing.Color.Blue
        Me.rtxtSerialMonitor.HideSelection = False
        Me.rtxtSerialMonitor.Location = New System.Drawing.Point(3, 47)
        Me.rtxtSerialMonitor.Name = "rtxtSerialMonitor"
        Me.rtxtSerialMonitor.Size = New System.Drawing.Size(731, 272)
        Me.rtxtSerialMonitor.TabIndex = 6
        Me.rtxtSerialMonitor.Text = ""
        Me.rtxtSerialMonitor.WordWrap = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(669, 28)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox1.TabIndex = 26
        Me.CheckBox1.Text = "on/off"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(476, 27)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(186, 18)
        Me.TextBox1.TabIndex = 24
        Me.TextBox1.Text = "yet to be implemented"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(448, 29)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(29, 13)
        Me.Label61.TabIndex = 25
        Me.Label61.Text = "Filter"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(93, 31)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(20, 13)
        Me.Label50.TabIndex = 23
        Me.Label50.Text = "aP"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(97, 23)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(9, 13)
        Me.Label49.TabIndex = 22
        Me.Label49.Text = "|"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(311, 31)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(19, 13)
        Me.Label41.TabIndex = 15
        Me.Label41.Text = "40"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(233, 31)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(19, 13)
        Me.Label42.TabIndex = 14
        Me.Label42.Text = "30"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(152, 32)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(19, 13)
        Me.Label40.TabIndex = 12
        Me.Label40.Text = "20"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(392, 32)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(19, 13)
        Me.Label46.TabIndex = 21
        Me.Label46.Text = "50"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(396, 25)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(9, 13)
        Me.Label47.TabIndex = 20
        Me.Label47.Text = "|"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(317, 25)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(9, 13)
        Me.Label48.TabIndex = 19
        Me.Label48.Text = "|"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(317, 23)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(9, 13)
        Me.Label43.TabIndex = 18
        Me.Label43.Text = "|"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(238, 23)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(9, 13)
        Me.Label44.TabIndex = 17
        Me.Label44.Text = "|"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(157, 25)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(9, 13)
        Me.Label45.TabIndex = 16
        Me.Label45.Text = "|"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(72, 31)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(19, 13)
        Me.Label39.TabIndex = 11
        Me.Label39.Text = "10"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(1, 31)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(13, 13)
        Me.Label38.TabIndex = 10
        Me.Label38.Text = "0"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(160, 23)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(9, 13)
        Me.Label37.TabIndex = 9
        Me.Label37.Text = "|"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(77, 23)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(9, 13)
        Me.Label36.TabIndex = 8
        Me.Label36.Text = "|"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(3, 23)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(9, 13)
        Me.Label33.TabIndex = 7
        Me.Label33.Text = "|"
        '
        'lblWrap
        '
        Me.lblWrap.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWrap.AutoSize = True
        Me.lblWrap.Location = New System.Drawing.Point(629, 7)
        Me.lblWrap.Name = "lblWrap"
        Me.lblWrap.Size = New System.Drawing.Size(33, 13)
        Me.lblWrap.TabIndex = 5
        Me.lblWrap.Text = "Wrap"
        '
        'cmbWrapSerialMonitor
        '
        Me.cmbWrapSerialMonitor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbWrapSerialMonitor.FormattingEnabled = True
        Me.cmbWrapSerialMonitor.Items.AddRange(New Object() {"none", "12", "48", "72", "80", "96", "108", "144"})
        Me.cmbWrapSerialMonitor.Location = New System.Drawing.Point(668, 4)
        Me.cmbWrapSerialMonitor.Name = "cmbWrapSerialMonitor"
        Me.cmbWrapSerialMonitor.Size = New System.Drawing.Size(55, 21)
        Me.cmbWrapSerialMonitor.TabIndex = 4
        Me.cmbWrapSerialMonitor.Text = "none"
        '
        'btnClearSerialMonitor
        '
        Me.btnClearSerialMonitor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearSerialMonitor.Location = New System.Drawing.Point(541, 3)
        Me.btnClearSerialMonitor.Name = "btnClearSerialMonitor"
        Me.btnClearSerialMonitor.Size = New System.Drawing.Size(60, 20)
        Me.btnClearSerialMonitor.TabIndex = 3
        Me.btnClearSerialMonitor.Text = "Clear"
        Me.btnClearSerialMonitor.UseVisualStyleBackColor = True
        '
        'btnSendSerialMonitor
        '
        Me.btnSendSerialMonitor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSendSerialMonitor.Location = New System.Drawing.Point(476, 3)
        Me.btnSendSerialMonitor.Name = "btnSendSerialMonitor"
        Me.btnSendSerialMonitor.Size = New System.Drawing.Size(60, 20)
        Me.btnSendSerialMonitor.TabIndex = 2
        Me.btnSendSerialMonitor.Text = "Send"
        Me.btnSendSerialMonitor.UseVisualStyleBackColor = True
        '
        'txtSendSerialMonitor
        '
        Me.txtSendSerialMonitor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSendSerialMonitor.Font = New System.Drawing.Font("Lucida Console", 9.75!)
        Me.txtSendSerialMonitor.Location = New System.Drawing.Point(3, 3)
        Me.txtSendSerialMonitor.MaxLength = 200
        Me.txtSendSerialMonitor.Name = "txtSendSerialMonitor"
        Me.txtSendSerialMonitor.Size = New System.Drawing.Size(467, 20)
        Me.txtSendSerialMonitor.TabIndex = 1
        '
        'btnLoadFromFile
        '
        Me.btnLoadFromFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLoadFromFile.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadFromFile.Location = New System.Drawing.Point(440, 397)
        Me.btnLoadFromFile.Name = "btnLoadFromFile"
        Me.btnLoadFromFile.Size = New System.Drawing.Size(55, 43)
        Me.btnLoadFromFile.TabIndex = 65
        Me.btnLoadFromFile.Text = "Load file"
        Me.btnLoadFromFile.UseVisualStyleBackColor = True
        Me.btnLoadFromFile.Visible = False
        '
        'btnSaveToFile
        '
        Me.btnSaveToFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveToFile.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveToFile.Location = New System.Drawing.Point(501, 397)
        Me.btnSaveToFile.Name = "btnSaveToFile"
        Me.btnSaveToFile.Size = New System.Drawing.Size(55, 43)
        Me.btnSaveToFile.TabIndex = 66
        Me.btnSaveToFile.Text = "Save file"
        Me.btnSaveToFile.UseVisualStyleBackColor = True
        Me.btnSaveToFile.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(684, 397)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(55, 43)
        Me.btnExit.TabIndex = 67
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPortSearch
        '
        Me.btnPortSearch.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPortSearch.Location = New System.Drawing.Point(198, 6)
        Me.btnPortSearch.Name = "btnPortSearch"
        Me.btnPortSearch.Size = New System.Drawing.Size(49, 21)
        Me.btnPortSearch.TabIndex = 68
        Me.btnPortSearch.Text = "Search"
        Me.btnPortSearch.UseVisualStyleBackColor = True
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 445)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(757, 22)
        Me.StatusStrip.TabIndex = 69
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(212, 17)
        Me.ToolStripStatusLabel1.Text = "Status messages are displayed here"
        '
        'FileChooser
        '
        Me.FileChooser.DefaultExt = "hex"
        Me.FileChooser.Filter = "Hex files|*.hex|Bin files|*.bin"
        Me.FileChooser.Title = "Select the hex file"
        '
        'tmrMonitor
        '
        Me.tmrMonitor.Interval = 1
        '
        'txtGuard
        '
        Me.txtGuard.Location = New System.Drawing.Point(449, 7)
        Me.txtGuard.MaxLength = 1
        Me.txtGuard.Name = "txtGuard"
        Me.txtGuard.Size = New System.Drawing.Size(15, 20)
        Me.txtGuard.TabIndex = 70
        Me.txtGuard.Text = "+"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(387, 9)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(60, 13)
        Me.Label27.TabIndex = 71
        Me.Label27.Text = "Guard char"
        '
        'Label52
        '
        Me.Label52.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.DarkRed
        Me.Label52.Location = New System.Drawing.Point(9, 397)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(354, 15)
        Me.Label52.TabIndex = 74
        Me.Label52.Text = "Tip: Select the port and baud rate and press download"
        '
        'Label53
        '
        Me.Label53.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.DarkRed
        Me.Label53.Location = New System.Drawing.Point(39, 415)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(332, 15)
        Me.Label53.TabIndex = 75
        Me.Label53.Text = "ATWR makes your changes permanent in EEPROM"
        '
        'Label89
        '
        Me.Label89.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label89.AutoSize = True
        Me.Label89.Location = New System.Drawing.Point(649, 427)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(29, 13)
        Me.Label89.TabIndex = 76
        Me.Label89.Text = "V1.6"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 467)
        Me.Controls.Add(Me.Label89)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSaveToFile)
        Me.Controls.Add(Me.btnLoadFromFile)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtGuard)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.btnPortSearch)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmbBaudRate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PortChooser)
        Me.Name = "frmMain"
        Me.Text = "XCM (XRF config manager)"
        Me.gboxSerial.ResumeLayout(False)
        Me.gboxSerial.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.General.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Advanced.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.gboxRP3.ResumeLayout(False)
        Me.gboxRP3.PerformLayout()
        Me.gboxRP2.ResumeLayout(False)
        Me.gboxRP2.PerformLayout()
        Me.gboxRP1.ResumeLayout(False)
        Me.gboxRP1.PerformLayout()
        Me.Log.ResumeLayout(False)
        Me.UploadFirmware.ResumeLayout(False)
        Me.UploadFirmware.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.SerialMonitor.ResumeLayout(False)
        Me.SerialMonitor.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PortChooser As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmbBaudRate As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblCH As System.Windows.Forms.Label
    Friend WithEvents lblDR As System.Windows.Forms.Label
    Friend WithEvents lblEA As System.Windows.Forms.Label
    Friend WithEvents lblEK As System.Windows.Forms.Label
    Friend WithEvents lblEE As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblI2 As System.Windows.Forms.Label
    Friend WithEvents lblNT As System.Windows.Forms.Label
    Friend WithEvents lblPL As System.Windows.Forms.Label
    Friend WithEvents btnWrite As System.Windows.Forms.Button
    Friend WithEvents txtCH As System.Windows.Forms.TextBox
    Friend WithEvents txtEA As System.Windows.Forms.TextBox
    Friend WithEvents txtEK As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtI2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNT As System.Windows.Forms.TextBox
    Friend WithEvents txtPK As System.Windows.Forms.TextBox
    Friend WithEvents txtPL As System.Windows.Forms.TextBox
    Friend WithEvents txtRO As System.Windows.Forms.TextBox
    Friend WithEvents txtDR As System.Windows.Forms.TextBox
    Friend WithEvents txtEE As System.Windows.Forms.TextBox
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblPK As System.Windows.Forms.Label
    Friend WithEvents lblRO As System.Windows.Forms.Label
    Friend WithEvents txtBD As System.Windows.Forms.TextBox
    Friend WithEvents lblFC As System.Windows.Forms.Label
    Friend WithEvents lblBD As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbBD As System.Windows.Forms.ComboBox
    Friend WithEvents txtFC As System.Windows.Forms.TextBox
    Friend WithEvents gboxSerial As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnFCOff As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnFCOn As System.Windows.Forms.RadioButton
    Friend WithEvents cmbNT As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCH As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmbPL As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbDR As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents General As System.Windows.Forms.TabPage
    Friend WithEvents Advanced As System.Windows.Forms.TabPage
    Friend WithEvents Log As System.Windows.Forms.TabPage
    Friend WithEvents btnLoadFromFile As System.Windows.Forms.Button
    Friend WithEvents btnSaveToFile As System.Windows.Forms.Button
    Friend WithEvents cmbSM As System.Windows.Forms.ComboBox
    Friend WithEvents txtSM As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblSM As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCC As System.Windows.Forms.Label
    Friend WithEvents txtCC As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnPortSearch As System.Windows.Forms.Button
    Friend WithEvents UploadFirmware As System.Windows.Forms.TabPage
    Friend WithEvents SerialMonitor As System.Windows.Forms.TabPage
    Friend WithEvents rbtnEEOff As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnEEOn As System.Windows.Forms.RadioButton
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbPK As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cmbRO As System.Windows.Forms.ComboBox
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents btnVerify As System.Windows.Forms.Button
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents btnfile As System.Windows.Forms.Button
    Friend WithEvents txtfilename As System.Windows.Forms.TextBox
    Friend WithEvents FileChooser As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tmrMonitor As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnSendSerialMonitor As System.Windows.Forms.Button
    Friend WithEvents txtSendSerialMonitor As System.Windows.Forms.TextBox
    Friend WithEvents btnClearSerialMonitor As System.Windows.Forms.Button
    Friend WithEvents cmbWrapSerialMonitor As System.Windows.Forms.ComboBox
    Friend WithEvents lblWrap As System.Windows.Forms.Label
    Friend WithEvents txtGuard As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents rtxtSerialMonitor As System.Windows.Forms.RichTextBox
    Friend WithEvents rtxtLog As System.Windows.Forms.RichTextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lblCN As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtCN As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cmbCS As System.Windows.Forms.ComboBox
    Friend WithEvents lblCS As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtCS As System.Windows.Forms.TextBox
    Friend WithEvents txtnCN As System.Windows.Forms.TextBox
    Friend WithEvents lblFreq As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents lblVR As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents rbtnBOOT As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnXRF As System.Windows.Forms.RadioButton
    Friend WithEvents btnProgAdvanced As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents gboxRP2 As System.Windows.Forms.GroupBox
    Friend WithEvents gboxRP1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnRPoff As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnRPon As System.Windows.Forms.RadioButton
    Friend WithEvents txtRP As System.Windows.Forms.TextBox
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents lblRP As System.Windows.Forms.Label
    Friend WithEvents lblRI As System.Windows.Forms.Label
    Friend WithEvents labelRI As System.Windows.Forms.Label
    Friend WithEvents txtRI As System.Windows.Forms.TextBox
    Friend WithEvents gboxRP3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRC As System.Windows.Forms.TextBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents lblRC As System.Windows.Forms.Label
    Friend WithEvents lblMY As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents txtMY As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label

End Class
