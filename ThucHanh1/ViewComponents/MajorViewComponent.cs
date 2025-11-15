using Microsoft.AspNetCore.Mvc;
using ThucHanh1.Data;

namespace ThucHanh1.ViewComponents
{
    public class MajorViewComponent : ViewComponent
    {
        SchoolContext db;

        public MajorViewComponent(SchoolContext _context)
        {
            db = _context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var majors = db.Majors.ToList();
            return View("RenderMajor", majors);
        }
    }
    }
