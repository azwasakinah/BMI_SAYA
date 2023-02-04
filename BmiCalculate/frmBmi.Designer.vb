<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBmi
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
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.lblBmi1 = New System.Windows.Forms.Label()
        Me.lblBmi = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(115, 126)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(58, 13)
        Me.lblHeight.TabIndex = 0
        Me.lblHeight.Text = "Height(cm)"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(226, 123)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(115, 174)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(59, 13)
        Me.lblWeight.TabIndex = 2
        Me.lblWeight.Text = "Weight(kg)"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(226, 174)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'btnCal
        '
        Me.btnCal.Location = New System.Drawing.Point(167, 331)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(96, 30)
        Me.btnCal.TabIndex = 4
        Me.btnCal.Text = "CALCULATE"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'lblBmi1
        '
        Me.lblBmi1.AutoSize = True
        Me.lblBmi1.Location = New System.Drawing.Point(118, 232)
        Me.lblBmi1.Name = "lblBmi1"
        Me.lblBmi1.Size = New System.Drawing.Size(26, 13)
        Me.lblBmi1.TabIndex = 5
        Me.lblBmi1.Text = "BMI"
        '
        'lblBmi
        '
        Me.lblBmi.AutoSize = True
        Me.lblBmi.Location = New System.Drawing.Point(226, 231)
        Me.lblBmi.Name = "lblBmi"
        Me.lblBmi.Size = New System.Drawing.Size(0, 13)
        Me.lblBmi.TabIndex = 6
        '
        'frmBmi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 438)
        Me.Controls.Add(Me.lblBmi)
        Me.Controls.Add(Me.lblBmi1)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblHeight)
        Me.Name = "frmBmi"
        Me.Text = "BMI CALCULATOR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeight As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblWeight As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnCal As Button
    Friend WithEvents lblBmi1 As Label
    Friend WithEvents lblBmi As Label
End Class
