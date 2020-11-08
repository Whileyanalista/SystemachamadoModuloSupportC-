using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systemachamado.ModellGetSet
{
    //CLASSE QUE MANIPULA OS VALORE 
    public class Chamado
    {
        public int id_chamado { get; set; }
        public string abertura{ get; set; }
        public string horaAb { get; set; }
        public string produto { get; set; }
        public string observacao { get; set; }
        public string fechamento { get; set; }
        public string horaSa { get; set; }
        public string situacao { get; set; }
        public int id_acesso { get; set; }
    }
}
