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

        //Eventhandlers
        private void numBuildingStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void numBuildingEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void numEntranceFloor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void numStandardFloor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void numUndergroundNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
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
                if(IsInt == false)
                {
                    MessageBox.Show("각 항목을 정수로 입력해 주세요");
                }
                else
                {
                    userInputsConverted.Add(intData);
                    IsReadyToRun = true;
                }
            }

            //Run it
            if (IsReadyToRun == true);
            {
                try
                {
                    ResetSelection();
                }
                catch (Exception)
                {

                }
            }
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
            
            foreach (var item in NavisworksApp.ActiveDocument.CurrentSelection.SelectedItems)
            {
                var cat = item.DescendantsAndSelf.Where(i => i.PropertyCategories.FindCategoryByDisplayName(tbCategory.Text) != null);
                var debugDongNum = cat.Where(m => m.PropertyCategories.FindCategoryByDisplayName(tbCategory.Text).
                                            Properties.FindPropertyByDisplayName(tbDebugDongTypeName.Text) != null);
                var debugFloorNum = cat.Where(m => m.PropertyCategories.FindCategoryByDisplayName(tbCategory.Text).
                                            Properties.FindPropertyByDisplayName(tbDebugFloorTypeName.Text) != null);
                result.AddRange(debugDongNum.Where(m => GetPropValue(m.PropertyCategories.FindCategoryByDisplayName(tbCategory.Text).
                                                Properties.FindPropertyByDisplayName(tbDebugDongTypeName.Text)) == tbDebugDongValue.Text &&
                                                GetPropValue(m.PropertyCategories.FindCategoryByDisplayName(tbCategory.Text).
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
    }


    //Recording setting values while 
    /// <param name="sender"></param>
    /// <param name="e"></param>

}




