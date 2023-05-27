Public Class Form1
    Dim students(100) As student

    Dim Acounter As Integer = 0
    Dim ncounter As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        students(Acounter) = New student
        students(Acounter).firstname = Txt1.Text
        students(Acounter).lastname = Txt2.Text
        Acounter += 1



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        students(Acounter).notes(ncounter) = New note
        students(Acounter).notes(ncounter).note = CInt(Txt3.Text)
        ncounter += 1
        Txt3.Clear()


    End Sub
End Class
