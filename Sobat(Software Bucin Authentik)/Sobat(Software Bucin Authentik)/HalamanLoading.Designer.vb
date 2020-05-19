<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HalamanLoading
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HalamanLoading))
        Me.LoadingProgressBucin = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureLoading = New System.Windows.Forms.PictureBox()
        Me.Percent_loadingLBL = New System.Windows.Forms.Label()
        Me.Status_loadingLBL = New System.Windows.Forms.Label()
        CType(Me.PictureLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoadingProgressBucin
        '
        Me.LoadingProgressBucin.Location = New System.Drawing.Point(21, 509)
        Me.LoadingProgressBucin.Name = "LoadingProgressBucin"
        Me.LoadingProgressBucin.Size = New System.Drawing.Size(776, 23)
        Me.LoadingProgressBucin.TabIndex = 5
        '
        'PictureLoading
        '
        Me.PictureLoading.Location = New System.Drawing.Point(143, 12)
        Me.PictureLoading.Name = "PictureLoading"
        Me.PictureLoading.Size = New System.Drawing.Size(480, 480)
        Me.PictureLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureLoading.TabIndex = 8
        Me.PictureLoading.TabStop = False
        '
        'Percent_loadingLBL
        '
        Me.Percent_loadingLBL.AutoSize = True
        Me.Percent_loadingLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Percent_loadingLBL.Location = New System.Drawing.Point(21, 535)
        Me.Percent_loadingLBL.Name = "Percent_loadingLBL"
        Me.Percent_loadingLBL.Size = New System.Drawing.Size(147, 20)
        Me.Percent_loadingLBL.TabIndex = 7
        Me.Percent_loadingLBL.Text = "Percent Loading <3"
        '
        'Status_loadingLBL
        '
        Me.Status_loadingLBL.AutoSize = True
        Me.Status_loadingLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status_loadingLBL.Location = New System.Drawing.Point(21, 561)
        Me.Status_loadingLBL.Name = "Status_loadingLBL"
        Me.Status_loadingLBL.Size = New System.Drawing.Size(88, 20)
        Me.Status_loadingLBL.TabIndex = 6
        Me.Status_loadingLBL.Text = "Loading <3"
        '
        'HalamanLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 590)
        Me.Controls.Add(Me.LoadingProgressBucin)
        Me.Controls.Add(Me.PictureLoading)
        Me.Controls.Add(Me.Percent_loadingLBL)
        Me.Controls.Add(Me.Status_loadingLBL)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HalamanLoading"
        Me.Text = "Halaman Loading Sobat(Software Bucin Authentik)"
        CType(Me.PictureLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoadingProgressBucin As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureLoading As PictureBox
    Friend WithEvents Percent_loadingLBL As Label
    Friend WithEvents Status_loadingLBL As Label
End Class
