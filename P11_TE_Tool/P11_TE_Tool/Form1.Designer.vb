<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ButComDlog = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TBoxRefTP = New System.Windows.Forms.TextBox()
        Me.TBoxNewTP = New System.Windows.Forms.TextBox()
        Me.TBoxRefRev = New System.Windows.Forms.TextBox()
        Me.TBoxNewRev = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBoxProd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelStatus = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButComDlog
        '
        Me.ButComDlog.Location = New System.Drawing.Point(106, 214)
        Me.ButComDlog.Name = "ButComDlog"
        Me.ButComDlog.Size = New System.Drawing.Size(157, 42)
        Me.ButComDlog.TabIndex = 0
        Me.ButComDlog.Text = "Create Compare Datalogs"
        Me.ButComDlog.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(119, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 130)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TBoxRefTP
        '
        Me.TBoxRefTP.Location = New System.Drawing.Point(106, 163)
        Me.TBoxRefTP.Name = "TBoxRefTP"
        Me.TBoxRefTP.Size = New System.Drawing.Size(246, 20)
        Me.TBoxRefTP.TabIndex = 2
        '
        'TBoxNewTP
        '
        Me.TBoxNewTP.Location = New System.Drawing.Point(106, 188)
        Me.TBoxNewTP.Name = "TBoxNewTP"
        Me.TBoxNewTP.Size = New System.Drawing.Size(246, 20)
        Me.TBoxNewTP.TabIndex = 3
        '
        'TBoxRefRev
        '
        Me.TBoxRefRev.Location = New System.Drawing.Point(59, 163)
        Me.TBoxRefRev.Name = "TBoxRefRev"
        Me.TBoxRefRev.Size = New System.Drawing.Size(41, 20)
        Me.TBoxRefRev.TabIndex = 4
        Me.TBoxRefRev.Text = "P.XX"
        '
        'TBoxNewRev
        '
        Me.TBoxNewRev.Location = New System.Drawing.Point(59, 188)
        Me.TBoxNewRev.Name = "TBoxNewRev"
        Me.TBoxNewRev.Size = New System.Drawing.Size(41, 20)
        Me.TBoxNewRev.TabIndex = 5
        Me.TBoxNewRev.Text = "P.YY"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Old Rev"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "New Rev"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "TP Rev"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(116, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Full Path:"
        '
        'TBoxProd
        '
        Me.TBoxProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxProd.ForeColor = System.Drawing.Color.Red
        Me.TBoxProd.Location = New System.Drawing.Point(54, 226)
        Me.TBoxProd.Name = "TBoxProd"
        Me.TBoxProd.Size = New System.Drawing.Size(46, 20)
        Me.TBoxProd.TabIndex = 5
        Me.TBoxProd.Text = "M2682"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Prod"
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(277, 233)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(0, 13)
        Me.LabelStatus.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 264)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBoxProd)
        Me.Controls.Add(Me.TBoxNewRev)
        Me.Controls.Add(Me.TBoxRefRev)
        Me.Controls.Add(Me.TBoxNewTP)
        Me.Controls.Add(Me.TBoxRefTP)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButComDlog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "P11 TE Tool"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButComDlog As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TBoxRefTP As System.Windows.Forms.TextBox
    Friend WithEvents TBoxNewTP As System.Windows.Forms.TextBox
    Friend WithEvents TBoxRefRev As System.Windows.Forms.TextBox
    Friend WithEvents TBoxNewRev As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBoxProd As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelStatus As System.Windows.Forms.Label

End Class
