Imports System.Security
Imports System.IO
Imports System.Text

Public Class Form1
    Public flagExiteChat As Boolean
    Public caminho, usuario As String

    Private Sub btnCriarSala_Click(sender As Object, e As EventArgs) Handles btnCriarSala.Click
        Dim nomeNovoChat = InputBox("Digite o nome da nova sala: ", "Nova Sala")
        criarSala(nomeNovoChat)
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click, txtMensagem.Enter, MyBase.Enter
        If (File.Exists(caminho) And txtMensagem.Text <> "") Then
            Using sw As StreamWriter = New StreamWriter(caminho, True)
                sw.WriteLine()
                sw.WriteLine(usuario + ": " + txtMensagem.Text)
            End Using
            Using sr As StreamReader = File.OpenText(caminho)
                txtChat.Text = sr.ReadToEnd
            End Using
            txtMensagem.Clear()
        Else
            MessageBox.Show("Arquivo não encontrado ", "Nome do arquivo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnEntrarSala_Click(sender As Object, e As EventArgs) Handles btnEntrarSala.Click
        frmChatsAbertos.Show()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (flagExiteChat = True) Then
            Using sr As StreamReader = File.OpenText(caminho)
                txtChat.Text = sr.ReadToEnd
            End Using
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flagExiteChat = False
        usuario = InputBox("Digite seu usuário: ", "Usuário")
    End Sub

    Public Function criarSala(ByVal nomeNovoChat As String)

        If (Not Directory.Exists("P:\Speaker\")) Then
            System.IO.Directory.CreateDirectory("P:\Speaker\")
        End If
        caminho = "P:\Speaker\" + nomeNovoChat + ".txt"

        If Not File.Exists(caminho) Then
            Using sw As FileStream = File.Create(caminho)
                Dim texto As Byte() = New UTF8Encoding(True).GetBytes(nomeNovoChat)
                sw.Write(texto, 0, texto.Length)
            End Using
            Using sr As StreamReader = File.OpenText(caminho)
                txtChat.Text = sr.ReadToEnd
            End Using
            flagExiteChat = True
        Else
            Using sr As StreamReader = File.OpenText(caminho)
                txtChat.Text = sr.ReadToEnd
            End Using
            flagExiteChat = True
        End If
    End Function

End Class
