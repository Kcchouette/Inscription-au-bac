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

﻿Module Pers
    Structure Personne
        <VBFixedString(15)> Dim nom As String
        <VBFixedString(10)> Dim pre As String
        <VBFixedString(20)> Dim adr As String
        Dim cp As Integer
        <VBFixedString(15)> Dim ville As String

        Dim age As Integer
        Dim iReg As Integer

        <VBFixedArray(3)> Dim tIndEcrit() As Integer
        <VBFixedArray(2)> Dim tIndOral() As Integer
        Dim iFacult As Integer
    End Structure

    Public persActu As Personne
    Public bidon As Personne
    Public lgEnr As Integer = Len(persActu)
    Public tblEnreg(lgEnr - 1) As Byte

    Public tReg() As String = {"Auvergne", "Bordelais", "Bourgogne", "Bretagne", "Morvan", "Nord", "Normandie", "Paris", "Poitou", "Roussillon"}
    Public tMat() As String = {"Saut", "Natation", "Lancer", _
                            "Philosophie", "Mathématiques", "Géologie", "Géographie", "Français", "Biologie", _
                            "Russe", "Histoire", "Espagnol", "Astronomie", "Anglais", "Allemand"}
    Public tEcrit() As Boolean = {False, False, False, True, True, True, True, True, True, True, True, True, True, True, True}
    Public tOral() As Boolean = {True, True, True, False, False, False, False, False, False, True, True, True, True, True, True}

    Public numFicInscrit As Integer = FreeFile() 'Penser à faire fileClose

    Public Sub creerFichier()
        'Positions interdites
        tblEnreg(0) = 2
        tblEnreg(1) = 2
        FilePut(numFicInscrit, bidon, UBound(tblEnreg))
        FilePut(numFicInscrit, tblEnreg, 1)
    End Sub

    Public Sub enregCand(ByVal pers As Personne)
        FileGet(numFicInscrit, tblEnreg, 1)
        Dim numInscrit As Integer = 2
        Do Until tblEnreg(numInscrit) = 0
            numInscrit += 1
        Loop
        tblEnreg(numInscrit) = 1
        FilePut(numFicInscrit, pers, numInscrit)
        FilePut(numFicInscrit, tblEnreg, 1)
        MsgBox("Numéro d'inscrit : " & numInscrit)
    End Sub

    Public Sub supprCand(ByVal num As Integer)
        FileGet(numFicInscrit, tblEnreg, 1)
        tblEnreg(num) = 0
        FilePut(numFicInscrit, bidon, num)
        FilePut(numFicInscrit, tblEnreg, 1)
        MsgBox("L'inscrit numéro " & num & " a bien été supprimé.")
    End Sub

    Public Sub reEnregCand(ByVal pers As Personne, ByVal num As Integer)
        If tblEnreg(num) = 0 Then Exit Sub
        FilePut(numFicInscrit, pers, num)
        MsgBox("Actualisation de l'inscription numéro " & num & " effectuée.")
    End Sub

    Public Sub chargerNomPre(ByRef cbx As ComboBox, ByRef lstNum As ListBox)
        FileGet(numFicInscrit, tblEnreg, 1)
        Dim ind As Integer
        For i = 2 To UBound(tblEnreg)
            If tblEnreg(i) = 1 Then
                FileGet(numFicInscrit, persActu, i)
                ind = cbx.Items.Add(LSet(persActu.nom, 15) & " " & LSet(persActu.pre, 10))
                lstNum.Items.Insert(ind, i)
            End If
        Next i
    End Sub

    Public Function getIndiceMat(ByVal libelleMatiere As String) As Integer
        For i = 0 To UBound(tMat)
            If (libelleMatiere = tMat(i)) Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Function getTypeMat(ByVal pers As Personne, ByVal libMat As String) As String
        Dim ind As Integer = getIndiceMat(libMat)

        For i = 0 To UBound(pers.tIndEcrit)
            If pers.tIndEcrit(i) = ind Then Return "Écrit"
        Next i
        For i = 0 To UBound(pers.tIndOral)
            If pers.tIndOral(i) = ind Then Return "Oral"
        Next
        If pers.iFacult = ind Then Return "Facultatif"
        Return ""
    End Function
End Module
