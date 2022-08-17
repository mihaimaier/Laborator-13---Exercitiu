using Laborator_13___Exercitiu.BankAccounts;
using Laborator_13___Exercitiu.Banks;
using System;

namespace Laborator_13___Exercitiu.Cards
{
    abstract class Card
    {

        public Guid Id { get; private set; }

        public void InsertCard()
        {
            Console.WriteLine("Please insert your card!");
        }
        public void GetCardData(Guid Id)
        {
            this.Id = Id;
        }
        public void ExtractCard()
        {
            Console.WriteLine("Please remove your card!");
        }
    }
}
