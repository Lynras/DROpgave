using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace ClassLibraryMusik
{
    public class MusikModel
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public int YearOfPublication { get; set; }
        public string Genre { get; set; }

        [Key]
        public int Id { get; set; }

        public MusikModel()
        {

        }

        public MusikModel(string title, string artist, int duration, int yearOfPublication, string genre, int id)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            YearOfPublication = yearOfPublication;
            Genre = genre;
            Id = id;
        }


        public override string ToString()
        {
            return $"Title: {Title}, Artist: {Artist}, Duration: {Duration}, YearOfPublication: {YearOfPublication}, Genre: {Genre}, Id: {Id}";
        }
    }
}
