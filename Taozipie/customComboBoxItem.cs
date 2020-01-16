namespace Taozipie
{
    class customComboBoxItem
    {
        public string Text { get; set; }
        public Product Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
