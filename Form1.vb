Imports System.IO
Imports Microsoft.Win32
Imports System.Diagnostics


Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim addp As New Dialog1
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddToAllowedProcessesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KillNowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowDependanciesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoogleItToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem15 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BbbbbbToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public watchfolder As FileSystemWatcher


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents IconMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuOpen As System.Windows.Forms.MenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lvwServices As System.Windows.Forms.ListView
    Friend WithEvents lchCaptions As System.Windows.Forms.ColumnHeader
    Friend WithEvents lchNames As System.Windows.Forms.ColumnHeader
    Friend WithEvents lchState As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents tvw As System.Windows.Forms.TreeView
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents txt_watchpath As System.Windows.Forms.TextBox
    Friend WithEvents txt_folderactivity As System.Windows.Forms.TextBox
    Friend WithEvents btn_stop As System.Windows.Forms.Button
    Friend WithEvents btn_startwatch As System.Windows.Forms.Button
    Friend WithEvents MenuExit As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.IconMenu = New System.Windows.Forms.ContextMenu
        Me.MenuOpen = New System.Windows.Forms.MenuItem
        Me.MenuExit = New System.Windows.Forms.MenuItem
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label1 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.lvwServices = New System.Windows.Forms.ListView
        Me.lchCaptions = New System.Windows.Forms.ColumnHeader
        Me.lchNames = New System.Windows.Forms.ColumnHeader
        Me.lchState = New System.Windows.Forms.ColumnHeader
        Me.cmdRefresh = New System.Windows.Forms.Button
        Me.cmdStart = New System.Windows.Forms.Button
        Me.cmdStop = New System.Windows.Forms.Button
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.tvw = New System.Windows.Forms.TreeView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToAllowedProcessesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KillNowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ShowDependanciesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GoogleItToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.btn_stop = New System.Windows.Forms.Button
        Me.btn_startwatch = New System.Windows.Forms.Button
        Me.txt_watchpath = New System.Windows.Forms.TextBox
        Me.txt_folderactivity = New System.Windows.Forms.TextBox
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.BbbbbbToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IconMenu
        '
        Me.IconMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuOpen, Me.MenuExit})
        '
        'MenuOpen
        '
        Me.MenuOpen.Index = 0
        Me.MenuOpen.Text = "Open"
        '
        'MenuExit
        '
        Me.MenuExit.Index = 1
        Me.MenuExit.Text = "Exit"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 37)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(483, 408)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.TreeView1)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(475, 382)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Processes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Allowed Processes"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Location = New System.Drawing.Point(139, 354)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(114, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Close Automatically"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(361, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Default Install"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.ContextMenuStrip = Me.ContextMenuStrip2
        Me.TreeView1.Location = New System.Drawing.Point(20, 36)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(430, 307)
        Me.TreeView1.TabIndex = 1
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem13, Me.ToolStripMenuItem14, Me.ToolStripMenuItem15, Me.ToolStripMenuItem16})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(211, 114)
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BbbbbbToolStripMenuItem})
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(210, 22)
        Me.ToolStripMenuItem13.Text = "Add To Allowed Processes"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(210, 22)
        Me.ToolStripMenuItem14.Text = "Kill Now"
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(210, 22)
        Me.ToolStripMenuItem15.Text = "Show Dependancies"
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(210, 22)
        Me.ToolStripMenuItem16.Text = "Google it"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(20, 349)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(49, 24)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Add "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(265, 349)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 24)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Save Changes"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(75, 349)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(53, 24)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lvwServices)
        Me.TabPage2.Controls.Add(Me.cmdRefresh)
        Me.TabPage2.Controls.Add(Me.cmdStart)
        Me.TabPage2.Controls.Add(Me.cmdStop)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(475, 382)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Services"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lvwServices
        '
        Me.lvwServices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lchCaptions, Me.lchNames, Me.lchState})
        Me.lvwServices.FullRowSelect = True
        Me.lvwServices.GridLines = True
        Me.lvwServices.Location = New System.Drawing.Point(28, 19)
        Me.lvwServices.Name = "lvwServices"
        Me.lvwServices.Size = New System.Drawing.Size(424, 328)
        Me.lvwServices.TabIndex = 6
        Me.lvwServices.UseCompatibleStateImageBehavior = False
        Me.lvwServices.View = System.Windows.Forms.View.Details
        '
        'lchCaptions
        '
        Me.lchCaptions.Text = "Service"
        Me.lchCaptions.Width = 200
        '
        'lchNames
        '
        Me.lchNames.Text = "Real Names"
        Me.lchNames.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lchNames.Width = 100
        '
        'lchState
        '
        Me.lchState.Text = "State"
        Me.lchState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lchState.Width = 100
        '
        'cmdRefresh
        '
        Me.cmdRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdRefresh.Location = New System.Drawing.Point(28, 353)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(84, 24)
        Me.cmdRefresh.TabIndex = 5
        Me.cmdRefresh.Text = "Refresh"
        '
        'cmdStart
        '
        Me.cmdStart.Enabled = False
        Me.cmdStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdStart.Location = New System.Drawing.Point(368, 353)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(84, 24)
        Me.cmdStart.TabIndex = 3
        Me.cmdStart.Text = "Start Service"
        '
        'cmdStop
        '
        Me.cmdStop.Enabled = False
        Me.cmdStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdStop.Location = New System.Drawing.Point(280, 353)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(84, 24)
        Me.cmdStop.TabIndex = 4
        Me.cmdStop.Text = "Stop Service"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.CheckBox4)
        Me.TabPage3.Controls.Add(Me.CheckBox3)
        Me.TabPage3.Controls.Add(Me.CheckBox2)
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.tvw)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(475, 382)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Task List"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(201, 349)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(89, 17)
        Me.CheckBox4.TabIndex = 4
        Me.CheckBox4.Text = "Automatic Kill"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(86, 349)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(109, 17)
        Me.CheckBox3.TabIndex = 3
        Me.CheckBox3.Text = "Execution Notifier"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(19, 349)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(61, 17)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "Monitor"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(351, 342)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(105, 28)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Show Processes"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'tvw
        '
        Me.tvw.ContextMenuStrip = Me.ContextMenuStrip1
        Me.tvw.Location = New System.Drawing.Point(19, 19)
        Me.tvw.Name = "tvw"
        Me.tvw.Size = New System.Drawing.Size(437, 317)
        Me.tvw.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToAllowedProcessesToolStripMenuItem, Me.KillNowToolStripMenuItem, Me.ShowDependanciesToolStripMenuItem, Me.GoogleItToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(211, 92)
        '
        'AddToAllowedProcessesToolStripMenuItem
        '
        Me.AddToAllowedProcessesToolStripMenuItem.Name = "AddToAllowedProcessesToolStripMenuItem"
        Me.AddToAllowedProcessesToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.AddToAllowedProcessesToolStripMenuItem.Text = "Add To Allowed Processes"
        '
        'KillNowToolStripMenuItem
        '
        Me.KillNowToolStripMenuItem.Name = "KillNowToolStripMenuItem"
        Me.KillNowToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.KillNowToolStripMenuItem.Text = "Kill Now"
        '
        'ShowDependanciesToolStripMenuItem
        '
        Me.ShowDependanciesToolStripMenuItem.Name = "ShowDependanciesToolStripMenuItem"
        Me.ShowDependanciesToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ShowDependanciesToolStripMenuItem.Text = "Show Dependancies"
        '
        'GoogleItToolStripMenuItem
        '
        Me.GoogleItToolStripMenuItem.Name = "GoogleItToolStripMenuItem"
        Me.GoogleItToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.GoogleItToolStripMenuItem.Text = "Google it"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btn_stop)
        Me.TabPage4.Controls.Add(Me.btn_startwatch)
        Me.TabPage4.Controls.Add(Me.txt_watchpath)
        Me.TabPage4.Controls.Add(Me.txt_folderactivity)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(475, 382)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Share Access"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btn_stop
        '
        Me.btn_stop.Location = New System.Drawing.Point(354, 70)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(75, 23)
        Me.btn_stop.TabIndex = 3
        Me.btn_stop.Text = "Button7"
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'btn_startwatch
        '
        Me.btn_startwatch.Location = New System.Drawing.Point(354, 24)
        Me.btn_startwatch.Name = "btn_startwatch"
        Me.btn_startwatch.Size = New System.Drawing.Size(75, 23)
        Me.btn_startwatch.TabIndex = 2
        Me.btn_startwatch.Text = "Button6"
        Me.btn_startwatch.UseVisualStyleBackColor = True
        '
        'txt_watchpath
        '
        Me.txt_watchpath.Location = New System.Drawing.Point(21, 28)
        Me.txt_watchpath.Name = "txt_watchpath"
        Me.txt_watchpath.Size = New System.Drawing.Size(265, 20)
        Me.txt_watchpath.TabIndex = 1
        '
        'txt_folderactivity
        '
        Me.txt_folderactivity.Location = New System.Drawing.Point(22, 99)
        Me.txt_folderactivity.Multiline = True
        Me.txt_folderactivity.Name = "txt_folderactivity"
        Me.txt_folderactivity.Size = New System.Drawing.Size(434, 268)
        Me.txt_folderactivity.TabIndex = 0
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save as"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem6, Me.ToolStripMenuItem11})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(511, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(35, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(123, 22)
        Me.ToolStripMenuItem2.Text = "Open"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(123, 22)
        Me.ToolStripMenuItem3.Text = "Save"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(123, 22)
        Me.ToolStripMenuItem4.Text = "Save as"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(123, 22)
        Me.ToolStripMenuItem5.Text = "Exit"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10})
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem6.Text = "Edit"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(124, 22)
        Me.ToolStripMenuItem7.Text = "Cut"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(124, 22)
        Me.ToolStripMenuItem8.Text = "Copy"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(124, 22)
        Me.ToolStripMenuItem9.Text = "Paste"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(124, 22)
        Me.ToolStripMenuItem10.Text = "Settings"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem12})
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(40, 20)
        Me.ToolStripMenuItem11.Text = "Help"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripMenuItem12.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 459)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(511, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'BbbbbbToolStripMenuItem
        '
        Me.BbbbbbToolStripMenuItem.Name = "BbbbbbToolStripMenuItem"
        Me.BbbbbbToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BbbbbbToolStripMenuItem.Text = "bbbbbb"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(511, 481)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Windows Process Controller"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    '#############################################################################
    '# This form minimizes to the system tray and handles a Right-Click menu     #
    '# of the icon in the system tray as well as the double click of the icon    #
    '# Append the following code to your form for functionality                  #
    '# You can add items to the Right-Click of the system tray icon menu by      #
    '# adding them to the context menu of the form                               #
    '#                                                                           #
    '# For Visual Basic .NET 2003 (It may also work on .NET 2002 but i haven't   #
    '# tested it yet)                                                            #
    '#                                                                           #
    '# By Juan Estrada                                                           #
    '#                                                                           #
    '# Comments and suggestions (In English or Spanish ONLY)                     #
    '# jestrada@montevideo.com.uy                                                #
    '#                                                                           #
    '#############################################################################

    Public WithEvents TrayIcon As NotifyIcon    'This is the tray icon to be
    ' displayed, the WithEvents is to handle the double-click of the tray icon

    Private Shown As Boolean                     'This variable is used to hide
    ' tray icon when the form is visible. It really tells if the form is beeing
    ' shown (Suggestion: Try to find another way to make this work, becouse this
    ' isn't very nice (But it works)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' !!! You have to add this code to the Form.Load Event Handler !!!

        TrayIcon = New NotifyIcon ' Makes a new instance of the tray icon (this
        '                           automatically creates it on the System Tray

        Shown = True '              The form is currently shown, so...


        With TrayIcon '                         Let's fill the tray icon
            .Visible = False '                  Becouse the form is currently
            '                                   shown, let's hide the tray icon
            .Icon = Me.Icon '                   You can define the image to be
            '                                   shown here, i put the icon of the
            '                                   form
            .Text = "Aplication Running..." '   This is the tool tip text that 
            '                                   shows the icon (You can change it
            '                                   dinamicaly)
            .ContextMenu = Me.IconMenu '        This tells the icon to show the 
            '                                   popup menu defined in the form
        End With

        If (FindKey("HKEY_LOCAL_MACHINE", "Software\WPK") = True) Then

            Button1.Enabled = False
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            CheckBox1.Enabled = True
            TreeView1.Enabled = True
            Button1.ForeColor = Color.Black


            Dim sRegNames As String()
            Dim regKey As RegistryKey
            regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\WPK\allowed", True)
            sRegNames = regKey.GetValueNames
            For Each sRegName As String In sRegNames
                Dim fff As String = regKey.GetValue(sRegName)
                TreeView1.Nodes.Add(fff)
            Next
            regKey.Close()

            Dim c As String
            Dim regKey1 As RegistryKey
            regKey1 = Registry.LocalMachine.OpenSubKey("SOFTWARE\WPK\settings", True)
            c = regKey1.GetValue("close")

            If c = "yes" Then
                CheckBox1.Checked = True
            End If
            regKey1.Close()

        Else
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            CheckBox1.Enabled = False
            TreeView1.Enabled = False
            Button1.ForeColor = Color.Red

        End If

    End Sub
#Region " IconMenu Handlers "
    ' !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    ' !!! You have to add this  handlers to your form to handle the IconMenu events !!!
    ' !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    Private Sub MenuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrayIcon.DoubleClick, MenuOpen.Click
        ' This handler restores the window when you click open in the 
        ' IconMenu-Open or when you double-click on the tray icon

        Me.WindowState = FormWindowState.Normal '   Restores the window
        Me.ShowInTaskbar = True '                   Show the TaskBar button
        Shown = True '                              The form is currently shown, so...
        TrayIcon.Visible = False '                  Hides the tray icon

    End Sub

    Private Sub MenuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuExit.Click
        ' This handler exits the program when you click exit in the IconMenu-Exit
        ' WARNING!!!: If you have a code for the closing of the program, call it
        ' !!!!!!!!!!  from here, or it may not be executed

        TrayIcon.Visible = False '  This hides the tray icon before closing the
        '                           application. This is nessesary becouse of a
        '                           problem with some Windows (like XP) that don't
        '                           refresh the System Tray unless you hover the 
        '                           mouse over it
        Me.Close() '                Closes the form
        End '                       Ends the program

    End Sub

#End Region

    Private Sub Form1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        ' This handler hides the Taskbar button of the window and shows the tray icon
        ' if the form was minimized
        If Shown And Me.WindowState = FormWindowState.Minimized Then
            Shown = False '                 The form is currently hided, so...
            Me.ShowInTaskbar = False '      Hides the Taskbar button of the form
            TrayIcon.Visible = True '       Shows the tray icon
        End If
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim regKey As RegistryKey
        regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", True)
        regKey.CreateSubKey("WPK")
        regKey.CreateSubKey("WPK\settings")
        regKey.CreateSubKey("WPK\allowed")
        regKey.Close()

        Dim allowed As New ArrayList()
        allowed.Add("NPROTECT")
        allowed.Add("SVCHOST")
        allowed.Add("NAVAPSVC")
        allowed.Add("SPBBCSvc")
        allowed.Add("symlcsvc")
        allowed.Add("svchost")
        allowed.Add("winlogon")
        allowed.Add("WINLOGON")
        allowed.Add("gcasDtServ")
        allowed.Add("CCAPP")
        allowed.Add("rundll32")
        allowed.Add("LSASS")
        allowed.Add("svchost")
        allowed.Add("explorer")
        allowed.Add("stop")
        allowed.Add("atiptaxx")
        allowed.Add("NPFMNTOR")
        allowed.Add("NMBgMonitor")
        allowed.Add("spoolsv")
        allowed.Add("MDM")
        allowed.Add("smss")
        allowed.Add("SNDSrvc")
        allowed.Add("lsass")
        allowed.Add("taskkill")
        allowed.Add("svchost")
        allowed.Add("csrss")
        allowed.Add("CCSETMGR")
        allowed.Add("services")
        allowed.Add("SERVICES")
        allowed.Add("svchost")
        allowed.Add("CCEVTMGR")
        allowed.Add("ati2evxx")
        allowed.Add("alg")
        allowed.Add("svchost")
        allowed.Add("NOPDB")
        allowed.Add("ati2evxx")
        allowed.Add("ctfmon")
        allowed.Add("cmd")
        allowed.Add("TaskSwitch")
        allowed.Add("System")
        allowed.Add("Idle")
        allowed.Add("ScreenShield")
        allowed.Add("Click Here Program Stopper.vshost")
        allowed.Add("devenv")
        allowed.Add("EXPLORER")
        allowed.Add("NMain")
        allowed.Add("BitComet")

        Dim regKey1 As RegistryKey
        regKey1 = Registry.LocalMachine.OpenSubKey("SOFTWARE\WPK\allowed", True)
        Dim i As Integer
        Dim process As String
        For i = 0 To allowed.Count - 1
            process = allowed(i)
            TreeView1.Nodes.Add(process)
            regKey1.SetValue(i, process)
        Next
        regKey1.Close()

        Dim regKey2 As RegistryKey
        regKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\WPK\settings", True)
        regKey2.SetValue("show", "yes")
        regKey2.SetValue("close", "yes")
        regKey2.Close()

        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        CheckBox1.Enabled = True
        CheckBox1.Checked = True
        TreeView1.Enabled = True
        Button1.ForeColor = Color.Black
        Button1.Enabled = False

        ReadSvcs()

    End Sub

    Public Function FindKey(ByVal type As String, ByVal key As String)
        Select Case type
            Case "HKEY_LOCAL_MACHINE"
                Dim regKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(key, True)
                If Not (regKey Is Nothing) Then
                    Return True
                End If
            Case "HKEY_CURRENT_USER"
                Dim regKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(key, True)
                If Not (regKey Is Nothing) Then
                    Return True
                End If
            Case "HKEY_CLASSES_ROOT"
                Dim regKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(key, True)
                If Not (regKey Is Nothing) Then
                    Return True
                End If
            Case "HKEY_USERS"
                Dim regKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.Users.OpenSubKey(key, True)
                If Not (regKey Is Nothing) Then
                    Return True
                End If
            Case "HKEY_CURRENT_CONFIG"
                Dim regKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentConfig.OpenSubKey(key, True)
                If Not (regKey Is Nothing) Then
                    Return True
                End If
        End Select
        Return False
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        addp.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            TreeView1.SelectedNode.Remove()
            Button4.Text = "Save Changes"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim tnode As TreeNode

        Dim regKey As RegistryKey
        regKey = Registry.LocalMachine.OpenSubKey("Software\WPK", True)
        regKey.DeleteSubKey("allowed", True)
        regKey.Close()
        Dim i As Integer
        Dim regKey1 As RegistryKey
        regKey1 = Registry.LocalMachine.OpenSubKey("SOFTWARE\WPK", True)
        regKey1.CreateSubKey("allowed")
        regKey1 = Registry.LocalMachine.OpenSubKey("SOFTWARE\WPK\allowed", True)
        For Each tnode In TreeView1.Nodes
            regKey1.SetValue(i, tnode.Text)
            i = i + 1
        Next
        regKey1.Close()

        Dim regKey2 As RegistryKey
        regKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\WPK\settings", True)
        If CheckBox1.Checked = True Then ' close
            regKey2.SetValue("close", "yes")
        End If
        If CheckBox1.Checked = False Then ' close
            regKey2.SetValue("close", "no")
        End If
        Button4.Text = "Saved"

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Button4.Text = "Save Changes"
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Button4.Text = "Save Changes"
    End Sub

    Sub ReadSvcs() 'of his old football
        Dim ListSvcs() As ServiceProcess.ServiceController 'games from back in the day,
        Dim SingleSvc As ServiceProcess.ServiceController 'when "your mother and I were dating."  But the
        Dim LVW As ListViewItem 'warm fuzzy of nostalgia,

        ListSvcs = SingleSvc.GetServices 'knowing that yes, you accomplished something, makes the world

        lvwServices.Items.Clear() 'feel a bit easier to deal with, and
        Try 'eventual death acceptable, almost as though we
            For Each SingleSvc In ListSvcs 'have made
                LVW = lvwServices.Items.Add(SingleSvc.DisplayName) 'indelible marks upon the history of whatever.
                LVW.SubItems.Add(SingleSvc.ServiceName) 'But a sigh usually caps off the standard cock-
                LVW.SubItems.Add(SingleSvc.Status.ToString) 'stroking session of the BBS-days bullshit, when we had
                LVW.SubItems.Add(SingleSvc.ServiceType.ToString) 'only 32 baud modems.  Maybe it's that I need to know
            Next 'how little I knew, how young I was, to re-
        Catch e As Exception 'assure myself of the growth that I have (?) experienced,  
            MessageBox.Show("Could not initialize Windows Service engine.  Restarting your computer may work", "Fatal Error: " & e.Source)
        End Try 'magic marker lines with my handle and the date,  maybe
    End Sub 'a dial-in or two on some sort of collective

    Private Sub lvwServices_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwServices.Click 'parental
        If lvwServices.SelectedItems(0).Text <> "" Then 'doorjam belonging to history herself.  It could be
            Select Case lvwServices.SelectedItems(0).SubItems(2).Text 'a quest for immortality, 
                Case "Stopped" 'for power -- all expressions of sexual
                    cmdStop.Enabled = False 'drives -- or maybe a hug for my inner child. 
                    cmdStart.Enabled = True 'But I 

                Case "Running" 'am not by any means someone who has any clue 
                    cmdStop.Enabled = True 'about
                    cmdStart.Enabled = False 'anything, other than distilled problems which 

                Case Else 'can be expressed in purely logical situations, which is
                    cmdStop.Enabled = False 'almost a moot point when dealing 
                    cmdStart.Enabled = False 'with complex systems such
            End Select 'as human interaction.  
        End If 'Feeling... like a jazz
    End Sub 'note on life, thoughts from the crowds, 

    Private Sub cmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStop.Click
        If lvwServices.SelectedItems(0).Text <> "" Then 'interacting, loving? 
            Call StopService(lvwServices.SelectedItems(0).SubItems(1).Text) 'each one special in its own way.  
        End If 'It has 
    End Sub 'been said that empathy is what 

    Sub StopService(ByVal ServiceName As String) 'sets us apart from the 
        Dim ListSvcs() As ServiceProcess.ServiceController 'animals, but does  
        Dim SingleSvc As ServiceProcess.ServiceController 'anyone give a 

        ListSvcs = SingleSvc.GetServices 'rat's ass about other people 

        Try 'when their own lives are at a
            For Each SingleSvc In ListSvcs 'crossroads? 
                If UCase(SingleSvc.ServiceName) = UCase(ServiceName) Then  'Nihilism.  
                    SingleSvc.Stop() 'The opposite of hippiedom?  The cyclical 
                    Call ReadSvcs() 'nature of the thread, which  
                    Exit For 'should just be trashed, 
                End If 'but that is okay.  
            Next 'Vibes can be recorded,
        Catch e As Exception 'saved, reflected upon,
            MessageBox.Show("Could not stop service.  Ensure it is not disabled", "Fatal Error: " & e.Source)
        End Try 'cherished possibly,
    End Sub ' forgotten probably. 

    Sub StartService(ByVal ServiceName As String) 'but it can be hoped
        Dim ListSvcs() As ServiceProcess.ServiceController 'that someone, 
        Dim SingleSvc As ServiceProcess.ServiceController 'years from now,

        ListSvcs = SingleSvc.GetServices ' reads this, 

        Try
            For Each SingleSvc In ListSvcs 'and imagines the 
                If UCase(SingleSvc.ServiceName) = UCase(ServiceName) Then
                    SingleSvc.Start() 'the writer, 
                    Call ReadSvcs() 'back in the day, 
                    Exit For 'reminiscing on when the sounds
                End If 'and the medium actually meant freedom of thought,
            Next ' and,
        Catch e As Exception 'possibly, a shot at eternal life.
            MessageBox.Show("Could not start service.  Ensure it is not disabled", "Fatal Error: " & e.Source)
        End Try 'But me? What do I have now that cant be emulated or recreated by technology?
    End Sub 'Only my mind

    Private Sub cmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.Click
        If lvwServices.SelectedItems(0).Text <> "" Then
            Call StartService(lvwServices.SelectedItems(0).SubItems(1).Text)
        End If
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        Call ReadSvcs()
    End Sub

    Private Sub tvw_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tvw.MouseUp

        Dim objButton As MouseButtons = Nothing

        Try
            If e.Button = MouseButtons.Right Then
                '** At what point is the mouse?
                Dim ptClient As Point = New Point(e.X, e.Y)
                '** Get the Node just below the mouse.
                Dim objDragTargetNode As TreeNode = CType(Me.tvw.GetNodeAt(ptClient), TreeNode)

                '** If this not is not already selected, then select it.
                If Not Me.tvw.SelectedNode Is objDragTargetNode Then
                    Me.tvw.SelectedNode = objDragTargetNode
                End If

                Me.Refresh() '** May not have an impact on the behavior - test this
                System.Windows.Forms.Application.DoEvents()
            End If
            Dim xxx As New ContextMenuStrip
            xxx.Show()



        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub treeview1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView1.MouseUp

        Dim objButton As MouseButtons = Nothing

        Try
            If e.Button = MouseButtons.Right Then
                '** At what point is the mouse?
                Dim ptClient As Point = New Point(e.X, e.Y)
                '** Get the Node just below the mouse.
                Dim objDragTargetNode As TreeNode = CType(Me.tvw.GetNodeAt(ptClient), TreeNode)

                '** If this not is not already selected, then select it.
                If Not Me.tvw.SelectedNode Is objDragTargetNode Then
                    Me.tvw.SelectedNode = objDragTargetNode
                End If

                Me.Refresh() '** May not have an impact on the behavior - test this
                System.Windows.Forms.Application.DoEvents()
            End If
            Dim xxx As New ContextMenuStrip
            xxx.Show()



        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim p As Process
        For Each p In Process.GetProcesses
            Dim fed As String
            fed = p.ProcessName.ToString
            tvw.Nodes.Add(fed)
        Next
    End Sub

End Class
