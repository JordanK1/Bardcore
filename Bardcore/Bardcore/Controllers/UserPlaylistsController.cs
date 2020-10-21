using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Bardcore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Bardcore.Controllers
{
    public class UserPlaylistsController : Controller
    {
        private readonly BardcoreContext _context;
        private readonly IHostingEnvironment _webroot;

        public UserPlaylistsController(BardcoreContext context, IHostingEnvironment webroot)
        {
            _context = context;
            _webroot = webroot;
        }

        // GET: UserPlaylists
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserPlaylist.ToListAsync());
        }

        // GET: UserPlaylists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userPlaylist = await _context.UserPlaylist
                .FirstOrDefaultAsync(m => m.PlaylistId == id);
            if (userPlaylist == null)
            {
                return NotFound();
            }

            return View(userPlaylist);
        }

        // GET: UserPlaylists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserPlaylists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PlaylistId,PlaylistCreator,PlaylistName")] UserPlaylist userPlaylist)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userPlaylist);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userPlaylist);
        }

        // GET: UserPlaylists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userPlaylist = await _context.UserPlaylist.FindAsync(id);
            if (userPlaylist == null)
            {
                return NotFound();
            }
            return View(userPlaylist);
        }

        // POST: UserPlaylists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PlaylistId,PlaylistCreator,PlaylistName")] UserPlaylist userPlaylist)
        {
            if (id != userPlaylist.PlaylistId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userPlaylist);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserPlaylistExists(userPlaylist.PlaylistId))
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
            return View(userPlaylist);
        }

        // GET: UserPlaylists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userPlaylist = await _context.UserPlaylist
                .FirstOrDefaultAsync(m => m.PlaylistId == id);
            if (userPlaylist == null)
            {
                return NotFound();
            }

            return View(userPlaylist);
        }

        // POST: UserPlaylists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userPlaylist = await _context.UserPlaylist.FindAsync(id);
            _context.UserPlaylist.Remove(userPlaylist);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserPlaylistExists(int id)
        {
            return _context.UserPlaylist.Any(e => e.PlaylistId == id);
        }
    }
}
