using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_10
{
    internal class VanBan
    {
        public string XauKiTu { get; set; }
        public VanBan() { }
        public VanBan(string st)
        {
            this.XauKiTu = st;
        }
        public int DemSoTu()
        {
            int dem = 0;
            bool trongTu = false;

            for (int i = 0; i < XauKiTu.Length; i++)
            {
                if (XauKiTu[i] != ' ')
                {
                    if (!trongTu)
                    {
                        dem++;
                        trongTu = true;
                    }
                }
                else
                {
                    trongTu = false;
                }
            }

            return dem;
        }
        public int DemSoKyTuH()
        {
            int dem = 0;
            for (int i = 0; i < XauKiTu.Length; i++)
            {
                char c = XauKiTu[i];
                if (c == 'H' || c == 'h')
                {
                    dem++;
                }
            }
            return dem;
        }
        public void ChuanHoa()
        {
            string tam = "";
            bool trongTu = false;
            for (int i = 0; i < XauKiTu.Length; i++)
            {
                char c = XauKiTu[i];

                if (c != ' ')
                {
                    tam += c;
                    trongTu = true;
                }
                else
                {
                    if (trongTu)
                    {
                        tam += ' ';
                        trongTu = false;
                    }
                }
            }

            if (tam.Length > 0 && tam[tam.Length - 1] == ' ')
                tam = tam.Substring(0, tam.Length - 1);

            XauKiTu = tam;
        }
    }
}
