using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        [DisplayName("Joke question")]
        public string JokeQuestion { get; set; }
        [DisplayName("Joke answer")]
        public string JokeAnswer { get; set; }
        [DisplayName("Joke author")]
        public string JokeAuthor { get; set; }

        public Joke()
        {

        }
    }
}
