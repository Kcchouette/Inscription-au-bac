Public Class FrmAffichBilan
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