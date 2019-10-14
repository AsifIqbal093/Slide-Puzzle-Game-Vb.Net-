<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game_Slider
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game_Slider))
        Me.Scorelbl = New System.Windows.Forms.Label()
        Me.Scoretxt = New System.Windows.Forms.Label()
        Me.BScorelbl = New System.Windows.Forms.Label()
        Me.Bscoretxt = New System.Windows.Forms.Label()
        Me.GameSheet = New System.Windows.Forms.Panel()
        Me.LoadingLbl = New System.Windows.Forms.Label()
        Me.LoadBar = New System.Windows.Forms.ProgressBar()
        Me.PlayButton = New System.Windows.Forms.PictureBox()
        Me.SpleshScreen = New System.Windows.Forms.PictureBox()
        Me.StartGameBtn = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimerPuzzle = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LoadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Playtimer = New System.Windows.Forms.Timer(Me.components)
        Me.Close_btn = New System.Windows.Forms.PictureBox()
        Me.Play_AgainBtn = New System.Windows.Forms.PictureBox()
        Me.End_Screen = New System.Windows.Forms.PictureBox()
        Me.GameSheet.SuspendLayout()
        CType(Me.PlayButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpleshScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartGameBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Close_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Play_AgainBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.End_Screen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Scorelbl
        '
        Me.Scorelbl.AutoSize = True
        Me.Scorelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Scorelbl.Location = New System.Drawing.Point(180, 238)
        Me.Scorelbl.Name = "Scorelbl"
        Me.Scorelbl.Size = New System.Drawing.Size(71, 24)
        Me.Scorelbl.TabIndex = 3
        Me.Scorelbl.Text = "Score:"
        '
        'Scoretxt
        '
        Me.Scoretxt.AutoSize = True
        Me.Scoretxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Scoretxt.Location = New System.Drawing.Point(257, 238)
        Me.Scoretxt.Name = "Scoretxt"
        Me.Scoretxt.Size = New System.Drawing.Size(32, 24)
        Me.Scoretxt.TabIndex = 4
        Me.Scoretxt.Text = "00"
        '
        'BScorelbl
        '
        Me.BScorelbl.AutoSize = True
        Me.BScorelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BScorelbl.Location = New System.Drawing.Point(134, 279)
        Me.BScorelbl.Name = "BScorelbl"
        Me.BScorelbl.Size = New System.Drawing.Size(117, 24)
        Me.BScorelbl.TabIndex = 5
        Me.BScorelbl.Text = "Best Score:"
        '
        'Bscoretxt
        '
        Me.Bscoretxt.AutoSize = True
        Me.Bscoretxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bscoretxt.Location = New System.Drawing.Point(257, 279)
        Me.Bscoretxt.Name = "Bscoretxt"
        Me.Bscoretxt.Size = New System.Drawing.Size(32, 24)
        Me.Bscoretxt.TabIndex = 6
        Me.Bscoretxt.Text = "00"
        '
        'GameSheet
        '
        Me.GameSheet.BackColor = System.Drawing.Color.Teal
        Me.GameSheet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GameSheet.Controls.Add(Me.LoadingLbl)
        Me.GameSheet.Controls.Add(Me.LoadBar)
        Me.GameSheet.Controls.Add(Me.PlayButton)
        Me.GameSheet.Controls.Add(Me.SpleshScreen)
        Me.GameSheet.Controls.Add(Me.StartGameBtn)
        Me.GameSheet.Controls.Add(Me.Label1)
        Me.GameSheet.Controls.Add(Me.TimerPuzzle)
        Me.GameSheet.Controls.Add(Me.Button11)
        Me.GameSheet.Controls.Add(Me.Button6)
        Me.GameSheet.Controls.Add(Me.Button7)
        Me.GameSheet.Controls.Add(Me.Button8)
        Me.GameSheet.Controls.Add(Me.Button4)
        Me.GameSheet.Controls.Add(Me.Button3)
        Me.GameSheet.Controls.Add(Me.Button2)
        Me.GameSheet.Controls.Add(Me.Label2)
        Me.GameSheet.Controls.Add(Me.Button13)
        Me.GameSheet.Controls.Add(Me.Button14)
        Me.GameSheet.Controls.Add(Me.Button15)
        Me.GameSheet.Controls.Add(Me.Button16)
        Me.GameSheet.Controls.Add(Me.Button9)
        Me.GameSheet.Controls.Add(Me.Button10)
        Me.GameSheet.Controls.Add(Me.Button12)
        Me.GameSheet.Controls.Add(Me.Button5)
        Me.GameSheet.Controls.Add(Me.Button1)
        Me.GameSheet.Location = New System.Drawing.Point(12, 12)
        Me.GameSheet.Name = "GameSheet"
        Me.GameSheet.Size = New System.Drawing.Size(444, 457)
        Me.GameSheet.TabIndex = 7
        '
        'LoadingLbl
        '
        Me.LoadingLbl.AutoSize = True
        Me.LoadingLbl.BackColor = System.Drawing.Color.Transparent
        Me.LoadingLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadingLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadingLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LoadingLbl.Location = New System.Drawing.Point(184, 371)
        Me.LoadingLbl.Name = "LoadingLbl"
        Me.LoadingLbl.Size = New System.Drawing.Size(75, 15)
        Me.LoadingLbl.TabIndex = 43
        Me.LoadingLbl.Text = "Loading...."
        '
        'LoadBar
        '
        Me.LoadBar.ForeColor = System.Drawing.Color.Green
        Me.LoadBar.Location = New System.Drawing.Point(95, 389)
        Me.LoadBar.Name = "LoadBar"
        Me.LoadBar.Size = New System.Drawing.Size(241, 19)
        Me.LoadBar.TabIndex = 42
        '
        'PlayButton
        '
        Me.PlayButton.Image = CType(resources.GetObject("PlayButton.Image"), System.Drawing.Image)
        Me.PlayButton.Location = New System.Drawing.Point(172, 269)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(100, 38)
        Me.PlayButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PlayButton.TabIndex = 41
        Me.PlayButton.TabStop = False
        '
        'SpleshScreen
        '
        Me.SpleshScreen.BackColor = System.Drawing.Color.Transparent
        Me.SpleshScreen.Image = Global.Group_Project.My.Resources.Resources.puzle
        Me.SpleshScreen.Location = New System.Drawing.Point(-1, -1)
        Me.SpleshScreen.Name = "SpleshScreen"
        Me.SpleshScreen.Size = New System.Drawing.Size(445, 460)
        Me.SpleshScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SpleshScreen.TabIndex = 40
        Me.SpleshScreen.TabStop = False
        '
        'StartGameBtn
        '
        Me.StartGameBtn.Image = CType(resources.GetObject("StartGameBtn.Image"), System.Drawing.Image)
        Me.StartGameBtn.Location = New System.Drawing.Point(159, 386)
        Me.StartGameBtn.Name = "StartGameBtn"
        Me.StartGameBtn.Size = New System.Drawing.Size(100, 35)
        Me.StartGameBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StartGameBtn.TabIndex = 39
        Me.StartGameBtn.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(338, 337)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 21)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "00"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerPuzzle
        '
        Me.TimerPuzzle.AutoSize = True
        Me.TimerPuzzle.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TimerPuzzle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TimerPuzzle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TimerPuzzle.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerPuzzle.Location = New System.Drawing.Point(75, 337)
        Me.TimerPuzzle.Name = "TimerPuzzle"
        Me.TimerPuzzle.Size = New System.Drawing.Size(57, 21)
        Me.TimerPuzzle.TabIndex = 23
        Me.TimerPuzzle.Text = "00:00"
        Me.TimerPuzzle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button11.Enabled = False
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.Black
        Me.Button11.Location = New System.Drawing.Point(221, 196)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(69, 64)
        Me.Button11.TabIndex = 30
        Me.Button11.Text = "11"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button6.Enabled = False
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(144, 126)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(67, 64)
        Me.Button6.TabIndex = 27
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button7.Enabled = False
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Location = New System.Drawing.Point(223, 126)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(67, 64)
        Me.Button7.TabIndex = 26
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button8.Enabled = False
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Black
        Me.Button8.Location = New System.Drawing.Point(302, 126)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(67, 64)
        Me.Button8.TabIndex = 25
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button4.Enabled = False
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(302, 56)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(67, 64)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button3.Enabled = False
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(223, 56)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 64)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(144, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 64)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(257, 337)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 21)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Moves:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button13.Enabled = False
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.Black
        Me.Button13.Location = New System.Drawing.Point(65, 266)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(67, 64)
        Me.Button13.TabIndex = 36
        Me.Button13.Text = "13"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button14.Enabled = False
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.Black
        Me.Button14.Location = New System.Drawing.Point(142, 266)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(67, 64)
        Me.Button14.TabIndex = 35
        Me.Button14.Text = "14"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button15.Enabled = False
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.Color.Black
        Me.Button15.Location = New System.Drawing.Point(221, 266)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(70, 64)
        Me.Button15.TabIndex = 34
        Me.Button15.Text = "15"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button16.Enabled = False
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.ForeColor = System.Drawing.Color.Black
        Me.Button16.Location = New System.Drawing.Point(302, 266)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(67, 64)
        Me.Button16.TabIndex = 33
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button9.Enabled = False
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Black
        Me.Button9.Location = New System.Drawing.Point(65, 196)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(67, 64)
        Me.Button9.TabIndex = 32
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button10.Enabled = False
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.Black
        Me.Button10.Location = New System.Drawing.Point(144, 196)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(67, 64)
        Me.Button10.TabIndex = 31
        Me.Button10.Text = "10"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button12.Enabled = False
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.Black
        Me.Button12.Location = New System.Drawing.Point(302, 196)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(67, 64)
        Me.Button12.TabIndex = 29
        Me.Button12.Text = "12"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button5.Enabled = False
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(65, 126)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(67, 64)
        Me.Button5.TabIndex = 28
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(65, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 64)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LoadTimer
        '
        Me.LoadTimer.Enabled = True
        Me.LoadTimer.Interval = 50
        '
        'Playtimer
        '
        '
        'Close_btn
        '
        Me.Close_btn.BackColor = System.Drawing.Color.Teal
        Me.Close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Close_btn.Image = CType(resources.GetObject("Close_btn.Image"), System.Drawing.Image)
        Me.Close_btn.Location = New System.Drawing.Point(199, 387)
        Me.Close_btn.Name = "Close_btn"
        Me.Close_btn.Size = New System.Drawing.Size(66, 26)
        Me.Close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Close_btn.TabIndex = 2
        Me.Close_btn.TabStop = False
        '
        'Play_AgainBtn
        '
        Me.Play_AgainBtn.BackColor = System.Drawing.Color.Teal
        Me.Play_AgainBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Play_AgainBtn.Image = Global.Group_Project.My.Resources.Resources.BtnPlayagain
        Me.Play_AgainBtn.Location = New System.Drawing.Point(184, 335)
        Me.Play_AgainBtn.Name = "Play_AgainBtn"
        Me.Play_AgainBtn.Size = New System.Drawing.Size(100, 30)
        Me.Play_AgainBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Play_AgainBtn.TabIndex = 1
        Me.Play_AgainBtn.TabStop = False
        '
        'End_Screen
        '
        Me.End_Screen.Image = CType(resources.GetObject("End_Screen.Image"), System.Drawing.Image)
        Me.End_Screen.Location = New System.Drawing.Point(12, 12)
        Me.End_Screen.Name = "End_Screen"
        Me.End_Screen.Size = New System.Drawing.Size(444, 457)
        Me.End_Screen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.End_Screen.TabIndex = 0
        Me.End_Screen.TabStop = False
        '
        'Game_Slider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 477)
        Me.Controls.Add(Me.GameSheet)
        Me.Controls.Add(Me.Bscoretxt)
        Me.Controls.Add(Me.BScorelbl)
        Me.Controls.Add(Me.Scoretxt)
        Me.Controls.Add(Me.Scorelbl)
        Me.Controls.Add(Me.Close_btn)
        Me.Controls.Add(Me.Play_AgainBtn)
        Me.Controls.Add(Me.End_Screen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Game_Slider"
        Me.Text = "Form1"
        Me.GameSheet.ResumeLayout(False)
        Me.GameSheet.PerformLayout()
        CType(Me.PlayButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpleshScreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartGameBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Close_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Play_AgainBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.End_Screen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents End_Screen As PictureBox
    Friend WithEvents Play_AgainBtn As PictureBox
    Friend WithEvents Close_btn As PictureBox
    Friend WithEvents Scorelbl As Label
    Friend WithEvents Scoretxt As Label
    Friend WithEvents BScorelbl As Label
    Friend WithEvents Bscoretxt As Label
    Friend WithEvents GameSheet As Panel
    Friend WithEvents StartGameBtn As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TimerPuzzle As Label
    Friend WithEvents Button11 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents SpleshScreen As PictureBox
    Friend WithEvents PlayButton As PictureBox
    Friend WithEvents LoadingLbl As Label
    Friend WithEvents LoadBar As ProgressBar
    Friend WithEvents LoadTimer As Timer
    Friend WithEvents Playtimer As Timer
End Class
