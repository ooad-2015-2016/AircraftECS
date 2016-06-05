using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Official.ViewModels
{
    class PrikazParametaraViewModel
    {
        public double gornja;
        public double donja;

        public double DajGornju()
        {
            gornja = Official.ViewModels.UnosParametaraViewModel.DajBrzinu() + 0.5*Official.ViewModels.UnosParametaraViewModel.DajBrzinu();
            return gornja;
        }

        public double DajDonju()
        {
            donja = Official.ViewModels.UnosParametaraViewModel.DajBrzinu() - 0.5 * Official.ViewModels.UnosParametaraViewModel.DajBrzinu();
            return donja;
        }


    }
}
