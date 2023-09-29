using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Lumpkin_Dalton
{
    internal class Game
    {
        public string Title { get; }
        public char Esbr { get; }

        public string Genre { get; }

        public Game(string titleParam, char EsbrParam, string genreParam)
        {
            Title = titleParam;
            Esbr = EsbrParam;
            Genre = genreParam;
        }
    }
}
