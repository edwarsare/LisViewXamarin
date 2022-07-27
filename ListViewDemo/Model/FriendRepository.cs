using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ListViewDemo.Helpers;

namespace ListViewDemo.Model
{
    public class FriendRepository
    {
        public List<Friend> Friends = new List<Friend>();

        

        public FriendRepository()
        {
            
        }

        public List<Friend> GetFriends()
        {
            Friends.Add(
                new Friend()
                {
                    FirstName = "Juan",
                    Phone = "5555000023"
                }
            );

            Friends.Add(
                new Friend()
                {
                    FirstName = "Maria",
                    Phone = "5555000023"
                }
            );

            Friends.Add(
                new Friend()
                {
                    FirstName = "Pedro",
                    Phone = "5555000023"
                }
            );

            Friends.Add(
                new Friend()
                {
                    FirstName = "Cesar",
                    Phone = "5555000023"
                }
            );

            Friends.Add(
                new Friend()
                {
                    FirstName = "Julio",
                    Phone = "5555000023"
                }
            );

            return Friends;
        }

        public List<Friend> GetFriendsByFirstLetter(string letter)
        {
            
            var query = from q in Friends
                        where q.FirstName.StartsWith(letter)
                        select q;

            return query.ToList();
        }

        public ObservableCollection<Grouping<string,Friend>> GetAllGrouped()
        {
            Friends.Add(
                new Friend()
                {
                    FirstName = "Juan",
                    Phone = "5555000023"
                }
            );

            Friends.Add(
                new Friend()
                {
                    FirstName = "Maria",
                    Phone = "5555000023"
                }
            );

            Friends.Add(
                new Friend()
                {
                    FirstName = "Pedro",
                    Phone = "5555000023"
                }
            );

            Friends.Add(
                new Friend()
                {
                    FirstName = "Cesar",
                    Phone = "5555000023"
                }
            );

            Friends.Add(
                new Friend()
                {
                    FirstName = "Julio",
                    Phone = "5555000023"
                }
            );

            var sorted = from f in Friends
                         orderby f.FirstName
                         group f by f.FirstName[0].ToString()
                         into theGroup
                         select new Grouping<string, Friend>(theGroup.Key, theGroup);

            return new ObservableCollection<Grouping<string, Friend>>(sorted);

            
        }


    }
}
