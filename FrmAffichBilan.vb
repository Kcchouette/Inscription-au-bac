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
