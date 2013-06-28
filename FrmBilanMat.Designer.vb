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
Partial Class FrmBilanMat
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
        Me.CbxMat = New System.Windows.Forms.ComboBox()
        Me.LstRegion = New System.Windows.Forms.ListBox()
        Me.LstNomPre = New System.Windows.Forms.ListBox()
        Me.LstType = New System.Windows.Forms.ListBox()
        Me.LblMat = New System.Windows.Forms.Label()
        Me.PnlCoord = New System.Windows.Forms.Panel()
        Me.BtnRet = New System.Windows.Forms.Button()
        Me.TmrScroll = New System.Windows.Forms.Timer(Me.components)
        Me.LstCache = New System.Windows.Forms.ListBox()
        Me.LblCptEcrit = New System.Windows.Forms.Label()
        Me.LblCptOral = New System.Windows.Forms.Label()
        Me.LblCptFac = New System.Windows.Forms.Label()
        Me.PnlCoord.SuspendLayout()
        Me.SuspendLayout()
        '
        'CbxMat
        '
        Me.CbxMat.FormattingEnabled = True
        Me.CbxMat.Location = New System.Drawing.Point(219, 6)
        Me.CbxMat.Name = "CbxMat"
        Me.CbxMat.Size = New System.Drawing.Size(121, 21)
        Me.CbxMat.Sorted = True
        Me.CbxMat.TabIndex = 0
        '
        'LstRegion
        '
        Me.LstRegion.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstRegion.FormattingEnabled = True
        Me.LstRegion.ItemHeight = 14
        Me.LstRegion.Location = New System.Drawing.Point(4, 15)
        Me.LstRegion.Name = "LstRegion"
        Me.LstRegion.Size = New System.Drawing.Size(120, 46)
        Me.LstRegion.TabIndex = 1
        '
        'LstNomPre
        '
        Me.LstNomPre.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstNomPre.FormattingEnabled = True
        Me.LstNomPre.ItemHeight = 14
        Me.LstNomPre.Location = New System.Drawing.Point(130, 15)
        Me.LstNomPre.Name = "LstNomPre"
        Me.LstNomPre.Size = New System.Drawing.Size(222, 46)
        Me.LstNomPre.Sorted = True
        Me.LstNomPre.TabIndex = 2
        '
        'LstType
        '
        Me.LstType.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstType.FormattingEnabled = True
        Me.LstType.ItemHeight = 14
        Me.LstType.Location = New System.Drawing.Point(358, 15)
        Me.LstType.Name = "LstType"
        Me.LstType.Size = New System.Drawing.Size(120, 46)
        Me.LstType.TabIndex = 3
        '
        'LblMat
        '
        Me.LblMat.AutoSize = True
        Me.LblMat.Location = New System.Drawing.Point(107, 9)
        Me.LblMat.Name = "LblMat"
        Me.LblMat.Size = New System.Drawing.Size(48, 13)
        Me.LblMat.TabIndex = 4
        Me.LblMat.Text = "Matière :"
        '
        'PnlCoord
        '
        Me.PnlCoord.Controls.Add(Me.LstType)
        Me.PnlCoord.Controls.Add(Me.LstNomPre)
        Me.PnlCoord.Controls.Add(Me.LstRegion)
        Me.PnlCoord.Location = New System.Drawing.Point(12, 33)
        Me.PnlCoord.Name = "PnlCoord"
        Me.PnlCoord.Size = New System.Drawing.Size(486, 73)
        Me.PnlCoord.TabIndex = 5
        '
        'BtnRet
        '
        Me.BtnRet.Location = New System.Drawing.Point(12, 132)
        Me.BtnRet.Name = "BtnRet"
        Me.BtnRet.Size = New System.Drawing.Size(75, 23)
        Me.BtnRet.TabIndex = 6
        Me.BtnRet.Text = "Retour"
        Me.BtnRet.UseVisualStyleBackColor = True
        '
        'TmrScroll
        '
        Me.TmrScroll.Interval = 50
        '
        'LstCache
        '
        Me.LstCache.FormattingEnabled = True
        Me.LstCache.Location = New System.Drawing.Point(329, 138)
        Me.LstCache.Name = "LstCache"
        Me.LstCache.Size = New System.Drawing.Size(169, 17)
        Me.LstCache.Sorted = True
        Me.LstCache.TabIndex = 7
        Me.LstCache.Visible = False
        '
        'LblCptEcrit
        '
        Me.LblCptEcrit.AutoSize = True
        Me.LblCptEcrit.Location = New System.Drawing.Point(58, 109)
        Me.LblCptEcrit.Name = "LblCptEcrit"
        Me.LblCptEcrit.Size = New System.Drawing.Size(16, 13)
        Me.LblCptEcrit.TabIndex = 4
        Me.LblCptEcrit.Text = "..."
        '
        'LblCptOral
        '
        Me.LblCptOral.AutoSize = True
        Me.LblCptOral.Location = New System.Drawing.Point(162, 109)
        Me.LblCptOral.Name = "LblCptOral"
        Me.LblCptOral.Size = New System.Drawing.Size(16, 13)
        Me.LblCptOral.TabIndex = 5
        Me.LblCptOral.Text = "..."
        '
        'LblCptFac
        '
        Me.LblCptFac.AutoSize = True
        Me.LblCptFac.Location = New System.Drawing.Point(261, 109)
        Me.LblCptFac.Name = "LblCptFac"
        Me.LblCptFac.Size = New System.Drawing.Size(16, 13)
        Me.LblCptFac.TabIndex = 6
        Me.LblCptFac.Text = "..."
        '
        'FrmBilanMat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 167)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblCptFac)
        Me.Controls.Add(Me.LstCache)
        Me.Controls.Add(Me.LblCptOral)
        Me.Controls.Add(Me.BtnRet)
        Me.Controls.Add(Me.LblCptEcrit)
        Me.Controls.Add(Me.PnlCoord)
        Me.Controls.Add(Me.LblMat)
        Me.Controls.Add(Me.CbxMat)
        Me.Name = "FrmBilanMat"
        Me.Text = "Bilan par matière"
        Me.PnlCoord.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbxMat As System.Windows.Forms.ComboBox
    Friend WithEvents LstRegion As System.Windows.Forms.ListBox
    Friend WithEvents LstNomPre As System.Windows.Forms.ListBox
    Friend WithEvents LstType As System.Windows.Forms.ListBox
    Friend WithEvents LblMat As System.Windows.Forms.Label
    Friend WithEvents PnlCoord As System.Windows.Forms.Panel
    Friend WithEvents BtnRet As System.Windows.Forms.Button
    Friend WithEvents TmrScroll As System.Windows.Forms.Timer
    Friend WithEvents LstCache As System.Windows.Forms.ListBox
    Friend WithEvents LblCptFac As System.Windows.Forms.Label
    Friend WithEvents LblCptOral As System.Windows.Forms.Label
    Friend WithEvents LblCptEcrit As System.Windows.Forms.Label
End Class
