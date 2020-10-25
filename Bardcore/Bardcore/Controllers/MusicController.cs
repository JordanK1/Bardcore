using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Bardcore.Models;
using Bardcore.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Bardcore.Controllers
{
    public class MusicController : Controller
    {
        private readonly BardcoreContext _context;
        private IHostingEnvironment _webroot;

        public MusicController(BardcoreContext context, IHostingEnvironment webroot)
        {
            _context = context;
            _webroot = webroot;
        }

        // GET: Music
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.SongInfo.ToListAsync());
        }

        
        /*public static List<MusicInformationVM> PleaseWork(BardcoreContext context) //Attempt 1 at linq join statement
           {
                
                var browse = (from s in context.SongInfo
                            join art in context.Artist on s.ArtistName equals art.ArtistId
                            join g in context.Genre on s.GenreName equals g.GenreId
                            join alb in context.Album on s.AlbumName equals alb.AlbumId
                            orderby s.TrackId
                            select new
                            {
                                s.Name,
                                art.ArName,
                                g.GName,
                                alb.AlName,
                                s.Uploader,
                                s.UploadDate
                            }).ToList();
            }    */

        public List<MusicInformationVM> GetList() //Attempt 2 at linq join statement
        {
            var songs = db.SongInfo
                        .select(s => new MusicInformationVM()
                        {
                            Name = s.Name,
                            Artist = art.ArName,
                            Genre = g.GName,
                            Album = alb.AlName,
                            Uploader = s.Uploader,
                            UploadDate = s.UploadDate
                        });
            return songs.ToList<MusicInformationVM>();
        }

        [Authorize]
        public async Task<IActionResult> Browse()
        {

            return View(GetList());
            
            /*return View(await _context.SongInfo.ToListAsync());*/ //Original View return statement
            
        }

        // GET: Music/Details/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songInfo = await _context.SongInfo
                .FirstOrDefaultAsync(m => m.TrackId == id);
            if (songInfo == null)
            {
                return NotFound();
            }

            return View(songInfo);
        }

        // GET: Music/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Music/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TrackId,Name,ArtistName,GenreName,AlbumName,ReleaseYear,Uploader,UploadDate,FileLocation")] SongInfo songInfo,
                IFormFile FileMusic)
        {
            if (FileMusic.Length > 0)
            {
                string FileLocation = _webroot.WebRootPath + "\\uploads\\";
                var fileName = Path.GetFileName(FileMusic.FileName);

                using (var stream = System.IO.File.Create(FileLocation + fileName))
                {
                    await FileMusic.CopyToAsync(stream);
                    songInfo.FileLocation = fileName;
                }

            }

            if (ModelState.IsValid)
            {
                _context.Add(songInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(songInfo);
        }

        // GET: Music/Edit/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songInfo = await _context.SongInfo.FindAsync(id);
            if (songInfo == null)
            {
                return NotFound();
            }
            return View(songInfo);
        }

        // POST: Music/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TrackId,Name,ArtistName,GenreName,AlbumName,ReleaseYear,Uploader,UploadDate,FileLocation")] SongInfo songInfo)
        {
            if (id != songInfo.TrackId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(songInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SongInfoExists(songInfo.TrackId))
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
            return View(songInfo);
        }

        [Authorize]
        public async Task<IActionResult> Listen(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var FileLocation = await _context.SongInfo
                .FirstOrDefaultAsync(m => m.TrackId == id);
            if (FileLocation == null)
            {
                return NotFound();
            }

            return View(FileLocation);
        }

        // GET: Music/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var songInfo = await _context.SongInfo
                .FirstOrDefaultAsync(m => m.TrackId == id);
            if (songInfo == null)
            {
                return NotFound();
            }

            return View(songInfo);
        }

        // POST: Music/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Administrator")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var songInfo = await _context.SongInfo.FindAsync(id);
            _context.SongInfo.Remove(songInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SongInfoExists(int id)
        {
            return _context.SongInfo.Any(e => e.TrackId == id);
        }
    }
}
