Imports System.Security
Imports System.IO
Imports System.Text

Public Class Form1
    Public flagExiteChat As Boolean
    Public caminho, usuario As String
    Dim Leitor As System.IO.FileInfo
    Dim infoReader As System.IO.FileInfo
    Public Teste As Date

    Private Sub btnCriarSala_Click(sender As Object, e As EventArgs) Handles btnCriarSala.Click
        Dim nomeNovoChat = InputBox("Digite o nome da nova sala: ", "Nova Sala")
        criarSala(nomeNovoChat)
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        sendMessage()
    End Sub

    Private Sub btnEntrarSala_Click(sender As Object, e As EventArgs) Handles btnEntrarSala.Click
        frmChatsAbertos.Show()
    End Sub

    Private Sub txtMensagem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMensagem.KeyDown
        If e.KeyCode = Keys.Enter Then
            sendMessage()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (flagExiteChat = True) Then
            Using sr As StreamReader = File.OpenText(caminho)
                txtChat.Text = sr.ReadToEnd
                infoReader = My.Computer.FileSystem.GetFileInfo(caminho)

                If (Teste = infoReader.LastWriteTime) Then
                    txtChat.Text = txtChat.Text & Chr(13) & Chr(10)
                    txtChat.SelectionStart = 10
                Else
                    Teste = infoReader.LastWriteTime
                End If
            End Using
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flagExiteChat = False
        usuario = InputBox("Digite seu usuário: ", "Usuário")

    End Sub

    Private Sub txtMensagem_TextChanged(sender As Object, e As EventArgs) Handles txtMensagem.TextChanged

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


    Private Function sendMessage()
        If (File.Exists(caminho)) Then
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
    End Function

End Class
