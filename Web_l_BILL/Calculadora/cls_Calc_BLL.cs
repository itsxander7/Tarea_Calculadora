using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_I_DAL.Calculadora;

namespace Web_l_BILL.Calculadora
{
    public class cls_Calc_BLL
    {
        #region MyRegion

        public void Calculadora_Cool(ref cls_Calc_DAL Obj_Calc_Dal)
        {
            switch (Obj_Calc_Dal.cSigno)
            {
                case '+':
                    {
                        Obj_Calc_Dal.fResultado = Obj_Calc_Dal.bNum_I + Obj_Calc_Dal.bNum_I;

                        break;
                    }
                case '-':
                    {
                        Obj_Calc_Dal.fResultado = Obj_Calc_Dal.bNum_I - Obj_Calc_Dal.bNum_I;

                        break;
                    }
                case '*':
                    {
                        Obj_Calc_Dal.fResultado = Obj_Calc_Dal.bNum_I * Obj_Calc_Dal.bNum_I;

                        break;
                    }
                case '/':
                    {
                        Obj_Calc_Dal.fResultado = Obj_Calc_Dal.bNum_I / Obj_Calc_Dal.bNum_I;

                        break;
                    }
                case '%':
                    {
                        Obj_Calc_Dal.fResultado = Obj_Calc_Dal.bNum_I % Obj_Calc_Dal.bNum_I;

                        break;
                    }

                default:
                    break;

            }
        }
        #endregion
    }
}
