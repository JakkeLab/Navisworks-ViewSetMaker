using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Navisworks.Api;
using Autodesk.Navisworks.Api.Interop.ComApi;
using Autodesk.Navisworks.Api.ComApi;
using NavisworksApp = Autodesk.Navisworks.Api.Application;
using Autodesk.Navisworks.Gui.Roamer;

namespace ViewSetMaker.Ctr
{
    public partial class UcViewMake : UserControl
    {

        public UcViewMake() => InitializeComponent(); public static bool IsInitatedBefore = false;

        //Enable Buttons
        public void EnableAddinButtons()
        {
            UcViewMake.IsInitatedBefore = true;
            //Will open after building main functions
            //btLoadSet.Enabled = true;
            //btSave.Enabled = true;
            //btSaveAs.Enabled = true;
            numBuildingStart.Enabled = true;
            numBuildingEnd.Enabled = true;
            numEntranceFloor.Enabled = true;
            numStandardFloor.Enabled = true;
            numUndergroundNum.Enabled = true;
            btRun.Enabled = true;
            txtStatus.Enabled = true;
        }

        //Reset Selections
        private void ResetSelection()
        {
            try
            {
                NavisworksApp.ActiveDocument.CurrentSelection.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Create a new template
        private void createNewTemplate(object sender, MouseEventArgs e)
        {
            EnableAddinButtons();
        }

        private void runCreatingView(object sender, MouseEventArgs e)
        {
        }

        //Converting numbers to string for matching property displayName.
        private List<string> CreateDongNameSet(int dongStart, int dongEnd)
        {
            List<string> dongNameSet = new List<string>();
            for(int i = dongStart; i < dongEnd+1; i++)
            {
                string dongNumString = i.ToString();
                string dongName = String.Concat(dongNumString, "동");
                dongNameSet.Add(dongName);
            }
            return dongNameSet;
        }

        private static string GetPropValue(DataProperty prop)
        {
            try
            {
                return prop.Value.IsDisplayString ? prop.Value.ToDisplayString() : prop.Value.ToString().Split(':')[1];
            }
            catch (Exception)
            {
                return "Prop Error";
            }
        }

        //Select and show models and by adding to current selection
        private void ShowSelectedModelItem(List<ModelItem> ModelItems)
        {
            NavisworksApp.ActiveDocument.CurrentSelection.Clear();
            NavisworksApp.ActiveDocument.CurrentSelection.AddRange(ModelItems);
        }

        //Save ViewPoint
        private void SaveViewpoint()
        {
            var acd = NavisworksApp.ActiveDocument;
            try
            {
                var state = ComApiBridge.State;
                var cv = state.CurrentView.Copy();
                var vp = state.ObjectFactory(nwEObjectType.eObjectType_nwOpView);
                var view = vp as InwOpView;
                if (view != null) view.ApplyHideAttribs = true;
                view.ApplyMaterialAttribs = true;
                vp.Name = LastIsolatedName;
                vp.anonview = cv;
                state.SavedViews().Add(vp);
            }
            catch (Exception)
            {

            }
        }


        public static string LastIsolatedName { get; private set; }

        //Search method for only debugging
        private List<ModelItem> CreateHideItemSet(string DongName, string FlNumString)
        {
            var result = new List<ModelItem>();

            //Models.RootItems indicates the root items that is shown on selection tree panel
            foreach (var item in NavisworksApp.ActiveDocument.Models.RootItems)
            {

                var cat = item.DescendantsAndSelf.Where(i => i.PropertyCategories.FindCategoryByDisplayName(tbBHCategory.Text) != null);
                var debugDongNum = cat.Where(m => m.PropertyCategories.FindCategoryByDisplayName(tbBHCategory.Text).
                                            Properties.FindPropertyByDisplayName(tbBHDongTypeName.Text) != null);
                result.AddRange(debugDongNum.Where(m => GetPropValue(m.PropertyCategories.FindCategoryByDisplayName(tbBHCategory.Text).
                                                Properties.FindPropertyByDisplayName(tbBHDongTypeName.Text)) == DongName &&
                                                Int32.Parse(GetPropValue(m.PropertyCategories.FindCategoryByDisplayName(tbBHCategory.Text).
                                                Properties.FindPropertyByDisplayName(tbBHFloornumCat.Text))) > Int32.Parse(FlNumString)));
            }
            return result;
        }

        //Search method for only debugging
        private List<ModelItem> debugSearchItems()
        {
            var result = new List<ModelItem>();

            //Models.RootItems indicates the root items that is shown on selection tree panel
            foreach (var item in NavisworksApp.ActiveDocument.Models.RootItems)
            {

                var cat = item.DescendantsAndSelf.Where(i => i.PropertyCategories.FindCategoryByDisplayName(tbDebugCategory.Text) != null);
                var debugDongNum = cat.Where(m => m.PropertyCategories.FindCategoryByDisplayName(tbDebugCategory.Text).
                                            Properties.FindPropertyByDisplayName(tbDebugDongTypeName.Text) != null);
                result.AddRange(debugDongNum.Where(m => GetPropValue(m.PropertyCategories.FindCategoryByDisplayName(tbDebugCategory.Text).
                                                Properties.FindPropertyByDisplayName(tbDebugDongTypeName.Text)) == tbDebugDongValue.Text &&
                                                Int32.Parse(GetPropValue(m.PropertyCategories.FindCategoryByDisplayName(tbDebugCategory.Text).
                                                Properties.FindPropertyByDisplayName(tbDebugFloorTypeName.Text))) > Int32.Parse(tbDebugFloorValue.Text)));
            }
            return result;
        }
        private void btDebugFind_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                var ModelItems = debugSearchItems();
                ShowSelectedModelItem(ModelItems);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Input control for not to type strings except integer
        private void keyPress_IsIntOrBack(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btSaveView_MouseUp(object sender, MouseEventArgs e)
        {
        }

        //Invert Hide : Ent
        private void HideForEnt_MouseUp(object sender, MouseEventArgs e)
        {
            int dongStart = int.Parse(numBuildingStart.Text);
            int dongEnd = int.Parse(numBuildingEnd.Text);
            var DongNameSet = CreateDongNameSet(dongStart, dongEnd);
            var ModelItemSet = new List<ModelItem>();
            try
            {
                foreach (string DongName in DongNameSet)
                {
                    var ModelItems = CreateHideItemSet(DongName, tbEntFloor.Text);
                    ModelItemSet.AddRange(ModelItems);
                }
                ShowSelectedModelItem(ModelItemSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Invert Hide : Stn
        private void HideForStn_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btTestModelSet_MouseUp(object sender, MouseEventArgs e)
        {
        }
    }


    //Recording setting values while 
    /// <param name="sender"></param>
    /// <param name="e"></param>

} 




