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
