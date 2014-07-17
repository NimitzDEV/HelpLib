Public Class FinishForm

    Private Sub FinishForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "非常开心"
        Select Case loadSolutionFileName
            Case "solve"
                Label1.Text = Label1.Text & vbCrLf & "你解决了一个问题"
            Case "learn"
                Label1.Text = Label1.Text & vbCrLf & "你学会了一项技能"
        End Select
        Label1.Left = (Me.Width - Label1.Width) / 2
        ButtonX1.Left = (Me.Width - ButtonX1.Width) / 2
        SwitchButton1.Left = (Me.Width - SwitchButton1.Width) / 2
        Label2.Left = (Me.Width - Label2.Width) / 2
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If SwitchButton1.Value = False Then
            setMetroTheme()
            mainFrm.Show()
            Me.Close()
        Else
            nowProcess = 0
            setMetroTheme()
            PageSwitchBridge()
            Me.Close()
        End If
    End Sub
End Class