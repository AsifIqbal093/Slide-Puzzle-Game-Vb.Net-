Imports System.ComponentModel

Public Class Game_Slider
    Public count As Integer
    Public score, bestscore As Integer
    Public sec As Decimal
    Public min As Integer
    'This is the startting of the Game'
    Private Sub Game_Slider_Load(sender As Object, e As EventArgs) Handles Me.Load
        PlayButton.Enabled = False
        Button1.Hide()
        Button2.Hide()
        Button3.Hide()
        Button4.Hide()
        Button5.Hide()
        Button6.Hide()
        Button7.Hide()
        Button8.Hide()
        Button9.Hide()
        Button10.Hide()
        Button11.Hide()
        Button12.Hide()
        Button13.Hide()
        Button14.Hide()
        Button15.Hide()
        Button16.Hide()
        End_Screen.Hide()
        Scorelbl.Hide()
        Scoretxt.Hide()
        BScorelbl.Hide()
        Bscoretxt.Hide()


    End Sub
    'this function will load the Game'
    Private Sub LoadTimer_Tick(sender As Object, e As EventArgs) Handles LoadTimer.Tick
        LoadBar.Increment(1)
        If LoadBar.Value = 100 Then
            LoadBar.Hide()
            LoadingLbl.Hide()
            PlayButton.Enabled = True
        End If
    End Sub
    'this will lead the user towards actual game screen'
    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        shuffle()
        My.Computer.Audio.Play(My.Resources.gametune__online_audio_converter_com_, AudioPlayMode.BackgroundLoop)
        SpleshScreen.Hide()
        PlayButton.Hide()
        Button1.Show()
        Button2.Show()
        Button3.Show()
        Button4.Show()
        Button5.Show()
        Button6.Show()
        Button7.Show()
        Button8.Show()
        Button9.Show()
        Button10.Show()
        Button11.Show()
        Button12.Show()
        Button13.Show()
        Button14.Show()
        Button15.Show()
        Button16.Show()
    End Sub
    'this button is for starting play'
    Private Sub StartGameBtn_Click(sender As Object, e As EventArgs) Handles StartGameBtn.Click
        'Enabling each of the button to swap values between each other'
        Playtimer.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button10.Enabled = True
        Button11.Enabled = True
        Button12.Enabled = True
        Button13.Enabled = True
        Button14.Enabled = True
        Button15.Enabled = True
        Button16.Enabled = True
    End Sub
    'the fuction will start counting the time'
    Private Sub Playtimer_Tick(sender As Object, e As EventArgs) Handles Playtimer.Tick
        'This Event will gerenerate the duration of the game'
        Dim str As String
        sec += 0.1
        If sec >= 60.0 Then
            sec = 0
            min += 1
        End If
        If min <= 10 Then
            str = "0" + CStr(min)
        Else
            str = CStr(min)
        End If
        str = str + ":"
        If sec <= 9 Then
            str = str + "0" + CStr(sec)
        Else
            str = str + CStr(sec)
        End If
        TimerPuzzle.Text = "Duration:" + str
    End Sub
    'Game button squencing and checking Started here'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Button1 Checking for empty spot on button 2 and Button 5
        Checkbutton(Button1, Button2)
        Checkbutton(Button1, Button5)

        checkSolved()
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        'Button2 Checking for empty spot on button 1,Button3 and Button 6
        Checkbutton(Button2, Button1)
        Checkbutton(Button2, Button3)
        Checkbutton(Button2, Button6)
        checkSolved()
    End Sub
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        'Button3 Checking for empty spot on button 2,Button4 and Button 7
        Checkbutton(Button3, Button2)
        Checkbutton(Button3, Button4)
        Checkbutton(Button3, Button7)
        checkSolved()
    End Sub
    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        'Button4 Checking for empty spot on button 3 and Button 8
        Checkbutton(Button4, Button3)
        Checkbutton(Button4, Button8)
        checkSolved()
    End Sub
    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        'Button5 Checking for empty spot on button 1,Button6 and Button9
        Checkbutton(Button5, Button1)
        Checkbutton(Button5, Button6)
        Checkbutton(Button5, Button9)
        checkSolved()
    End Sub
    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        'Button6 Checking for empty spot on button 2,Button5,Button7 and Button10'
        Checkbutton(Button6, Button2)
        Checkbutton(Button6, Button5)
        Checkbutton(Button6, Button7)
        Checkbutton(Button6, Button10)
        checkSolved()
    End Sub
    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        'Button7 Checking for empty spot on button3,Button6,Button8 and Button11'
        Checkbutton(Button7, Button3)
        Checkbutton(Button7, Button6)
        Checkbutton(Button7, Button8)
        Checkbutton(Button7, Button11)
        checkSolved()
    End Sub
    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        'Button8 Checking for empty spot on button4,Button7 and Button12'
        Checkbutton(Button8, Button4)
        Checkbutton(Button8, Button7)
        Checkbutton(Button8, Button12)
        checkSolved()
    End Sub
    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        'Button9 Checking for empty spot on button5,Button10 and Button13'
        Checkbutton(Button9, Button5)
        Checkbutton(Button9, Button10)
        Checkbutton(Button9, Button13)
        checkSolved()
    End Sub
    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        'Button10 Checking for empty spot on button6,Button9,Button11 and Button14'
        Checkbutton(Button10, Button6)
        Checkbutton(Button10, Button9)
        Checkbutton(Button10, Button11)
        Checkbutton(Button10, Button14)
        checkSolved()
    End Sub
    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click
        'Button11 Checking for empty spot on button7,Button10,Button12 and Button15'
        Checkbutton(Button11, Button7)
        Checkbutton(Button11, Button10)
        Checkbutton(Button11, Button12)
        Checkbutton(Button11, Button15)
        checkSolved()
    End Sub
    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        'Button12 Checking for empty spot on button8,Button11 and Button16'
        Checkbutton(Button12, Button8)
        Checkbutton(Button12, Button11)
        Checkbutton(Button12, Button16)
        checkSolved()
    End Sub
    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click
        'Button13 Checking for empty spot on button9 and Button14'
        Checkbutton(Button13, Button9)
        Checkbutton(Button13, Button14)
        checkSolved()
    End Sub
    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Button14.Click
        'Button14 Checking for empty spot on button10,Button13 and Button15'
        Checkbutton(Button14, Button10)
        Checkbutton(Button14, Button13)
        Checkbutton(Button14, Button15)
        checkSolved()
    End Sub
    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click
        'Button15 Checking for empty spot on button11,Button14 and Button16
        Checkbutton(Button15, Button11)
        Checkbutton(Button15, Button14)
        Checkbutton(Button15, Button16)
        checkSolved()
    End Sub
    Private Sub Button16_Click_1(sender As Object, e As EventArgs) Handles Button16.Click
        'Button16 Checking for empty spot on button12 and Button15
        Checkbutton(Button16, Button12)
        Checkbutton(Button16, Button15)
        checkSolved()
    End Sub
    'Game button squencing and checking closes here'
    'Play Again '
    Private Sub Play_AgainBtn_Click(sender As Object, e As EventArgs) Handles Play_AgainBtn.Click
        End_Screen.Hide()
        Scorelbl.Hide()
        Scoretxt.Hide()
        BScorelbl.Hide()
        Bscoretxt.Hide()
        Play_AgainBtn.Hide()
        Close_btn.Hide()
        shuffle()
        My.Computer.Audio.Play(My.Resources.gametune__online_audio_converter_com_, AudioPlayMode.BackgroundLoop)
        TimerPuzzle.Text = "00:00"
        Playtimer.Enabled = True
        GameSheet.Show()
        Button1.Show()
        Button2.Show()
        Button3.Show()
        Button4.Show()
        Button5.Show()
        Button6.Show()
        Button7.Show()
        Button8.Show()
        Button9.Show()
        Button10.Show()
        Button11.Show()
        Button12.Show()
        Button13.Show()
        Button14.Show()
        Button15.Show()
        Button16.Show()
        Label1.Show()
        Label2.Show()
        TimerPuzzle.Show()
        StartGameBtn.Show()
    End Sub
    'This portion is about Animation for button'
    'Animation for Play Button'
    Private Sub PlayButton_MouseMove(sender As Object, e As MouseEventArgs) Handles PlayButton.MouseMove
        PlayButton.Image = My.Resources.button_Play1
    End Sub
    Private Sub PlayButton_MouseLeave(sender As Object, e As EventArgs) Handles PlayButton.MouseLeave
        PlayButton.Image = My.Resources.button_Play
    End Sub
    'Animation for StartGame button'
    Private Sub StartGameBtn_MouseMove(sender As Object, e As MouseEventArgs) Handles StartGameBtn.MouseMove
        StartGameBtn.Image = My.Resources.Start_Game_Btn1
    End Sub
    Private Sub StartGameBtn_MouseLeave(sender As Object, e As EventArgs) Handles StartGameBtn.MouseLeave
        StartGameBtn.Image = My.Resources.Start_Game_Btn
    End Sub
    'Animation for Play Again button'
    Private Sub Play_AgainBtn_MouseMove(sender As Object, e As MouseEventArgs) Handles Play_AgainBtn.MouseMove
        Play_AgainBtn.Image = My.Resources.BtnPlayagain1
    End Sub
    Private Sub Play_AgainBtn_MouseLeave(sender As Object, e As EventArgs) Handles Play_AgainBtn.MouseLeave
        Play_AgainBtn.Image = My.Resources.BtnPlayagain
    End Sub
    'Animation for Close button'
    Private Sub Close_btn_MouseMove(sender As Object, e As MouseEventArgs) Handles Close_btn.MouseMove
        Close_btn.Image = My.Resources.End_Game1
    End Sub
    Private Sub Close_btn_MouseLeave(sender As Object, e As EventArgs) Handles Close_btn.MouseLeave
        Close_btn.Image = My.Resources.End_Game
    End Sub
    'Animation for button end here'
    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Application.Exit()
    End Sub
    'Dialogue for closing Application'
    Private Sub Game_Slider_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim x = MsgBox("Are you sure to close the Puzzle???", vbYesNo + vbQuestion)
        If (x = System.Windows.Forms.DialogResult.No) Then
            e.Cancel = True
        End If
    End Sub
End Class
