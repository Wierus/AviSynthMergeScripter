using System.Collections.Generic;
using System.Xml;

namespace AviSynthMergeScripter {

    /// <summary>
    /// Настройки программы, загружаемые из XML-файла.
    /// </summary>
    public class Settings {

        /// <summary>
        /// Имя XML-файла настроек.
        /// </summary>
        public const string SettingsFileName = "Settings.xml";

        /// <summary>
        /// Имя XML-атрибута фактического значения настройки.
        /// </summary>
        private const string ValueMemberAttributeName   = "value";

        /// <summary>
        /// Имя XML-атрибута отображаемого значения настройки.
        /// </summary>
        private const string DisplayMemberAttributeName = "displayValue";

        /// <summary>
        /// Имя XML-атрибута фактического значения настройки по умолчанию.
        /// </summary>
        private const string DefaultAttributeName       = "default";

        /// <summary>
        /// XML-документ.
        /// </summary>
        private XmlDocument xmlDocument;

        /// <summary>
        /// Корневой элемент XML-документа.
        /// </summary>
        private XmlElement  rootElement;

        /// <summary>
        /// Конструктор настроек.
        /// Загрузка XML-документа из файла настроек и инициализация корневого элемента.
        /// </summary>
        public Settings() {
            this.xmlDocument = new XmlDocument();
            this.xmlDocument.Load(SettingsFileName);
            this.rootElement = this.xmlDocument.DocumentElement;
        }

        /// <summary>
        /// Получение списка фактических и отображаемых значений настройки с указанным именем.
        /// Выбираются фактическое и отображаемое значения.
        /// Если отображаемое значение не задано, то оно устанавливается такое же как фактическое.
        /// </summary>
        /// <param name="xPath">Имя настройки в соответствии с выражением XPath.</param>
        /// <returns>Список фактических и отображаемых значений настройки.</returns>
        public List<ListControlItem> GetListControlItems(string xPath) {
            List<ListControlItem> listControlItems = new List<ListControlItem>();
            XmlNodeList selectedXmlNodes = this.rootElement.SelectNodes(xPath);
            foreach (XmlElement element in selectedXmlNodes) {
                string valueMember   = element.GetAttribute(ValueMemberAttributeName);
                string displayMember = element.GetAttribute(DisplayMemberAttributeName);
                if (displayMember == string.Empty) {
                    displayMember = valueMember;
                }
                listControlItems.Add(new ListControlItem(valueMember, displayMember));
            }
            return listControlItems;
        }

        /// <summary>
        /// Получение фактического и отображаемого значения настройки по умолчанию с указанным именем.
        /// </summary>
        /// <param name="xPath">Имя настройки в соответствии с выражением XPath.</param>
        /// <returns>Фактическое и отображаемое значение настройки по умолчанию. null, если настройка с указанным именем отсутствует.</returns>
        public ListControlItem GetDefaultListControlItem(string xPath) {
            XmlNodeList selectedXmlNodes = this.rootElement.SelectNodes(xPath);
            foreach (XmlElement element in selectedXmlNodes) {
                if (element.GetAttribute(DefaultAttributeName) == "true") {
                    string valueMember   = element.GetAttribute(ValueMemberAttributeName);
                    string displayMember = element.GetAttribute(DisplayMemberAttributeName);
                    return new ListControlItem(valueMember, displayMember);
                }
            }
            return null;
        }

    }

}
