﻿Imports Newtonsoft.Json
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.publickey = Nothing Then
            Funktion.Create_adress()
            My.Settings.Save()
        End If

        Process.Start("https://www.blockchain.com/de/btc/address/" + My.Settings.publickey)
    End Sub
End Class
