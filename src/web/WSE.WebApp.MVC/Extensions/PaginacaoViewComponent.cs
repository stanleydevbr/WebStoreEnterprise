using Microsoft.AspNetCore.Mvc;
using WSE.WebApp.MVC.Models;

namespace WSE.WebApp.MVC.Extensions
{
    public class PaginacaoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IPagedList modeloPaginado)
        {
            return View(modeloPaginado);
        }
    }
}
