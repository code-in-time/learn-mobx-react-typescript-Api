using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Note
    {
        public string msg { get; set; }
        public string ID { get; set; }
        public string date { get; set; }
    }

    public class NotesList
    {
        public List<Note> NotesL { get; set; }
    }
}

//export interface Inotes
//{
//    msg: string,
//    ID: number,
//    date: string,
//}
