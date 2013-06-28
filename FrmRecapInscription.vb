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

﻿Public Class FrmRecapInscription

    ' gérer numéro
    ' compter le nombre d'inscrit

    Public suppr As Boolean
    Public modif As Boolean
    Public bilan As Boolean

    Private Sub FrmRecapInscription_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Tag = Me.Text & " "
        Call Reinit()
    End Sub

    Private Sub BtnAnnul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnnul.Click
        Me.Hide()
        If modif Then
            FrmAccueil.tmrHeureActu.Stop()
            FrmInscripRens.tmrReste.Start()
            FrmInscripRegEpreuves.Show()
        ElseIf bilan Then
            FrmAffichBilan.Show()
        ElseIf suppr Then
            FrmModifSuppr.Show()
            FrmModifSuppr.Reinit()
        Else
            FrmAccueil.Show()
        End If
    End Sub

    Private Sub BtnValid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnValid.Click
        If suppr Then
            supprCand(LblNum.Text)
        ElseIf modif Then
            reEnregCand(persActu, LblNum.Text)
        Else
            enregCand(persActu)
        End If
        Me.Hide()
        FrmAccueil.Show()
    End Sub

    Public Sub Reinit()
        LblNom.Text = Trim(persActu.nom)
        LblPre.Text = Trim(persActu.pre)
        LblAdr.Text = Trim(persActu.adr)
        LblCP.Text = persActu.cp
        LblVille.Text = Trim(persActu.ville)
        LblAge.Text = persActu.age
        LblReg.Text = tReg(persActu.iReg)

        'Chargement des matières
        LblMatEcrit.Text = ""
        LblMatOral.Text = ""
        For i = 0 To UBound(persActu.tIndEcrit)
            LblMatEcrit.Text = tMat(persActu.tIndEcrit(i)) & vbCrLf & LblMatEcrit.Text
        Next i
        For i = 0 To UBound(persActu.tIndOral)
            LblMatOral.Text = tMat(persActu.tIndOral(i)) & vbCrLf & LblMatOral.Text
        Next i
        If persActu.iFacult <> -1 Then
            LblEprFa.Text = tMat(persActu.iFacult)
        Else
            LblEprFa.Text = "NON"
        End If

        LblLibelléNum.Visible = True
        LblNum.Visible = True
        If bilan Then
            BtnValid.Visible = False
        Else
            BtnValid.Visible = True
            If suppr Then
                BtnValid.Text = "Supprimer l'inscription"
            ElseIf modif Then
                BtnValid.Text = "Actualiser l'inscription"
            Else 'ni bilan, modif ou suppr -> pas de numéro attibué
                BtnValid.Text = "Validation définitive"
                LblLibelléNum.Visible = False
                LblNum.Visible = False
            End If
        End If
    End Sub
End Class
