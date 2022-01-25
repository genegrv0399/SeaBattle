using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    internal class Field
    {
        #region Поля
        private string сondition;
        private int numberField;
        private enum ListСondition
        {
            // поле занято, поле не занято
            fieldOccupied, fieldNotOccupied
        }
        #endregion

        #region Свойства
        public string Condition { get; set; }
        #endregion

        #region Конуструкторы
        public Field(int k)
        {
            this.numberField = k;
            this.сondition = ListСondition.fieldNotOccupied.ToString();
        }
        #endregion
    }
}
