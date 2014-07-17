Public Class boxWANWebPage
    Private Sub boxWANWebPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '公共模块
        Dim finalPath As String
        finalPath = getXmlInfo("ref")
        StepIndicator1.StepCount = allProcess
        StepIndicator1.CurrentStep = nowProcess
        Me.Text = "正在进行： " & excSolutionName & " - 第" & nowProcess & "步 / 共" & allProcess & "步"
        ButtonX1.Text = autoGenButton()
        NumericUpDown1.Maximum = allProcess
        '独立解析模块
        Label1.Text = getXmlInfo("title")
        RichTextBoxEx1.Text = getXmlInfo("desc")
        If finalPath.Substring(0, 3) <> "http" Then
            If Dir(finalPath) = "" And Dir(finalPath, vbDirectory) = "" Then
                If Dir(environPath & "Temp\" & finalPath) <> "" Then finalPath = environPath & "Temp\" & finalPath
            End If
        End If
        WebBrowser1.Navigate(finalPath)
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
        PageSwitchBridge()
    End Sub
    Private Sub RadialMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem1.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub RadialMenuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem2.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub RadialMenuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem3.Click
        WebBrowser1.Navigate(getXmlInfo("ref"))
    End Sub

    Private Sub RadialMenuItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem4.Click
        WebBrowser1.GoBack()
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
        Me.Close()
        PageSwitchBridge()
    End Sub
End Class