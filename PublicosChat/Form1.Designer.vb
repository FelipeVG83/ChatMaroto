<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtChat = New System.Windows.Forms.TextBox()
        Me.txtMensagem = New System.Windows.Forms.TextBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.btnCriarSala = New System.Windows.Forms.Button()
        Me.btnEntrarSala = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtChat
        '
        Me.txtChat.Location = New System.Drawing.Point(12, 82)
        Me.txtChat.Multiline = True
        Me.txtChat.Name = "txtChat"
        Me.txtChat.ReadOnly = True
        Me.txtChat.Size = New System.Drawing.Size(664, 348)
        Me.txtChat.TabIndex = 0
        '
        'txtMensagem
        '
        Me.txtMensagem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtMensagem.Location = New System.Drawing.Point(12, 461)
        Me.txtMensagem.Name = "txtMensagem"
        Me.txtMensagem.Size = New System.Drawing.Size(517, 20)
        Me.txtMensagem.TabIndex = 1
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(535, 458)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(141, 23)
        Me.btnEnviar.TabIndex = 2
        Me.btnEnviar.Text = "ENVIAR"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'btnCriarSala
        '
        Me.btnCriarSala.Location = New System.Drawing.Point(12, 12)
        Me.btnCriarSala.Name = "btnCriarSala"
        Me.btnCriarSala.Size = New System.Drawing.Size(119, 31)
        Me.btnCriarSala.TabIndex = 3
        Me.btnCriarSala.Text = "CRIAR SALA"
        Me.btnCriarSala.UseVisualStyleBackColor = True
        '
        'btnEntrarSala
        '
        Me.btnEntrarSala.Location = New System.Drawing.Point(137, 12)
        Me.btnEntrarSala.Name = "btnEntrarSala"
        Me.btnEntrarSala.Size = New System.Drawing.Size(147, 31)
        Me.btnEntrarSala.TabIndex = 4
        Me.btnEntrarSala.Text = "ENTRAR EM UMA SALA"
        Me.btnEntrarSala.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 505)
        Me.Controls.Add(Me.btnEntrarSala)
        Me.Controls.Add(Me.btnCriarSala)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.txtMensagem)
        Me.Controls.Add(Me.txtChat)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtChat As TextBox
    Friend WithEvents txtMensagem As TextBox
    Friend WithEvents btnEnviar As Button
    Friend WithEvents btnCriarSala As Button
    Friend WithEvents btnEntrarSala As Button
    Friend WithEvents Timer1 As Timer
End Class
