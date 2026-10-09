<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TSMI置顶 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI设置目标时间 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI时间显示格式 = New System.Windows.Forms.ToolStripMenuItem()
        Me.y = New System.Windows.Forms.ToolStripMenuItem()
        Me.m = New System.Windows.Forms.ToolStripMenuItem()
        Me.d = New System.Windows.Forms.ToolStripMenuItem()
        Me.h = New System.Windows.Forms.ToolStripMenuItem()
        Me.n = New System.Windows.Forms.ToolStripMenuItem()
        Me.s = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI透明度 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSCB透明度 = New System.Windows.Forms.ToolStripComboBox()
        Me.TSMI关闭 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSMI刷新 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(2, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "College Entrance Examination"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(98, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 50)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "123 Days"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(331, 91)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 38)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(292, 50)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(2, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 35)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "has only"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(247, 15)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 35)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "left"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TSMI置顶
        '
        Me.TSMI置顶.Checked = True
        Me.TSMI置顶.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TSMI置顶.Name = "TSMI置顶"
        Me.TSMI置顶.Size = New System.Drawing.Size(168, 26)
        Me.TSMI置顶.Text = "置顶"
        '
        'TSMI设置目标时间
        '
        Me.TSMI设置目标时间.Name = "TSMI设置目标时间"
        Me.TSMI设置目标时间.Size = New System.Drawing.Size(168, 26)
        Me.TSMI设置目标时间.Text = "设置目标时间"
        '
        'TSMI时间显示格式
        '
        Me.TSMI时间显示格式.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.y, Me.m, Me.d, Me.h, Me.n, Me.s})
        Me.TSMI时间显示格式.Name = "TSMI时间显示格式"
        Me.TSMI时间显示格式.Size = New System.Drawing.Size(168, 26)
        Me.TSMI时间显示格式.Text = "时间显示格式"
        '
        'y
        '
        Me.y.Name = "y"
        Me.y.Size = New System.Drawing.Size(147, 26)
        Me.y.Text = "年"
        '
        'm
        '
        Me.m.Name = "m"
        Me.m.Size = New System.Drawing.Size(147, 26)
        Me.m.Text = "月"
        '
        'd
        '
        Me.d.Checked = True
        Me.d.CheckState = System.Windows.Forms.CheckState.Checked
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(147, 26)
        Me.d.Text = "日(默认)"
        '
        'h
        '
        Me.h.Name = "h"
        Me.h.Size = New System.Drawing.Size(147, 26)
        Me.h.Text = "时"
        '
        'n
        '
        Me.n.Name = "n"
        Me.n.Size = New System.Drawing.Size(147, 26)
        Me.n.Text = "分"
        '
        's
        '
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(147, 26)
        Me.s.Text = "秒"
        '
        'TSMI透明度
        '
        Me.TSMI透明度.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSCB透明度})
        Me.TSMI透明度.Name = "TSMI透明度"
        Me.TSMI透明度.Size = New System.Drawing.Size(168, 26)
        Me.TSMI透明度.Text = "透明度"
        '
        'TSCB透明度
        '
        Me.TSCB透明度.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TSCB透明度.Items.AddRange(New Object() {"100%", "80%", "60%(默认)", "40%", "20%"})
        Me.TSCB透明度.Name = "TSCB透明度"
        Me.TSCB透明度.Size = New System.Drawing.Size(121, 28)
        '
        'TSMI关闭
        '
        Me.TSMI关闭.Name = "TSMI关闭"
        Me.TSMI关闭.Size = New System.Drawing.Size(168, 26)
        Me.TSMI关闭.Text = "关闭"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI置顶, Me.TSMI设置目标时间, Me.TSMI时间显示格式, Me.TSMI透明度, Me.TSMI刷新, Me.TSMI关闭})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowCheckMargin = True
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(169, 160)
        '
        'TSMI刷新
        '
        Me.TSMI刷新.Name = "TSMI刷新"
        Me.TSMI刷新.Size = New System.Drawing.Size(168, 26)
        Me.TSMI刷新.Text = "刷新"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(417, 167)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.Name = "Form1"
        Me.Opacity = 0.7R
        Me.ShowInTaskbar = False
        Me.Text = "桌面倒计时"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TSMI置顶 As ToolStripMenuItem
    Friend WithEvents TSMI设置目标时间 As ToolStripMenuItem
    Friend WithEvents TSMI时间显示格式 As ToolStripMenuItem
    Friend WithEvents y As ToolStripMenuItem
    Friend WithEvents m As ToolStripMenuItem
    Friend WithEvents d As ToolStripMenuItem
    Friend WithEvents h As ToolStripMenuItem
    Friend WithEvents n As ToolStripMenuItem
    Friend WithEvents s As ToolStripMenuItem
    Friend WithEvents TSMI透明度 As ToolStripMenuItem
    Friend WithEvents TSMI关闭 As ToolStripMenuItem
    Private WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TSMI刷新 As ToolStripMenuItem
    Friend WithEvents TSCB透明度 As ToolStripComboBox
End Class
