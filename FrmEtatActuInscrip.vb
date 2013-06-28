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

﻿Public Class FrmEtatActuInscrip
    Private Sub FrmEtatActuInscrip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tag = Me.Text & " "
    End Sub

    Private Sub BtnRet_Click(sender As Object, e As EventArgs) Handles BtnRet.Click
        Me.Hide()
        TmrScroll.Stop()
        FrmAccueil.Show()
    End Sub

    Private Sub Lst_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstNom.SelectedIndexChanged, LstPre.SelectedIndexChanged, LstNum.SelectedIndexChanged, LstEcrit.SelectedIndexChanged, LstOral.SelectedIndexChanged, LstFac.SelectedIndexChanged
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

    Public Sub Reinit()
        Dim ind As Integer
        Dim mat As String
        FileGet(numFicInscrit, tblEnreg, 1)

        'Nettoyage des listes
        LstCache.Items.Clear()
        Dim lb As ListBox
        For Each lb In PnlCoord.Controls
            lb.Items.Clear()
        Next lb

        'Chargement des listes
        For i = 2 To UBound(tblEnreg)
            If tblEnreg(i) = 1 Then
                FileGet(numFicInscrit, persActu, i)
                ind = LstCache.Items.Add(LSet(persActu.nom, 15) & persActu.pre)
                LstNom.Items.Insert(ind, persActu.nom)
                LstPre.Items.Insert(ind, persActu.pre)
                LstNum.Items.Insert(ind, i)

                mat = ""
                For j = UBound(persActu.tIndEcrit) To 0 Step -1
                    mat = mat & UCase(LSet(tMat(persActu.tIndEcrit(j)), 4)) & " "
                Next j
                LstEcrit.Items.Insert(ind, mat)

                mat = ""
                For j = UBound(persActu.tIndOral) To 0 Step -1
                    mat = mat & UCase(LSet(tMat(persActu.tIndOral(j)), 4)) & " "
                Next j
                LstOral.Items.Insert(ind, mat)

                If persActu.iFacult = -1 Then
                    mat = "NON"
                Else
                    mat = UCase(LSet(tMat(persActu.iFacult), 4))
                End If
                LstFac.Items.Insert(ind, mat)
            End If
        Next i
        TmrScroll.Start()
    End Sub

    Private Sub TmrScroll_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrScroll.Tick
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
End Class
