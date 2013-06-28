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

﻿Public Class FrmAffichBilan
    Public fin As Boolean
    Private Sub ButDemandeCandidature_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCandidature.Click
        Me.Hide()
        FrmBilanIndividuel.Show()
        FrmBilanIndividuel.Reinit()
    End Sub

    Private Sub ButInscriptionsMat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMat.Click
        Me.Hide()
        FrmBilanMat.Show()
        FrmBilanMat.Reinit()
    End Sub

    Private Sub BtnRet_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnRet.Click
        Me.Hide()
        If Not fin Then
            FrmAccueil.Show()
        Else
            FileClose(numFicInscrit)
            FrmAccueil.Close()
        End If
    End Sub

    Private Sub btnSuppr_Click(sender As Object, e As EventArgs) Handles btnSuppr.Click
        MsgBox("Fonctionnalité non disponible")
    End Sub

    Private Sub FrmAffichBilan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tag = Me.Text & " "
        Call FrmAccueil.tmrHeureActu_Tick(sender, e)
    End Sub

    Private Sub FrmAffichBilan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If fin Then BtnRet.Text = "Quitter l'application"
    End Sub
End Class
