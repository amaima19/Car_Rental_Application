namespace Car.Models
{
    public class Car
    {

       public int id { get; set; }
       public string name{ get; set; } 
       public  Double price { get; set; }
       public  Car()
        { id = 0;
            name = "";
            price = 00.0;
        }
        public Car(int val,string nam,double prc)
        {  id = val;
            name = nam;
            price = prc;
        }   
    }
}
