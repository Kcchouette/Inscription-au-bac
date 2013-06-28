Public Class FrmAccueil

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