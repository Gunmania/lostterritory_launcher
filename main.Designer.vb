<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class main
#Region "Windows Form 디자이너에서 생성한 코드 "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        '이 호출은 Windows Form 디자이너에 필요합니다.
        InitializeComponent()
    End Sub
    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents MapImage1 As System.Windows.Forms.PictureBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents GameLogo As System.Windows.Forms.PictureBox
    Public WithEvents Image1 As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    'Windows Form 디자이너를 사용하여 수정할 수 있습니다.
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MapImage2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MapImage1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GameLogo = New System.Windows.Forms.PictureBox()
        Me.Image1 = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Frame1.SuspendLayout()
        CType(Me.MapImage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MapImage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(346, 257)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(65, 25)
        Me.Command1.TabIndex = 0
        Me.Command1.Text = "종료"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.White
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.MapImage2)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.MapImage1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 56)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(403, 188)
        Me.Frame1.TabIndex = 3
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Map List"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(200, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(191, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Bunker / Team Death Match"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MapImage2
        '
        Me.MapImage2.Image = CType(resources.GetObject("MapImage2.Image"), System.Drawing.Image)
        Me.MapImage2.Location = New System.Drawing.Point(218, 26)
        Me.MapImage2.Name = "MapImage2"
        Me.MapImage2.Size = New System.Drawing.Size(160, 120)
        Me.MapImage2.TabIndex = 6
        Me.MapImage2.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(23, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(161, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Town / Death Match"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MapImage1
        '
        Me.MapImage1.Cursor = System.Windows.Forms.Cursors.Default
        Me.MapImage1.Image = CType(resources.GetObject("MapImage1.Image"), System.Drawing.Image)
        Me.MapImage1.Location = New System.Drawing.Point(26, 26)
        Me.MapImage1.Name = "MapImage1"
        Me.MapImage1.Size = New System.Drawing.Size(160, 120)
        Me.MapImage1.TabIndex = 5
        Me.MapImage1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(231, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(135, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Game Launcher"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(198, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ver. Alpha 4 - Fix2 (2013. 9. 27)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GameLogo
        '
        Me.GameLogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.GameLogo.Image = CType(resources.GetObject("GameLogo.Image"), System.Drawing.Image)
        Me.Image1.SetIndex(Me.GameLogo, CType(0, Short))
        Me.GameLogo.Location = New System.Drawing.Point(55, 16)
        Me.GameLogo.Name = "GameLogo"
        Me.GameLogo.Size = New System.Drawing.Size(117, 27)
        Me.GameLogo.TabIndex = 4
        Me.GameLogo.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(103, 247)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(159, 12)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "http://witteam.gunmania.kr"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 12)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "by W.I.T TEAM"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.Location = New System.Drawing.Point(275, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 25)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "설정"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(420, 292)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GameLogo)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "main"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RightToLeftLayout = True
        Me.Text = "Immortality : Lost Territory"
        Me.Frame1.ResumeLayout(False)
        CType(Me.MapImage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MapImage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MapImage2 As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
#End Region
End Class