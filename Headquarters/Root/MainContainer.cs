using System.Windows;
using System.Windows.Interop;
using Headquarters.VM;
using View.Base;
using View.Window;

namespace Headquarters.Root
{
    public class MainContainer
    {
        private IWindow _window;

        public IWindow ResolveWindow()
        {
            PlayerViewModel playerViewModel = new PlayerViewModel();
            ViewModelFactory vmFactory = new ViewModelFactory(playerViewModel);

            Window main = new Main();
            _window = new MainWindowAdapter(main, vmFactory);
            return _window;
        }
    }
}