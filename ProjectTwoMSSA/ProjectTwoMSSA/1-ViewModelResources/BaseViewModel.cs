using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ProjectTwoMSSA._1_ViewModelResources
{
    internal partial class BaseViewModel : ObservableObject, INotifyPropertyChanged, INotifyPropertyChanging
    {
        public BaseViewModel() { }

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool _isBusy;
        [ObservableProperty]
        string _title;

        public bool IsNotBusy => !IsBusy;
        
        // Everything below this line is encapsulated by the above implementation, which is kind of cool. 
        /*public event PropertyChangedEventHandler PropertyChanged;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                if (_isBusy == value)
                    return;

                _isBusy = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsNotBusy));
            }
        }

        public bool IsNotBusy => !IsBusy;

        public string Title
        {
            get => _title;
            set
            {
                if (_title == value)
                    return;

                _title = value;
                OnPropertyChanged();
            }
        }

        public void OnPropertyChanged([CallerMemberName]string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }*/
    }
}
