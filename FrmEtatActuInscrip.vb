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
