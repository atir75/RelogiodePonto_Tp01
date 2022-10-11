using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tp01
{
    public class Ponto
    {
        public String matricula;
        public String data;
        public String hora;
        public String personalizado;


        public void setMatricula(String _matricula) { matricula = _matricula; }
        public void setData(String _data) { data = _data; }
        public void setHora(String _hora) { hora = _hora; }
        public void setPersonalizado(String _personalizado) { personalizado = _personalizado; }



        public String getMatricula() { return matricula; }
        public String getData() { return data; }
        public String getHora() { return hora; }
        public String getPersonalizado() { return personalizado; }

    }
}
