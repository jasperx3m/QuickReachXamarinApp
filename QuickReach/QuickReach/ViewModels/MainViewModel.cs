﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace QuickReach.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        ObservableCollection<string> cards;
        public ObservableCollection<string> Cards
        {
            get { return cards; }
            set { cards = value; RaisePropertyChanged(); }
        }
        public MainViewModel()
        {
            cards = new ObservableCollection<string>
            {
                "Card No 1",
                "Card No 2",
                "Card No 3",
                "Card No 4"
            };
        }
        public event PropertyChangedEventHandler PropertyChanged;
        void RaisePropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
