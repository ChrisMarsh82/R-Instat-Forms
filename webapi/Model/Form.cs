﻿namespace webapi.Model
{
    public class Form
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        // public IEnumerable<Control>? Controls { get; set; }
        public List<Control>? Controls { get; set; }
    }
}
