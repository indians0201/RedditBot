﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedditSharp;
using System.Net;
using System.Threading;
using RedditSharp.Things;

namespace RedditBot
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Simple reddit bot that replies to comments.
            /// </summary>
            var reddit = new Reddit();
            var user = reddit.LogIn("BotKazy", "thisisapassword");
            var subreddit = reddit.GetSubreddit("/r/test");

            foreach (var post in subreddit.New.Take(25))
            {
                Console.WriteLine("THREAD : {0}", post.Title);
                if (post.Title == "Test")
                {
                    try
                    {
                        foreach (var comment in post.Comments)
                        {
                            if (comment.Body.Contains("Kazy") || comment.Body.Contains("kazy"))
                                if (comment.Author != "BotKazy")

                                {
                                    using (WebClient client = new WebClient())
                                    {
                                        comment.Reply("[Kazy is a bot](https://play.esea.net/users/727731)");

                                        Thread.Sleep(5000);
                                        //penis
                                    }
                                }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: {0}", e.Message);
                    }
                }
            }
        }
    }
}