using System;
using System.Collections.Generic;

namespace Section2Classes
{
    namespace Exercises
    {
        public class StopWatch
        {
            /*
            * Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should
            provide two methods: Start and Stop. We call the start method first, and the stop method next.
            Then we ask the stopwatch about the duration between start and stop. Duration should be a
            value in TimeSpan. Display the duration on the console.
            We should also be able to use a stopwatch multiple times. So we may start and stop it and then
            start and stop it again. Make sure the duration value each time is calculated properly.
            We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
            start time). So the class should throw an InvalidOperationException if its started twice.

            Educational tip: The aim of this exercise is to make you understand that a class should be
            always in a valid state. We use encapsulation and information hiding to achieve that. The class
            should not reveal its implementation detail. It only reveals a little bit, like a blackbox. From the
            outside, you should not be able to misuse a class because you shouldn’t be able to see the
            implementation detail.
            */

            private bool IsRunning = false;

            public DateTime StartTime { get; set; }
            public DateTime StopTime { get; set; }

            public double Duration
            {
                get
                {
                    if (IsRunning == true)
                    {
                        throw new Exception("StopWatch is still running.");
                    }
                    TimeSpan timeSpan = StopTime - StartTime;
                    return timeSpan.TotalSeconds;
                }
            }

            public void Start()
            {
                if (IsRunning == true)
                {
                    throw new Exception("StopWatch is already running.");

                }
                IsRunning = true;
                StartTime = DateTime.Now;
            }

            public void Stop()
            {
                IsRunning = false;
                StopTime = DateTime.Now;
            }
        }

        public class Post
        {
            /*
             * Design a class called Post. This class models a StackOverflow post. It should have properties
                for title, description and the date/time it was created. We should be able to up-vote or down-vote
                a post. We should also be able to see the current vote value. In the main method, create a post,
                up-vote and down-vote it a few times and then display the the current vote value.
                In this exercise, you will learn that a StackOverflow post should provide methods for up-voting
                and down-voting. You should not give the ability to set the Vote property from the outside,
                because otherwise, you may accidentally change the votes of a class to 0 or to a random
                number. And this is how we create bugs in our programs. The class should always protect its
                state and hide its implementation detail.

                Educational tip: The aim of this exercise is to help you understand that classes should
                encapsulate data AND behaviour around that data. Many developers (even those with years of
                experience) tend to create classes that are purely data containers, and other classes that are
                purely behaviour (methods) providers. This is not object-oriented programming. This is
                procedural programming. Such programs are very fragile. Making a change breaks many parts
                of the code. 
             */


            // REMEMBER THAT...
            private string _foo;
            public void SetFoo(string foo)
            {
                this._foo = foo;
            }
            public string GetFoo()
            {
                return _foo;
            }

            // IS THE SAME AS...
            public string Foo { get; set; }
            // The private field and the getters and setters are automatically implemented.


            private readonly Dictionary<string, string> _post;
            public string Title { get; set; }
            public string Description { get; set; }

            public DateTime CreatedAt { get; set; }
            public int Like { get; set; } = 0;

            public Post()
            {
                CreatedAt = DateTime.Now;
                _post = new Dictionary<string, string>();
            }

            public string this[string key]
            {
                get { return _post[key]; }
                set { _post[key] = value; }
            }

            public void AddPost(string Title, string Description)
            {
                _post.Add(Title, Description);
            }

            public void GiveLike()
            {
                Like++;
                this["Likes"] = $"This post has { Like } likes.";
            }

            public void DisLike()
            {
                if (Like == 0)
                {
                    Like = 0;
                }
                else
                {
                    Like--;
                }
            }

            public string Likes()
            {
                return this["Likes"] = $"This post has { Like } likes.";
            }

            public string Details()
            {

                return $"Created: { CreatedAt.ToShortDateString() }\nTitle: { Title }\nDescription: { Description }\nLikes: { this.Like }";
            }

            public string Test()
            {
                var values = _post.Values;
                return values.ToString();
            }

        }
    }
}
