Public Class boxInformationPagePicture
    Dim sourcePath As String
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
        PageSwitchBridge()
    End Sub

    Private Sub boxInformationPagePicture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            '公共模块
            StepIndicator1.StepCount = allProcess
            StepIndicator1.CurrentStep = nowProcess
        Me.Text = "正在进行： " & excSolutionName & " - 第" & nowProcess & "步 / 共" & allProcess & "步"
        ButtonX1.Text = autoGenButton()
        NumericUpDown1.Maximum = allProcess
        '独立解析模块
        sourcePath = getXmlInfo("pic")
        Label1.Text = getXmlInfo("title")
        RichTextBoxEx1.Text = getXmlInfo("desc")
        If My.Computer.FileSystem.FileExists(environPath & "Temp\" & sourcePath) Then
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(environPath & "Temp\" & sourcePath,IO.FileMode.Open, IO.FileAccess.Read)
            PictureBox1.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
        Else
            showToastMessage(Me, "无法加载<InstructionPic>节点所指示的文件" & vbCrLf & environPath & "Temp\" & sourcePath, eToastPosition.MiddleCenter, eToastGlowColor.Red)
        End If
    End Sub
    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        nowProcess -= 2
        Me.Close()
        PageSwitchBridge()
    End Sub
    Private Sub ButtonX4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        frmSelect.Show()
        Me.Close()
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        nowProcess = NumericUpDown1.Value - 1
        PictureBox1.Image = PictureBox1.ErrorImage
        Me.Close()
        PageSwitchBridge()
    End Sub
End Class