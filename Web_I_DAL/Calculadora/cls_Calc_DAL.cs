using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_I_DAL.Calculadora
{
    public class cls_Calc_DAL
    {
        #region Variables Privadas

        private int _bNum_I, _bNum_II;
        private char _cSigno;
        private float _fResultado;

        #endregion

        #region Variables Públicas
        public int bNum_I { get => _bNum_I; set => _bNum_I = value; }
        public int bNum_II { get => _bNum_II; set => _bNum_II = value; }
        public char cSigno { get => _cSigno; set => _cSigno = value; }
        public float fResultado { get => _fResultado; set => _fResultado = value; }

        #endregion

    }
}
