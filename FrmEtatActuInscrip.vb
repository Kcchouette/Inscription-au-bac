Public Class FrmEtatActuInscrip
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