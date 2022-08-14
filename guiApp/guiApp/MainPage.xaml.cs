using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace guiApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<structs.SolutionBase> solutions = new ObservableCollection<structs.SolutionBase>();
        ObservableCollection<InputContainer> Inputs = new ObservableCollection<InputContainer>();
        public MainPage()
        {
            solutions.Add(new Challenge_Solutions.Solution1CB());
            this.InitializeComponent();
        }

        private void SolutionChange(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
    public class InputContainer
    {
        public string Name;
        public string Input;
    }
    public class SolutionContainer
    {
        public string Name;

    }
}
