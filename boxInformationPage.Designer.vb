<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class boxInformationPage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StepIndicator1 = New DevComponents.DotNetBar.Controls.StepIndicator()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.RichTextBoxEx1 = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.MetroToolbar1 = New DevComponents.DotNetBar.Metro.MetroToolbar()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer2 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer3 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer4 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer5 = New DevComponents.DotNetBar.ItemContainer()
        Me.MetroToolbar1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 74)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "标题"
        '
        'StepIndicator1
        '
        Me.StepIndicator1.Location = New System.Drawing.Point(0, -5)
        Me.StepIndicator1.Name = "StepIndicator1"
        Me.StepIndicator1.Size = New System.Drawing.Size(641, 15)
        Me.StepIndicator1.TabIndex = 7
        Me.StepIndicator1.Text = "StepIndicator1"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(485, 423)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(156, 34)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolColor = System.Drawing.Color.CornflowerBlue
        Me.ButtonX1.TabIndex = 8
        Me.ButtonX1.Text = "下一步"
        '
        'RichTextBoxEx1
        '
        '
        '
        '
        Me.RichTextBoxEx1.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.RichTextBoxEx1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RichTextBoxEx1.Font = New System.Drawing.Font("新宋体", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RichTextBoxEx1.Location = New System.Drawing.Point(0, 86)
        Me.RichTextBoxEx1.Name = "RichTextBoxEx1"
        Me.RichTextBoxEx1.ReadOnly = True
        Me.RichTextBoxEx1.Rtf = "{\rtf1\ansi\deff0{\fonttbl{\f0\fnil\fcharset134 \'d0\'c2\'cb\'ce\'cc\'e5;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\vie" & _
    "wkind4\uc1\pard\lang2052\b\f0\fs36 RichTextBoxEx1\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RichTextBoxEx1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBoxEx1.Size = New System.Drawing.Size(641, 331)
        Me.RichTextBoxEx1.TabIndex = 9
        Me.RichTextBoxEx1.Text = "RichTextBoxEx1"
        '
        'MetroToolbar1
        '
        Me.MetroToolbar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.MetroToolbar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroToolbar1.ContainerControlProcessDialogKey = True
        Me.MetroToolbar1.Controls.Add(Me.ButtonX4)
        Me.MetroToolbar1.Controls.Add(Me.ButtonX3)
        Me.MetroToolbar1.Controls.Add(Me.ButtonX2)
        Me.MetroToolbar1.Controls.Add(Me.NumericUpDown1)
        Me.MetroToolbar1.Controls.Add(Me.Label2)
        Me.MetroToolbar1.DragDropSupport = True
        Me.MetroToolbar1.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroToolbar1.ForeColor = System.Drawing.Color.Black
        Me.MetroToolbar1.Location = New System.Drawing.Point(0, 429)
        Me.MetroToolbar1.Name = "MetroToolbar1"
        Me.MetroToolbar1.Size = New System.Drawing.Size(214, 28)
        Me.MetroToolbar1.TabIndex = 10
        Me.MetroToolbar1.Text = "MetroToolbar1"
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Location = New System.Drawing.Point(162, 31)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(49, 23)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX4.TabIndex = 4
        Me.ButtonX4.Text = "回列表"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(10, 0)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(123, 23)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX3.Symbol = ""
        Me.ButtonX3.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonX3.TabIndex = 3
        Me.ButtonX3.Text = "上一步"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(108, 31)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(48, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.ButtonX2.TabIndex = 2
        Me.ButtonX2.Text = "确定"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(63, 31)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(39, 26)
        Me.NumericUpDown1.TabIndex = 1
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "跳转到"
        '
        'ItemContainer1
        '
        '
        '
        '
        Me.ItemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer1.Name = "ItemContainer1"
        '
        '
        '
        Me.ItemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ItemContainer2
        '
        '
        '
        '
        Me.ItemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer2.Name = "ItemContainer2"
        '
        '
        '
        Me.ItemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ItemContainer3
        '
        '
        '
        '
        Me.ItemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer3.Name = "ItemContainer3"
        '
        '
        '
        Me.ItemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ItemContainer4
        '
        '
        '
        '
        Me.ItemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer4.Name = "ItemContainer4"
        '
        '
        '
        Me.ItemContainer4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ItemContainer5
        '
        '
        '
        '
        Me.ItemContainer5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer5.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer5.Name = "ItemContainer5"
        '
        '
        '
        Me.ItemContainer5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'boxInformationPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 463)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroToolbar1)
        Me.Controls.Add(Me.RichTextBoxEx1)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.StepIndicator1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "boxInformationPage"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "啊啊啊"
        Me.MetroToolbar1.ResumeLayout(False)
        Me.MetroToolbar1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StepIndicator1 As DevComponents.DotNetBar.Controls.StepIndicator
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents RichTextBoxEx1 As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents MetroToolbar1 As DevComponents.DotNetBar.Metro.MetroToolbar
    Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer2 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ItemContainer3 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer4 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer5 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
End Class
