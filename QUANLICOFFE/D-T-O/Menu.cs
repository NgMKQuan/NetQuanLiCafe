using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLICOFFE.D_T_O
{
   public class Menu
    {
        public Menu(string name,int count,float price, float totalprice = 0)
        {
            this.Name = name;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalprice;
        }

        public Menu(DataRow row)
        {
            this.name = row ["NAME"].ToString();
            this.Count =(int)row ["COUNT"];
            this.Price =(float)Convert.ToDouble(row ["PRICE"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["TOTALPRICE"].ToString());
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private float totalprice;

        public float TotalPrice
        {
            get { return totalprice; }
            set { totalprice = value; }
        }

      
       

        
    }
}
