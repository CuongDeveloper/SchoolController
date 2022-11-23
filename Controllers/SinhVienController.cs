using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolController.Models;

namespace SchoolController.Controllers
{
    public class SinhVienController : Controller
    {
        private readonly SchoolContext _context;

        public SinhVienController(SchoolContext context)
        {
            _context = context;
        }

        // GET: SinhVien
        public async Task<IActionResult> Index()
        {
            Microsoft.EntityFrameworkCore.Query.IIncludableQueryable<SinhVien, TaiKhoan> schoolContext = _context.SinhViens.Include(s => s.MaChuyenNganhNavigation).Include(s => s.MaPhuHuynhNavigation).Include(s => s.TenTaiKhoanNavigation);
            return View(await schoolContext.ToListAsync());
        }

        // GET: SinhVien/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.SinhViens == null)
            {
                return NotFound();
            }

            SinhVien? sinhVien = await _context.SinhViens
                .Include(s => s.MaChuyenNganhNavigation)
                .Include(s => s.MaPhuHuynhNavigation)
                .Include(s => s.TenTaiKhoanNavigation)
                .FirstOrDefaultAsync(m => m.MaSinhVien == id);
            return sinhVien == null ? NotFound() : View(sinhVien);
        }

        // GET: SinhVien/Create
        public IActionResult Create()
        {
            ViewData["MaChuyenNganh"] = new SelectList(_context.ChuyenNganhs, "MaChuyenNganh", "MaChuyenNganh");
            ViewData["MaPhuHuynh"] = new SelectList(_context.PhuHuynhs, "MaPhuHuynh", "MaPhuHuynh");
            ViewData["TenTaiKhoan"] = new SelectList(_context.TaiKhoans, "TenTaiKhoan", "TenTaiKhoan");
            return View();
        }

        // POST: SinhVien/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaSinhVien,TenSinhVien,GioiTinh,NgaySinh,SoDienThoai,DiaChi,Hinh,TenTaiKhoan,MaPhuHuynh,MaChuyenNganh")] SinhVien sinhVien)
        {
            if (ModelState.IsValid)
            {
                _ = _context.Add(sinhVien);
                _ = await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaChuyenNganh"] = new SelectList(_context.ChuyenNganhs, "MaChuyenNganh", "MaChuyenNganh", sinhVien.MaChuyenNganh);
            ViewData["MaPhuHuynh"] = new SelectList(_context.PhuHuynhs, "MaPhuHuynh", "MaPhuHuynh", sinhVien.MaPhuHuynh);
            ViewData["TenTaiKhoan"] = new SelectList(_context.TaiKhoans, "TenTaiKhoan", "TenTaiKhoan", sinhVien.TenTaiKhoan);
            return View(sinhVien);
        }

        // GET: SinhVien/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.SinhViens == null)
            {
                return NotFound();
            }

            SinhVien? sinhVien = await _context.SinhViens.FindAsync(id);
            if (sinhVien == null)
            {
                return NotFound();
            }
            ViewData["MaChuyenNganh"] = new SelectList(_context.ChuyenNganhs, "MaChuyenNganh", "MaChuyenNganh", sinhVien.MaChuyenNganh);
            ViewData["MaPhuHuynh"] = new SelectList(_context.PhuHuynhs, "MaPhuHuynh", "MaPhuHuynh", sinhVien.MaPhuHuynh);
            ViewData["TenTaiKhoan"] = new SelectList(_context.TaiKhoans, "TenTaiKhoan", "TenTaiKhoan", sinhVien.TenTaiKhoan);
            return View(sinhVien);
        }

        // POST: SinhVien/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaSinhVien,TenSinhVien,GioiTinh,NgaySinh,SoDienThoai,DiaChi,Hinh,TenTaiKhoan,MaPhuHuynh,MaChuyenNganh")] SinhVien sinhVien)
        {
            if (id != sinhVien.MaSinhVien)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _ = _context.Update(sinhVien);
                    _ = await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SinhVienExists(sinhVien.MaSinhVien))
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
            ViewData["MaChuyenNganh"] = new SelectList(_context.ChuyenNganhs, "MaChuyenNganh", "MaChuyenNganh", sinhVien.MaChuyenNganh);
            ViewData["MaPhuHuynh"] = new SelectList(_context.PhuHuynhs, "MaPhuHuynh", "MaPhuHuynh", sinhVien.MaPhuHuynh);
            ViewData["TenTaiKhoan"] = new SelectList(_context.TaiKhoans, "TenTaiKhoan", "TenTaiKhoan", sinhVien.TenTaiKhoan);
            return View(sinhVien);
        }

        // GET: SinhVien/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.SinhViens == null)
            {
                return NotFound();
            }

            SinhVien? sinhVien = await _context.SinhViens
                .Include(s => s.MaChuyenNganhNavigation)
                .Include(s => s.MaPhuHuynhNavigation)
                .Include(s => s.TenTaiKhoanNavigation)
                .FirstOrDefaultAsync(m => m.MaSinhVien == id);
            return sinhVien == null ? NotFound() : View(sinhVien);
        }

        // POST: SinhVien/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.SinhViens == null)
            {
                return Problem("Entity set 'SchoolContext.SinhViens'  is null.");
            }
            SinhVien? sinhVien = await _context.SinhViens.FindAsync(id);
            if (sinhVien != null)
            {
                _ = _context.SinhViens.Remove(sinhVien);
            }

            _ = await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SinhVienExists(string id)
        {
            return _context.SinhViens.Any(e => e.MaSinhVien == id);
        }
    }
}
