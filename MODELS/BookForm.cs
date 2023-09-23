﻿using Microsoft.AspNetCore.Http;

namespace $safeprojectname$.Models

{
    public class BookForm
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public IFormFile Image { get; set; }

        public IFormFile File { get; set; }


        public int GenreId { get; set; }

    }
}
