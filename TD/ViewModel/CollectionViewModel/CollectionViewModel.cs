using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD.ViewModel
{
    public abstract class CollectionViewModel<T> : ObservableCollection<T>
        where T: ViewModel
    {
        

    }
}
