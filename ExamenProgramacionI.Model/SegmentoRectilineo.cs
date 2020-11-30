using System;

namespace ExamenProgramacionI.Model
{
    public class SegmentoRectilineo
    {
        public Punto A { get; set; }
        public Punto B { get; set; }

        public SegmentoRectilineo() { }

        public SegmentoRectilineo(string DatosCSV)
        {
            string[] Datos = DatosCSV.Split(',');
            A = new Punto()
            {
                X = int.Parse(Datos[0]),
                Y = int.Parse(Datos[1])
            };
            B = new Punto()
            {
                X = int.Parse(Datos[2]),
                Y = int.Parse(Datos[3])
            };
        }

        public double Longitud()
        {
            int DX = A.X - B.X;
            int DY = A.Y - B.Y;
            return Math.Sqrt(DX * DX + DY * DY);
        }

        public override string ToString()
        {
            return $"{A.X},{A.Y},{B.X},{B.Y}";
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                SegmentoRectilineo s = (SegmentoRectilineo)obj;

                return ToString().Equals(s.ToString());
            }
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
