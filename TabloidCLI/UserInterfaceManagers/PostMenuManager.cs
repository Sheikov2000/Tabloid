﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using TabloidCLI.Repositories;

namespace TabloidCLI.UserInterfaceManagers
{
    internal class PostMenuManager : IUserInterfaceManager 
    {
        private IUserInterfaceManager _parentUI;
        private PostRepository _postRepository;
    

    public PostMenuManager(IUserInterfaceManager parentUI, string conncectionString)
    {
        _parentUI = parentUI;
        _postRepository = new PostRepository(conncectionString);
    }

        public IUserInterfaceManager Execute()
        {
            Console.WriteLine("Post Menu");
            Console.WriteLine(" 1)List Post");
            Console.WriteLine(" 2)Add Post");
            Console.WriteLine(" 3)Edit Post");
            Console.WriteLine(" 4)Remove Post");
            Console.WriteLine(" 5)Note Management");
            Console.WriteLine(" 0)Return to Main Menu");

            Console.WriteLine(">");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    return this;
                case "2":
                    return this;
                case "3":
                    return this;
                case "4":
                    return this;
                case "5":
                    return this;
                case "0":
                    return this;
                default:
                    Console.WriteLine("Invalid Selection");
                    return this;
            }

        }
    }
}