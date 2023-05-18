#if Mvu
using Microsoft.Maui.Controls;

#endif
namespace MauiApp._1.Helpers
{
    public static class VisualStateHelper
    {
        public static MC.VisualStateGroupList CreateVisualStateGroupList(IEnumerable<MC.VisualStateGroup> visualStateGroups)
        {
            var visualStateGroupList = new MC.VisualStateGroupList();

            foreach (var visualStateGroup in visualStateGroups)
            {
                visualStateGroupList.Add(visualStateGroup);
            }

            return visualStateGroupList;
        }
    }
}
