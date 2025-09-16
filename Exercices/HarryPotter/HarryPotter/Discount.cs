using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    public class Discount
    {
        private int nbBooks;
        private double priceRation;
        
        public Discount(int nb, double price)
        {
          nbBooks = nb;
            this.priceRation = priceRation;
        }

        public bool CanBeApplied(Basket b)
        {
            b.HowManyDifferent() >= nbBooks;
        }

        public double Apply(double basePrice)
        {
            nbBooks * basePrice * priceRation;
        }

        public Basket RemovePaidBooks(Basket b)
        {
            b.RemoveDifferent(nbBooks);
        }
    }
}
