Imports Newtonsoft.Json
Public Class MainForm
    Dim AktuellerKontostand As String()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.publickey = Nothing Then
            Funktion.Create_address()
            My.Settings.Save()
        End If
        'Process.Start("https://www.blockchain.com/de/btc/address/" + My.Settings.publickey)
        AktuellerKontostand = Funktion.get_kontostand(My.Settings.publickey)
        confirmed_label.Text = "Confirmed Balance: " & AktuellerKontostand(2)
        unconfirmed_label.Text = "Unconfirmed Balance: " & AktuellerKontostand(1)
        network_label.Text = AktuellerKontostand(0)
    End Sub
    Private Sub CreateTrans()

    End Sub
End Class
