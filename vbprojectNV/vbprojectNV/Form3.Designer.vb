<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.TheEmpireThemeContainer1 = New vbprojectNV.TheEmpireThemeContainer()
        Me.TheEmpireStatusStrip1 = New vbprojectNV.TheEmpireStatusStrip()
        Me.TheEmpireThemeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TheEmpireThemeContainer1
        '
        Me.TheEmpireThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TheEmpireThemeContainer1.Controls.Add(Me.TheEmpireStatusStrip1)
        Me.TheEmpireThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TheEmpireThemeContainer1.ForeColor = System.Drawing.Color.White
        Me.TheEmpireThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.TheEmpireThemeContainer1.Name = "TheEmpireThemeContainer1"
        Me.TheEmpireThemeContainer1.Size = New System.Drawing.Size(1219, 688)
        Me.TheEmpireThemeContainer1.TabIndex = 0
        Me.TheEmpireThemeContainer1.Text = "Bibliothèque"
        '
        'TheEmpireStatusStrip1
        '
        Me.TheEmpireStatusStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TheEmpireStatusStrip1.Location = New System.Drawing.Point(0, 654)
        Me.TheEmpireStatusStrip1.Name = "TheEmpireStatusStrip1"
        Me.TheEmpireStatusStrip1.Size = New System.Drawing.Size(1219, 34)
        Me.TheEmpireStatusStrip1.TabIndex = 2
        Me.TheEmpireStatusStrip1.Text = "vous étes connecté en tant qu' administrateur"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 688)
        Me.Controls.Add(Me.TheEmpireThemeContainer1)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.TheEmpireThemeContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TheEmpireThemeContainer1 As vbprojectNV.TheEmpireThemeContainer
    Friend WithEvents TheEmpireStatusStrip1 As vbprojectNV.TheEmpireStatusStrip
End Class
