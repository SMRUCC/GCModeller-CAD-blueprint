﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraphPad
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        PictureBox1 = New PictureBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        AddNodeToolStripMenuItem = New ToolStripMenuItem()
        Timer1 = New Timer(components)
        AddLinkToolStripMenuItem = New ToolStripMenuItem()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.AliceBlue
        PictureBox1.ContextMenuStrip = ContextMenuStrip1
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(815, 577)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {AddNodeToolStripMenuItem, AddLinkToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(181, 70)
        ' 
        ' AddNodeToolStripMenuItem
        ' 
        AddNodeToolStripMenuItem.Name = "AddNodeToolStripMenuItem"
        AddNodeToolStripMenuItem.Size = New Size(128, 22)
        AddNodeToolStripMenuItem.Text = "Add Node"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 10
        ' 
        ' AddLinkToolStripMenuItem
        ' 
        AddLinkToolStripMenuItem.Name = "AddLinkToolStripMenuItem"
        AddLinkToolStripMenuItem.Size = New Size(180, 22)
        AddLinkToolStripMenuItem.Text = "Add Link"
        ' 
        ' GraphPad
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        Name = "GraphPad"
        Size = New Size(815, 577)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AddNodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents AddLinkToolStripMenuItem As ToolStripMenuItem

End Class
