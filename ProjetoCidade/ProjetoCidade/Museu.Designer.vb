<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Museu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Museu))
        Me.lbPergunta = New System.Windows.Forms.Label()
        Me.bStart = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.bContinuar = New System.Windows.Forms.Button()
        Me.quadro = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JogarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FecharToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.quadro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbPergunta
        '
        Me.lbPergunta.AutoSize = True
        Me.lbPergunta.BackColor = System.Drawing.Color.Transparent
        Me.lbPergunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPergunta.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbPergunta.Location = New System.Drawing.Point(423, 129)
        Me.lbPergunta.Name = "lbPergunta"
        Me.lbPergunta.Size = New System.Drawing.Size(178, 24)
        Me.lbPergunta.TabIndex = 1
        Me.lbPergunta.Text = "Que quadro é este?"
        Me.lbPergunta.Visible = False
        '
        'bStart
        '
        Me.bStart.BackColor = System.Drawing.Color.Transparent
        Me.bStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bStart.FlatAppearance.BorderSize = 0
        Me.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bStart.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.bStart.Location = New System.Drawing.Point(391, 198)
        Me.bStart.Name = "bStart"
        Me.bStart.Size = New System.Drawing.Size(248, 272)
        Me.bStart.TabIndex = 2
        Me.bStart.Text = "Começar"
        Me.bStart.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RadioButton1.Location = New System.Drawing.Point(12, 220)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = False
        Me.RadioButton1.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RadioButton2.Location = New System.Drawing.Point(12, 291)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = False
        Me.RadioButton2.Visible = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RadioButton3.Location = New System.Drawing.Point(733, 220)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton3.TabIndex = 5
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = False
        Me.RadioButton3.Visible = False
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RadioButton4.Location = New System.Drawing.Point(733, 291)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton4.TabIndex = 6
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = False
        Me.RadioButton4.Visible = False
        '
        'bContinuar
        '
        Me.bContinuar.BackColor = System.Drawing.Color.Transparent
        Me.bContinuar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bContinuar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bContinuar.ForeColor = System.Drawing.SystemColors.Control
        Me.bContinuar.Location = New System.Drawing.Point(427, 555)
        Me.bContinuar.Name = "bContinuar"
        Me.bContinuar.Size = New System.Drawing.Size(174, 45)
        Me.bContinuar.TabIndex = 7
        Me.bContinuar.Text = "Continuar"
        Me.bContinuar.UseVisualStyleBackColor = False
        Me.bContinuar.Visible = False
        '
        'quadro
        '
        Me.quadro.BackColor = System.Drawing.Color.Transparent
        Me.quadro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.quadro.Image = Global.MyArtsPal.My.Resources.Resources._1
        Me.quadro.Location = New System.Drawing.Point(391, 198)
        Me.quadro.Name = "quadro"
        Me.quadro.Size = New System.Drawing.Size(246, 272)
        Me.quadro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.quadro.TabIndex = 8
        Me.quadro.TabStop = False
        Me.quadro.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XToolStripMenuItem, Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1024, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'XToolStripMenuItem
        '
        Me.XToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.XToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.XToolStripMenuItem.Name = "XToolStripMenuItem"
        Me.XToolStripMenuItem.Size = New System.Drawing.Size(26, 20)
        Me.XToolStripMenuItem.Text = "X"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JogarToolStripMenuItem, Me.FecharToolStripMenuItem})
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'JogarToolStripMenuItem
        '
        Me.JogarToolStripMenuItem.Name = "JogarToolStripMenuItem"
        Me.JogarToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.JogarToolStripMenuItem.Text = "Jogar"
        '
        'FecharToolStripMenuItem
        '
        Me.FecharToolStripMenuItem.Name = "FecharToolStripMenuItem"
        Me.FecharToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.FecharToolStripMenuItem.Text = "Sair"
        '
        'Museu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MyArtsPal.My.Resources.Resources.Background_2
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.quadro)
        Me.Controls.Add(Me.bContinuar)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.bStart)
        Me.Controls.Add(Me.lbPergunta)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Museu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Museu — Quiz"
        CType(Me.quadro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbPergunta As System.Windows.Forms.Label
    Friend WithEvents bStart As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents bContinuar As System.Windows.Forms.Button
    Friend WithEvents quadro As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JogarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FecharToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
