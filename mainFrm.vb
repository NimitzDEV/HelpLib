Public Class mainFrm
    Dim tickTmp As Integer
    Dim debugInform As New Microsoft.WindowsAPICodePack.Dialogs.TaskDialog

    Private Sub debugOKClick(ByVal sender As Object, ByVal e As System.EventArgs)
        cbDebug.Checked = True
        debugInform.Controls.Clear()
        debugInform.Close()
    End Sub
    Private Sub debugCancelClick(ByVal sender As Object, ByVal e As System.EventArgs)
        cbDebug.Checked = False
        debugInform.Controls.Clear()
        debuginform.close()
    End Sub

    Private Sub mainFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        writeSettings()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '处理信息
        readSettings()
        environPath = Application.StartupPath & "\PData\"
        If Dir(environPath, vbDirectory) = "" Then MkDir(environPath)
        '----
        Me.Height = 498
        Me.Width = 506
        SlidePanel1.IsOpen = False
        setMetroTheme()
        Me.Text = Application.ProductName & " " & Application.ProductVersion
        Label4.Text = Me.Text
        Label4.Left = (SlidePanel1.Width - Label4.Width) / 2
        PictureBox4.Left = (SlidePanel1.Width - PictureBox4.Width) / 2
        Debug.Print(updatePath)
        If updatePath = "NONE" Then
            showToastMessage(Me, "查找路径已被重置", eToastPosition.BottomCenter, eToastGlowColor.Red)
            updatePath = environPath
        End If
        txtPath.Text = updatePath
    End Sub
    Private Sub RadialLearn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuLearnX.Click
            loadSolutionFileName = "learn"
            frmSelect.Show()
            Me.Visible = False
    End Sub
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        '排版界面
        Label1.Left = (Me.Width - Label1.Width) / 2
        Label2.Left = (Me.Width - Label2.Width) / 2
        RadialMenu1.Top = (Me.Height - RadialMenu1.Height) / 2
        RadialMenu1.Left = (Me.Width - RadialMenu1.Width - 20) / 2
        Label2.Top = RadialMenu1.Top + RadialMenu1.Height + 20
        Label1.Top = RadialMenu1.Top - Label1.Height - 20
        '升级页面
        udpBox.Left = (Me.Width - udpBox.Width) / 2
        LabelX2.Left = (Me.Width - LabelX2.Width) / 2
        CircularProgress1.Left = (Me.Width - CircularProgress1.Width) / 2
    End Sub

    Private Sub RadialSolve_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuSolveX.Click
            loadSolutionFileName = "solve"
            frmSelect.Show()
            Me.Visible = False
    End Sub

    Private Sub RadialExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuExitX.Click
        Me.Close()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        SlidePanel1.IsOpen = False
    End Sub

    Private Sub RadialMenuSettings_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuSettings.Click
        SuperTabControl1.SelectedTab = SuperTabItem1
        'ExpandablePanel1.Expanded = False
        SlidePanel1.IsOpen = True
    End Sub

    Private Sub RadialMenu1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenu1.Click
        SlidePanel1.Visible = True
    End Sub
    Private Sub SuperTabItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SuperTabItem2.Click
        udpBox.Image = My.Resources.update128
        CircularProgress1.IsRunning = True
        CircularProgress1.Visible = True
        LabelX2.Visible = False
        Timer1.Enabled = True
        LabelX2.Left = (Me.Width - LabelX2.Width) / 2
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tickTmp += 1
        If tickTmp = 1 Then
            Timer1.Enabled = False
            tickTmp = 0
            If My.Computer.FileSystem.DirectoryExists(updatePath) = False Then
                udpBox.Image = My.Resources.err
                LabelX2.Text = "无效的目录"
                LabelX2.Visible = True
                CircularProgress1.IsRunning = False
                CircularProgress1.Visible = False
                LabelX2.Left = (Me.Width - LabelX2.Width) / 2
                Exit Sub
            End If
            updateExecte(updatePath & "update.zip")
        End If
    End Sub
    Private Sub updateExecte(ByVal updateFile As String)
        If My.Computer.FileSystem.FileExists(updateFile) Then
            autoAddList(updateFile)
            udpBox.Image = My.Resources.ok_1_
            LabelX2.Text = "数据升级完成"
            LabelX2.Visible = True
            CircularProgress1.IsRunning = False
            CircularProgress1.Visible = False
            LabelX2.Left = (Me.Width - LabelX2.Width) / 2
            Exit Sub
        End If
        LabelX2.Text = "数据很新哦!"
        LabelX2.Left = (Me.Width - LabelX2.Width) / 2
        udpBox.Image = My.Resources.new128
        LabelX2.Visible = True
        CircularProgress1.IsRunning = False
        CircularProgress1.Visible = False
    End Sub


    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.Click
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\Updater.exe") = False Then
            showToastMessage(Me, "本功能暂时不可用", eToastPosition.MiddleCenter, eToastGlowColor.Blue)
            Exit Sub
        End If
        Process.Start(Application.StartupPath & "\Updater.exe")
        Me.Close()
    End Sub



    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("http://weibo.com/u/3703045777")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://weibo.com/u/2610146151")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://weibo.com/NimitzDEV")
    End Sub


    Private Sub debugAsk()
        Dim debugOK As New TaskDialogCommandLink
        Dim debugCancel As New TaskDialogCommandLink
        debugInform.InstructionText = "是否开启 开发者模式 "
        debugInform.Text = "本选项为一次性选项。开启本模式以后，列表界面将会出现调试XML按钮。点击该按钮会直接加载Temp目录下的main.xml文件。这样子，调试你的XML的时候就不用重复打包进行测试了。"
        debugInform.Caption = "Debug Mode"
        debugInform.FooterText = Me.Text
        debugOK.Text = "确认打开"
        debugCancel.Text = "不打开"
        AddHandler debugOK.Click, AddressOf debugOKClick
        AddHandler debugCancel.Click, AddressOf debugCancelClick
        debugInform.Controls.Add(debugOK)
        debugInform.Controls.Add(debugCancel)
        debugInform.Show()
    End Sub

    Private Sub cbDebug_Click(sender As Object, e As EventArgs) Handles cbDebug.Click
        If cbDebug.Checked = True Then
            debugAsk()
            Exit Sub
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fbd1.Description = "请选择升级包（update.zip）的查找路径"
        fbd1.ShowDialog()
        If fbd1.SelectedPath = "" Then
            showToastMessage(Me, "设置未更改", eToastPosition.BottomCenter, eToastGlowColor.Orange)
            Exit Sub
        End If
        updatePath = fbd1.SelectedPath & "\"
        txtPath.Text = updatePath
        showToastMessage(Me, "路径已经设置为 : " & updatePath, eToastPosition.BottomCenter, eToastGlowColor.Green)
    End Sub

    Private Sub dragUpdate_DragDrop(sender As Object, e As DragEventArgs) Handles dragUpdate.DragDrop
        For Each a As String In e.Data.GetData(DataFormats.FileDrop)
            Debug.Print(a.Substring(Len(a) - 3))
            If a.Substring(Len(a) - 3) <> "zip" Then
                showToastMessage(Me, "数据包格式错误", eToastPosition.MiddleCenter, eToastGlowColor.Red)
                Exit Sub
            End If
            SuperTabControl1.SelectedTab = SuperTabItem2
            showToastMessage(Me, "正在执行自定义升级，请稍候...", eToastPosition.BottomCenter, eToastGlowColor.Blue)
            updateExecte(a)
            Exit For
        Next
    End Sub

    Private Sub dragUpdate_DragEnter(sender As Object, e As DragEventArgs) Handles dragUpdate.DragEnter
        e.Effect = DragDropEffects.Link
    End Sub

    Private Sub dragUpdate_Click(sender As Object, e As EventArgs) Handles dragUpdate.Click
        showToastMessage(Me, "将数据包拖入本处，将进行自定义数据包升级", eToastPosition.MiddleCenter, eToastGlowColor.Green)
    End Sub
End Class