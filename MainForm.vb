Imports System.Text
Imports System.IO
Imports System.Threading

Module MyCountModule
    Public Count As Integer
End Module

Public Class MainForm
    Public Thread1 As Thread
    Public MyStringBuilder As StringBuilder
    Public FilteredMyStringBuilder As StringBuilder

    Private Sub StartBTN_Click(sender As Object, e As EventArgs) Handles StartBTN.Click
        If Thread1 Is Nothing Then
            CheckForIllegalCrossThreadCalls = False
            Thread1 = New Thread(AddressOf StartGenerate)
            Thread1.Start()
        Else
            MessageBox.Show("Thread has been started")
        End If
    End Sub

    Private Sub AbortBTN_Click(sender As Object, e As EventArgs) Handles AbortBTN.Click
        Thread1.Abort()
    End Sub

    Private Sub ExportBTN_Click(sender As Object, e As EventArgs) Handles ExportBTN.Click
        ExportFilteredListToSelectedFolder.ShowDialog()
        ExportResults()
    End Sub

    Sub ExportResults()
        Dim objStreamWriter As StreamWriter
        Dim StringPath As String = ExportFilteredListToSelectedFolder.SelectedPath
        If File.Exists(StringPath + "\UTF8Lists1.txt") Then
            While File.Exists(StringPath + "\UTF8Lists" + Count.ToString() + ".txt") = True
                Count += 1
            End While
            objStreamWriter = New StreamWriter(StringPath + "\UTF8Lists" + Count.ToString() + ".txt")
            objStreamWriter.WriteLine(MyStringBuilder.ToString)
            objStreamWriter.Close()
        Else
            objStreamWriter = New StreamWriter(StringPath + "\UTF8Lists1.txt")
            objStreamWriter.WriteLine(MyStringBuilder.ToString)
            objStreamWriter.Close()
        End If
        MyStringBuilder = New StringBuilder()
        MessageBox.Show("Done")
    End Sub

    Sub StartGenerate()
        Dim UTF8Bytes As Byte() = New Byte() {}
        ReDim UTF8Bytes(4)
        Dim Byte1Text As String = ""
        Dim Byte2Text As String = ""
        Dim Byte3Text As String = ""
        Dim Byte4Text As String = ""
        Dim Byte1EndingText As String = ""
        Dim Byte2EndingText As String = ""
        Dim Byte3EndingText As String = ""
        Dim Byte4EndingText As String = ""
        Dim Byte1Int As Integer
        Dim Byte2Int As Integer
        Dim Byte3Int As Integer
        Dim Byte4Int As Integer
        Dim Byte1EndInt As Integer
        Dim Byte2EndInt As Integer
        Dim Byte3EndInt As Integer
        Dim Byte4EndInt As Integer
        Dim TestParseBoolean As Boolean = True
        Dim TestParseBoolean2 As Boolean = True
        Dim TestParseBoolean3 As Boolean = True
        Dim TestParseBoolean4 As Boolean = True
        Dim UTF8String As String = ""
        Dim CheckerString As String = ""
        MyStringBuilder = New StringBuilder()
        OutputBox.Items.Clear()
        If Byte1TB.Text = "" And Byte2TB.Text = "" And Byte3TB.Text = "" And Byte4TB.Text = "" Then
            Byte1Text = "0"
            Byte2Text = "0"
            Byte3Text = "0"
            Byte4Text = "0"
        Else
            Byte1Text = Byte1TB.Text
            Byte2Text = Byte2TB.Text
            Byte3Text = Byte3TB.Text
            Byte4Text = Byte4TB.Text
        End If
        Byte1Int = Integer.Parse(Byte1Text)
        Byte2Int = Integer.Parse(Byte2Text)
        Byte3Int = Integer.Parse(Byte3Text)
        Byte4Int = Integer.Parse(Byte4Text)
        Byte4EndingText = Byte4EndTB.Text
        Byte3EndingText = Byte3EndTB.Text
        Byte2EndingText = Byte2EndTB.Text
        Byte1EndingText = Byte1EndTB.Text
        Byte1EndInt = Integer.Parse(Byte1EndingText)
        Byte2EndInt = Integer.Parse(Byte2EndingText)
        Byte3EndInt = Integer.Parse(Byte3EndingText)
        Byte4EndInt = Integer.Parse(Byte4EndingText)
        If UnicodeCB1.Text = "[0xC2,0xDF],[0x80,0xBF]" Then
            Byte3Int = 194
            Byte4Int = 128
            ReDim UTF8Bytes(2)
            UTF8Bytes(0) = Byte3Int
            UTF8Bytes(1) = Byte4Int
            While Byte3Int <= Byte3EndInt
                While Byte4Int <= Byte4EndInt
                    UTF8String = Convert.ToBase64String(UTF8Bytes)
                    MyStringBuilder.Append(UTF8String + Environment.NewLine)
                    OutputBox.Items.Add(Encoding.UTF8.GetString(UTF8Bytes))
                    Byte4TB.Text = UTF8Bytes(1).ToString()
                    Byte4Int += 1
                    If Byte4Int <= Byte4EndInt Then
                        UTF8Bytes(1) = Byte4Int
                    Else
                        UTF8Bytes(1) = 128
                    End If
                End While
                Byte3TB.Text = UTF8Bytes(0).ToString()
                Byte4Int = 128
                Byte3Int += 1
                If Byte3Int <= Byte3EndInt Then
                    UTF8Bytes(0) = Byte3Int
                Else
                    UTF8Bytes(0) = 194
                End If
            End While
        ElseIf UnicodeCB1.Text = "0xE0,[0xA0,0xBF],[0x80,0xBF]" Then
            Byte2Int = Byte2EndInt
            ReDim UTF8Bytes(3)
            Byte3Int = 160
            Byte4Int = 128
            UTF8Bytes(0) = Byte2Int
            UTF8Bytes(1) = Byte3Int
            UTF8Bytes(2) = Byte4Int
            While Byte2Int = Byte2EndInt
                While Byte3Int <= Byte3EndInt
                    While Byte4Int <= Byte4EndInt
                        Byte4TB.Text = UTF8Bytes(2).ToString()
                        UTF8String = Convert.ToBase64String(UTF8Bytes)
                        MyStringBuilder.Append(UTF8String + Environment.NewLine)
                        OutputBox.Items.Add(Encoding.UTF8.GetString(UTF8Bytes))
                        Byte4Int += 1
                        If Byte4Int <= Byte4EndInt Then
                            UTF8Bytes(2) = Byte4Int
                        Else
                            UTF8Bytes(2) = 128
                        End If
                    End While
                    Byte3TB.Text = UTF8Bytes(1).ToString()
                    Byte4Int = 128
                    Byte3Int += 1
                    If Byte3Int <= Byte3EndInt Then
                        UTF8Bytes(1) = Byte3Int
                    Else
                        UTF8Bytes(1) = 160
                    End If
                End While
                Byte2TB.Text = UTF8Bytes(0).ToString()
                Byte3Int = 160
                Byte2Int += 1
                If Byte2Int <= Byte2EndInt Then
                    UTF8Bytes(0) = Byte2Int
                Else
                    UTF8Bytes(0) = Byte2EndInt
                End If
            End While
        ElseIf UnicodeCB1.Text = "[0xE1,0xEC],[0x80,0xBF],[0x80,0xBF]" Then
            Byte2Int = 225
            ReDim UTF8Bytes(3)
            Byte3Int = 128
            Byte4Int = 128
            UTF8Bytes(0) = Byte2Int
            UTF8Bytes(1) = Byte3Int
            UTF8Bytes(2) = Byte4Int
            While Byte2Int <= Byte2EndInt
                While Byte3Int <= Byte3EndInt
                    While Byte4Int <= Byte4EndInt
                        Byte4TB.Text = UTF8Bytes(2).ToString()
                        UTF8String = Convert.ToBase64String(UTF8Bytes)
                        MyStringBuilder.Append(UTF8String + Environment.NewLine)
                        OutputBox.Items.Add(Encoding.UTF8.GetString(UTF8Bytes))
                        Byte4Int += 1
                        If Byte4Int <= Byte4EndInt Then
                            UTF8Bytes(2) = Byte4Int
                        Else
                            UTF8Bytes(2) = 128
                        End If
                    End While
                    Byte3TB.Text = UTF8Bytes(1).ToString()
                    Byte4Int = 128
                    Byte3Int += 1
                    If Byte3Int <= Byte3EndInt Then
                        UTF8Bytes(1) = Byte3Int
                    Else
                        UTF8Bytes(1) = 128
                    End If
                End While
                Byte2TB.Text = UTF8Bytes(0).ToString()
                Byte3Int = 160
                Byte2Int += 1
                If Byte2Int <= Byte2EndInt Then
                    UTF8Bytes(0) = Byte2Int
                Else
                    UTF8Bytes(0) = 225
                End If
            End While
        ElseIf UnicodeCB1.Text = "0xED,[0x80,0x9F],[0x80,0xBF]" Then
            Byte2Int = Byte2EndInt
            ReDim UTF8Bytes(3)
            Byte3Int = 128
            Byte4Int = 128
            UTF8Bytes(0) = Byte2Int
            UTF8Bytes(1) = Byte3Int
            UTF8Bytes(2) = Byte4Int
            While Byte2Int = Byte2EndInt
                While Byte3Int <= Byte3EndInt
                    While Byte4Int <= Byte4EndInt
                        Byte4TB.Text = UTF8Bytes(2).ToString()
                        UTF8String = Convert.ToBase64String(UTF8Bytes)
                        MyStringBuilder.Append(UTF8String + Environment.NewLine)
                        OutputBox.Items.Add(Encoding.UTF8.GetString(UTF8Bytes))
                        Byte4Int += 1
                        If Byte4Int <= Byte4EndInt Then
                            UTF8Bytes(2) = Byte4Int
                        Else
                            UTF8Bytes(2) = 128
                        End If
                    End While
                    Byte3TB.Text = UTF8Bytes(1).ToString()
                    Byte4Int = 128
                    Byte3Int += 1
                    If Byte3Int <= Byte3EndInt Then
                        UTF8Bytes(1) = Byte3Int
                    Else
                        UTF8Bytes(1) = 128
                    End If
                End While
                Byte2TB.Text = UTF8Bytes(0).ToString()
                Byte3Int = 160
                Byte2Int += 1
                If Byte2Int <= Byte2EndInt Then
                    UTF8Bytes(0) = Byte2Int
                Else
                    UTF8Bytes(0) = Byte2EndInt
                End If
            End While
        ElseIf UnicodeCB1.Text = "[0xEE,0xEF],[0x80,0xBF],[0x80,0xBF]" Then
            Byte2Int = 238
            ReDim UTF8Bytes(3)
            Byte3Int = 128
            Byte4Int = 128
            UTF8Bytes(0) = Byte2Int
            UTF8Bytes(1) = Byte3Int
            UTF8Bytes(2) = Byte4Int
            While Byte2Int <= Byte2EndInt
                While Byte3Int <= Byte3EndInt
                    While Byte4Int <= Byte4EndInt
                        Byte4TB.Text = UTF8Bytes(2).ToString()
                        UTF8String = Convert.ToBase64String(UTF8Bytes)
                        MyStringBuilder.Append(UTF8String + Environment.NewLine)
                        OutputBox.Items.Add(Encoding.UTF8.GetString(UTF8Bytes))
                        Byte4Int += 1
                        If Byte4Int <= Byte4EndInt Then
                            UTF8Bytes(2) = Byte4Int
                        Else
                            UTF8Bytes(2) = 128
                        End If
                    End While
                    Byte3TB.Text = UTF8Bytes(1).ToString()
                    Byte4Int = 128
                    Byte3Int += 1
                    If Byte3Int <= Byte3EndInt Then
                        UTF8Bytes(1) = Byte3Int
                    Else
                        UTF8Bytes(1) = 128
                    End If
                End While
                Byte2TB.Text = UTF8Bytes(0).ToString()
                Byte3Int = 160
                Byte2Int += 1
                If Byte2Int <= Byte2EndInt Then
                    UTF8Bytes(0) = Byte2Int
                Else
                    UTF8Bytes(0) = 238
                End If
            End While
        ElseIf UnicodeCB1.Text = "0xF0,[0x90,0xBF],[0x80,0xBF],[0x80,0xBF]" Then
            Byte1Int = Byte1EndInt
            Byte2Int = 144
            Byte3Int = 128
            Byte4Int = 128
            UTF8Bytes(0) = Byte1Int
            UTF8Bytes(1) = Byte2Int
            UTF8Bytes(2) = Byte3Int
            UTF8Bytes(3) = Byte4Int
            While Byte1Int = Byte1EndInt
                While Byte2Int <= Byte2EndInt
                    While Byte3Int <= Byte3EndInt
                        While Byte4Int <= Byte4EndInt
                            Byte4TB.Text = UTF8Bytes(3).ToString()
                            UTF8String = Convert.ToBase64String(UTF8Bytes)
                            MyStringBuilder.Append(UTF8String + Environment.NewLine)
                            OutputBox.Items.Add(Encoding.UTF8.GetString(UTF8Bytes))
                            Byte4Int += 1
                            If Byte4Int <= Byte4EndInt Then
                                UTF8Bytes(3) = Byte4Int
                            Else
                                UTF8Bytes(3) = 128
                            End If
                        End While
                        Byte3TB.Text = UTF8Bytes(2).ToString()
                        Byte4Int = 128
                        Byte3Int += 1
                        If Byte3Int <= Byte3EndInt Then
                            UTF8Bytes(2) = Byte3Int
                        Else
                            UTF8Bytes(2) = 128
                        End If
                    End While
                    Byte2TB.Text = UTF8Bytes(1).ToString()
                    Byte3Int = 128
                    Byte2Int += 1
                    If Byte2Int <= Byte2EndInt Then
                        UTF8Bytes(1) = Byte2Int
                    Else
                        UTF8Bytes(1) = 128
                    End If
                End While
                Byte2Int = 144
                Byte1TB.Text = UTF8Bytes(0)
                Byte1Int += 1
            End While
        ElseIf UnicodeCB1.Text = "[0xF1,0xF3],[0x80,0xBF],[0x80,0xBF],[0x80,0xBF]" Then
            Byte1Int = 241
            Byte2Int = 128
            Byte3Int = 128
            Byte4Int = 128
            UTF8Bytes(0) = Byte1Int
            UTF8Bytes(1) = Byte2Int
            UTF8Bytes(2) = Byte3Int
            UTF8Bytes(3) = Byte4Int
            While Byte1Int <= Byte1EndInt
                While Byte2Int <= Byte2EndInt
                    While Byte3Int <= Byte3EndInt
                        While Byte4Int <= Byte4EndInt
                            Byte4TB.Text = UTF8Bytes(3).ToString()
                            UTF8String = Convert.ToBase64String(UTF8Bytes)
                            MyStringBuilder.Append(UTF8String + Environment.NewLine)
                            OutputBox.Items.Add(Encoding.UTF8.GetString(UTF8Bytes))
                            Byte4Int += 1
                            If Byte4Int <= Byte4EndInt Then
                                UTF8Bytes(3) = Byte4Int
                            Else
                                UTF8Bytes(3) = 128
                            End If
                        End While
                        Byte3TB.Text = UTF8Bytes(2).ToString()
                        Byte4Int = 128
                        Byte3Int += 1
                        If Byte3Int <= Byte3EndInt Then
                            UTF8Bytes(2) = Byte3Int
                        Else
                            UTF8Bytes(2) = 128
                        End If
                    End While
                    Byte2TB.Text = UTF8Bytes(1).ToString()
                    Byte3Int = 128
                    Byte2Int += 1
                    If Byte2Int <= Byte2EndInt Then
                        UTF8Bytes(1) = Byte2Int
                    Else
                        UTF8Bytes(1) = 128
                    End If
                End While
                Byte2Int = 128
                Byte1TB.Text = UTF8Bytes(0)
                Byte1Int += 1
                If Byte1Int <= Byte1EndInt Then
                    UTF8Bytes(0) = Byte1Int
                Else
                    UTF8Bytes(0) = 241
                End If
            End While
        ElseIf UnicodeCB1.Text = "0xF4,[0x80,0x8F],[0x80,0xBF],[0x80,0xBF]" Then
            Byte1Int = Byte1EndInt
            Byte2Int = 128
            Byte3Int = 128
            Byte4Int = 128
            UTF8Bytes(0) = Byte1Int
            UTF8Bytes(1) = Byte2Int
            UTF8Bytes(2) = Byte3Int
            UTF8Bytes(3) = Byte4Int
            While Byte1Int = Byte1EndInt
                While Byte2Int <= Byte2EndInt
                    While Byte3Int <= Byte3EndInt
                        While Byte4Int <= Byte4EndInt
                            Byte4TB.Text = UTF8Bytes(3).ToString()
                            UTF8String = Convert.ToBase64String(UTF8Bytes)
                            MyStringBuilder.Append(UTF8String + Environment.NewLine)
                            OutputBox.Items.Add(Encoding.UTF8.GetString(UTF8Bytes))
                            Byte4Int += 1
                            If Byte4Int <= Byte4EndInt Then
                                UTF8Bytes(3) = Byte4Int
                            Else
                                UTF8Bytes(3) = 128
                            End If
                        End While
                        Byte3TB.Text = UTF8Bytes(2).ToString()
                        Byte4Int = 128
                        Byte3Int += 1
                        If Byte3Int <= Byte3EndInt Then
                            UTF8Bytes(2) = Byte3Int
                        Else
                            UTF8Bytes(2) = 128
                        End If
                    End While
                    Byte2TB.Text = UTF8Bytes(1).ToString()
                    Byte3Int = 128
                    Byte2Int += 1
                    If Byte2Int <= Byte2EndInt Then
                        UTF8Bytes(1) = Byte2Int
                    Else
                        UTF8Bytes(1) = 128
                    End If
                End While
                Byte2Int = 128
                Byte1TB.Text = UTF8Bytes(0)
                Byte1Int += 1
            End While
        End If
        MessageBox.Show("Output Box Length " + OutputBox.Items.Count.ToString())
        Thread1.Abort()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Count = 1
    End Sub

    Private Sub UnicodeCB1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UnicodeCB1.SelectedIndexChanged
        If UnicodeCB1.Text = "[0xC2,0xDF],[0x80,0xBF]" Then
            Byte1EndTB.Text = "0"
            Byte2EndTB.Text = "0"
            Byte3EndTB.Text = "223"
            Byte4EndTB.Text = "191"
        ElseIf UnicodeCB1.Text = "0xE0,[0xA0,0xBF],[0x80,0xBF]" Then
            Byte1EndTB.Text = "0"
            Byte2EndTB.Text = "224"
            Byte3EndTB.Text = "191"
            Byte4EndTB.Text = "191"
        ElseIf UnicodeCB1.Text = "[0xE1,0xEC],[0x80,0xBF],[0x80,0xBF]" Then
            Byte1EndTB.Text = "0"
            Byte2EndTB.Text = "236"
            Byte3EndTB.Text = "191"
            Byte4EndTB.Text = "223"
        ElseIf UnicodeCB1.Text = "0xED,[0x80,0x9F],[0x80,0xBF]" Then
            Byte1EndTB.Text = "0"
            Byte2EndTB.Text = "237"
            Byte3EndTB.Text = "159"
            Byte4EndTB.Text = "191"
        ElseIf UnicodeCB1.Text = "[0xEE,0xEF],[0x80,0xBF],[0x80,0xBF]" Then
            Byte1EndTB.Text = "0"
            Byte2EndTB.Text = "239"
            Byte3EndTB.Text = "191"
            Byte4EndTB.Text = "191"
        ElseIf UnicodeCB1.Text = "0xF0,[0x90,0xBF],[0x80,0xBF],[0x80,0xBF]" Then
            Byte1EndTB.Text = "240"
            Byte2EndTB.Text = "191"
            Byte3EndTB.Text = "191"
            Byte4EndTB.Text = "191"
        ElseIf UnicodeCB1.Text = "[0xF1,0xF3],[0x80,0xBF],[0x80,0xBF],[0x80,0xBF]" Then
            Byte1EndTB.Text = "243"
            Byte2EndTB.Text = "191"
            Byte3EndTB.Text = "191"
            Byte4EndTB.Text = "191"
        ElseIf UnicodeCB1.Text = "0xF4,[0x80,0x8F],[0x80,0xBF],[0x80,0xBF]" Then
            Byte1EndTB.Text = "244"
            Byte2EndTB.Text = "143"
            Byte3EndTB.Text = "191"
            Byte4EndTB.Text = "191"
        End If
    End Sub

    Private Sub OutputBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OutputBox.SelectedIndexChanged
        MessageBox.Show(OutputBox.SelectedIndex)
    End Sub

    Private Sub FilterExportBTN_Click(sender As Object, e As EventArgs) Handles FilterExportBTN.Click
        ExportFilteredListToSelectedFolder.ShowDialog()
        FilteredMyStringBuilder = New StringBuilder()
        Dim UTF8Bytes As Byte() = New Byte() {}
        Dim TotalCount As Integer = OutputBox.Items.Count
        Dim LoopCount As Integer = 0
        While LoopCount < TotalCount
            UTF8Bytes = Encoding.UTF8.GetBytes(OutputBox.Items(LoopCount).ToString())
            FilteredMyStringBuilder.Append(Convert.ToBase64String(UTF8Bytes) + Environment.NewLine)
            LoopCount += 1
        End While
        ExportFilterResults()
        MessageBox.Show("Done")
    End Sub

    Sub ExportFilterResults()
        Dim objStreamWriter As StreamWriter
        Dim StringPath As String = ExportFilteredListToSelectedFolder.SelectedPath
        If File.Exists(StringPath + "\UTF8Lists1.txt") Then
            While File.Exists(StringPath + "\UTF8Lists" + Count.ToString() + ".txt") = True
                Count += 1
            End While
            objStreamWriter = New StreamWriter(StringPath + "\UTF8Lists" + Count.ToString() + ".txt")
            objStreamWriter.WriteLine(FilteredMyStringBuilder.ToString)
            objStreamWriter.Close()
        Else
            objStreamWriter = New StreamWriter(StringPath + "\UTF8Lists1.txt")
            objStreamWriter.WriteLine(FilteredMyStringBuilder.ToString)
            objStreamWriter.Close()
        End If
        FilteredMyStringBuilder = New StringBuilder()
    End Sub

    Private Sub RemoveRangeBTN_Click(sender As Object, e As EventArgs) Handles RemoveRangeBTN.Click
        If RemoveFromPositionTB.Text <> Nothing And RemoveFromPositionTB.Text <> "" Then
            Dim StartPosition As Integer = Integer.Parse(RemoveFromPositionTB.Text)
            Dim EndPosition As Integer = 0
            Dim Difference As Integer = 0
            Dim LoopCount As Integer = 1
            If RemoveAtPositionTB.Text = Nothing And RemoveAtPositionTB.Text = "" Then
                MessageBox.Show("Do you intend to use Remove From rather than Remove Range?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                EndPosition = Integer.Parse(RemoveAtPositionTB.Text)
                Difference = EndPosition - StartPosition
                While LoopCount <= Difference
                    OutputBox.Items.RemoveAt(StartPosition)
                    LoopCount += 1
                End While
                OutputBox.Refresh()
                MessageBox.Show("Specific items have been removed from output box", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class
