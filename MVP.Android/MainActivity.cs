using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using System.Xml.Linq;
using Android.Widget;
using Android.Content.Res;
using System.IO;
using System.Xml;
using Java.IO;
using Android.Graphics;
using System.Runtime.Remoting.Contexts;

namespace MVP.Droid
{
    [Activity(Label = "MVP", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
        

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}





//Typeface tf = Typeface.CreateFromAsset(this.Assets, "archivoXml1.xml");

/*
AssetManager assets = this.Assets;

XmlReader xmlReader = XmlReader.Create(assets.Open("archivoXml1.xml"));
while (xmlReader.Read())
{
    if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "Temperatura"))
    {
        if (xmlReader.HasAttributes)
        {
            // Leo valores de temperatura del Xml 
            Console.WriteLine(xmlReader.GetAttribute("valorTemp") + ": " + xmlReader.GetAttribute("unidad"));
            string temperatura = xmlReader.GetAttribute("valorTemp");

            Console.WriteLine("la temperatura:");
            Console.WriteLine(temperatura);

        }
    }
} */

// Read the contents of our asset
/*
AssetManager assets = this.Assets;
//XDocument xdoc = XDocument.Load(assets.Open("archivoXml1.xml"));
XmlDocument doc = new XmlDocument();
doc.Load(assets.Open("archivoXml1.xml"));
XmlNode root = doc.SelectSingleNode("Resultados");

XmlElement temperaturas = doc.CreateElement("Temperaturas");
root.AppendChild(temperaturas);

XmlAttribute id = doc.CreateAttribute("id");
id.Value = doc.SelectNodes("Resultados/Temperaturas").Count.ToString();
temperaturas.Attributes.Append(id);

Console.WriteLine(doc.InnerXml);
*/



// Cargo el Xml y agrego data
/*
XmlDocument doc = new XmlDocument.Load();
doc.Load(assets.Open("archivoXml1.xml"));
doc.SelectSingleNode("Temperatura");

XmlElement raiz = doc.CreateElement("Libros");
doc.AppendChild(raiz);

XmlElement libro = doc.CreateElement("libro");
raiz.AppendChild(libro);

XmlElement titulo = doc.CreateElement("titulo");
titulo.AppendChild(doc.CreateTextNode("El Hobbit 2"));
libro.AppendChild(titulo);

XmlElement precio = doc.CreateElement("precio");
precio.AppendChild(doc.CreateTextNode("10.0"));
libro.AppendChild(precio);


doc.Save("XMLFile1.xml");

*/

