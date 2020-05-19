<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loadingcompletenotif
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loadingcompletenotif))
        Me.Labelnotfcomloading = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Labelnotfcomloading
        '
        Me.Labelnotfcomloading.AutoSize = True
        Me.Labelnotfcomloading.Font = New System.Drawing.Font("Arial Narrow", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelnotfcomloading.Location = New System.Drawing.Point(108, 126)
        Me.Labelnotfcomloading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelnotfcomloading.Name = "Labelnotfcomloading"
        Me.Labelnotfcomloading.Size = New System.Drawing.Size(707, 43)
        Me.Labelnotfcomloading.TabIndex = 0
        Me.Labelnotfcomloading.Text = "Selamat datang di Sobat(Software Bucin Authentik)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 412)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(719, 43)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Terima Kasih telah menggunakan Aplikasi Sobat ^-^"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(349, 573)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(299, 35)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Lanjut ke halaman utama"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'loadingcompletenotif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SteganoNET.My.Resources.Resources._480WedKis1
        Me.ClientSize = New System.Drawing.Size(1067, 692)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Labelnotfcomloading)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "loadingcompletenotif"
        Me.Text = "loadingcompletenotif"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Labelnotfcomloading As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
