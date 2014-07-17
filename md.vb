Module md
    Public loadSolutionFileName As String
    Public environPath As String
    Public excSolutionName As String
    Public listCount As Integer
    Public allProcess As Integer
    Public nowProcess As Integer
    Public startSign As Integer
    '设置项目
    Public updatePath As String
    'elements
    Dim headerNode As Xml.XmlNode
    Dim subNode As Xml.XmlNode
    Dim subNode2 As Xml.XmlNode
    Dim optionNode As Xml.XmlElement
    Dim attrNode As Xml.XmlElement
    Public Function shortString(ByVal fullStr As String) As String
        If Len(fullStr) > 15 Then Return fullStr.Substring(0, 15) & "..."
        Return fullStr
    End Function
    Public Function getXmlInfo(ByVal optionName As String, Optional ByRef counts As Integer = 0) As String
        Dim thisFunctionString As String
        thisFunctionString = ""
        Try
            If My.Computer.FileSystem.FileExists(environPath & "Temp\main.xml") Then
                Dim doc As New Xml.XmlDocument
                doc.Load(environPath & "Temp\main.xml")
                headerNode = doc.SelectSingleNode("LiPaiXMLFileRoot")
                subNode = headerNode.SelectSingleNode("instruction")
                counts = subNode.SelectNodes("step").Count
                If optionName <> "" Then

                    subNode2 = subNode.SelectNodes("step")(nowProcess - 1)
                    optionNode = CType(subNode2, Xml.XmlNode)
                    thisFunctionString = System.Text.RegularExpressions.Regex.Unescape(optionNode.GetAttribute(optionName))
                    headerNode = Nothing
                    optionNode = Nothing

                End If
            End If
        Catch ex As Exception
            showException(ex.Message, ex.StackTrace, "LiPaiXMLCoreDecoder")
        End Try
        getXmlInfo = thisFunctionString
    End Function

    Public Sub PageSwitchBridge()
        If nowProcess = allProcess Then
            FinishForm.Show()
            Exit Sub
        End If
        If nowProcess < 0 Then nowProcess = 0
        nowProcess += 1
        Select Case getXmlInfo("type")
            Case "InformationPage"
                boxInformationPage.Show()
            Case "InformationPagePicture"
                boxInformationPagePicture.Show()
            Case "WebPage"
                boxWANWebPage.Show()
            Case "RTFPage"

            Case Else
                MsgBox("无法打开第" & nowProcess & "步" & vbCrLf & "此版本不支持帮助脚本所描述的页面类型：" & vbCrLf & "无法支持类型：" & getXmlInfo("author") & vbCrLf & "请尝试升级主程序" & vbCrLf & "或者尝试联系该脚本的作者：" & getXmlInfo("author"), vbOKOnly + vbExclamation, "页面桥异常 模块 LiPaiPageSwitchBridge")
                FinishForm.Show()
        End Select
    End Sub
    Public Function autoGenButton() As String
        Dim thisFunctionSign As String
        If nowProcess = allProcess Then
            thisFunctionSign = "完成"
        Else
            thisFunctionSign = "下一步"
        End If
        autoGenButton = thisFunctionSign
    End Function
    Public Sub setMetroTheme()
        Randomize()
        Select Case CInt(Int(7 - 1 + 1) * Rnd() + 1)
            Case 1
                mainFrm.RadialMenu1.Symbol = ChrW(&HF118).ToString()
                mainFrm.StyleManager1.MetroColorParameters = DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters.Orange
            Case 2
                mainFrm.RadialMenu1.Symbol = ChrW(&HF005).ToString()
                mainFrm.StyleManager1.MetroColorParameters = DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters.RedAmplified
            Case 3
                mainFrm.RadialMenu1.Symbol = ChrW(&HF0A6).ToString()
                mainFrm.StyleManager1.MetroColorParameters = DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters.Green
            Case 4
                mainFrm.RadialMenu1.Symbol = ChrW(&HF099).ToString()
                mainFrm.StyleManager1.MetroColorParameters = DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters.Blue
            Case 5
                mainFrm.RadialMenu1.Symbol = ChrW(&HF113).ToString()
                mainFrm.StyleManager1.MetroColorParameters = DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters.Purple
            Case 6
                mainFrm.RadialMenu1.Symbol = ChrW(&HF17B).ToString()
                mainFrm.StyleManager1.MetroColorParameters = DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters.Magenta
            Case 7
                mainFrm.RadialMenu1.Symbol = ChrW(&HF179).ToString()
                mainFrm.StyleManager1.MetroColorParameters = DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters.Red
            Case 8
                mainFrm.RadialMenu1.Symbol = ChrW(&HF185).ToString()
                mainFrm.StyleManager1.MetroColorParameters = DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters.ForestGreen
        End Select
    End Sub
    Public Sub showException(ByVal exName As String, ByVal exStack As String, ByVal decodeName As String)
        MsgBox("解析器 " & decodeName & " 运行时异常" & vbCrLf & "--------------------" & vbCrLf & _
               "错误描述：" & vbCrLf & exName & vbCrLf & vbCrLf & "--------------------" & vbCrLf & vbCrLf & "以下为开发者信息：" & vbCrLf _
                & exStack & vbCrLf _
               & "--------------------" & vbCrLf & "该错误可能由脚本引起" _
               , vbOKOnly + vbExclamation, "解析器 " & decodeName & " 运行时异常")
    End Sub
    Public Sub showToastMessage(ByVal targetForm As Form, ByVal showMessage As String, ByVal pos As eToastPosition, ByVal colour As eToastGlowColor)
        'ToastNotification.Show(targetForm, showMessage, 5000, pos)
        ToastNotification.Show(targetForm, showMessage, My.Resources.small, 5000, colour, pos)
    End Sub
    Public Sub autoAddList(ByVal updateFile As String)
        '----定义变量
        Dim ss As String
        Dim addName As String
        Dim addPath As String
        Dim addFile As String
        Dim addAuthor As String
        Dim addPublish As String
        Dim addDesc As String
        '----------重置与初始化
        addName = ""
        addPath = ""
        addFile = ""
        addAuthor = ""
        addPublish = ""
        addDesc = ""
        DecompressZip(updateFile, environPath)
        '------检查添加列表
        If My.Computer.FileSystem.FileExists(environPath & "update.txt") = False Then
            MsgBox("无法加载update列表，请联系升级作者！")
            Exit Sub
        End If
        '-------打开添加配置
        FileOpen(1, environPath & "update.txt", OpenMode.Input)
        Dim xmldoc As New Xml.XmlDocument
        Dim root As Xml.XmlNode
        xmldoc.Load(environPath & "list.xml")
        root = xmldoc.SelectSingleNode("LiPaiXMLFileRoot").SelectSingleNode(addFile)
        Dim xel As Xml.XmlElement = xmldoc.CreateElement("item")
        '--------历遍文件内容
        Do Until EOF(1)
            '---------读取
            ss = LineInput(1)
            '-------分离内容
            addName = Split(ss, "%")(0)
            addPath = Split(ss, "%")(1)
            addAuthor = Split(ss, "%")(2)
            addPublish = Split(ss, "%")(3)
            addDesc = Split(ss, "%")(4)
            addFile = Split(ss, "%")(5)
            '--------配置XML节点

            xel.SetAttribute("name", addName)
            xel.SetAttribute("file", addPath)
            xel.SetAttribute("author", addAuthor)
            xel.SetAttribute("publish", addPublish)
            xel.SetAttribute("desc", addDesc)
            root.AppendChild(xel)

            '--------更新到新的列表

        Loop
        xmldoc.Save(environPath & "list.xml")
        '----关闭文件与删除文件
        FileClose(1)
        If mainFrm.cbBackup.Checked = True Then
            If Dir(environPath & "升级备份", vbDirectory) = "" Then MkDir(environPath & "升级备份")
            FileCopy(updateFile, environPath & "升级备份\" & getDateString() & ".zip")
        End If
        Kill(environPath & "update.txt")
        Kill(updateFile)
        '-----更新完成
    End Sub
    Public Sub readSettings()
        updatePath = My.Settings.updateSearchingPath
        mainFrm.cbBackup.Checked = My.Settings.backupUpdate
    End Sub
    Public Sub writeSettings()
        My.Settings.updateSearchingPath = updatePath
        My.Settings.backupUpdate = mainFrm.cbBackup.Checked
        My.Settings.Save()
    End Sub
    Public Function getDateString() As String
        Return Year(Now) & Month(Now) & Hour(Now) & Minute(Now) & Second(Now)
    End Function
End Module