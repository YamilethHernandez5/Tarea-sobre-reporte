using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_sobre_reporte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Creamos la instancia de la Reporte
            Reporte report = new Reporte();

            //Creamos un objeto

            //Asignar valores a las propiedades
            report.setReportId(1);
            report.setReportCode("");
            report.setReportName("");
            report.setReportDate("");

            //Asignar valores a propiedades autoimplementadas 
            report._ReportDescription = ("");
            //Mostrar datos del Reporte
            /* MessageBox.Show(
               "Datos del reporte:  " +
               "\n ID :  " + report.getReportId() +
                "\n Código de reporte:  " + report.getReportCode() +
                "\n Nombre:   " + report.getName() +
                 "\n Fecha de reporte:   " + report.getReportDate() +
                  "\n Descripción de reporte:   " + report._ReportDescription
                  );*/
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            //Instancia de la clase utilizando constructores 

            //Utilizando constructor vacio 
            Reporte report = new Reporte();
            report.setReportId(Convert.ToInt32(txtReportId.Text));
            report.setReportCode(txtReportCode.Text);
            report.setReportName(txtName.Text);
            report.setReportDate(txtReportDate.Text);
            report._ReportDescription = txtReportDescription.Text;

            //Constructor que inicializa todas las propiedades
            Reporte reportI = new Reporte(Convert.ToInt32(txtReportId.Text),
                txtReportCode.Text, txtName.Text, txtReportDate.Text, txtReportDescription.Text);


            //agregar los datos a listbox
            lstReportInfo.Items.Add("Mediante constructor vacío: " + report.getReportInfo());
            lstReportInfo.Items.Add("Mediante constructor inicializando las propiedades: " + reportI.getReportInfo());
        }
    }
    
}
