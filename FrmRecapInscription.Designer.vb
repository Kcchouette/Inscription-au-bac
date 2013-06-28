<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecapInscription
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
        Me.LblLibelléNom = New System.Windows.Forms.Label()
        Me.LblLibelléPrénom = New System.Windows.Forms.Label()
        Me.LblLibelléAdresse = New System.Windows.Forms.Label()
        Me.LblLibelléCP = New System.Windows.Forms.Label()
        Me.LblLibelléVille = New System.Windows.Forms.Label()
        Me.LblLibelléAge = New System.Windows.Forms.Label()
        Me.LblNom = New System.Windows.Forms.Label()
        Me.BtnAnnul = New System.Windows.Forms.Button()
        Me.BtnValid = New System.Windows.Forms.Button()
        Me.LblPre = New System.Windows.Forms.Label()
        Me.LblAdr = New System.Windows.Forms.Label()
        Me.LblCP = New System.Windows.Forms.Label()
        Me.LblVille = New System.Windows.Forms.Label()
        Me.LblAge = New System.Windows.Forms.Label()
        Me.LblLibelléMatièreE = New System.Windows.Forms.Label()
        Me.LblMatEcrit = New System.Windows.Forms.Label()
        Me.LblLibelléMatièreO = New System.Windows.Forms.Label()
        Me.LblMatOral = New System.Windows.Forms.Label()
        Me.LblLibelléEpreuve = New System.Windows.Forms.Label()
        Me.LblEprFa = New System.Windows.Forms.Label()
        Me.LblLibelléRégion = New System.Windows.Forms.Label()
        Me.LblReg = New System.Windows.Forms.Label()
        Me.LblLibelléNum = New System.Windows.Forms.Label()
        Me.LblNum = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblLibelléNom
        '
        Me.LblLibelléNom.AutoSize = True
        Me.LblLibelléNom.Location = New System.Drawing.Point(12, 9)
        Me.LblLibelléNom.Name = "LblLibelléNom"
        Me.LblLibelléNom.Size = New System.Drawing.Size(38, 13)
        Me.LblLibelléNom.TabIndex = 0
        Me.LblLibelléNom.Text = "Nom : "
        '
        'LblLibelléPrénom
        '
        Me.LblLibelléPrénom.AutoSize = True
        Me.LblLibelléPrénom.Location = New System.Drawing.Point(140, 9)
        Me.LblLibelléPrénom.Name = "LblLibelléPrénom"
        Me.LblLibelléPrénom.Size = New System.Drawing.Size(49, 13)
        Me.LblLibelléPrénom.TabIndex = 1
        Me.LblLibelléPrénom.Text = "Prénom :"
        '
        'LblLibelléAdresse
        '
        Me.LblLibelléAdresse.AutoSize = True
        Me.LblLibelléAdresse.Location = New System.Drawing.Point(12, 43)
        Me.LblLibelléAdresse.Name = "LblLibelléAdresse"
        Me.LblLibelléAdresse.Size = New System.Drawing.Size(72, 13)
        Me.LblLibelléAdresse.TabIndex = 2
        Me.LblLibelléAdresse.Text = "Adresse rue : "
        '
        'LblLibelléCP
        '
        Me.LblLibelléCP.AutoSize = True
        Me.LblLibelléCP.Location = New System.Drawing.Point(302, 43)
        Me.LblLibelléCP.Name = "LblLibelléCP"
        Me.LblLibelléCP.Size = New System.Drawing.Size(69, 13)
        Me.LblLibelléCP.TabIndex = 3
        Me.LblLibelléCP.Text = "Code postal :"
        '
        'LblLibelléVille
        '
        Me.LblLibelléVille.AutoSize = True
        Me.LblLibelléVille.Location = New System.Drawing.Point(187, 43)
        Me.LblLibelléVille.Name = "LblLibelléVille"
        Me.LblLibelléVille.Size = New System.Drawing.Size(35, 13)
        Me.LblLibelléVille.TabIndex = 4
        Me.LblLibelléVille.Text = "Ville : "
        '
        'LblLibelléAge
        '
        Me.LblLibelléAge.AutoSize = True
        Me.LblLibelléAge.Location = New System.Drawing.Point(295, 9)
        Me.LblLibelléAge.Name = "LblLibelléAge"
        Me.LblLibelléAge.Size = New System.Drawing.Size(35, 13)
        Me.LblLibelléAge.TabIndex = 5
        Me.LblLibelléAge.Text = "Âge : "
        '
        'LblNom
        '
        Me.LblNom.AutoSize = True
        Me.LblNom.Location = New System.Drawing.Point(46, 9)
        Me.LblNom.Name = "LblNom"
        Me.LblNom.Size = New System.Drawing.Size(16, 13)
        Me.LblNom.TabIndex = 6
        Me.LblNom.Text = "..."
        '
        'BtnAnnul
        '
        Me.BtnAnnul.Location = New System.Drawing.Point(11, 202)
        Me.BtnAnnul.Name = "BtnAnnul"
        Me.BtnAnnul.Size = New System.Drawing.Size(92, 30)
        Me.BtnAnnul.TabIndex = 7
        Me.BtnAnnul.Text = "Annulation"
        Me.BtnAnnul.UseVisualStyleBackColor = True
        '
        'BtnValid
        '
        Me.BtnValid.Location = New System.Drawing.Point(360, 202)
        Me.BtnValid.Name = "BtnValid"
        Me.BtnValid.Size = New System.Drawing.Size(126, 30)
        Me.BtnValid.TabIndex = 8
        Me.BtnValid.Text = "..."
        Me.BtnValid.UseVisualStyleBackColor = True
        '
        'LblPre
        '
        Me.LblPre.AutoSize = True
        Me.LblPre.Location = New System.Drawing.Point(184, 9)
        Me.LblPre.Name = "LblPre"
        Me.LblPre.Size = New System.Drawing.Size(16, 13)
        Me.LblPre.TabIndex = 16
        Me.LblPre.Text = "..."
        '
        'LblAdr
        '
        Me.LblAdr.AutoSize = True
        Me.LblAdr.Location = New System.Drawing.Point(77, 43)
        Me.LblAdr.Name = "LblAdr"
        Me.LblAdr.Size = New System.Drawing.Size(16, 13)
        Me.LblAdr.TabIndex = 17
        Me.LblAdr.Text = "..."
        '
        'LblCP
        '
        Me.LblCP.AutoSize = True
        Me.LblCP.Location = New System.Drawing.Point(377, 43)
        Me.LblCP.Name = "LblCP"
        Me.LblCP.Size = New System.Drawing.Size(16, 13)
        Me.LblCP.TabIndex = 18
        Me.LblCP.Text = "..."
        '
        'LblVille
        '
        Me.LblVille.AutoSize = True
        Me.LblVille.Location = New System.Drawing.Point(219, 43)
        Me.LblVille.Name = "LblVille"
        Me.LblVille.Size = New System.Drawing.Size(16, 13)
        Me.LblVille.TabIndex = 19
        Me.LblVille.Text = "..."
        '
        'LblAge
        '
        Me.LblAge.AutoSize = True
        Me.LblAge.Location = New System.Drawing.Point(330, 9)
        Me.LblAge.Name = "LblAge"
        Me.LblAge.Size = New System.Drawing.Size(16, 13)
        Me.LblAge.TabIndex = 20
        Me.LblAge.Text = "..."
        '
        'LblLibelléMatièreE
        '
        Me.LblLibelléMatièreE.AutoSize = True
        Me.LblLibelléMatièreE.Location = New System.Drawing.Point(8, 93)
        Me.LblLibelléMatièreE.Name = "LblLibelléMatièreE"
        Me.LblLibelléMatièreE.Size = New System.Drawing.Size(98, 13)
        Me.LblLibelléMatièreE.TabIndex = 21
        Me.LblLibelléMatièreE.Text = "Matières de l'écrit : "
        '
        'LblMatEcrit
        '
        Me.LblMatEcrit.AutoSize = True
        Me.LblMatEcrit.Location = New System.Drawing.Point(112, 93)
        Me.LblMatEcrit.Name = "LblMatEcrit"
        Me.LblMatEcrit.Size = New System.Drawing.Size(0, 13)
        Me.LblMatEcrit.TabIndex = 22
        '
        'LblLibelléMatièreO
        '
        Me.LblLibelléMatièreO.AutoSize = True
        Me.LblLibelléMatièreO.Location = New System.Drawing.Point(229, 93)
        Me.LblLibelléMatièreO.Name = "LblLibelléMatièreO"
        Me.LblLibelléMatièreO.Size = New System.Drawing.Size(95, 13)
        Me.LblLibelléMatièreO.TabIndex = 23
        Me.LblLibelléMatièreO.Text = "Matières de l'oral : "
        '
        'LblMatOral
        '
        Me.LblMatOral.AutoSize = True
        Me.LblMatOral.Location = New System.Drawing.Point(330, 93)
        Me.LblMatOral.Name = "LblMatOral"
        Me.LblMatOral.Size = New System.Drawing.Size(0, 13)
        Me.LblMatOral.TabIndex = 24
        '
        'LblLibelléEpreuve
        '
        Me.LblLibelléEpreuve.AutoSize = True
        Me.LblLibelléEpreuve.Location = New System.Drawing.Point(8, 169)
        Me.LblLibelléEpreuve.Name = "LblLibelléEpreuve"
        Me.LblLibelléEpreuve.Size = New System.Drawing.Size(108, 13)
        Me.LblLibelléEpreuve.TabIndex = 25
        Me.LblLibelléEpreuve.Text = "Épreuve facultative : "
        '
        'LblEprFa
        '
        Me.LblEprFa.AutoSize = True
        Me.LblEprFa.Location = New System.Drawing.Point(122, 169)
        Me.LblEprFa.Name = "LblEprFa"
        Me.LblEprFa.Size = New System.Drawing.Size(16, 13)
        Me.LblEprFa.TabIndex = 26
        Me.LblEprFa.Text = "..."
        '
        'LblLibelléRégion
        '
        Me.LblLibelléRégion.AutoSize = True
        Me.LblLibelléRégion.Location = New System.Drawing.Point(362, 9)
        Me.LblLibelléRégion.Name = "LblLibelléRégion"
        Me.LblLibelléRégion.Size = New System.Drawing.Size(50, 13)
        Me.LblLibelléRégion.TabIndex = 27
        Me.LblLibelléRégion.Text = "Région : "
        '
        'LblReg
        '
        Me.LblReg.AutoSize = True
        Me.LblReg.Location = New System.Drawing.Point(409, 9)
        Me.LblReg.Name = "LblReg"
        Me.LblReg.Size = New System.Drawing.Size(16, 13)
        Me.LblReg.TabIndex = 28
        Me.LblReg.Text = "..."
        '
        'LblLibelléNum
        '
        Me.LblLibelléNum.AutoSize = True
        Me.LblLibelléNum.Location = New System.Drawing.Point(438, 43)
        Me.LblLibelléNum.Name = "LblLibelléNum"
        Me.LblLibelléNum.Size = New System.Drawing.Size(19, 13)
        Me.LblLibelléNum.TabIndex = 29
        Me.LblLibelléNum.Text = "N°"
        '
        'LblNum
        '
        Me.LblNum.AutoSize = True
        Me.LblNum.Location = New System.Drawing.Point(453, 43)
        Me.LblNum.Name = "LblNum"
        Me.LblNum.Size = New System.Drawing.Size(16, 13)
        Me.LblNum.TabIndex = 30
        Me.LblNum.Text = "..."
        '
        'FrmRecapInscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 249)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblNum)
        Me.Controls.Add(Me.LblLibelléNum)
        Me.Controls.Add(Me.LblReg)
        Me.Controls.Add(Me.LblLibelléRégion)
        Me.Controls.Add(Me.LblEprFa)
        Me.Controls.Add(Me.LblLibelléEpreuve)
        Me.Controls.Add(Me.LblMatOral)
        Me.Controls.Add(Me.LblLibelléMatièreO)
        Me.Controls.Add(Me.LblMatEcrit)
        Me.Controls.Add(Me.LblLibelléMatièreE)
        Me.Controls.Add(Me.LblAge)
        Me.Controls.Add(Me.LblVille)
        Me.Controls.Add(Me.LblCP)
        Me.Controls.Add(Me.LblAdr)
        Me.Controls.Add(Me.LblPre)
        Me.Controls.Add(Me.BtnValid)
        Me.Controls.Add(Me.BtnAnnul)
        Me.Controls.Add(Me.LblNom)
        Me.Controls.Add(Me.LblLibelléAge)
        Me.Controls.Add(Me.LblLibelléVille)
        Me.Controls.Add(Me.LblLibelléCP)
        Me.Controls.Add(Me.LblLibelléAdresse)
        Me.Controls.Add(Me.LblLibelléPrénom)
        Me.Controls.Add(Me.LblLibelléNom)
        Me.Name = "FrmRecapInscription"
        Me.Text = "Recapitulatif de l'inscription"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblLibelléNom As System.Windows.Forms.Label
    Friend WithEvents LblLibelléPrénom As System.Windows.Forms.Label
    Friend WithEvents LblLibelléAdresse As System.Windows.Forms.Label
    Friend WithEvents LblLibelléCP As System.Windows.Forms.Label
    Friend WithEvents LblLibelléVille As System.Windows.Forms.Label
    Friend WithEvents LblLibelléAge As System.Windows.Forms.Label
    Friend WithEvents LblNom As System.Windows.Forms.Label
    Friend WithEvents BtnAnnul As System.Windows.Forms.Button
    Friend WithEvents BtnValid As System.Windows.Forms.Button
    Friend WithEvents LblPre As System.Windows.Forms.Label
    Friend WithEvents LblAdr As System.Windows.Forms.Label
    Friend WithEvents LblCP As System.Windows.Forms.Label
    Friend WithEvents LblVille As System.Windows.Forms.Label
    Friend WithEvents LblAge As System.Windows.Forms.Label
    Friend WithEvents LblLibelléMatièreE As System.Windows.Forms.Label
    Friend WithEvents LblMatEcrit As System.Windows.Forms.Label
    Friend WithEvents LblLibelléMatièreO As System.Windows.Forms.Label
    Friend WithEvents LblMatOral As System.Windows.Forms.Label
    Friend WithEvents LblLibelléEpreuve As System.Windows.Forms.Label
    Friend WithEvents LblEprFa As System.Windows.Forms.Label
    Friend WithEvents LblLibelléRégion As System.Windows.Forms.Label
    Friend WithEvents LblReg As System.Windows.Forms.Label
    Friend WithEvents LblLibelléNum As System.Windows.Forms.Label
    Friend WithEvents LblNum As System.Windows.Forms.Label
End Class
