Public Class Form1

    Dim pointer1 As Integer
    Dim pointer2 As Integer
    Dim pointer3 As Integer

    Dim TasksConcluidas As Integer
    Dim TasksExcluidas As Integer
    Dim Performance As Integer

    Dim countToDo1 As Integer

    Dim TaskPointer As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TaskPointer = 0
        TasksConcluidas = 0
        TasksExcluidas = 0
        countToDo1 = 0
    End Sub
    Private Sub Btn_createTaskk_Click(sender As Object, e As EventArgs) Handles Btn_createTaskk.Click

        TaskPointer += 1

        If TaskPointer = 1 Then
            PnTask_1.Visible = True
            lblTask_1.Text = Rtx_Task.Text
            pointer1 = 0
            Rtx_Task.Clear()

        ElseIf TaskPointer = 2 Then
            PnTask_2.Visible = True
            lblTask_2.Text = Rtx_Task.Text
            pointer2 = 0
            Rtx_Task.Clear()

        ElseIf TaskPointer = 3 Then
            PnTask_3.Visible = True
            lblTask_3.Text = Rtx_Task.Text
            pointer3 = 0
            Rtx_Task.Clear()

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
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lbl_TaskPointer.Text = TaskPointer
        lbl_countToDo1.Text = countToDo1
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
        important_1.BackColor = Color.DodgerBlue
    End Sub

    Private Sub important_2_Click(sender As Object, e As EventArgs) Handles important_2.Click
        important_2.BackColor = Color.DodgerBlue
    End Sub

    Private Sub important_3_Click(sender As Object, e As EventArgs) Handles important_3.Click
        important_3.BackColor = Color.DodgerBlue
    End Sub

    Public Sub CheckMonitor()

        If PnTask_1.Visible = False Then
            PnMonitor_1.Text = 0
        Else
            PnMonitor_1.Text = 1
        End If

        If PnTask_2.Visible = False Then
            PnMonitor_2.Text = 0
        Else
            PnMonitor_2.Text = 1
        End If

        If PnTask_3.Visible = False Then
            PnMonitor_3.Text = 0
        Else
            PnMonitor_3.Text = 1
        End If

    End Sub

    Public Sub CheckPerformance()
        Performance = TasksConcluidas - TasksExcluidas

        lbl_Desempenho.Text = "Desempenho " & Performance

        If TasksExcluidas > TasksConcluidas Then
            pic_Desempenho.Image = My.Resources.down
        Else
            pic_Desempenho.Image = My.Resources.up
        End If

    End Sub

End Class
