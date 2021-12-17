﻿using System;
using System.Collections.Generic;
using System.Linq;
using Application.Dto;
using Application.Interfaces;
using AutoMapper;
using Domain.Interfaces;

namespace Application.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public PostService(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public IEnumerable<PostDto> GetAllPosts()
        {
            var posts = _postRepository.GetAll();
            //return posts.Select(posts => new PostDto
            //{
            //Id = posts.Id,
            //Title = posts.Title,
            //Content = posts.Content
            //});
            return _mapper.Map<IEnumerable<PostDto>>(posts);
        }

            public PostDto GetPostById(int id)
        {
            var post = _postRepository.GetById(id);
            //return new PostDto()
            //{
            //    Id = post.Id,
            //    Title = post.Title,
            //    Content = post.Content
            //};
            return _mapper.Map<PostDto>(post);
        }
    }
}