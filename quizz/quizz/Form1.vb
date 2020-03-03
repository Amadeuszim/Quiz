Public Class Form1

    Public certo As Integer
    Public errado As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnver1_Click(sender As Object, e As EventArgs) Handles btnver1.Click
        btnver1.Enabled = False
        btnfalso1.Enabled = False
        errado = errado + 1
    End Sub

    Private Sub btnfalso1_Click(sender As Object, e As EventArgs) Handles btnfalso1.Click
        btnver1.Enabled = False
        btnfalso1.Enabled = False
        certo = certo + 1
    End Sub

    Private Sub btnver2_Click(sender As Object, e As EventArgs) Handles btnver2.Click
        btnver2.Enabled = False
        btnfalso2.Enabled = False
        errado = errado + 1
    End Sub

    Private Sub btnfalso2_Click(sender As Object, e As EventArgs) Handles btnfalso2.Click
        btnver2.Enabled = False
        btnfalso2.Enabled = False
        certo = certo + 1
    End Sub

    Private Sub btnver3_Click(sender As Object, e As EventArgs) Handles btnver3.Click
        btnver3.Enabled = False
        btnfalso3.Enabled = False
        certo = certo + 1
    End Sub

    Private Sub btnfalso3_Click(sender As Object, e As EventArgs) Handles btnfalso3.Click
        btnver3.Enabled = False
        btnfalso3.Enabled = False
        errado = errado + 1
    End Sub

    Private Sub btnver4_Click(sender As Object, e As EventArgs) Handles btnver4.Click
        btnver4.Enabled = False
        btnfalso4.Enabled = False
        errado = errado + 1
    End Sub

    Private Sub btnfalso4_Click(sender As Object, e As EventArgs) Handles btnfalso4.Click
        btnver4.Enabled = False
        btnfalso4.Enabled = False
        certo = certo + 1
    End Sub

    Private Sub btnver5_Click(sender As Object, e As EventArgs) Handles btnver5.Click
        btnver5.Enabled = False
        btnfalso5.Enabled = False
        certo = certo + 1
    End Sub

    Private Sub btnfalso5_Click(sender As Object, e As EventArgs) Handles btnfalso5.Click
        btnver5.Enabled = False
        btnfalso5.Enabled = False
        errado = errado + 1
    End Sub

    Private Sub btnver6_Click(sender As Object, e As EventArgs) Handles btnver6.Click
        btnver6.Enabled = False
        btnfalso6.Enabled = False
        certo = certo + 1
    End Sub

    Private Sub btnfalso6_Click(sender As Object, e As EventArgs) Handles btnfalso6.Click
        btnver6.Enabled = False
        btnfalso6.Enabled = False
        errado = errado + 1
    End Sub

    Private Sub btnver7_Click(sender As Object, e As EventArgs) Handles btnver7.Click
        btnver7.Enabled = False
        btnfalso7.Enabled = False
        certo = certo + 1
    End Sub

    Private Sub btnfalso7_Click(sender As Object, e As EventArgs) Handles btnfalso7.Click
        btnver7.Enabled = False
        btnfalso7.Enabled = False
        errado = errado + 1
    End Sub

    Private Sub btnver8_Click(sender As Object, e As EventArgs) Handles btnver8.Click
        btnver8.Enabled = False
        btnfalso8.Enabled = False
        errado = errado + 1
    End Sub

    Private Sub btnfalso8_Click(sender As Object, e As EventArgs) Handles btnfalso8.Click
        btnver8.Enabled = False
        btnfalso8.Enabled = False
        certo = certo + 1
    End Sub

    Private Sub btnver9_Click(sender As Object, e As EventArgs) Handles btnver9.Click
        btnver9.Enabled = False
        btnfalso9.Enabled = False
        certo = certo + 1
    End Sub

    Private Sub btnfalso9_Click(sender As Object, e As EventArgs) Handles btnfalso9.Click
        btnver9.Enabled = False
        btnfalso9.Enabled = False
        errado = errado + 1
    End Sub

    Private Sub btnver10_Click(sender As Object, e As EventArgs) Handles btnver10.Click
        btnver10.Enabled = False
        btnfalso10.Enabled = False
        errado = errado + 1
    End Sub

    Private Sub btnfalso10_Click(sender As Object, e As EventArgs) Handles btnfalso10.Click
        btnver10.Enabled = False
        btnfalso10.Enabled = False
        certo = certo + 1
    End Sub

    Private Sub btniniciar_Click(sender As Object, e As EventArgs) Handles btniniciar.Click
        btnfalso1.Enabled = True
        btnfalso2.Enabled = True
        btnfalso3.Enabled = True
        btnfalso4.Enabled = True
        btnfalso5.Enabled = True
        btnfalso6.Enabled = True
        btnfalso7.Enabled = True
        btnfalso8.Enabled = True
        btnfalso9.Enabled = True
        btnfalso10.Enabled = True
        btnver1.Enabled = True
        btnver2.Enabled = True
        btnver3.Enabled = True
        btnver4.Enabled = True
        btnver5.Enabled = True
        btnver6.Enabled = True
        btnver7.Enabled = True
        btnver8.Enabled = True
        btnver9.Enabled = True
        btnver10.Enabled = True
        btnresposta.Enabled = True
        btniniciar.Enabled = False
        Timer1.Enabled = True

    End Sub

    Private Sub btnresposta_Click(sender As Object, e As EventArgs) Handles btnresposta.Click
        lblcerto.Text = CStr(certo)
        lblerrado.Text = CStr(errado)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnfalso1.Enabled = True
            btnfalso2.Enabled = True
            btnfalso3.Enabled = True
            btnfalso4.Enabled = True
            btnfalso5.Enabled = True
            btnfalso6.Enabled = True
            btnfalso7.Enabled = True
            btnfalso8.Enabled = True
            btnfalso9.Enabled = True
            btnfalso10.Enabled = True
            btnver1.Enabled = True
            btnver2.Enabled = True
            btnver3.Enabled = True
            btnver4.Enabled = True
            btnver5.Enabled = True
            btnver6.Enabled = True
            btnver7.Enabled = True
            btnver8.Enabled = True
            btnver9.Enabled = True
            btnver10.Enabled = True
            btniniciar.Enabled = False
        End If

        If e.KeyCode = Keys.F3 Then btnresposta.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Timer1.Interval = 5000 Then
            MsgBox("O tempo acabou")
            Me.Close()
        End If

    End Sub
End Class
