using System;
using System.Collections.Generic;

namespace Day04
{
    class Library
    {
        // PART 1: Private Internal Storage 
        private Dictionary<int, string> books = new Dictionary<int, string>();

        //  PART 2: Integer-Based Indexer (Read + Write) 
        public string this[int bookId]
        {
            get
            {
                // return books[bookId];
                return books.ContainsKey(bookId) ? books[bookId] : "Book ID not found";
            }
            set
            {
                books[bookId] = value;
            }
        }

        // PART 3: String-Based Indexer (Read-Only) 
        public string this[string title]
        {
            get
            {
                var res = books.FirstOrDefault(b => b.Value == title).Value;
                return res ?? "Book title not present";
            }
        }
    }
}
