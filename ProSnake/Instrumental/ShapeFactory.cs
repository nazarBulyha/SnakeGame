using System.Collections.Generic;

namespace ProSnake
{
    class ShapeFactory {
        public static IShape GetSnakeShape(Shape snakeShape)
        {
            switch (snakeShape)
            {
                case Shape.Circle:
                    return new Circle();
                case Shape.Square:
                    return new Square();
                case Shape.Diamond:
                    return new Diamond();
                default: return new Circle();
            }
        }
        public static IEnumerable<IShape> GetListSnakeShape(Shape snakeShape)
        {
            IEnumerable<IShape> IShapeList;

            switch (snakeShape)
            {
                case Shape.Circle:
                    IShapeList = new List<Circle>();
                    break;

                case Shape.Square:
                    IShapeList = new List<Square>();
                    break;

                case Shape.Diamond:
                    IShapeList = new List<Diamond>();
                    break;

                default:
                    IShapeList = new List<Circle>();
                    return IShapeList;
            }
            return IShapeList;
        }
    }
}