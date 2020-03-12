using System;
using System.Collections.Generic;
using System.Text;

namespace IADB.Model.BackPropagation
{
    public class Parametros
    {
        public int Id { get; set; }
        public int NumCamada { get; set; }
        public int NumMaior { get; set; }
        public int NumEntra { get; set; }
        public int NumPadrao { get; set; }
        public double TxAprende { get; set; }
        public double ErroMedio { get; set; }
    }
}
