<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFirstForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lbltotalFinal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณรายได้ทั้งปี"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Aqua
        Me.Label2.Location = New System.Drawing.Point(24, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(323, 47)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "เงินเดือน"
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(422, 116)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(177, 47)
        Me.txtSalary.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Aqua
        Me.Label3.Location = New System.Drawing.Point(24, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(323, 47)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "รายได้ทั้งปี"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Aqua
        Me.Label4.Location = New System.Drawing.Point(24, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(323, 47)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ภาษีที่ต้องชำระ"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Aqua
        Me.lblTotal.Location = New System.Drawing.Point(422, 184)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(177, 47)
        Me.lblTotal.TabIndex = 1
        '
        'btnCal
        '
        Me.btnCal.Location = New System.Drawing.Point(148, 394)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(159, 68)
        Me.btnCal.TabIndex = 3
        Me.btnCal.Text = "Cal"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(361, 394)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(159, 68)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Aqua
        Me.Label5.Location = New System.Drawing.Point(24, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(323, 47)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "เงินคงเหลือหลังหักภาษี"
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.Color.Aqua
        Me.lblTax.Location = New System.Drawing.Point(422, 251)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(177, 47)
        Me.lblTax.TabIndex = 1
        '
        'lbltotalFinal
        '
        Me.lbltotalFinal.BackColor = System.Drawing.Color.Aqua
        Me.lbltotalFinal.Location = New System.Drawing.Point(422, 316)
        Me.lbltotalFinal.Name = "lbltotalFinal"
        Me.lbltotalFinal.Size = New System.Drawing.Size(177, 47)
        Me.lbltotalFinal.TabIndex = 1
        '
        'frmFirstForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(20.0!, 39.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 497)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbltotalFinal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.Name = "frmFirstForm"
        Me.Text = "frmFirstForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCal As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lbltotalFinal As Label
End Class
