﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAffichBilan
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
        Me.btnCandidature = New System.Windows.Forms.Button()
        Me.btnMat = New System.Windows.Forms.Button()
        Me.btnSuppr = New System.Windows.Forms.Button()
        Me.BtnRet = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCandidature
        '
        Me.btnCandidature.Location = New System.Drawing.Point(13, 12)
        Me.btnCandidature.Name = "btnCandidature"
        Me.btnCandidature.Size = New System.Drawing.Size(137, 38)
        Me.btnCandidature.TabIndex = 0
        Me.btnCandidature.Text = "Bilan individuel d'une demande de candidature"
        Me.btnCandidature.UseVisualStyleBackColor = True
        '
        'btnMat
        '
        Me.btnMat.Location = New System.Drawing.Point(156, 12)
        Me.btnMat.Name = "btnMat"
        Me.btnMat.Size = New System.Drawing.Size(137, 38)
        Me.btnMat.TabIndex = 1
        Me.btnMat.Text = "Bilan des inscriptions dans une matière"
        Me.btnMat.UseVisualStyleBackColor = True
        '
        'btnSuppr
        '
        Me.btnSuppr.Location = New System.Drawing.Point(299, 12)
        Me.btnSuppr.Name = "btnSuppr"
        Me.btnSuppr.Size = New System.Drawing.Size(137, 38)
        Me.btnSuppr.TabIndex = 2
        Me.btnSuppr.Text = "Bilan des inscriptions supprimées"
        Me.btnSuppr.UseVisualStyleBackColor = True
        '
        'BtnRet
        '
        Me.BtnRet.Location = New System.Drawing.Point(13, 84)
        Me.BtnRet.Name = "BtnRet"
        Me.BtnRet.Size = New System.Drawing.Size(115, 23)
        Me.BtnRet.TabIndex = 3
        Me.BtnRet.Text = "Retour à l'accueil"
        Me.BtnRet.UseVisualStyleBackColor = True
        '
        'FrmAffichBilan
        '
        Me.AccessibleDescription = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 127)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnRet)
        Me.Controls.Add(Me.btnSuppr)
        Me.Controls.Add(Me.btnMat)
        Me.Controls.Add(Me.btnCandidature)
        Me.Name = "FrmAffichBilan"
        Me.Text = "Afficher bilan"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCandidature As System.Windows.Forms.Button
    Friend WithEvents btnMat As System.Windows.Forms.Button
    Friend WithEvents btnSuppr As System.Windows.Forms.Button
    Friend WithEvents BtnRet As System.Windows.Forms.Button
End Class