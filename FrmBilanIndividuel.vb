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

﻿Public Class FrmBilanIndividuel

    Private Sub BtnRet_Click(sender As Object, e As EventArgs) Handles BtnRet.Click
        Me.Hide()
        FrmAffichBilan.Show()
    End Sub

    Private Sub FrmBilanIndividuel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tag = Me.Text & " "
        Call chargerNomPre(CbxNomPre, LstCacheNum)
        CbxNomPre.SelectedIndex = 0
        Call FrmAccueil.tmrHeureActu_Tick(sender, e)
    End Sub

    Private Sub RbtNum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtNum.Click
        TxtNum.Enabled = True
        CbxNomPre.Enabled = False
    End Sub

    Private Sub RbtNomPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtNom.Click
        TxtNum.Enabled = False
        CbxNomPre.Enabled = True
    End Sub

    Private Sub TxtNum_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtNum.KeyPress
        If (e.KeyChar = vbBack) Then
            Exit Sub
        End If
        If (e.KeyChar >= "0" And e.KeyChar <= "9") Then
            Exit Sub
        End If
        e.KeyChar = Chr(0)
    End Sub

    Private Sub btnAff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAff.Click
        Dim num As Integer
        If rbtNum.Checked Then
            FileGet(numFicInscrit, tblEnreg, 1)
            If TxtNum.Text = "" Then TxtNum.Text = 0
            If tblEnreg(TxtNum.Text) <> 1 Then
                MsgBox("Numéro invalide")
                TxtNum.Focus()
                Exit Sub
            End If
            num = TxtNum.Text
        Else 'nom-prénom
            num = LstCacheNum.Items(CbxNomPre.SelectedIndex)
        End If
        FileGet(numFicInscrit, persActu, num)

        Me.Hide()
        FrmRecapInscription.Show()
        FrmRecapInscription.modif = False
        FrmRecapInscription.suppr = False
        FrmRecapInscription.bilan = True
        FrmRecapInscription.LblNum.Text = num
        FrmRecapInscription.Reinit()
    End Sub

    Public Sub Reinit()
        rbtNum.Checked = True
        TxtNum.Enabled = True
        TxtNum.Text = ""

        CbxNomPre.Items.Clear()
        LstCacheNum.Items.Clear()
        Call chargerNomPre(CbxNomPre, LstCacheNum)
        CbxNomPre.SelectedIndex = 0
        CbxNomPre.Enabled = False
    End Sub
End Class
