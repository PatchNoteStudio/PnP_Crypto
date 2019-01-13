Imports System.Net
Imports System.Security.Cryptography
Imports System.Text
Imports Bitcoin
Imports Bitcoin.BitcoinUtilities
Imports Bitcoin.KeyCore
Imports System.Net.WebClient
Imports Newtonsoft.Json

Public Class Funktion
    Shared Sub Create_address()
        Dim randomtext = Convert.ToBase64String(Utilities.GetRandomBytes(39)).Replace(vbCr, "r"c).Replace(vbLf, "n"c)
        Dim keyBytes As Byte() = New SHA256Managed().ComputeHash(UTF8Encoding.UTF8.GetBytes(randomtext), 0, UTF8Encoding.UTF8.GetBytes(randomtext).Length)
        Dim pkInitialWif As PrivateKey = New PrivateKey(Globals.ProdDumpKeyVersion, keyBytes)
        Dim newprivatekey = pkInitialWif.WIFEncodedPrivateKeyString
        Dim newpublickey As New PublicKey(pkInitialWif)
        My.Settings.privatekey = newprivatekey

        My.Settings.publickey = KeyCore.BitcoinAddress.GetBitcoinAdressEncodedStringFromPublicKey(newpublickey)

    End Sub

    Shared Function get_kontostand(pubkey As String) As String()
        Dim httpClient As New WebClient
        httpClient.Encoding = Text.Encoding.UTF8
        Dim antwort = httpClient.DownloadString("https://chain.so/api/v2/get_address_balance/BTC/" + pubkey)
        Dim ergebnis = Newtonsoft.Json.Linq.JObject.Parse(antwort)
        Dim network As String = ergebnis("data")("network")
        Dim unconfirmed As String = ergebnis("data")("unconfirmed_balance")
        Dim confirmed As String = ergebnis("data")("confirmed_balance")
        Dim ergebnisse As String() = {network, unconfirmed, confirmed}
        Return ergebnisse
    End Function

    Shared Function send_money(money As Double, receiver As String) As Boolean
        
        Return False
    End Function

    Shared Function get_tx_details(txid As String) As String()
        Dim httpClient As New WebClient
        httpClient.Encoding = Text.Encoding.UTF8
        Dim antwort = httpClient.DownloadString("https://chain.so/api/v2/get_tx/BTC/" + txid)
        Dim ergebnis = Newtonsoft.Json.Linq.JObject.Parse(antwort)
        Dim network As String = ergebnis("data")("network")
        Dim unconfirmed As String = ergebnis("data")("unconfirmed_balance")
        Dim confirmed As String = ergebnis("data")("confirmed_balance")
        Dim ergebnisse As String() = {network, unconfirmed, confirmed}
        Return ergebnisse
    End Function

    Shared Function convert_currency(money As Double, convert_from As String, convert_to As String) As Double

    End Function
End Class
