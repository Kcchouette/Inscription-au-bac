<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInscripRens
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblPre = New System.Windows.Forms.Label()
        Me.lblAdr = New System.Windows.Forms.Label()
        Me.lblCP = New System.Windows.Forms.Label()
        Me.lblVille = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtPre = New System.Windows.Forms.TextBox()
        Me.txtAdr = New System.Windows.Forms.TextBox()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.btnSuiv = New System.Windows.Forms.Button()
        Me.btnAband = New System.Windows.Forms.Button()
        Me.hscAge = New System.Windows.Forms.HScrollBar()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.tmrReste = New System.Windows.Forms.Timer(Me.components)
        Me.LblNum = New System.Windows.Forms.Label()
        Me.LblLibelléNum = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(12, 9)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(42, 13)
        Me.lblNom.TabIndex = 0
        Me.lblNom.Text = "* Nom :"
        '
        'lblPre
        '
        Me.lblPre.AutoSize = True
        Me.lblPre.Location = New System.Drawing.Point(12, 35)
        Me.lblPre.Name = "lblPre"
        Me.lblPre.Size = New System.Drawing.Size(56, 13)
        Me.lblPre.TabIndex = 1
        Me.lblPre.Text = "* Prénom :"
        '
        'lblAdr
        '
        Me.lblAdr.AutoSize = True
        Me.lblAdr.Location = New System.Drawing.Point(12, 61)
        Me.lblAdr.Name = "lblAdr"
        Me.lblAdr.Size = New System.Drawing.Size(69, 13)
        Me.lblAdr.TabIndex = 2
        Me.lblAdr.Text = "Adresse rue :"
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Location = New System.Drawing.Point(12, 87)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(76, 13)
        Me.lblCP.TabIndex = 3
        Me.lblCP.Text = "* Code postal :"
        '
        'lblVille
        '
        Me.lblVille.AutoSize = True
        Me.lblVille.Location = New System.Drawing.Point(12, 113)
        Me.lblVille.Name = "lblVille"
        Me.lblVille.Size = New System.Drawing.Size(39, 13)
        Me.lblVille.TabIndex = 4
        Me.lblVille.Text = "* Ville :"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(12, 139)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(39, 13)
        Me.lblAge.TabIndex = 5
        Me.lblAge.Text = "* Âge :"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(104, 6)
        Me.txtNom.MaxLength = 15
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(137, 20)
        Me.txtNom.TabIndex = 6
        Me.txtNom.Tag = ""
        '
        'txtPre
        '
        Me.txtPre.Location = New System.Drawing.Point(104, 32)
        Me.txtPre.MaxLength = 10
        Me.txtPre.Name = "txtPre"
        Me.txtPre.Size = New System.Drawing.Size(137, 20)
        Me.txtPre.TabIndex = 7
        Me.txtPre.Tag = ""
        '
        'txtAdr
        '
        Me.txtAdr.Location = New System.Drawing.Point(104, 58)
        Me.txtAdr.MaxLength = 20
        Me.txtAdr.Name = "txtAdr"
        Me.txtAdr.Size = New System.Drawing.Size(137, 20)
        Me.txtAdr.TabIndex = 8
        Me.txtAdr.Tag = ""
        '
        'txtVille
        '
        Me.txtVille.Location = New System.Drawing.Point(104, 110)
        Me.txtVille.MaxLength = 15
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(137, 20)
        Me.txtVille.TabIndex = 10
        Me.txtVille.Tag = ""
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(104, 84)
        Me.txtCP.MaxLength = 5
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(137, 20)
        Me.txtCP.TabIndex = 9
        Me.txtCP.Tag = ""
        '
        'btnSuiv
        '
        Me.btnSuiv.Location = New System.Drawing.Point(153, 195)
        Me.btnSuiv.Name = "btnSuiv"
        Me.btnSuiv.Size = New System.Drawing.Size(89, 23)
        Me.btnSuiv.TabIndex = 12
        Me.btnSuiv.Text = "Suivant ->"
        Me.btnSuiv.UseVisualStyleBackColor = True
        '
        'btnAband
        '
        Me.btnAband.Location = New System.Drawing.Point(12, 195)
        Me.btnAband.Name = "btnAband"
        Me.btnAband.Size = New System.Drawing.Size(135, 23)
        Me.btnAband.TabIndex = 13
        Me.btnAband.Text = "Abandonner l'inscription"
        Me.btnAband.UseVisualStyleBackColor = True
        '
        'hscAge
        '
        Me.hscAge.Location = New System.Drawing.Point(104, 138)
        Me.hscAge.Name = "hscAge"
        Me.hscAge.Size = New System.Drawing.Size(100, 17)
        Me.hscAge.TabIndex = 14
        '
        'txtAge
        '
        Me.txtAge.Enabled = False
        Me.txtAge.Location = New System.Drawing.Point(208, 138)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(33, 20)
        Me.txtAge.TabIndex = 15
        Me.txtAge.Tag = ""
        '
        'tmrReste
        '
        Me.tmrReste.Interval = 1000
        '
        'LblNum
        '
        Me.LblNum.AutoSize = True
        Me.LblNum.Location = New System.Drawing.Point(101, 170)
        Me.LblNum.Name = "LblNum"
        Me.LblNum.Size = New System.Drawing.Size(16, 13)
        Me.LblNum.TabIndex = 32
        Me.LblNum.Text = "..."
        '
        'LblLibelléNum
        '
        Me.LblLibelléNum.AutoSize = True
        Me.LblLibelléNum.Location = New System.Drawing.Point(12, 170)
        Me.LblLibelléNum.Name = "LblLibelléNum"
        Me.LblLibelléNum.Size = New System.Drawing.Size(91, 13)
        Me.LblLibelléNum.TabIndex = 31
        Me.LblLibelléNum.Text = "Numéro d'inscrit : "
        '
        'FrmInscripRens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 230)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblNum)
        Me.Controls.Add(Me.LblLibelléNum)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.hscAge)
        Me.Controls.Add(Me.btnAband)
        Me.Controls.Add(Me.btnSuiv)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.txtVille)
        Me.Controls.Add(Me.txtAdr)
        Me.Controls.Add(Me.txtPre)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblVille)
        Me.Controls.Add(Me.lblCP)
        Me.Controls.Add(Me.lblAdr)
        Me.Controls.Add(Me.lblPre)
        Me.Controls.Add(Me.lblNom)
        Me.Name = "FrmInscripRens"
        Me.Text = "Inscription"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblPre As System.Windows.Forms.Label
    Friend WithEvents lblAdr As System.Windows.Forms.Label
    Friend WithEvents lblCP As System.Windows.Forms.Label
    Friend WithEvents lblVille As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtPre As System.Windows.Forms.TextBox
    Friend WithEvents txtAdr As System.Windows.Forms.TextBox
    Friend WithEvents txtVille As System.Windows.Forms.TextBox
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents btnSuiv As System.Windows.Forms.Button
    Friend WithEvents btnAband As System.Windows.Forms.Button
    Friend WithEvents hscAge As System.Windows.Forms.HScrollBar
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents tmrReste As System.Windows.Forms.Timer
    Friend WithEvents LblNum As System.Windows.Forms.Label
    Friend WithEvents LblLibelléNum As System.Windows.Forms.Label

End Class
