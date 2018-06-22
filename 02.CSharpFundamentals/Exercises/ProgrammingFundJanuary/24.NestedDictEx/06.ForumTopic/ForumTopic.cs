using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ForumTopic
{
    class ForumTopic
    {
        static void Main(string[] args)
        {
            var forumHistogram = new Dictionary<string, HashSet<string>>();
            var currentLine = Console.ReadLine();
            while (currentLine != "filter")
            {
                var splited = currentLine.Split(new[] { " -> ", ", " }, StringSplitOptions.RemoveEmptyEntries);
                var topic = splited[0];
                var tags = splited.Skip(1).ToArray();

                if (!forumHistogram.ContainsKey(topic))
                {
                    forumHistogram[topic] = new HashSet<string>();
                }
                foreach (var pair in tags)
                {
                    forumHistogram[topic].Add(pair);
                }

                currentLine = Console.ReadLine();
            }

            var filters = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var topic in forumHistogram)
            {
                var contains = true;
                foreach (var filter in filters)
                {
                    if (!topic.Value.Contains(filter))
                    {
                        contains = false;
                    }
                }
                if (contains)
                {
                    Console.WriteLine($"{topic.Key} | #{string.Join(", #", topic.Value)}");
                }
            }
        }
    }
}
