Public Class FrmDiaUtilVB

    Private Sub FrmDiaUtilVB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        McaData.TodayDate = Now
        'Funciona também:
        'McaData.SelectionStart = Convert.ToDateTime("2020/01/06 12:00")
        McaData.SelectionStart = New DateTime(2020, 1, 6, 12, 0, 0)
    End Sub

    Private Sub BtnCalcula_Click(sender As Object, e As EventArgs) Handles BtnCalcula.Click
        Dim DblDiasUteis As Double = Convert.ToDouble(NudDiasPrazo.Value)

        DtpDataChapada.Value = McaData.SelectionStart.AddDays(DblDiasUteis)
        DblDiasUteis = ClsDiaUtilVB.NumeroDiasUteis(DblDiasUteis, McaData.SelectionStart, RbtSoma.Checked)
        DtpDataFutura.Value = McaData.SelectionStart.AddDays(DblDiasUteis)
        LblResposta.Text = DblDiasUteis.ToString()
    End Sub

    Private Sub BtnCalculaAmanha_Click(sender As Object, e As EventArgs) Handles BtnCalculaAmanha.Click
        Dim DblDiasUteis As Double = 1

        'A conversão abaixo no VB.Net é implícita, no C# é obrigatória!
        'NudDiasPrazo.Value = Convert.ToDouble(DblDiasUteis)
        NudDiasPrazo.Value = DblDiasUteis
        McaData.SelectionStart = Now

        DtpDataChapada.Value = McaData.SelectionStart.AddDays(DblDiasUteis)
        DblDiasUteis = ClsDiaUtilVB.NumeroDiasUteis(DblDiasUteis, Nothing)
        DtpDataFutura.Value = McaData.SelectionStart.AddDays(DblDiasUteis)
        LblResposta.Text = DblDiasUteis.ToString()
    End Sub

End Class
