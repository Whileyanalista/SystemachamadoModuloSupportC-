using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systemachamado.ModellGetSet
{
    //CLASSE QUE MANIPULA OS VALORE  
    public class Acesso
    {
        public int id_acesso { get; set; }
        public string setor { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string perfil { get; set; }     

    }
}
