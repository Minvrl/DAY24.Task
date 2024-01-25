using DAY24.Task;

ShapeManager manager = new ShapeManager();

Circle circle = new Circle { Radius = 1};
Circle circle2 = new Circle { Radius = 2 };
Circle circle3 = new Circle { Radius = 0 };
Rectangle rect = new Rectangle() { Length =10, Width = 10};
Rectangle rect2 = new Rectangle() { Length = 14, Width = 10 };
Rectangle rect3 = new Rectangle() { Length = 4, Width = 4 };


manager.AddShape(circle);
manager.AddShape(circle2);
manager.AddShape(circle3);
manager.AddShape(rect);
manager.AddShape(rect2);
manager.AddShape(rect3);

Console.WriteLine(manager.GetCircleCount());