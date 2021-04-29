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

        TaskPointer = My.Settings.TaskPointer
        TasksConcluidas = 0
        TasksExcluidas = 0
        countToDo1 = 0
        Pomodoro.Interval = 1000
        pomodoroPointer = 1

        PnTask_1.Visible = My.Settings.PnTask_1
        PnTask_2.Visible = My.Settings.PnTask_2
        PnTask_3.Visible = My.Settings.PnTask_3

        lblTask_1.Text = My.Settings.LblTask_1
        lblTask_2.Text = My.Settings.LblTask_2
        lblTask_3.Text = My.Settings.LblTask_3

        important_1.BackColor = My.Settings.Important_1
        important_2.BackColor = My.Settings.Important_2
        important_3.BackColor = My.Settings.Important_3

        IsNormal_1 = My.Settings.IsNormal_1
        IsNormal_2 = My.Settings.IsNormal_2
        IsNormal_3 = My.Settings.IsNormal_3

        stage_1.Text = My.Settings.stage_1

        lblTask_1.BackColor = My.Settings.lblTask1_BackColor
        lblTask_2.BackColor = My.Settings.lblTask2_BackColor
        lblTask_3.BackColor = My.Settings.lblTask3_BackColor

        'DarkMode
        If My.Settings.IsDark = True Then

            Me.BackColor = Color.FromArgb(10, 10, 10)
            PnTask_1.BackColor = Color.FromArgb(64, 64, 64)
            PnTask_2.BackColor = Color.FromArgb(64, 64, 64)
            PnTask_3.BackColor = Color.FromArgb(64, 64, 64)

            Rtx_Task.BackColor = Color.FromArgb(64, 64, 64)
            Rtx_Task.ForeColor = Color.White

            lblTask_1.ForeColor = Color.White
            lblTask_1.BackColor = Color.FromArgb(64, 64, 64)
            If PnTask_1.BackColor = Color.SpringGreen Then
                lblTask_1.BackColor = Color.SpringGreen
            End If

            lblTask_2.ForeColor = Color.White
            lblTask_2.BackColor = Color.FromArgb(64, 64, 64)

            lblTask_3.ForeColor = Color.White
            lblTask_3.BackColor = Color.FromArgb(64, 64, 64)

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

                BtnDarkMode.Text = "  Light Mode"
                BtnDarkMode.Image = My.Resources.light_bulb


            Else

                Me.BackColor = Color.White
            PnTask_1.BackColor = Color.White
            PnTask_2.BackColor = Color.White
            PnTask_3.BackColor = Color.White

            Rtx_Task.BackColor = Color.WhiteSmoke
            Rtx_Task.ForeColor = Color.Black

            lblTask_1.ForeColor = Color.Black
            lblTask_1.BackColor = Color.White
            lblTask_2.ForeColor = Color.Black
            lblTask_1.BackColor = Color.White
            lblTask_3.ForeColor = Color.Black
            lblTask_1.BackColor = Color.White
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

            FlowLayoutPanel1.BackColor = Color.WhiteSmoke
            FlowLayoutPanel2.BackColor = Color.WhiteSmoke
            FlowLayoutPanel3.BackColor = Color.WhiteSmoke

            ComboBox1.FlatStyle = FlatStyle.Flat
            My.Settings.IsDark = False

            BtnDarkMode.Text = "  Dark Mode"
            BtnDarkMode.Image = My.Resources.moon__1_
        End If

        '=1=
        If My.Settings.stage_1 = 1 Then
            FlowLayoutPanel1.Controls.Add(PnTask_1)
            BtnBack_1.Enabled = True
        End If

        If My.Settings.stage_1 = 2 Then
            FlowLayoutPanel2.Controls.Add(PnTask_1)
            BtnBack_1.Enabled = True
        End If

        If My.Settings.stage_1 = 3 Then
            FlowLayoutPanel3.Controls.Add(PnTask_1)
            BtnBack_1.Enabled = True
            PnTask_1.BackColor = Color.SpringGreen
            btn_delete1.Text = "Concluir"
            btn_delete1.ForeColor = Color.Black
            lblTask_1.Font = New Font(lblTask_1.Font, FontStyle.Strikeout)
        End If

        '==2==
        If My.Settings.stage_2 = 1 Then
            FlowLayoutPanel1.Controls.Add(PnTask_2)
            BtnBack_2.Enabled = True
        End If

        If My.Settings.stage_2 = 2 Then
            FlowLayoutPanel2.Controls.Add(PnTask_2)
            BtnBack_2.Enabled = True
        End If

        If My.Settings.stage_2 = 3 Then
            FlowLayoutPanel3.Controls.Add(PnTask_2)
            BtnBack_2.Enabled = True
            PnTask_2.BackColor = Color.SpringGreen
            Btn_delete2.Text = "Concluir"
            Btn_delete2.ForeColor = Color.Black
            lblTask_2.Font = New Font(lblTask_2.Font, FontStyle.Strikeout)
        End If

        '===3===
        If My.Settings.stage_3 = 1 Then
            FlowLayoutPanel1.Controls.Add(PnTask_3)
            BtnBack_3.Enabled = True
        End If

        If My.Settings.stage_3 = 2 Then
            FlowLayoutPanel2.Controls.Add(PnTask_3)
            BtnBack_3.Enabled = True
        End If

        If My.Settings.stage_3 = 3 Then
            FlowLayoutPanel3.Controls.Add(PnTask_3)
            BtnBack_3.Enabled = True
            PnTask_3.BackColor = Color.SpringGreen
            Btn_delete3.Text = "Concluir"
            Btn_delete3.ForeColor = Color.Black
            lblTask_3.Font = New Font(lblTask_3.Font, FontStyle.Strikeout)
        End If

    End Sub
    Private Sub Btn_createTaskk_Click(sender As Object, e As EventArgs) Handles Btn_createTaskk.Click

        My.Settings.TaskPointer += 1

        If Rtx_Task.Text = "" Then
            MsgBox("Ops, nenhum texto inserido :(")
        Else
            If My.Settings.TaskPointer = 1 Then

                PnTask_1.Visible = True
                My.Settings.PnTask_1 = PnTask_1.Visible

                lblTask_1.Text = Rtx_Task.Text
                If IsDark = True Then
                    lblTask_1.BackColor = Color.White
                Else
                    lblTask_1.BackColor = Color.FromArgb(64, 64, 64)
                End If

                My.Settings.LblTask_1 = lblTask_1.Text

                    IsNormal_1 = True
                    My.Settings.IsNormal_1 = IsNormal_1

                    pointer1 = 0
                    Rtx_Task.Clear()

                    important_1.BackColor = Color.Silver

                ElseIf My.Settings.TaskPointer = 2 Then

                    PnTask_2.Visible = True
                    My.Settings.PnTask_2 = PnTask_2.Visible

                    lblTask_2.Text = Rtx_Task.Text
                If IsDark = True Then
                    lblTask_2.BackColor = Color.White
                Else
                    lblTask_2.BackColor = Color.FromArgb(64, 64, 64)
                End If

                My.Settings.LblTask_2 = lblTask_2.Text

                IsNormal_2 = True
                    My.Settings.IsNormal_2 = IsNormal_2

                    pointer2 = 0
                    Rtx_Task.Clear()

                    important_2.BackColor = Color.Silver

                ElseIf My.Settings.TaskPointer = 3 Then

                    PnTask_3.Visible = True
                My.Settings.PnTask_3 = PnTask_3.Visible

                lblTask_3.Text = Rtx_Task.Text
                If IsDark = True Then
                    lblTask_3.BackColor = Color.White
                Else
                    lblTask_3.BackColor = Color.FromArgb(64, 64, 64)
                End If
                My.Settings.LblTask_3 = lblTask_3.Text

                IsNormal_3 = True
                My.Settings.IsNormal_3 = IsNormal_3

                pointer3 = 0
                Rtx_Task.Clear()

                important_3.BackColor = Color.Silver

            End If
        End If

        If My.Settings.TaskPointer > 3 Then
            MsgBox("Numero de tarefas atigido")
        Else
            'countToDo1 += 1
        End If

    End Sub

    Private Sub BtnNext_1_Click(sender As Object, e As EventArgs) Handles BtnNext_1.Click

        My.Settings.pointer1 += 1

        If My.Settings.pointer1 = 1 Then
            FlowLayoutPanel2.Controls.Add(PnTask_1)
            BtnBack_1.Enabled = True
        ElseIf My.Settings.pointer1 = 2 Then
            FlowLayoutPanel3.Controls.Add(PnTask_1)
            PnTask_1.BackColor = Color.SpringGreen
            btn_delete1.Text = "Concluir"
            btn_delete1.ForeColor = Color.Black
            lblTask_1.Font = New Font(lblTask_1.Font, FontStyle.Strikeout)
            lblTask_1.BackColor = Color.SpringGreen
            My.Settings.lblTask1_BackColor = lblTask_1.BackColor
            If My.Settings.IsDark = True Then
                lblTask_1.ForeColor = Color.Black
            End If
        End If

        If PnTask_1.Parent Is FlowLayoutPanel1 Then
            My.Settings.stage_1 = 1
        End If

        If PnTask_1.Parent Is FlowLayoutPanel2 Then
            My.Settings.stage_1 = 2

        End If

        If PnTask_1.Parent Is FlowLayoutPanel3 Then
            My.Settings.stage_1 = 3
        End If


        My.Settings.Save()
        My.Settings.Reload()

    End Sub

    Private Sub BtnBack_1_Click(sender As Object, e As EventArgs) Handles BtnBack_1.Click

        My.Settings.pointer1 -= 1

        If My.Settings.pointer1 = 0 Then
            FlowLayoutPanel1.Controls.Add(PnTask_1)
        ElseIf My.Settings.pointer1 = 1 Then
            FlowLayoutPanel2.Controls.Add(PnTask_1)
            PnTask_1.BackColor = Color.White
            btn_delete1.Text = "Delete"
            btn_delete1.ForeColor = Color.DeepPink
            lblTask_1.Font = New Font(lblTask_1.Font, FontStyle.Regular)
            lblTask_1.BackColor = Color.White
            My.Settings.lblTask1_BackColor = lblTask_1.BackColor
        End If

        If PnTask_1.Parent Is FlowLayoutPanel1 Then
            My.Settings.stage_1 = 1
        End If

        If PnTask_1.Parent Is FlowLayoutPanel2 Then
            My.Settings.stage_1 = 2
        End If

        If PnTask_1.Parent Is FlowLayoutPanel3 Then
            My.Settings.stage_1 = 3
        End If

        My.Settings.Save()
        My.Settings.Reload()

    End Sub

    Private Sub BtnNext_2_Click(sender As Object, e As EventArgs) Handles BtnNext_2.Click
        My.Settings.pointer2 += 1

        If My.Settings.pointer2 = 1 Then
            FlowLayoutPanel2.Controls.Add(PnTask_2)
            BtnBack_2.Enabled = True
        ElseIf My.Settings.pointer2 = 2 Then
            FlowLayoutPanel3.Controls.Add(PnTask_2)
            PnTask_2.BackColor = Color.SpringGreen
            Btn_delete2.Text = "Concluir"
            Btn_delete2.ForeColor = Color.Black
            lblTask_2.Font = New Font(lblTask_2.Font, FontStyle.Strikeout)
            lblTask_2.BackColor = Color.SpringGreen
            My.Settings.lblTask2_BackColor = lblTask_2.BackColor
        End If

        If PnTask_2.Parent Is FlowLayoutPanel1 Then
            My.Settings.stage_2 = 1
        End If

        If PnTask_2.Parent Is FlowLayoutPanel2 Then
            My.Settings.stage_2 = 2

        End If

        If PnTask_2.Parent Is FlowLayoutPanel3 Then
            My.Settings.stage_2 = 3
        End If

    End Sub

    Private Sub BtnBack_2_Click(sender As Object, e As EventArgs) Handles BtnBack_2.Click
        My.Settings.pointer2 -= 1

        If My.Settings.pointer2 = 0 Then
            FlowLayoutPanel1.Controls.Add(PnTask_2)

        ElseIf My.Settings.pointer2 = 1 Then
            FlowLayoutPanel2.Controls.Add(PnTask_2)
            PnTask_2.BackColor = Color.White
            btn_delete1.Text = "Delete"
            btn_delete1.ForeColor = Color.DeepPink
            lblTask_2.Font = New Font(lblTask_2.Font, FontStyle.Regular)
            lblTask_2.BackColor = Color.White
            My.Settings.lblTask2_BackColor = lblTask_2.BackColor
        End If

    End Sub

    Private Sub BtnNext_3_Click(sender As Object, e As EventArgs) Handles BtnNext_3.Click

        My.Settings.pointer3 += 1

        If My.Settings.pointer3 = 1 Then
            FlowLayoutPanel2.Controls.Add(PnTask_3)
            BtnBack_3.Enabled = True
        ElseIf My.Settings.pointer3 = 2 Then
            FlowLayoutPanel3.Controls.Add(PnTask_3)
            PnTask_3.BackColor = Color.SpringGreen
            Btn_delete3.Text = "Concluir"
            Btn_delete3.ForeColor = Color.Black
            lblTask_3.Font = New Font(lblTask_3.Font, FontStyle.Strikeout)
            lblTask_3.BackColor = Color.SpringGreen
            My.Settings.lblTask3_BackColor = lblTask_3.BackColor
        End If

        If PnTask_3.Parent Is FlowLayoutPanel1 Then
            My.Settings.stage_3 = 1
        End If

        If PnTask_3.Parent Is FlowLayoutPanel2 Then
            My.Settings.stage_3 = 2
        End If

        If PnTask_3.Parent Is FlowLayoutPanel3 Then
            My.Settings.stage_3 = 3
        End If

    End Sub

    Private Sub BtnBack_3_Click(sender As Object, e As EventArgs) Handles BtnBack_3.Click
        My.Settings.pointer3 -= 1

        If My.Settings.pointer3 = 0 Then
            FlowLayoutPanel1.Controls.Add(PnTask_3)
        ElseIf My.Settings.pointer3 = 1 Then
            FlowLayoutPanel2.Controls.Add(PnTask_3)
            PnTask_3.BackColor = Color.White
            btn_delete1.Text = "Delete"
            btn_delete1.ForeColor = Color.DeepPink
            lblTask_3.Font = New Font(lblTask_3.Font, FontStyle.Regular)
            lblTask_3.BackColor = Color.White
            My.Settings.lblTask3_BackColor = lblTask_3.BackColor
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        My.Settings.Save()
        My.Settings.Reload()

        lbl_TaskPointer.Text = My.Settings.TaskPointer
        'lbl_countToDo1.Text = countToDo1
        lbl_countToDo2.Text = FlowLayoutPanel2.Controls.Count
        lbl_countToDo3.Text = FlowLayoutPanel3.Controls.Count

        lbl_TasksConcluidas.Text = TasksConcluidas
        lbl_TasksExcluidas.Text = TasksExcluidas

        stage_1.Text = My.Settings.stage_1
        stage_2.Text = My.Settings.stage_2
        stage_3.Text = My.Settings.stage_3

        lbl_pointer1.Text = My.Settings.pointer1
        lbl_pointer2.Text = My.Settings.pointer2
        lbl_pointer3.Text = My.Settings.pointer3

        CheckMonitor()
        CheckPerformance()

        'Tabela verdade para representação de situações

        If PnTask_1.Visible = True And PnTask_2.Visible = True And PnTask_3.Visible = True Then
            '(1 - 1 - 1)
            My.Settings.TaskPointer = 3
        ElseIf PnTask_1.Visible = True And PnTask_2.Visible = True And PnTask_3.Visible = False Then
            '( 1 - 1 - 0 )
            My.Settings.TaskPointer = 2
        ElseIf PnTask_1.Visible = True And PnTask_2.Visible = False And PnTask_3.Visible = False Then
            '( 1 - 0 - 0 )
            My.Settings.TaskPointer = 1
        ElseIf PnTask_1.Visible = False And PnTask_2.Visible = False And PnTask_3.Visible = False Then
            '( 0 - 0 - 0 )
            My.Settings.TaskPointer = 0
        ElseIf PnTask_1.Visible = False And PnTask_2.Visible = False And PnTask_3.Visible = True Then
            '( 0 - 0 - 1 )
            My.Settings.TaskPointer = 0
        ElseIf PnTask_1.Visible = True And PnTask_2.Visible = False And PnTask_3.Visible = False Then
            '( 0 - 1 - 1 )
            My.Settings.TaskPointer = 0
        ElseIf PnTask_1.Visible = False And PnTask_2.Visible = True And PnTask_3.Visible = False Then
            '( 0 - 1 - 0 )
            My.Settings.TaskPointer = 0
        ElseIf PnTask_1.Visible = True And PnTask_2.Visible = False And PnTask_3.Visible = True Then
            '( 1 - 0 - 1 )
            My.Settings.TaskPointer = 1
        End If



    End Sub

    Private Sub btn_delete1_Click(sender As Object, e As EventArgs) Handles btn_delete1.Click
        PnTask_1.Visible = False
        FlowLayoutPanel1.Controls.Add(PnTask_1)
        My.Settings.TaskPointer = 0
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
        My.Settings.TaskPointer = 1
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
        My.Settings.TaskPointer = 2
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
            My.Settings.Important_1 = important_1.BackColor
        Else
            important_1.BackColor = Color.Silver
            My.Settings.Important_1 = important_1.BackColor
        End If

    End Sub

    Private Sub important_2_Click(sender As Object, e As EventArgs) Handles important_2.Click
        If important_2.BackColor = Color.Silver Then
            important_2.BackColor = Color.DodgerBlue
            My.Settings.Important_2 = important_2.BackColor
        Else
            important_2.BackColor = Color.Silver
            My.Settings.Important_2 = important_2.BackColor
        End If
    End Sub

    Private Sub important_3_Click(sender As Object, e As EventArgs) Handles important_3.Click
        If important_3.BackColor = Color.Silver Then
            important_3.BackColor = Color.DodgerBlue
            My.Settings.Important_3 = important_3.BackColor
        Else
            important_3.BackColor = Color.Silver
            My.Settings.Important_3 = important_3.BackColor
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
            My.Settings.Important_1 = important_1.BackColor
        Else
            important_1.BackColor = Color.Silver
            My.Settings.Important_1 = important_1.BackColor
        End If

    End Sub

    Private Sub important_2_DoubleClick(sender As Object, e As EventArgs) Handles important_2.DoubleClick
        If important_2.BackColor = Color.Silver Or important_2.BackColor = Color.DodgerBlue Then
            important_2.BackColor = Color.DeepPink
            My.Settings.Important_2 = important_2.BackColor
        Else
            important_2.BackColor = Color.Silver
            My.Settings.Important_2 = important_2.BackColor
        End If
    End Sub

    Private Sub important_3_DoubleClick(sender As Object, e As EventArgs) Handles important_3.DoubleClick
        If important_3.BackColor = Color.Silver Or important_3.BackColor = Color.DodgerBlue Then
            important_3.BackColor = Color.DeepPink
            My.Settings.Important_3 = important_3.BackColor
        Else
            important_3.BackColor = Color.Silver
            My.Settings.Important_3 = important_3.BackColor
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

        If My.Settings.IsDark = False Then

            Me.BackColor = Color.FromArgb(10, 10, 10)
            PnTask_1.BackColor = Color.FromArgb(64, 64, 64)
            PnTask_2.BackColor = Color.FromArgb(64, 64, 64)
            PnTask_3.BackColor = Color.FromArgb(64, 64, 64)

            Rtx_Task.BackColor = Color.FromArgb(64, 64, 64)
            Rtx_Task.ForeColor = Color.White

            lblTask_1.ForeColor = Color.White
            lblTask_1.BackColor = Color.FromArgb(64, 64, 64)
            lblTask_2.ForeColor = Color.White
            lblTask_2.BackColor = Color.FromArgb(64, 64, 64)
            lblTask_3.ForeColor = Color.White
            lblTask_3.BackColor = Color.FromArgb(64, 64, 64)

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
            My.Settings.IsDark = True

            BtnDarkMode.Text = "  Light Mode"
            BtnDarkMode.Image = My.Resources.light_bulb


        Else

            Me.BackColor = Color.White
            PnTask_1.BackColor = Color.White
            PnTask_2.BackColor = Color.White
            PnTask_3.BackColor = Color.White

            Rtx_Task.BackColor = Color.WhiteSmoke
            Rtx_Task.ForeColor = Color.Black

            lblTask_1.ForeColor = Color.Black
            lblTask_1.BackColor = Color.White
            lblTask_2.ForeColor = Color.Black
            lblTask_1.BackColor = Color.White
            lblTask_3.ForeColor = Color.Black
            lblTask_1.BackColor = Color.White
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

            FlowLayoutPanel1.BackColor = Color.WhiteSmoke
            FlowLayoutPanel2.BackColor = Color.WhiteSmoke
            FlowLayoutPanel3.BackColor = Color.WhiteSmoke

            ComboBox1.FlatStyle = FlatStyle.Flat
            My.Settings.IsDark = False

            BtnDarkMode.Text = "  Dark Mode"
            BtnDarkMode.Image = My.Resources.moon__1_
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Reset()
        Me.Close()
    End Sub

    Private Sub EditTask_1_Click(sender As Object, e As EventArgs) Handles EditTask_1.Click

        If lblTask_1.ReadOnly = True Then
            lblTask_1.ReadOnly = False
            EditTask_1.Image = My.Resources.floppy_disk
        Else
            lblTask_1.ReadOnly = True
            EditTask_1.Image = My.Resources.edit__1_
            My.Settings.LblTask_1 = lblTask_1.Text
            MsgBox("Tarefa alterada com sucesso")
        End If

    End Sub

    Private Sub EditTask_2_Click(sender As Object, e As EventArgs) Handles EditTask_2.Click
        If lblTask_2.ReadOnly = True Then
            lblTask_2.ReadOnly = False
            EditTask_2.Image = My.Resources.floppy_disk
        Else
            lblTask_2.ReadOnly = True
            EditTask_2.Image = My.Resources.edit__1_
            My.Settings.LblTask_2 = lblTask_2.Text
            MsgBox("Tarefa alterada com sucesso")
        End If
    End Sub

    Private Sub EditTask_3_Click(sender As Object, e As EventArgs) Handles EditTask_3.Click
        If lblTask_3.ReadOnly = True Then
            lblTask_3.ReadOnly = False
            EditTask_3.Image = My.Resources.floppy_disk
        Else
            lblTask_3.ReadOnly = True
            EditTask_3.Image = My.Resources.edit__1_
            My.Settings.LblTask_3 = lblTask_3.Text
            MsgBox("Tarefa alterada com sucesso")
        End If
    End Sub
End Class
