namespace AviSynthMergeScripter {

    /// <summary>
    /// Представляет элемент, хранящий фактическое и отображаемое значения для класса ListControl.
    /// Может быть использован для классов ComboBox и ListBox.
    /// </summary>
    public class ListControlItem {

        /// <summary>
        /// Фактическое значение.
        /// </summary>
        private string valueMember;

        /// <summary>
        /// Отображаемое значение.
        /// </summary>
        private string displayMember;

        /// <summary>
        /// Конструктор элемента.
        /// </summary>
        /// <param name="valueMember">Фактическое значение.</param>
        /// <param name="displayMember">Отображаемое значение.</param>
        public ListControlItem(string valueMember, string displayMember) {
            this.valueMember = valueMember;
            this.displayMember = displayMember;
        }

        /// <summary>
        /// Фактическое значение.
        /// </summary>
        public string ValueMember {
            get {
                return this.valueMember;
            }
        }

        /// <summary>
        /// Отображаемое значение.
        /// </summary>
        public string DisplayMember {
            get {
                return this.displayMember;
            }
        }

        /// <summary>
        /// Сравнение данного и указанного элементов.
        /// Сравнение производится только по фактическому значению (поле "ValueMember").
        /// </summary>
        /// <param name="obj">Элемент, с которым требуется сравнить данный элемент.</param>
        /// <returns>true, если поля "ValueMember" элементов равны. false, иначе.</returns>
        public override bool Equals(object obj) {
            return ((ListControlItem)obj).valueMember.Equals(this.valueMember);
        }

    }

}
