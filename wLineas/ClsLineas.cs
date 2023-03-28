using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace wLineas
{
    class ClsLineas
    {
        private int Xinicial;
        private int Xfinal;
        private int Yinicial;
        private int Yfinal;

        private static int Cuenta = 0;

        public ClsLineas()
        {
            Xinicial = 0;
            Xfinal = 0;
            Yinicial = 0;
            Yfinal = 0;
        }

        public ClsLineas(int Xinicial, int Xfinal, int Yinicial, int Yfinal)
        {
            this.Xinicial = Xinicial;
            this.Xfinal = Xfinal;
            this.Yinicial = Yinicial;
            this.Yfinal = Yfinal;

        }

        public ClsLineas(double Xinicial, double Xfinal, double Yinicial, double Yfinal)
        {
            this.Xinicial = (int)Xinicial;
            this.Xfinal = (int)Xfinal;
            this.Yinicial = (int)Yinicial;
            this.Yfinal = (int)Yfinal;

        }


        public int obtenxi()
        {
            return Xinicial;
        }       
        public int obtenyi()
        {
            return Yinicial;
        }
        public int obtenyf()
        {
            return Yfinal;
        }
        public int obtenxf()
        {
            return Xfinal;
        }



        public static int SubirCuenta()
        {
            Cuenta += 1;
            return Cuenta;
        }



    }
}
