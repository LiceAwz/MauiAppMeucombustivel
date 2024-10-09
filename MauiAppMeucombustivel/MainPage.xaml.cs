namespace MauiAppMeucombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Obtém os valores inseridos para etanol e gasolina
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                // Obtém os valores da marca e modelo do veículo
                string marca = txt_marca_do_veiculo.Text;
                string modelo = txt_modelo_do_veiculo.Text;

                string msg = "";
                if (etanol <= (gasolina * 0.7))
                {
                    msg = $"O etanol está compensando para o seu {marca} {modelo}.";
                }
                else
                {
                    msg = $"A gasolina está compensando para o seu {marca} {modelo}.";
                }

                // Exibe a mensagem
                DisplayAlert("Calculado", msg, "OK");

            } catch (Exception ex)
            {
                // Exibe a mensagem de erro caso ocorra algum problema
                DisplayAlert("Ops", ex.Message, "Fechar");
            }

        } // Fecha método
    } // Fecha Class
} // Fecha namespace
