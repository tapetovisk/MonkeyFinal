using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MonkeyFinal.Service
{
    public class AiBaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetProperty<T>(ref T Store, T value, [CallerMemberName]string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(Store, value))
                return false;

            Store = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public async Task PushAsync<TViewModel>(params object[] args) where TViewModel : AiBaseViewModel
        {
            var viewModelType = typeof(TViewModel);
            var viewModelTypeName = viewModelType.Name;
            var viewModelTypeWordLegth = "ViewModel".Length;
            var viewTypeName = $"MonkeyFinal.View.{viewModelTypeName.Substring(0, viewModelTypeName.Length - viewModelTypeWordLegth)}Page";
            var viewType = Type.GetType(viewTypeName);

            var page = Activator.CreateInstance(viewType) as Page;

            var viewModel = Activator.CreateInstance(viewModelType, args);
            if (page != null)
            {
                page.BindingContext = viewModel;
            }

            await Application.Current.MainPage.Navigation.PushAsync(page);
        }

    }
}
