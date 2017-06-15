using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villafjordhoej._Model
{
    class M_CollectedMellemVaerelser
    {

        public Me_Vaerelser MeVaerelser { get; set; }
        public M_Vaerelse MVaerelse { get; set; }


        public M_CollectedMellemVaerelser(Me_Vaerelser meVaerelser, M_Vaerelse mVaerelse)
        {
            MeVaerelser = meVaerelser;
            MVaerelse = mVaerelse;
        }
    }
}
