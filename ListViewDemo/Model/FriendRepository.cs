using System;
using System.Collections.Generic;
using System.Linq;

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


    }
}
