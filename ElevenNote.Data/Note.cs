using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ElevenNote.Data
{
    public class Note
    {
        public Note()
        {
        }

        public Note(string title, string content, Guid ownerId, DateTimeOffset createdTime)
        {
            Title = title;
            Content = content;
            OwnerID = ownerId;
            CreatedUtc = createdTime;
        }

        [Key]
        public int NoteID { get; set; }

        [Required]
        public Guid OwnerID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

        [DefaultValue(false)]
        public bool IsStarred { get; set; }
    }
}