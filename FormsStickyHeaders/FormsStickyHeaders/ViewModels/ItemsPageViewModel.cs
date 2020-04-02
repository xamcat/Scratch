using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Unicode;

namespace FormsProofOfConcept.ViewModels
{
    public class ItemsPageViewModel : BaseViewModel
    {
        private List<ItemGroup> _items = new List<ItemGroup>();
        public List<ItemGroup> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        public ItemsPageViewModel()
        {
            //Initialize mock item groups
            var groupCount = 100;
            var maxItemsPerGroup = 5;
            var random = new Random();
            var itemNumber = 0;
            var character = 0x0001F404;

            for (int i = 1; i < groupCount; i++)
            {
                var itemCountForGroup = random.Next(minValue: 1, maxValue: maxItemsPerGroup);
                if (itemCountForGroup == 0)
                {
                    continue;
                }
                var itemViewModels = new List<ItemViewModel>();
                for (int j = 0; j < itemCountForGroup; j++)
                {
                    itemNumber++;
                    character++;
                    itemViewModels.Add(new ItemViewModel
                    {                        
                        Icon = Char.ConvertFromUtf32(character),
                        Name = $"Item {itemNumber}",
                        Description = $"This is a {UnicodeInfo.GetName(character)?.ToLower()}"
                    });
                }
                var itemGroup = new ItemGroup(groupNumber: i, items: itemViewModels);
                Items.Add(itemGroup);
            }
        }
    }
}