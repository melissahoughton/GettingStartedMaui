using Microsoft.Maui;
using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace GettingStartedMaui
{
    public class App : IApplication
    {
        List<IWindow> _windows = new List<IWindow>();
        public IReadOnlyList<IWindow> Windows => _windows.AsReadOnly();

        public App(IImageSourceServiceConfiguration imageConfig)
        {
            imageConfig.SetImageDirectory("Assets");
        }

        public IWindow CreateWindow(IActivationState activationState)
        {
            var window = new Window(new MainPage());
            _windows.Add(window);
            return window;
        }
    }
}
