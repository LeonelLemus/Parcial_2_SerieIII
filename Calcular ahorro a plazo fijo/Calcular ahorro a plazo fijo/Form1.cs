private void btnCalcular_Click(object sender, EventArgs e)
{
    // Obtener las entradas del usuario
    double montoInicial = double.Parse(txtMontoInicial.Text);
    double tasaInteresAnual = double.Parse(txtTasaInteresAnual.Text);
    double periodoTiempo = double.Parse(txtPeriodoTiempo.Text);

    // Calcular el capital final
    double capitalFinal = montoInicial * Math.Pow(1 + tasaInteresAnual / 100, periodoTiempo);

    // Calcular los intereses acumulados
    double interesesAcumulados = capitalFinal - montoInicial;

    // Mostrar los resultados
    txtCapitalFinal.Text = capitalFinal.ToString("0.00");
    txtInteresesAcumulados.Text = interesesAcumulados.ToString("0.00");
}
