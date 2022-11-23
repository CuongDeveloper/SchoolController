using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolController.Models;

namespace SchoolController.Controllers
{
    public class PhuHuynhController : Controller
    {
        private readonly SchoolContext _context;

        public PhuHuynhController(SchoolContext context)
        {
            _context = context;
        }

        // GET: PhuHuynh
        public async Task<IActionResult> Index()
        {
            Microsoft.EntityFrameworkCore.Query.IIncludableQueryable<PhuHuynh, TaiKhoan> schoolContext = _context.PhuHuynhs.Include(p => p.TenTaiKhoanNavigation);
            return View(await schoolContext.ToListAsync());
        }

        // GET: PhuHuynh/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.PhuHuynhs == null)
            {
                return NotFound();
            }

            PhuHuynh? phuHuynh = await _context.PhuHuynhs
                .Include(p => p.TenTaiKhoanNavigation)
                .FirstOrDefaultAsync(m => m.MaPhuHuynh == id);
            return phuHuynh == null ? NotFound() : View(phuHuynh);
        }

        // GET: PhuHuynh/Create
        public IActionResult Create()
        {
            ViewData["TenTaiKhoan"] = new SelectList(_context.TaiKhoans, "TenTaiKhoan", "TenTaiKhoan");
            return View();
        }

        // POST: PhuHuynh/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaPhuHuynh,TenPhuHuynh,GioiTinh,NgaySinh,SoDienThoai,DiaChi,Hinh,TenTaiKhoan")] PhuHuynh phuHuynh)
        {
            if (ModelState.IsValid)
            {
                _ = _context.Add(phuHuynh);
                _ = await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TenTaiKhoan"] = new SelectList(_context.TaiKhoans, "TenTaiKhoan", "TenTaiKhoan", phuHuynh.TenTaiKhoan);
            return View(phuHuynh);
        }

        // GET: PhuHuynh/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.PhuHuynhs == null)
            {
                return NotFound();
            }

            PhuHuynh? phuHuynh = await _context.PhuHuynhs.FindAsync(id);
            if (phuHuynh == null)
            {
                return NotFound();
            }
            ViewData["TenTaiKhoan"] = new SelectList(_context.TaiKhoans, "TenTaiKhoan", "TenTaiKhoan", phuHuynh.TenTaiKhoan);
            return View(phuHuynh);
        }

        // POST: PhuHuynh/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaPhuHuynh,TenPhuHuynh,GioiTinh,NgaySinh,SoDienThoai,DiaChi,Hinh,TenTaiKhoan")] PhuHuynh phuHuynh)
        {
            if (id != phuHuynh.MaPhuHuynh)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _ = _context.Update(phuHuynh);
                    _ = await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhuHuynhExists(phuHuynh.MaPhuHuynh))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["TenTaiKhoan"] = new SelectList(_context.TaiKhoans, "TenTaiKhoan", "TenTaiKhoan", phuHuynh.TenTaiKhoan);
            return View(phuHuynh);
        }

        // GET: PhuHuynh/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.PhuHuynhs == null)
            {
                return NotFound();
            }

            PhuHuynh? phuHuynh = await _context.PhuHuynhs
                .Include(p => p.TenTaiKhoanNavigation)
                .FirstOrDefaultAsync(m => m.MaPhuHuynh == id);
            return phuHuynh == null ? NotFound() : View(phuHuynh);
        }

        // POST: PhuHuynh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.PhuHuynhs == null)
            {
                return Problem("Entity set 'SchoolContext.PhuHuynhs'  is null.");
            }
            PhuHuynh? phuHuynh = await _context.PhuHuynhs.FindAsync(id);
            if (phuHuynh != null)
            {
                _ = _context.PhuHuynhs.Remove(phuHuynh);
            }

            _ = await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhuHuynhExists(string id)
        {
            return _context.PhuHuynhs.Any(e => e.MaPhuHuynh == id);
        }
    }
}
