using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolController.Models;

namespace SchoolController.Controllers
{
    public class GiangVienController : Controller
    {
        private readonly SchoolContext _context;

        public GiangVienController(SchoolContext context)
        {
            _context = context;
        }

        // GET: GiangVien
        public async Task<IActionResult> Index()
        {
            Microsoft.EntityFrameworkCore.Query.IIncludableQueryable<GiangVien, TaiKhoan> schoolContext = _context.GiangViens.Include(g => g.TenTaiKhoanNavigation);
            return View(await schoolContext.ToListAsync());
        }

        // GET: GiangVien/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.GiangViens == null)
            {
                return NotFound();
            }

            GiangVien? giangVien = await _context.GiangViens
                .Include(g => g.TenTaiKhoanNavigation)
                .FirstOrDefaultAsync(m => m.MaGiangVien == id);
            return giangVien == null ? NotFound() : View(giangVien);
        }

        // GET: GiangVien/Create
        public IActionResult Create()
        {
            ViewData["TenTaiKhoan"] = new SelectList(_context.TaiKhoans, "TenTaiKhoan", "TenTaiKhoan");
            return View();
        }

        // POST: GiangVien/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaGiangVien,TenGiangVien,GioiTinh,NgaySinh,SoDienThoai,DiaChi,Hinh,TenTaiKhoan")] GiangVien giangVien)
        {
            if (ModelState.IsValid)
            {
                _ = _context.Add(giangVien);
                _ = await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TenTaiKhoan"] = new SelectList(_context.TaiKhoans, "TenTaiKhoan", "TenTaiKhoan", giangVien.TenTaiKhoan);
            return View(giangVien);
        }

        // GET: GiangVien/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.GiangViens == null)
            {
                return NotFound();
            }

            GiangVien? giangVien = await _context.GiangViens.FindAsync(id);
            if (giangVien == null)
            {
                return NotFound();
            }
            ViewData["TenTaiKhoan"] = new SelectList(_context.TaiKhoans, "TenTaiKhoan", "TenTaiKhoan", giangVien.TenTaiKhoan);
            return View(giangVien);
        }

        // POST: GiangVien/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaGiangVien,TenGiangVien,GioiTinh,NgaySinh,SoDienThoai,DiaChi,Hinh,TenTaiKhoan")] GiangVien giangVien)
        {
            if (id != giangVien.MaGiangVien)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _ = _context.Update(giangVien);
                    _ = await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GiangVienExists(giangVien.MaGiangVien))
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
            ViewData["TenTaiKhoan"] = new SelectList(_context.TaiKhoans, "TenTaiKhoan", "TenTaiKhoan", giangVien.TenTaiKhoan);
            return View(giangVien);
        }

        // GET: GiangVien/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.GiangViens == null)
            {
                return NotFound();
            }

            GiangVien? giangVien = await _context.GiangViens
                .Include(g => g.TenTaiKhoanNavigation)
                .FirstOrDefaultAsync(m => m.MaGiangVien == id);
            return giangVien == null ? NotFound() : View(giangVien);
        }

        // POST: GiangVien/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.GiangViens == null)
            {
                return Problem("Entity set 'SchoolContext.GiangViens'  is null.");
            }
            GiangVien? giangVien = await _context.GiangViens.FindAsync(id);
            if (giangVien != null)
            {
                _ = _context.GiangViens.Remove(giangVien);
            }

            _ = await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GiangVienExists(string id)
        {
            return _context.GiangViens.Any(e => e.MaGiangVien == id);
        }
    }
}
