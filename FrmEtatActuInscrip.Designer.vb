'' The MIT License (MIT)
'' 
'' Copyright (c) 2013 Kcchouette and b-dauphin on Github
''
'' Permission is hereby granted, free of charge, to any person obtaining a copy
'' of this software and associated documentation files (the "Software"), to deal
'' in the Software without restriction, including without limitation the rights
'' to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
'' copies of the Software, and to permit persons to whom the Software is
'' furnished to do so, subject to the following conditions:
'' 
'' The above copyright notice and this permission notice shall be included in
'' all copies or substantial portions of the Software.
'' 
'' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
'' IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
'' FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
'' AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
'' LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
'' OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
'' THE SOFTWARE.

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEtatActuInscrip
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
        Me.LstNom = New System.Windows.Forms.ListBox()
        Me.LstPre = New System.Windows.Forms.ListBox()
        Me.LstNum = New System.Windows.Forms.ListBox()
        Me.LstEcrit = New System.Windows.Forms.ListBox()
        Me.LstOral = New System.Windows.Forms.ListBox()
        Me.LstFac = New System.Windows.Forms.ListBox()
        Me.PnlCoord = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblFac = New System.Windows.Forms.Label()
        Me.LblEcrit = New System.Windows.Forms.Label()
        Me.LblOral = New System.Windows.Forms.Label()
        Me.BtnRet = New System.Windows.Forms.Button()
        Me.LstCache = New System.Windows.Forms.ListBox()
        Me.TmrScroll = New System.Windows.Forms.Timer(Me.components)
        Me.PnlCoord.SuspendLayout()
        Me.SuspendLayout()
        '
        'LstNom
        '
        Me.LstNom.FormattingEnabled = True
        Me.LstNom.Location = New System.Drawing.Point(14, 3)
        Me.LstNom.Name = "LstNom"
        Me.LstNom.Size = New System.Drawing.Size(100, 43)
        Me.LstNom.TabIndex = 0
        '
        'LstPre
        '
        Me.LstPre.FormattingEnabled = True
        Me.LstPre.Location = New System.Drawing.Point(120, 3)
        Me.LstPre.Name = "LstPre"
        Me.LstPre.Size = New System.Drawing.Size(99, 43)
        Me.LstPre.TabIndex = 1
        '
        'LstNum
        '
        Me.LstNum.FormattingEnabled = True
        Me.LstNum.Location = New System.Drawing.Point(225, 3)
        Me.LstNum.Name = "LstNum"
        Me.LstNum.Size = New System.Drawing.Size(53, 43)
        Me.LstNum.TabIndex = 2
        '
        'LstEcrit
        '
        Me.LstEcrit.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstEcrit.FormattingEnabled = True
        Me.LstEcrit.ItemHeight = 14
        Me.LstEcrit.Location = New System.Drawing.Point(295, 3)
        Me.LstEcrit.Name = "LstEcrit"
        Me.LstEcrit.Size = New System.Drawing.Size(171, 46)
        Me.LstEcrit.TabIndex = 3
        '
        'LstOral
        '
        Me.LstOral.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstOral.FormattingEnabled = True
        Me.LstOral.ItemHeight = 14
        Me.LstOral.Location = New System.Drawing.Point(472, 3)
        Me.LstOral.Name = "LstOral"
        Me.LstOral.Size = New System.Drawing.Size(138, 46)
        Me.LstOral.TabIndex = 4
        '
        'LstFac
        '
        Me.LstFac.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstFac.FormattingEnabled = True
        Me.LstFac.ItemHeight = 14
        Me.LstFac.Location = New System.Drawing.Point(616, 3)
        Me.LstFac.Name = "LstFac"
        Me.LstFac.Size = New System.Drawing.Size(65, 46)
        Me.LstFac.TabIndex = 5
        '
        'PnlCoord
        '
        Me.PnlCoord.Controls.Add(Me.LstNum)
        Me.PnlCoord.Controls.Add(Me.LstPre)
        Me.PnlCoord.Controls.Add(Me.LstNom)
        Me.PnlCoord.Controls.Add(Me.LstEcrit)
        Me.PnlCoord.Controls.Add(Me.LstOral)
        Me.PnlCoord.Controls.Add(Me.LstFac)
        Me.PnlCoord.Location = New System.Drawing.Point(13, 30)
        Me.PnlCoord.Name = "PnlCoord"
        Me.PnlCoord.Size = New System.Drawing.Size(684, 60)
        Me.PnlCoord.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(235, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Numéro :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Prénom :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nom :"
        '
        'LblFac
        '
        Me.LblFac.AutoSize = True
        Me.LblFac.Location = New System.Drawing.Point(626, 9)
        Me.LblFac.Name = "LblFac"
        Me.LblFac.Size = New System.Drawing.Size(56, 13)
        Me.LblFac.TabIndex = 8
        Me.LblFac.Text = "Facultatif :"
        '
        'LblEcrit
        '
        Me.LblEcrit.AutoSize = True
        Me.LblEcrit.Location = New System.Drawing.Point(305, 9)
        Me.LblEcrit.Name = "LblEcrit"
        Me.LblEcrit.Size = New System.Drawing.Size(34, 13)
        Me.LblEcrit.TabIndex = 6
        Me.LblEcrit.Text = "Écrit :"
        '
        'LblOral
        '
        Me.LblOral.AutoSize = True
        Me.LblOral.Location = New System.Drawing.Point(482, 9)
        Me.LblOral.Name = "LblOral"
        Me.LblOral.Size = New System.Drawing.Size(32, 13)
        Me.LblOral.TabIndex = 7
        Me.LblOral.Text = "Oral :"
        '
        'BtnRet
        '
        Me.BtnRet.Location = New System.Drawing.Point(12, 106)
        Me.BtnRet.Name = "BtnRet"
        Me.BtnRet.Size = New System.Drawing.Size(75, 23)
        Me.BtnRet.TabIndex = 9
        Me.BtnRet.Text = "Retour"
        Me.BtnRet.UseVisualStyleBackColor = True
        '
        'LstCache
        '
        Me.LstCache.FormattingEnabled = True
        Me.LstCache.Location = New System.Drawing.Point(258, 106)
        Me.LstCache.Name = "LstCache"
        Me.LstCache.Size = New System.Drawing.Size(165, 17)
        Me.LstCache.Sorted = True
        Me.LstCache.TabIndex = 10
        Me.LstCache.Visible = False
        '
        'TmrScroll
        '
        Me.TmrScroll.Interval = 50
        '
        'FrmEtatActuInscrip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 141)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblFac)
        Me.Controls.Add(Me.LstCache)
        Me.Controls.Add(Me.LblOral)
        Me.Controls.Add(Me.LblEcrit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnRet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PnlCoord)
        Me.Name = "FrmEtatActuInscrip"
        Me.Text = "État actuel des inscriptions"
        Me.PnlCoord.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LstNom As System.Windows.Forms.ListBox
    Friend WithEvents LstPre As System.Windows.Forms.ListBox
    Friend WithEvents LstNum As System.Windows.Forms.ListBox
    Friend WithEvents LstEcrit As System.Windows.Forms.ListBox
    Friend WithEvents LstOral As System.Windows.Forms.ListBox
    Friend WithEvents LstFac As System.Windows.Forms.ListBox
    Friend WithEvents PnlCoord As System.Windows.Forms.Panel
    Friend WithEvents LblFac As System.Windows.Forms.Label
    Friend WithEvents LblOral As System.Windows.Forms.Label
    Friend WithEvents LblEcrit As System.Windows.Forms.Label
    Friend WithEvents BtnRet As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LstCache As System.Windows.Forms.ListBox
    Friend WithEvents TmrScroll As System.Windows.Forms.Timer
End Class
