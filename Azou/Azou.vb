Public Class Azou
    Dim Lettre
    Dim Nombre1
    Dim Score
    Dim Timetake
    Dim NewPoint As New System.Drawing.Point
    Dim X, Y As Integer

    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.Y -= (Y)
            NewPoint.X -= (X)
            Me.Location = NewPoint
        End If
    End Sub

    Sub SetLettre()
        Randomize()
        Nombre1 = Int((78 * Rnd()) + 1)

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
        If Nombre1 = "43" Then Lettre = "a"
        If Nombre1 = "44" Then Lettre = "b"
        If Nombre1 = "45" Then Lettre = "c"
        If Nombre1 = "46" Then Lettre = "d"
        If Nombre1 = "47" Then Lettre = "e"
        If Nombre1 = "48" Then Lettre = "f"
        If Nombre1 = "49" Then Lettre = "g"
        If Nombre1 = "50" Then Lettre = "h"
        If Nombre1 = "51" Then Lettre = "i"
        If Nombre1 = "52" Then Lettre = "j"
        If Nombre1 = "53" Then Lettre = "k"
        If Nombre1 = "54" Then Lettre = "l"
        If Nombre1 = "55" Then Lettre = "m"
        If Nombre1 = "56" Then Lettre = "n"
        If Nombre1 = "57" Then Lettre = "o"
        If Nombre1 = "58" Then Lettre = "p"
        If Nombre1 = "59" Then Lettre = "q"
        If Nombre1 = "60" Then Lettre = "r"
        If Nombre1 = "61" Then Lettre = "s"
        If Nombre1 = "62" Then Lettre = "t"
        If Nombre1 = "63" Then Lettre = "u"
        If Nombre1 = "64" Then Lettre = "v"
        If Nombre1 = "65" Then Lettre = "w"
        If Nombre1 = "66" Then Lettre = "x"
        If Nombre1 = "67" Then Lettre = "y"
        If Nombre1 = "68" Then Lettre = "z"
        If Nombre1 = "69" Then Lettre = "1"
        If Nombre1 = "70" Then Lettre = "2"
        If Nombre1 = "71" Then Lettre = "3"
        If Nombre1 = "72" Then Lettre = "0"
        If Nombre1 = "73" Then Lettre = "4"
        If Nombre1 = "74" Then Lettre = "5"
        If Nombre1 = "75" Then Lettre = "6"
        If Nombre1 = "76" Then Lettre = "7"
        If Nombre1 = "77" Then Lettre = "8"
        If Nombre1 = "78" Then Lettre = "9"
    End Sub






    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label4.Hide()
        SetLettre()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = "Tapez   " & Lettre
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
            Label4.Show()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timetake = Timetake + 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text = "Recommencer"
        Timetake = 0
        Score = 0
        Label4.Hide()
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class
