<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelect
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem6 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem7 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Node5 = New DevComponents.AdvTree.Node()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MetroTilePanel1 = New DevComponents.DotNetBar.Metro.MetroTilePanel()
        Me.ItemContainer2 = New DevComponents.DotNetBar.ItemContainer()
        Me.MetroTileItem2 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer()
        Me.MetroTileItem1 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem5 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem6 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem7 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem8 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem9 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.SlidePanel1 = New DevComponents.DotNetBar.Controls.SlidePanel()
        Me.lbinfo = New System.Windows.Forms.Label()
        Me.lbDesc = New System.Windows.Forms.Label()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.SlidePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonItem3
        '
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Text = "ButtonItem1"
        '
        'ButtonItem5
        '
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.Text = "ButtonItem1"
        '
        'ButtonItem6
        '
        Me.ButtonItem6.Name = "ButtonItem6"
        Me.ButtonItem6.Text = "ButtonItem1"
        '
        'ButtonItem7
        '
        Me.ButtonItem7.Name = "ButtonItem7"
        Me.ButtonItem7.Text = "ButtonItem1"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Enabled = False
        Me.ButtonX1.Location = New System.Drawing.Point(106, 159)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(101, 51)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX1.SymbolColor = System.Drawing.Color.LawnGreen
        Me.ButtonX1.TabIndex = 1
        Me.ButtonX1.Text = "开始"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(24, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 40)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "-/-"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(46, 107)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(121, 97)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Node5
        '
        Me.Node5.HostedControl = Me.ListView1
        Me.Node5.Name = "Node5"
        Me.Node5.Text = "ListView1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(299, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "请在下面的列表中选择，单击即可进入"
        '
        'MetroTilePanel1
        '
        Me.MetroTilePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.MetroTilePanel1.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTilePanel1.BackgroundStyle.Class = "MetroTilePanel"
        Me.MetroTilePanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTilePanel1.ContainerControlProcessDialogKey = True
        Me.MetroTilePanel1.DragDropSupport = True
        Me.MetroTilePanel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroTilePanel1.ForeColor = System.Drawing.Color.Black
        Me.MetroTilePanel1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer2})
        Me.MetroTilePanel1.Location = New System.Drawing.Point(12, 137)
        Me.MetroTilePanel1.Name = "MetroTilePanel1"
        Me.MetroTilePanel1.ScrollBarAppearance = DevComponents.DotNetBar.eScrollBarAppearance.ApplicationScroll
        Me.MetroTilePanel1.Size = New System.Drawing.Size(457, 384)
        Me.MetroTilePanel1.TabIndex = 8
        Me.MetroTilePanel1.Text = "MetroTilePanel1"
        '
        'ItemContainer2
        '
        '
        '
        '
        Me.ItemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer2.MultiLine = True
        Me.ItemContainer2.Name = "ItemContainer2"
        Me.ItemContainer2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MetroTileItem2})
        '
        '
        '
        Me.ItemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MetroTileItem2
        '
        Me.MetroTileItem2.Name = "MetroTileItem2"
        Me.MetroTileItem2.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem2.Text = "是啊是啊" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "是啊是啊"
        Me.MetroTileItem2.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        '
        '
        '
        Me.MetroTileItem2.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem2.TitleText = "是啊是啊"
        Me.MetroTileItem2.TitleTextAlignment = System.Drawing.ContentAlignment.BottomRight
        '
        'ItemContainer1
        '
        '
        '
        '
        Me.ItemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer1.MultiLine = True
        Me.ItemContainer1.Name = "ItemContainer1"
        Me.ItemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MetroTileItem1, Me.MetroTileItem5, Me.MetroTileItem6, Me.MetroTileItem7, Me.MetroTileItem8, Me.MetroTileItem9})
        '
        '
        '
        Me.ItemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MetroTileItem1
        '
        Me.MetroTileItem1.Name = "MetroTileItem1"
        Me.MetroTileItem1.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        '
        '
        '
        Me.MetroTileItem1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MetroTileItem5
        '
        Me.MetroTileItem5.Name = "MetroTileItem5"
        Me.MetroTileItem5.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem5.Text = "MetroTileItem5"
        Me.MetroTileItem5.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        '
        '
        '
        Me.MetroTileItem5.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MetroTileItem6
        '
        Me.MetroTileItem6.Name = "MetroTileItem6"
        Me.MetroTileItem6.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem6.Text = "MetroTileItem6"
        Me.MetroTileItem6.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        '
        '
        '
        Me.MetroTileItem6.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MetroTileItem7
        '
        Me.MetroTileItem7.Name = "MetroTileItem7"
        Me.MetroTileItem7.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem7.Text = "MetroTileItem7"
        Me.MetroTileItem7.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        '
        '
        '
        Me.MetroTileItem7.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MetroTileItem8
        '
        Me.MetroTileItem8.Name = "MetroTileItem8"
        Me.MetroTileItem8.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem8.Text = "MetroTileItem8"
        Me.MetroTileItem8.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        '
        '
        '
        Me.MetroTileItem8.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MetroTileItem9
        '
        Me.MetroTileItem9.Name = "MetroTileItem9"
        Me.MetroTileItem9.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem9.Text = "MetroTileItem9"
        Me.MetroTileItem9.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        '
        '
        '
        Me.MetroTileItem9.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(397, 524)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(33, 13)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "返回"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(436, 524)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(33, 13)
        Me.LinkLabel2.TabIndex = 11
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "刷新"
        '
        'SlidePanel1
        '
        Me.SlidePanel1.BackColor = System.Drawing.Color.Transparent
        Me.SlidePanel1.Controls.Add(Me.LinkLabel3)
        Me.SlidePanel1.Controls.Add(Me.lbinfo)
        Me.SlidePanel1.Controls.Add(Me.lbDesc)
        Me.SlidePanel1.Controls.Add(Me.lbTitle)
        Me.SlidePanel1.Controls.Add(Me.ButtonX1)
        Me.SlidePanel1.ForeColor = System.Drawing.Color.Black
        Me.SlidePanel1.Location = New System.Drawing.Point(31, 75)
        Me.SlidePanel1.Name = "SlidePanel1"
        Me.SlidePanel1.Size = New System.Drawing.Size(236, 226)
        Me.SlidePanel1.SlideOutButtonVisible = False
        Me.SlidePanel1.TabIndex = 0
        Me.SlidePanel1.Text = "SlidePanel1"
        Me.SlidePanel1.UsesBlockingAnimation = False
        '
        'lbinfo
        '
        Me.lbinfo.AutoSize = True
        Me.lbinfo.BackColor = System.Drawing.Color.Transparent
        Me.lbinfo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbinfo.Location = New System.Drawing.Point(14, 116)
        Me.lbinfo.Name = "lbinfo"
        Me.lbinfo.Size = New System.Drawing.Size(28, 21)
        Me.lbinfo.TabIndex = 12
        Me.lbinfo.Text = "-/-"
        '
        'lbDesc
        '
        Me.lbDesc.AutoSize = True
        Me.lbDesc.BackColor = System.Drawing.Color.Transparent
        Me.lbDesc.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDesc.Location = New System.Drawing.Point(15, 71)
        Me.lbDesc.Name = "lbDesc"
        Me.lbDesc.Size = New System.Drawing.Size(36, 25)
        Me.lbDesc.TabIndex = 11
        Me.lbDesc.Text = "-/-"
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = True
        Me.lbTitle.BackColor = System.Drawing.Color.Transparent
        Me.lbTitle.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitle.ForeColor = System.Drawing.Color.Black
        Me.lbTitle.Location = New System.Drawing.Point(11, 14)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(54, 40)
        Me.lbTitle.TabIndex = 10
        Me.lbTitle.Text = "-/-"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.LinkColor = System.Drawing.Color.MediumSlateBlue
        Me.LinkLabel3.Location = New System.Drawing.Point(159, 38)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel3.TabIndex = 13
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "返回列表"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel4.LinkColor = System.Drawing.Color.OrangeRed
        Me.LinkLabel4.Location = New System.Drawing.Point(397, 59)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(72, 13)
        Me.LinkLabel4.TabIndex = 12
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "开发者模式"
        Me.LinkLabel4.Visible = False
        '
        'frmSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.帮助库.My.Resources.Resources.newbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(485, 542)
        Me.ControlBox = False
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.SlidePanel1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MetroTilePanel1)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSelect"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.SlidePanel1.ResumeLayout(False)
        Me.SlidePanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem6 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem7 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Node5 As DevComponents.AdvTree.Node
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MetroTilePanel1 As DevComponents.DotNetBar.Metro.MetroTilePanel
    Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents MetroTileItem1 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem5 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem6 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem7 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem8 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem9 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents ItemContainer2 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents MetroTileItem2 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents SlidePanel1 As DevComponents.DotNetBar.Controls.SlidePanel
    Friend WithEvents lbDesc As System.Windows.Forms.Label
    Friend WithEvents lbTitle As System.Windows.Forms.Label
    Friend WithEvents lbinfo As System.Windows.Forms.Label
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
End Class
