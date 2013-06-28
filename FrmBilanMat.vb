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

﻿Public Class FrmBilanMat

    Private Sub BtnRet_Click(sender As Object, e As EventArgs) Handles BtnRet.Click
        Me.Hide()
        TmrScroll.Stop()
        FrmAffichBilan.Show()
    End Sub

    Private Sub SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstRegion.SelectedIndexChanged, LstNomPre.SelectedIndexChanged, LstType.SelectedIndexChanged
        Dim ind As Integer
        Dim lb As ListBox
        Dim top As Integer

        top = sender.TopIndex
        ind = sender.SelectedIndex

        For Each lb In PnlCoord.Controls
            lb.TopIndex = top
            If (lb.SelectedIndex = ind) Then Continue For
            lb.SelectedIndex = ind
        Next
    End Sub

    Private Sub TmrScroll_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TmrScroll.Tick
        Dim lb As ListBox
        Dim lb2 As ListBox
        For Each lb In PnlCoord.Controls
            If lb.TopIndex <> TmrScroll.Tag Then
                TmrScroll.Tag = lb.TopIndex
                For Each lb2 In PnlCoord.Controls
                    lb2.TopIndex = TmrScroll.Tag
                Next lb2
                Exit For
            End If
        Next lb
    End Sub

    Private Sub FrmBilanMat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Tag = Me.Text & " "
        For i = 0 To UBound(tMat)
            CbxMat.Items.Add(tMat(i))
        Next i
        CbxMat.SelectedIndex = 0
        Call Reinit()
    End Sub

    Public Sub Reinit()
        'Nettoyage des listes
        LstCache.Items.Clear()
        Dim lb As ListBox
        For Each lb In PnlCoord.Controls
            lb.Items.Clear()
        Next lb

        'Chargement des listes TODO -
        Dim ind As Integer
        Dim type As String
        Dim cptEcrit As Integer
        Dim cptOral As Integer
        Dim cptFac As Integer

        FileGet(numFicInscrit, tblEnreg, 1)
        For i = 2 To UBound(tblEnreg)
            If tblEnreg(i) = 1 Then
                FileGet(numFicInscrit, persActu, i)
                type = getTypeMat(persActu, CbxMat.SelectedItem)
                If type <> "" Then
                    ind = LstCache.Items.Add(LSet(tReg(persActu.iReg), 10) & LSet(persActu.nom, 15) & persActu.pre)
                    LstNomPre.Items.Insert(ind, LSet(persActu.nom, 15) & " " & persActu.pre)
                    LstRegion.Items.Insert(ind, tReg(persActu.iReg)) ' Pas de - pour l'instant
                    LstType.Items.Insert(ind, type)
                    If type = "Écrit" Then
                        cptEcrit += 1
                    ElseIf type = "Oral" Then
                        cptOral += 1
                    Else 'Facultatif
                        cptFac += 1
                    End If
                End If
            End If
        Next i
        LblCptEcrit.Text = "Écrit : " & cptEcrit
        LblCptOral.Text = "Oral : " & cptOral
        LblCptFac.Text = "Facultatif : " & cptFac
        TmrScroll.Start()

        For i = LstRegion.Items.Count - 1 To 1 Step -1
            If (Trim(LstRegion.Items(i)) = Trim(LstRegion.Items(i - 1))) Then
                LstRegion.Items(i) = "-"
            End If
        Next i

    End Sub

    Private Sub CbxMat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxMat.SelectedIndexChanged
        Reinit()
    End Sub
End Class
