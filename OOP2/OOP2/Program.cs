using System;

namespace OOP2
{
    //indexler

    //1275 çıktı olarak binikiyüzyetmişbeş yazacak.

    //Ekranı çalıştır rastgele kar yağsın , sonra kapansın tekrar çalıştşr yağmur  , sonra kapansın tekrar çalıştır dolu

    class Depo
    {
        private string[] _depo = new string[10];

        public string this[int indis] //thisi gördüğümüz zaman indexleyici dir yani classı kastetiyor aslında
        {
            get { return _depo[indis]; }
            set { _depo[indis] = value; }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Depo depo = new Depo();
            depo[0] = "";

            string strMesaj = "Merhaba";
            for (int i = 0; i < strMesaj.Length; i++)
            {
                Console.WriteLine(strMesaj[i]);  //Burada indexleyici var, string sınıfının içinde indexleyici olmasaydı zaten böyle kullanamzdık
            }
        }

        //SqlConnection conn = new SqlConnection("Data source=.;initial catalog=Northwind;integrated security=true);
        //conn.Open();
        //    Sqlcommand cmd = new Sqlcommand("*SELECT * FROM Products", conn);
        //sqkDataReader dr = cmd.ExecuteREader();
        //while(dr.Read()){
        //    Console.WriteLine(dr["ProductID"] +  " " + dr[1]);
   //     string strSatir = " ";
   //     for (int i = 0; dr<dr.FieldCount; i++)
			//{
   //         strSatir +=dr[i] + " ";
            
			//}
   //     Console.WriteLine(strSatir);
   //     strSatir="";
   //     //    }
   //     conn.Close();


    }
}
