using Laborator_13___Exercitiu.Cards;
using Laborator_13___Exercitiu.Banks;
using System;
using System.Collections.Generic;
using System.Text;
using Laborator_13___Exercitiu.BankAccounts;

namespace Laborator_13___Exercitiu.Pos
{
    abstract class POS
    {
        public Guid Id { get; private set; }

        public void Pay(decimal amount, Card card)
        {
            card.InsertCard();
            card.GetCardData(Id);
            card.Pay();
            card.ExtractCard();
        }
    }
}