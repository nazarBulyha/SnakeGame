namespace ProSnake
{
    class Square : IShape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Square()
        {
            X = 0;
            Y = 0;
        }
    }
}