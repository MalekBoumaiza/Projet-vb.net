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
        Me.TheEmpireThemeContainer1 = New vbprojectNV.TheEmpireThemeContainer()
        Me.inscri = New vbprojectNV.TheEmpireButton()
        Me.pw = New vbprojectNV.TheEmpireTextBox()
        Me.log = New vbprojectNV.TheEmpireTextBox()
        Me.connexion = New vbprojectNV.TheEmpireButton()
        Me.TheEmpireGroupBox2 = New vbprojectNV.TheEmpireGroupBox()
        Me.TheEmpireGroupBox1 = New vbprojectNV.TheEmpireGroupBox()
        Me.TheEmpireThemeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TheEmpireThemeContainer1
        '
        Me.TheEmpireThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TheEmpireThemeContainer1.Controls.Add(Me.inscri)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.pw)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.log)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.connexion)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.TheEmpireGroupBox2)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.TheEmpireGroupBox1)
        Me.TheEmpireThemeContainer1.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.TheEmpireThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TheEmpireThemeContainer1.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireThemeContainer1.ForeColor = System.Drawing.Color.LightGray
        Me.TheEmpireThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.TheEmpireThemeContainer1.Name = "TheEmpireThemeContainer1"
        Me.TheEmpireThemeContainer1.Size = New System.Drawing.Size(465, 462)
        Me.TheEmpireThemeContainer1.TabIndex = 0
        Me.TheEmpireThemeContainer1.Text = "Accès à la bibliothèque"
        '
        'inscri
        '
        Me.inscri.BackColor = System.Drawing.Color.Transparent
        Me.inscri.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inscri.Image = Nothing
        Me.inscri.ImageAlignment = vbprojectNV.TheEmpireButton.ImageAlignments.Left
        Me.inscri.Location = New System.Drawing.Point(91, 387)
        Me.inscri.Name = "inscri"
        Me.inscri.Size = New System.Drawing.Size(263, 49)
        Me.inscri.TabIndex = 5
        Me.inscri.Text = "S'inscrir"
        '
        'pw
        '
        Me.pw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pw.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pw.ForeColor = System.Drawing.Color.LightGray
        Me.pw.Location = New System.Drawing.Point(52, 224)
        Me.pw.MaxLength = 32767
        Me.pw.Multiline = False
        Me.pw.Name = "pw"
        Me.pw.ReadOnly = False
        Me.pw.SelectionLength = 0
        Me.pw.SelectionStart = 0
        Me.pw.Size = New System.Drawing.Size(341, 46)
        Me.pw.TabIndex = 3
        Me.pw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.pw.UseSystemPasswordChar = False
        '
        'log
        '
        Me.log.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.log.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.log.ForeColor = System.Drawing.Color.LightGray
        Me.log.Location = New System.Drawing.Point(55, 117)
        Me.log.MaxLength = 32767
        Me.log.Multiline = False
        Me.log.Name = "log"
        Me.log.ReadOnly = False
        Me.log.SelectionLength = 0
        Me.log.SelectionStart = 0
        Me.log.Size = New System.Drawing.Size(341, 46)
        Me.log.TabIndex = 2
        Me.log.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.log.UseSystemPasswordChar = False
        '
        'connexion
        '
        Me.connexion.BackColor = System.Drawing.Color.Transparent
        Me.connexion.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.connexion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connexion.Image = Nothing
        Me.connexion.ImageAlignment = vbprojectNV.TheEmpireButton.ImageAlignments.Left
        Me.connexion.Location = New System.Drawing.Point(91, 314)
        Me.connexion.Name = "connexion"
        Me.connexion.Size = New System.Drawing.Size(263, 49)
        Me.connexion.TabIndex = 4
        Me.connexion.Text = "Connexion"
        '
        'TheEmpireGroupBox2
        '
        Me.TheEmpireGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireGroupBox2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireGroupBox2.ForeColor = System.Drawing.Color.Black
        Me.TheEmpireGroupBox2.Location = New System.Drawing.Point(52, 183)
        Me.TheEmpireGroupBox2.Name = "TheEmpireGroupBox2"
        Me.TheEmpireGroupBox2.Size = New System.Drawing.Size(341, 55)
        Me.TheEmpireGroupBox2.TabIndex = 1
        Me.TheEmpireGroupBox2.Text = "Password"
        '
        'TheEmpireGroupBox1
        '
        Me.TheEmpireGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireGroupBox1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireGroupBox1.ForeColor = System.Drawing.Color.Black
        Me.TheEmpireGroupBox1.Location = New System.Drawing.Point(52, 76)
        Me.TheEmpireGroupBox1.Name = "TheEmpireGroupBox1"
        Me.TheEmpireGroupBox1.Size = New System.Drawing.Size(341, 54)
        Me.TheEmpireGroupBox1.TabIndex = 0
        Me.TheEmpireGroupBox1.Text = "Login"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 462)
        Me.Controls.Add(Me.TheEmpireThemeContainer1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TheEmpireThemeContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TheEmpireThemeContainer1 As vbprojectNV.TheEmpireThemeContainer
    Friend WithEvents log As vbprojectNV.TheEmpireTextBox
    Friend WithEvents TheEmpireGroupBox2 As vbprojectNV.TheEmpireGroupBox
    Friend WithEvents TheEmpireGroupBox1 As vbprojectNV.TheEmpireGroupBox
    Friend WithEvents connexion As vbprojectNV.TheEmpireButton
    Friend WithEvents pw As vbprojectNV.TheEmpireTextBox
    Friend WithEvents inscri As vbprojectNV.TheEmpireButton

End Class
