Public Class Form1
    Dim Lettre
    Dim Nombre1
    Dim Score
    Dim Timetake

    Sub SetLettre()
        Randomize()
        Nombre1 = Int((42 * Rnd()) + 1)

        If Nombre1 = "1" Then Lettre = "a"
        If Nombre1 = "2" Then Lettre = "b"
        If Nombre1 = "3" Then Lettre = "c"
        If Nombre1 = "4" Then Lettre = "d"
        If Nombre1 = "5" Then Lettre = "e"
        If Nombre1 = "6" Then Lettre = "f"
        If Nombre1 = "7" Then Lettre = "g"
        If Nombre1 = "8" Then Lettre = "h"
        If Nombre1 = "9" Then Lettre = "i"
        If Nombre1 = "10" Then Lettre = "j"
        If Nombre1 = "11" Then Lettre = "k"
        If Nombre1 = "12" Then Lettre = "l"
        If Nombre1 = "13" Then Lettre = "m"
        If Nombre1 = "14" Then Lettre = "n"
        If Nombre1 = "15" Then Lettre = "o"
        If Nombre1 = "16" Then Lettre = "p"
        If Nombre1 = "17" Then Lettre = "q"
        If Nombre1 = "18" Then Lettre = "r"
        If Nombre1 = "19" Then Lettre = "s"
        If Nombre1 = "20" Then Lettre = "t"
        If Nombre1 = "21" Then Lettre = "u"
        If Nombre1 = "22" Then Lettre = "v"
        If Nombre1 = "23" Then Lettre = "w"
        If Nombre1 = "24" Then Lettre = "x"
        If Nombre1 = "25" Then Lettre = "y"
        If Nombre1 = "26" Then Lettre = "z"
        If Nombre1 = "27" Then Lettre = "+"
        If Nombre1 = "28" Then Lettre = "-"
        If Nombre1 = "29" Then Lettre = "="
        If Nombre1 = "30" Then Lettre = "1"
        If Nombre1 = "31" Then Lettre = "2"
        If Nombre1 = "32" Then Lettre = "3"
        If Nombre1 = "33" Then Lettre = "4"
        If Nombre1 = "34" Then Lettre = "5"
        If Nombre1 = "35" Then Lettre = "6"
        If Nombre1 = "36" Then Lettre = "7"
        If Nombre1 = "37" Then Lettre = "8"
        If Nombre1 = "38" Then Lettre = "9"
        If Nombre1 = "39" Then Lettre = "0"
        If Nombre1 = "40" Then Lettre = "é"
        If Nombre1 = "41" Then Lettre = "è"
        If Nombre1 = "42" Then Lettre = "@"
    End Sub






    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Button1.Hide()
        Label4.Hide()
        SetLettre()
        Timer1.Start()
        Timer2.Start()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = "Tapez " & Lettre
        Label2.Text = "Temps " & Timetake & "s"
        Label3.Text = "Score " & Score & "/60"
        If TextBox1.Text = Lettre Then
            SetLettre()
            Score = Score + 1
            TextBox1.Clear()
        End If
        If Score = 60 Then
            Timer1.Stop()
            Timer2.Stop()
            Label3.Text = "Score 60/60"
            Button1.Show()
            Label4.Show()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timetake = Timetake + 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timetake = 0
        Score = 0
        Button1.Hide()
        Label4.Hide()
        Timer1.Start()
        Timer2.Start()
    End Sub
End Class
