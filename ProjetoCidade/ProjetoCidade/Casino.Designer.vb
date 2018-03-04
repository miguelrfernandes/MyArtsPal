<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Casino
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Casino))
        Me.bSpaceInvaders = New System.Windows.Forms.Button()
        Me.bRoleta = New System.Windows.Forms.Button()
        Me.bVoltar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bSpaceInvaders
        '
        Me.bSpaceInvaders.Location = New System.Drawing.Point(197, 63)
        Me.bSpaceInvaders.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bSpaceInvaders.Name = "bSpaceInvaders"
        Me.bSpaceInvaders.Size = New System.Drawing.Size(117, 28)
        Me.bSpaceInvaders.TabIndex = 0
        Me.bSpaceInvaders.Text = "SpaceInvaders"
        Me.bSpaceInvaders.UseVisualStyleBackColor = True
        '
        'bRoleta
        '
        Me.bRoleta.Location = New System.Drawing.Point(67, 63)
        Me.bRoleta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bRoleta.Name = "bRoleta"
        Me.bRoleta.Size = New System.Drawing.Size(100, 28)
        Me.bRoleta.TabIndex = 1
        Me.bRoleta.Text = "Roleta"
        Me.bRoleta.UseVisualStyleBackColor = True
        '
        'bVoltar
        '
        Me.bVoltar.Location = New System.Drawing.Point(132, 217)
        Me.bVoltar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bVoltar.Name = "bVoltar"
        Me.bVoltar.Size = New System.Drawing.Size(100, 28)
        Me.bVoltar.TabIndex = 2
        Me.bVoltar.Text = "Voltar"
        Me.bVoltar.UseVisualStyleBackColor = True
        '
        'Casino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 897)
        Me.Controls.Add(Me.bVoltar)
        Me.Controls.Add(Me.bRoleta)
        Me.Controls.Add(Me.bSpaceInvaders)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Casino"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Casino"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bSpaceInvaders As System.Windows.Forms.Button
    Friend WithEvents bRoleta As System.Windows.Forms.Button
    Friend WithEvents bVoltar As System.Windows.Forms.Button
End Class
