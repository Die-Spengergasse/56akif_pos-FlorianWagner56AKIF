using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01.Model
{

    public class TextPost : Post
    {
        public TextPost(string title, DateTime created) : base(title, created)
        {
            
        }

        public TextPost(string title) : base(title, DateTime.Now)
        {
    
        }

        public string? Content { get; set; } = null;
        public int Length
        {
            get { return Content?.Length ?? 0; }
        }
        public override string Html
        {
            get
            {
                if (Content == null)
                {
                    throw new ArgumentNullException("Content war NULL!");
                }
                return $"<h1>{Title}</h1><p>{Content}</p>";
            }
        }


    }
}