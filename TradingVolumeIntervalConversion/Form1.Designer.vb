<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FileBrowseButton = New System.Windows.Forms.Button()
        Me.FileTextBox = New System.Windows.Forms.TextBox()
        Me.ConvertFileTextBox = New System.Windows.Forms.TextBox()
        Me.ConvertFileBrowseButton = New System.Windows.Forms.Button()
        Me.ConvertButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FileBrowseButton
        '
        Me.FileBrowseButton.Location = New System.Drawing.Point(597, 12)
        Me.FileBrowseButton.Name = "FileBrowseButton"
        Me.FileBrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.FileBrowseButton.TabIndex = 0
        Me.FileBrowseButton.Text = "Browse"
        Me.FileBrowseButton.UseVisualStyleBackColor = True
        '
        'FileTextBox
        '
        Me.FileTextBox.Location = New System.Drawing.Point(12, 12)
        Me.FileTextBox.Name = "FileTextBox"
        Me.FileTextBox.Size = New System.Drawing.Size(579, 22)
        Me.FileTextBox.TabIndex = 1
        '
        'ConvertFileTextBox
        '
        Me.ConvertFileTextBox.Location = New System.Drawing.Point(12, 177)
        Me.ConvertFileTextBox.Name = "ConvertFileTextBox"
        Me.ConvertFileTextBox.Size = New System.Drawing.Size(579, 22)
        Me.ConvertFileTextBox.TabIndex = 2
        '
        'ConvertFileBrowseButton
        '
        Me.ConvertFileBrowseButton.Location = New System.Drawing.Point(597, 177)
        Me.ConvertFileBrowseButton.Name = "ConvertFileBrowseButton"
        Me.ConvertFileBrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.ConvertFileBrowseButton.TabIndex = 3
        Me.ConvertFileBrowseButton.Text = "Browse"
        Me.ConvertFileBrowseButton.UseVisualStyleBackColor = True
        '
        'ConvertButton
        '
        Me.ConvertButton.Location = New System.Drawing.Point(300, 55)
        Me.ConvertButton.Name = "ConvertButton"
        Me.ConvertButton.Size = New System.Drawing.Size(100, 100)
        Me.ConvertButton.TabIndex = 4
        Me.ConvertButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 211)
        Me.Controls.Add(Me.ConvertButton)
        Me.Controls.Add(Me.ConvertFileBrowseButton)
        Me.Controls.Add(Me.ConvertFileTextBox)
        Me.Controls.Add(Me.FileTextBox)
        Me.Controls.Add(Me.FileBrowseButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Conversion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FileBrowseButton As Button
    Friend WithEvents FileTextBox As TextBox
    Friend WithEvents ConvertFileTextBox As TextBox
    Friend WithEvents ConvertFileBrowseButton As Button
    Friend WithEvents ConvertButton As Button
End Class
