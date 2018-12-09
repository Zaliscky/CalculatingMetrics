using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeTaskEMP
{
    public class DataClass
    {

     
        public List<double> NOP;
        public List<double> NOM;
        public List<double> NOC;
        public List<double> CALL;
        public List<double> NDD;
        private void FillNOP() 
        {
            NOP = new List<double>();
            NOP.Add(22);
        NOP.Add(25);
        NOP.Add(1);
        NOP.Add(1);
       NOP.Add( 43);
        NOP.Add(34);
        NOP.Add(48);
        NOP.Add(10);
        NOP.Add(21);
       NOP.Add( 64);
      NOP.Add(  25);
       NOP.Add( 3);
       NOP.Add( 18);
       NOP.Add( 62);
      NOP.Add(  25);
      NOP.Add(  13);
      NOP.Add(  1);
      NOP.Add(  112);
     NOP.Add(30);
       NOP.Add( 317);
        NOP.Add(11);
       NOP.Add( 21);
      NOP.Add(  2);
      NOP.Add(  1);
       NOP.Add( 48);
       NOP.Add( 96);
       NOP.Add( 60);
       NOP.Add( 2);
      NOP.Add(  5);
      NOP.Add(15);

         
        }
        private void FillNOM()
        {
            NOM = new List<double>();
             NOM.Add(2003);
 NOM.Add(1664);
 NOM.Add(102);
 NOM.Add(50);
 NOM.Add(1990);
 NOM.Add(879);
 NOM.Add(11770);
 NOM.Add(1261);
 NOM.Add(4258);
 NOM.Add(9871);
 NOM.Add(698);
 NOM.Add(221);
 NOM.Add(1007);
 NOM.Add(6533);
 NOM.Add(387);
 NOM.Add(614);
 NOM.Add(213);
 NOM.Add(10945);
 NOM.Add(1393);
 NOM.Add(13354);
 NOM.Add(468);
 NOM.Add(1249);
 NOM.Add(338);
 NOM.Add(152);
 NOM.Add(10951);
 NOM.Add(4611);
 NOM.Add(2909);
 NOM.Add(76);
 NOM.Add(141);
 NOM.Add(351);

        }
        private void FillNOC()
        {
            NOC = new List<double>();
            
            NOC.Add( 175);
    NOC.Add(191);
    NOC.Add(  14);
   NOC.Add(   11);
   NOC.Add(   352);
   NOC.Add(   128);
   NOC.Add(   1013);
  NOC.Add(  128);
  NOC.Add(   352);
    NOC.Add(  1397);
   NOC.Add(   108);
  NOC.Add(    25);
  NOC.Add(    145);
    NOC.Add(  795);
    NOC.Add(  83);
    NOC.Add(  93);
    NOC.Add(  12);
    NOC.Add(  848);
    NOC.Add(  105);
    NOC.Add(  1739);
   NOC.Add(   65);
    NOC.Add(  223);
   NOC.Add(   24);
   NOC.Add(   21);
   NOC.Add(   1013);
   NOC.Add(   584);
    NOC.Add(  391);
   NOC.Add(   11);
   NOC.Add(   30);
   NOC.Add(50);


        }
        private void FillCALL()
        {
            CALL = new List<double>();
            CALL.Add(6628);  
         CALL.Add( 16239);
         CALL.Add( 472);
         CALL.Add( 302);
         CALL.Add( 17441);
        CALL.Add(  2721);
        CALL.Add(  40448);
         CALL.Add( 5502);
         CALL.Add( 14548);
         CALL.Add( 19319);
       CALL.Add( 2298);
         CALL.Add( 454);
        CALL.Add(  3821);
         CALL.Add( 25546);
        CALL.Add(  938);
        CALL.Add(  2238);
        CALL.Add(  1076);
       CALL.Add(   24047);
      CALL.Add(    4424);
     CALL.Add(     39380);
     CALL.Add(     1814);
    CALL.Add(      2863);
         CALL.Add( 1516);
       CALL.Add(   689);
       CALL.Add(   38212);
       CALL.Add(   12328);
       CALL.Add(   9141);
       CALL.Add(   375);
       CALL.Add(   391);
       CALL.Add(1675);

            
        }

        private void FillNDD() 
        {
            NDD = new List<double>();
               NDD.Add( 0.10);
    NDD.Add( 0.02);
    NDD.Add( 0.0);
    NDD.Add( 0.0);
    NDD.Add( 0.15);
    NDD.Add( 0.11);
    NDD.Add( 0.10);
    NDD.Add( 0.02);
    NDD.Add( 0.11);
   NDD.Add(  0.05);
    NDD.Add( 0.10);
   NDD.Add(  0.17);
     NDD.Add(0.09);
    NDD.Add( 0.10);
   NDD.Add(  0.23);
     NDD.Add(0.18);
    NDD.Add( 0.0);
     NDD.Add(0.15);
    NDD.Add( 0.07);
    NDD.Add( 0.07);
   NDD.Add(  0.23);
   NDD.Add(  0.05);
    NDD.Add( 0.20);
     NDD.Add(0.0);
    NDD.Add( 0.10);
    NDD.Add( 0.11);
     NDD.Add(0.10);
     NDD.Add(0.12);
    NDD.Add( 0.07);
    NDD.Add(0.09);


        }
        
      
       
        public List<double> NOAV;
        public List<double> NOPA;
        public List<double> WMC;
        public List<double> TCC;
        public List<double> PNAS; 
        private void FillWMC()
        {
            WMC = new List<double>();
       

           WMC.Add(14.08);
   WMC.Add( 13.18);
    WMC.Add(12);
    WMC.Add(7.92);
   WMC.Add( 36.08);
   WMC.Add( 7.07);
   WMC.Add( 20.99);
   WMC.Add( 13.49);
    WMC.Add(12.43);
   WMC.Add( 7.55);
   WMC.Add( 9.33);
   WMC.Add( 8.28);
   WMC.Add( 12.01);
   WMC.Add( 12.90);
   WMC.Add( 4.66);
   WMC.Add( 8.20);
   WMC.Add( 8.11);
   WMC.Add( 15.30);
   WMC.Add( 12.45);
    WMC.Add(10.90);
    WMC.Add(10.03);
    WMC.Add(5.47);
   WMC.Add( 21.44);
   WMC.Add( 26.42);
    WMC.Add(18.99);
    WMC.Add(9.24);
   WMC.Add( 9.90);
   WMC.Add( 8.25);
   WMC.Add( 7.12);
   WMC.Add(11.51);
            
        }
        private void FillNOAV()
        {
            NOAV = new List<double>();
            NOAV.Add(4.32);
            NOAV.Add(2.56);
            NOAV.Add(6.87);
            NOAV.Add(5.7);
            NOAV.Add(3.81);
            NOAV.Add(3.59);
            NOAV.Add(3.86);
            NOAV.Add(4.43);
            NOAV.Add(3.89);
            NOAV.Add(5.43);
            NOAV.Add(4.88);
            NOAV.Add(2.18);
            NOAV.Add(2.79);
            NOAV.Add(3.8);
            NOAV.Add(7.69);
            NOAV.Add(4.2);
            NOAV.Add(3.95);
            NOAV.Add(3.38);
            NOAV.Add(3.55);
            NOAV.Add(3.28);
            NOAV.Add(3.37);
            NOAV.Add(3.52);
            NOAV.Add(2.36);
            NOAV.Add(3.99);
            NOAV.Add(1.67);
            NOAV.Add(4.19);
            NOAV.Add(3.97);
            NOAV.Add(2.22);
            NOAV.Add(4.85);
            NOAV.Add(20.45);

        }
        private void FillNOPA()
        {
            NOPA.Add(0.81);
            NOPA.Add(0.32);
            NOPA.Add(0.62);
            NOPA.Add(0);
            NOPA.Add(3.14);
            NOPA.Add(0.47);
            NOPA.Add(0.04);
            NOPA.Add(6.39);
            NOPA.Add(0.14);
            NOPA.Add(1.42);
            NOPA.Add(0.7);
            NOPA.Add(0.05);
            NOPA.Add(0.01);
            NOPA.Add(0);
            NOPA.Add(3.18);
            NOPA.Add(0.82);
            NOPA.Add(0.43);
            NOPA.Add(0.72);
            NOPA.Add(0.84);
            NOPA.Add(0.16);
            NOPA.Add(0.16);
            NOPA.Add(0.16);
            NOPA.Add(0.79);
            NOPA.Add(0.62);
            NOPA.Add(0.06);
            NOPA.Add(0.21);
            NOPA.Add(0.18);
            NOPA.Add(0.7);
            NOPA.Add(0.42);
            NOPA.Add(0.11);

        }
        private void FillCC()
        {
            TCC = new List<double>();
            TCC.Add(0.37);
            TCC.Add(0.60);
            TCC.Add(0.47);
            TCC.Add(0.34);
            TCC.Add(0.73);
            TCC.Add(0.29);
            TCC.Add(0.24);
            TCC.Add(  0.37);
            TCC.Add(  0.35);
            TCC.Add(0.29);
            TCC.Add(0.49);
            TCC.Add(0.58);
            TCC.Add(0.43);
            TCC.Add(0.41);
            TCC.Add(0.36);
            TCC.Add(0.49);
            TCC.Add(0.65);
            TCC.Add(0.31);
            TCC.Add(0.53);
            TCC.Add(0.47);
            TCC.Add(0.41);
            TCC.Add(0.29);
            TCC.Add(0.30);
            TCC.Add(0.49);
            TCC.Add(0.21);
            TCC.Add(0.37);
            TCC.Add(0.49);
            TCC.Add(0.52);
            TCC.Add(0.24);
            TCC.Add(0.44);


        }
        private void FillPNAS()
        {
            PNAS = new List<double>();
            PNAS.Add(-0.60);
            PNAS.Add(-0.65);
            PNAS.Add(-1);
            PNAS.Add(-1);
            PNAS.Add(-0.24);
            PNAS.Add(-0.52);
            PNAS.Add(-0.35);
            PNAS.Add(-0.87);
            PNAS.Add(-0.50);
            PNAS.Add(-0.35);
            PNAS.Add(-0.63);
            PNAS.Add(-0.50);
            PNAS.Add(-0.57);
            PNAS.Add(-0.36);
            PNAS.Add(-0.58);
            PNAS.Add(-0.64);
            PNAS.Add(-1);
            PNAS.Add(-0.31);
            PNAS.Add(-0.76);
            PNAS.Add(-0.42);
            PNAS.Add(-0.58);
            PNAS.Add(-0.75);
            PNAS.Add(-0.29);
            PNAS.Add(-1);
            PNAS.Add(-0.35);
            PNAS.Add(-0.47);
            PNAS.Add(-0.32);
            PNAS.Add(-0.52);
            PNAS.Add(-0.90);
            PNAS.Add(-0.66);

          
        }
        
        public void Serialize()
        {
            XmlSerializer serializer = new XmlSerializer(GetType());
            using (TextWriter writer = new StreamWriter(@"Data.xml"))
            {
                serializer.Serialize(writer, this);
            }
        }

        public static DataClass Deserialize()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(DataClass));
            TextReader reader = new StreamReader(@"Data.xml");
            object obj = deserializer.Deserialize(reader);
            reader.Close();
            return (DataClass)obj; 
        }
    }
}
