using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;

namespace CanvasTree.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<NodeViewModel> Nodes { get; set; } =
    [
        new NodeViewModel(100, 150),
        new NodeViewModel(400, 200),
        new NodeViewModel(500, 400)
    ];

    [RelayCommand]
    private void AddNewNode()
    {
        var x = Random.Shared.Next(100, 1000);
        var y = Random.Shared.Next(100, 1000);
        Nodes.Add(new NodeViewModel(x, y));
    }
}