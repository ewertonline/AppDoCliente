using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTC.AppDoCliente.Services
{
    public class FunilariaService
    {
        public static async Task Autenticar(string usuario, string senha, Action success, Action<string> error)
        {
            //await
            //var result = await 1 + 1;

            success();
            //return true;
        }
    }
}
