using Thực_hành_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Thực_hành_1.ViewComponents
{
    public class RenderViewComponent:ViewComponent
    {
        private List<MenuItem> MenuItems = new List<MenuItem>();
        public RenderViewComponent() 
        {
            MenuItems.Add(new MenuItem() { Id = 1, Name = "Branches", Link = "Branches/List" });
            MenuItems.Add(new MenuItem() { Id = 2, Name = "Students", Link = "Students/List" });
            MenuItems.Add(new MenuItem() { Id = 3, Name = "Subjects", Link = "Subjects/List" });
            MenuItems.Add(new MenuItem() { Id = 4, Name = "Courses", Link = "Courses/List" });
        }
        public async Task<ViewViewComponentResult> InvokeAsync()
        {
            return View("RenderLeftMenu", MenuItems);
        }
    }
}
