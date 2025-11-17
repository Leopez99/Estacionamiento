using ConsoleApp2.Vehiculos;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Ticketera
    {
        //La ticketera entrega un qr que tiene la informacion de la hora de entrada del auto
        //y una foto con su patente, tambien debe identificar si es una moto, camioneta o auto


        public void ObtenerDatosDeAuto()
        {

        }

        public void CrearTicket(Vehiculo vehiculo)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(CrearJson(vehiculo), QRCodeGenerator.ECCLevel.Q);

            //Borrar despues 
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            qrCodeImage.Save("QR.png", ImageFormat.Png);
        }


        private String CrearJson(Vehiculo vehiculo)
        {
            return JsonSerializer.Serialize(vehiculo);
        }

    }
}
