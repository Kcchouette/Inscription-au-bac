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

﻿Public Class FrmModifSuppr

    Private Sub Rbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtModif.Click, RbtSuppr.Click
        BtnAction.Text = sender.Tag
        Me.Tag = sender.Tag & " "
        Call FrmAccueil.tmrHeureActu_Tick(sender, e)
    End Sub

    Private Sub FrmModifSuppr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RbtModif.Tag = "Modifier l'inscription"
        RbtSuppr.Tag = "Supprimer l'inscription"
        Me.Tag = RbtModif.Tag & " "
        Call FrmAccueil.tmrHeureActu_Tick(sender, e)
    End Sub

    Private Sub RbtNum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtNum.Click
        TxtNum.Enabled = True
        CbxNomPre.Enabled = False
    End Sub

    Private Sub RbtNomPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtNomPre.Click
        TxtNum.Enabled = False
        CbxNomPre.Enabled = True
    End Sub

    Private Sub BtnRet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRet.Click
        Me.Hide()
        FrmAccueil.Show()
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

    Private Sub BtnAction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAction.Click
        Dim num As Integer
        If RbtNum.Checked Then
            FileGet(numFicInscrit, tblEnreg, 1)
            If TxtNum.Text = "" Or tblEnreg(TxtNum.Text) <> 1 Then
                MsgBox("Numéro invalide")
                TxtNum.Focus()
                Exit Sub
            End If
            num = TxtNum.Text
        Else 'nom-prénom
            num = LstCacheNum.Items(CbxNomPre.SelectedIndex)
        End If
        FileGet(numFicInscrit, persActu, num)
        If RbtModif.Checked Then
            Me.Hide()
            FrmInscripRens.Show()
            FrmInscripRens.modif = True
            FrmInscripRens.LblNum.Text = num
            FrmInscripRens.Reinit()
        Else 'suppr
            Me.Hide()
            FrmRecapInscription.Show()
            FrmRecapInscription.suppr = True
            FrmRecapInscription.bilan = False
            FrmRecapInscription.modif = False
            FrmRecapInscription.LblNum.Text = num
            FrmRecapInscription.Reinit()
        End If
    End Sub

    Public Sub Reinit()
        RbtModif.Checked = True
        BtnAction.Text = RbtModif.Tag
        RbtNum.Checked = True
        TxtNum.Enabled = True
        TxtNum.Text = ""
        CbxNomPre.Items.Clear()
        LstCacheNum.Items.Clear()
        Call chargerNomPre(CbxNomPre, LstCacheNum)
        CbxNomPre.SelectedIndex = 0
        CbxNomPre.Enabled = False
    End Sub
End Class
