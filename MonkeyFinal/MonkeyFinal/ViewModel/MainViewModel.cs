using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MonkeyFinal.ViewModel
{
    public class MainViewModel : Service.AiBaseViewModel
    {

        private string _cep;
        public string Cep
        {
            get { return _cep; }
            set { SetProperty(ref _cep, value); }
        }

        public Command BuscaCommand { get; }

        public MainViewModel()
        {

            BuscaCommand = new Command(buscaCep);

        }

        async void buscaCep()
        {

            var end = await GetAsync($"https://viacep.com.br/ws/{Cep}/json/");

            await PushAsync<ViewModel.EnderecoViewModel>(end);
        }

        public static async Task<Model.enderecoModel> GetAsync(string Url)
        {
            try
            {
                HttpClient client = new HttpClient();

                var res = await client.GetAsync(Url);

                if (res.IsSuccessStatusCode)
                {
                    Model.enderecoModel conf = JsonConvert.DeserializeObject<Model.enderecoModel>(res.Content.ReadAsStringAsync().Result);
                    return conf;
                }
                else
                {
                    return new Model.enderecoModel();
                }

            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Erro Conexão", ex.Message, "OK");
                return new Model.enderecoModel();
            }
        }
    }
}
