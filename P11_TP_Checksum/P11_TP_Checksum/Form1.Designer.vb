<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P11_Checksum
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P11_Checksum))
        Me.ButCksum = New System.Windows.Forms.Button()
        Me.TBoxCksum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelProcess = New System.Windows.Forms.Label()
        Me.TBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButCksum
        '
        Me.ButCksum.Location = New System.Drawing.Point(78, 212)
        Me.ButCksum.Name = "ButCksum"
        Me.ButCksum.Size = New System.Drawing.Size(129, 23)
        Me.ButCksum.TabIndex = 0
        Me.ButCksum.Text = "Generate Checksum"
        Me.ButCksum.UseVisualStyleBackColor = True
        '
        'TBoxCksum
        '
        Me.TBoxCksum.Location = New System.Drawing.Point(12, 176)
        Me.TBoxCksum.Name = "TBoxCksum"
        Me.TBoxCksum.Size = New System.Drawing.Size(260, 20)
        Me.TBoxCksum.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Full Test Program Zip path:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(78, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 129)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'LabelProcess
        '
        Me.LabelProcess.AutoSize = True
        Me.LabelProcess.ForeColor = System.Drawing.Color.Red
        Me.LabelProcess.Location = New System.Drawing.Point(79, 240)
        Me.LabelProcess.Name = "LabelProcess"
        Me.LabelProcess.Size = New System.Drawing.Size(128, 13)
        Me.LabelProcess.TabIndex = 2
        Me.LabelProcess.Text = "Processing... Please wait."
        Me.LabelProcess.Visible = False
        '
        'TBox1
        '
        Me.TBox1.Location = New System.Drawing.Point(94, 214)
        Me.TBox1.Name = "TBox1"
        Me.TBox1.Size = New System.Drawing.Size(100, 20)
        Me.TBox1.TabIndex = 4
        Me.TBox1.Visible = False
        '
        'P11_Checksum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelProcess)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBoxCksum)
        Me.Controls.Add(Me.ButCksum)
        Me.Controls.Add(Me.TBox1)
        Me.Name = "P11_Checksum"
        Me.Text = "P11 Checksum v0.1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButCksum As System.Windows.Forms.Button
    Friend WithEvents TBoxCksum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelProcess As System.Windows.Forms.Label
    Friend WithEvents TBox1 As System.Windows.Forms.TextBox

End Class
