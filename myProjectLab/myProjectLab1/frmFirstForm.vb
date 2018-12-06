Public Class frmFirstForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCal.Click

        lblTotal.Text = Val(txtSalary.Text) * 12

        lblTax.Text = Val(lblTotal.Text) * 0.05

        lbltotalFinal.Text = lblTotal.Text - lblTax.Text
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class
