using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeTaskEMP
{
    class Program
    {
        public Program(DataClass dc, _4lab FLab, _5lab FFLab)
        {
            MainUI(dc, FLab, FFLab);
        }
        void MainUI(DataClass dc, _4lab FLab, _5lab FFLab)
        {
            while (true)
            {
                Console.WriteLine("1. Primary statistical analysis");
                Console.WriteLine("2. Correlation/regression");
                Console.WriteLine("------------------------------");
        
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        _4lab_UI(FLab, dc);
                        break;
                    case 2:
                        _5lab_UI(FFLab, dc);
                        break;
                    case 3:
                       dc.Serialize();
                        break;
                    default:
                        break;
                }
            }
        }

        private void _5lab_UI(_5lab FFLab, DataClass dc)
        {
            Console.WriteLine("What direct metrics?");
            Console.WriteLine("1.  NOP");
            Console.WriteLine("2.  NOM");
            Console.WriteLine("3.  NOC");
            Console.WriteLine("4.  CALL");
            Console.WriteLine("5.  NDD");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    _5lab_UI2(dc.NOP, FFLab, dc);
                    break;
                case 2:
                    _5lab_UI2(dc.NOM, FFLab, dc);
                    break;
                case 3:
                    _5lab_UI2(dc.NOC, FFLab, dc);
                    break;
                case 4:
                    _5lab_UI2(dc.CALL, FFLab, dc);
                    break;
                case 5:
                    _5lab_UI2(dc.NDD, FFLab, dc);
                    break;
                default:
                    break;
            }

        }
        private void _5lab_UI2(List<double> x, _5lab FFlab, DataClass dc)
        {
            Console.WriteLine("What indirect metric?");
            Console.WriteLine("1.  WMC");
            Console.WriteLine("2.  NOAV");
            Console.WriteLine("3.  NOPA");
            Console.WriteLine("4.  TCC");
            Console.WriteLine("5.  PNAS");
            int i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:
                    FFlab.UI(x, dc.WMC);
                    break;
                case 2:
                    FFlab.UI(x, dc.NOAV);
                    break;
                case 3:
                    FFlab.UI(x, dc.NOPA);
                    break;
                case 4:
                    FFlab.UI(x, dc.TCC);
                    break;
                case 5:
                    FFlab.UI(x, dc.PNAS);
                    break;
                default:
                    break;
            }
        }



        private void _4lab_UI(_4lab FLab, DataClass dc)
        {
            Console.WriteLine("What metrics?");
            Console.WriteLine("1.  NOP");
            Console.WriteLine("2.  NOM");
            Console.WriteLine("3.  NOC");
            Console.WriteLine("4.  CALL");
            Console.WriteLine("5.  NDD");
            Console.WriteLine("6.  WMC");
            Console.WriteLine("7.  NOAV");
            Console.WriteLine("8.  NOPA");
            Console.WriteLine("9.  TCC");
            Console.WriteLine("10. PNAS");
            int i = int.Parse(Console.ReadLine());
            do
            {
                switch (i)
                {
                    case 1:
                        FLab.UI(dc.NOP);
                        break;
                    case 2:
                        FLab.UI(dc.NOM);
                        break;
                    case 3:
                        FLab.UI(dc.NOC);
                        break;
                    case 4:
                        FLab.UI(dc.CALL);
                        break;
                    case 5:
                        FLab.UI(dc.NDD);
                        break;
                    case 6:
                        FLab.UI(dc.WMC);
                        break;
                    case 7:
                        FLab.UI(dc.NOAV);
                        break;
                    case 8:
                        FLab.UI(dc.NOPA);
                        break;
                    case 9:
                        FLab.UI(dc.TCC);
                        break;
                    case 10:
                        FLab.UI(dc.PNAS);
                        break;
                    default:
                        break;
                }

            }
            while (i == 0);
        }
            
        static void Main(string[] args)
        {
         
            new Program(DataClass.Deserialize(), new _4lab(), new _5lab());
        }
    }
}
