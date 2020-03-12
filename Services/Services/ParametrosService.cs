using System;
using System.Collections.Generic;
using System.Text;
using IADB.Context;
using IADB.Model.BackPropagation;

namespace Services.Services
{
    public class ParametrosService : BaseService<Parametros>
    {
        private readonly Context _context;
        public ParametrosService(Context context) : base(context)
        {
            _context = context;
        }
    }
}
