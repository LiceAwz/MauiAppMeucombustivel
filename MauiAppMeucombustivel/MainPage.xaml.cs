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

                double etanal = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string msg = "";
                if (etanal <= (gasolina * 0.7))
                {
                    msg = "O etanol está compensando.";
                }
                else
                {
                    msg = "A gasolina está compensado.";
                }

                DisplayAlert("Calculado", msg, "OK");

            } catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }

        } // Fecha método
    } // Fecha Class
} // Fecha namespace
