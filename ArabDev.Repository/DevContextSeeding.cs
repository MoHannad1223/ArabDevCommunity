using ArabDev.Data.Contexts;
using ArabDev.Data.DataOrEntities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ArabDev.Repository
{
   public class DevContextSeeding
    {
        public static async Task SeedAsync(ArabDevDbContext context,ILoggerFactory loggerFactory)
        {
            try
            {
                if (context.Users != null && !context.Users.Any())
                {
                    //C:\Users\DELL\Downloads\ArabDevCommunityGrad.PL\ArabDev.Repository\seeding\seeding\User.json
                    var usersdata = File.ReadAllText("../ArabDev.Repository/seeding/seeding/User.json");
                    var user=JsonSerializer.Deserialize<List<User>> (usersdata);
                    if (user is not null) 
                    {
                        await context.Users.AddRangeAsync(user);
                    }
                }
                if (context.Posts != null && !context.Posts.Any())
                {
                    //C:\Users\DELL\Downloads\ArabDevCommunityGrad.PL\ArabDev.Repository\seeding\seeding\Post.json
                    var postsdata = File.ReadAllText("../ArabDev.Repository/seeding/seeding/Post.json");
                    var post = JsonSerializer.Deserialize<List<Post>>(postsdata);
                    if (post is not null)
                    {
                        await context.Posts.AddRangeAsync(post);
                    }
                }
                if (context.Skills != null && !context.Skills.Any())
                {
                    //C:\Users\DELL\Downloads\ArabDevCommunityGrad.PL\ArabDev.Repository\seeding\seeding\Skills.json
                    var skillsdata = File.ReadAllText("../ArabDev.Repository/seeding/seeding/Skills.json");
                    var skill = JsonSerializer.Deserialize<List<Skills>>(skillsdata);
                    if (skill is not null)
                    {
                        await context.Skills.AddRangeAsync(skill);
                    }
                }
                if (context.User_Learnings != null && !context.User_Learnings.Any())
                {
                    //C:\Users\DELL\Downloads\ArabDevCommunityGrad.PL\ArabDev.Repository\seeding\seeding\User Learning.json
                    var userslearningdata = File.ReadAllText("../ArabDev.Repository/seeding/seeding/User Learning.json");
                    var userslearning = JsonSerializer.Deserialize<List<User_Learning>>(userslearningdata);
                    if (userslearning is not null)
                    {
                        await context.User_Learnings.AddRangeAsync(userslearning);
                    }
                }
                if (context.Shares != null && !context.Shares.Any())
                {
                    //C:\Users\DELL\Downloads\ArabDevCommunityGrad.PL\ArabDev.Repository\seeding\seeding\Share.json
                    var sharesdata = File.ReadAllText("../ArabDev.Repository/seeding/seeding/Share.json");
                    var share = JsonSerializer.Deserialize<List<Shares>>(sharesdata);
                    if (share is not null)
                    {
                        await context.Shares.AddRangeAsync(share);
                    }
                }
                if (context.SavedPosts != null && !context.SavedPosts.Any())
                {
               // C: \Users\DELL\Downloads\ArabDevCommunityGrad.PL\ArabDev.Repository\seeding\seeding\SavedPost.json
                var savedpostsdata = File.ReadAllText("../ArabDev.Repository/seeding/seeding/SavedPost.json");
                    var savedpost = JsonSerializer.Deserialize<List<SavedPost>>(savedpostsdata);
                    if (savedpost is not null)
                    {
                        await context.SavedPosts.AddRangeAsync(savedpost);
                    }
                }
                if (context.SavedPodcasts != null && !context.SavedPodcasts.Any())
                {
                    //C:\Users\DELL\Downloads\ArabDevCommunityGrad.PL\ArabDev.Repository\seeding\seeding\SavedPodcast.json
                    var savedpodcastdata = File.ReadAllText("../ArabDev.Repository/seeding/seeding/SavedPodcast.json");
                    var savedpodcast = JsonSerializer.Deserialize<List<SavedPodcast>>(savedpodcastdata);
                    if (savedpodcast is not null)
                    {
                        await context.SavedPodcasts.AddRangeAsync(savedpodcast);
                    }
                }
                if (context.PodCasts != null && !context.PodCasts.Any())
                {
                    //C:\Users\DELL\Downloads\ArabDevCommunityGrad.PL\ArabDev.Repository\seeding\seeding\PodCast.json
                    var podcastdata = File.ReadAllText("../ArabDev.Repository/seeding/seeding/PodCast.json");
                    var podcast = JsonSerializer.Deserialize<List<PodCast>>(podcastdata);
                    if (podcast is not null)
                    {
                        await context.PodCasts.AddRangeAsync(podcast);
                    }
                }
                if (context.Notifications != null && !context.Notifications.Any())
                {
                    //C:\Users\DELL\Downloads\ArabDevCommunityGrad.PL\ArabDev.Repository\seeding\seeding\Notification.json
                    var notificationdata = File.ReadAllText("../ArabDev.Repository/seeding/seeding/Notification.json");
                    var notification = JsonSerializer.Deserialize<List<Notification>>(notificationdata);
                    if (notification is not null)
                    {
                        await context.Notifications.AddRangeAsync(notification);
                    }
                }
                if (context.Likes != null && !context.Likes.Any())
                {
                    //C:\Users\DELL\Downloads\ArabDevCommunityGrad.PL\ArabDev.Repository\seeding\seeding\Likes.json
                    var likesdata = File.ReadAllText("../ArabDev.Repository/seeding/seeding/Likes.json");
                    var likes = JsonSerializer.Deserialize<List<Likes>>(likesdata);
                    if (likes is not null)
                    {
                        await context.Likes.AddRangeAsync(likes);
                    }
                }
                if (context.ContactSubmission != null && !context.ContactSubmission.Any())
                {
                    //C:\Users\DELL\Downloads\ArabDevCommunityGrad.PL\ArabDev.Repository\seeding\seeding\ContactSubmission.json
                    var contactsdata = File.ReadAllText("../ArabDev.Repository/seeding/seeding/ContactSubmission.json");
                    var contact = JsonSerializer.Deserialize<List<ContactSubmission>>(contactsdata);
                    if (contact is not null)
                    {
                        await context.ContactSubmission.AddRangeAsync(contact);
                    }
                }
                if (context.Comments!= null && !context.Comments.Any())
                {
                    //C:\Users\DELL\Downloads\ArabDevCommunityGrad.PL\ArabDev.Repository\seeding\seeding\Comment.json
                    var commentsdata = File.ReadAllText("../ArabDev.Repository/seeding/seeding/Comment.json");
                    var comment = JsonSerializer.Deserialize<List<Comment>>(commentsdata);
                    if (comment is not null)
                    {
                        await context.Comments.AddRangeAsync(comment);
                    }
                }
                if (context.Followers != null && !context.Followers.Any())
                {
                    //C:\Users\DELL\Downloads\ArabDevCommunityGrad.PL\ArabDev.Repository\seeding\seeding\Follower.json
                    var followerdata = File.ReadAllText("../ArabDev.Repository/seeding/seeding/Follower.json");
                    var follower = JsonSerializer.Deserialize<List<Follower>>(followerdata);
                    if (follower is not null)
                    {
                        await context.Followers.AddRangeAsync(follower);
                    }
                }
                await context.SaveChangesAsync();

            }
            catch(Exception ex)
            {
                var logger = loggerFactory.CreateLogger<ArabDevDbContext>();
                logger.LogError(ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"InnerException: {ex.InnerException.Message}");
                }
            }
            
        }
    }
}
