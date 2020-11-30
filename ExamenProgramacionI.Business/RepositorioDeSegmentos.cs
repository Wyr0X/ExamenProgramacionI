using ExamenProgramacionI.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ExamenProgramacionI.Business
{
    public class RepositorioDeSegmentos
    {
        private readonly List<SegmentoRectilineo> Lista = new List<SegmentoRectilineo>();

        private readonly string FilePath = Directory.GetCurrentDirectory() + "/datos.csv";

        public void Guardar()
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                foreach (SegmentoRectilineo segmento in Lista)
                {
                    writer.WriteLine(segmento.ToString());
                }
            }
        }

        public void Leer()
        {
            if (!File.Exists(FilePath)) return;

            using (StreamReader reader = new StreamReader(FilePath))
            {
                while (!reader.EndOfStream)
                {
                    string Linea = reader.ReadLine();

                    Lista.Add(new SegmentoRectilineo(Linea));
                }
            }
        }

        public void Agregar(SegmentoRectilineo segmento)
        {
            Lista.Add(segmento);
        }

        public List<SegmentoRectilineo> ObtenerLista()
        {
            return Lista;
        }

        public bool Existe(SegmentoRectilineo segmentoAE)
        {
            int result = Lista.IndexOf(segmentoAE);

            return result != -1;
        }

        public void Eliminar(SegmentoRectilineo segmento)
        {
            Lista.Remove(segmento);
        }

        public List<SegmentoRectilineo> OrdenarPorLongitud(bool Descendiente)
        {
            if (Descendiente)
            {
                return Lista.OrderByDescending(s => s.Longitud()).ToList();
            }
            else
            {
                return Lista.OrderBy(s => s.Longitud()).ToList();
            }
        }

        public List<SegmentoRectilineo> OrdenarPorCoordX1(bool Descendiente)
        {
            if (Descendiente)
            {
                return Lista.OrderByDescending(s => s.A.X).ToList();
            }
            else
            {
                return Lista.OrderBy(s => s.A.X).ToList();
            }
        }
    }
}
