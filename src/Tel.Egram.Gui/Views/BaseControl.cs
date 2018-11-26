using System;
using System.Reactive.Disposables;
using Avalonia;
using Avalonia.LogicalTree;
using ReactiveUI;

namespace Tel.Egram.Gui.Views
{
    /// <summary>
    /// Workaround for model activation
    /// </summary>
    public class BaseControl<TViewModel> : ReactiveUserControl<TViewModel>
        where TViewModel : class
    {   
        public BaseControl()
        {
            this.WhenActivated(disposables =>
            {
                Disposable.Create(() => { }).DisposeWith(disposables);
            });
        }
    }
}