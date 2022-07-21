using System;
using System.Collections.Generic;
using System.Linq;
using ListViewDemo.Model;

namespace ListViewDemo.ViewModel
{
    public class MainPageViewModel
    {
        public IList<Friend> Friends { get; set; }

        public MainPageViewModel()
        {
            FriendRepository repository = new FriendRepository();
            Friends = repository.GetFriends().ToList();
        }


    }
}
