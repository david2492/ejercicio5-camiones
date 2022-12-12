using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml;





namespace Capacidad_camiones
{
    class camion
    {
        double capacidad;
        double sacas;

        public camion()
        {
            this.capacidad = 0.0;
            this.sacas = 0.0;
        }

        public void setcapacidad(double capacidad) => this.capacidad = capacidad;
        public double getcapacidad() { return this.capacidad; }

        public void setsacas(double sacas) => this.sacas = sacas;
        public double getsacas() { return this.sacas; }

        public bool VerificarCapacidad()
        {
            if (sacas > capacidad) return true;
            else return false;
            {

            }
        }


    }
}