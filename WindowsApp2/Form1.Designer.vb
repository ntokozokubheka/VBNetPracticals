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
        Me.lblNumberWeeks = New System.Windows.Forms.Label()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.lblAverageMoney = New System.Windows.Forms.Label()
        Me.txtNumberWeeks = New System.Windows.Forms.TextBox()
        Me.txtMoney = New System.Windows.Forms.TextBox()
        Me.txtAverageMoney = New System.Windows.Forms.TextBox()
        Me.btnNumberweeks = New System.Windows.Forms.Button()
        Me.btnMoney = New System.Windows.Forms.Button()
        Me.btnAverageMoney = New System.Windows.Forms.Button()
        Me.txtSuccess = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblNumberWeeks
        '
        Me.lblNumberWeeks.AutoSize = True
        Me.lblNumberWeeks.Location = New System.Drawing.Point(91, 46)
        Me.lblNumberWeeks.Name = "lblNumberWeeks"
        Me.lblNumberWeeks.Size = New System.Drawing.Size(93, 13)
        Me.lblNumberWeeks.TabIndex = 0
        Me.lblNumberWeeks.Text = "Number of Weeks"
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Location = New System.Drawing.Point(94, 115)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(117, 13)
        Me.lblMoney.TabIndex = 1
        Me.lblMoney.Text = "Money For Each Week"
        '
        'lblAverageMoney
        '
        Me.lblAverageMoney.AutoSize = True
        Me.lblAverageMoney.Location = New System.Drawing.Point(94, 192)
        Me.lblAverageMoney.Name = "lblAverageMoney"
        Me.lblAverageMoney.Size = New System.Drawing.Size(112, 13)
        Me.lblAverageMoney.TabIndex = 2
        Me.lblAverageMoney.Text = "Average Money Made"
        '
        'txtNumberWeeks
        '
        Me.txtNumberWeeks.Location = New System.Drawing.Point(228, 46)
        Me.txtNumberWeeks.Name = "txtNumberWeeks"
        Me.txtNumberWeeks.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberWeeks.TabIndex = 3
        '
        'txtMoney
        '
        Me.txtMoney.Location = New System.Drawing.Point(259, 115)
        Me.txtMoney.Name = "txtMoney"
        Me.txtMoney.Size = New System.Drawing.Size(100, 20)
        Me.txtMoney.TabIndex = 4
        '
        'txtAverageMoney
        '
        Me.txtAverageMoney.Location = New System.Drawing.Point(248, 192)
        Me.txtAverageMoney.Name = "txtAverageMoney"
        Me.txtAverageMoney.Size = New System.Drawing.Size(100, 20)
        Me.txtAverageMoney.TabIndex = 5
        '
        'btnNumberweeks
        '
        Me.btnNumberweeks.Location = New System.Drawing.Point(454, 42)
        Me.btnNumberweeks.Name = "btnNumberweeks"
        Me.btnNumberweeks.Size = New System.Drawing.Size(168, 35)
        Me.btnNumberweeks.TabIndex = 6
        Me.btnNumberweeks.Text = "Input Number of Weeks"
        Me.btnNumberweeks.UseVisualStyleBackColor = True
        '
        'btnMoney
        '
        Me.btnMoney.Location = New System.Drawing.Point(463, 110)
        Me.btnMoney.Name = "btnMoney"
        Me.btnMoney.Size = New System.Drawing.Size(144, 35)
        Me.btnMoney.TabIndex = 7
        Me.btnMoney.Text = "Input Money Made"
        Me.btnMoney.UseVisualStyleBackColor = True
        '
        'btnAverageMoney
        '
        Me.btnAverageMoney.Location = New System.Drawing.Point(463, 177)
        Me.btnAverageMoney.Name = "btnAverageMoney"
        Me.btnAverageMoney.Size = New System.Drawing.Size(144, 38)
        Me.btnAverageMoney.TabIndex = 8
        Me.btnAverageMoney.Text = "Calculate Average Money"
        Me.btnAverageMoney.UseVisualStyleBackColor = True
        '
        'txtSuccess
        '
        Me.txtSuccess.Location = New System.Drawing.Point(248, 286)
        Me.txtSuccess.Name = "txtSuccess"
        Me.txtSuccess.Size = New System.Drawing.Size(290, 20)
        Me.txtSuccess.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtSuccess)
        Me.Controls.Add(Me.btnAverageMoney)
        Me.Controls.Add(Me.btnMoney)
        Me.Controls.Add(Me.btnNumberweeks)
        Me.Controls.Add(Me.txtAverageMoney)
        Me.Controls.Add(Me.txtMoney)
        Me.Controls.Add(Me.txtNumberWeeks)
        Me.Controls.Add(Me.lblAverageMoney)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.lblNumberWeeks)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumberWeeks As Label
    Friend WithEvents lblMoney As Label
    Friend WithEvents lblAverageMoney As Label
    Friend WithEvents txtNumberWeeks As TextBox
    Friend WithEvents txtMoney As TextBox
    Friend WithEvents txtAverageMoney As TextBox
    Friend WithEvents btnNumberweeks As Button
    Friend WithEvents btnMoney As Button
    Friend WithEvents btnAverageMoney As Button
    Friend WithEvents txtSuccess As TextBox
End Class
