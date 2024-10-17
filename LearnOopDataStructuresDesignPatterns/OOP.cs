using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOopDataStructuresDesignPatterns
{
    public class OOP
    {
    }

    //Aggregation has a association
    public class Professor { }
    public class University 
    {
        private List<Professor> _professors = new List<Professor>();
        void AddProfessor() 
        {
            _professors.Add(new Professor());
        }
    }

    //Composition has a association strong
    public class Room { }
    public class House 
    {
        public House()
        {
            var room = new Room();
        }
    }

    //polymorphism can help in reducing conditional logic.
    public class PolymorphismRegucingCondition
    {
        public abstract class Payment
        {
            public abstract void Process();
        }
        public class CreditCardPayment : Payment
        {
            public override void Process() => Console.WriteLine("Processing credit card payment");
        }
        public class PayPalPayment : Payment
        {
            public override void Process() => Console.WriteLine("Processing PayPal payment");
        }
        public void MakePayment(Payment payment)
        {
            payment.Process();  // No need for if-else based on payment type
        }
    }
}
