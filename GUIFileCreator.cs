using System;
using System.Collections.Generic;
namespace LazyPythonGUICreator
{
    class GUIFileCreator
    {
        private string generateControlCode(PythonGuiControl p)
        {
            return "";
        }

        private string generateControlEventCode(PythonGuiControl p)
        {
            return "";
        }

        public void createFile(List<PythonGuiControl> _lst)
        {
            // Ich brauchte einen einzigartigen Namen, wollte zum jetzigen Zeitpunkt aber noch kein FileDialog implementieren.
            DateTime dtToday = DateTime.Today;
            string strFileName = dtToday.Year + dtToday.Month + dtToday.Day + dtToday.Hour + dtToday.Minute + dtToday.Second + ".py"; 
            
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("./Output/" + strFileName, true))
            {
                file.WriteLine("import tkinter as tk");
                
                file.WriteLine("class viewMainform: #TODO Name");
                
                file.WriteLine("\tdef __init__(self):");
                file.WriteLine("\t\tself.viewmodel = viewmodelMainform(self)");
                file.WriteLine("\t\tself.InitializeComponents()");
                
                file.WriteLine("\tdef InitializeComponents(self):");
                file.WriteLine("\t\tself.form = tk.Tk()");
                file.WriteLine("\t\tself.form.geometry() #TODO");
                file.WriteLine("\t\tself.form.protocol(\"WM_DELETE_WINDOW\", self.viewmodel.on_closing)");

                foreach(PythonGuiControl p in _lst)
                {
                    file.WriteLine("");
                    file.WriteLine(this.generateControlCode(p));
                }

                file.WriteLine("");
                file.WriteLine("\t\tself.form.mainloop()");
            }
        }
    }
}