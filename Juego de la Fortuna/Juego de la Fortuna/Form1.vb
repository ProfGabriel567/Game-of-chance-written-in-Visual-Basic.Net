Public Class frmFortuna

    Public score As Integer = 100
    Private Sub btnGameOver_Click(sender As Object, e As EventArgs) Handles btnGameOver.Click
        End
    End Sub

    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click

        Label5.Visible = False
        PictureBox1.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        Label1.Text = CStr(Int(Rnd() * 10))
        Label2.Text = CStr(Int(Rnd() * 10))
        Label3.Text = CStr(Int(Rnd() * 10))

        If (Label1.Text = "7") Or (Label2.Text = "7") Or (Label3.Text = "7") Then
            Label5.Visible = True
            PictureBox1.Visible = True
            Beep()

        End If


        If lblScore.Text <= "0" Then
            btnJugar.Visible = False

            lblScore.Visible = False
            Label5.Text = "GAME OVER"
            PictureBox1.Visible = False
            PictureBox4.Visible = False
            PictureBox3.Visible = True
            Beep()
            'System.Threading.Thread.Sleep(3000)
            'End
        End If



        If Label1.Text = "7" And Label2.Text = "7" And Label3.Text = "7" Then
            lblScore.Text = lblScore.Text + 100
        ElseIf Label1.Text = "7" And Label2.Text = "7" And Label3.Text <> "7" Then
            lblScore.Text = lblScore.Text + 40
        ElseIf Label1.Text = "7" And Label2.Text <> "7" And Label3.Text = "7" Then
            lblScore.Text = lblScore.Text + 40
        ElseIf Label1.Text <> "7" And Label2.Text = "7" And Label3.Text = "7" Then
            lblScore.Text = lblScore.Text + 40
        ElseIf Label1.Text <> "7" And Label2.Text <> "7" And Label3.Text = "7" Then
            lblScore.Text = lblScore.Text + 20
        ElseIf Label1.Text <> "7" And Label2.Text = "7" And Label3.Text <> "7" Then
            lblScore.Text = lblScore.Text + 20
        ElseIf Label1.Text = "7" And Label2.Text <> "7" And Label3.Text <> "7" Then
        Else
            If lblScore.Text > 0 Then


                lblScore.Text = lblScore.Text - 10
                PictureBox1.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = True
            Else
                Label7.Visible = True
                btnJugar.Visible = False

                lblScore.Visible = False

                PictureBox3.Visible = True
                PictureBox1.Visible = False
                PictureBox4.Visible = False

                Beep()
                System.Threading.Thread.Sleep(5000)
                End

            End If



        End If






    End Sub

    Private Sub frmFortuna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Visible = False
        Label7.Visible = False

        Randomize()

        lblScore.Text = score


    End Sub

End Class
