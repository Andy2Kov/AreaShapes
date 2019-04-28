namespace AreaShapes
{
    public static class Calculate
    {
        public static ShapeParams CalculateArea(double r)
        {
            Circle c = new AreaShapes.Circle(r);
            ShapeParams p = new AreaShapes.ShapeParams() {
                Area = c.Area(),
                ShapeName = c.ShapeName
            } ; 
            return p;  
        }

        public static ShapeParams CalculateArea(double a, double b, double c)
        {
            Triangle t = new AreaShapes.Triangle(a, b, c);
            ShapeParams p = new AreaShapes.ShapeParams() {
                Area = t.Area(),
                ShapeName = t.ShapeName
            };
            return p;  
        }
    }

    public struct ShapeParams
    {
        public double Area;
        public string ShapeName;
    }
}
