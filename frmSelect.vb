Public Class frmSelect
    Dim autoAddNode As Integer
    Dim allSolution(0, 0) As String
    'elements
    Dim xmlNode As Xml.XmlNode
    Dim xmlNode2 As Xml.XmlNode
    Dim xmlInnerNode As Xml.XmlNode
    Dim xe As Xml.XmlElement
    Dim overwriteInform As New Microsoft.WindowsAPICodePack.Dialogs.TaskDialog
    Private Sub frmSelect_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If startSign = 0 Then
            setMetroTheme()
            mainFrm.Show()
        End If
    End Sub
    Private Sub frmSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mainFrm.cbDebug.Checked Then LinkLabel4.Visible = True

        Me.BackColor = Color.FromArgb(23, 64, 109)

        Label4.ForeColor = Color.White
        lbDesc.ForeColor = Color.Orange
        Label3.ForeColor = Color.FromArgb(166, 185, 30)

        lbTitle.Left = Label3.Left
        lbTitle.Top = Label3.Top
        lbDesc.Left = lbTitle.Left
        lbDesc.Top = Label4.Top
        lbinfo.Left = lbDesc.Left


        lbTitle.ForeColor = Label3.ForeColor
        lbinfo.ForeColor = Color.White


        ButtonX1.Top = Me.Height - ButtonX1.Height * 2
        ButtonX1.Left = (Me.Width - ButtonX1.Width) / 2
        LinkLabel3.Top = lbTitle.Top
        LinkLabel3.Left = Me.Width - LinkLabel3.Width - 24
        SlidePanel1.Top = 0
        SlidePanel1.Left = 0
        SlidePanel1.Width = Me.Width
        SlidePanel1.Height = Me.Height
        SlidePanel1.IsOpen = False
        startSign = 0
        Select Case loadSolutionFileName
            Case "solve"
                Label3.Text = "解决一个问题"
            Case "learn"
                Label3.Text = "学习一项内容"
        End Select
        'Me.Text = Label3.Text
        loadList()
    End Sub

    Private Sub subclick(sender As Object, e As EventArgs)
        ButtonX1.Enabled = True
        ButtonX1.Tag = sender.tag - 1
        lbTitle.Text = allSolution(sender.tag - 1, 4)
        lbDesc.Text = allSolution(sender.tag - 1, 3)
        lbinfo.Top = lbDesc.Top + lbDesc.Height + 40
        lbinfo.Text = "作者：" & allSolution(sender.tag - 1, 1) & vbCrLf & "日期：" & allSolution(sender.tag - 1, 2) & vbCrLf & "文件：" & allSolution(sender.tag - 1, 0)
        LinkLabel3.Top = lbinfo.Top + lbinfo.Height + 15
        SlidePanel1.IsOpen = True
    End Sub

    Private Sub loadList()
        ItemContainer2.SubItems.Clear()
        Try
            autoAddNode = 0
            If My.Computer.FileSystem.FileExists(environPath & "list.xml") Then
                Dim doc As New Xml.XmlDocument
                '加载
                doc.Load(environPath & "list.xml")
                xmlNode = doc.SelectSingleNode("LiPaiXMLFileRoot")
                xmlNode2 = xmlNode.SelectSingleNode(loadSolutionFileName)
                listCount = xmlNode2.SelectNodes("item").Count
                ReDim allSolution(listCount - 1, 4)
                For Me.autoAddNode = 0 To listCount - 1
                    xmlInnerNode = xmlNode2.SelectNodes("item")(autoAddNode)
                    xe = CType(xmlInnerNode, Xml.XmlElement)
                    allSolution(autoAddNode, 0) = xe.GetAttribute("file")
                    allSolution(autoAddNode, 1) = xe.GetAttribute("author")
                    allSolution(autoAddNode, 2) = xe.GetAttribute("publish")
                    allSolution(autoAddNode, 3) = xe.GetAttribute("desc")
                    allSolution(autoAddNode, 4) = xe.GetAttribute("name")
                    Dim itemMain As New DevComponents.DotNetBar.Metro.MetroTileItem
                    itemMain.Text = shortString(allSolution(autoAddNode, 3))
                    itemMain.TitleText = allSolution(autoAddNode, 4)
                    itemMain.TileColor = CInt(Int(21 - 1 + 1) * Rnd() + 1)
                    itemMain.TitleTextAlignment = ContentAlignment.BottomRight
                    itemMain.Tag = autoAddNode + 1
                    AddHandler itemMain.Click, AddressOf subclick
                    ItemContainer2.SubItems.Add(itemMain)
                    ' 委托
                    'Me.Invoke(New sendMetrotile(AddressOf invokeAdd), itemMain, itemFrame)
                    Application.DoEvents()
                Next
            End If
            showToastMessage(Me, "列表加载完成", eToastPosition.BottomLeft, eToastGlowColor.Green)
            ItemContainer2.Refresh()
            MetroTilePanel1.AddItem("")
        Catch ex As Exception
            showException(ex.Message, ex.StackTrace, "ListCoreLoader")
        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If mainFrm.cbDebug.Checked = True Then
            If Dir(environPath & "Temp\main.xml") <> "" Then
                Dim buttonOverwrite As New TaskDialogCommandLink
                Dim buttonCancel As New TaskDialogCommandLink
                buttonOverwrite.Text = "确认进行覆盖"
                buttonCancel.Text = "取消本次操作"
                overwriteInform.Text = "你正在使用开发者模式，当使用开始按钮后你在Temp目录中调试的main.xml文件将会被覆盖！是否继续？" & vbCrLf & "如果需要使用开发者模式调试 请返回列表 点击右上角的开发者模式"
                overwriteInform.Caption = "覆盖确认"
                overwriteInform.FooterText = Label3.Text
                overwriteInform.Controls.Add(buttonCancel)
                overwriteInform.Controls.Add(buttonOverwrite)
                AddHandler buttonCancel.Click, AddressOf ovwNo
                AddHandler buttonOverwrite.Click, AddressOf ovwYes
                overwriteInform.DetailsCollapsedLabel = "在哪里？"
                overwriteInform.DetailsExpandedLabel = "收起"
                overwriteInform.DetailsExpandedText = "开发者模式就在右上角哦"
                overwriteInform.Show()
                Exit Sub

                'If MsgBox("你正在使用开发者模式，当使用开始按钮后你在Temp目录中调试的main.xml文件将会被覆盖！是否继续？", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "高能预警！") = MsgBoxResult.Cancel Then Exit Sub
            End If
        End If

        If Dir(environPath & allSolution(ButtonX1.Tag, 0)) = "" Then
            MsgBox("文件未找到！")
            Exit Sub
        End If
        DecompressZip(environPath & allSolution(ButtonX1.Tag, 0), environPath & "Temp\")
        executeProc()
    End Sub
    Private Sub ovwYes(ByVal sender As Object, ByVal e As EventArgs)
        If Dir(environPath & allSolution(ButtonX1.Tag, 0)) = "" Then
            MsgBox("文件未找到！")
            Exit Sub
        End If
        DecompressZip(environPath & allSolution(ButtonX1.Tag, 0), environPath & "Temp\")
        overwriteInform.Controls.Clear()
        overwriteInform.Close()
        executeProc()
    End Sub
    Private Sub ovwNo(ByVal sender As Object, ByVal e As EventArgs)
        SlidePanel1.IsOpen = False
        overwriteInform.Controls.Clear()
        overwriteInform.Close()
    End Sub

    Private Sub executeProc()
        excSolutionName = lbTitle.Text
        Dim ap As Integer
        getXmlInfo("", ap)
        allProcess = 0
        nowProcess = 0
        allProcess = ap
        PageSwitchBridge()
        startSign = 1
        Me.Close()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        MetroTilePanel1.Items.Remove(MetroTilePanel1.Items.Item(1))
        loadList()
        ButtonX1.Enabled = False
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        SlidePanel1.IsOpen = False
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        MsgBox("将开始调试Temp目录下的main.xml")
        If Dir(environPath & "Temp\main.xml") = "" Then
            MsgBox("文件未就绪")
            Exit Sub
        End If
        executeProc()
    End Sub
End Class