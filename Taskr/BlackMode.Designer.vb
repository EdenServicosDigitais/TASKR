<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlackMode
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_TasksConcluidas = New System.Windows.Forms.Label()
        Me.Btn_createTaskk = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_TasksExcluidas = New System.Windows.Forms.Label()
        Me.lbl_TaskPointer = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_Pomodoro = New System.Windows.Forms.Label()
        Me.Btn_Pomodoro = New System.Windows.Forms.Button()
        Me.lbl_Desempenho = New System.Windows.Forms.Label()
        Me.Pomodoro = New System.Windows.Forms.Timer(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lbl_countToDo3 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PnTask_1 = New System.Windows.Forms.Panel()
        Me.btn_delete1 = New System.Windows.Forms.Label()
        Me.BtnBack_1 = New System.Windows.Forms.Label()
        Me.BtnNext_1 = New System.Windows.Forms.Label()
        Me.lblTask_1 = New System.Windows.Forms.Label()
        Me.PnTask_2 = New System.Windows.Forms.Panel()
        Me.Btn_delete2 = New System.Windows.Forms.Label()
        Me.BtnBack_2 = New System.Windows.Forms.Label()
        Me.BtnNext_2 = New System.Windows.Forms.Label()
        Me.lblTask_2 = New System.Windows.Forms.Label()
        Me.PnTask_3 = New System.Windows.Forms.Panel()
        Me.Btn_delete3 = New System.Windows.Forms.Label()
        Me.BtnBack_3 = New System.Windows.Forms.Label()
        Me.BtnNext_3 = New System.Windows.Forms.Label()
        Me.lblTask_3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_countToDo2 = New System.Windows.Forms.Label()
        Me.Rtx_Task = New System.Windows.Forms.RichTextBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pic_Desempenho = New System.Windows.Forms.PictureBox()
        Me.AfriCircleImage1 = New AfriCircleImage.AfriCircleImage()
        Me.important_1 = New AfriCircleImage.AfriCircleImage()
        Me.important_2 = New AfriCircleImage.AfriCircleImage()
        Me.important_3 = New AfriCircleImage.AfriCircleImage()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.PnTask_1.SuspendLayout()
        Me.PnTask_2.SuspendLayout()
        Me.PnTask_3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Desempenho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AfriCircleImage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.important_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.important_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.important_3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(99, 442)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(204, 92)
        Me.Panel1.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(86, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 54)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Tarefas concluídas"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_TasksConcluidas)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(75, 90)
        Me.Panel2.TabIndex = 0
        '
        'lbl_TasksConcluidas
        '
        Me.lbl_TasksConcluidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_TasksConcluidas.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TasksConcluidas.ForeColor = System.Drawing.Color.LimeGreen
        Me.lbl_TasksConcluidas.Location = New System.Drawing.Point(0, 0)
        Me.lbl_TasksConcluidas.Name = "lbl_TasksConcluidas"
        Me.lbl_TasksConcluidas.Size = New System.Drawing.Size(75, 90)
        Me.lbl_TasksConcluidas.TabIndex = 2
        Me.lbl_TasksConcluidas.Text = "00"
        Me.lbl_TasksConcluidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_createTaskk
        '
        Me.Btn_createTaskk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_createTaskk.BackColor = System.Drawing.Color.DodgerBlue
        Me.Btn_createTaskk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_createTaskk.FlatAppearance.BorderSize = 0
        Me.Btn_createTaskk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_createTaskk.Font = New System.Drawing.Font("Segoe UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_createTaskk.ForeColor = System.Drawing.Color.White
        Me.Btn_createTaskk.Location = New System.Drawing.Point(99, 363)
        Me.Btn_createTaskk.Name = "Btn_createTaskk"
        Me.Btn_createTaskk.Size = New System.Drawing.Size(204, 52)
        Me.Btn_createTaskk.TabIndex = 49
        Me.Btn_createTaskk.Text = "Criar tarefa +"
        Me.Btn_createTaskk.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(100, 543)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(204, 92)
        Me.Panel3.TabIndex = 55
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(86, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 54)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Tarefas excluídas"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lbl_TasksExcluidas)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(75, 90)
        Me.Panel4.TabIndex = 0
        '
        'lbl_TasksExcluidas
        '
        Me.lbl_TasksExcluidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_TasksExcluidas.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TasksExcluidas.ForeColor = System.Drawing.Color.Crimson
        Me.lbl_TasksExcluidas.Location = New System.Drawing.Point(0, 0)
        Me.lbl_TasksExcluidas.Name = "lbl_TasksExcluidas"
        Me.lbl_TasksExcluidas.Size = New System.Drawing.Size(75, 90)
        Me.lbl_TasksExcluidas.TabIndex = 2
        Me.lbl_TasksExcluidas.Text = "00"
        Me.lbl_TasksExcluidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_TaskPointer
        '
        Me.lbl_TaskPointer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_TaskPointer.AutoSize = True
        Me.lbl_TaskPointer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_TaskPointer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TaskPointer.ForeColor = System.Drawing.Color.White
        Me.lbl_TaskPointer.Location = New System.Drawing.Point(188, 218)
        Me.lbl_TaskPointer.Name = "lbl_TaskPointer"
        Me.lbl_TaskPointer.Size = New System.Drawing.Size(16, 17)
        Me.lbl_TaskPointer.TabIndex = 54
        Me.lbl_TaskPointer.Text = "1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(160, 81)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 19)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "titulos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(268, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 19)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Nível 0"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(101, 108)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(161, 10)
        Me.ProgressBar1.TabIndex = 51
        Me.ProgressBar1.Value = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(155, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 37)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Usuario"
        '
        'lbl_Pomodoro
        '
        Me.lbl_Pomodoro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_Pomodoro.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbl_Pomodoro.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pomodoro.ForeColor = System.Drawing.Color.White
        Me.lbl_Pomodoro.Location = New System.Drawing.Point(243, 134)
        Me.lbl_Pomodoro.Name = "lbl_Pomodoro"
        Me.lbl_Pomodoro.Size = New System.Drawing.Size(70, 30)
        Me.lbl_Pomodoro.TabIndex = 59
        Me.lbl_Pomodoro.Text = "00:00"
        Me.lbl_Pomodoro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_Pomodoro
        '
        Me.Btn_Pomodoro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Pomodoro.BackColor = System.Drawing.Color.DodgerBlue
        Me.Btn_Pomodoro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Pomodoro.FlatAppearance.BorderSize = 0
        Me.Btn_Pomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Pomodoro.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Pomodoro.ForeColor = System.Drawing.Color.White
        Me.Btn_Pomodoro.Location = New System.Drawing.Point(101, 134)
        Me.Btn_Pomodoro.Name = "Btn_Pomodoro"
        Me.Btn_Pomodoro.Size = New System.Drawing.Size(136, 30)
        Me.Btn_Pomodoro.TabIndex = 58
        Me.Btn_Pomodoro.Text = "Iniciar"
        Me.Btn_Pomodoro.UseVisualStyleBackColor = False
        '
        'lbl_Desempenho
        '
        Me.lbl_Desempenho.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_Desempenho.AutoSize = True
        Me.lbl_Desempenho.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Desempenho.ForeColor = System.Drawing.Color.White
        Me.lbl_Desempenho.Location = New System.Drawing.Point(99, 641)
        Me.lbl_Desempenho.Name = "lbl_Desempenho"
        Me.lbl_Desempenho.Size = New System.Drawing.Size(154, 25)
        Me.lbl_Desempenho.TabIndex = 56
        Me.lbl_Desempenho.Text = "Desempenho 1.0"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Todas", "Importantes", "Urgentes"})
        Me.ComboBox1.Location = New System.Drawing.Point(1300, 69)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(107, 28)
        Me.ComboBox1.TabIndex = 60
        '
        'lbl_countToDo3
        '
        Me.lbl_countToDo3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_countToDo3.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbl_countToDo3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_countToDo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_countToDo3.ForeColor = System.Drawing.Color.White
        Me.lbl_countToDo3.Location = New System.Drawing.Point(1200, 224)
        Me.lbl_countToDo3.Name = "lbl_countToDo3"
        Me.lbl_countToDo3.Size = New System.Drawing.Size(25, 25)
        Me.lbl_countToDo3.TabIndex = 46
        Me.lbl_countToDo3.Text = "-"
        Me.lbl_countToDo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.PnTask_1)
        Me.FlowLayoutPanel1.Controls.Add(Me.PnTask_2)
        Me.FlowLayoutPanel1.Controls.Add(Me.PnTask_3)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(411, 273)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(322, 447)
        Me.FlowLayoutPanel1.TabIndex = 40
        '
        'PnTask_1
        '
        Me.PnTask_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnTask_1.Controls.Add(Me.important_1)
        Me.PnTask_1.Controls.Add(Me.btn_delete1)
        Me.PnTask_1.Controls.Add(Me.BtnBack_1)
        Me.PnTask_1.Controls.Add(Me.BtnNext_1)
        Me.PnTask_1.Controls.Add(Me.lblTask_1)
        Me.PnTask_1.Location = New System.Drawing.Point(8, 8)
        Me.PnTask_1.Margin = New System.Windows.Forms.Padding(8, 8, 8, 5)
        Me.PnTask_1.Name = "PnTask_1"
        Me.PnTask_1.Size = New System.Drawing.Size(301, 135)
        Me.PnTask_1.TabIndex = 0
        Me.PnTask_1.Visible = False
        '
        'btn_delete1
        '
        Me.btn_delete1.AutoSize = True
        Me.btn_delete1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete1.ForeColor = System.Drawing.Color.DeepPink
        Me.btn_delete1.Location = New System.Drawing.Point(15, 107)
        Me.btn_delete1.Name = "btn_delete1"
        Me.btn_delete1.Size = New System.Drawing.Size(49, 17)
        Me.btn_delete1.TabIndex = 3
        Me.btn_delete1.Text = "Delete"
        '
        'BtnBack_1
        '
        Me.BtnBack_1.AutoSize = True
        Me.BtnBack_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBack_1.Enabled = False
        Me.BtnBack_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack_1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BtnBack_1.Location = New System.Drawing.Point(209, 107)
        Me.BtnBack_1.Name = "BtnBack_1"
        Me.BtnBack_1.Size = New System.Drawing.Size(39, 17)
        Me.BtnBack_1.TabIndex = 2
        Me.BtnBack_1.Text = "Back"
        '
        'BtnNext_1
        '
        Me.BtnNext_1.AutoSize = True
        Me.BtnNext_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNext_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext_1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BtnNext_1.Location = New System.Drawing.Point(253, 107)
        Me.BtnNext_1.Name = "BtnNext_1"
        Me.BtnNext_1.Size = New System.Drawing.Size(36, 17)
        Me.BtnNext_1.TabIndex = 1
        Me.BtnNext_1.Text = "Next"
        '
        'lblTask_1
        '
        Me.lblTask_1.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTask_1.ForeColor = System.Drawing.Color.White
        Me.lblTask_1.Location = New System.Drawing.Point(13, 13)
        Me.lblTask_1.Name = "lblTask_1"
        Me.lblTask_1.Size = New System.Drawing.Size(242, 90)
        Me.lblTask_1.TabIndex = 0
        Me.lblTask_1.Text = "Lorem Ipsum Lorem Ipsum sit dolor amet, lorem ipsum, lorem smet sit dolor amet, l" &
    "orem ipsum, lorem smet"
        '
        'PnTask_2
        '
        Me.PnTask_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnTask_2.Controls.Add(Me.important_2)
        Me.PnTask_2.Controls.Add(Me.Btn_delete2)
        Me.PnTask_2.Controls.Add(Me.BtnBack_2)
        Me.PnTask_2.Controls.Add(Me.BtnNext_2)
        Me.PnTask_2.Controls.Add(Me.lblTask_2)
        Me.PnTask_2.Location = New System.Drawing.Point(8, 156)
        Me.PnTask_2.Margin = New System.Windows.Forms.Padding(8, 8, 8, 5)
        Me.PnTask_2.Name = "PnTask_2"
        Me.PnTask_2.Size = New System.Drawing.Size(301, 135)
        Me.PnTask_2.TabIndex = 1
        Me.PnTask_2.Visible = False
        '
        'Btn_delete2
        '
        Me.Btn_delete2.AutoSize = True
        Me.Btn_delete2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_delete2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_delete2.ForeColor = System.Drawing.Color.DeepPink
        Me.Btn_delete2.Location = New System.Drawing.Point(15, 106)
        Me.Btn_delete2.Name = "Btn_delete2"
        Me.Btn_delete2.Size = New System.Drawing.Size(49, 17)
        Me.Btn_delete2.TabIndex = 4
        Me.Btn_delete2.Text = "Delete"
        '
        'BtnBack_2
        '
        Me.BtnBack_2.AutoSize = True
        Me.BtnBack_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBack_2.Enabled = False
        Me.BtnBack_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack_2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BtnBack_2.Location = New System.Drawing.Point(206, 106)
        Me.BtnBack_2.Name = "BtnBack_2"
        Me.BtnBack_2.Size = New System.Drawing.Size(39, 17)
        Me.BtnBack_2.TabIndex = 2
        Me.BtnBack_2.Text = "Back"
        '
        'BtnNext_2
        '
        Me.BtnNext_2.AutoSize = True
        Me.BtnNext_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNext_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext_2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BtnNext_2.Location = New System.Drawing.Point(250, 106)
        Me.BtnNext_2.Name = "BtnNext_2"
        Me.BtnNext_2.Size = New System.Drawing.Size(36, 17)
        Me.BtnNext_2.TabIndex = 1
        Me.BtnNext_2.Text = "Next"
        '
        'lblTask_2
        '
        Me.lblTask_2.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTask_2.ForeColor = System.Drawing.Color.White
        Me.lblTask_2.Location = New System.Drawing.Point(13, 13)
        Me.lblTask_2.Name = "lblTask_2"
        Me.lblTask_2.Size = New System.Drawing.Size(248, 79)
        Me.lblTask_2.TabIndex = 0
        Me.lblTask_2.Text = "Lorem Ipsum Lorem Ipsum sit dolor amet, lorem ipsum, lorem smet sit dolor amet, l" &
    "orem ipsum, lorem smet"
        '
        'PnTask_3
        '
        Me.PnTask_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnTask_3.Controls.Add(Me.important_3)
        Me.PnTask_3.Controls.Add(Me.Btn_delete3)
        Me.PnTask_3.Controls.Add(Me.BtnBack_3)
        Me.PnTask_3.Controls.Add(Me.BtnNext_3)
        Me.PnTask_3.Controls.Add(Me.lblTask_3)
        Me.PnTask_3.Location = New System.Drawing.Point(8, 304)
        Me.PnTask_3.Margin = New System.Windows.Forms.Padding(8)
        Me.PnTask_3.Name = "PnTask_3"
        Me.PnTask_3.Size = New System.Drawing.Size(301, 135)
        Me.PnTask_3.TabIndex = 2
        Me.PnTask_3.Visible = False
        '
        'Btn_delete3
        '
        Me.Btn_delete3.AutoSize = True
        Me.Btn_delete3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_delete3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_delete3.ForeColor = System.Drawing.Color.DeepPink
        Me.Btn_delete3.Location = New System.Drawing.Point(15, 104)
        Me.Btn_delete3.Name = "Btn_delete3"
        Me.Btn_delete3.Size = New System.Drawing.Size(49, 17)
        Me.Btn_delete3.TabIndex = 5
        Me.Btn_delete3.Text = "Delete"
        '
        'BtnBack_3
        '
        Me.BtnBack_3.AutoSize = True
        Me.BtnBack_3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBack_3.Enabled = False
        Me.BtnBack_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack_3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BtnBack_3.Location = New System.Drawing.Point(206, 104)
        Me.BtnBack_3.Name = "BtnBack_3"
        Me.BtnBack_3.Size = New System.Drawing.Size(39, 17)
        Me.BtnBack_3.TabIndex = 2
        Me.BtnBack_3.Text = "Back"
        '
        'BtnNext_3
        '
        Me.BtnNext_3.AutoSize = True
        Me.BtnNext_3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNext_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext_3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BtnNext_3.Location = New System.Drawing.Point(250, 104)
        Me.BtnNext_3.Name = "BtnNext_3"
        Me.BtnNext_3.Size = New System.Drawing.Size(36, 17)
        Me.BtnNext_3.TabIndex = 1
        Me.BtnNext_3.Text = "Next"
        '
        'lblTask_3
        '
        Me.lblTask_3.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTask_3.ForeColor = System.Drawing.Color.White
        Me.lblTask_3.Location = New System.Drawing.Point(13, 13)
        Me.lblTask_3.Name = "lblTask_3"
        Me.lblTask_3.Size = New System.Drawing.Size(248, 79)
        Me.lblTask_3.TabIndex = 0
        Me.lblTask_3.Text = "Lorem Ipsum sit dolor amet, lorem ipsum, lorem Lorem Ipsum sit dolor amet, lorem " &
    "ipsum, lorem smet smet"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(406, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 30)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "A Fazer"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(94, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 30)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Escrever"
        '
        'lbl_countToDo2
        '
        Me.lbl_countToDo2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_countToDo2.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbl_countToDo2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_countToDo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_countToDo2.ForeColor = System.Drawing.Color.White
        Me.lbl_countToDo2.Location = New System.Drawing.Point(896, 224)
        Me.lbl_countToDo2.Name = "lbl_countToDo2"
        Me.lbl_countToDo2.Size = New System.Drawing.Size(25, 25)
        Me.lbl_countToDo2.TabIndex = 45
        Me.lbl_countToDo2.Text = "-"
        Me.lbl_countToDo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Rtx_Task
        '
        Me.Rtx_Task.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Rtx_Task.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Rtx_Task.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Rtx_Task.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rtx_Task.ForeColor = System.Drawing.Color.White
        Me.Rtx_Task.Location = New System.Drawing.Point(99, 272)
        Me.Rtx_Task.Name = "Rtx_Task"
        Me.Rtx_Task.Size = New System.Drawing.Size(204, 80)
        Me.Rtx_Task.TabIndex = 38
        Me.Rtx_Task.Text = ""
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(1085, 273)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(322, 447)
        Me.FlowLayoutPanel3.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1080, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 30)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Concluído"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(748, 273)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(322, 447)
        Me.FlowLayoutPanel2.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(743, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 30)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Em Progresso"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = Global.Taskr.My.Resources.Resources.gear
        Me.PictureBox2.Location = New System.Drawing.Point(266, 681)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(38, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 63
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Taskr.My.Resources.Resources.light_bulb
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(99, 681)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(5)
        Me.Button1.Size = New System.Drawing.Size(161, 39)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "    Light Mode"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Taskr.My.Resources.Resources.filter
        Me.PictureBox1.Location = New System.Drawing.Point(1269, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'pic_Desempenho
        '
        Me.pic_Desempenho.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pic_Desempenho.Image = Global.Taskr.My.Resources.Resources.down
        Me.pic_Desempenho.Location = New System.Drawing.Point(278, 641)
        Me.pic_Desempenho.Name = "pic_Desempenho"
        Me.pic_Desempenho.Size = New System.Drawing.Size(25, 25)
        Me.pic_Desempenho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Desempenho.TabIndex = 57
        Me.pic_Desempenho.TabStop = False
        '
        'AfriCircleImage1
        '
        Me.AfriCircleImage1.BackColor = System.Drawing.Color.DodgerBlue
        Me.AfriCircleImage1.Location = New System.Drawing.Point(99, 47)
        Me.AfriCircleImage1.Name = "AfriCircleImage1"
        Me.AfriCircleImage1.Size = New System.Drawing.Size(50, 50)
        Me.AfriCircleImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AfriCircleImage1.TabIndex = 48
        Me.AfriCircleImage1.TabStop = False
        '
        'important_1
        '
        Me.important_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.important_1.BackColor = System.Drawing.Color.Silver
        Me.important_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.important_1.Location = New System.Drawing.Point(264, 13)
        Me.important_1.Name = "important_1"
        Me.important_1.Size = New System.Drawing.Size(25, 25)
        Me.important_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.important_1.TabIndex = 14
        Me.important_1.TabStop = False
        '
        'important_2
        '
        Me.important_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.important_2.BackColor = System.Drawing.Color.Silver
        Me.important_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.important_2.Location = New System.Drawing.Point(264, 13)
        Me.important_2.Name = "important_2"
        Me.important_2.Size = New System.Drawing.Size(25, 25)
        Me.important_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.important_2.TabIndex = 15
        Me.important_2.TabStop = False
        '
        'important_3
        '
        Me.important_3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.important_3.BackColor = System.Drawing.Color.Silver
        Me.important_3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.important_3.Location = New System.Drawing.Point(264, 13)
        Me.important_3.Name = "important_3"
        Me.important_3.Size = New System.Drawing.Size(25, 25)
        Me.important_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.important_3.TabIndex = 16
        Me.important_3.TabStop = False
        '
        'BlackMode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1501, 758)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btn_createTaskk)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lbl_TaskPointer)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_Pomodoro)
        Me.Controls.Add(Me.Btn_Pomodoro)
        Me.Controls.Add(Me.lbl_Desempenho)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.pic_Desempenho)
        Me.Controls.Add(Me.AfriCircleImage1)
        Me.Controls.Add(Me.lbl_countToDo3)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_countToDo2)
        Me.Controls.Add(Me.Rtx_Task)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.Label3)
        Me.Name = "BlackMode"
        Me.Text = "BlackMode"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.PnTask_1.ResumeLayout(False)
        Me.PnTask_1.PerformLayout()
        Me.PnTask_2.ResumeLayout(False)
        Me.PnTask_2.PerformLayout()
        Me.PnTask_3.ResumeLayout(False)
        Me.PnTask_3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Desempenho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AfriCircleImage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.important_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.important_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.important_3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents important_2 As AfriCircleImage.AfriCircleImage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_TasksConcluidas As Label
    Friend WithEvents Btn_createTaskk As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_TasksExcluidas As Label
    Friend WithEvents lbl_TaskPointer As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_Pomodoro As Label
    Friend WithEvents Btn_Pomodoro As Button
    Friend WithEvents lbl_Desempenho As Label
    Friend WithEvents Pomodoro As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents pic_Desempenho As PictureBox
    Friend WithEvents AfriCircleImage1 As AfriCircleImage.AfriCircleImage
    Friend WithEvents important_1 As AfriCircleImage.AfriCircleImage
    Friend WithEvents important_3 As AfriCircleImage.AfriCircleImage
    Friend WithEvents lbl_countToDo3 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PnTask_1 As Panel
    Friend WithEvents btn_delete1 As Label
    Friend WithEvents BtnBack_1 As Label
    Friend WithEvents BtnNext_1 As Label
    Friend WithEvents lblTask_1 As Label
    Friend WithEvents PnTask_2 As Panel
    Friend WithEvents Btn_delete2 As Label
    Friend WithEvents BtnBack_2 As Label
    Friend WithEvents BtnNext_2 As Label
    Friend WithEvents lblTask_2 As Label
    Friend WithEvents PnTask_3 As Panel
    Friend WithEvents Btn_delete3 As Label
    Friend WithEvents BtnBack_3 As Label
    Friend WithEvents BtnNext_3 As Label
    Friend WithEvents lblTask_3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_countToDo2 As Label
    Friend WithEvents Rtx_Task As RichTextBox
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
