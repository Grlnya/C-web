using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;
using System.Security.Principal;


namespace WebApplication5.Controllers
{
    public class UserLoginController : Controller
    {

        public List<Userr> users = new List<Userr>()
            {
                new Userr("leo", "123pas", "LEONID", "11.11.2010"),
                new Userr("dio", "66%2s", "some text inside", "11.11.2010"),
                new Userr("vano", "neverland", "unreal tournament", "11.11.2010"),
                new Userr("sam", "somepassword", "corporation1", "11.11.2010"),
                new Userr("jadi", "starwars", "Skywalker", "11.11.2010")

            };
        public void adduser(string login, string password, string FullName, string birthdate)
        {
            users.Add(new Userr(login, password, FullName, birthdate));
        }
                
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Registration(string login, string password,string FullName, string birthdate)
        {
            adduser(login, password, FullName, birthdate);
            return RedirectToAction("Login", "UserLogin");
        }
        public ActionResult AutorizatonPage()
        {
            return View(users);
        }
        public ActionResult Error()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(string login, string password)
        {
            
            //string authData = $"Login: {login}   Password: {password}";
            //return Content(authData);
            int j = users.Count;
            bool f=false;
            for (int i = 0; i <j; i ++)
            {
                if (login == users[i].login && password == users[i].password) ViewBag.flag = true;
            }
            if (ViewBag.flag) return RedirectToAction("AutorizatonPage", "UserLogin");
            else return RedirectToAction("Error", "UserLogin");
        }
    }
}