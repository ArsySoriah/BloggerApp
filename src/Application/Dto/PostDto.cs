﻿using System;
namespace Application.Dto
{
    public class PostDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public PostDto()
        {
        }
    }
}