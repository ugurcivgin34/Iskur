using System;
using System.Collections.Generic;

namespace Ders12_Arrays_Devam
{
    class Program
    {
        static void Main(string[] args)
        {
            //iki boyutlu dizi
            //int[,] matris = new int[5, 5];
            //matris[0, 0] = 10;
            //matris[0, 4] = 20;
            //matris[4, 0] = 30;
            //matris[4, 4] = 40;

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(matris[i,j]+ " ");
            //    }
            //    Console.WriteLine();

            //}

            //_-----------------------------------------------------------------------------------------
            //Aşağıdaki çıktıyı veren matrisi döngü ile oluşturunuz
            //2 0 0 0 2
            //1 0 0 0 1
            //2 0 0 0 2
            //1 0 0 0 1
            //2 0 0 0 2

            //int[,] matris = new int[5, 5];

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (i%2==0 && (j ==0 || j==4))
            //        {
            //            matris[i, j] = 2;
            //        }
            //        else if (i % 2 == 1 && (j == 0 || j == 4))
            //        {
            //            matris[i, j] = 1;
            //        }
            //        else 
            //        matris[i,j] = 3


            //    }
            //}
            // matris[2,2]=0;
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(matris[i, j] + " ");
            //    }
            //    Console.WriteLine("");//İçteki döngü tamamlanınca alt satıra geç.
            //}

            //-----------------------------------------------------------------------------------------
            //1 0 0 0 0 
            //0 1 0 0 0 
            //0 0 1 0 0
            //0 0 0 1 0
            //0 0 0 0 1

            //for (int satir = 0; satir < 5; satir++)
            //{
            //    for (int sütun = 0; sütun < 5; sütun++)
            //    {
            //        if (satir == sütun)
            //        {
            //            matris[satir, sütun] = 1;
            //        }
            //    }
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(matris[i, j] + " ");
            //    }
            //    Console.WriteLine("");//İçteki döngü tamamlanınca alt satıra geç.
            //}

            //------------------------------------------------------------------------------------------
            /*
            1 0 0 0 1
            0 1 0 1 0
            0 0 1 0 0
            0 1 0 1 0
            1 0 0 0 1

            */

            //for (int satir = 0; satir < 5; satir++)
            //{
            //    for (int sutun = 0; sutun < 5; sutun++)
            //    {
            //        if(satir==sutun || satir + sutun ==4)
            //        {
            //            matris[satir,sutun] = 1;
            //        }
            //    }
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(matris[i, j] + " ");
            //    }
            //    Console.WriteLine("");//İçteki döngü tamamlanınca alt satıra geç.
            //}


            //------------------------------------------------------------------------------------------------------
            //2x3 matris , tüm elamanları 5 olsun
            //int[,] matris = new int[3, 5];

            //for (int satir = 0; satir < 2; satir++)
            //{
            //    for (int sutun = 0; sutun < 3; sutun++)
            //    {
            //        matris[satir, sutun] = 5;
            //    }
            //}

            //for (int satir = 0; satir < 2; satir++)
            //{
            //    for (int sutun = 0; sutun < 3; sutun++)
            //    {
            //        Console.Write(matris[satir,sutun] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //------------------------------------------------------------------------------------------------------
            //2X4 lük bir dizi tanımlayınız.HEr bir elemanı klavyeden alsın.BU diziyi ekrana yazdırın

            //int[,] matris = new int[2, 4];

            //for (int satir = 0; satir < 2; satir++)
            //{
            //    for (int sutun = 0; sutun < 4; sutun++)
            //    {
            //        Console.Write("Lütfen "+ satir + " .inci satir " + sutun + " .inci sutunu giriniz : ");
            //        matris[satir, sutun] = int.Parse(Console.ReadLine());

            //    }

            //}

            //for (int satir = 0; satir < 2; satir++)
            //{
            //    for (int sutun = 0; sutun < 4; sutun++)
            //    {
            //        Console.Write(matris[satir,sutun] + " ");


            //    }
            //    Console.WriteLine("");

            //}

            //------------------------------------------------------------------------------------------------------
            //2x4 matris, her satırın son değeri hariç klavyeden alınsın. Son kolon satırdaki sayıların toplamınu tutsun

            //int[,] matris = new int[2, 4];

            //for (int satir = 0; satir < 2; satir++)
            //{
            //    for (int sutun = 0; sutun < 3; sutun++)
            //    {

            //            Console.WriteLine("Sayı=:");
            //            matris[satir, sutun] = int.Parse(Console.ReadLine());

            //    }
            //}


            //int satirToplam = 0;
            //for (int satir = 0; satir < 2; satir++)
            //{
            //    satirToplam = 0;
            //    for (int sutun = 0; sutun < 3; sutun++)
            //    {
            //        satirToplam += matris[satir, sutun];
            //    }
            //    matris[satir, 3] = satirToplam;

            //}

            //for (int satir = 0; satir < 2; satir++)
            //{
            //    for (int sutun = 0; sutun < 4; sutun++)
            //    {
            //        Console.Write(matris[satir, sutun] + " ");


            //    }
            //    Console.WriteLine("");

            //}
            // son kolon satırdaki sayıların toplamını tutsun. 
            // Örnek:
            // 1 2 3 6 
            // 4 5 6 15
            //int[,] dizi2 = new int[2, 4];
            //for (int i = 0; i < 2; i++)
            //{
            //    int satirToplam = 0;
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (j < 3)
            //        {
            //            Console.WriteLine("Sayı=");
            //            dizi2[i, j] = int.Parse(Console.ReadLine());
            //            satirToplam += dizi2[i, j];
            //        }
            //        else
            //            dizi2[i, 3] = satirToplam;

            //    }
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(dizi2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //------------------------------------------------------------------------------------------------------
            /////////////////////////////////
            ///3 Boyutlu Diziler: ///
            ////////////////////////////////

            //int[,,] dizi = new int[2, 3, 3];
            //Random rnd = new Random();

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        for (int k = 0; k < 3; k++)
            //        {
            //            dizi[i,j,k] = rnd.Next(1, 1000);
            //        }
            //    }
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        for (int k = 0; k < 3; k++)
            //        {
            //            Console.Write(dizi[i, j, k] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine("******************");
            //    Console.WriteLine("******************");
            //}

            




        }
    }
}



