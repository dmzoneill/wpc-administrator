Public Class Form1
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents MenuExit As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.IconMenu = New System.Windows.Forms.ContextMenu
        Me.MenuOpen = New System.Windows.Forms.MenuItem
        Me.MenuExit = New System.Windows.Forms.MenuItem
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
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Name = "Form1"
        Me.Text = "Form1"

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
End Class
