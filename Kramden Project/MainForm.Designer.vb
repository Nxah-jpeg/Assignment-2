<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblSalespeople = New Label()
        lblAllowance = New Label()
        lblTotalcost = New Label()
        txtPeople = New TextBox()
        txtAllowance = New TextBox()
        txtTotalCost = New TextBox()
        btnClear = New Button()
        btnCalc = New Button()
        btnExit = New Button()
        lblCompany = New Label()
        SuspendLayout()
        ' 
        ' lblSalespeople
        ' 
        lblSalespeople.AutoSize = True
        lblSalespeople.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lblSalespeople.Location = New Point(12, 113)
        lblSalespeople.Name = "lblSalespeople"
        lblSalespeople.Size = New Size(315, 38)
        lblSalespeople.TabIndex = 0
        lblSalespeople.Text = "Number of Sales People"
        lblSalespeople.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblAllowance
        ' 
        lblAllowance.AutoSize = True
        lblAllowance.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lblAllowance.Location = New Point(12, 228)
        lblAllowance.Name = "lblAllowance"
        lblAllowance.Size = New Size(264, 38)
        lblAllowance.TabIndex = 9
        lblAllowance.Text = "Expenses Allowance"
        lblAllowance.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTotalcost
        ' 
        lblTotalcost.AutoSize = True
        lblTotalcost.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lblTotalcost.Location = New Point(12, 320)
        lblTotalcost.Name = "lblTotalcost"
        lblTotalcost.Size = New Size(137, 38)
        lblTotalcost.TabIndex = 10
        lblTotalcost.Text = "Total Cost"
        lblTotalcost.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtPeople
        ' 
        txtPeople.Location = New Point(360, 120)
        txtPeople.Name = "txtPeople"
        txtPeople.Size = New Size(150, 31)
        txtPeople.TabIndex = 1
        ' 
        ' txtAllowance
        ' 
        txtAllowance.Location = New Point(360, 235)
        txtAllowance.Name = "txtAllowance"
        txtAllowance.Size = New Size(150, 31)
        txtAllowance.TabIndex = 2
        ' 
        ' txtTotalCost
        ' 
        txtTotalCost.Location = New Point(360, 327)
        txtTotalCost.Name = "txtTotalCost"
        txtTotalCost.Size = New Size(150, 31)
        txtTotalCost.TabIndex = 3
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.Location = New Point(442, 394)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(110, 44)
        btnClear.TabIndex = 5
        btnClear.Text = "C&lear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnCalc
        ' 
        btnCalc.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnCalc.Location = New Point(310, 394)
        btnCalc.Name = "btnCalc"
        btnCalc.Size = New Size(110, 44)
        btnCalc.TabIndex = 4
        btnCalc.Text = "&Calculate"
        btnCalc.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnExit.Location = New Point(659, 32)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(110, 45)
        btnExit.TabIndex = 6
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblCompany
        ' 
        lblCompany.AutoSize = True
        lblCompany.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        lblCompany.Location = New Point(328, 18)
        lblCompany.Name = "lblCompany"
        lblCompany.Size = New Size(206, 45)
        lblCompany.TabIndex = 10
        lblCompany.Text = "Kramden Inc."
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(831, 495)
        Controls.Add(lblCompany)
        Controls.Add(btnExit)
        Controls.Add(btnCalc)
        Controls.Add(btnClear)
        Controls.Add(txtTotalCost)
        Controls.Add(txtAllowance)
        Controls.Add(txtPeople)
        Controls.Add(lblTotalcost)
        Controls.Add(lblAllowance)
        Controls.Add(lblSalespeople)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kramden Inc."
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSalespeople As Label
    Friend WithEvents lblAllowance As Label
    Friend WithEvents lblTotalcost As Label
    Friend WithEvents txtPeople As TextBox
    Friend WithEvents txtAllowance As TextBox
    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCompany As Label
End Class
