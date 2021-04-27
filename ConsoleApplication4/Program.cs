using System;

using Tekla.Structures.Drawing;
using TSDrw = Tekla.Structures.Drawing;
using TSDrwUI = Tekla.Structures.Drawing.UI;
using T3D = Tekla.Structures.Geometry3d;

using System.Text.RegularExpressions;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ДВУТAВР25К1";
            
            bool IsContains = new Regex(@"ДВУТAВР(\w*)К(\w*)").IsMatch(s);
            Console.WriteLine(IsContains);
            Console.ReadKey();
            return;
            //IsContains = match.Success; 
            //IsContains = s.Contains("ДВУТАВР*Б*");


            ArrayCollection<int> array = new ArrayCollection<int>();
            ArrayCollection<string> array_str = new ArrayCollection<string>();
            array.AddValue(1);
            array.AddValue(2);
            array.AddValue(33);
            array.AddValue(4);

            array_str.AddValue("ebala");
            array_str.AddValue("pizda");
            array_str.AddValue("like");
            array_str.AddValue("rotebat");
            array_str.AddValue("ale_blya");
            

            //Console.WriteLine("i = {0}", i);
            Console.WriteLine(array.GetValueByIndex(2));
            Console.WriteLine(array.GetLength());
            Console.WriteLine(array_str.GetValueByIndex(1));
            Console.WriteLine(array_str.GetLength());

            array_str.Remove("valera");
            array_str.Remove("rotebat");
           // Console.WriteLine('\n');

            Console.WriteLine(array_str.GetLength());
            Console.ReadKey();

        }

        private void EntryPoint()
        {
            Tekla.Structures.ModelInternal.Operation.dotStartAction("Interrupt", "MainFrame");
            bool keepgoing = true;
            while (keepgoing)
            {
                try
                {
                    CreateWeldLine();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                    break;
                }
            }
        }
        private static void CreateWeldLine()
        {
            DrawingHandler drawingHandler = new DrawingHandler();

            if (drawingHandler.GetConnectionStatus())
            {
                TSDrwUI.Picker picker = drawingHandler.GetPicker();

                ViewBase view = null;
                PointList points = new PointList();

                StringList prompts = new StringList();
                prompts.Add("Pick first point");
                prompts.Add("Pick second point");
                picker.PickPoints(2, prompts, out points, out view);

                T3D.Point _sp = points[0];
                T3D.Point _ep = points[1];

                DrawUsingPlugin(view, points, "WeldLinePlugin");

            }
        }
        public static bool DrawUsingPlugin(Tekla.Structures.Drawing.ViewBase view, TSDrw.PointList pointList, string Name)
        {
            TSDrw.Plugin plugin = new TSDrw.Plugin((TSDrw.ViewBase)view, Name);
            TSDrw.PluginPickerInput Input = new TSDrw.PluginPickerInput();
            Input.Add((TSDrw.PickerInput)new TSDrw.PickerInputNPoints((TSDrw.ViewBase)view, pointList));
            plugin.SetPickerInput(Input);

            plugin.SetAttribute("Joint", 0);
            plugin.SetAttribute("Shop", 0);
            plugin.SetAttribute("Visible", 1);
            bool flag = plugin.Insert();
            return flag;
        }
    }
}
