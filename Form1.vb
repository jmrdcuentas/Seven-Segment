Public Class Form1
    Dim Second As Int32 = -1
    Dim format = New Integer(9, 6) {
            {1, 1, 1, 1, 1, 1, 0},
            {0, 1, 1, 0, 0, 0, 0},
            {1, 1, 0, 1, 1, 0, 1},
            {1, 1, 1, 1, 0, 0, 1},
            {0, 1, 1, 0, 0, 1, 1},
            {1, 0, 1, 1, 0, 1, 1},
            {1, 0, 1, 1, 1, 1, 1},
            {1, 1, 1, 0, 0, 0, 0},
            {1, 1, 1, 1, 1, 1, 1},
            {1, 1, 1, 1, 0, 1, 1}
        }
    Dim btns(6) As Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button7.Focus()

        For i As Integer = 0 To 6
            btns(i) = CType(Me.Controls("Button" & i), Button)
        Next

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Second = Second + 1

        For ind As Integer = 0 To 6
            If format(Second, ind) = 1 Then
                btns(ind).BackColor = Color.Red
            Else
                btns(ind).BackColor = Color.White
            End If
        Next

        If Second = 9 Then
            Second = -1
        End If
    End Sub
End Class