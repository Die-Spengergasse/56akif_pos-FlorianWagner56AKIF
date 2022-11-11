using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01.Model
{

    public class SmartPhoneApp : List<Post>
    {
        //public Post[string title]
        public SmartPhoneApp(string smartPhoneId) 
        {
            SmartPhoneId = smartPhoneId;
        }
        //public Post 
        public string SmartPhoneId { get; set; } = string.Empty;
        
        public new void Add(Post newPost)
        {
            if(newPost is not null)
            {
                base.Add(newPost);
                newPost.SmartPhone = this;
            }
        }

        public string  ProcessPosts()
        {
            StringBuilder concatenated = new StringBuilder();
            foreach(Post post in this)
            {
                concatenated.Append(post.Html);
            }
            return concatenated.ToString();
        }

        public int CalcRating()
        {
            int sum = 0;
            foreach (Post post in this)
            {
                sum += post.Rating;
            }
            return sum;
        }
    }
}
