using System.Windows.Media;

namespace SeaBattle
{
    public class Field
    {
        #region Поля
        private string сondition;
        private int numberFieldHorizantal;
        private int numberFieldVertikal;
        public Geometry Geometry { get; set; }
        public Brush Fill { get; set; }
        public Brush Stroke { get; set; }
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
        public Field(int h, int v, Geometry g, Brush f, Brush s)
        {
            numberFieldHorizantal = h;
            numberFieldVertikal = v;
            Geometry = g;
            Fill = f;
            Stroke = s;
            сondition = ListСondition.fieldNotOccupied.ToString();
        }
        #endregion
    }
}
