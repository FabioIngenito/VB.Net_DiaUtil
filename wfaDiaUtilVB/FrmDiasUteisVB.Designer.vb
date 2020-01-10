<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDiaUtilVB
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblResposta = New System.Windows.Forms.Label()
        Me.GbxSomaSubtrai = New System.Windows.Forms.GroupBox()
        Me.RbtSubtrai = New System.Windows.Forms.RadioButton()
        Me.RbtSoma = New System.Windows.Forms.RadioButton()
        Me.NudDiasPrazo = New System.Windows.Forms.NumericUpDown()
        Me.LblEscolhaUmaDataNoCalendario = New System.Windows.Forms.Label()
        Me.LblDiasPrazo = New System.Windows.Forms.Label()
        Me.McaData = New System.Windows.Forms.MonthCalendar()
        Me.LblRespostaLabel = New System.Windows.Forms.Label()
        Me.DtpDataFutura = New System.Windows.Forms.DateTimePicker()
        Me.LblDataFutura = New System.Windows.Forms.Label()
        Me.DtpDataChapada = New System.Windows.Forms.DateTimePicker()
        Me.LblDataChapada = New System.Windows.Forms.Label()
        Me.BtnCalcula = New System.Windows.Forms.Button()
        Me.BtnCalculaAmanha = New System.Windows.Forms.Button()
        Me.GbxSomaSubtrai.SuspendLayout()
        CType(Me.NudDiasPrazo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblResposta
        '
        Me.LblResposta.BackColor = System.Drawing.SystemColors.Window
        Me.LblResposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblResposta.Location = New System.Drawing.Point(73, 272)
        Me.LblResposta.Name = "LblResposta"
        Me.LblResposta.Size = New System.Drawing.Size(66, 23)
        Me.LblResposta.TabIndex = 24
        '
        'GbxSomaSubtrai
        '
        Me.GbxSomaSubtrai.Controls.Add(Me.RbtSubtrai)
        Me.GbxSomaSubtrai.Controls.Add(Me.RbtSoma)
        Me.GbxSomaSubtrai.Location = New System.Drawing.Point(15, 64)
        Me.GbxSomaSubtrai.Name = "GbxSomaSubtrai"
        Me.GbxSomaSubtrai.Size = New System.Drawing.Size(124, 66)
        Me.GbxSomaSubtrai.TabIndex = 17
        Me.GbxSomaSubtrai.TabStop = False
        Me.GbxSomaSubtrai.Text = "Soma ou Subtrai"
        '
        'RbtSubtrai
        '
        Me.RbtSubtrai.AutoSize = True
        Me.RbtSubtrai.Location = New System.Drawing.Point(30, 42)
        Me.RbtSubtrai.Name = "RbtSubtrai"
        Me.RbtSubtrai.Size = New System.Drawing.Size(58, 17)
        Me.RbtSubtrai.TabIndex = 1
        Me.RbtSubtrai.Text = "Subtrai"
        Me.RbtSubtrai.UseVisualStyleBackColor = True
        '
        'RbtSoma
        '
        Me.RbtSoma.AutoSize = True
        Me.RbtSoma.Checked = True
        Me.RbtSoma.Location = New System.Drawing.Point(30, 19)
        Me.RbtSoma.Name = "RbtSoma"
        Me.RbtSoma.Size = New System.Drawing.Size(52, 17)
        Me.RbtSoma.TabIndex = 0
        Me.RbtSoma.TabStop = True
        Me.RbtSoma.Text = "Soma"
        Me.RbtSoma.UseVisualStyleBackColor = True
        '
        'NudDiasPrazo
        '
        Me.NudDiasPrazo.Location = New System.Drawing.Point(81, 38)
        Me.NudDiasPrazo.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NudDiasPrazo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudDiasPrazo.Name = "NudDiasPrazo"
        Me.NudDiasPrazo.Size = New System.Drawing.Size(58, 20)
        Me.NudDiasPrazo.TabIndex = 16
        Me.NudDiasPrazo.Value = New Decimal(New Integer() {360, 0, 0, 0})
        '
        'LblEscolhaUmaDataNoCalendario
        '
        Me.LblEscolhaUmaDataNoCalendario.AutoSize = True
        Me.LblEscolhaUmaDataNoCalendario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEscolhaUmaDataNoCalendario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblEscolhaUmaDataNoCalendario.Location = New System.Drawing.Point(12, 9)
        Me.LblEscolhaUmaDataNoCalendario.Name = "LblEscolhaUmaDataNoCalendario"
        Me.LblEscolhaUmaDataNoCalendario.Size = New System.Drawing.Size(112, 13)
        Me.LblEscolhaUmaDataNoCalendario.TabIndex = 15
        Me.LblEscolhaUmaDataNoCalendario.Text = "Escolha uma data:"
        '
        'LblDiasPrazo
        '
        Me.LblDiasPrazo.AutoSize = True
        Me.LblDiasPrazo.Location = New System.Drawing.Point(12, 40)
        Me.LblDiasPrazo.Name = "LblDiasPrazo"
        Me.LblDiasPrazo.Size = New System.Drawing.Size(63, 13)
        Me.LblDiasPrazo.TabIndex = 14
        Me.LblDiasPrazo.Text = "Dias/Prazo:"
        '
        'McaData
        '
        Me.McaData.Location = New System.Drawing.Point(148, 9)
        Me.McaData.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.McaData.MaxSelectionCount = 1
        Me.McaData.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.McaData.Name = "McaData"
        Me.McaData.TabIndex = 13
        Me.McaData.TodayDate = New Date(2020, 1, 9, 0, 0, 0, 0)
        '
        'LblRespostaLabel
        '
        Me.LblRespostaLabel.AutoSize = True
        Me.LblRespostaLabel.Location = New System.Drawing.Point(12, 273)
        Me.LblRespostaLabel.Name = "LblRespostaLabel"
        Me.LblRespostaLabel.Size = New System.Drawing.Size(55, 13)
        Me.LblRespostaLabel.TabIndex = 23
        Me.LblRespostaLabel.Text = "Resposta:"
        '
        'DtpDataFutura
        '
        Me.DtpDataFutura.Location = New System.Drawing.Point(15, 240)
        Me.DtpDataFutura.Name = "DtpDataFutura"
        Me.DtpDataFutura.Size = New System.Drawing.Size(361, 20)
        Me.DtpDataFutura.TabIndex = 22
        Me.DtpDataFutura.Value = New Date(2020, 1, 6, 12, 0, 0, 0)
        '
        'LblDataFutura
        '
        Me.LblDataFutura.AutoSize = True
        Me.LblDataFutura.Location = New System.Drawing.Point(12, 224)
        Me.LblDataFutura.Name = "LblDataFutura"
        Me.LblDataFutura.Size = New System.Drawing.Size(186, 13)
        Me.LblDataFutura.TabIndex = 21
        Me.LblDataFutura.Text = "Data Futura (somente dias contábeis):"
        '
        'DtpDataChapada
        '
        Me.DtpDataChapada.Location = New System.Drawing.Point(15, 196)
        Me.DtpDataChapada.Name = "DtpDataChapada"
        Me.DtpDataChapada.Size = New System.Drawing.Size(361, 20)
        Me.DtpDataChapada.TabIndex = 20
        Me.DtpDataChapada.Value = New Date(2020, 1, 6, 12, 0, 0, 0)
        '
        'LblDataChapada
        '
        Me.LblDataChapada.AutoSize = True
        Me.LblDataChapada.Location = New System.Drawing.Point(12, 180)
        Me.LblDataChapada.Name = "LblDataChapada"
        Me.LblDataChapada.Size = New System.Drawing.Size(354, 13)
        Me.LblDataChapada.TabIndex = 19
        Me.LblDataChapada.Text = "Data Chapada (sem considerar feriados, sáb, dom e dias NÃO contábeis):"
        '
        'BtnCalcula
        '
        Me.BtnCalcula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcula.Location = New System.Drawing.Point(15, 136)
        Me.BtnCalcula.Name = "BtnCalcula"
        Me.BtnCalcula.Size = New System.Drawing.Size(60, 35)
        Me.BtnCalcula.TabIndex = 18
        Me.BtnCalcula.Text = "&Calcula"
        Me.BtnCalcula.UseVisualStyleBackColor = True
        '
        'BtnCalculaAmanha
        '
        Me.BtnCalculaAmanha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalculaAmanha.Location = New System.Drawing.Point(81, 136)
        Me.BtnCalculaAmanha.Name = "BtnCalculaAmanha"
        Me.BtnCalculaAmanha.Size = New System.Drawing.Size(60, 35)
        Me.BtnCalculaAmanha.TabIndex = 25
        Me.BtnCalculaAmanha.Text = "&Amanhã"
        Me.BtnCalculaAmanha.UseVisualStyleBackColor = True
        '
        'FrmDiaUtilVB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 301)
        Me.Controls.Add(Me.BtnCalculaAmanha)
        Me.Controls.Add(Me.LblResposta)
        Me.Controls.Add(Me.GbxSomaSubtrai)
        Me.Controls.Add(Me.NudDiasPrazo)
        Me.Controls.Add(Me.LblEscolhaUmaDataNoCalendario)
        Me.Controls.Add(Me.LblDiasPrazo)
        Me.Controls.Add(Me.McaData)
        Me.Controls.Add(Me.LblRespostaLabel)
        Me.Controls.Add(Me.DtpDataFutura)
        Me.Controls.Add(Me.LblDataFutura)
        Me.Controls.Add(Me.DtpDataChapada)
        Me.Controls.Add(Me.LblDataChapada)
        Me.Controls.Add(Me.BtnCalcula)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDiaUtilVB"
        Me.ShowIcon = False
        Me.Text = "Verifica Número Dias Úteis VB.Net"
        Me.GbxSomaSubtrai.ResumeLayout(False)
        Me.GbxSomaSubtrai.PerformLayout()
        CType(Me.NudDiasPrazo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents LblResposta As Label
    Private WithEvents GbxSomaSubtrai As GroupBox
    Private WithEvents RbtSubtrai As RadioButton
    Private WithEvents RbtSoma As RadioButton
    Private WithEvents NudDiasPrazo As NumericUpDown
    Private WithEvents LblEscolhaUmaDataNoCalendario As Label
    Private WithEvents LblDiasPrazo As Label
    Private WithEvents McaData As MonthCalendar
    Private WithEvents LblRespostaLabel As Label
    Private WithEvents DtpDataFutura As DateTimePicker
    Private WithEvents LblDataFutura As Label
    Private WithEvents DtpDataChapada As DateTimePicker
    Private WithEvents LblDataChapada As Label
    Private WithEvents BtnCalcula As Button
    Private WithEvents BtnCalculaAmanha As Button
End Class
