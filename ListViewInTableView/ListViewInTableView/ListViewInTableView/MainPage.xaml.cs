using Syncfusion.DataSource;
using Syncfusion.ListView.XForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SfListViewSample
{
    public partial class MainPage : ContentPage
    {
        ContactsViewModel viewmodel;
        #region Constructor
        public MainPage()
        {
            InitializeComponent();

            listView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
            {
                PropertyName = "ContactName",
                KeySelector = (object obj1) =>
                {
                    var item = (obj1 as Contacts);
                    return item.ContactName[0].ToString();
                },
            });
            viewmodel = new ContactsViewModel();
            listView.BindingContext = viewmodel;
        }
        
        #endregion
    }
   
}
