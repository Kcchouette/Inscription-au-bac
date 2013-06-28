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
