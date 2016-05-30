Public Class Form1
    Dim timeInterval As Byte = 5

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bmp As New Bitmap(My.Resources.flecha_arrow)
        Dim scaledbmp As New Bitmap(bmp, ConvertButton.Width - 10, ConvertButton.Height - 10)
        ConvertButton.Image = scaledbmp

        OpenFileDialog1.InitialDirectory = Application.StartupPath
        FolderBrowserDialog1.SelectedPath = Application.StartupPath
    End Sub

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles FileBrowseButton.Click
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            FileTextBox.Text = OpenFileDialog1.FileName()
            If ConvertFileTextBox.Text = "" Then
                Dim fileName As New String(OpenFileDialog1.FileName)
                Dim fileNameSplit() As String = fileName.Split(".")
                For i = 0 To fileNameSplit.Length() - 2
                    If i <> 0 Then ConvertFileTextBox.Text += "."
                    ConvertFileTextBox.Text += fileNameSplit(i)
                Next
                ConvertFileTextBox.Text += "_converted." + fileNameSplit(fileNameSplit.Length() - 1)
            Else
                Dim fileName As New String(OpenFileDialog1.FileName)
                Dim fileNameSplit() As String = fileName.Split("\")
                Dim fileNameSplit2() As String = fileNameSplit(fileNameSplit.Length() - 1).Split(".")
                Dim filePathSplit() As String = ConvertFileTextBox.Text.Split("\")
                ConvertFileTextBox.Text = ""
                For i = 0 To filePathSplit.Length() - 2
                    ConvertFileTextBox.Text += filePathSplit(i) + "\"
                Next
                ConvertFileTextBox.Text += fileNameSplit2(fileNameSplit2.Length() - 2) + "_converted." + fileNameSplit2(fileNameSplit2.Length() - 1)
            End If

            OpenFileDialog1.OpenFile.Close()
        End If
    End Sub

    Private Sub ConvertFileBrowseButton_Click(sender As Object, e As EventArgs) Handles ConvertFileBrowseButton.Click
        If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If ConvertFileTextBox.Text = "" Then
                ConvertFileTextBox.Text = FolderBrowserDialog1.SelectedPath() + "\"
            Else
                Dim fileName As New String(ConvertFileTextBox.Text)
                Dim fileNameSplit() As String = fileName.Split("\")
                Dim fileNameSplit2() As String = fileNameSplit(fileNameSplit.Length() - 1).Split(".")
                ConvertFileTextBox.Text = FolderBrowserDialog1.SelectedPath() + "\" + fileNameSplit2(fileNameSplit2.Length() - 2) + "_converted." + fileNameSplit2(fileNameSplit2.Length() - 1)
            End If
        End If
    End Sub

    Private Sub ConvertButton_Click(sender As Object, e As EventArgs) Handles ConvertButton.Click
        Dim readFilePath As String = FileTextBox.Text()
        Dim writeFilePath As String = ConvertFileTextBox.Text()
        Dim readFileStreamReader As System.IO.StreamReader
        Dim writeFileStreamWriter As System.IO.StreamWriter

        Dim line As String
        Dim words() As String
        Dim countReadLineStep As Byte = 0

        Dim dateS As String
        Dim timeS As String
        Dim dataFirst As Integer
        Dim dataLast As Integer
        Dim dataMax As Integer
        Dim dataMin As Integer
        Dim volumn As Integer

        Try
            readFileStreamReader = My.Computer.FileSystem.OpenTextFileReader(readFilePath)
            writeFileStreamWriter = My.Computer.FileSystem.OpenTextFileWriter(writeFilePath, False)

            While readFileStreamReader.EndOfStream() = False
                line = readFileStreamReader.ReadLine()
                countReadLineStep += 1

                words = line.Split(",")

                If countReadLineStep = 1 Then
                    dataMax = Integer.MinValue
                    dataMin = Integer.MaxValue
                    volumn = 0

                    dateS = words(0)
                    timeS = words(1)
                    dataFirst = Integer.Parse(words(2))
                End If

                For i = 2 To 5
                    Dim n As Integer = Integer.Parse(words(i))
                    If n > dataMax Then dataMax = n
                    If n < dataMin Then dataMin = n
                Next
                volumn += Integer.Parse(words(6))

                If countReadLineStep = timeInterval Or readFileStreamReader.EndOfStream() Then
                    dataLast = Integer.Parse(words(5))

                    writeFileStreamWriter.WriteLine(dateS + "," +
                                                    timeS + "," +
                                                    dataFirst.ToString() + "," +
                                                    dataLast.ToString() + "," +
                                                    dataMax.ToString() + "," +
                                                    dataMin.ToString() + "," +
                                                    volumn.ToString())

                    countReadLineStep = 0
                End If

            End While
        Catch exc As System.Exception
            MsgBox("Error", exc.Message)
            Return
        End Try

        readFileStreamReader.Close()
        writeFileStreamWriter.Close()
    End Sub
End Class
