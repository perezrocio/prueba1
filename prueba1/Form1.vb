Public Class Form1

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles tpe.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim he As Integer
        Dim turno As Integer
        Dim pxh As Integer
        Dim pe As Integer
        Dim tp As Integer
        Dim sb As Integer
        turno = cbturno.SelectedIndex + 1
        he = Convert.ToInt32(thrse.Text)
        sb = Convert.ToInt32(tsb.Text)
        If (turno = 1) Then
            pxh = 120
        ElseIf (turno = 2) Then
            pxh = 150
        ElseIf (turno = 3) Then
            pxh = 180
        End If
        tp = sb + pe
        pe = he * pxh


        tpxh.Text = pxh.ToString()
        tpe.Text = pe.ToString()
        ttp.Text = tp.ToString()
        tsb.Text = sb.ToString()
        thrse.Text = he.ToString()

    End Sub
End Class
