using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
  

    //Корабль
    class Ship
    {
        #region Перечисления
        private enum ListNameShip
        {
            //катер - однопалубник, эсминец - двухпалубник, крейсер - трёхпалубник, линкор - четрыёхпалубник    
            Boat, Destroyer, Cruiser, Battleship
        }
        private enum ListСondition
        {
            //не пробит, пробит, уничтожен
            notBroken, broken, destroyed
        }
        #endregion

        #region Поля
        private readonly string name;
        private int numberOfDecks;
        private string condition;
        List<Deck> decks;
     
        #endregion

        #region Свойства
        public string Name { get { return name; } }
        public int NumberOfDecks { get { return numberOfDecks; } set { numberOfDecks = value; } }
        #endregion

        #region Консутрукторы
        public Ship(int n)
        {
            switch (n)
            {
                case 1: this.name = ListNameShip.Boat.ToString(); break;
                case 2: this.name = ListNameShip.Destroyer.ToString(); break;
                case 3: this.name = ListNameShip.Cruiser.ToString(); break;
                case 4: this.name = ListNameShip.Battleship.ToString(); break;
            }
            this.decks = new List<Deck>();
            for(int k = 0; k < n; k++)
            {
                decks.Add(new Deck(k));
            }
            this.condition = ListСondition.notBroken.ToString();
        }      
        #endregion


        //Палуба
        class Deck
        {
            #region Поля
            private string conditionDeck;
            private int deckNumber;
            #endregion

            #region Конструкторы
            public Deck(int k)
            {
                this.deckNumber = k;
                this.conditionDeck = ListСondition.notBroken.ToString();
            }
            #endregion
        }
    }

    
}
