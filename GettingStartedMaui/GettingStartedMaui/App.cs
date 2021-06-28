using Microsoft.Maui;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStartedMaui
{
    public class App : IApplication
    {
		List<IWindow> _windows = new List<IWindow>();
		public IReadOnlyList<IWindow> Windows => _windows.AsReadOnly();

		public IWindow CreateWindow(IActivationState activationState)
		{
			var window = new Window(new MainPage());
			_windows.Add(window);
			return window;
		}
	}
}
