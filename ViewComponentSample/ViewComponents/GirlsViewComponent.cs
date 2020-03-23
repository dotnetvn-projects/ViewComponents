using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentSample.DataSource;
using ViewComponentSample.Models;

namespace ViewComponentSample.ViewComponents
{
    [ViewComponent(Name = "Girls")]
    public class GirlsViewComponent: ViewComponent
    {
        private readonly DataProvider _dataProvider;

        public GirlsViewComponent(DataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public async Task<IViewComponentResult> InvokeAsync(int page = 1, int pageSize = 9)
        {
            var items = await GetItemsAsync(page, pageSize);
            return View(items);

           // return View("~/Views/Girls/Default.cshtml", items);
        }

        private async Task<GirlListModel> GetItemsAsync(int page = 1, int pageSize = 9)
        {
            var data = await _dataProvider.ReadSampleData();

            GirlListModel girlListModel = new GirlListModel
            {
                TotalRecord = data.GirlInfoItems.Count
            };

            data.GirlInfoItems.ForEach(x =>
            {
                girlListModel.GirlList.Add(new GirlModel
                {
                    Name = x.Name, ProfileImage = x.Image
                });
            });

            return girlListModel;
        }
    }
}
