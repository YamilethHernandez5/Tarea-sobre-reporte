using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_sobre_reporte
{
    class Reporte
    {
        //Metodo de propiedad
        private int _ReportId;
        private string _ReportCode;
        private string _Name;
        private string _ReportDate;

        //Metodo de propiedad autoimplementada 
        public string _ReportDescription { get; set; }

        //Metodo constructor
        public Reporte() //Metodo vacio 
        { }

        //Metodo de sobrecarga de constructor 
        public Reporte(int ReportId, string ReportCode, string Name, string ReportDate, string ReportDescription)
        {
            _ReportId = ReportId;
            _ReportCode = ReportCode;
            _Name = Name;
            _ReportDate = ReportDate;
            _ReportDescription = ReportDescription;
        }

        //Id de Reporte
        public int getReportId()
        {
            return _ReportId;
        }

        public void setReportId(int ReportId)
        {
            _ReportId = ReportId;
        }

        //Código de Reporte
        public string getReportCode()
        {
            return _ReportCode;
        }

        public void setReportCode(string ReportCode)
        {
            _ReportCode = ReportCode;
        }

        //Nombre 
        public string getName()
        {
            return _Name;
        }

        public void setReportName(string Name)
        {
            _Name = Name;
        }

        //Fecha de Reporte
        public string getReportDate()
        {
            return _ReportDate;
        }

        public void setReportDate(string ReportDate)
        {
            _ReportDate = ReportDate;
        }

        //Metodo para mostrar información del reporte
        public string getReportInfo()
        {
            return "ID:   " + _ReportId + "Código de reporte:  " + _ReportCode + "Nombre:  " + _Name + "Fecha de reporte:  " + _ReportDate + "Descripcion de reporte:  " + _ReportDescription;

        }

    }
}
