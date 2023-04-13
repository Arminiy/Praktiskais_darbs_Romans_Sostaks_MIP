using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktiskais_darbs_Romans_Sostaks_MIP
{
    public partial class Form1 : Form
    {
       

        int pirmaspeletajarezultats; /*speletaja kopejais punktu skaits*/

        int pirmaissoliscipars;    /* Speletaja 1 sola izveletais cipars*/
        int otraissoliscipars;     /* Speletaja 2 sola izveletais cipars*/
        int tresaissoliscipars;/* Speletaja 3 sola izveletais cipars*/
        int ceturtaissoliscipars;/* Speletaja 4 sola izveletais cipars*/
        int piektaissoliscipars;/* Speletaja 5 sola izveletais cipars*/
        int sestaissoliscipars;/* Speletaja 6 sola izveletais cipars*/
        int septitaissoliscipars;/* Speletaja 7 sola izveletais cipars*/
        int astotaissoliscipars;/* Speletaja 8 sola izveletais cipars*/
        int devitaissoliscipars;/* Speletaja 9 sola izveletais cipars*/
        int desmitaissoliscipars;/* Speletaja 10 sola izveletais cipars*/
        int vienpadsmitaissoliscipars;/* Speletaja 11 sola izveletais cipars*/
        int divpadsmitaissoliscipars;/* Speletaja 12 sola izveletais cipars*/
        int trispadsmitaissoliscipars;/* Speletaja 13 sola izveletais cipars*/
        int cetrpadsmitaissoliscipars;/* Speletaja 14 sola izveletais cipars*/

        int otraspeletajarezultats;    /*datora kopejais punktu skaits*/
        int pirmaissoliscipars2;    /* Datora 1 sola izveletais cipars*/
        int otraissoliscipars2;     /* Datora 2 sola izveletais cipars*/
        int tresaissoliscipars2;/* Datora 3 sola izveletais cipars*/
        int ceturtaissoliscipars2;/* Datora 4 sola izveletais cipars*/
        int piektaissoliscipars2;/* Datora 5 sola izveletais cipars*/
        int sestaissoliscipars2;/* Datora 6 sola izveletais cipars*/
        int septitaissoliscipars2;/* Datora 7 sola izveletais cipars*/
        int astotaissoliscipars2;/* Datora 8 sola izveletais cipars*/
        int devitaissoliscipars2;/* Datora 9 sola izveletais cipars*/
        int desmitaissoliscipars2;/* Datora 10 sola izveletais cipars*/
        int vienpadsmitaissoliscipars2;/* Datora 11 sola izveletais cipars*/
        int divpadsmitaissoliscipars2;/* Datora 12 sola izveletais cipars*/
        int trispadsmitaissoliscipars2;/* Datora 13 sola izveletais cipars*/
        int cetrpadsmitaissoliscipars2;/* Datora 14 sola izveletais cipars*/

        int Max = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)    /*apstiprinat 1 speletajs*/
        {
            string pirmaissolis = textBox2.Text;
            string otraissolis = textBox3.Text;
            string tresaissolis = textBox7.Text;
            string ceturtaissolis = textBox8.Text;
            string piektaissolis = textBox9.Text;
            string sestaissolis = textBox10.Text;
            string septitaissolis = textBox11.Text;
            string astotaissolis = textBox12.Text;
            string devitaissolis = textBox20.Text;
            string desmitaissolis = textBox21.Text;
            string vienpadsmitaissolis = textBox22.Text;
            string divpadsmitaissolis = textBox23.Text;
            string trispadsmitaissolis = textBox24.Text;
            string cetrpadsmitaissolis = textBox25.Text;


            pirmaissoliscipars = Convert.ToInt32(pirmaissolis);
            otraissoliscipars = Convert.ToInt32(otraissolis);
            tresaissoliscipars = Convert.ToInt32(tresaissolis);
            ceturtaissoliscipars = Convert.ToInt32(ceturtaissolis);
            piektaissoliscipars = Convert.ToInt32(piektaissolis);
            sestaissoliscipars = Convert.ToInt32(sestaissolis);
            septitaissoliscipars = Convert.ToInt32(septitaissolis);
            astotaissoliscipars = Convert.ToInt32(astotaissolis);
            devitaissoliscipars = Convert.ToInt32(devitaissolis);
            desmitaissoliscipars = Convert.ToInt32(desmitaissolis);
            vienpadsmitaissoliscipars = Convert.ToInt32(vienpadsmitaissolis);
            divpadsmitaissoliscipars = Convert.ToInt32(divpadsmitaissolis);
            trispadsmitaissoliscipars = Convert.ToInt32(trispadsmitaissolis);
            cetrpadsmitaissoliscipars = Convert.ToInt32(cetrpadsmitaissolis);

            pirmaspeletajarezultats = 3 + pirmaissoliscipars + otraissoliscipars + tresaissoliscipars + ceturtaissoliscipars + piektaissoliscipars + sestaissoliscipars + septitaissoliscipars +astotaissoliscipars +devitaissoliscipars +desmitaissoliscipars +vienpadsmitaissoliscipars+divpadsmitaissoliscipars+trispadsmitaissoliscipars+cetrpadsmitaissoliscipars;

            textBox1.Text = pirmaspeletajarezultats.ToString();

            String Speletajs1 = " Spēlētājs 1 ";
            String dat = " Dators ";
            String nichja = "Spēles rezultāts - neizšķirts";
            if (pirmaspeletajarezultats == 42 & otraspeletajarezultats == 42)              
            
            {
                textBox19.Text = nichja;

            }
            else if (pirmaspeletajarezultats>42)                           
            {
                textBox19.Text = dat;                                              

            }
            else if (pirmaspeletajarezultats == 42)
                {
                textBox19.Text = Speletajs1;
            }
        }

        private void button2_Click(object sender, EventArgs e)     /*apstiprinat dators*/
        {
            string pirmaissolis2 = textBox4.Text;
            string otraissolis2 = textBox5.Text;
            string tresaisssolis2 = textBox13.Text;
            string ceturtaisssolis2 = textBox14.Text;
            string piektaisssolis2 = textBox15.Text;
            string sestaisssolis2 = textBox16.Text;
            string septitaisssolis2 = textBox17.Text;
            string astotaisssolis2 = textBox18.Text;
            string devitaissolis2 = textBox26.Text;
            string desmitaissolis2 = textBox27.Text;
            string vienpadsmitaissolis2 = textBox28.Text;
            string divpadsmitaissolis2 = textBox29.Text;
            string trispadsmitaissolis2 = textBox30.Text;
            string cetrpadsmitaissolis2 = textBox31.Text;

            pirmaissoliscipars2 = Convert.ToInt32(pirmaissolis2);
            otraissoliscipars2 = Convert.ToInt32(otraissolis2);
            tresaissoliscipars2 = Convert.ToInt32(tresaisssolis2);
            ceturtaissoliscipars2 = Convert.ToInt32(ceturtaisssolis2);
            piektaissoliscipars2 = Convert.ToInt32(piektaisssolis2);
            sestaissoliscipars2 = Convert.ToInt32(sestaisssolis2);
            septitaissoliscipars2 = Convert.ToInt32(septitaisssolis2);
            astotaissoliscipars2 = Convert.ToInt32(astotaisssolis2);
            devitaissoliscipars2 = Convert.ToInt32(devitaissolis2);
            desmitaissoliscipars2 = Convert.ToInt32(desmitaissolis2);
            vienpadsmitaissoliscipars2 = Convert.ToInt32(vienpadsmitaissolis2);
            divpadsmitaissoliscipars2 = Convert.ToInt32(divpadsmitaissolis2);
            trispadsmitaissoliscipars2 = Convert.ToInt32(trispadsmitaissolis2);
            cetrpadsmitaissoliscipars2 = Convert.ToInt32(cetrpadsmitaissolis2);

            
            otraspeletajarezultats = 3 + pirmaissoliscipars2 + otraissoliscipars2 + tresaissoliscipars2 + ceturtaissoliscipars2 + piektaissoliscipars2 + sestaissoliscipars2 + septitaissoliscipars2 + astotaissoliscipars2+devitaissoliscipars2+desmitaissoliscipars2+vienpadsmitaissoliscipars2+divpadsmitaissoliscipars2+trispadsmitaissoliscipars2+cetrpadsmitaissoliscipars2;
            textBox6.Text = otraspeletajarezultats.ToString();

            String Dators = " Dators ";
            String player1 = "Spēlētājs 1";
            String nichja = "Spēles rezultāts - neizšķirts";
            if (otraspeletajarezultats == 42 & pirmaspeletajarezultats == 42)                                                
            {
                textBox19.Text = nichja;                                                        

            }
            else if (otraspeletajarezultats > 42)
            {
                textBox19.Text = player1;

            }
            else if (otraspeletajarezultats == 42)              
            {
                textBox19.Text = Dators;                                   
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)     /* Stavim cipars 3 (solis 1)*/ 
        {

            int cipars3 = 3;
          
            textBox2.Text = cipars3.ToString();

        }

        private void button4_Click(object sender, EventArgs e)      /* Stavim cipars 4 (solis 1)*/
        {
            int cipars4 = 4;

            textBox2.Text = cipars4.ToString();
        }

        private void button5_Click(object sender, EventArgs e)       /* Stavim cipars 3 (solis 2)*/
        {
            int cipars3 = 3;

            textBox3.Text = cipars3.ToString();
        }

        private void button6_Click(object sender, EventArgs e)         /* Stavim cipars 4 (solis 2)*/
        {
            int cipars4 = 4;

            textBox3.Text = cipars4.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)                /* ustanovka nolej (player1) */
        {
            int startpoint = 0;
            int startpointresult = 3;
            String pusto = null;  /*надо сделать очистку поля!*/
            textBox1.Text = startpointresult.ToString();  /* не нуждается в правке!! */
            textBox6.Text = startpointresult.ToString();  /* не нуждается в правке!! */
            textBox2.Text = startpoint.ToString();
            textBox3.Text = startpoint.ToString();
            textBox7.Text = startpoint.ToString();
            textBox8.Text = startpoint.ToString();
            textBox9.Text = startpoint.ToString();
            textBox10.Text = startpoint.ToString();
            textBox11.Text = startpoint.ToString();
            textBox12.Text = startpoint.ToString();
            textBox4.Text = startpoint.ToString();           /* ustanovka nolej (player2) */
            textBox5.Text = startpoint.ToString();
            textBox13.Text = startpoint.ToString();
            textBox14.Text = startpoint.ToString();
            textBox15.Text = startpoint.ToString();
            textBox16.Text = startpoint.ToString();
            textBox17.Text = startpoint.ToString();
            textBox18.Text = startpoint.ToString();
            textBox19.Text = pusto; /*надо сделать очистку поля!*/
            textBox20.Text = startpoint.ToString();
            textBox21.Text = startpoint.ToString();
            textBox22.Text = startpoint.ToString();
            textBox23.Text = startpoint.ToString();
            textBox24.Text = startpoint.ToString();
            textBox25.Text = startpoint.ToString();
            textBox26.Text = startpoint.ToString();
            textBox27.Text = startpoint.ToString();
            textBox28.Text = startpoint.ToString();
            textBox29.Text = startpoint.ToString();
            textBox30.Text = startpoint.ToString();
            textBox31.Text = startpoint.ToString();
        }

        private void button8_Click(object sender, EventArgs e)    /* Stavim cipars 3 (solis 3)*/
        {
            int cipars3 = 3;

            textBox7.Text = cipars3.ToString();
        }

        private void button12_Click(object sender, EventArgs e)   /*stavim cipars 4 (solis 3) */
        {
            int cipars4 = 4;

            textBox7.Text = cipars4.ToString();
        }

        private void button9_Click(object sender, EventArgs e)   /* Stavim cipars 3 (solis 4)*/
        {
            int cipars3 = 3;

            textBox10.Text = cipars3.ToString();
        }

        private void button13_Click(object sender, EventArgs e)   /*stavim cipars 4 (solis 4) */
        {
            int cipars4 = 4;

            textBox10.Text = cipars4.ToString();
        }

        private void button10_Click(object sender, EventArgs e)   /* Stavim cipars 3 (solis 5)*/
        {
            int cipars3 = 3;

            textBox9.Text = cipars3.ToString();
        }

        private void button14_Click(object sender, EventArgs e)     /*stavim cipars 4 (solis 5) */
        {
            int cipars4 = 4;

            textBox9.Text = cipars4.ToString();
        }

        private void button11_Click(object sender, EventArgs e)    /* Stavim cipars 3 (solis 6)*/
        {
            int cipars3 = 3;

            textBox8.Text = cipars3.ToString();
        }

        private void button15_Click(object sender, EventArgs e)    /*stavim cipars 4 (solis 6) */
        {
            int cipars4 = 4;

            textBox8.Text = cipars4.ToString();
        }

        private void button16_Click(object sender, EventArgs e)  /* Stavim cipars 3 (solis 7)*/
        {
            int cipars3 = 3;

            textBox11.Text = cipars3.ToString();
        }

        private void button18_Click(object sender, EventArgs e)  /*stavim cipars 4 (solis 7) */
        {
            int cipars4 = 4;

            textBox11.Text = cipars4.ToString();
        }

        private void button17_Click(object sender, EventArgs e)   /* Stavim cipars 3 (solis 8)*/
        {
            int cipars3 = 3;

            textBox12.Text = cipars3.ToString();
        }

        private void button19_Click(object sender, EventArgs e)   /*stavim cipars 4 (solis 8) */
        {
            int cipars4 = 4;

            textBox12.Text = cipars4.ToString();
        }

        private void button20_Click(object sender, EventArgs e)    /*datora gajiens solis 1 */  /*datora merkis ir izveleties celu, kurs vedis pie uzvaras vai izdarit visu iespejamo lai speletajs neuzvaretu*/
        {

            if (otraspeletajarezultats == 35)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 5);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 5 */
                textBox4.Text = datoracipars.ToString();
            }
            else if (otraspeletajarezultats == 36)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 4);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 4 */
                textBox4.Text = datoracipars.ToString();
            }

            else if (otraspeletajarezultats == 37)
            {
                int cipars5 = 5;
                textBox4.Text = cipars5.ToString();
            }
            else if (otraspeletajarezultats == 38)
            {
                int cipars4 = 4;
                textBox4.Text = cipars4.ToString();
            }
            else if (otraspeletajarezultats == 39)
            {
                int cipars3 = 3;
                textBox4.Text = cipars3.ToString();
            }

            else if(pirmaissoliscipars == 3)          /*Ja speletajs izvelas ciparu 3, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();                      
                int datoracipars = rnd.Next(4, 6);             /* Данный диапазон показывает следующее: int value больше или равен 4, и меньше 6 */
                textBox4.Text = datoracipars.ToString();
            }
            else if(pirmaissoliscipars == 4)            /*Ja speletajs izvelas ciparu 4, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();               
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox4.Text = datoracipars.ToString();
            }

            else if (pirmaissoliscipars == 5)            /*Ja speletajs izvelas ciparu 5, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox4.Text = datoracipars.ToString();
            }

            else
            {

                 
                Random rnd = new Random();                     /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars = rnd.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox4.Text = datoracipars.ToString();
            }
        }

        private void button21_Click(object sender, EventArgs e)   /*datora gajiens solis 2 */
        {
            if (otraspeletajarezultats == 35)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 5);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 5 */
                textBox5.Text = datoracipars.ToString();
            }
            else if (otraspeletajarezultats == 36)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 4);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 4 */
                textBox5.Text = datoracipars.ToString();
            }

            else if (otraspeletajarezultats == 37)
            {
                int cipars5 = 5;
                textBox5.Text = cipars5.ToString();
            } 
            else if (otraspeletajarezultats == 38)
            {
                int cipars4 = 4;
                textBox5.Text = cipars4.ToString();
            }
            else if (otraspeletajarezultats == 39)
            {
                int cipars3 = 3;
                textBox5.Text = cipars3.ToString();
            }

            else if (otraissoliscipars == 3)          /*Ja speletajs izvelas ciparu 3, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(4, 6);             /* Данный диапазон показывает следующее: int value больше или равен 4, и меньше 6 */
                textBox5.Text = datoracipars.ToString();
            }
            else if (otraissoliscipars == 4)            /*Ja speletajs izvelas ciparu 4, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox5.Text = datoracipars.ToString();
            }

            else if (otraissoliscipars == 5)            /*Ja speletajs izvelas ciparu 5, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox5.Text = datoracipars.ToString();
            }

            else if (otraissoliscipars==0 && pirmaspeletajarezultats<otraspeletajarezultats)
                {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox5.Text = datoracipars2.ToString();
            }

            else if (otraissoliscipars == 0 && pirmaspeletajarezultats == otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox5.Text = datoracipars2.ToString();
            }


            else if(otraissoliscipars==0 && pirmaspeletajarezultats > otraspeletajarezultats)
            {
                textBox5.Text = Max.ToString(); /*Jaizvelas augstako heiristisko vertejumu si gadijuma*/
            }

            else
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox5.Text = datoracipars2.ToString();
            }
        }

        private void button22_Click(object sender, EventArgs e)    /*datora gajiens solis 3 */
        {
            if (otraspeletajarezultats == 35)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 5);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 5 */
                textBox13.Text = datoracipars.ToString();
            }
            else if (otraspeletajarezultats == 36)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 4);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 4 */
                textBox13.Text = datoracipars.ToString();
            }

            else if (otraspeletajarezultats == 37)
            {
                int cipars5 = 5;
                textBox13.Text = cipars5.ToString();
            }
            else if (otraspeletajarezultats == 38)
            {
                int cipars4 = 4;
                textBox13.Text = cipars4.ToString();
            }
            else if (otraspeletajarezultats == 39)
            {
                int cipars3 = 3;
                textBox13.Text = cipars3.ToString();
            }

            else if (tresaissoliscipars == 3)          /*Ja speletajs izvelas ciparu 3, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(4, 6);             /* Данный диапазон показывает следующее: int value больше или равен 4, и меньше 6 */
                textBox13.Text = datoracipars.ToString();
            }
            else if (tresaissoliscipars == 4)            /*Ja speletajs izvelas ciparu 4, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox13.Text = datoracipars.ToString();
            }

            else if (tresaissoliscipars == 5)            /*Ja speletajs izvelas ciparu 5, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox13.Text = datoracipars.ToString();
            }

            else if (tresaissoliscipars == 0 && pirmaspeletajarezultats < otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox13.Text = datoracipars2.ToString();
            }

            else if (tresaissoliscipars == 0 && pirmaspeletajarezultats == otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox13.Text = datoracipars2.ToString();
            }


            else if (tresaissoliscipars == 0 && pirmaspeletajarezultats > otraspeletajarezultats)
            {
                textBox13.Text = Max.ToString();   /*Jaizvelas augstako heiristisko vertejumu si gadijuma*/
            }

            else 
            { 
            Random rnd3 = new Random(); /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
            int datoracipars3 = rnd3.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
            textBox13.Text = datoracipars3.ToString();
            }
        }

        private void button23_Click(object sender, EventArgs e)     /*datora gajiens solis 4 */
        {
            if (otraspeletajarezultats == 35)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 5);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 5 */
                textBox14.Text = datoracipars.ToString();
            }
            else if (otraspeletajarezultats == 36)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 4);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 4 */
                textBox14.Text = datoracipars.ToString();
            }

            else if (otraspeletajarezultats == 37)
            {
                int cipars5 = 5;
                textBox14.Text = cipars5.ToString();
            }
            else if (otraspeletajarezultats == 38)
            {
                int cipars4 = 4;
                textBox14.Text = cipars4.ToString();
            }
            else if (otraspeletajarezultats == 39)
            {
                int cipars3 = 3;
                textBox14.Text = cipars3.ToString();
            }

            else if (ceturtaissoliscipars == 3)          /*Ja speletajs izvelas ciparu 3, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(4, 6);             /* Данный диапазон показывает следующее: int value больше или равен 4, и меньше 6 */
                textBox14.Text = datoracipars.ToString();
            }
            else if (ceturtaissoliscipars == 4)            /*Ja speletajs izvelas ciparu 4, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox14.Text = datoracipars.ToString();
            }

            else if (ceturtaissoliscipars == 5)            /*Ja speletajs izvelas ciparu 5, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox14.Text = datoracipars.ToString();
            }

            else if (ceturtaissoliscipars == 0 && pirmaspeletajarezultats < otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox14.Text = datoracipars2.ToString();
            }

            else if (ceturtaissoliscipars == 0 && pirmaspeletajarezultats == otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox14.Text = datoracipars2.ToString();
            }


            else if (ceturtaissoliscipars == 0 && pirmaspeletajarezultats > otraspeletajarezultats)
            {
                textBox14.Text = Max.ToString();   /*Jaizvelas augstako heiristisko vertejumu si gadijuma*/
            }

            else
            {
                Random rnd4 = new Random(); /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars4 = rnd4.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox14.Text = datoracipars4.ToString();
            }
        }

        private void button24_Click(object sender, EventArgs e)    /*datora gajiens solis 5 */
        {
            if (otraspeletajarezultats == 35)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 5);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 5 */
                textBox15.Text = datoracipars.ToString();
            }
            else if (otraspeletajarezultats == 36)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 4);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 4 */
                textBox15.Text = datoracipars.ToString();
            }

            else if (otraspeletajarezultats == 37)
            {
                int cipars5 = 5;
                textBox15.Text = cipars5.ToString();
            }
            else if (otraspeletajarezultats == 38)
            {
                int cipars4 = 4;
                textBox15.Text = cipars4.ToString();
            }
            else if (otraspeletajarezultats == 39)
            {
                int cipars3 = 3;
                textBox15.Text = cipars3.ToString();
            }

            else if (piektaissoliscipars == 3)          /*Ja speletajs izvelas ciparu 3, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(4, 6);             /* Данный диапазон показывает следующее: int value больше или равен 4, и меньше 6 */
                textBox15.Text = datoracipars.ToString();
            }
            else if (piektaissoliscipars == 4)            /*Ja speletajs izvelas ciparu 4, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox15.Text = datoracipars.ToString();
            }

            else if (piektaissoliscipars == 5)            /*Ja speletajs izvelas ciparu 5, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox15.Text = datoracipars.ToString();
            }

            else if (piektaissoliscipars == 0 && pirmaspeletajarezultats < otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox15.Text = datoracipars2.ToString();
            }

            else if (piektaissoliscipars == 0 && pirmaspeletajarezultats == otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox15.Text = datoracipars2.ToString();
            }


            else if (piektaissoliscipars == 0 && pirmaspeletajarezultats > otraspeletajarezultats)
            {
                textBox15.Text = Max.ToString();   /*Jaizvelas augstako heiristisko vertejumu si gadijuma*/
            }

            else
            {
                Random rnd5 = new Random(); /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars5 = rnd5.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox15.Text = datoracipars5.ToString();
            }
        }

        private void button25_Click(object sender, EventArgs e)    /*datora gajiens solis 6 */
        {
            if (otraspeletajarezultats == 35)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 5);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 5 */
                textBox16.Text = datoracipars.ToString();
            }
            else if (otraspeletajarezultats == 36)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 4);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 4 */
                textBox16.Text = datoracipars.ToString();
            }

            else if (otraspeletajarezultats == 37)
            {
                int cipars5 = 5;
                textBox16.Text = cipars5.ToString();
            }
            else if (otraspeletajarezultats == 38)
            {
                int cipars4 = 4;
                textBox16.Text = cipars4.ToString();
            }
            else if (otraspeletajarezultats == 39)
            {
                int cipars3 = 3;
                textBox16.Text = cipars3.ToString();
            }

            else if (sestaissoliscipars == 3)          /*Ja speletajs izvelas ciparu 3, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(4, 6);             /* Данный диапазон показывает следующее: int value больше или равен 4, и меньше 6 */
                textBox16.Text = datoracipars.ToString();
            }
            else if (sestaissoliscipars == 4)            /*Ja speletajs izvelas ciparu 4, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox16.Text = datoracipars.ToString();
            }

            else if (sestaissoliscipars == 5)            /*Ja speletajs izvelas ciparu 5, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox16.Text = datoracipars.ToString();
            }

            else if (sestaissoliscipars == 0 && pirmaspeletajarezultats < otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox16.Text = datoracipars2.ToString();
            }

            else if (sestaissoliscipars == 0 && pirmaspeletajarezultats == otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox16.Text = datoracipars2.ToString();
            }


            else if (sestaissoliscipars == 0 && pirmaspeletajarezultats > otraspeletajarezultats)
            {
                textBox16.Text = Max.ToString();   /*Jaizvelas augstako heiristisko vertejumu si gadijuma*/
            }

            else
            {
                Random rnd6 = new Random(); /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars6 = rnd6.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox16.Text = datoracipars6.ToString();
            }
        }

        private void button26_Click(object sender, EventArgs e)   /*datora gajiens solis 7 */
        {
            if (otraspeletajarezultats == 35)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 5);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 5 */
                textBox17.Text = datoracipars.ToString();
            }
            else if (otraspeletajarezultats == 36)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 4);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 4 */
                textBox17.Text = datoracipars.ToString();
            }

            else if (otraspeletajarezultats == 37)
            {
                int cipars5 = 5;
                textBox17.Text = cipars5.ToString();
            }
            else if (otraspeletajarezultats == 38)
            {
                int cipars4 = 4;
                textBox17.Text = cipars4.ToString();
            }
            else if (otraspeletajarezultats == 39)
            {
                int cipars3 = 3;
                textBox17.Text = cipars3.ToString();
            }

            else if (septitaissoliscipars == 3)          /*Ja speletajs izvelas ciparu 3, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(4, 6);             /* Данный диапазон показывает следующее: int value больше или равен 4, и меньше 6 */
                textBox17.Text = datoracipars.ToString();
            }
            else if (septitaissoliscipars == 4)            /*Ja speletajs izvelas ciparu 4, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox17.Text = datoracipars.ToString();
            }

            else if (septitaissoliscipars == 5)            /*Ja speletajs izvelas ciparu 5, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox17.Text = datoracipars.ToString();
            }

            else if (septitaissoliscipars == 0 && pirmaspeletajarezultats < otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox17.Text = datoracipars2.ToString();
            }

            else if (septitaissoliscipars == 0 && pirmaspeletajarezultats == otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox17.Text = datoracipars2.ToString();
            }


            else if (septitaissoliscipars == 0 && pirmaspeletajarezultats > otraspeletajarezultats)
            {
                textBox17.Text = Max.ToString(); /*Jaizvelas augstako heiristisko vertejumu si gadijuma*/
            }

            else
            {
                Random rnd7 = new Random(); /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars7 = rnd7.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox17.Text = datoracipars7.ToString();
            }
        }

        private void button27_Click(object sender, EventArgs e)    /*datora gajiens solis 8 */
        {
            if (otraspeletajarezultats == 35)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 5);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 5 */
                textBox18.Text = datoracipars.ToString();
            }
            else if (otraspeletajarezultats == 36)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 4);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 4 */
                textBox18.Text = datoracipars.ToString();
            }

            else if (otraspeletajarezultats == 37)
            {
                int cipars5 = 5;
                textBox18.Text = cipars5.ToString();
            }
            else if (otraspeletajarezultats == 38)
            {
                int cipars4 = 4;
                textBox18.Text = cipars4.ToString();
            }
            else if (otraspeletajarezultats == 39)
            {
                int cipars3 = 3;
                textBox18.Text = cipars3.ToString();
            }

            else if (astotaissoliscipars == 3)          /*Ja speletajs izvelas ciparu 3, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(4, 6);             /* Данный диапазон показывает следующее: int value больше или равен 4, и меньше 6 */
                textBox18.Text = datoracipars.ToString();
            }
            else if (astotaissoliscipars == 4)            /*Ja speletajs izvelas ciparu 4, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox18.Text = datoracipars.ToString();
            }

            else if (astotaissoliscipars == 5)            /*Ja speletajs izvelas ciparu 5, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox18.Text = datoracipars.ToString();
            }

            else if (astotaissoliscipars == 0 && pirmaspeletajarezultats < otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox18.Text = datoracipars2.ToString();
            }

            else if (astotaissoliscipars == 0 && pirmaspeletajarezultats == otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox18.Text = datoracipars2.ToString();
            }


            else if (astotaissoliscipars == 0 && pirmaspeletajarezultats > otraspeletajarezultats)
            {
                textBox18.Text = Max.ToString(); /*Jaizvelas augstako heiristisko vertejumu si gadijuma*/
            }

            else
            {
                Random rnd8 = new Random(); /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars8 = rnd8.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox18.Text = datoracipars8.ToString();
            }
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)   /*datora gajiens solis 14 */
        {
            if (otraspeletajarezultats == 35)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 5);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 5 */
                textBox31.Text = datoracipars.ToString();
            }
            else if (otraspeletajarezultats == 36)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 4);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 4 */
                textBox31.Text = datoracipars.ToString();
            }

            else if (otraspeletajarezultats == 37)
            {
                int cipars5 = 5;
                textBox31.Text = cipars5.ToString();
            }
            else if (otraspeletajarezultats == 38)
            {
                int cipars4 = 4;
                textBox31.Text = cipars4.ToString();
            }
            else if (otraspeletajarezultats == 39)
            {
                int cipars3 = 3;
                textBox31.Text = cipars3.ToString();
            }

            else if (cetrpadsmitaissoliscipars == 3)          /*Ja speletajs izvelas ciparu 3, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(4, 6);             /* Данный диапазон показывает следующее: int value больше или равен 4, и меньше 6 */
                textBox31.Text = datoracipars.ToString();
            }
            else if (cetrpadsmitaissoliscipars == 4)            /*Ja speletajs izvelas ciparu 4, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox31.Text = datoracipars.ToString();
            }

            else if (cetrpadsmitaissoliscipars == 5)            /*Ja speletajs izvelas ciparu 5, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox31.Text = datoracipars.ToString();
            }

            else if (cetrpadsmitaissoliscipars == 0 && pirmaspeletajarezultats < otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox31.Text = datoracipars2.ToString();
            }

            else if (cetrpadsmitaissoliscipars == 0 && pirmaspeletajarezultats == otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox31.Text = datoracipars2.ToString();
            }


            else if (cetrpadsmitaissoliscipars == 0 && pirmaspeletajarezultats > otraspeletajarezultats)
            {
                textBox31.Text = Max.ToString(); /*Jaizvelas augstako heiristisko vertejumu si gadijuma*/
            }

            else
            {
                Random rnd14 = new Random(); /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars14 = rnd14.Next(3, 6);            /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox31.Text = datoracipars14.ToString();
            }

        }

        private void button28_Click(object sender, EventArgs e)   /*datora gajiens solis 9 */
        {
            if (otraspeletajarezultats == 35)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 5);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 5 */
                textBox26.Text = datoracipars.ToString();
            }
            else if (otraspeletajarezultats == 36)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 4);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 4 */
                textBox26.Text = datoracipars.ToString();
            }

            else if (otraspeletajarezultats == 37)
            {
                int cipars5 = 5;
                textBox26.Text = cipars5.ToString();
            }
            else if (otraspeletajarezultats == 38)
            {
                int cipars4 = 4;
                textBox26.Text = cipars4.ToString();
            }
            else if (otraspeletajarezultats == 39)
            {
                int cipars3 = 3;
                textBox26.Text = cipars3.ToString();
            }

            else if (devitaissoliscipars == 3)          /*Ja speletajs izvelas ciparu 3, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(4, 6);             /* Данный диапазон показывает следующее: int value больше или равен 4, и меньше 6 */
                textBox26.Text = datoracipars.ToString();
            }
            else if (devitaissoliscipars == 4)            /*Ja speletajs izvelas ciparu 4, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox26.Text = datoracipars.ToString();
            }

            else if (devitaissoliscipars == 5)            /*Ja speletajs izvelas ciparu 5, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox26.Text = datoracipars.ToString();
            }

            else if (devitaissoliscipars == 0 && pirmaspeletajarezultats < otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox26.Text = datoracipars2.ToString();
            }

            else if (devitaissoliscipars == 0 && pirmaspeletajarezultats == otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox26.Text = datoracipars2.ToString();
            }


            else if (devitaissoliscipars == 0 && pirmaspeletajarezultats > otraspeletajarezultats)
            {
                textBox26.Text = Max.ToString(); /*Jaizvelas augstako heiristisko vertejumu si gadijuma*/
            }

            else
            {
                Random rnd9 = new Random(); /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars9 = rnd9.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox26.Text = datoracipars9.ToString();
            }

        }

        private void button29_Click(object sender, EventArgs e)   /*datora gajiens solis 10 */
        {
            if (otraspeletajarezultats == 35)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 5);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 5 */
                textBox27.Text = datoracipars.ToString();
            }
            else if (otraspeletajarezultats == 36)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 4);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 4 */
                textBox27.Text = datoracipars.ToString();
            }

            else if (otraspeletajarezultats == 37)
            {
                int cipars5 = 5;
                textBox27.Text = cipars5.ToString();
            } else if (otraspeletajarezultats == 38)
            {
                int cipars4 = 4;
                textBox27.Text = cipars4.ToString();
            } else if (otraspeletajarezultats == 39)
            {
                int cipars3 = 3;
                textBox27.Text = cipars3.ToString();
            }

            else if (desmitaissoliscipars == 3)          /*Ja speletajs izvelas ciparu 3, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(4, 6);             /* Данный диапазон показывает следующее: int value больше или равен 4, и меньше 6 */
                textBox27.Text = datoracipars.ToString();
            }
            else if (desmitaissoliscipars == 4)            /*Ja speletajs izvelas ciparu 4, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox27.Text = datoracipars.ToString();
            }

            else if (desmitaissoliscipars == 5)            /*Ja speletajs izvelas ciparu 5, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox27.Text = datoracipars.ToString();
            }

            else if (desmitaissoliscipars == 0 && pirmaspeletajarezultats < otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox27.Text = datoracipars2.ToString();
            }

            else if (desmitaissoliscipars == 0 && pirmaspeletajarezultats == otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox27.Text = datoracipars2.ToString();
            }


            else if (desmitaissoliscipars == 0 && pirmaspeletajarezultats > otraspeletajarezultats)
            {
                textBox27.Text = Max.ToString(); /*Jaizvelas augstako heiristisko vertejumu si gadijuma*/
            }

            else
            {
                Random rnd10 = new Random(); /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars10 = rnd10.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox27.Text = datoracipars10.ToString();
            }
        }

        private void button30_Click(object sender, EventArgs e)  /*datora gajiens solis 11 */
        {
            if (otraspeletajarezultats == 35)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 5);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 5 */
                textBox28.Text = datoracipars.ToString();
            }
            else if (otraspeletajarezultats == 36)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 4);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 4 */
                textBox28.Text = datoracipars.ToString();
            }

            else if (otraspeletajarezultats == 37)
            {
                int cipars5 = 5;
                textBox28.Text = cipars5.ToString();
            }
            else if (otraspeletajarezultats == 38)
            {
                int cipars4 = 4;
                textBox28.Text = cipars4.ToString();
            }
            else if (otraspeletajarezultats == 39)
            {
                int cipars3 = 3;
                textBox28.Text = cipars3.ToString();
            }

            else if (vienpadsmitaissoliscipars == 3)          /*Ja speletajs izvelas ciparu 3, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(4, 6);             /* Данный диапазон показывает следующее: int value больше или равен 4, и меньше 6 */
                textBox28.Text = datoracipars.ToString();
            }
            else if (vienpadsmitaissoliscipars == 4)            /*Ja speletajs izvelas ciparu 4, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox28.Text = datoracipars.ToString();
            }

            else if (vienpadsmitaissoliscipars == 5)            /*Ja speletajs izvelas ciparu 5, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox28.Text = datoracipars.ToString();
            }

            else if (vienpadsmitaissoliscipars == 0 && pirmaspeletajarezultats < otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox28.Text = datoracipars2.ToString();
            }

            else if (vienpadsmitaissoliscipars == 0 && pirmaspeletajarezultats == otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox28.Text = datoracipars2.ToString();
            }


            else if (vienpadsmitaissoliscipars == 0 && pirmaspeletajarezultats > otraspeletajarezultats)
            {
                textBox28.Text = Max.ToString(); /*Jaizvelas augstako heiristisko vertejumu si gadijuma*/
            }

            else
            {
                Random rnd11 = new Random(); /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars11 = rnd11.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox28.Text = datoracipars11.ToString();
            }
        }

        private void button31_Click(object sender, EventArgs e)   /*datora gajiens solis 12 */
        {
            if (otraspeletajarezultats == 35)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 5);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 5 */
                textBox29.Text = datoracipars.ToString();
            }
            else if (otraspeletajarezultats == 36)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 4);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 4 */
                textBox29.Text = datoracipars.ToString();
            }

            else if (otraspeletajarezultats == 37)
            {
                int cipars5 = 5;
                textBox29.Text = cipars5.ToString();
            }
            else if (otraspeletajarezultats == 38)
            {
                int cipars4 = 4;
                textBox29.Text = cipars4.ToString();
            }
            else if (otraspeletajarezultats == 39)
            {
                int cipars3 = 3;
                textBox29.Text = cipars3.ToString();
            }

            else if (divpadsmitaissoliscipars == 3)          /*Ja speletajs izvelas ciparu 3, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(4, 6);             /* Данный диапазон показывает следующее: int value больше или равен 4, и меньше 6 */
                textBox29.Text = datoracipars.ToString();
            }
            else if (divpadsmitaissoliscipars == 4)            /*Ja speletajs izvelas ciparu 4, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox29.Text = datoracipars.ToString();
            }

            else if (divpadsmitaissoliscipars == 5)            /*Ja speletajs izvelas ciparu 5, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox29.Text = datoracipars.ToString();
            }

            else if (divpadsmitaissoliscipars == 0 && pirmaspeletajarezultats < otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox29.Text = datoracipars2.ToString();
            }

            else if (divpadsmitaissoliscipars == 0 && pirmaspeletajarezultats == otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox29.Text = datoracipars2.ToString();
            }


            else if (divpadsmitaissoliscipars == 0 && pirmaspeletajarezultats > otraspeletajarezultats)
            {
                textBox29.Text = Max.ToString(); /*Jaizvelas augstako heiristisko vertejumu si gadijuma*/
            }

            else
            {
                Random rnd12 = new Random(); /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars12 = rnd12.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox29.Text = datoracipars12.ToString();
            }
        }

        private void button32_Click(object sender, EventArgs e) /*datora gajiens solis 13 */
        {
            if (otraspeletajarezultats == 35)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 5);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 5 */
                textBox30.Text = datoracipars.ToString();
            }
            else if (otraspeletajarezultats == 36)
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(3, 4);    /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 4 */
                textBox30.Text = datoracipars.ToString();
            }

            else if (otraspeletajarezultats == 37)
            {
                int cipars5 = 5;
                textBox30.Text = cipars5.ToString();
            }
            else if (otraspeletajarezultats == 38)
            {
                int cipars4 = 4;
                textBox30.Text = cipars4.ToString();
            }
            else if (otraspeletajarezultats == 39)
            {
                int cipars3 = 3;
                textBox30.Text = cipars3.ToString();
            }

            else if (trispadsmitaissoliscipars == 3)          /*Ja speletajs izvelas ciparu 3, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(4, 6);             /* Данный диапазон показывает следующее: int value больше или равен 4, и меньше 6 */
                textBox30.Text = datoracipars.ToString();
            }
            else if (trispadsmitaissoliscipars == 4)            /*Ja speletajs izvelas ciparu 4, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox30.Text = datoracipars.ToString();
            }

            else if (trispadsmitaissoliscipars == 5)            /*Ja speletajs izvelas ciparu 5, pec minimaksa algoritma datoram jaizvelas racionalakais cels*/
            {
                Random rnd = new Random();
                int datoracipars = rnd.Next(5, 6);             /* Данный диапазон показывает следующее: int value больше или равен 5, и меньше 6 */
                textBox30.Text = datoracipars.ToString();
            }

            else if (trispadsmitaissoliscipars == 0 && pirmaspeletajarezultats < otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox30.Text = datoracipars2.ToString();
            }

            else if (trispadsmitaissoliscipars == 0 && pirmaspeletajarezultats == otraspeletajarezultats)
            {
                Random rnd2 = new Random();  /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars2 = rnd2.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox30.Text = datoracipars2.ToString();
            }


            else if (trispadsmitaissoliscipars == 0 && pirmaspeletajarezultats > otraspeletajarezultats)
            {
                textBox30.Text = Max.ToString(); /*Jaizvelas augstako heiristisko vertejumu si gadijuma*/
            }

            else
            {
                Random rnd13 = new Random(); /*Случай, когда выбор цифры для компьютера не является принципиальным и можно выбрать асолютно любую цифру*/
                int datoracipars13 = rnd13.Next(3, 6);             /* Данный диапазон показывает следующее: int value больше или равен 3, и меньше 6 */
                textBox30.Text = datoracipars13.ToString();
            }
        }

        private void button34_Click(object sender, EventArgs e)   /* Stavim cipars 3 (solis 9)*/
        {
            int cipars3 = 3;

            textBox20.Text = cipars3.ToString();
        }

        private void button40_Click(object sender, EventArgs e)  /*stavim cipars 4 (solis 9) */
        {
            int cipars4 = 4;

            textBox20.Text = cipars4.ToString();
        }

        private void button35_Click(object sender, EventArgs e)  /*stavim cipars 3 (solis 10) */
        {
            int cipars3 = 3;

            textBox21.Text = cipars3.ToString();
        }

        private void button41_Click(object sender, EventArgs e)   /*stavim cipars 4 (solis 10) */
        {
            int cipars4 = 4;

            textBox21.Text = cipars4.ToString();
        }

        private void button36_Click(object sender, EventArgs e)   /*stavim cipars 3 (solis 11) */
        {
            int cipars3 = 3;

            textBox22.Text = cipars3.ToString();
        }

        private void button42_Click(object sender, EventArgs e)   /*stavim cipars 4 (solis 11) */
        {
            int cipars4 = 4;

            textBox22.Text = cipars4.ToString();
        }

        private void button37_Click(object sender, EventArgs e)    /*stavim cipars 3 (solis 12) */
        {
            int cipars3 = 3;

            textBox23.Text = cipars3.ToString();
        }

        private void button43_Click(object sender, EventArgs e)   /*stavim cipars 4 (solis 12) */
        { 
            int cipars4 = 4;

            textBox23.Text = cipars4.ToString();
        }

        private void button38_Click(object sender, EventArgs e)   /*stavim cipars 3 (solis 13) */
        {
            int cipars3 = 3;

            textBox24.Text = cipars3.ToString();
        }

        private void button44_Click(object sender, EventArgs e)    /*stavim cipars 4 (solis 13) */
        {
            int cipars4 = 4;

            textBox24.Text = cipars4.ToString();
        }

        private void button39_Click(object sender, EventArgs e)  /*stavim cipars 3 (solis 14) */
        {
            int cipars3 = 3;

            textBox25.Text = cipars3.ToString();
        }

        private void button45_Click(object sender, EventArgs e)   /*stavim cipars 4 (solis 14) */
        {
            int cipars4 = 4;

            textBox25.Text = cipars4.ToString();
        }

        private void button46_Click(object sender, EventArgs e)  /*stavim cipars 5 (solis 1) */
        {
            int cipars5 = 5;

            textBox2.Text = cipars5.ToString();
        }

        private void button47_Click(object sender, EventArgs e) /*stavim cipars 5 (solis 2) */
        {
            int cipars5 = 5;

            textBox3.Text = cipars5.ToString();
        }

        private void button48_Click(object sender, EventArgs e) /*stavim cipars 5 (solis 3) */
        {
            int cipars5 = 5;

            textBox7.Text = cipars5.ToString();
        }

        private void button49_Click(object sender, EventArgs e)  /*stavim cipars 5 (solis 4) */
        {
            int cipars5 = 5;

            textBox10.Text = cipars5.ToString();
        }

        private void button50_Click(object sender, EventArgs e) /*stavim cipars 5 (solis 5) */
        {
            int cipars5 = 5;

            textBox9.Text = cipars5.ToString();
        }

        private void button51_Click(object sender, EventArgs e) /*stavim cipars 5 (solis 6) */
        {
            int cipars5 = 5;

            textBox8.Text = cipars5.ToString();
        }

        private void button52_Click(object sender, EventArgs e)  /*stavim cipars 5 (solis 7) */
        {
            int cipars5 = 5;

            textBox11.Text = cipars5.ToString();
        }

        private void button53_Click(object sender, EventArgs e)  /*stavim cipars 5 (solis 8) */
        {
            int cipars5 = 5;

            textBox12.Text = cipars5.ToString();
        }

        private void button54_Click(object sender, EventArgs e) /*stavim cipars 5 (solis 9) */
        {
            int cipars5 = 5;

            textBox20.Text = cipars5.ToString();
        }

        private void button55_Click(object sender, EventArgs e) /*stavim cipars 5 (solis 10) */
        {
            int cipars5 = 5;

            textBox21.Text = cipars5.ToString();
        }

        private void button56_Click(object sender, EventArgs e) /*stavim cipars 5 (solis 11) */
        {
            int cipars5 = 5;

            textBox22.Text = cipars5.ToString();
        }

        private void button57_Click(object sender, EventArgs e) /*stavim cipars 5 (solis 12) */
        {
            int cipars5 = 5;

            textBox23.Text = cipars5.ToString();
        }

        private void button58_Click(object sender, EventArgs e) /*stavim cipars 5 (solis 13) */
        {
            int cipars5 = 5;

            textBox24.Text = cipars5.ToString();
        }

        private void button59_Click(object sender, EventArgs e) /*stavim cipars 5 (solis 14) */
        {
            int cipars5 = 5;

            textBox25.Text = cipars5.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
       
    }
}
