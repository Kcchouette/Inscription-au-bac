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

Pictures in /images are under Free Art License 1.3 or later : http://artlibre.org/licence/lal/en

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
