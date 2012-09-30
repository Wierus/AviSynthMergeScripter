using System.Collections.Generic;
using System.Xml;

namespace AviSynthMergeScripter {

    public class Settings {

        private const string SettingsFileName = "Settings.xml";

        private XmlDocument xmlDocument;
        private XmlElement  rootElement;

        public Settings() {
            this.xmlDocument = new XmlDocument();
            this.xmlDocument.Load(SettingsFileName);
            this.rootElement = this.xmlDocument.DocumentElement;
        }

        public List<string> GetSettingValues(string settingName) {
            List<string> settingValues = new List<string>();
            foreach (XmlElement element in this.rootElement.GetElementsByTagName(settingName)) {
                settingValues.Add(element.GetAttribute("value"));
            }
            return settingValues;
        }

        public string GetDefaultSettingValue(string settingName) {
            foreach (XmlElement element in this.rootElement.GetElementsByTagName(settingName)) {
                if (element.GetAttribute("default") == "true") {
                    return element.GetAttribute("value");
                }
            }
            return null;
        }

    }

}
