using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Windows;
using AcAp = Autodesk.AutoCAD.ApplicationServices.Application;
using System.Windows.Forms;

namespace CSS_Palette.UtilsMethod
{
    public class UpdateMethod
    {
        public static string UpdateFileTemplate(string templateType)
        {
            Document doc = AcAp.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;
            string fullFileName = "";
            string mainDirectory = @"S:\@FRP\_SST-ST Alliance\3. CAD template\_Current template\";
            string searchPattern = templateType;

            string[] files = Directory.GetFiles(mainDirectory, searchPattern);
            if(files.Length > 0)
            {
                string filePath = files[0];
                string fileName = Path.GetFileName(filePath);
                fullFileName = mainDirectory + fileName;
            }
            else
            {
               
                ed.WriteMessage("Template not found !");
            }

            return fullFileName;
        }
    }
}
