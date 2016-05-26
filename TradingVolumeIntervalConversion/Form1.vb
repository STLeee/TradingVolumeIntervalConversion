Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenFileDialog1.Title = "Select a File"

        Dim bmp As New Bitmap(My.Resources.flecha_arrow)
        Dim scaledbmp As New Bitmap(bmp, ConvertButton.Width - 10, ConvertButton.Height - 10)
        ConvertButton.Image = scaledbmp
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
        End If
    End Sub

End Class
