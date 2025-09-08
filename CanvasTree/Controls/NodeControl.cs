using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace CanvasTree.Controls;

public class NodeControl : Control
{
    public override void Render(DrawingContext context)
    {
        base.Render(context);
        
        var center = new Point(Bounds.Width / 2, Bounds.Height / 2);

        // circle
        var pen = new Pen(Brushes.Black, 1.5);
        var radius = 20d;
        context.DrawEllipse(Brushes.White, pen, center, radius, radius);
    }
}