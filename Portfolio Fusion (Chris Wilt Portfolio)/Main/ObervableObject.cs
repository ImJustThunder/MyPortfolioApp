using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Portfolio_Fusion__Chris_Wilt_Portfolio_.Main
{
    internal class ObervableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
