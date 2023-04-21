using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PL_CONSOLE
{
    public class Program
    {
        static void Main(string[] args)
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            xmldoc.Load("C:\\Users\\digis\\Documents\\Valeria Rodriguez Puebla\\10.- DatosXML.xml");

            XmlDataDocument nuevoxml = new XmlDataDocument();

            XmlDeclaration xmlDeclaration = nuevoxml.CreateXmlDeclaration("1.0", "ISO-8859-1", null);
            nuevoxml.AppendChild(xmlDeclaration);
            XmlNode infoNode = nuevoxml.CreateElement("info");
            nuevoxml.AppendChild(infoNode);

            XmlNode noticiasNode = xmldoc.SelectSingleNode("/noticias");

            foreach(XmlNode noticiaNode in noticiasNode.ChildNodes)
            {
                XmlNode podcastNode = nuevoxml.CreateElement("podcast");
                podcastNode.Attributes.Append(nuevoxml.CreateAttribute("tipo")).Value = noticiaNode.Attributes["tipo"].Value;
                podcastNode.Attributes.Append(nuevoxml.CreateAttribute("libre")).Value = noticiaNode.SelectSingleNode("libre").InnerText;
                podcastNode.Attributes.Append(nuevoxml.CreateAttribute("id")).Value = noticiaNode.SelectSingleNode("id").InnerText;
                podcastNode.Attributes.Append(nuevoxml.CreateAttribute("is3idfp")).Value = noticiaNode.SelectSingleNode("is3idfp").InnerText;
                podcastNode.Attributes.Append(nuevoxml.CreateAttribute("idaudio")).Value = noticiaNode.SelectSingleNode("idaudio").InnerText;

                XmlNode categoriaNode = nuevoxml.CreateElement("podcast");
                categoriaNode.InnerText = noticiaNode.SelectSingleNode("categoria").InnerText;
                podcastNode.AppendChild(categoriaNode);

                XmlNode tituloNode = nuevoxml.CreateElement("titulo");
                tituloNode.InnerText = noticiaNode.SelectSingleNode("titulo").InnerText;
                podcastNode.AppendChild(tituloNode);

                XmlNode resumenNode = nuevoxml.CreateElement("resumen");
                resumenNode.InnerText = noticiaNode.SelectSingleNode("resumen").InnerText;
                podcastNode.AppendChild(resumenNode);

                XmlNode prevurlNode = nuevoxml.CreateElement("prevurl");
                prevurlNode.InnerText = noticiaNode.SelectSingleNode("prevurl").InnerText;
                podcastNode.AppendChild(prevurlNode);

                XmlNode urlNode = nuevoxml.CreateElement("url");
                urlNode.InnerText = noticiaNode.SelectSingleNode("url").InnerText;
                podcastNode.AppendChild(urlNode);

                infoNode.AppendChild(podcastNode);
            }
            Console.WriteLine(nuevoxml.OuterXml);
            nuevoxml.Save("C:\\Users\\digis\\Documents\\Valeria Rodriguez Puebla\\nuevoarchivo.xml");
            Console.ReadKey();
        }
    }
}
