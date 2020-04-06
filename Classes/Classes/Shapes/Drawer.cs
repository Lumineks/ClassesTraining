using System.Collections.Generic;

namespace Classes
{
    public class Drawer
    { 
        public static void DrawPicture(List<Shape> list)
        {
            foreach (var shape in list)
                shape.Draw();
        }
    }
}
