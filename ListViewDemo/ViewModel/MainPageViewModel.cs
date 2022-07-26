﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ListViewDemo.Helpers;
using ListViewDemo.Model;

namespace ListViewDemo.ViewModel
{
    public class MainPageViewModel
    {
        public ObservableCollection<Grouping<string, Friend>> Friends { get; set; }

        public MainPageViewModel()
        {
            FriendRepository repository = new FriendRepository();
            Friends = repository.GetAllGrouped();
        }


    }
}
