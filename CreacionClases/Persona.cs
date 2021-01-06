namespace CreacionClases
{
    public class Persona
    {
        #region "Propiedades"
        private string _nombre;
        private int _edad;

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set { _nombre = value; }
        }
        public int Edad
        {
            get { return _edad; }
            set
            {
                _edad = value;
            }
        }
        #endregion

    }
}
