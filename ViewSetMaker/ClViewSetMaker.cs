using System;
using ViewSetMaker.Ctr;
using Autodesk.Navisworks.Api.Plugins;
using System.Windows.Forms;

/// <summary>
/// Name
/// </summary>
namespace ViewSetMaker
{
    /// <summary>
    /// Addin Info
    /// </summary>
    [Plugin("ViewSetMaker", "Keeleys95", DisplayName = "ViewSetMaker")]
    [RibbonLayout("AddinRibbon.xaml")]
    [RibbonTab("ID_CustomTab_1", DisplayName = "ViewSetMaker")]
    [Command("ID_Button_1", Icon = "1_16.png", LargeIcon = "1_32.png", ToolTip = "Create Viewpoint List at once")]
    ///Command(buttonId at XAML button, name of Icon IMG, name of Icon IMG, ToolTips)

    /// Define Addin tab
    public class ClViewSetMaker : CommandHandlerPlugin
    {
        public override int ExecuteCommand(string name, params string[] parameters)
        {
            switch (name)
            {
                case "ID_Button_1":
                    if (!Autodesk.Navisworks.Api.Application.IsAutomated)
                    {
                        var pluginRecord = Autodesk.Navisworks.Api.Application.Plugins.FindPlugin("ViewSetMakerDockPanel.Keeleys95"); //'Namespace of tab'.'DeveloperName'
                        
                        if (pluginRecord is DockPanePluginRecord && pluginRecord.IsEnabled)
                        {
                            var docPanel = (DockPanePlugin)(pluginRecord.LoadedPlugin ?? pluginRecord.LoadPlugin()); // Load plugin when PluginRecord.LoadedPlugin is Null
                            docPanel.ActivatePane();
                        }

                    }

                    break;
            }

            return 0;
        }
    }
}


namespace AddinDockPanel
{
    [Plugin("ViewSetMakerDockPanel", "Keeleys95", DisplayName = "ViewSetMaker")] //Define Plugin's name, developer, display name
    [DockPanePlugin(235, 500, AutoScroll = true, MinimumHeight = 500, MinimumWidth = 235)]

    public class ViewSetMakerDockPanel : DockPanePlugin
    {
        public override Control CreateControlPane()
        {
            var tc = new TabControl();
            tc.ParentChanged += SetDockStile;

            var tp1 = new TabPage("Make Viewpoints");
            tp1.Controls.Add(new UcViewMake());
            tc.TabPages.Add(tp1);

            return tc;
        }

        private void SetDockStile(object sender, EventArgs e)
        {
            try
            {
                var tc = sender as TabControl;
                tc.Dock = DockStyle.Fill;
            }
            catch (Exception)
            {

            }
        }
        public override void DestroyControlPane(Control pane)
        {
            try
            {
                var ctr = (UcViewMake)pane;
                ctr?.Dispose();
            }
            catch (Exception)
            {

            }
        }
    }
}