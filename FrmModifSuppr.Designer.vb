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
Partial Class FrmModifSuppr
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
        Me.TxtNum = New System.Windows.Forms.TextBox()
        Me.PnlModifSuppr = New System.Windows.Forms.Panel()
        Me.RbtSuppr = New System.Windows.Forms.RadioButton()
        Me.RbtModif = New System.Windows.Forms.RadioButton()
        Me.CbxNomPre = New System.Windows.Forms.ComboBox()
        Me.BtnAction = New System.Windows.Forms.Button()
        Me.RbtNum = New System.Windows.Forms.RadioButton()
        Me.RbtNomPre = New System.Windows.Forms.RadioButton()
        Me.PnlNomNum = New System.Windows.Forms.Panel()
        Me.BtnRet = New System.Windows.Forms.Button()
        Me.LstCacheNum = New System.Windows.Forms.ListBox()
        Me.PnlModifSuppr.SuspendLayout()
        Me.PnlNomNum.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtNum
        '
        Me.TxtNum.Location = New System.Drawing.Point(101, 6)
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.Size = New System.Drawing.Size(85, 20)
        Me.TxtNum.TabIndex = 0
        '
        'PnlModifSuppr
        '
        Me.PnlModifSuppr.Controls.Add(Me.RbtSuppr)
        Me.PnlModifSuppr.Controls.Add(Me.RbtModif)
        Me.PnlModifSuppr.Location = New System.Drawing.Point(12, 12)
        Me.PnlModifSuppr.Name = "PnlModifSuppr"
        Me.PnlModifSuppr.Size = New System.Drawing.Size(231, 52)
        Me.PnlModifSuppr.TabIndex = 2
        '
        'RbtSuppr
        '
        Me.RbtSuppr.AutoSize = True
        Me.RbtSuppr.Location = New System.Drawing.Point(122, 18)
        Me.RbtSuppr.Name = "RbtSuppr"
        Me.RbtSuppr.Size = New System.Drawing.Size(83, 17)
        Me.RbtSuppr.TabIndex = 1
        Me.RbtSuppr.Text = "Suppression"
        Me.RbtSuppr.UseVisualStyleBackColor = True
        '
        'RbtModif
        '
        Me.RbtModif.AutoSize = True
        Me.RbtModif.Checked = True
        Me.RbtModif.Location = New System.Drawing.Point(21, 18)
        Me.RbtModif.Name = "RbtModif"
        Me.RbtModif.Size = New System.Drawing.Size(82, 17)
        Me.RbtModif.TabIndex = 0
        Me.RbtModif.TabStop = True
        Me.RbtModif.Text = "Modification"
        Me.RbtModif.UseVisualStyleBackColor = True
        '
        'CbxNomPre
        '
        Me.CbxNomPre.Enabled = False
        Me.CbxNomPre.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxNomPre.FormattingEnabled = True
        Me.CbxNomPre.Location = New System.Drawing.Point(101, 45)
        Me.CbxNomPre.Name = "CbxNomPre"
        Me.CbxNomPre.Size = New System.Drawing.Size(215, 22)
        Me.CbxNomPre.Sorted = True
        Me.CbxNomPre.TabIndex = 3
        '
        'BtnAction
        '
        Me.BtnAction.Location = New System.Drawing.Point(195, 198)
        Me.BtnAction.Name = "BtnAction"
        Me.BtnAction.Size = New System.Drawing.Size(133, 25)
        Me.BtnAction.TabIndex = 4
        Me.BtnAction.Text = "..."
        Me.BtnAction.UseVisualStyleBackColor = True
        '
        'RbtNum
        '
        Me.RbtNum.AutoSize = True
        Me.RbtNum.Checked = True
        Me.RbtNum.Location = New System.Drawing.Point(3, 7)
        Me.RbtNum.Name = "RbtNum"
        Me.RbtNum.Size = New System.Drawing.Size(68, 17)
        Me.RbtNum.TabIndex = 6
        Me.RbtNum.TabStop = True
        Me.RbtNum.Text = "Numéro :"
        Me.RbtNum.UseVisualStyleBackColor = True
        '
        'RbtNomPre
        '
        Me.RbtNomPre.AutoSize = True
        Me.RbtNomPre.Location = New System.Drawing.Point(3, 45)
        Me.RbtNomPre.Name = "RbtNomPre"
        Me.RbtNomPre.Size = New System.Drawing.Size(92, 17)
        Me.RbtNomPre.TabIndex = 7
        Me.RbtNomPre.Text = "Nom-Prénom :"
        Me.RbtNomPre.UseVisualStyleBackColor = True
        '
        'PnlNomNum
        '
        Me.PnlNomNum.Controls.Add(Me.RbtNomPre)
        Me.PnlNomNum.Controls.Add(Me.RbtNum)
        Me.PnlNomNum.Controls.Add(Me.CbxNomPre)
        Me.PnlNomNum.Controls.Add(Me.TxtNum)
        Me.PnlNomNum.Location = New System.Drawing.Point(12, 83)
        Me.PnlNomNum.Name = "PnlNomNum"
        Me.PnlNomNum.Size = New System.Drawing.Size(324, 74)
        Me.PnlNomNum.TabIndex = 8
        '
        'BtnRet
        '
        Me.BtnRet.Location = New System.Drawing.Point(12, 200)
        Me.BtnRet.Name = "BtnRet"
        Me.BtnRet.Size = New System.Drawing.Size(75, 23)
        Me.BtnRet.TabIndex = 9
        Me.BtnRet.Text = "Retour"
        Me.BtnRet.UseVisualStyleBackColor = True
        '
        'LstCacheNum
        '
        Me.LstCacheNum.FormattingEnabled = True
        Me.LstCacheNum.Location = New System.Drawing.Point(279, 12)
        Me.LstCacheNum.Name = "LstCacheNum"
        Me.LstCacheNum.Size = New System.Drawing.Size(57, 17)
        Me.LstCacheNum.TabIndex = 10
        Me.LstCacheNum.Visible = False
        '
        'FrmModifSuppr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 235)
        Me.Controls.Add(Me.LstCacheNum)
        Me.Controls.Add(Me.BtnRet)
        Me.Controls.Add(Me.PnlNomNum)
        Me.Controls.Add(Me.BtnAction)
        Me.Controls.Add(Me.PnlModifSuppr)
        Me.Name = "FrmModifSuppr"
        Me.Text = "Modifier l'inscription"
        Me.PnlModifSuppr.ResumeLayout(False)
        Me.PnlModifSuppr.PerformLayout()
        Me.PnlNomNum.ResumeLayout(False)
        Me.PnlNomNum.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtNum As System.Windows.Forms.TextBox
    Friend WithEvents PnlModifSuppr As System.Windows.Forms.Panel
    Friend WithEvents RbtSuppr As System.Windows.Forms.RadioButton
    Friend WithEvents RbtModif As System.Windows.Forms.RadioButton
    Friend WithEvents CbxNomPre As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAction As System.Windows.Forms.Button
    Friend WithEvents RbtNum As System.Windows.Forms.RadioButton
    Friend WithEvents RbtNomPre As System.Windows.Forms.RadioButton
    Friend WithEvents PnlNomNum As System.Windows.Forms.Panel
    Friend WithEvents BtnRet As System.Windows.Forms.Button
    Friend WithEvents LstCacheNum As System.Windows.Forms.ListBox
End Class
