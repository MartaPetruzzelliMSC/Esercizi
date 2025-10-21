using CodeFirstExample2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample2
{
    public class App
    {
        private readonly CodeFirstDbContext _context;

        public App(CodeFirstDbContext context)
        {
            _context = context;
        }

        public void Run()
        {

        }
    }
}
