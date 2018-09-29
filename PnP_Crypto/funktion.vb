Imports System.Net
Imports System.Security.Cryptography
Imports System.Text
Imports Bitcoin
Imports Bitcoin.BitcoinUtilities
Imports Bitcoin.KeyCore
Imports System.Net.WebClient
Imports Newtonsoft.Json

Public Class Funktion
    Shared Sub Create_adress()
        Dim randomtext = Convert.ToBase64String(Utilities.GetRandomBytes(39)).Replace(vbCr, "r"c).Replace(vbLf, "n"c)
        Dim keyBytes As Byte() = New SHA256Managed().ComputeHash(UTF8Encoding.UTF8.GetBytes(randomtext), 0, UTF8Encoding.UTF8.GetBytes(randomtext).Length)
        Dim pkInitialWif As PrivateKey = New PrivateKey(Globals.ProdDumpKeyVersion, keyBytes)
        Dim newprivatekey = pkInitialWif.WIFEncodedPrivateKeyString

        Dim newpublickey As New PublicKey(pkInitialWif)
        My.Settings.privatekey = newprivatekey

        My.Settings.publickey = KeyCore.BitcoinAddress.GetBitcoinAdressEncodedStringFromPublicKey(newpublickey)

    End Sub

    Shared Function get_kontostand(pubkey As String) As String
        Dim kontostand As New WebClient
        Dim ergebnis = JsonConvert.SerializeObject(kontostand.OpenRead("https://chain.so/api/v2/get_address_balance/BTC/" + pubkey))

    End Function
End Class
