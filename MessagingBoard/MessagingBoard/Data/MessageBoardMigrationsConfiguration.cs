using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;

namespace MessagingBoard.Data
{
    public class MessageBoardMigrationsConfiguration
        : DbMigrationsConfiguration<MessagingBoardContext>
    {
        public MessageBoardMigrationsConfiguration()
        {
            this.AutomaticMigrationDataLossAllowed = true;
            this.AutomaticMigrationsEnabled = true;
        }
        protected override void Seed(MessagingBoardContext context)
        {
            base.Seed(context);

#if DEBUG
            if (context.Topiks.Count() == 0)
            {
                var topic = new Topic()
                {
                    Title = "I love MVC",
                    Created = DateTime.Now,
                    Body = "I love ASP.NET MVC and I want everyone to know it!",
                    Replys = new List<Reply>()
                {
                new Reply()
                {
                    Body = "I love it Too!",
                    Created = DateTime.Now
                },
                new Reply()
                {
                    Body = "Me Too",
                    Created= DateTime.Now
                },
                new Reply()
                {
                    Body = "Aw Shucks",
                    Created = DateTime.Now
                },
            }
                };
                context.Topiks.Add(topic);

                var anotherTopic = new Topic()
                {
                    Title = "I like Ruby too!",
                    Created = DateTime.Now,
                    Body = "Ruby on Rails is popular"
                };

                context.Topiks.Add(anotherTopic);

                try
                {
                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    var msg = ex.Message;
                }
#endif
            }
        }
    }
}