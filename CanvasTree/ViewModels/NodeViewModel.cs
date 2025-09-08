namespace CanvasTree.ViewModels;

public class NodeViewModel : ViewModelBase
{
    public double X { get; set; }
    public double Y { get; set; }
    
    public NodeViewModel(double x, double y)
    {
        X = x;
        Y = y;
    }
}