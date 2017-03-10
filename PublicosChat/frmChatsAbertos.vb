Public Class frmChatsAbertos
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim nomeChat, C As String
        C = ComboBox1.SelectedItem.ToString()
        nomeChat = C.Substring(0, C.Length - 4)

        Form1.criarSala(nomeChat)
        Me.Close()
    End Sub

    Private Sub frmChatsAbertos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        atualizarLista()
    End Sub

    Private Sub btnAtualizarLista_Click(sender As Object, e As EventArgs) Handles btnAtualizarLista.Click
        atualizarLista()
    End Sub

    Public Function atualizarLista()
        ComboBox1.Items.Clear()

        Dim di As New IO.DirectoryInfo("P:\Speaker")
        Dim diar1 As IO.FileInfo() = di.GetFiles()
        Dim dra As IO.FileInfo
        For Each dra In diar1
            ComboBox1.Items.Add(dra)
        Next


    End Function

End Class