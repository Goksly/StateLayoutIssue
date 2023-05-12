using CommunityToolkit.Mvvm.ComponentModel;
using StateLayoutIssue.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StateLayoutIssue.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public partial class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;

        [ObservableProperty]
        private string _text;

        [ObservableProperty]
        private string _description;
        public string Id { get; set; }      

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Text = item.Text;
                Description = item.Description;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
