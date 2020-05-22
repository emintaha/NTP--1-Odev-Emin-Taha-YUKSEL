using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitabevi.app
{
    public class Kitap : Program
    {

        public Kitap()
        {

        }



        public Kitap(string kitapadi , string kitaptürü , string yazaradi , double basimtarihi)
        {
            this.SetKitapadi(kitapadi);

            this.SetKitaptürü(kitaptürü);

            this.SetYazaradi(yazaradi);

            this.SetBasimtarihi(basimtarihi);

        }
        private string kitapadi;
       
        private string kitaptürü;
        
        private string yazaradi; 
        
        private double basimtarihi;

        public double Basimtarihi { get => basimtarihi; set => basimtarihi = value; }

        public double GetKitapadi()
        {
            return Basimtarihi;
        }

        public void SetKitapadi(string value)
        {
            kitapadi = value.ToUpper();
        }

        public string GetKitaptürü()
        {
            return kitaptürü;
        }

        public void SetKitaptürü(string value)
        {
            kitaptürü = value.ToUpper();
        }

        public string GetYazaradi()
        {
            return yazaradi;
        }

        public void SetYazaradi(string value)
        {
            yazaradi = value;
        }


        public void KitapBilgi(int [] value) 
        {
            
        
        }
        

        public string KitapGetir() => $" Kitap adı:{this.GetKitapadi()}, Kitap türü: {this.GetKitaptürü()}, Yazar Adı: {this.GetYazaradi()} , Basım tarihi: {this.GetBasimtarihi()}";
    }
}
