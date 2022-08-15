using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
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
            GetSolutions();
            GetInputs();
            this.InitializeComponent();
            ApplicationView.PreferredLaunchViewSize = new Size(600, 200);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
        }


        private void GetSolutions()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            foreach (var item in assembly.DefinedTypes)
            {
                if (item.Namespace == typeof(Challenge_Solutions.Solution1CB).Namespace)
                {
                    solutions.Add((structs.SolutionBase)(item.AsType().GetConstructor(new Type[] { }).Invoke(new object[] { })));
                }
            }
        }
        private void GetInputs()
        {
            string start = AppDomain.CurrentDomain.BaseDirectory;
            string[] filepaths = Directory.GetFiles(start+"/Challenge Input");
            foreach (var path in filepaths)
            {
                var Input = new InputContainer();
                Input.Name = Path.GetFileName(path);
                var reader = new StreamReader(path);
                Input.Input = reader.ReadToEnd();
                reader.Close();
                Inputs.Add(Input);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (cmbInput.SelectedIndex == -1)return;
            if (cmbSolutions.SelectedIndex == -1) return;
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            try
            {
                txtOutput.Text = ((structs.SolutionBase)cmbSolutions.SelectedItem).Solve(((InputContainer)cmbInput.SelectedItem).Input);
            }
            catch (Exception err)
            {
                txtOutput.Text = err.Message;
            }
            sw.Stop();
            txtTime.Text = sw.Elapsed.ToString();
            sw.Reset();
        }
    }
    public class InputContainer
    {
        public string Name;
        public string Input;
        public override string ToString()
        {
            return Name;
        }
    }
}
