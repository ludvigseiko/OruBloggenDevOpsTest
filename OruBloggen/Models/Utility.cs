using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.AspNet.Identity;

namespace OruBloggen.Models
{

public class AuthorizeUserAttribute : AuthorizeAttribute
    {

        protected override bool AuthorizeCore(HttpContextBase context)
        {
            var userId = context.User.Identity.GetUserId();
            if (userId != null || userId != " ")
            {
                var ctx = new OruBloggenDbContext();
                try { 
                    var userIsActivated = ctx.Users.FirstOrDefault(u => u.UserID == userId).UserActive;
                    return userIsActivated;
                } catch(Exception e)
                {
                    return true;
                }
                
            }
            return true;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {

            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {

                filterContext.Result = new RedirectToRouteResult(
                            new RouteValueDictionary(
                                new
                                {
                                    controller = "Home",
                                    action = "Unauthorised"
                                })
                            );
            }
            else
            {
                base.HandleUnauthorizedRequest(filterContext);
            }
        }
    }
    public static class Utility
    {



        public static bool isAdmin(string userId)
        {
            var ctx = new OruBloggenDbContext();

            return ctx.Users.FirstOrDefault(u => u.UserID == userId).UserIsAdmin;
        }

        public static string getCategoryById(int categoryId)
        {
            var ctx = new OruBloggenDbContext();
            return ctx.Categories.FirstOrDefault(u => u.CategoryID == categoryId).CategoryName;
        }

        public static List<SelectListItem> getSearchedUsers(string searchString)
        {
            var ctx = new OruBloggenDbContext();

            var userList = ctx.Users.Where(u => String.Concat(u.UserFirstname, " ", u.UserLastname)
                                     .Contains(searchString) ||
                                     searchString == null).ToList();

            var users = new List<SelectListItem>();
            foreach (var item in userList)
            {
                users.Add(new SelectListItem
                {
                    Text = item.UserFirstname + " " + item.UserLastname,
                    Value = item.UserID
                });
            }

            return users;
        }

        public static bool IsActivated(string userId)
        {
            if(userId != null || userId != " ")
            {
                var ctx = new OruBloggenDbContext();
                var userIsActivated = ctx.Users.FirstOrDefault(u => u.UserID == userId).UserActive;
                return userIsActivated;
            }
            return true;

        }

        public static void TeamsInitializer()
        {
            var ctx = new OruBloggenDbContext();
            if(!ctx.Teams.Any()) { 
            IList<TeamModel> defaultStandards = new List<TeamModel>();

            defaultStandards.Add(new TeamModel() { TeamName = "Informatik" });
            defaultStandards.Add(new TeamModel() { TeamName = "Ekonomi" });
            defaultStandards.Add(new TeamModel() { TeamName = "Psykologi" });

            ctx.Teams.AddRange(defaultStandards);
            ctx.SaveChanges();
            }

        }
    }
}