Imports Newtonsoft.Json
Public Class Form1
    Dim AktuellerKontostand As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.publickey = Nothing Then
            Funktion.Create_adress()
            My.Settings.Save()
        End If
        'Process.Start("https://www.blockchain.com/de/btc/address/" + My.Settings.publickey)
        AktuellerKontostand = Funktion.get_kontostand(My.Settings.publickey)
        MsgBox(AktuellerKontostand)
    End Sub
    Private Sub CreateTrans()
        
    End Sub
End Class
