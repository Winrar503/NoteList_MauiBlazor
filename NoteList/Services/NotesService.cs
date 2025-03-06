using NoteList.Data;
using NoteList.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NoteList.Services
{
    public class NotesService
    {
        public readonly AppDbContext _context;

        public NotesService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Notes>> GetAllNotesAsync()
        {
            return await _context.Notes.ToListAsync();
        }

        public async Task<Notes> GetNoteByIdAsync(int id)
        {
            return await _context.Notes.FindAsync(id);
        }

        public async Task AddNoteAsync(Notes newNote)
        {
            _context.Notes.Add(newNote);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateNoteAsync(Notes updatedNote)
        {
            _context.Notes.Update(updatedNote);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteNoteAsync(int id)
        {
            var note = await _context.Notes.FindAsync(id);
            if (note != null)
            {
                _context.Notes.Remove(note);
                await _context.SaveChangesAsync();
            }
        }
    }
}
