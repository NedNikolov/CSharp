using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SocialPosts
{
    class SocialPosts
    {
        static Dictionary<string, Dictionary<string, string>> postsComments = new Dictionary<string, Dictionary<string, string>>();
        static Dictionary<string, int> postLikes = new Dictionary<string, int>();
        static Dictionary<string, int> postDisikes = new Dictionary<string, int>();

        static void Main(string[] args)
        {            
            string input = Console.ReadLine();
            while (input != "drop the media")
            {
                string[] inputTokens = input.Split(' ');

                string command = inputTokens[0];
                string postName = inputTokens[1];

                switch (command)
                {
                    case "post":
                    {
                        CreatePost(postName);
                        break;
                    }
                    case "like":
                    {
                        LikePost(postName);
                        break;
                    }
                    case "dislike":
                    {
                        DislikePost(postName);
                        break;
                    }
                    case "comment":
                    {
                        string commentatorName = inputTokens[2];
                        string commentContent = string.Join(" ", inputTokens.Skip(3));
                        CommentPost(postName, commentatorName, commentContent);
                        break;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var postCommentData in postsComments)
            {
                string postName = postCommentData.Key;
                int likes = postLikes[postName];
                int dislikes = postDisikes[postName];
                Dictionary<string, string> commentsData = postCommentData.Value;

                Console.WriteLine("Post: {0} | Likes: {1} | Dislikes: {2}", postName, likes, dislikes);

                Console.WriteLine("Comments:");

                if (commentsData.Count == 0)
                {
                    Console.WriteLine("None");
                }
                foreach (var commentData in commentsData)
                {
                    string commentatorName = commentData.Key;
                    string commentContent = commentData.Value;

                    Console.WriteLine("*  {0}: {1}", commentatorName, commentContent);
                }

            }
        }

        static void CreatePost(string postName)
        {
            postsComments.Add(postName, new Dictionary<string, string>());
            postLikes.Add(postName, 0);
            postDisikes.Add(postName, 0);
        }

        static void LikePost(string postName)
        {
            postLikes[postName]++;
        }

        static void DislikePost(string postName)
        {
            postDisikes[postName]++;
        }

        static void CommentPost(string postName, string commentatorName, string commentContent)
        {
            postsComments[postName].Add(commentatorName, commentContent);
        }
    }
}
