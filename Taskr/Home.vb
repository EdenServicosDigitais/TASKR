Public Class Home

    Dim pointer1 As Integer
    Dim pointer2 As Integer
    Dim pointer3 As Integer

    Dim TasksConcluidas As Integer
    Dim TasksExcluidas As Integer
    Dim Performance As Integer

    Dim countToDo1 As Integer
    Dim TaskPointer As Integer

    Dim pomodoroSeconds As Integer
    Dim pomodoroMinutes As Integer
    Dim pomodoroPointer As Integer

    Dim IsNormal_1 As Boolean
    Dim IsNormal_2 As Boolean
    Dim IsNormal_3 As Boolean
    Dim IsDark As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TaskPointer = 0
        TasksConcluidas = 0
        TasksExcluidas = 0
        countToDo1 = 0
        Pomodoro.Interval = 1000
        pomodoroPointer = 1

        IsNormal_1 = False
        IsNormal_2 = False
        IsNormal_3 = False

    End Sub
    Private Sub Btn_createTaskk_Click(sender As Object, e As EventArgs) Handles Btn_createTaskk.Click

        TaskPointer += 1

        If Rtx_Task.Text = "" Then
            MsgBox("Ops, nenhum texto inserido :(")
        Else
            If TaskPointer = 1 Then
                PnTask_1.Visible = True
                lblTask_1.Text = Rtx_Task.Text
                pointer1 = 0
                Rtx_Task.Clear()
                IsNormal_1 = True

            ElseIf TaskPointer = 2 Then
                PnTask_2.Visible = True
                lblTask_2.Text = Rtx_Task.Text
                pointer2 = 0
                Rtx_Task.Clear()
                IsNormal_2 = True

            ElseIf TaskPointer = 3 Then
                PnTask_3.Visible = True
                lblTask_3.Text = Rtx_Task.Text
                pointer3 = 0
                Rtx_Task.Clear()
                IsNormal_3 = True

            End If
        End If

        If TaskPointer > 3 Then
            MsgBox("Numero de tarefas atigido")
        Else
            'countToDo1 += 1
        End If

    End Sub

    Private Sub BtnNext_1_Click(sender As Object, e As EventArgs) Handles BtnNext_1.Click
        pointer1 += 1

        If pointer1 = 1 Then
            FlowLayoutPanel2.Controls.Add(PnTask_1)
            BtnBack_1.Enabled = True
        ElseIf pointer1 = 2 Then
            FlowLayoutPanel3.Controls.Add(PnTask_1)
            PnTask_1.BackColor = Color.SpringGreen
            btn_delete1.Text = "Concluir"
            btn_delete1.ForeColor = Color.Black
            lblTask_1.Font = New Font(lblTask_1.Font, FontStyle.Strikeout)
        End If

    End Sub

    Private Sub BtnBack_1_Click(sender As Object, e As EventArgs) Handles BtnBack_1.Click

        pointer1 -= 1

        If pointer1 = 0 Then
            FlowLayoutPanel1.Controls.Add(PnTask_1)
        ElseIf pointer1 = 1 Then
            FlowLayoutPanel2.Controls.Add(PnTask_1)
            PnTask_1.BackColor = Color.White

            btn_delete1.Text = "Delete"
            btn_delete1.ForeColor = Color.DeepPink
            lblTask_1.Font = New Font(lblTask_1.Font, FontStyle.Regular)
        End If


    End Sub

    Private Sub BtnNext_2_Click(sender As Object, e As EventArgs) Handles BtnNext_2.Click
        pointer2 += 1


        If pointer2 = 1 Then
            FlowLayoutPanel2.Controls.Add(PnTask_2)
            BtnBack_2.Enabled = True
        ElseIf pointer2 = 2 Then
            FlowLayoutPanel3.Controls.Add(PnTask_2)
            PnTask_2.BackColor = Color.SpringGreen
            Btn_delete2.Text = "Concluir"
            Btn_delete2.ForeColor = Color.Black
            lblTask_2.Font = New Font(lblTask_2.Font, FontStyle.Strikeout)
        End If
    End Sub

    Private Sub BtnBack_2_Click(sender As Object, e As EventArgs) Handles BtnBack_2.Click
        pointer2 -= 1

        If pointer2 = 0 Then
            FlowLayoutPanel1.Controls.Add(PnTask_2)

        ElseIf pointer2 = 1 Then
            FlowLayoutPanel2.Controls.Add(PnTask_2)
            PnTask_2.BackColor = Color.White

            btn_delete1.Text = "Delete"
            btn_delete1.ForeColor = Color.DeepPink
            lblTask_2.Font = New Font(lblTask_2.Font, FontStyle.Regular)
        End If

    End Sub

    Private Sub BtnNext_3_Click(sender As Object, e As EventArgs) Handles BtnNext_3.Click
        pointer3 += 1


        If pointer3 = 1 Then
            FlowLayoutPanel2.Controls.Add(PnTask_3)
            BtnBack_3.Enabled = True
        ElseIf pointer3 = 2 Then
            FlowLayoutPanel3.Controls.Add(PnTask_3)
            PnTask_3.BackColor = Color.SpringGreen
            Btn_delete3.Text = "Concluir"
            Btn_delete3.ForeColor = Color.Black
            lblTask_3.Font = New Font(lblTask_3.Font, FontStyle.Strikeout)
        End If
    End Sub

    Private Sub BtnBack_3_Click(sender As Object, e As EventArgs) Handles BtnBack_3.Click
        pointer3 -= 1

        If pointer3 = 0 Then
            FlowLayoutPanel1.Controls.Add(PnTask_3)
        ElseIf pointer3 = 1 Then
            FlowLayoutPanel2.Controls.Add(PnTask_3)
            PnTask_3.BackColor = Color.White

            btn_delete1.Text = "Delete"
            btn_delete1.ForeColor = Color.DeepPink
            lblTask_3.Font = New Font(lblTask_3.Font, FontStyle.Regular)
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lbl_TaskPointer.Text = TaskPointer
        'lbl_countToDo1.Text = countToDo1
        lbl_countToDo2.Text = FlowLayoutPanel2.Controls.Count
        lbl_countToDo3.Text = FlowLayoutPanel3.Controls.Count

        lbl_TasksConcluidas.Text = TasksConcluidas
        lbl_TasksExcluidas.Text = TasksExcluidas


        CheckMonitor()
        CheckPerformance()

        'Tabela verdade para representação de situações

        If PnTask_1.Visible = True And PnTask_2.Visible = True And PnTask_3.Visible = True Then
            '(1 - 1 - 1)
            TaskPointer = 3
        ElseIf PnTask_1.Visible = True And PnTask_2.Visible = True And PnTask_3.Visible = False Then
            '( 1 - 1 - 0 )
            TaskPointer = 2
        ElseIf PnTask_1.Visible = True And PnTask_2.Visible = False And PnTask_3.Visible = False Then
            '( 1 - 0 - 0 )
            TaskPointer = 1
        ElseIf PnTask_1.Visible = False And PnTask_2.Visible = False And PnTask_3.Visible = False Then
            '( 0 - 0 - 0 )
            TaskPointer = 0
        ElseIf PnTask_1.Visible = False And PnTask_2.Visible = False And PnTask_3.Visible = True Then
            '( 0 - 0 - 1 )
            TaskPointer = 0
        ElseIf PnTask_1.Visible = True And PnTask_2.Visible = False And PnTask_3.Visible = False Then
            '( 0 - 1 - 1 )
            TaskPointer = 0
        ElseIf PnTask_1.Visible = False And PnTask_2.Visible = True And PnTask_3.Visible = False Then
            '( 0 - 1 - 0 )
            TaskPointer = 0
        ElseIf PnTask_1.Visible = True And PnTask_2.Visible = False And PnTask_3.Visible = True Then
            '( 1 - 0 - 1 )
            TaskPointer = 1
        End If

    End Sub

    Private Sub btn_delete1_Click(sender As Object, e As EventArgs) Handles btn_delete1.Click
        PnTask_1.Visible = False
        FlowLayoutPanel1.Controls.Add(PnTask_1)
        TaskPointer = 0
        countToDo1 -= 1
        IsNormal_1 = False

        If btn_delete1.Text = "Concluir" Then
            TasksConcluidas += 1
            PnTask_1.BackColor = Color.White
            btn_delete1.Text = "Delete"
            btn_delete1.ForeColor = Color.DeepPink
            important_1.BackColor = Color.Silver
        Else
            TasksExcluidas += 1
        End If


    End Sub

    Private Sub Btn_delete2_Click(sender As Object, e As EventArgs) Handles Btn_delete2.Click
        PnTask_2.Visible = False
        FlowLayoutPanel1.Controls.Add(PnTask_2)
        TaskPointer = 1
        countToDo1 -= 1
        IsNormal_2 = False

        If Btn_delete2.Text = "Concluir" Then
            TasksConcluidas += 1
            PnTask_2.BackColor = Color.White
            Btn_delete2.Text = "Delete"
            Btn_delete2.ForeColor = Color.DeepPink
            important_2.BackColor = Color.Silver
        Else
            TasksExcluidas += 1
        End If


    End Sub

    Private Sub Btn_delete3_Click(sender As Object, e As EventArgs) Handles Btn_delete3.Click
        PnTask_3.Visible = False
        FlowLayoutPanel1.Controls.Add(PnTask_3)
        TaskPointer = 2
        countToDo1 -= 1
        IsNormal_3 = False

        If Btn_delete3.Text = "Concluir" Then
            TasksConcluidas += 1
            PnTask_3.BackColor = Color.White
            Btn_delete3.Text = "Delete"
            Btn_delete3.ForeColor = Color.DeepPink
            important_3.BackColor = Color.Silver
        Else
            TasksExcluidas += 1
        End If
    End Sub

    Private Sub important_1_Click(sender As Object, e As EventArgs) Handles important_1.Click

        If important_1.BackColor = Color.Silver Then
            important_1.BackColor = Color.DodgerBlue
        Else
            important_1.BackColor = Color.Silver
        End If

    End Sub

    Private Sub important_2_Click(sender As Object, e As EventArgs) Handles important_2.Click
        If important_2.BackColor = Color.Silver Then
            important_2.BackColor = Color.DodgerBlue
        Else
            important_2.BackColor = Color.Silver
        End If
    End Sub

    Private Sub important_3_Click(sender As Object, e As EventArgs) Handles important_3.Click
        If important_3.BackColor = Color.Silver Then
            important_3.BackColor = Color.DodgerBlue
        Else
            important_3.BackColor = Color.Silver
        End If
    End Sub

    Public Sub CheckMonitor()

        If PnTask_1.Visible = False Then
            ' PnMonitor_1.Text = 0
        Else
            'PnMonitor_1.Text = 1
        End If

        If PnTask_2.Visible = False Then
            'PnMonitor_2.Text = 0
        Else
            ' PnMonitor_2.Text = 1
        End If

        If PnTask_3.Visible = False Then
            'PnMonitor_3.Text = 0
        Else
            ' PnMonitor_3.Text = 1
        End If

    End Sub

    Public Sub CheckPerformance()
        Performance = TasksConcluidas - TasksExcluidas

        If TasksExcluidas > TasksConcluidas Then
            pic_Desempenho.Image = My.Resources.down
        Else
            pic_Desempenho.Image = My.Resources.up
        End If

    End Sub

    Private Sub Pomodoro_Tick(sender As Object, e As EventArgs) Handles Pomodoro.Tick

        pomodoroSeconds += 1
        lbl_Pomodoro.Text = "0" & pomodoroMinutes & ":0" & pomodoroSeconds

        If pomodoroSeconds = 59 Then
            pomodoroSeconds = 0
            pomodoroMinutes += 1
        End If

        If pomodoroMinutes > 9 And pomodoroSeconds > 9 Then
            lbl_Pomodoro.Text = "" & pomodoroMinutes & ":" & pomodoroSeconds
        ElseIf pomodoroMinutes > 9 And pomodoroSeconds < 9 Then
            lbl_Pomodoro.Text = "" & pomodoroMinutes & ":0" & pomodoroSeconds
        ElseIf pomodoroMinutes < 9 And pomodoroSeconds > 9 Then
            lbl_Pomodoro.Text = "0" & pomodoroMinutes & ":" & pomodoroSeconds
        End If

    End Sub

    Private Sub Btn_Pomodoro_Click(sender As Object, e As EventArgs) Handles Btn_Pomodoro.Click

        If pomodoroPointer = 1 Then
            Pomodoro.Start()
            Btn_Pomodoro.Text = "Pausar"
            pomodoroPointer = 2

        ElseIf pomodoroPointer = 2 Then
            Pomodoro.Stop()
            Btn_Pomodoro.Text = "Iniciar"

        End If

    End Sub

    Private Sub important_1_DoubleClick(sender As Object, e As EventArgs) Handles important_1.DoubleClick

        If important_1.BackColor = Color.Silver Or important_1.BackColor = Color.DodgerBlue Then
            important_1.BackColor = Color.DeepPink
        Else
            important_1.BackColor = Color.Silver
        End If

    End Sub

    Private Sub important_2_DoubleClick(sender As Object, e As EventArgs) Handles important_2.DoubleClick
        If important_2.BackColor = Color.Silver Or important_2.BackColor = Color.DodgerBlue Then
            important_2.BackColor = Color.DeepPink
        Else
            important_2.BackColor = Color.Silver
        End If
    End Sub

    Private Sub important_3_DoubleClick(sender As Object, e As EventArgs) Handles important_3.DoubleClick
        If important_3.BackColor = Color.Silver Or important_3.BackColor = Color.DodgerBlue Then
            important_3.BackColor = Color.DeepPink
        Else
            important_3.BackColor = Color.Silver
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        'Filtro de tarefas
        '[0] Todas
        '[1] Importantes
        '[2] Urgentes

        TabIndex = 1

        If ComboBox1.SelectedIndex = 0 Then

            If IsNormal_1 = True And (important_1.BackColor = Color.Silver Or important_1.BackColor = Color.DeepPink Or important_1.BackColor = Color.DodgerBlue) Then
                PnTask_1.Visible = True
            Else
                PnTask_1.Visible = False
            End If

            If IsNormal_2 = True And (important_2.BackColor = Color.Silver Or important_2.BackColor = Color.DeepPink Or important_2.BackColor = Color.DodgerBlue) Then
                PnTask_2.Visible = True
            Else
                PnTask_2.Visible = False
            End If

            If IsNormal_3 = True And (important_3.BackColor = Color.Silver Or important_3.BackColor = Color.DeepPink Or important_3.BackColor = Color.DodgerBlue) Then
                PnTask_3.Visible = True
            Else
                PnTask_3.Visible = False
            End If


        End If

        If ComboBox1.SelectedIndex = 1 Then

            If IsNormal_1 = True And important_1.BackColor = Color.DodgerBlue Then
                PnTask_1.Visible = True
            Else
                PnTask_1.Visible = False
            End If

            If IsNormal_2 = True And important_2.BackColor = Color.DodgerBlue Then
                PnTask_2.Visible = True
            Else
                PnTask_2.Visible = False
            End If

            If IsNormal_3 = True And important_3.BackColor = Color.DodgerBlue Then
                PnTask_3.Visible = True
            Else
                PnTask_3.Visible = False
            End If

        End If

        If ComboBox1.SelectedIndex = 2 Then

            If IsNormal_1 = True And important_1.BackColor = Color.DeepPink Then
                PnTask_1.Visible = True
            Else
                PnTask_1.Visible = False
            End If

            If IsNormal_2 = True And important_2.BackColor = Color.DeepPink Then
                PnTask_2.Visible = True
            Else
                PnTask_2.Visible = False
            End If

            If IsNormal_3 = True And important_3.BackColor = Color.DeepPink Then
                PnTask_3.Visible = True
            Else
                PnTask_3.Visible = False
            End If

        End If


    End Sub

    Private Sub BtnDarkMode_Click(sender As Object, e As EventArgs) Handles BtnDarkMode.Click

        If IsDark = False Then

            Me.BackColor = Color.FromArgb(10, 10, 10)
            PnTask_1.BackColor = Color.FromArgb(64, 64, 64)
            PnTask_2.BackColor = Color.FromArgb(64, 64, 64)
            PnTask_3.BackColor = Color.FromArgb(64, 64, 64)

            Rtx_Task.BackColor = Color.FromArgb(64, 64, 64)
            Rtx_Task.ForeColor = Color.White

            lblTask_1.ForeColor = Color.White
            lblTask_2.ForeColor = Color.White
            lblTask_3.ForeColor = Color.White
            lbl_countToDo2.ForeColor = Color.White
            lbl_countToDo3.ForeColor = Color.White
            lbl_TaskPointer.ForeColor = Color.White

            lbl_TarefasC.ForeColor = Color.White
            lbl_TarefasE.ForeColor = Color.White

            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
            Label4.ForeColor = Color.White
            lbl_Usuário.ForeColor = Color.White
            lbl_Titles.ForeColor = Color.White
            lbl_Level.ForeColor = Color.White

            FlowLayoutPanel1.BackColor = Color.FromArgb(10, 10, 10)
            FlowLayoutPanel2.BackColor = Color.FromArgb(10, 10, 10)
            FlowLayoutPanel3.BackColor = Color.FromArgb(10, 10, 10)

            ComboBox1.FlatStyle = FlatStyle.System
            IsDark = True

            BtnDarkMode.Text = "  Light Mode"
            BtnDarkMode.Image = My.Resources.light_bulb


        Else

            Me.BackColor = Color.White
            PnTask_1.BackColor = Color.WhiteSmoke
            PnTask_2.BackColor = Color.WhiteSmoke
            PnTask_3.BackColor = Color.WhiteSmoke

            Rtx_Task.BackColor = Color.WhiteSmoke
            Rtx_Task.ForeColor = Color.Black

            lblTask_1.ForeColor = Color.Black
            lblTask_2.ForeColor = Color.Black
            lblTask_3.ForeColor = Color.Black
            lbl_TaskPointer.ForeColor = Color.Black

            lbl_TarefasC.ForeColor = Color.Black
            lbl_TarefasE.ForeColor = Color.Black

            Label1.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
            Label4.ForeColor = Color.Black
            lbl_Usuário.ForeColor = Color.Black
            lbl_Titles.ForeColor = Color.Black
            lbl_Level.ForeColor = Color.Black

            FlowLayoutPanel1.BackColor = Color.White
            FlowLayoutPanel2.BackColor = Color.White
            FlowLayoutPanel3.BackColor = Color.White

            ComboBox1.FlatStyle = FlatStyle.Flat
            IsDark = False

            BtnDarkMode.Text = "  Dark Mode"
            BtnDarkMode.Image = My.Resources.moon__1_
        End If

    End Sub
End Class
