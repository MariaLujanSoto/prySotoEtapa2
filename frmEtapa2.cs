using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySotoEtapa2
{
    public partial class frmEtapa2 : Form
    {
        public frmEtapa2()
        {
            InitializeComponent();
        }

        clsVehiculo objAuto;
        clsVehiculo objAvion;
        clsVehiculo objBarco;
        int caso = 1;

        private void frmEtapa2_Load(object sender, EventArgs e)
        {
            objAuto = new clsVehiculo();
            objAvion = new clsVehiculo();
            objBarco = new clsVehiculo();

            objAuto.crearAuto();
            objAvion.crearAvion();
            objBarco.crearBarco();
        }

        private void btnCrearVehiculos_Click(object sender, EventArgs e)
        {
            if(caso == 1) {
                objAuto.crearAuto();
                objAuto.Auto.Location = new Point(400, 500);
                this.Controls.Add(objAuto.Auto);
                objBarco.Barco.Dispose();
                caso++;
                

            }
            else
            {
                if(caso == 2)
                {
                    objAvion.crearAvion();
                    objAvion.Avion.Location = new Point(200, 100);
                    Controls.Add(objAvion.Avion);
                    objAuto.Auto.Dispose();
                    caso++;
                }
                else
                {
                    objBarco.crearBarco();
                    objBarco.Barco.Location = new Point(300, 350);
                    this.Controls.Add(objBarco.Barco);
                    objAvion.Avion.Dispose();

                    caso = 1;
                }
            }        
                    

        }
    }
}
