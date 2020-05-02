namespace TestTabControl
{
    public class Rectangle : Shape
    {
        public Rectangle(double w, double h) : base(w, h)
        {
            Name = this.GetType().Name;
        }
    }
}
