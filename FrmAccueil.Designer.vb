<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAccueil
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
        Me.btnInscrire = New System.Windows.Forms.Button()
        Me.btnModifSuppr = New System.Windows.Forms.Button()
        Me.btnAff = New System.Windows.Forms.Button()
        Me.btnBilan = New System.Windows.Forms.Button()
        Me.btnFin = New System.Windows.Forms.Button()
        Me.tmrHeureActu = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnInscrire
        '
        Me.btnInscrire.Location = New System.Drawing.Point(12, 12)
        Me.btnInscrire.Name = "btnInscrire"
        Me.btnInscrire.Size = New System.Drawing.Size(102, 48)
        Me.btnInscrire.TabIndex = 0
        Me.btnInscrire.Text = "Inscrire un candidat"
        Me.btnInscrire.UseVisualStyleBackColor = True
        '
        'btnModifSuppr
        '
        Me.btnModifSuppr.Location = New System.Drawing.Point(120, 12)
        Me.btnModifSuppr.Name = "btnModifSuppr"
        Me.btnModifSuppr.Size = New System.Drawing.Size(102, 48)
        Me.btnModifSuppr.TabIndex = 1
        Me.btnModifSuppr.Text = "Modifier ou supprimer une inscription"
        Me.btnModifSuppr.UseVisualStyleBackColor = True
        '
        'btnAff
        '
        Me.btnAff.Location = New System.Drawing.Point(120, 66)
        Me.btnAff.Name = "btnAff"
        Me.btnAff.Size = New System.Drawing.Size(102, 49)
        Me.btnAff.TabIndex = 3
        Me.btnAff.Text = "Afficher l'état des inscriptions"
        Me.btnAff.UseVisualStyleBackColor = True
        '
        'btnBilan
        '
        Me.btnBilan.Location = New System.Drawing.Point(12, 66)
        Me.btnBilan.Name = "btnBilan"
        Me.btnBilan.Size = New System.Drawing.Size(102, 49)
        Me.btnBilan.TabIndex = 4
        Me.btnBilan.Text = "Établir un bilan provisoire"
        Me.btnBilan.UseVisualStyleBackColor = True
        '
        'btnFin
        '
        Me.btnFin.Location = New System.Drawing.Point(127, 138)
        Me.btnFin.Name = "btnFin"
        Me.btnFin.Size = New System.Drawing.Size(95, 38)
        Me.btnFin.TabIndex = 5
        Me.btnFin.Text = "Fin des inscriptions"
        Me.btnFin.UseVisualStyleBackColor = True
        '
        'tmrHeureActu
        '
        Me.tmrHeureActu.Interval = 2000
        '
        'FrmAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 193)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnFin)
        Me.Controls.Add(Me.btnBilan)
        Me.Controls.Add(Me.btnAff)
        Me.Controls.Add(Me.btnModifSuppr)
        Me.Controls.Add(Me.btnInscrire)
        Me.Name = "FrmAccueil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInscrire As System.Windows.Forms.Button
    Friend WithEvents btnModifSuppr As System.Windows.Forms.Button
    Friend WithEvents btnAff As System.Windows.Forms.Button
    Friend WithEvents btnBilan As System.Windows.Forms.Button
    Friend WithEvents btnFin As System.Windows.Forms.Button
    Friend WithEvents tmrHeureActu As System.Windows.Forms.Timer
End Class
