using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyFinal.Model
{
    public class enderecoModel:Service.AiBaseViewModel
    {

        private string _cep;
        public string cep
        {
            get { return _cep; }
            set { SetProperty(ref _cep, value); }
        }

        private string _logradouro;
        public string logradouro
        {
            get { return _logradouro; }
            set { SetProperty(ref _logradouro, value); }
        }

        private string _complemento;
        public string complemento
        {
            get { return _complemento; }
            set { SetProperty(ref _complemento, value); }
        }

        private string _bairro;
        public string bairro
        {
            get { return _bairro; }
            set { SetProperty(ref _bairro, value); }
        }

        private string _localidade;
        public string localidade
        {
            get { return _localidade; }
            set { SetProperty(ref _localidade, value); }
        }

        private string _uf;
        public string uf
        {
            get { return _uf; }
            set { SetProperty(ref _uf, value); }
        }

        private string _unidade;
        public string unidade
        {
            get { return _unidade; }
            set { SetProperty(ref _unidade, value); }
        }

        private string _ibge;
        public string ibge
        {
            get { return _ibge; }
            set { SetProperty(ref _ibge, value); }
        }

        private string _gia;

        public string gia
        {
            get { return _gia; }
            set { SetProperty(ref _gia, value); }
        }
    }
}
