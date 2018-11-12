<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.confirmed_label = New System.Windows.Forms.Label()
        Me.unconfirmed_label = New System.Windows.Forms.Label()
        Me.network_label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'confirmed_label
        '
        Me.confirmed_label.Location = New System.Drawing.Point(269, 9)
        Me.confirmed_label.Name = "confirmed_label"
        Me.confirmed_label.Size = New System.Drawing.Size(168, 21)
        Me.confirmed_label.TabIndex = 0
        Me.confirmed_label.Text = "0,00000000"
        Me.confirmed_label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'unconfirmed_label
        '
        Me.unconfirmed_label.Location = New System.Drawing.Point(269, 30)
        Me.unconfirmed_label.Name = "unconfirmed_label"
        Me.unconfirmed_label.Size = New System.Drawing.Size(168, 21)
        Me.unconfirmed_label.TabIndex = 1
        Me.unconfirmed_label.Text = "0,00000000"
        Me.unconfirmed_label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'network_label
        '
        Me.network_label.Location = New System.Drawing.Point(463, 9)
        Me.network_label.Name = "network_label"
        Me.network_label.Size = New System.Drawing.Size(65, 21)
        Me.network_label.TabIndex = 2
        Me.network_label.Text = "BTC"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(463, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "BTC"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 488)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.network_label)
        Me.Controls.Add(Me.unconfirmed_label)
        Me.Controls.Add(Me.confirmed_label)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents confirmed_label As Label
    Friend WithEvents unconfirmed_label As Label
    Friend WithEvents network_label As Label
    Friend WithEvents Label1 As Label
End Class
