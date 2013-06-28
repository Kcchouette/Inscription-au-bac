Public Class FrmInscripRens
    Dim ageMin As Integer = 25
    Dim ageMax As Integer = 55
    Dim nbCran As Integer = ageMax - ageMin
    Public tpsRestant As Integer
    Public modif As Boolean

    Private Sub btnSuiv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSuiv.Click
        Dim valid As Boolean = True

        If txtVille.Text.Length = 0 Then
            lblVille.ForeColor = Color.Red
            valid = False
            txtVille.Focus()
        End If

        If txtCP.Text.Length <> 5 Or Mid(txtCP.Text, 1, 2) = "00" Then
            lblCP.ForeColor = Color.Red
            valid = False
            txtCP.Focus()
        End If

        If txtPre.Text.Length = 0 Then
            lblPre.ForeColor = Color.Red
            valid = False
            txtPre.Focus()
        End If

        If txtNom.Text.Length = 0 Then
            lblNom.ForeColor = Color.Red
            valid = False
            txtNom.Focus()
        End If

        If valid Then
            persActu.nom = txtNom.Text
            persActu.pre = txtPre.Text
            persActu.adr = txtAdr.Text
            persActu.cp = txtCP.Text
            persActu.ville = txtVille.Text
            persActu.age = txtAge.Text
            Me.Hide()
            FrmInscripRegEpreuves.Show()
            FrmInscripRegEpreuves.modif = modif
            FrmInscripRegEpreuves.LblNum.Text = LblNum.Text
            FrmInscripRegEpreuves.Reinit()
        Else
            MsgBox("Renseignement obligatoire non renseigné", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub KeyPress_alpha(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNom.KeyPress, txtPre.KeyPress, txtVille.KeyPress
        Dim c As Char
        c = e.KeyChar
        c = UCase(c)
        Dim s As String = " " & vbBack 'Pas d'accents

        If (s.IndexOf(c) > -1) Then ' s'il n'était pas dans la chaîne, index = -1
            Exit Sub
        End If

        If (c >= "A" And c <= "Z") Then
            Exit Sub
        End If
        e.KeyChar = Chr(0)
    End Sub

    Private Sub KeyPress_num(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtAge.KeyPress, txtCP.KeyPress
        If (e.KeyChar = vbBack) Then
            Exit Sub
        End If
        If (e.KeyChar >= "0" And e.KeyChar <= "9") Then
            Exit Sub
        End If
        e.KeyChar = Chr(0)
    End Sub

    Private Sub FrmInscripRens_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tag = Me.Text & " "
        txtCP.Tag = lblCP
        txtVille.Tag = lblVille
        txtPre.Tag = lblPre
        txtNom.Tag = lblNom

        'ScrollBar
        hscAge.SmallChange = 1
        hscAge.LargeChange = 5
        hscAge.Minimum = 0
        hscAge.Maximum = nbCran + (hscAge.LargeChange - 1)
        If persActu.age = 0 Then
            hscAge.Value = nbCran \ 2
        Else
            hscAge.Value = persActu.age - ageMin
            txtNom.Text = persActu.nom
            txtPre.Text = persActu.pre
            txtCP.Text = persActu.cp
            txtVille.Text = persActu.ville
            txtAdr.Text = persActu.adr
        End If
        Call actuTxtAge()
        tpsRestant = 61
        Call tmrReste_Tick(sender, e)
    End Sub

    Private Sub btnAband_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAband.Click
        Me.Hide()
        tmrReste.Stop()
        FrmAccueil.Show()
    End Sub

    Private Sub actuTxtAge()
        txtAge.Text = ageMin + hscAge.Value
    End Sub

    Private Sub hscAge_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hscAge.Scroll
        Call actuTxtAge()
    End Sub

    Public Sub tmrReste_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrReste.Tick
        On Error Resume Next
        tpsRestant -= 1
        ActiveForm.Text = ActiveForm.Tag & TimeOfDay & " Il reste " & tpsRestant & "s"
        If tpsRestant < 1 Then
            tmrReste.Stop()
            MsgBox("Fin du temps")
            Call btnAband_Click(sender, e)
        End If
    End Sub

    Private Sub txt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCP.TextChanged, txtNom.TextChanged, txtPre.TextChanged, txtVille.TextChanged
        sender.Tag.ForeColor = DefaultForeColor
    End Sub

    Private Sub txtAdr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdr.KeyPress
        Dim c As Char
        c = e.KeyChar
        c = UCase(c)
        Dim s As String = " " & vbBack 'Pas d'accents

        If (s.IndexOf(c) > -1) Then ' s'il n'était pas dans la chaîne, index = -1
            Exit Sub
        End If

        If (c >= "A" And c <= "Z") Then
            Exit Sub
        End If

        If (e.KeyChar >= "0" And e.KeyChar <= "9") Then
            Exit Sub
        End If
        e.KeyChar = Chr(0)
    End Sub

    Private Sub txt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNom.LostFocus, txtPre.LostFocus, txtVille.LostFocus
        sender.Text = Trim(UCase(sender.Text))
    End Sub

    Private Sub txtAdr_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAdr.LostFocus
        sender.Text = Trim(sender.Text)
    End Sub

    Public Sub Reinit()
        'Nécessaire car cp est un Integer et non un String
        If persActu.cp <> 0 Then
            txtCP.Text = Trim(persActu.cp)
        Else
            txtCP.Text = ""
        End If
        txtAdr.Text = Trim(persActu.adr)
        txtNom.Text = Trim(persActu.nom)
        txtPre.Text = Trim(persActu.pre)
        txtVille.Text = Trim(persActu.ville)
        hscAge.Value = nbCran \ 2
        Call actuTxtAge()

        LblLibelléNum.Visible = modif
        LblNum.Visible = modif

        'timers
        FrmAccueil.tmrHeureActu.Stop()
        tpsRestant = 61
        tmrReste.Start()
    End Sub
End Class