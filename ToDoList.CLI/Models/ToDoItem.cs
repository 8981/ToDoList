namespace ToDoList
{
    public class ToDoItem
    {
        public string? Text { get; }
        public int Number { get; }

        public ToDoItem(string text, int number)
        {
            Text = text;
            Number = number;
        }

        public override string ToString()
        {
            return "#" + Number + " " + Text;
        }
    }
    
}