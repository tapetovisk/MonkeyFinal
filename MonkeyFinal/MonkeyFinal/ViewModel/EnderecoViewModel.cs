using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyFinal.ViewModel
{
    public class EnderecoViewModel:Service.AiBaseViewModel
    {
        public Model.enderecoModel endereco { get; set; }

        public  EnderecoViewModel(Model.enderecoModel Endereco)
        {
            endereco = Endereco;
        }
    }
}
