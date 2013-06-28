Public Class FrmInscripRegEpreuves

    Dim cptEcrit As Integer
    Dim cptOral As Integer
    Public modif As Boolean

    Private Sub FrmInscripRegEpruves_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Tag = Me.Text & " "

        'Chargement des régions
        For i = 0 To UBound(tReg)
            cbxReg.Items.Add(tReg(i))
        Next i

        'Chargement des matières
        Dim iEcrit As Integer = 0
        Dim iOral As Integer = 0
        For i = 0 To UBound(tMat)
            If tEcrit(i) And tOral(i) Then
                grpEcrit.Controls(iEcrit).Tag = iOral
                grpOral.Controls(iOral).Tag = iEcrit
                grpEcrit.Controls(iEcrit).Text = tMat(i)
                iEcrit += 1
                grpOral.Controls(iOral).Text = tMat(i)
                iOral += 1
            ElseIf tEcrit(i) Then
                grpEcrit.Controls(iEcrit).Tag = -1
                grpEcrit.Controls(iEcrit).Text = tMat(i)
                iEcrit += 1
            Else 'Seul tOral est vrai
                grpOral.Controls(iOral).Tag = -1
                grpOral.Controls(iOral).Text = tMat(i)
                iOral += 1
            End If
        Next i

        Call actuLblEcrit()
        Call actuLblOral()
    End Sub

    Private Sub Ecrit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox1.Click, CheckBox2.Click, CheckBox3.Click, CheckBox4.Click, CheckBox5.Click, CheckBox6.Click, CheckBox7.Click, CheckBox8.Click, CheckBox9.Click, CheckBox10.Click, CheckBox11.Click, CheckBox12.Click
        If (sender.checked) Then
            cptEcrit += 1
        Else
            cptEcrit -= 1
        End If

        If cptEcrit > 4 Then
            sender.checked = False
            cptEcrit -= 1
            MsgBox("TROP DE CHOIX", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Attention")
        End If

        If sender.Tag <> -1 Then grpOral.Controls(sender.Tag).Enabled = Not sender.Checked

        Call actuLblEcrit()
    End Sub

    Private Sub Oral_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox13.Click, CheckBox14.Click, CheckBox15.Click, CheckBox16.Click, CheckBox17.Click, CheckBox18.Click, CheckBox19.Click, CheckBox20.Click, CheckBox21.Click
        If (sender.checked) Then
            cptOral += 1
        Else
            cptOral -= 1
        End If

        If cptOral > 3 Then
            sender.checked = False
            cptOral -= 1
            MsgBox("TROP DE CHOIX", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Attention")
        End If

        If sender.Tag <> -1 Then grpEcrit.Controls(sender.Tag).Enabled = Not sender.Checked

        Call actuLblOral()
    End Sub

    Private Sub btnValid_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnValid.Click
        Dim chkbx As CheckBox
        If cptEcrit <> 4 And cptOral <> 3 Then
            MsgBox("Il manque : " & vbCrLf & (4 - cptEcrit) & " matière(s) à l'écrit et" & vbCrLf & (3 - cptOral) & " matière(s) à l'oral à sélectionner.", _
                   MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "INSCRIPTION INCORRECTE")
        ElseIf cptEcrit <> 4 Then
            MsgBox("Il manque : " & vbCrLf & (4 - cptEcrit) & " matière(s) à l'écrit à sélectionner", _
                   MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "INSCRIPTION INCORRECTE")
        ElseIf cptOral <> 3 Then
            MsgBox("Il manque : " & vbCrLf & (3 - cptOral) & " matière(s) à l'oral à sélectionner", _
                   MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "INSCRIPTION INCORRECTE")
        Else 'Tout est OK
            persActu.iReg = cbxReg.SelectedIndex

            'sauvegarder indices épreuves
            Dim i As Integer = 0
            For Each chkbx In grpEcrit.Controls
                If chkbx.Checked Then
                    persActu.tIndEcrit(i) = getIndiceMat(chkbx.Text)
                    i += 1
                    If i > 3 Then Exit For
                End If
            Next
            i = 0
            For Each chkbx In grpOral.Controls
                If chkbx.Checked Then
                    persActu.tIndOral(i) = getIndiceMat(chkbx.Text)
                    i += 1
                    If i > 2 Then Exit For
                End If
            Next
            If btnEprOui.Checked Then
                persActu.iFacult = getIndiceMat(cbxEpr.SelectedItem)
            Else
                persActu.iFacult = -1
            End If
            FrmAccueil.tmrHeureActu.Start()
            FrmInscripRens.tmrReste.Stop()
            FrmRecapInscription.Show()
            FrmRecapInscription.suppr = False
            FrmRecapInscription.modif = modif
            FrmRecapInscription.bilan = False
            FrmRecapInscription.LblNum.Text = LblNum.Text
            FrmRecapInscription.Reinit()
            Me.Hide()
        End If
    End Sub

    Private Sub actuLblEcrit()
        lblEcritRest.Text = 4 - cptEcrit & " choix restant(s)"
    End Sub

    Private Sub actuLblOral()
        lblOralRest.Text = 3 - cptOral & " choix restant(s)"
    End Sub

    Private Sub btnEprOui_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEprOui.Click
        If cptEcrit <> 4 Or cptOral <> 3 Then
            MsgBox("Sélection incorrecte.")
            btnEprNon.Checked = True
            Exit Sub
        End If

        Dim chkbx As CheckBox
        For Each chkbx In grpEcrit.Controls
            If (Not chkbx.Checked) And chkbx.Enabled Then
                cbxEpr.Items.Add(chkbx.Text)
            End If
        Next
        For Each chkbx In grpOral.Controls
            If chkbx.Tag = -1 And (Not chkbx.Checked) Then
                'Si tag <> -1, déjà rentré dans l'écrit
                cbxEpr.Items.Add(chkbx.Text)
            End If
        Next
        cbxEpr.SelectedIndex = 0
        cbxEpr.Enabled = True
        pnlOblig.Enabled = False
    End Sub

    Private Sub btnEprNon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEprNon.Click
        cbxEpr.Items.Clear()
        cbxEpr.Enabled = False
        pnlOblig.Enabled = True
    End Sub

    Private Sub btnAnnul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnul.Click
        Me.Hide()
        FrmInscripRens.Reinit()
        FrmInscripRens.Show()
    End Sub

    Public Sub Reinit()
        FrmInscripRens.tpsRestant = 76

        'Chargement nom et prénom
        lblNom.Text = persActu.nom
        lblPre.Text = persActu.pre

        cbxReg.SelectedIndex = persActu.iReg
        LblLibelléNum.Visible = modif
        LblNum.Visible = modif

        cbxEpr.Items.Clear()
        cbxEpr.Enabled = False
        pnlOblig.Enabled = True
        Dim chk As CheckBox
        For Each chk In grpEcrit.Controls
            chk.Checked = False
            chk.Enabled = True
        Next chk
        For Each chk In grpOral.Controls
            chk.Checked = False
            chk.Enabled = True
        Next chk
        cptEcrit = 0
        cptOral = 0
        Call actuLblEcrit()
        Call actuLblOral()
        btnEprNon.Checked = True
    End Sub
End Class