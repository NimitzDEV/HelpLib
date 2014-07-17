Imports System.IO
Imports System.Text
Imports ICSharpCode
Imports ICSharpCode.SharpZipLib
Imports ICSharpCode.SharpZipLib.Zip
Imports ICSharpCode.SharpZipLib.Zip.Compression
Imports ICSharpCode.SharpZipLib.Core

Module zipService
    '''<summary>加压数据</summary>
    '''<param name="data">数据</param>
    '''<param name="offset">起始偏移</param>
    '''<param name="length">长度</param>
    '''<param name="level">压缩级别</param>
    Public Function Compress(ByVal data As Byte(), Optional ByVal offset As Integer = 0, Optional ByVal length As Integer = -1, Optional ByVal level As Integer = 9) As Byte()

        If data Is Nothing OrElse data.Length = 0 Then Return Nothing
        If offset < 0 Then offset = 0
        If length < 0 Then length = data.Length
        If level < 0 Then level = 1
        If level > 9 Then level = 9

        Dim ms As New MemoryStream
        Dim def As New Deflater

        def.SetLevel(level)
        def.SetInput(data, offset, length)
        Dim output(&H400 - 1) As Byte
        Do Until (def.IsFinished)
            Dim count As Integer = def.Deflate(output)
            ms.Write(output, 0, count)
        Loop

        Dim ret As Byte() = ms.ToArray
        ms.Close()
        Return ret
    End Function

    '''<summary>加压字符</summary>
    '''<param name="str">字符</param>
    '''<param name="enc">编码</param>
    '''<param name="level">压缩级别</param>
    Public Function CompressString(ByVal str As String, Optional ByVal enc As Encoding = Nothing, Optional ByVal level As Integer = 9) As Byte()
        If enc Is Nothing Then enc = Encoding.Default
        Dim data As Byte() = enc.GetBytes(str)
        Return Compress(data, , , level)
    End Function

    '''<summary>解压数据</summary>
    '''<param name="data">数据</param>
    Public Function Decompress(ByVal data As Byte()) As Byte()
        If data Is Nothing OrElse data.Length < 1 Then Return Nothing

        Dim ms As New MemoryStream
        Dim inf As New Inflater
        inf.SetInput(data)
        Dim buffer(&H400 - 1) As Byte
        Do Until (inf.IsFinished)
            Dim count As Integer = inf.Inflate(buffer)
            ms.Write(buffer, 0, count)
        Loop

        Dim ret As Byte() = ms.ToArray
        ms.Close()

        Return ret
    End Function

    '''<summary>解压字符</summary>
    '''<param name="data">数据</param>
    '''<param name="enc">编码</param>
    Public Function DecompressString(ByVal data As Byte(), Optional ByVal enc As Encoding = Nothing) As String
        If enc Is Nothing Then enc = Encoding.Default
        Dim bs As Byte() = Decompress(data)
        Return enc.GetString(bs)
    End Function


    '''<summary>快速加压</summary>
    Public Sub FastCreateZip(ByVal zipPath As String, ByVal folderPath As String, Optional ByVal fileFilter As String = "", Optional ByVal password As String = Nothing)
        Dim fz As New FastZip
        If password <> Nothing Then fz.Password = password
        fz.CreateZip(zipPath, folderPath, True, fileFilter)
    End Sub

    ' '''<summary>快速解压</summary>
    'Public Sub FastExtractZip(ByVal zipPath As String, ByVal folderPath As String, Optional ByVal fileFilter As String = "", Optional ByVal password As String = Nothing)
    '    'Dim fz As New FastZip
    '    'If password <> Nothing Then fz.Password = password
    '    'fz.ExtractZip(zipPath, folderPath, fileFilter)
    '    DecompressZip(zipPath, folderPath)
    'End Sub


    '''<summary>解压ZIP文件到目录</summary>
    '''<param name="zipPath">ZIP文件路径</param>
    '''<param name="folderPath">目标文件夹</param>
    '''<param name="password">密码</param>
    '''<param name="overwrite">是否覆盖文件</param>
    Public Sub DecompressZip(ByVal zipPath As String, ByVal folderPath As String, Optional ByVal password As String = Nothing, Optional ByVal overwrite As Boolean = True)
        ' 初始化文档、密码、目标文件夹路径
        Dim z As New ZipInputStream(File.OpenRead(zipPath))
        If password <> Nothing Then z.Password = password
        If folderPath = Nothing Then
            'folderPath = HttpContext.Current.Server.MapPath("~/")
            folderPath = Application.StartupPath
        End If
        If Not folderPath.EndsWith("\") Then folderPath &= "\"
        If Not Directory.Exists(folderPath) Then Directory.CreateDirectory(folderPath)

        Dim t As ZipEntry
        Dim fp As String

        ' 开始循环解压
        Do
            t = z.GetNextEntry
            If t Is Nothing Then Exit Do
            fp = folderPath & t.Name
            ' 如果是文件夹则创建文件夹
            If t.IsDirectory AndAlso Not Directory.Exists(fp) Then
                Directory.CreateDirectory(fp)
            ElseIf t.IsFile Then
                ' 如果是文件则解压文件
                If (Not File.Exists(fp)) OrElse (File.Exists(fp) And overwrite) Then
                    Dim sw As FileStream = File.Create(fp)
                    Dim size As Integer
                    Dim data(2048) As Byte
                    Do '循环读取数据
                        size = z.Read(data, 0, data.Length)
                        If size = 0 Then Exit Do
                        sw.Write(data, 0, size)
                    Loop
                    sw.Close()
                    File.SetLastWriteTime(fp, t.DateTime) '更新创建日期
                End If

            End If
        Loop

        z.Close()
    End Sub

    '''<summary>压缩某个目录内全部文档到ZIP</summary>
    '''<param name="zipPath">ZIP路径</param>
    '''<param name="folderPath">目标目录</param>
    '''<param name="level">压缩级别</param>
    '''<param name="password">密码</param>
    Public Sub CompressFile(ByVal zipPath As String, ByVal folderPath As String, Optional ByVal level As Integer = 9, Optional ByVal password As String = Nothing)

        If Not Directory.Exists(folderPath) Then Return
        If folderPath.EndsWith("\") Then folderPath &= "\"

        Dim z As New ZipOutputStream(File.Create(zipPath))
        z.SetLevel(level)
        If password <> Nothing Then z.Password = password

        Dim fn As String, buffer(4096) As Byte
        Dim di As Integer = folderPath.Length + 1

        ' 先将主目录下所有文件加入文档
        For Each f As String In Directory.GetFiles(folderPath, "*", SearchOption.TopDirectoryOnly)
            fn = f.Remove(0, di)
            z.PutNextEntry(New ZipEntry(fn))
            ' 将文件数据写入ZIP
            Using fs As FileStream = File.OpenRead(f)
                StreamUtils.Copy(fs, z, buffer)
            End Using
        Next

        ' 枚举所有文件夹
        For Each d As String In Directory.GetDirectories(folderPath, "*", SearchOption.AllDirectories)
            fn = d.Remove(0, di) & "\"
            z.PutNextEntry(New ZipEntry(fn))
            ' 枚举所有文件
            For Each f As String In Directory.GetFiles(d, "*", SearchOption.TopDirectoryOnly)
                fn = f.Remove(0, di)
                z.PutNextEntry(New ZipEntry(fn))
                Using fs As FileStream = File.OpenRead(f)
                    StreamUtils.Copy(fs, z, buffer)
                End Using
            Next
        Next

        z.Close()
    End Sub
End Module
