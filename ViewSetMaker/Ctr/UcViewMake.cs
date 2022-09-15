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
            //Import user input data
            var dongStart = numBuildingStart.Text;
            var dongEnd = numBuildingEnd.Text;
            var EntFloor = numEntranceFloor.Text;
            var StnFloor = numStandardFloor.Text;
            var UndgFloor = numUndergroundNum.Text;

            //Create list containing user input Data
            List<string> userInputs = new List<string>();
            userInputs.Add(dongStart);
            userInputs.Add(dongEnd);
            userInputs.Add(EntFloor);
            userInputs.Add(StnFloor);
            userInputs.Add(UndgFloor);
            bool IsReadyToRun = false;
            /* Type Hint : [0] : 첫동 번호, [1] : 끝동 번호, [2] : 출입구층 번호, [3] : 기준층 번호, [4] : 지하주차장 층수 */
            //Create new container
            List<int> userInputsConverted = new List<int>();

            //Test if list contains invalid inputs; all inputs should be int type.
            foreach(string Inputs in userInputs)
            {
                bool IsInt = int.TryParse(Inputs, out int intData);
                if(IsInt == true)
                {
                    userInputsConverted.Add(intData);
                    IsReadyToRun = true;
                }
                else
                {
                    IsReadyToRun = false;
                    userInputsConverted.Clear();
                }
            }

            //Run It
            if(IsReadyToRun == true)
            {

                int a1;
                int a2;
                int.TryParse(dongStart, out a1);
                int.TryParse(dongEnd, out a2);
                var dongNames = CreateDongNameSet(a1, a2);
                List<string> dongStrings = new List<string>();

                foreach (var item in dongNames)
                {
                    string s = item.ToString();
                    dongStrings.Add(s);
                }

                try
                {
                    ResetSelection();
                    CreateItemSet(dongStrings);
                }
                catch (Exception)
                {

                }
            }
            else
            {
                MessageBox.Show("각 항목을 정수로 입력하지 않았거나 공백이 없는지 확인해 주세요");
            }
        }

        //Creating item set
        private void CreateItemSet(List<string> dongNameSet /*, int entFloor, int EntStnFloor, int UndgFloor*/)
        {
            var objectCollection = new List<ModelItem>();
            {
                foreach(var dongName in dongNameSet)
                {
                    foreach (var item in NavisworksApp.ActiveDocument.Models.RootItems)
                    {

                        var BHCategory = item.DescendantsAndSelf.Where(i => i.PropertyCategories.FindCategoryByDisplayName(tbBHCategory.Text) != null);
                        var BHDongNum = BHCategory.Where(m => m.PropertyCategories.FindCategoryByDisplayName(tbBHCategory.Text).
                                                    Properties.FindPropertyByDisplayName(tbBHDongTypeName.Text) != null);
                        /*var BH = BHCategory.Where(m => m.PropertyCategories.FindCategoryByDisplayName(tbCategory.Text).
                                                    Properties.FindPropertyByDisplayName(tbDebugFloorTypeName.Text) != null);*/ //Temporary line.
                        objectCollection.AddRange(BHDongNum.Where(m => GetPropValue(m.PropertyCategories.FindCategoryByDisplayName(tbBHCategory.Text).
                                                        Properties.FindPropertyByDisplayName(tbBHDongTypeName.Text)) == dongName));
                    }
                }
                //For only testing
                NavisworksApp.ActiveDocument.CurrentSelection.Clear();
                NavisworksApp.ActiveDocument.CurrentSelection.AddRange(objectCollection);
            }
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

        //Search method for only debugging
        private void debugSearchItems()
        {
            var result = new List<ModelItem>();

            //Models.RootItems indicates the root items that is shown on selection tree panel
            foreach (var item in NavisworksApp.ActiveDocument.Models.RootItems)
            {
                
                var cat = item.DescendantsAndSelf.Where(i => i.PropertyCategories.FindCategoryByDisplayName(tbDebugCategory.Text) != null);
                var debugDongNum = cat.Where(m => m.PropertyCategories.FindCategoryByDisplayName(tbDebugCategory.Text).
                                            Properties.FindPropertyByDisplayName(tbDebugDongTypeName.Text) != null);
                var debugFloorNum = cat.Where(m => m.PropertyCategories.FindCategoryByDisplayName(tbDebugCategory.Text).
                                            Properties.FindPropertyByDisplayName(tbDebugFloorTypeName.Text) != null);
                result.AddRange(debugDongNum.Where(m => GetPropValue(m.PropertyCategories.FindCategoryByDisplayName(tbDebugCategory.Text).
                                                Properties.FindPropertyByDisplayName(tbDebugDongTypeName.Text)) == tbDebugDongValue.Text &&
                                                GetPropValue(m.PropertyCategories.FindCategoryByDisplayName(tbDebugCategory.Text).
                                                Properties.FindPropertyByDisplayName(tbDebugFloorTypeName.Text)) == tbDebugFloorValue.Text));
                
            }
            NavisworksApp.ActiveDocument.CurrentSelection.Clear();
            NavisworksApp.ActiveDocument.CurrentSelection.AddRange(result);
        }

        private void btDebugFind_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                debugSearchItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string LastIsolatedName { get; private set; }

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
            catch(Exception)
            {

            }
        }


        //Create Hide Item
        private void HideItemsByFloor(int entFloor, int stnFloor, string dongName, bool IsHideForEnt)
        {
            var DongItemSet = new ModelItemCollection();
            var HideFloorListEnt = new List<int>();
            var HideFloorListStn = new List<int>();

            //Find Highest Level
            foreach (var item in NavisworksApp.ActiveDocument.Models.RootItems)
            {
                var cat = item.DescendantsAndSelf.Where(i => i.PropertyCategories.FindCategoryByDisplayName(tbBHCategory.Text) != null);
                var FloorObj = cat.Where(m => m.PropertyCategories.FindCategoryByDisplayName(tbBHCategory.Text).
                                                Properties.FindPropertyByDisplayName(tbFloornumCat.Text) != null &&
                                              m.PropertyCategories.FindCategoryByDisplayName(tbBHCategory.Text).
                                                Properties.FindPropertyByDisplayName(tbBHDongTypeName.Text).ToString() == dongName);
                foreach (var modelObj in FloorObj)
                {
                    DongItemSet.Add(modelObj);
                    foreach (var categoryName in modelObj.PropertyCategories)
                    {
                        foreach (var floorPropValue in categoryName.Properties.Where(i => i.DisplayName == tbFloornumCat.Text))
                        {
                            string ModelFloorString = GetPropValue(floorPropValue);
                            int ModelFloorNum;
                            int.TryParse(ModelFloorString, out ModelFloorNum);
                            if(HideFloorListEnt.Contains(ModelFloorNum) == false)
                            {
                                HideFloorListEnt.Add(ModelFloorNum);
                            }
                            HideFloorListEnt.Add(ModelFloorNum);

                            if (HideFloorListStn.Contains(ModelFloorNum) == false)
                            {
                                HideFloorListStn.Add(ModelFloorNum);
                            }
                        }
                    }
                }
            }

        /* 22.09.15
        FloorObj cannot be added.
         */

            //Create sets containing floor numbers not to hide
            foreach (int fl in HideFloorListEnt)
            {
                if (fl < entFloor+1)
                {
                    HideFloorListEnt.Remove(fl);
                }
            }

            foreach (int fl in HideFloorListStn)
            {
                if (fl < stnFloor + 1)
                {
                    HideFloorListStn.Remove(fl);
                }
            }

            //Select item to Hide
            var HideItemSetEnt = new ModelItemCollection();
            var HideItemSetStn = new ModelItemCollection();
            foreach (var item1 in DongItemSet)
            {
                int flNumInt;
                var info = item1.PropertyCategories.FindCategoryByDisplayName(tbBHCategory.Text).Properties.FindPropertyByDisplayName(tbFloornumCat.Text);
                string flString = GetPropValue(info);
                int.TryParse(flString, out flNumInt);
                if (HideFloorListEnt.Contains(flNumInt) == true)
                {
                    HideItemSetEnt.Add(item1);
                }
            }

            foreach (var item in DongItemSet)
            {
                int flNumInt;
                var info = item.PropertyCategories.FindCategoryByDisplayName(tbBHCategory.Text).Properties.FindPropertyByDisplayName(tbFloornumCat.Text);
                string flString = GetPropValue(info);
                int.TryParse(flString, out flNumInt);
                if (HideFloorListStn.Contains(flNumInt) == true)
                {
                    HideItemSetStn.Add(item);
                }
            }
            NavisworksApp.ActiveDocument.CurrentSelection.Clear();
            if(IsHideForEnt == true)
            {
                NavisworksApp.ActiveDocument.CurrentSelection.AddRange(HideItemSetEnt);
            }
            else
            {
                NavisworksApp.ActiveDocument.CurrentSelection.AddRange(HideItemSetStn);
            }
;
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
            SaveViewpoint();
        }

        //Invert Hide
        private void HideForStn_MouseUp(object sender, MouseEventArgs e)
        {
            int entFlNum;
            int stnFlNum;
            int.TryParse(tbEntFloor.Text, out entFlNum);
            int.TryParse(tbStnFloor.Text, out stnFlNum);
            int dongStartNum = DongNumParser(numBuildingStart.Text);
            int dongEndNum = DongNumParser(numBuildingEnd.Text);
            var dongNames = CreateDongNameSet(dongStartNum, dongEndNum);
            foreach(string dongName in dongNames)
            {
                HideItemsByFloor(entFlNum, stnFlNum, dongName, true);
            }
        }

        private int DongNumParser(string buildingStart)
        {
            int a1;
            int.TryParse(buildingStart, out a1);
            return a1;
        }

        private void HideForEnt_MouseUp(object sender, MouseEventArgs e)
        {
            int entFlNum;
            int stnFlNum;
            int.TryParse(tbEntFloor.Text, out entFlNum);
            int.TryParse(tbStnFloor.Text, out stnFlNum);
            int dongStartNum = DongNumParser(numBuildingStart.Text);
            int dongEndNum = DongNumParser(numBuildingEnd.Text);
            var dongNames = CreateDongNameSet(dongStartNum, dongEndNum);
            foreach (string dongName in dongNames)
            {
                HideItemsByFloor(entFlNum, stnFlNum, dongName, false);
            }
        }
    }


    //Recording setting values while 
    /// <param name="sender"></param>
    /// <param name="e"></param>

}




