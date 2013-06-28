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

﻿Public Class FrmAccueil

    Private Sub btnInscrire_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnInscrire.Click
        Me.Hide()
        persActu = bidon
        FrmInscripRens.modif = False
        FrmInscripRens.Show()
        FrmInscripRens.Reinit()
    End Sub

    Private Sub FrmAccueil_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        tmrHeureActu.Start()
        Call tmrHeureActu_Tick(sender, e)
    End Sub

    Private Sub FrmAccueil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmrHeureActu.Start()
        Me.Tag = Me.Text & " "
        ReDim persActu.tIndEcrit(3)
        ReDim persActu.tIndOral(2)
        ReDim bidon.tIndEcrit(3)
        ReDim bidon.tIndOral(2)
        FileOpen(numFicInscrit, "inscriptions.dat", OpenMode.Random, OpenAccess.ReadWrite, OpenShare.Shared, lgEnr)
        'Call creerFichier()
    End Sub

    Sub tmrHeureActu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrHeureActu.Tick
        On Error Resume Next
        ActiveForm.Text = ActiveForm.Tag & TimeOfDay
    End Sub

    Private Sub btnFin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFin.Click
        Me.Hide()
        FrmAffichBilan.fin = True
        FrmAffichBilan.Show()
    End Sub

    Private Sub btnBilan_Click(sender As Object, e As EventArgs) Handles btnBilan.Click
        Me.Hide()
        FrmAffichBilan.Show()
    End Sub

    Private Sub btnAff_Click(sender As Object, e As EventArgs) Handles btnAff.Click
        Me.Hide()
        FrmEtatActuInscrip.Show()
        FrmEtatActuInscrip.Reinit()
    End Sub

    Private Sub btnModifSuppr_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnModifSuppr.Click
        Me.Hide()
        FrmModifSuppr.Show()
        FrmModifSuppr.Reinit()
    End Sub
End Class
