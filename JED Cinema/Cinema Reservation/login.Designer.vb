<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim BorderEdges4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.signUp = New System.Windows.Forms.Label()
        Me.exitLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.employeePanel = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.adminCheck = New System.Windows.Forms.CheckBox()
        Me.user = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.loginBtn = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.pass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.registerLink = New System.Windows.Forms.LinkLabel()
        Me.usernameTextbox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuButton1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.loginAvatar = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuShadowPanel1 = New Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel()
        Me.logoPic = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.employeePanel.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.loginAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuShadowPanel1.SuspendLayout()
        CType(Me.logoPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumPurple
        Me.Panel1.Controls.Add(Me.signUp)
        Me.Panel1.Controls.Add(Me.exitLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(732, 227)
        Me.Panel1.TabIndex = 0
        '
        'signUp
        '
        Me.signUp.AutoSize = True
        Me.signUp.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signUp.ForeColor = System.Drawing.Color.White
        Me.signUp.Location = New System.Drawing.Point(221, 39)
        Me.signUp.Name = "signUp"
        Me.signUp.Size = New System.Drawing.Size(59, 25)
        Me.signUp.TabIndex = 1
        Me.signUp.Text = "Login"
        '
        'exitLabel
        '
        Me.exitLabel.AutoSize = True
        Me.exitLabel.BackColor = System.Drawing.Color.Silver
        Me.exitLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.exitLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.exitLabel.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitLabel.ForeColor = System.Drawing.Color.White
        Me.exitLabel.Location = New System.Drawing.Point(21, 18)
        Me.exitLabel.Name = "exitLabel"
        Me.exitLabel.Size = New System.Drawing.Size(26, 27)
        Me.exitLabel.TabIndex = 0
        Me.exitLabel.Text = "X"
        Me.exitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.employeePanel)
        Me.Panel2.Controls.Add(Me.user)
        Me.Panel2.Controls.Add(Me.loginBtn)
        Me.Panel2.Controls.Add(Me.pass)
        Me.Panel2.ForeColor = System.Drawing.Color.Aqua
        Me.Panel2.Location = New System.Drawing.Point(70, 129)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(362, 315)
        Me.Panel2.TabIndex = 1
        '
        'employeePanel
        '
        Me.employeePanel.BackColor = System.Drawing.Color.White
        Me.employeePanel.BackgroundImage = CType(resources.GetObject("employeePanel.BackgroundImage"), System.Drawing.Image)
        Me.employeePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.employeePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.employeePanel.Controls.Add(Me.adminCheck)
        Me.employeePanel.ForeColor = System.Drawing.Color.White
        Me.employeePanel.GradientBottomLeft = System.Drawing.Color.PowderBlue
        Me.employeePanel.GradientBottomRight = System.Drawing.Color.MediumSlateBlue
        Me.employeePanel.GradientTopLeft = System.Drawing.Color.MediumSlateBlue
        Me.employeePanel.GradientTopRight = System.Drawing.Color.DarkSlateGray
        Me.employeePanel.Location = New System.Drawing.Point(129, 269)
        Me.employeePanel.Name = "employeePanel"
        Me.employeePanel.Quality = 10
        Me.employeePanel.Size = New System.Drawing.Size(116, 27)
        Me.employeePanel.TabIndex = 6
        '
        'adminCheck
        '
        Me.adminCheck.AutoSize = True
        Me.adminCheck.BackColor = System.Drawing.Color.Transparent
        Me.adminCheck.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminCheck.ForeColor = System.Drawing.Color.White
        Me.adminCheck.Location = New System.Drawing.Point(13, 3)
        Me.adminCheck.Name = "adminCheck"
        Me.adminCheck.Size = New System.Drawing.Size(98, 17)
        Me.adminCheck.TabIndex = 6
        Me.adminCheck.Text = "JED Employee"
        Me.adminCheck.UseVisualStyleBackColor = False
        '
        'user
        '
        Me.user.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.user.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.user.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.user.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.user.HintForeColor = System.Drawing.Color.Empty
        Me.user.HintText = "Username"
        Me.user.isPassword = False
        Me.user.LineFocusedColor = System.Drawing.Color.DarkTurquoise
        Me.user.LineIdleColor = System.Drawing.Color.DarkSlateGray
        Me.user.LineMouseHoverColor = System.Drawing.Color.LightCyan
        Me.user.LineThickness = 4
        Me.user.Location = New System.Drawing.Point(73, 78)
        Me.user.Margin = New System.Windows.Forms.Padding(4)
        Me.user.MaxLength = 17
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(221, 28)
        Me.user.TabIndex = 3
        Me.user.TabStop = False
        Me.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'loginBtn
        '
        Me.loginBtn.AllowToggling = False
        Me.loginBtn.AnimationSpeed = 200
        Me.loginBtn.AutoGenerateColors = False
        Me.loginBtn.BackColor = System.Drawing.Color.Transparent
        Me.loginBtn.BackColor1 = System.Drawing.Color.MediumPurple
        Me.loginBtn.BackgroundImage = CType(resources.GetObject("loginBtn.BackgroundImage"), System.Drawing.Image)
        Me.loginBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.loginBtn.ButtonText = "Login"
        Me.loginBtn.ButtonTextMarginLeft = 0
        Me.loginBtn.ColorContrastOnClick = 45
        Me.loginBtn.ColorContrastOnHover = 45
        Me.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = True
        BorderEdges3.TopLeft = True
        BorderEdges3.TopRight = True
        Me.loginBtn.CustomizableEdges = BorderEdges3
        Me.loginBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.loginBtn.DisabledBorderColor = System.Drawing.Color.Empty
        Me.loginBtn.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.loginBtn.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.loginBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.loginBtn.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.Color.White
        Me.loginBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.loginBtn.IconMarginLeft = 11
        Me.loginBtn.IconPadding = 10
        Me.loginBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.loginBtn.IdleBorderColor = System.Drawing.Color.MediumOrchid
        Me.loginBtn.IdleBorderRadius = 5
        Me.loginBtn.IdleBorderThickness = 1
        Me.loginBtn.IdleFillColor = System.Drawing.Color.MediumPurple
        Me.loginBtn.IdleIconLeftImage = Nothing
        Me.loginBtn.IdleIconRightImage = Nothing
        Me.loginBtn.IndicateFocus = False
        Me.loginBtn.Location = New System.Drawing.Point(73, 206)
        Me.loginBtn.Name = "loginBtn"
        StateProperties5.BorderColor = System.Drawing.Color.DarkMagenta
        StateProperties5.BorderRadius = 5
        StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties5.BorderThickness = 1
        StateProperties5.FillColor = System.Drawing.Color.MediumSlateBlue
        StateProperties5.ForeColor = System.Drawing.Color.White
        StateProperties5.IconLeftImage = Nothing
        StateProperties5.IconRightImage = Nothing
        Me.loginBtn.onHoverState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties6.BorderRadius = 5
        StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties6.BorderThickness = 1
        StateProperties6.FillColor = System.Drawing.Color.Magenta
        StateProperties6.ForeColor = System.Drawing.Color.White
        StateProperties6.IconLeftImage = Nothing
        StateProperties6.IconRightImage = Nothing
        Me.loginBtn.OnPressedState = StateProperties6
        Me.loginBtn.Size = New System.Drawing.Size(221, 41)
        Me.loginBtn.TabIndex = 2
        Me.loginBtn.TabStop = False
        Me.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.loginBtn.TextMarginLeft = 0
        Me.loginBtn.UseDefaultRadiusAndThickness = True
        '
        'pass
        '
        Me.pass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.pass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.pass.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pass.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pass.HintForeColor = System.Drawing.Color.Empty
        Me.pass.HintText = "Password"
        Me.pass.isPassword = True
        Me.pass.LineFocusedColor = System.Drawing.Color.DarkTurquoise
        Me.pass.LineIdleColor = System.Drawing.Color.DarkSlateGray
        Me.pass.LineMouseHoverColor = System.Drawing.Color.LightCyan
        Me.pass.LineThickness = 4
        Me.pass.Location = New System.Drawing.Point(73, 142)
        Me.pass.Margin = New System.Windows.Forms.Padding(4)
        Me.pass.MaxLength = 17
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(221, 28)
        Me.pass.TabIndex = 1
        Me.pass.TabStop = False
        Me.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'registerLink
        '
        Me.registerLink.ActiveLinkColor = System.Drawing.Color.DarkTurquoise
        Me.registerLink.AutoSize = True
        Me.registerLink.BackColor = System.Drawing.Color.Transparent
        Me.registerLink.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerLink.LinkColor = System.Drawing.Color.DarkMagenta
        Me.registerLink.Location = New System.Drawing.Point(65, 34)
        Me.registerLink.Name = "registerLink"
        Me.registerLink.Size = New System.Drawing.Size(71, 21)
        Me.registerLink.TabIndex = 4
        Me.registerLink.TabStop = True
        Me.registerLink.Text = "Register"
        Me.registerLink.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'usernameTextbox
        '
        Me.usernameTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.usernameTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.usernameTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.usernameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernameTextbox.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameTextbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.usernameTextbox.HintForeColor = System.Drawing.Color.Empty
        Me.usernameTextbox.HintText = ""
        Me.usernameTextbox.isPassword = False
        Me.usernameTextbox.LineFocusedColor = System.Drawing.Color.DarkTurquoise
        Me.usernameTextbox.LineIdleColor = System.Drawing.Color.DarkCyan
        Me.usernameTextbox.LineMouseHoverColor = System.Drawing.Color.DarkSlateGray
        Me.usernameTextbox.LineThickness = 4
        Me.usernameTextbox.Location = New System.Drawing.Point(63, 82)
        Me.usernameTextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.usernameTextbox.MaxLength = 17
        Me.usernameTextbox.Name = "usernameTextbox"
        Me.usernameTextbox.Size = New System.Drawing.Size(221, 28)
        Me.usernameTextbox.TabIndex = 0
        Me.usernameTextbox.Text = "Username"
        Me.usernameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuMaterialTextbox2
        '
        Me.BunifuMaterialTextbox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.BunifuMaterialTextbox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.BunifuMaterialTextbox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox2.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox2.HintText = ""
        Me.BunifuMaterialTextbox2.isPassword = True
        Me.BunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.DarkTurquoise
        Me.BunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.DarkCyan
        Me.BunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.DarkSlateGray
        Me.BunifuMaterialTextbox2.LineThickness = 4
        Me.BunifuMaterialTextbox2.Location = New System.Drawing.Point(63, 152)
        Me.BunifuMaterialTextbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox2.MaxLength = 17
        Me.BunifuMaterialTextbox2.Name = "BunifuMaterialTextbox2"
        Me.BunifuMaterialTextbox2.Size = New System.Drawing.Size(221, 28)
        Me.BunifuMaterialTextbox2.TabIndex = 1
        Me.BunifuMaterialTextbox2.Text = "Password"
        Me.BunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuButton1
        '
        Me.BunifuButton1.AllowToggling = False
        Me.BunifuButton1.AnimationSpeed = 200
        Me.BunifuButton1.AutoGenerateColors = False
        Me.BunifuButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.BackColor1 = System.Drawing.Color.DarkCyan
        Me.BunifuButton1.BackgroundImage = CType(resources.GetObject("BunifuButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.ButtonText = "Login"
        Me.BunifuButton1.ButtonTextMarginLeft = 0
        Me.BunifuButton1.ColorContrastOnClick = 45
        Me.BunifuButton1.ColorContrastOnHover = 45
        Me.BunifuButton1.Cursor = System.Windows.Forms.Cursors.Arrow
        BorderEdges4.BottomLeft = True
        BorderEdges4.BottomRight = True
        BorderEdges4.TopLeft = True
        BorderEdges4.TopRight = True
        Me.BunifuButton1.CustomizableEdges = BorderEdges4
        Me.BunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton1.DisabledBorderColor = System.Drawing.Color.Empty
        Me.BunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton1.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuButton1.IconMarginLeft = 11
        Me.BunifuButton1.IconPadding = 10
        Me.BunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuButton1.IdleBorderColor = System.Drawing.Color.DarkTurquoise
        Me.BunifuButton1.IdleBorderRadius = 5
        Me.BunifuButton1.IdleBorderThickness = 1
        Me.BunifuButton1.IdleFillColor = System.Drawing.Color.DarkCyan
        Me.BunifuButton1.IdleIconLeftImage = Nothing
        Me.BunifuButton1.IdleIconRightImage = Nothing
        Me.BunifuButton1.IndicateFocus = False
        Me.BunifuButton1.Location = New System.Drawing.Point(73, 206)
        Me.BunifuButton1.Name = "BunifuButton1"
        StateProperties7.BorderColor = System.Drawing.Color.DarkCyan
        StateProperties7.BorderRadius = 5
        StateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties7.BorderThickness = 1
        StateProperties7.FillColor = System.Drawing.Color.DarkTurquoise
        StateProperties7.ForeColor = System.Drawing.Color.White
        StateProperties7.IconLeftImage = Nothing
        StateProperties7.IconRightImage = Nothing
        Me.BunifuButton1.onHoverState = StateProperties7
        StateProperties8.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties8.BorderRadius = 5
        StateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties8.BorderThickness = 1
        StateProperties8.FillColor = System.Drawing.Color.LightSteelBlue
        StateProperties8.ForeColor = System.Drawing.Color.White
        StateProperties8.IconLeftImage = Nothing
        StateProperties8.IconRightImage = Nothing
        Me.BunifuButton1.OnPressedState = StateProperties8
        Me.BunifuButton1.Size = New System.Drawing.Size(221, 41)
        Me.BunifuButton1.TabIndex = 2
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton1.TextMarginLeft = 0
        Me.BunifuButton1.UseDefaultRadiusAndThickness = True
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'loginAvatar
        '
        Me.loginAvatar.AllowFocused = False
        Me.loginAvatar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.loginAvatar.BackColor = System.Drawing.Color.MediumPurple
        Me.loginAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.loginAvatar.BorderRadius = 0
        Me.loginAvatar.Image = CType(resources.GetObject("loginAvatar.Image"), System.Drawing.Image)
        Me.loginAvatar.InitialImage = CType(resources.GetObject("loginAvatar.InitialImage"), System.Drawing.Image)
        Me.loginAvatar.IsCircle = False
        Me.loginAvatar.Location = New System.Drawing.Point(171, 64)
        Me.loginAvatar.Name = "loginAvatar"
        Me.loginAvatar.Size = New System.Drawing.Size(146, 102)
        Me.loginAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.loginAvatar.TabIndex = 2
        Me.loginAvatar.TabStop = False
        Me.loginAvatar.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Don't have an account?"
        '
        'BunifuShadowPanel1
        '
        Me.BunifuShadowPanel1.BackColor = System.Drawing.Color.LightGray
        Me.BunifuShadowPanel1.BorderColor = System.Drawing.Color.MistyRose
        Me.BunifuShadowPanel1.Controls.Add(Me.Label1)
        Me.BunifuShadowPanel1.Controls.Add(Me.registerLink)
        Me.BunifuShadowPanel1.Location = New System.Drawing.Point(480, 371)
        Me.BunifuShadowPanel1.Name = "BunifuShadowPanel1"
        Me.BunifuShadowPanel1.PanelColor = System.Drawing.Color.Lavender
        Me.BunifuShadowPanel1.ShadowDept = 2
        Me.BunifuShadowPanel1.ShadowTopLeftVisible = False
        Me.BunifuShadowPanel1.Size = New System.Drawing.Size(220, 73)
        Me.BunifuShadowPanel1.TabIndex = 6
        '
        'logoPic
        '
        Me.logoPic.AllowFocused = False
        Me.logoPic.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.logoPic.BackColor = System.Drawing.Color.MediumPurple
        Me.logoPic.BorderRadius = 4
        Me.logoPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.logoPic.Image = CType(resources.GetObject("logoPic.Image"), System.Drawing.Image)
        Me.logoPic.IsCircle = False
        Me.logoPic.Location = New System.Drawing.Point(471, 129)
        Me.logoPic.Name = "logoPic"
        Me.logoPic.Size = New System.Drawing.Size(229, 172)
        Me.logoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logoPic.TabIndex = 2
        Me.logoPic.TabStop = False
        Me.logoPic.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(732, 485)
        Me.Controls.Add(Me.logoPic)
        Me.Controls.Add(Me.BunifuShadowPanel1)
        Me.Controls.Add(Me.loginAvatar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.Text = "JED Employee"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.employeePanel.ResumeLayout(False)
        Me.employeePanel.PerformLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.loginAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuShadowPanel1.ResumeLayout(False)
        Me.BunifuShadowPanel1.PerformLayout()
        CType(Me.logoPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents signUp As Label
    Friend WithEvents exitLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents loginBtn As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents usernameTextbox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents user As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents registerLink As LinkLabel
    Friend WithEvents BunifuMaterialTextbox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents employeePanel As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents adminCheck As CheckBox
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents loginAvatar As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuShadowPanel1 As Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel
    Friend WithEvents logoPic As Bunifu.UI.WinForms.BunifuPictureBox
End Class
