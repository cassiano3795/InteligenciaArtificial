using System;
using System.Collections.Generic;
using System.Text;
using Core.Services.TreinaService;
using IADB.Context;
using IADB.Model.BackPropagation;

namespace Services.Services
{
    public class BackPropagationService : IBackPropagationService
    {
        private const int Id = 1;
        private readonly ParametrosService _parametrosService;
        private readonly Parametros _parametros;

        private int[] _camadas;
        private float[][] _x;
        private float[][][] _w;
        private float _emq;
        private float[][] _em;
        private int[] _sai;
        private int[][] _ent;
        

        public BackPropagationService(ParametrosService parametrosService)
        {
            _parametrosService = parametrosService;
            _parametros = _parametrosService.Read(Id);

            _camadas = new[] {2, 2, 1};
            //_x = new float[][] {{ 1, 2 }, { 3, 4.0 }};

        }


        public void Treina()
        {
            var parametros = _parametrosService.Read(Id);
            char mostra;
            int c, n, i, j, k, l, iteracoes, linha;
        }
    }
}
