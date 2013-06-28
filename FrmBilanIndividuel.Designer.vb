'' Copyright (c) 2013, Kcchouette and b-dauphin on Github
'' All rights reserved.
'' 
'' Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
'' 
''     Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
''     Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
''     Neither the name of the <ORGANIZATION> nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
'' 
'' THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBilanIndividuel
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
        Me.CbxNomPre = New System.Windows.Forms.ComboBox()
        Me.TxtNum = New System.Windows.Forms.TextBox()
        Me.btnAff = New System.Windows.Forms.Button()
        Me.rbtNom = New System.Windows.Forms.RadioButton()
        Me.rbtNum = New System.Windows.Forms.RadioButton()
        Me.PnlChoix = New System.Windows.Forms.Panel()
        Me.BtnRet = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LstCacheNum = New System.Windows.Forms.ListBox()
        Me.PnlChoix.SuspendLayout()
        Me.SuspendLayout()
        '
        'CbxNomPre
        '
        Me.CbxNomPre.Enabled = False
        Me.CbxNomPre.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxNomPre.FormattingEnabled = True
        Me.CbxNomPre.Location = New System.Drawing.Point(101, 29)
        Me.CbxNomPre.Name = "CbxNomPre"
        Me.CbxNomPre.Size = New System.Drawing.Size(241, 22)
        Me.CbxNomPre.Sorted = True
        Me.CbxNomPre.TabIndex = 0
        '
        'TxtNum
        '
        Me.TxtNum.Location = New System.Drawing.Point(101, 3)
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.Size = New System.Drawing.Size(41, 20)
        Me.TxtNum.TabIndex = 1
        '
        'btnAff
        '
        Me.btnAff.Location = New System.Drawing.Point(278, 109)
        Me.btnAff.Name = "btnAff"
        Me.btnAff.Size = New System.Drawing.Size(75, 23)
        Me.btnAff.TabIndex = 4
        Me.btnAff.Text = "Afficher"
        Me.btnAff.UseVisualStyleBackColor = True
        '
        'rbtNom
        '
        Me.rbtNom.AutoSize = True
        Me.rbtNom.Location = New System.Drawing.Point(3, 35)
        Me.rbtNom.Name = "rbtNom"
        Me.rbtNom.Size = New System.Drawing.Size(92, 17)
        Me.rbtNom.TabIndex = 5
        Me.rbtNom.Text = "Nom-Prénom :"
        Me.rbtNom.UseVisualStyleBackColor = True
        '
        'rbtNum
        '
        Me.rbtNum.AutoSize = True
        Me.rbtNum.Checked = True
        Me.rbtNum.Location = New System.Drawing.Point(3, 3)
        Me.rbtNum.Name = "rbtNum"
        Me.rbtNum.Size = New System.Drawing.Size(68, 17)
        Me.rbtNum.TabIndex = 6
        Me.rbtNum.TabStop = True
        Me.rbtNum.Text = "Numéro :"
        Me.rbtNum.UseVisualStyleBackColor = True
        '
        'PnlChoix
        '
        Me.PnlChoix.Controls.Add(Me.TxtNum)
        Me.PnlChoix.Controls.Add(Me.rbtNum)
        Me.PnlChoix.Controls.Add(Me.rbtNom)
        Me.PnlChoix.Controls.Add(Me.CbxNomPre)
        Me.PnlChoix.Location = New System.Drawing.Point(11, 27)
        Me.PnlChoix.Name = "PnlChoix"
        Me.PnlChoix.Size = New System.Drawing.Size(352, 67)
        Me.PnlChoix.TabIndex = 7
        '
        'BtnRet
        '
        Me.BtnRet.Location = New System.Drawing.Point(12, 109)
        Me.BtnRet.Name = "BtnRet"
        Me.BtnRet.Size = New System.Drawing.Size(75, 23)
        Me.BtnRet.TabIndex = 8
        Me.BtnRet.Text = "Retour"
        Me.BtnRet.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Sélectionnez un candidat"
        '
        'LstCacheNum
        '
        Me.LstCacheNum.FormattingEnabled = True
        Me.LstCacheNum.Location = New System.Drawing.Point(292, 4)
        Me.LstCacheNum.Name = "LstCacheNum"
        Me.LstCacheNum.Size = New System.Drawing.Size(61, 17)
        Me.LstCacheNum.TabIndex = 11
        Me.LstCacheNum.Visible = False
        '
        'FrmBilanIndividuel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 144)
        Me.ControlBox = False
        Me.Controls.Add(Me.LstCacheNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRet)
        Me.Controls.Add(Me.PnlChoix)
        Me.Controls.Add(Me.btnAff)
        Me.Name = "FrmBilanIndividuel"
        Me.Text = "Bilan Individuel"
        Me.PnlChoix.ResumeLayout(False)
        Me.PnlChoix.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbxNomPre As System.Windows.Forms.ComboBox
    Friend WithEvents TxtNum As System.Windows.Forms.TextBox
    Friend WithEvents btnAff As System.Windows.Forms.Button
    Friend WithEvents rbtNom As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNum As System.Windows.Forms.RadioButton
    Friend WithEvents PnlChoix As System.Windows.Forms.Panel
    Friend WithEvents BtnRet As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LstCacheNum As System.Windows.Forms.ListBox
End Class
