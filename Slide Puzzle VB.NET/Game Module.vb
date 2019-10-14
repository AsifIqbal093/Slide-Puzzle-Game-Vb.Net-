Module Game_Module000000
    'this sub routine is for checking empty spot on button'
    Sub Checkbutton(ByRef butt1 As Button, ByRef butt2 As Button)
        If butt2.Text = "" Then
            butt2.Text = butt1.Text
            butt1.Text = ""

            Game_Slider.count = Game_Slider.count + 1
            Game_Slider.Label1.Text = Game_Slider.count
            'this will calculated number of moves'
        End If
    End Sub
    'Will show thw end contents when the puzzle is solved'
    'Will hide the puzzle content when puzzle is solved'
    Sub checkSolved()
        If Game_Slider.Button1.Text = "1" And Game_Slider.Button2.Text = "2" And
           Game_Slider.Button3.Text = "3" And Game_Slider.Button4.Text = "4" And
           Game_Slider.Button5.Text = "5" And Game_Slider.Button6.Text = "6" And
           Game_Slider.Button7.Text = "7" And Game_Slider.Button8.Text = "8" And
           Game_Slider.Button9.Text = "9" And Game_Slider.Button10.Text = "10" And
           Game_Slider.Button11.Text = "11" And Game_Slider.Button12.Text = "12" And
           Game_Slider.Button13.Text = "13" And Game_Slider.Button14.Text = "14" And
           Game_Slider.Button15.Text = "15" And Game_Slider.Button16.Text = "" Then

            Game_Slider.End_Screen.Show()
            Game_Slider.Scorelbl.Show()
            Game_Slider.Scoretxt.Show()
            Game_Slider.BScorelbl.Show()
            Game_Slider.Bscoretxt.Show()
            Game_Slider.Play_AgainBtn.Show()
            Game_Slider.Close_btn.Show()
            Game_Slider.Playtimer.Enabled = False
            Game_Slider.Button1.Hide()
            Game_Slider.Button2.Hide()
            Game_Slider.Button3.Hide()
            Game_Slider.Button4.Hide()
            Game_Slider.Button5.Hide()
            Game_Slider.Button6.Hide()
            Game_Slider.Button7.Hide()
            Game_Slider.Button8.Hide()
            Game_Slider.Button9.Hide()
            Game_Slider.Button10.Hide()
            Game_Slider.Button11.Hide()
            Game_Slider.Button12.Hide()
            Game_Slider.Button13.Hide()
            Game_Slider.Button14.Hide()
            Game_Slider.Button15.Hide()
            Game_Slider.Button16.Hide()
            Game_Slider.Label1.Hide()
            Game_Slider.Label2.Hide()
            Game_Slider.StartGameBtn.Hide()
            Game_Slider.TimerPuzzle.Hide()
            Game_Slider.GameSheet.Hide()
            'this portion Present Score and Best Score'
            Game_Slider.bestscore = 200
            Game_Slider.score = Game_Slider.Label1.Text
            Game_Slider.Scoretxt.Text = Game_Slider.score
            If Game_Slider.bestscore > Game_Slider.score Then
                Game_Slider.bestscore = Game_Slider.score
            Else
                Game_Slider.bestscore = Game_Slider.bestscore
            End If
            Game_Slider.Bscoretxt.Text = Game_Slider.bestscore
        End If
    End Sub
    'this function is for creating random numbers for each button on Game screen'
    Sub shuffle()
        Dim i(15), j, k, RN As Integer
        Dim flag As Boolean
        flag = False
        j = 1
        i(k) = 1
        Do While j <= 15
            Randomize()
            RN = CInt(Int((15 * Rnd()) + 1))

            For k = 1 To j
                If (i(k) = RN) Then
                    flag = True
                    Exit For
                End If
            Next
            If flag = True Then
                flag = False
            Else
                i(j) = RN
                j = j + 1
            End If

        Loop

        Game_Slider.Button1.Text = i(1)
        Game_Slider.Button2.Text = i(2)
        Game_Slider.Button3.Text = i(3)
        Game_Slider.Button4.Text = i(4)

        Game_Slider.Button5.Text = i(5)
        Game_Slider.Button6.Text = i(6)
        Game_Slider.Button7.Text = i(7)
        Game_Slider.Button8.Text = i(8)

        Game_Slider.Button9.Text = i(9)
        Game_Slider.Button10.Text = i(10)
        Game_Slider.Button11.Text = i(11)
        Game_Slider.Button12.Text = i(12)

        Game_Slider.Button13.Text = i(13)
        Game_Slider.Button14.Text = i(14)
        Game_Slider.Button15.Text = i(15)
        Game_Slider.Button16.Text = ""
    End Sub
End Module
