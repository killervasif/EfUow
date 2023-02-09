﻿namespace EfUow.Models
{
    public class S_Card : BaseEntity
    {
        public int Id_Student { get; set; }
        public int Id_Book { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime? DateIn { get; set; }
        public int Id_Lib { get; set; }

        public Student? Student { get; set; }
        public Book? Book { get; set; }
        public Lib? Lib { get; set; }
    }
}
