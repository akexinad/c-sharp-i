using System;
using System.Collections.Generic;

namespace Section2Classes
{
    namespace Indexers
    {
        /*
         * Indexers allow instances of a class or struct to be indexed just like arrays. 
         * The indexed value can be set or retrieved without explicitly specifying a type or instance member. 
         * Indexers resemble properties except that their accessors take parameters.
         * 
         * So if your class has the semantics/behaves like a list, collection or array, you can improve
         * your code by using an indexer.
         * 
         * So instead of setting and getting your properties via getters and setters, you can use the indexer syntax.
         * 
         */

        public class HttpCookie
        {
            // A hash of name/value pairs, name is of type string, and value is of type string.
            // Remember you can either initialize it in hear, right after declaring the field, or make a constructor and initialize it in there.
            // Remember that making it readonly will prevent this field from being re-initialized by accident.
            private readonly Dictionary<string, string> _dictionary;
            // We can also add an auto-implemented property for DateTime
            public DateTime Expiry { get; set; }

            public HttpCookie()
            {
                _dictionary = new Dictionary<string, string>();
            }

            // THIS IS THE INDEXER.
            // Declarng an indexer is like declaring a property.
            // The indexer does not have a name. It uses the 'this' keyword.
            public string this[string key]
            {
                get { return _dictionary[key]; }
                set { _dictionary[key] = value; }
            }
        }
    }
}
