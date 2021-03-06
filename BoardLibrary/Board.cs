﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//SINGLETON BOARD CLASS TO HANDLE THE DATA
namespace BoardLibrary
{
    public class Board
    {
        private IUserService userService;
        private IPostService postService;

        public Board(IUserService userService, IPostService postService)
        {
            this.userService = userService;
            this.postService = postService;
        }

        //USER METHODS
        public User AddUser(User user)
        {
            return userService.AddUser(user);
        }

        public IEnumerable<User> GetUsers()
        {
            return userService.GetUsers();
        }

        public bool LoginUser(string email, string password)
        {
            return userService.LoginUser(email, password);
        }

        public User GetLoggedUser()
        {
            return userService.GetLoggedUser();
        }
        
        //POST METHODS
        public Post AddPost(Post post)
        {
            return postService.AddPost(post);
        }

        public List<Post> GetPostList()
        {
            return postService.GetPostList();
        }
    }
}
