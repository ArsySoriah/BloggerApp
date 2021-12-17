﻿using System;
using System.Collections.Generic;
using Application.Dto;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IPostService
    {
        IEnumerable<PostDto> GetAllPosts();
        PostDto GetPostById(int id);
    }
}