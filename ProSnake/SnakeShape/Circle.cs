namespace ProSnake
{
    class Circle : IShape
    {
        //List<Circle> circleList;
        public int X { get; set; }
        public int Y { get; set; }

        public Circle()
        {
            X = 0;
            Y = 0;
        }
    }
}