using System;
using System.Collections.Generic;

namespace FormsProofOfConcept.ViewModels
{
    public class ItemGroup : List<ItemViewModel>
    {
        public string HeaderTitle { get; private set; }

        public string HeaderSubtitle { get; private set; }

        public ItemGroup(int groupNumber, List<ItemViewModel> items) : base(items)
        {
            HeaderTitle = $"Group: {groupNumber}";
            HeaderSubtitle = $"{items.Count} item" + (items.Count > 1 ? "s" : "");
        }
    }
}
