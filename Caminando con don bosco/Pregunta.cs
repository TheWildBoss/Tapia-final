using System.Collections.Generic;

namespace Caminando_con_don_bosco
{
    internal class Pregunta
    {
        private string v1;
        private List<string> list;
        private string v2;

        public Pregunta(string v1, List<string> list, string v2)
        {
            this.v1 = v1;
            this.list = list;
            this.v2 = v2;
        }
    }
}