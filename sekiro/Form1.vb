Public Class Form1

    '分数
    Dim score = 0

    '血量
    Dim HP = 5

    '飞镖数量
    Dim CKL = 0

    '注册窗体的键盘事件
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    '键盘事件
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.D Then
            If Timer1.Enabled = True Then
                Timer1.Enabled = False
            End If
            If Timer3.Enabled = True Then
                Timer3.Enabled = False
            End If
            If Timer2.Enabled = False And Timer4.Enabled = False And Timer5.Enabled = False And Timer6.Enabled = False And Timer7.Enabled = False And Timer15.Enabled = False Then
                Timer2.Enabled = True
            End If
        ElseIf e.KeyCode = Keys.A Then
            If Timer1.Enabled = True Then
                Timer1.Enabled = False
            End If
            If Timer2.Enabled = True Then
                Timer2.Enabled = False
            End If
            If Timer3.Enabled = False And Timer4.Enabled = False And Timer5.Enabled = False And Timer6.Enabled = False And Timer7.Enabled = False And Timer15.Enabled = False Then
                Timer3.Enabled = True
            End If
        End If
    End Sub
    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.D Then
            Timer2.Enabled = False
            quiet_index = 0
            run_index = 0
            Timer1.Enabled = True
        ElseIf e.KeyCode = Keys.A Then
            Timer3.Enabled = False
            quiet_index = 0
            back_index = 0
            Timer1.Enabled = True
        ElseIf e.KeyCode = Keys.J Then
            If Timer1.Enabled = True Then
                Timer1.Enabled = False
            End If
            If Timer2.Enabled = True Then
                Timer2.Enabled = False
            End If
            If Timer3.Enabled = True Then
                Timer3.Enabled = False
            End If
            If Timer4.Enabled = False And Timer5.Enabled = False And Timer6.Enabled = False And Timer7.Enabled = False And Timer10.Enabled = False And Timer15.Enabled = False Then
                Timer4.Enabled = True
            Else
                attacked = True
            End If
        ElseIf e.KeyCode = Keys.K Then
            If Timer1.Enabled = True Then
                Timer1.Enabled = False
            End If
            If Timer2.Enabled = True Then
                Timer2.Enabled = False
            End If
            If Timer3.Enabled = True Then
                Timer3.Enabled = False
            End If
            If Timer6.Enabled = False And Timer4.Enabled = False And Timer5.Enabled = False And Timer7.Enabled = False And Timer10.Enabled = False And Timer15.Enabled = False Then
                Timer6.Enabled = True
            End If
        ElseIf e.KeyCode = Keys.ShiftKey Then
            If Timer1.Enabled = True Then
                Timer1.Enabled = False
            End If
            If Timer2.Enabled = True Then
                Timer2.Enabled = False
            End If
            If Timer3.Enabled = True Then
                Timer3.Enabled = False
            End If
            If Timer7.Enabled = False And Timer4.Enabled = False And Timer5.Enabled = False And Timer6.Enabled = False And Timer10.Enabled = False And Timer15.Enabled = False Then
                Timer7.Enabled = True
            End If
        ElseIf e.KeyCode = Keys.L Then
            If Timer1.Enabled = True Then
                Timer1.Enabled = False
            End If
            If Timer2.Enabled = True Then
                Timer2.Enabled = False
            End If
            If Timer3.Enabled = True Then
                Timer3.Enabled = False
            End If
            If Timer10.Enabled = False And Timer4.Enabled = False And Timer5.Enabled = False And Timer6.Enabled = False And Timer7.Enabled = False And Timer12.Enabled = False And Timer15.Enabled = False Then
                Timer10.Enabled = True
            End If
        End If
    End Sub

    '游戏开始
    Dim FX = 120
    Dim FY = 393
    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        score = 0
        HP = 5
        CKL = 0
        PictureBox1.Left = FX
        PictureBox1.Top = FY
        quiet_act(0) = sekiro.My.Resources.Resources.quiet0
        quiet_act(1) = sekiro.My.Resources.Resources.quiet1
        quiet_act(2) = sekiro.My.Resources.Resources.quiet2
        quiet_act(3) = sekiro.My.Resources.Resources.quiet3
        run_act(0) = sekiro.My.Resources.Resources.running0
        run_act(1) = sekiro.My.Resources.Resources.running1
        run_act(2) = sekiro.My.Resources.Resources.running2
        run_act(3) = sekiro.My.Resources.Resources.running3
        run_act(4) = sekiro.My.Resources.Resources.running4
        run_act(5) = sekiro.My.Resources.Resources.running5
        run_act(6) = sekiro.My.Resources.Resources.running6
        run_act(7) = sekiro.My.Resources.Resources.running7
        back_act(0) = sekiro.My.Resources.Resources.walking1
        back_act(1) = sekiro.My.Resources.Resources.walking2
        back_act(2) = sekiro.My.Resources.Resources.walking3
        back_act(3) = sekiro.My.Resources.Resources.walking4
        back_act(4) = sekiro.My.Resources.Resources.walking5
        attack_act(0) = sekiro.My.Resources.Resources.attack101
        attack_act(1) = sekiro.My.Resources.Resources.attack102
        attack_act(2) = sekiro.My.Resources.Resources.attack103
        attack_act(3) = sekiro.My.Resources.Resources.attack104
        attack_act(4) = sekiro.My.Resources.Resources.attack105
        attack_act(5) = sekiro.My.Resources.Resources.attack106
        attack_act(6) = sekiro.My.Resources.Resources.attack107
        attack_act(7) = sekiro.My.Resources.Resources.attack108
        attack_act(8) = sekiro.My.Resources.Resources.attack109
        attack_act(9) = sekiro.My.Resources.Resources.attack110
        attack_act(10) = sekiro.My.Resources.Resources.attack111
        attack_act(11) = sekiro.My.Resources.Resources.attack112
        attack2_act(0) = sekiro.My.Resources.Resources.attack20
        attack2_act(1) = sekiro.My.Resources.Resources.attack21
        attack2_act(2) = sekiro.My.Resources.Resources.attack22
        attack2_act(3) = sekiro.My.Resources.Resources.attack23
        attack2_act(4) = sekiro.My.Resources.Resources.attack24
        attack2_act(5) = sekiro.My.Resources.Resources.attack25
        attack2_act(6) = sekiro.My.Resources.Resources.attack26
        attack2_act(7) = sekiro.My.Resources.Resources.attack27
        attack2_act(8) = sekiro.My.Resources.Resources.attack30
        attack2_act(9) = sekiro.My.Resources.Resources.attack31
        attack2_act(10) = sekiro.My.Resources.Resources.attack32
        attack2_act(11) = sekiro.My.Resources.Resources.attack33
        attack2_act(12) = sekiro.My.Resources.Resources.attack34
        attack2_act(13) = sekiro.My.Resources.Resources.attack35
        attack2_act(14) = sekiro.My.Resources.Resources.attack36
        jump_act(0) = sekiro.My.Resources.Resources.jump0
        jump_act(1) = sekiro.My.Resources.Resources.jump1
        jump_act(2) = sekiro.My.Resources.Resources.jump2
        jump_act(3) = sekiro.My.Resources.Resources.jump3
        jump_act(4) = sekiro.My.Resources.Resources.jump4
        jump_act(5) = sekiro.My.Resources.Resources.jump5
        jump_act(6) = sekiro.My.Resources.Resources.jump6
        jump_act(7) = sekiro.My.Resources.Resources.jump7
        slash_act(1) = sekiro.My.Resources.Resources.slash1
        slash_act(2) = sekiro.My.Resources.Resources.slash2
        slash_act(3) = sekiro.My.Resources.Resources.slash3
        slash_act(4) = sekiro.My.Resources.Resources.slash4
        slash_act(5) = sekiro.My.Resources.Resources.slash5
        shoot_act(1) = sekiro.My.Resources.Resources.shoot1
        shoot_act(2) = sekiro.My.Resources.Resources.shoot2
        shoot_act(3) = sekiro.My.Resources.Resources.shoot3
        shoot_act(4) = sekiro.My.Resources.Resources.shoot4
        shoot_act(5) = sekiro.My.Resources.Resources.shoot5
        shoot_act(6) = sekiro.My.Resources.Resources.shoot6
        numbers(0) = sekiro.My.Resources.Resources._0
        numbers(1) = sekiro.My.Resources.Resources._1
        numbers(2) = sekiro.My.Resources.Resources._2
        numbers(3) = sekiro.My.Resources.Resources._3
        numbers(4) = sekiro.My.Resources.Resources._4
        numbers(5) = sekiro.My.Resources.Resources._5
        numbers(6) = sekiro.My.Resources.Resources._6
        numbers(7) = sekiro.My.Resources.Resources._7
        numbers(8) = sekiro.My.Resources.Resources._8
        numbers(9) = sekiro.My.Resources.Resources._9
        danger_act(0) = sekiro.My.Resources.Resources.danger1
        danger_act(1) = sekiro.My.Resources.Resources.danger2
        danger_act(2) = sekiro.My.Resources.Resources.danger3
        danger_act(3) = sekiro.My.Resources.Resources.danger4
        danger_act(4) = sekiro.My.Resources.Resources.danger3
        danger_act(5) = sekiro.My.Resources.Resources.danger2
        danger_act(6) = sekiro.My.Resources.Resources.danger1
        death_act(1) = sekiro.My.Resources.Resources.death1
        death_act(2) = sekiro.My.Resources.Resources.death2
        death_act(3) = sekiro.My.Resources.Resources.death3
        death_act(4) = sekiro.My.Resources.Resources.death4
        death_act(5) = sekiro.My.Resources.Resources.death5
        death_act(6) = sekiro.My.Resources.Resources.death6
        death2_act(1) = sekiro.My.Resources.Resources.death11
        death2_act(2) = sekiro.My.Resources.Resources.death21
        death2_act(3) = sekiro.My.Resources.Resources.death31
        death2_act(4) = sekiro.My.Resources.Resources.death41
        PictureBox14.Visible = False
        PictureBox15.Visible = False
        PictureBox16.Visible = False
        PictureBox17.Visible = False
        PictureBox19.Visible = False
        PictureBox20.Visible = False
        PictureBox1.Visible = True
        PictureBox6.Visible = True
        PictureBox7.Visible = True
        PictureBox8.Visible = True
        PictureBox9.Visible = True
        PictureBox10.Visible = True
        PictureBox11.Visible = True
        PictureBox12.Visible = True
        numcg()
        Timer1.Enabled = True
        Timer8.Enabled = True
    End Sub

    '禁止时
    Dim quiet_index = 0
    Dim quiet_act(4) As Bitmap
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.BackgroundImage = quiet_act(quiet_index)
        quiet_index += 1
        quiet_index = quiet_index Mod 4
    End Sub

    '奔跑时
    Dim run_index = 0
    Dim run_act(8) As Bitmap
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox1.BackgroundImage = run_act(run_index)
        PictureBox1.Left += 17
        run_index += 1
        run_index = run_index Mod 8
    End Sub

    '后退时
    Dim back_index = 0
    Dim back_act(5) As Bitmap
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        PictureBox1.BackgroundImage = back_act(back_index)
        PictureBox1.Left -= 8
        back_index += 1
        back_index = back_index Mod 5
    End Sub

    '攻击时
    Dim attack_index = 0
    Dim attacked = False
    Dim attack_act(12) As Bitmap
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        PictureBox1.BackgroundImage = attack_act(attack_index)
        attack_index += 1
        If attack_index >= 7 Then
            If Timer9.Enabled = True And block1.Left > PictureBox1.Left + 120 And block1.Left < PictureBox1.Left + 200 And block1.Top < PictureBox1.Top + 200 And block1.Top > PictureBox1.Top + 90 Then
                If score <= 98 Then
                    score += 1
                    numcg()
                End If
                PictureBox5.Top = block1.Top
                PictureBox5.Left = block1.Left - 10
                PictureBox5.Visible = True
                Timer13.Enabled = True
                Dim x = myRND.Next(1200, 2500)
                Dim y = myRND.Next(120, 220)
                block1.Left = PictureBox1.Left + x
                block1.Top = PictureBox1.Top + y
                v = myRND.Next(15, 25)
                If y >= 200 Then
                    block1.Left = PictureBox1.Left + 1400
                    v = 25
                    PictureBox13.BackgroundImage = Nothing
                    PictureBox13.Visible = True
                    Timer14.Enabled = True
                End If
                If CKL < 3 Then
                    CKL += 1
                    If CKL = 1 Then
                        PictureBox2.Visible = True
                    ElseIf CKL = 2 Then
                        PictureBox3.Visible = True
                    ElseIf CKL = 3 Then
                        PictureBox4.Visible = True
                    End If
                End If
            End If
            PictureBox1.Left += 5
        End If
        If attack_index = 12 Then
            If attacked Then
                attack_index = 0
                attacked = False
                Timer5.Enabled = True
                Timer4.Enabled = False
            Else
                attack_index = 0
                Timer1.Enabled = True
                Timer4.Enabled = False
            End If
        End If
    End Sub

    '二段攻击时
    Dim attack2_index = 0
    Dim attack2_act(15) As Bitmap
    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        PictureBox1.BackgroundImage = attack2_act(attack2_index)
        attack2_index += 1
        If attack2_index >= 3 And attack2_index < 9 Then
            PictureBox1.Left += 3
            If Timer9.Enabled = True And block1.Left > PictureBox1.Left + 120 And block1.Left < PictureBox1.Left + 210 And block1.Top < PictureBox1.Top + 200 And block1.Top > PictureBox1.Top + 90 Then
                If score <= 97 Then
                    score += 2
                    numcg()
                End If
                PictureBox5.Top = block1.Top
                PictureBox5.Left = block1.Left - 10
                PictureBox5.Visible = True
                Timer13.Enabled = True
                Dim x = myRND.Next(1200, 2500)
                Dim y = myRND.Next(120, 220)
                block1.Left = PictureBox1.Left + x
                block1.Top = PictureBox1.Top + y
                v = myRND.Next(15, 25)
                If y >= 200 Then
                    block1.Left = PictureBox1.Left + 1400
                    v = 25
                    PictureBox13.BackgroundImage = Nothing
                    PictureBox13.Visible = True
                    Timer14.Enabled = True
                End If
                If CKL < 3 Then
                    CKL += 1
                    If CKL = 1 Then
                        PictureBox2.Visible = True
                    ElseIf CKL = 2 Then
                        PictureBox3.Visible = True
                    ElseIf CKL = 3 Then
                        PictureBox4.Visible = True
                    End If
                End If
            End If
        ElseIf attack2_index >= 9 Then
            PictureBox1.Left += 10
            If Timer9.Enabled = True And block1.Left > PictureBox1.Left + 120 And block1.Left < PictureBox1.Left + 240 And block1.Top < PictureBox1.Top + 200 And block1.Top > PictureBox1.Top + 90 Then
                If score <= 96 Then
                    score += 3
                    numcg()
                End If
                PictureBox5.Top = block1.Top
                PictureBox5.Left = block1.Left - 10
                PictureBox5.Visible = True
                Timer13.Enabled = True
                Dim x = myRND.Next(1200, 2500)
                Dim y = myRND.Next(120, 220)
                block1.Left = PictureBox1.Left + x
                block1.Top = PictureBox1.Top + y
                v = myRND.Next(15, 25)
                If y >= 200 Then
                    block1.Left = PictureBox1.Left + 1400
                    v = 25
                    PictureBox13.BackgroundImage = Nothing
                    PictureBox13.Visible = True
                    Timer14.Enabled = True
                End If
                If CKL < 3 Then
                    CKL += 1
                    If CKL = 1 Then
                        PictureBox2.Visible = True
                    ElseIf CKL = 2 Then
                        PictureBox3.Visible = True
                    ElseIf CKL = 3 Then
                        PictureBox4.Visible = True
                    End If
                End If
            End If
        End If
        If attack2_index = 15 Then
            attack2_index = 0
            Timer1.Enabled = True
            Timer5.Enabled = False
        End If
    End Sub

    '跳跃时
    Dim jump_index = 0
    Dim jump_act(8) As Bitmap
    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        PictureBox1.BackgroundImage = jump_act(jump_index)
        jump_index += 1
        If jump_index = 2 Then
            PictureBox1.Top -= 40
        ElseIf jump_index = 3 Then
            PictureBox1.Top -= 20
        ElseIf jump_index = 4 Then
            PictureBox1.Top -= 10
        ElseIf jump_index = 5 Then
            PictureBox1.Top += 10
        ElseIf jump_index = 6 Then
            PictureBox1.Top += 20
        ElseIf jump_index = 7 Then
            PictureBox1.Top += 40
        End If
        If jump_index = 8 Then
            jump_index = 0
            Timer1.Enabled = True
            Timer6.Enabled = False
        End If
    End Sub

    '后撤步
    Dim slash_index = 0
    Dim slash_act(5) As Bitmap
    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        PictureBox1.BackgroundImage = slash_act(slash_index)
        PictureBox1.Left -= 15
        slash_index += 1
        If slash_index = 5 Then
            slash_index = 0
            Timer1.Enabled = True
            Timer7.Enabled = False
        End If
    End Sub

    '扔飞镖
    Dim shoot_index = 0
    Dim shoot_act(6) As Bitmap
    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        PictureBox1.BackgroundImage = shoot_act(shoot_index)
        shoot_index += 1
        If shoot_index = 6 Then
            shoot_index = 0
            Timer1.Enabled = True
            Timer10.Enabled = False
            If CKL > 0 Then
                CKL -= 1
                If CKL = 0 Then
                    PictureBox2.Visible = False
                ElseIf CKL = 1 Then
                    PictureBox3.Visible = False
                ElseIf CKL = 2 Then
                    PictureBox4.Visible = False
                End If
                Timer11.Enabled = True
            End If
        End If
    End Sub
    Dim block2 = New PictureBox
    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick
        block2.Size = New Size(100, 15)
        Dim y = PictureBox1.Top + 180
        If block1.Top >= y - 35 And block1.Top <= y + 20 Then
            y = block1.Top
        End If
        block2.Location = New Point(PictureBox1.Left + 130, y)
        block2.BackgroundImage = sekiro.My.Resources.Resources.kuwu1
        block2.BackgroundImageLayout = ImageLayout.Zoom
        block2.Visible = True
        Me.Controls.Add(block2)
        block2.BringToFront()
        Timer11.Enabled = False
        Timer12.Enabled = True
    End Sub
    Private Sub Timer12_Tick(sender As Object, e As EventArgs) Handles Timer12.Tick
        If shooton(block2.Left, block2.Top) Then
            If score <= 97 Then
                score += 2
                numcg()
            End If
            PictureBox5.Top = block1.Top
            PictureBox5.Left = block1.Left - 10
            PictureBox5.Visible = True
            Timer13.Enabled = True
            Dim x = myRND.Next(1200, 2500)
            Dim y = myRND.Next(120, 220)
            block1.Left = PictureBox1.Left + x
            block1.Top = PictureBox1.Top + y
            v = myRND.Next(15, 25)
            If y >= 200 Then
                block1.Left = PictureBox1.Left + 1400
                v = 25
                PictureBox13.BackgroundImage = Nothing
                PictureBox13.Visible = True
                Timer14.Enabled = True
            End If
            block2.Visible = False
            Timer12.Enabled = False
        Else
            block2.Left += 25
            If block2.Left >= 1200 Then
                block2.Visible = False
                Timer12.Enabled = False
            End If
        End If
    End Sub

    '飞镖
    Dim myRND As New Random
    Dim v = myRND.Next(15, 25)
    Dim block1 = New PictureBox
    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        block1.Size = New Size(100, 15)
        Dim x = 2500
        Dim y = myRND.Next(120, 220)
        block1.Location = New Point(PictureBox1.Left + x, PictureBox1.Top + y)
        block1.BackgroundImage = sekiro.My.Resources.Resources.kuwu0
        block1.BackgroundImageLayout = ImageLayout.Zoom
        block1.Visible = True
        Me.Controls.Add(block1)
        block1.BringToFront()
        Timer8.Enabled = False
        Timer9.Enabled = True
    End Sub
    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        If hitted(block1.Left, block1.Top) Then
            HP -= 1
            If HP = 4 Then
                PictureBox10.Visible = False
            ElseIf HP = 3 Then
                PictureBox9.Visible = False
            ElseIf HP = 2 Then
                PictureBox8.Visible = False
            ElseIf HP = 1 Then
                PictureBox7.Visible = False
            ElseIf HP = 0 Then
                PictureBox6.Visible = False
                Timer1.Enabled = False
                Timer2.Enabled = False
                Timer3.Enabled = False
                Timer4.Enabled = False
                Timer5.Enabled = False
                Timer6.Enabled = False
                Timer7.Enabled = False
                Timer10.Enabled = False
                Timer15.Enabled = True
            End If
            Dim x = myRND.Next(1200, 2500)
            Dim y = myRND.Next(120, 220)
            block1.Left = PictureBox1.Left + x
            block1.Top = PictureBox1.Top + y
            v = myRND.Next(15, 25)
            If y >= 200 Then
                block1.Left = PictureBox1.Left + 1400
                v = 25
                PictureBox13.BackgroundImage = Nothing
                PictureBox13.Visible = True
                Timer14.Enabled = True
            End If
        Else
            block1.Left -= v
            If block1.Left <= -30 Then
                If score <= 98 Then
                    score += 1
                    numcg()
                End If
                Dim x = myRND.Next(1200, 2500)
                Dim y = myRND.Next(120, 220)
                block1.Left = PictureBox1.Left + x
                block1.Top = PictureBox1.Top + y
                v = myRND.Next(15, 25)
                If y >= 200 Then
                    block1.Left = PictureBox1.Left + 1400
                    v = 25
                    PictureBox13.BackgroundImage = Nothing
                    PictureBox13.Visible = True
                    Timer14.Enabled = True
                End If
            End If
        End If
    End Sub

    '碰撞检测
    Private Function hitted(x As Integer, y As Integer) As Boolean
        If y >= PictureBox1.Top + 120 And y <= PictureBox1.Top + 220 And x <= PictureBox1.Left + 120 And x >= PictureBox1.Left + 95 Then
            Return True
        End If
        Return False
    End Function

    '飞镖对撞
    Private Function shooton(x As Integer, y As Integer) As Boolean
        If y >= block1.Top - 10 And y <= block1.Top + 10 And x <= block1.Left + 90 And x >= block1.Left - 90 Then
            Return True
        End If
        Return False
    End Function

    '黄色星星
    Dim star_index = 0
    Private Sub Timer13_Tick(sender As Object, e As EventArgs) Handles Timer13.Tick
        star_index += 1
        If star_index = 2 Then
            PictureBox5.Visible = False
            Timer13.Enabled = False
            star_index = 0
        End If
    End Sub

    '记分牌变动
    Dim numbers(10) As Bitmap
    Private Sub numcg()
        Dim r = score Mod 10
        Dim l = (score - r) / 10
        PictureBox11.BackgroundImage = numbers(l)
        PictureBox12.BackgroundImage = numbers(r)
    End Sub

    '危
    Dim danger_act(7) As Bitmap
    Dim danger_index = 0
    Private Sub Timer14_Tick(sender As Object, e As EventArgs) Handles Timer14.Tick
        PictureBox13.Top = PictureBox1.Top + 36
        PictureBox13.Left = PictureBox1.Left + 80
        PictureBox13.BackgroundImage = danger_act(danger_index)
        danger_index += 1
        If danger_index = 7 Then
            PictureBox13.Visible = False
            Timer14.Enabled = False
            danger_index = 0
        End If
    End Sub

    '倒地
    Dim death_act(6) As Bitmap
    Dim death_index = 0
    Private Sub Timer15_Tick(sender As Object, e As EventArgs) Handles Timer15.Tick
        PictureBox1.BackgroundImage = death_act(death_index)
        death_index += 1
        If death_index = 6 Then
            death_index = 0
            Timer15.Enabled = False
            death()
        End If
    End Sub

    '死
    Private Sub death()
        Timer8.Enabled = False
        Timer9.Enabled = False
        Timer11.Enabled = False
        Timer12.Enabled = False
        Timer13.Enabled = False
        Timer14.Enabled = False
        block1.Visible = False
        block2.Visible = False
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        PictureBox12.Visible = False
        PictureBox13.Visible = False
        PictureBox14.Visible = True
        Timer16.Enabled = True
    End Sub

    '死字动画
    Dim death2_act(4) As Bitmap
    Dim death2_index = 0
    Private Sub Timer16_Tick(sender As Object, e As EventArgs) Handles Timer16.Tick
        PictureBox14.BackgroundImage = death2_act(death2_index)
        death2_index += 1
        If death2_index = 4 Then
            death2_index = 0
            Timer16.Enabled = False
            PictureBox19.BackgroundImage = PictureBox11.BackgroundImage
            PictureBox20.BackgroundImage = PictureBox12.BackgroundImage
            PictureBox17.Visible = True
            PictureBox19.Visible = True
            PictureBox20.Visible = True
        End If
    End Sub

    '退出
    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Me.Dispose()
        Application.Exit()
    End Sub

    '按键高亮
    Private Sub PictureBox15_Enter(sender As Object, e As EventArgs) Handles PictureBox15.MouseEnter
        PictureBox15.BackgroundImage = sekiro.My.Resources.Resources.start2
    End Sub
    Private Sub PictureBox15_Leave(sender As Object, e As EventArgs) Handles PictureBox15.MouseLeave
        PictureBox15.BackgroundImage = sekiro.My.Resources.Resources.start
    End Sub
    Private Sub PictureBox16_Enter(sender As Object, e As EventArgs) Handles PictureBox16.MouseEnter
        PictureBox16.BackgroundImage = sekiro.My.Resources.Resources.quit2
    End Sub
    Private Sub PictureBox16_Leave(sender As Object, e As EventArgs) Handles PictureBox16.MouseLeave
        PictureBox16.BackgroundImage = sekiro.My.Resources.Resources.quit
    End Sub
    Private Sub PictureBox14_Enter(sender As Object, e As EventArgs) Handles PictureBox14.MouseEnter
        If Timer16.Enabled = False Then
            PictureBox14.BackgroundImage = sekiro.My.Resources.Resources.death21
        End If
    End Sub
    Private Sub PictureBox14_Leave(sender As Object, e As EventArgs) Handles PictureBox14.MouseLeave
        PictureBox14.BackgroundImage = sekiro.My.Resources.Resources.death41
    End Sub

    '回到菜单
    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        PictureBox14.Visible = False
        PictureBox15.Visible = True
        PictureBox16.Visible = True
    End Sub
End Class