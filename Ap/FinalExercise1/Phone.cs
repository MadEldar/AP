using System;

namespace FinalExercise1
{
    public abstract class Phone
    {
        protected string PhoneName { get; set; }
        
        protected string PhoneType { get; set; }
        
        protected float PhonePrice { get; set; }

        protected Phone(string phoneName, float phonePrice, string phoneType)
        {
            PhoneName = phoneName;
            PhoneType = phoneType;
            PhonePrice = phonePrice;
        }

        public void Display()
        {
            Console.WriteLine("Phone: {0, -15} Type: {1, -10} Price: {2}", PhoneName, PhoneType, PhonePrice);
        }
    }
}