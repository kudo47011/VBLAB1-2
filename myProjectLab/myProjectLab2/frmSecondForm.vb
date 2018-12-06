Public Class frmSecondForm
    Private Sub frmSecondForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim vistra, computer, total1, com1, com2, total2 As Integer

        vistra = Val(txtVistra.Text)
        computer = Val(txtComputer.Text)
        total1 = vistra + computer

        com1 = vistra * 0.05
        com2 = computer * 0.1
        total2 = com1 + com2

        lblTotal1.Text = total1
        lblTotal2.Text = total2
        lblCom1.Text = com1
        lblCom2.Text = com2

    End Sub
End Class
