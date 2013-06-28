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
Partial Class FrmInscripRegEpreuves
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
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblPre = New System.Windows.Forms.Label()
        Me.cbxReg = New System.Windows.Forms.ComboBox()
        Me.lblReg = New System.Windows.Forms.Label()
        Me.pnlOblig = New System.Windows.Forms.Panel()
        Me.lblOralRest = New System.Windows.Forms.Label()
        Me.lblEcritRest = New System.Windows.Forms.Label()
        Me.grpOral = New System.Windows.Forms.GroupBox()
        Me.CheckBox21 = New System.Windows.Forms.CheckBox()
        Me.CheckBox20 = New System.Windows.Forms.CheckBox()
        Me.CheckBox19 = New System.Windows.Forms.CheckBox()
        Me.CheckBox18 = New System.Windows.Forms.CheckBox()
        Me.CheckBox17 = New System.Windows.Forms.CheckBox()
        Me.CheckBox16 = New System.Windows.Forms.CheckBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.grpEcrit = New System.Windows.Forms.GroupBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.grpEprFacult = New System.Windows.Forms.GroupBox()
        Me.cbxEpr = New System.Windows.Forms.ComboBox()
        Me.btnEprNon = New System.Windows.Forms.RadioButton()
        Me.btnEprOui = New System.Windows.Forms.RadioButton()
        Me.btnValid = New System.Windows.Forms.Button()
        Me.btnAnnul = New System.Windows.Forms.Button()
        Me.LblNum = New System.Windows.Forms.Label()
        Me.LblLibelléNum = New System.Windows.Forms.Label()
        Me.pnlOblig.SuspendLayout()
        Me.grpOral.SuspendLayout()
        Me.grpEcrit.SuspendLayout()
        Me.grpEprFacult.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(29, 9)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(29, 13)
        Me.lblNom.TabIndex = 0
        Me.lblNom.Text = "Nom"
        '
        'lblPre
        '
        Me.lblPre.AutoSize = True
        Me.lblPre.Location = New System.Drawing.Point(132, 9)
        Me.lblPre.Name = "lblPre"
        Me.lblPre.Size = New System.Drawing.Size(43, 13)
        Me.lblPre.TabIndex = 1
        Me.lblPre.Text = "Prénom"
        '
        'cbxReg
        '
        Me.cbxReg.FormattingEnabled = True
        Me.cbxReg.Location = New System.Drawing.Point(135, 31)
        Me.cbxReg.Name = "cbxReg"
        Me.cbxReg.Size = New System.Drawing.Size(121, 21)
        Me.cbxReg.Sorted = True
        Me.cbxReg.TabIndex = 2
        '
        'lblReg
        '
        Me.lblReg.AutoSize = True
        Me.lblReg.Location = New System.Drawing.Point(29, 39)
        Me.lblReg.Name = "lblReg"
        Me.lblReg.Size = New System.Drawing.Size(47, 13)
        Me.lblReg.TabIndex = 3
        Me.lblReg.Text = "Région :"
        '
        'pnlOblig
        '
        Me.pnlOblig.Controls.Add(Me.lblOralRest)
        Me.pnlOblig.Controls.Add(Me.lblEcritRest)
        Me.pnlOblig.Controls.Add(Me.grpOral)
        Me.pnlOblig.Controls.Add(Me.grpEcrit)
        Me.pnlOblig.Location = New System.Drawing.Point(12, 58)
        Me.pnlOblig.Name = "pnlOblig"
        Me.pnlOblig.Size = New System.Drawing.Size(567, 255)
        Me.pnlOblig.TabIndex = 4
        '
        'lblOralRest
        '
        Me.lblOralRest.AutoSize = True
        Me.lblOralRest.Location = New System.Drawing.Point(352, 221)
        Me.lblOralRest.Name = "lblOralRest"
        Me.lblOralRest.Size = New System.Drawing.Size(16, 13)
        Me.lblOralRest.TabIndex = 3
        Me.lblOralRest.Text = "..."
        '
        'lblEcritRest
        '
        Me.lblEcritRest.AutoSize = True
        Me.lblEcritRest.Location = New System.Drawing.Point(32, 221)
        Me.lblEcritRest.Name = "lblEcritRest"
        Me.lblEcritRest.Size = New System.Drawing.Size(16, 13)
        Me.lblEcritRest.TabIndex = 2
        Me.lblEcritRest.Text = "..."
        '
        'grpOral
        '
        Me.grpOral.Controls.Add(Me.CheckBox21)
        Me.grpOral.Controls.Add(Me.CheckBox20)
        Me.grpOral.Controls.Add(Me.CheckBox19)
        Me.grpOral.Controls.Add(Me.CheckBox18)
        Me.grpOral.Controls.Add(Me.CheckBox17)
        Me.grpOral.Controls.Add(Me.CheckBox16)
        Me.grpOral.Controls.Add(Me.CheckBox15)
        Me.grpOral.Controls.Add(Me.CheckBox14)
        Me.grpOral.Controls.Add(Me.CheckBox13)
        Me.grpOral.Location = New System.Drawing.Point(315, 22)
        Me.grpOral.Name = "grpOral"
        Me.grpOral.Size = New System.Drawing.Size(234, 192)
        Me.grpOral.TabIndex = 1
        Me.grpOral.TabStop = False
        Me.grpOral.Text = "Matières à l'oral"
        '
        'CheckBox21
        '
        Me.CheckBox21.AutoSize = True
        Me.CheckBox21.Location = New System.Drawing.Point(141, 83)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox21.TabIndex = 8
        Me.CheckBox21.Text = "CheckBox21"
        Me.CheckBox21.UseVisualStyleBackColor = True
        '
        'CheckBox20
        '
        Me.CheckBox20.AutoSize = True
        Me.CheckBox20.Location = New System.Drawing.Point(141, 60)
        Me.CheckBox20.Name = "CheckBox20"
        Me.CheckBox20.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox20.TabIndex = 7
        Me.CheckBox20.Text = "CheckBox20"
        Me.CheckBox20.UseVisualStyleBackColor = True
        '
        'CheckBox19
        '
        Me.CheckBox19.AutoSize = True
        Me.CheckBox19.Location = New System.Drawing.Point(141, 37)
        Me.CheckBox19.Name = "CheckBox19"
        Me.CheckBox19.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox19.TabIndex = 6
        Me.CheckBox19.Text = "CheckBox19"
        Me.CheckBox19.UseVisualStyleBackColor = True
        '
        'CheckBox18
        '
        Me.CheckBox18.AutoSize = True
        Me.CheckBox18.Location = New System.Drawing.Point(26, 152)
        Me.CheckBox18.Name = "CheckBox18"
        Me.CheckBox18.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox18.TabIndex = 5
        Me.CheckBox18.Text = "CheckBox18"
        Me.CheckBox18.UseVisualStyleBackColor = True
        '
        'CheckBox17
        '
        Me.CheckBox17.AutoSize = True
        Me.CheckBox17.Location = New System.Drawing.Point(26, 129)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox17.TabIndex = 4
        Me.CheckBox17.Text = "CheckBox17"
        Me.CheckBox17.UseVisualStyleBackColor = True
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.Location = New System.Drawing.Point(26, 106)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox16.TabIndex = 3
        Me.CheckBox16.Text = "CheckBox16"
        Me.CheckBox16.UseVisualStyleBackColor = True
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.Location = New System.Drawing.Point(26, 83)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox15.TabIndex = 2
        Me.CheckBox15.Text = "CheckBox15"
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Location = New System.Drawing.Point(26, 60)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox14.TabIndex = 1
        Me.CheckBox14.Text = "CheckBox14"
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Location = New System.Drawing.Point(26, 37)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox13.TabIndex = 0
        Me.CheckBox13.Text = "CheckBox13"
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'grpEcrit
        '
        Me.grpEcrit.Controls.Add(Me.CheckBox12)
        Me.grpEcrit.Controls.Add(Me.CheckBox11)
        Me.grpEcrit.Controls.Add(Me.CheckBox10)
        Me.grpEcrit.Controls.Add(Me.CheckBox9)
        Me.grpEcrit.Controls.Add(Me.CheckBox8)
        Me.grpEcrit.Controls.Add(Me.CheckBox7)
        Me.grpEcrit.Controls.Add(Me.CheckBox6)
        Me.grpEcrit.Controls.Add(Me.CheckBox5)
        Me.grpEcrit.Controls.Add(Me.CheckBox4)
        Me.grpEcrit.Controls.Add(Me.CheckBox3)
        Me.grpEcrit.Controls.Add(Me.CheckBox2)
        Me.grpEcrit.Controls.Add(Me.CheckBox1)
        Me.grpEcrit.Location = New System.Drawing.Point(18, 22)
        Me.grpEcrit.Name = "grpEcrit"
        Me.grpEcrit.Size = New System.Drawing.Size(233, 192)
        Me.grpEcrit.TabIndex = 0
        Me.grpEcrit.TabStop = False
        Me.grpEcrit.Text = "Matières à l'écrit"
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Location = New System.Drawing.Point(122, 153)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox12.TabIndex = 11
        Me.CheckBox12.Text = "CheckBox12"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Location = New System.Drawing.Point(122, 129)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox11.TabIndex = 10
        Me.CheckBox11.Text = "CheckBox11"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Location = New System.Drawing.Point(122, 106)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox10.TabIndex = 9
        Me.CheckBox10.Text = "CheckBox10"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(122, 83)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox9.TabIndex = 8
        Me.CheckBox9.Text = "CheckBox9"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(122, 60)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox8.TabIndex = 7
        Me.CheckBox8.Text = "CheckBox8"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(122, 37)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox7.TabIndex = 6
        Me.CheckBox7.Text = "CheckBox7"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(17, 152)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox6.TabIndex = 5
        Me.CheckBox6.Text = "CheckBox6"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(17, 129)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "CheckBox5"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(17, 106)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "CheckBox4"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(17, 83)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(17, 60)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(17, 37)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'grpEprFacult
        '
        Me.grpEprFacult.Controls.Add(Me.cbxEpr)
        Me.grpEprFacult.Controls.Add(Me.btnEprNon)
        Me.grpEprFacult.Controls.Add(Me.btnEprOui)
        Me.grpEprFacult.Location = New System.Drawing.Point(30, 333)
        Me.grpEprFacult.Name = "grpEprFacult"
        Me.grpEprFacult.Size = New System.Drawing.Size(531, 53)
        Me.grpEprFacult.TabIndex = 5
        Me.grpEprFacult.TabStop = False
        Me.grpEprFacult.Text = "Épreuve Facultative ?"
        '
        'cbxEpr
        '
        Me.cbxEpr.Enabled = False
        Me.cbxEpr.FormattingEnabled = True
        Me.cbxEpr.Location = New System.Drawing.Point(337, 19)
        Me.cbxEpr.Name = "cbxEpr"
        Me.cbxEpr.Size = New System.Drawing.Size(121, 21)
        Me.cbxEpr.Sorted = True
        Me.cbxEpr.TabIndex = 2
        '
        'btnEprNon
        '
        Me.btnEprNon.AutoSize = True
        Me.btnEprNon.Checked = True
        Me.btnEprNon.Location = New System.Drawing.Point(122, 23)
        Me.btnEprNon.Name = "btnEprNon"
        Me.btnEprNon.Size = New System.Drawing.Size(45, 17)
        Me.btnEprNon.TabIndex = 1
        Me.btnEprNon.TabStop = True
        Me.btnEprNon.Text = "Non"
        Me.btnEprNon.UseVisualStyleBackColor = True
        '
        'btnEprOui
        '
        Me.btnEprOui.AutoSize = True
        Me.btnEprOui.Location = New System.Drawing.Point(17, 23)
        Me.btnEprOui.Name = "btnEprOui"
        Me.btnEprOui.Size = New System.Drawing.Size(41, 17)
        Me.btnEprOui.TabIndex = 0
        Me.btnEprOui.TabStop = True
        Me.btnEprOui.Text = "Oui"
        Me.btnEprOui.UseVisualStyleBackColor = True
        '
        'btnValid
        '
        Me.btnValid.Location = New System.Drawing.Point(468, 403)
        Me.btnValid.Name = "btnValid"
        Me.btnValid.Size = New System.Drawing.Size(75, 23)
        Me.btnValid.TabIndex = 6
        Me.btnValid.Text = "Valider"
        Me.btnValid.UseVisualStyleBackColor = True
        '
        'btnAnnul
        '
        Me.btnAnnul.Location = New System.Drawing.Point(71, 403)
        Me.btnAnnul.Name = "btnAnnul"
        Me.btnAnnul.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnul.TabIndex = 7
        Me.btnAnnul.Text = "Annuler"
        Me.btnAnnul.UseVisualStyleBackColor = True
        '
        'LblNum
        '
        Me.LblNum.AutoSize = True
        Me.LblNum.Location = New System.Drawing.Point(378, 9)
        Me.LblNum.Name = "LblNum"
        Me.LblNum.Size = New System.Drawing.Size(16, 13)
        Me.LblNum.TabIndex = 34
        Me.LblNum.Text = "..."
        '
        'LblLibelléNum
        '
        Me.LblLibelléNum.AutoSize = True
        Me.LblLibelléNum.Location = New System.Drawing.Point(289, 9)
        Me.LblLibelléNum.Name = "LblLibelléNum"
        Me.LblLibelléNum.Size = New System.Drawing.Size(91, 13)
        Me.LblLibelléNum.TabIndex = 33
        Me.LblLibelléNum.Text = "Numéro d'inscrit : "
        '
        'FrmInscripRegEpreuves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 435)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblNum)
        Me.Controls.Add(Me.LblLibelléNum)
        Me.Controls.Add(Me.btnAnnul)
        Me.Controls.Add(Me.btnValid)
        Me.Controls.Add(Me.grpEprFacult)
        Me.Controls.Add(Me.pnlOblig)
        Me.Controls.Add(Me.lblReg)
        Me.Controls.Add(Me.cbxReg)
        Me.Controls.Add(Me.lblPre)
        Me.Controls.Add(Me.lblNom)
        Me.Name = "FrmInscripRegEpreuves"
        Me.Text = "Épreuves"
        Me.pnlOblig.ResumeLayout(False)
        Me.pnlOblig.PerformLayout()
        Me.grpOral.ResumeLayout(False)
        Me.grpOral.PerformLayout()
        Me.grpEcrit.ResumeLayout(False)
        Me.grpEcrit.PerformLayout()
        Me.grpEprFacult.ResumeLayout(False)
        Me.grpEprFacult.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblPre As System.Windows.Forms.Label
    Friend WithEvents cbxReg As System.Windows.Forms.ComboBox
    Friend WithEvents lblReg As System.Windows.Forms.Label
    Friend WithEvents pnlOblig As System.Windows.Forms.Panel
    Friend WithEvents lblOralRest As System.Windows.Forms.Label
    Friend WithEvents lblEcritRest As System.Windows.Forms.Label
    Friend WithEvents grpOral As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox21 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox20 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox19 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox18 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox17 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox16 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox15 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox13 As System.Windows.Forms.CheckBox
    Friend WithEvents grpEcrit As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents grpEprFacult As System.Windows.Forms.GroupBox
    Friend WithEvents cbxEpr As System.Windows.Forms.ComboBox
    Friend WithEvents btnEprNon As System.Windows.Forms.RadioButton
    Friend WithEvents btnEprOui As System.Windows.Forms.RadioButton
    Friend WithEvents btnValid As System.Windows.Forms.Button
    Friend WithEvents btnAnnul As System.Windows.Forms.Button
    Friend WithEvents LblNum As System.Windows.Forms.Label
    Friend WithEvents LblLibelléNum As System.Windows.Forms.Label
End Class
