using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTC.AppDoCliente.Views.PaginaTeste
{

    public class PaginaTesteMenuItem
    {
        public PaginaTesteMenuItem()
        {
            TargetType = typeof(PaginaTesteDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}
