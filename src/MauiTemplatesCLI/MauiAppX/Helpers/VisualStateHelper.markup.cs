namespace MauiApp._1.Helpers
{
    public static class VisualStateHelper
    {
        public static VisualStateGroupList CreateVisualStateGroupList(IEnumerable<VisualStateGroup> visualStateGroups)
        {
            var visualStateGroupList = new VisualStateGroupList();

            foreach (var visualStateGroup in visualStateGroups)
            {
                visualStateGroupList.Add(visualStateGroup);
            }

            return visualStateGroupList;
        }
    }
}
