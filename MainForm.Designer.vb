<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Byte1TB = New System.Windows.Forms.TextBox()
        Me.Byte2TB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Byte3TB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Byte4TB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StartBTN = New System.Windows.Forms.Button()
        Me.AbortBTN = New System.Windows.Forms.Button()
        Me.ExportBTN = New System.Windows.Forms.Button()
        Me.Byte4EndTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Byte3EndTB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Byte2EndTB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Byte1EndTB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.UnicodeCB1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OutputBox = New System.Windows.Forms.ListBox()
        Me.ExportFilteredListToSelectedFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.FilterExportBTN = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RemoveFromPositionTB = New System.Windows.Forms.TextBox()
        Me.RemoveAtPositionTB = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RemoveRangeBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Byte 1 Count"
        '
        'Byte1TB
        '
        Me.Byte1TB.Location = New System.Drawing.Point(212, 10)
        Me.Byte1TB.Name = "Byte1TB"
        Me.Byte1TB.Size = New System.Drawing.Size(242, 26)
        Me.Byte1TB.TabIndex = 1
        '
        'Byte2TB
        '
        Me.Byte2TB.Location = New System.Drawing.Point(212, 60)
        Me.Byte2TB.Name = "Byte2TB"
        Me.Byte2TB.Size = New System.Drawing.Size(242, 26)
        Me.Byte2TB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Byte 2 Count"
        '
        'Byte3TB
        '
        Me.Byte3TB.Location = New System.Drawing.Point(212, 111)
        Me.Byte3TB.Name = "Byte3TB"
        Me.Byte3TB.Size = New System.Drawing.Size(242, 26)
        Me.Byte3TB.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Byte 3 Count"
        '
        'Byte4TB
        '
        Me.Byte4TB.Location = New System.Drawing.Point(212, 165)
        Me.Byte4TB.Name = "Byte4TB"
        Me.Byte4TB.Size = New System.Drawing.Size(242, 26)
        Me.Byte4TB.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Byte 4 Count"
        '
        'StartBTN
        '
        Me.StartBTN.Location = New System.Drawing.Point(17, 516)
        Me.StartBTN.Name = "StartBTN"
        Me.StartBTN.Size = New System.Drawing.Size(154, 63)
        Me.StartBTN.TabIndex = 8
        Me.StartBTN.Text = "Start"
        Me.StartBTN.UseVisualStyleBackColor = True
        '
        'AbortBTN
        '
        Me.AbortBTN.Location = New System.Drawing.Point(212, 516)
        Me.AbortBTN.Name = "AbortBTN"
        Me.AbortBTN.Size = New System.Drawing.Size(154, 63)
        Me.AbortBTN.TabIndex = 9
        Me.AbortBTN.Text = "Abort"
        Me.AbortBTN.UseVisualStyleBackColor = True
        '
        'ExportBTN
        '
        Me.ExportBTN.Location = New System.Drawing.Point(410, 516)
        Me.ExportBTN.Name = "ExportBTN"
        Me.ExportBTN.Size = New System.Drawing.Size(154, 63)
        Me.ExportBTN.TabIndex = 10
        Me.ExportBTN.Text = "Export"
        Me.ExportBTN.UseVisualStyleBackColor = True
        '
        'Byte4EndTB
        '
        Me.Byte4EndTB.Location = New System.Drawing.Point(792, 168)
        Me.Byte4EndTB.Name = "Byte4EndTB"
        Me.Byte4EndTB.ReadOnly = True
        Me.Byte4EndTB.Size = New System.Drawing.Size(242, 26)
        Me.Byte4EndTB.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(647, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Byte 4 End"
        '
        'Byte3EndTB
        '
        Me.Byte3EndTB.Location = New System.Drawing.Point(792, 114)
        Me.Byte3EndTB.Name = "Byte3EndTB"
        Me.Byte3EndTB.ReadOnly = True
        Me.Byte3EndTB.Size = New System.Drawing.Size(242, 26)
        Me.Byte3EndTB.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(647, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Byte 3 End"
        '
        'Byte2EndTB
        '
        Me.Byte2EndTB.Location = New System.Drawing.Point(792, 63)
        Me.Byte2EndTB.Name = "Byte2EndTB"
        Me.Byte2EndTB.ReadOnly = True
        Me.Byte2EndTB.Size = New System.Drawing.Size(242, 26)
        Me.Byte2EndTB.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(647, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Byte 2 End"
        '
        'Byte1EndTB
        '
        Me.Byte1EndTB.Location = New System.Drawing.Point(792, 13)
        Me.Byte1EndTB.Name = "Byte1EndTB"
        Me.Byte1EndTB.ReadOnly = True
        Me.Byte1EndTB.Size = New System.Drawing.Size(242, 26)
        Me.Byte1EndTB.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(647, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Byte 1 End"
        '
        'UnicodeCB1
        '
        Me.UnicodeCB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UnicodeCB1.FormattingEnabled = True
        Me.UnicodeCB1.Items.AddRange(New Object() {"[0xC2,0xDF],[0x80,0xBF]", "0xE0,[0xA0,0xBF],[0x80,0xBF]", "[0xE1,0xEC],[0x80,0xBF],[0x80,0xBF]", "0xED,[0x80,0x9F],[0x80,0xBF]", "[0xEE,0xEF],[0x80,0xBF],[0x80,0xBF]", "0xF0,[0x90,0xBF],[0x80,0xBF],[0x80,0xBF]", "[0xF1,0xF3],[0x80,0xBF],[0x80,0xBF],[0x80,0xBF]", "0xF4,[0x80,0x8F],[0x80,0xBF],[0x80,0xBF]"})
        Me.UnicodeCB1.Location = New System.Drawing.Point(212, 226)
        Me.UnicodeCB1.Name = "UnicodeCB1"
        Me.UnicodeCB1.Size = New System.Drawing.Size(242, 28)
        Me.UnicodeCB1.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 20)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Unicode Selection"
        '
        'OutputBox
        '
        Me.OutputBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.OutputBox.FormattingEnabled = True
        Me.OutputBox.ItemHeight = 36
        Me.OutputBox.Location = New System.Drawing.Point(651, 229)
        Me.OutputBox.Name = "OutputBox"
        Me.OutputBox.Size = New System.Drawing.Size(552, 256)
        Me.OutputBox.TabIndex = 21
        '
        'FilterExportBTN
        '
        Me.FilterExportBTN.Location = New System.Drawing.Point(590, 516)
        Me.FilterExportBTN.Name = "FilterExportBTN"
        Me.FilterExportBTN.Size = New System.Drawing.Size(175, 63)
        Me.FilterExportBTN.TabIndex = 22
        Me.FilterExportBTN.Text = "Filter Export"
        Me.FilterExportBTN.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 284)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 20)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Remove Start From"
        '
        'RemoveFromPositionTB
        '
        Me.RemoveFromPositionTB.Location = New System.Drawing.Point(212, 277)
        Me.RemoveFromPositionTB.Name = "RemoveFromPositionTB"
        Me.RemoveFromPositionTB.Size = New System.Drawing.Size(242, 26)
        Me.RemoveFromPositionTB.TabIndex = 24
        '
        'RemoveAtPositionTB
        '
        Me.RemoveAtPositionTB.Location = New System.Drawing.Point(212, 328)
        Me.RemoveAtPositionTB.Name = "RemoveAtPositionTB"
        Me.RemoveAtPositionTB.Size = New System.Drawing.Size(242, 26)
        Me.RemoveAtPositionTB.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 335)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 20)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Remove End At"
        '
        'RemoveRangeBTN
        '
        Me.RemoveRangeBTN.Location = New System.Drawing.Point(792, 516)
        Me.RemoveRangeBTN.Name = "RemoveRangeBTN"
        Me.RemoveRangeBTN.Size = New System.Drawing.Size(179, 63)
        Me.RemoveRangeBTN.TabIndex = 28
        Me.RemoveRangeBTN.Text = "Remove Range"
        Me.RemoveRangeBTN.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1297, 591)
        Me.Controls.Add(Me.RemoveRangeBTN)
        Me.Controls.Add(Me.RemoveAtPositionTB)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.RemoveFromPositionTB)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.FilterExportBTN)
        Me.Controls.Add(Me.OutputBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.UnicodeCB1)
        Me.Controls.Add(Me.Byte4EndTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Byte3EndTB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Byte2EndTB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Byte1EndTB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ExportBTN)
        Me.Controls.Add(Me.AbortBTN)
        Me.Controls.Add(Me.StartBTN)
        Me.Controls.Add(Me.Byte4TB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Byte3TB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Byte2TB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Byte1TB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Byte1TB As TextBox
    Friend WithEvents Byte2TB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Byte3TB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Byte4TB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents StartBTN As Button
    Friend WithEvents AbortBTN As Button
    Friend WithEvents ExportBTN As Button
    Friend WithEvents Byte4EndTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Byte3EndTB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Byte2EndTB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Byte1EndTB As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents UnicodeCB1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents OutputBox As ListBox
    Friend WithEvents ExportFilteredListToSelectedFolder As FolderBrowserDialog
    Friend WithEvents FilterExportBTN As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents RemoveFromPositionTB As TextBox
    Friend WithEvents RemoveAtPositionTB As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents RemoveRangeBTN As Button
End Class
