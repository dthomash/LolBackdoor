using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace LolBackdoor
{
    public static class ServerApiConfigHelper
    {
        private const string AttrNameName = "name";
        private const string ServerApiConfigFileName = "ServerAPIConfig.xml";
        
        public static Dictionary<string, string> GetServerApiVersions(LolRegion region)
        {
            Dictionary<string, string> serverApiVersions = null;
            XmlDocument serverConfig = new XmlDocument();
            serverConfig.Load(ServerApiConfigFileName);
            if (serverConfig.HasChildNodes)
            {
                XmlElement lolElement = GetLeagueOfLegendsElement(serverConfig);
                XmlElement serverElement = GetServerElement(region, lolElement);
                serverApiVersions = GetServerApiVersions(serverElement);
            }
            return serverApiVersions;
        }

        private static Dictionary<string, string> GetServerApiVersions(XmlElement serverElement)
        {
            return serverElement.ChildNodes
                .OfType<XmlElement>()
                .ToDictionary(x => x.GetAttribute("name"), x => x.GetElementsByTagName("version").OfType<XmlElement>().First().InnerText);
        }

        private static XmlElement GetServerElement(LolRegion region, XmlElement lolElement)
        {
            return GetElementsByElementNameAndAttributeValue(lolElement, "server", "region", region.ToString())
                .First();
        }

        private static XmlElement GetLeagueOfLegendsElement(XmlDocument riotServerDoc)
        {
            return GetElementsByNameAndElementName(riotServerDoc.DocumentElement, "game", "LeagueOfLegends")
                .First();
        }
        private static IEnumerable<XmlElement> GetElementsByNameAndElementName(XmlElement node, string elementName, string name)
        {
            return GetElementsByElementNameAndAttributeValue(node, elementName, AttrNameName, name);
        }

        private static IEnumerable<XmlElement> GetElementsByElementNameAndAttributeValue(XmlElement node, string elementName, string attrName,
            string attrValue)
        {
            return node.GetElementsByTagName(elementName)
                .OfType<XmlElement>()
                .Where(x => x.HasAttribute(attrName) && x.GetAttribute(attrName) == attrValue);
        }
    }
}
