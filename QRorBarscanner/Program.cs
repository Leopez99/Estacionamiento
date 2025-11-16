using System;
using System.Drawing;
using System.Drawing.Imaging;
using QRCoder;
namespace QRorBarscanner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("The payload aka the text which should be encoded.", QRCodeGenerator.ECCLevel.Q);

            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            qrCodeImage.Save("QR.png", ImageFormat.Png);


            Console.WriteLine("Hello World!");
        }
    }
}