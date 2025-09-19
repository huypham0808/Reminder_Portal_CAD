using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Windows;
using System.Windows;
using AcAp = Autodesk.AutoCAD.ApplicationServices.Application;
using System.IO;
using System.Windows.Forms;


[assembly: CommandClass(typeof(CSS_Palette.CSS_ToolPalette))]
namespace CSS_Palette
{
    public class CSS_ToolPalette
    {
        static PaletteSet palette;
        static bool wasVisible;
        [CommandMethod("CSS_PALETTE", CommandFlags.Modal)]
        public static void CSS_Utility()
        {
            if (palette == null)
            {
                palette = new PaletteSet("CSS_Reminder", "CSSPALETTE", new Guid("{E0A6F2C6-2D74-42FE-BFF2-2AAE212C9322}"));
                palette.Style = PaletteSetStyles.ShowAutoHideButton |
                                PaletteSetStyles.ShowCloseButton |
                                PaletteSetStyles.ShowPropertiesMenu;
                palette.MinimumSize = new System.Drawing.Size(350, 800);
                palette.AddVisual("REMINDER", new mainForm2());
                //palette.AddVisual("Tab 2", new mainForm2());
                //PaletteSetStyles.ShowTabForSingle |

                var docs = AcAp.DocumentManager;
                docs.DocumentBecameCurrent += (s, e) => palette.Visible = e.Document == null ? false : wasVisible;
                docs.DocumentCreated += (s, e) => palette.Visible = wasVisible;
                docs.DocumentToBeDeactivated += (s, e) => wasVisible = palette.Visible;
                docs.DocumentToBeDestroyed += (s, e) =>
                {
                    wasVisible = palette.Visible;
                    if (docs.Count == 1)
                        palette.Visible = false;
                };
            }
            palette.Visible = true;
            palette.RolledUp = true;
            palette.DockEnabled = DockSides.Left;
        }
        [CommandMethod("CSS_TEMPLATE")]
        public void CSS_Template()
        {
            Document doc = AcAp.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;
            string templateDirectory = UtilsMethod.UpdateMethod.UpdateFileTemplate("*ST-SST_CAD TEMPLATE.dwt");

            DocumentCollection docColl = AcAp.DocumentManager;
            Document newDrawing = docColl.Add(templateDirectory);
            docColl.MdiActiveDocument = newDrawing;
            ed.WriteMessage("Template was loaded successfully!");
        }
        [CommandMethod("CSS_INSTALLATION_NOTE")]
        public void CSS_InstallNote()
        {
            Document doc = AcAp.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;

            string templateDirectory = UtilsMethod.UpdateMethod.UpdateFileTemplate("*ST-SST_INSTALLATION NOTES.dwt");

            DocumentCollection docColl = AcAp.DocumentManager;
            Document newDrawing = docColl.Add(templateDirectory);
            docColl.MdiActiveDocument = newDrawing;
            ed.WriteMessage("Installation Note was loaded successfully!");
        }
    }
}
