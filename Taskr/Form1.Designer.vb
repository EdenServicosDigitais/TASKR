<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PnTask_1 = New System.Windows.Forms.Panel()
        Me.important_1 = New AfriCircleImage.AfriCircleImage()
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
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Rtx_Task = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_countToDo2 = New System.Windows.Forms.Label()
        Me.lbl_countToDo3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AfriCircleImage1 = New AfriCircleImage.AfriCircleImage()
        Me.Btn_createTaskk = New System.Windows.Forms.Button()
        Me.important_2 = New AfriCircleImage.AfriCircleImage()
        Me.important_3 = New AfriCircleImage.AfriCircleImage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.AfriCircleImage2 = New AfriCircleImage.AfriCircleImage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.PnTask_1.SuspendLayout()
        CType(Me.important_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnTask_2.SuspendLayout()
        Me.PnTask_3.SuspendLayout()
        CType(Me.AfriCircleImage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.important_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.important_3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.AfriCircleImage2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Adicionar"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(296, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "A Fazer"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FlowLayoutPanel1.Controls.Add(Me.PnTask_1)
        Me.FlowLayoutPanel1.Controls.Add(Me.PnTask_2)
        Me.FlowLayoutPanel1.Controls.Add(Me.PnTask_3)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(301, 208)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(322, 447)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'PnTask_1
        '
        Me.PnTask_1.BackColor = System.Drawing.Color.White
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
        'important_1
        '
        Me.important_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.important_1.BackColor = System.Drawing.Color.Silver
        Me.important_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.important_1.Location = New System.Drawing.Point(261, 13)
        Me.important_1.Name = "important_1"
        Me.important_1.Size = New System.Drawing.Size(25, 25)
        Me.important_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.important_1.TabIndex = 14
        Me.important_1.TabStop = False
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
        Me.lblTask_1.Location = New System.Drawing.Point(13, 13)
        Me.lblTask_1.Name = "lblTask_1"
        Me.lblTask_1.Size = New System.Drawing.Size(242, 90)
        Me.lblTask_1.TabIndex = 0
        Me.lblTask_1.Text = "Lorem Ipsum Lorem Ipsum sit dolor amet, lorem ipsum, lorem smet sit dolor amet, l" &
    "orem ipsum, lorem smet"
        '
        'PnTask_2
        '
        Me.PnTask_2.BackColor = System.Drawing.Color.White
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
        Me.lblTask_2.Location = New System.Drawing.Point(13, 13)
        Me.lblTask_2.Name = "lblTask_2"
        Me.lblTask_2.Size = New System.Drawing.Size(248, 79)
        Me.lblTask_2.TabIndex = 0
        Me.lblTask_2.Text = "Lorem Ipsum Lorem Ipsum sit dolor amet, lorem ipsum, lorem smet sit dolor amet, l" &
    "orem ipsum, lorem smet"
        '
        'PnTask_3
        '
        Me.PnTask_3.BackColor = System.Drawing.Color.White
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
        Me.lblTask_3.Location = New System.Drawing.Point(13, 13)
        Me.lblTask_3.Name = "lblTask_3"
        Me.lblTask_3.Size = New System.Drawing.Size(248, 79)
        Me.lblTask_3.TabIndex = 0
        Me.lblTask_3.Text = "Lorem Ipsum sit dolor amet, lorem ipsum, lorem Lorem Ipsum sit dolor amet, lorem " &
    "ipsum, lorem smet smet"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(638, 208)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(322, 447)
        Me.FlowLayoutPanel2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(633, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Em Progresso"
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(975, 208)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(322, 447)
        Me.FlowLayoutPanel3.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(970, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 30)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Concluído"
        '
        'Rtx_Task
        '
        Me.Rtx_Task.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Rtx_Task.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Rtx_Task.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Rtx_Task.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rtx_Task.Location = New System.Drawing.Point(41, 208)
        Me.Rtx_Task.Name = "Rtx_Task"
        Me.Rtx_Task.Size = New System.Drawing.Size(204, 80)
        Me.Rtx_Task.TabIndex = 1
        Me.Rtx_Task.Text = ""
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lbl_countToDo2
        '
        Me.lbl_countToDo2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_countToDo2.AutoSize = True
        Me.lbl_countToDo2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_countToDo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_countToDo2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_countToDo2.Location = New System.Drawing.Point(774, 137)
        Me.lbl_countToDo2.Name = "lbl_countToDo2"
        Me.lbl_countToDo2.Size = New System.Drawing.Size(19, 20)
        Me.lbl_countToDo2.TabIndex = 10
        Me.lbl_countToDo2.Text = "--"
        '
        'lbl_countToDo3
        '
        Me.lbl_countToDo3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_countToDo3.AutoSize = True
        Me.lbl_countToDo3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_countToDo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_countToDo3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_countToDo3.Location = New System.Drawing.Point(1083, 137)
        Me.lbl_countToDo3.Name = "lbl_countToDo3"
        Me.lbl_countToDo3.Size = New System.Drawing.Size(19, 20)
        Me.lbl_countToDo3.TabIndex = 11
        Me.lbl_countToDo3.Text = "--"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(1122, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 37)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Thomas"
        '
        'AfriCircleImage1
        '
        Me.AfriCircleImage1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AfriCircleImage1.BackColor = System.Drawing.Color.SpringGreen
        Me.AfriCircleImage1.Image = CType(resources.GetObject("AfriCircleImage1.Image"), System.Drawing.Image)
        Me.AfriCircleImage1.Location = New System.Drawing.Point(1260, 21)
        Me.AfriCircleImage1.Name = "AfriCircleImage1"
        Me.AfriCircleImage1.Size = New System.Drawing.Size(50, 50)
        Me.AfriCircleImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AfriCircleImage1.TabIndex = 13
        Me.AfriCircleImage1.TabStop = False
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
        Me.Btn_createTaskk.Location = New System.Drawing.Point(41, 299)
        Me.Btn_createTaskk.Name = "Btn_createTaskk"
        Me.Btn_createTaskk.Size = New System.Drawing.Size(204, 52)
        Me.Btn_createTaskk.TabIndex = 14
        Me.Btn_createTaskk.Text = "Criar tarefa +"
        Me.Btn_createTaskk.UseVisualStyleBackColor = False
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
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(41, 377)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(204, 92)
        Me.Panel1.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(75, 90)
        Me.Panel2.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 90)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "00"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(86, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 54)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Tarefas concluídas"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(1129, 84)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(119, 10)
        Me.ProgressBar1.TabIndex = 16
        Me.ProgressBar1.Value = 40
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1256, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Nível 0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(46, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 21)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "26"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(92, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 21)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Novembro"
        '
        'AfriCircleImage2
        '
        Me.AfriCircleImage2.BackColor = System.Drawing.Color.DodgerBlue
        Me.AfriCircleImage2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AfriCircleImage2.Location = New System.Drawing.Point(76, 53)
        Me.AfriCircleImage2.Name = "AfriCircleImage2"
        Me.AfriCircleImage2.Size = New System.Drawing.Size(10, 10)
        Me.AfriCircleImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AfriCircleImage2.TabIndex = 21
        Me.AfriCircleImage2.TabStop = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(1130, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 19)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "unstopable"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1340, 695)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.AfriCircleImage2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btn_createTaskk)
        Me.Controls.Add(Me.AfriCircleImage1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_countToDo3)
        Me.Controls.Add(Me.lbl_countToDo2)
        Me.Controls.Add(Me.Rtx_Task)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.PnTask_1.ResumeLayout(False)
        Me.PnTask_1.PerformLayout()
        CType(Me.important_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnTask_2.ResumeLayout(False)
        Me.PnTask_2.PerformLayout()
        Me.PnTask_3.ResumeLayout(False)
        Me.PnTask_3.PerformLayout()
        CType(Me.AfriCircleImage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.important_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.important_3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.AfriCircleImage2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PnTask_1 As Panel
    Friend WithEvents BtnBack_1 As Label
    Friend WithEvents BtnNext_1 As Label
    Friend WithEvents lblTask_1 As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Rtx_Task As RichTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PnTask_2 As Panel
    Friend WithEvents BtnBack_2 As Label
    Friend WithEvents BtnNext_2 As Label
    Friend WithEvents lblTask_2 As Label
    Friend WithEvents PnTask_3 As Panel
    Friend WithEvents BtnBack_3 As Label
    Friend WithEvents BtnNext_3 As Label
    Friend WithEvents lblTask_3 As Label
    Friend WithEvents lbl_countToDo2 As Label
    Friend WithEvents lbl_countToDo3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents AfriCircleImage1 As AfriCircleImage.AfriCircleImage
    Friend WithEvents btn_delete1 As Label
    Friend WithEvents Btn_delete2 As Label
    Friend WithEvents Btn_delete3 As Label
    Friend WithEvents important_1 As AfriCircleImage.AfriCircleImage
    Friend WithEvents Btn_createTaskk As Button
    Friend WithEvents important_2 As AfriCircleImage.AfriCircleImage
    Friend WithEvents important_3 As AfriCircleImage.AfriCircleImage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents AfriCircleImage2 As AfriCircleImage.AfriCircleImage
    Friend WithEvents Label11 As Label
End Class
