using SandBox.DO.dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SandBox.BLL;
using Presentation.ViewModels;

namespace Presentation.Controllers
{
    
    public class UserController : Controller
    {
        public ActionResult Create()
        {
            UserVM newUser = new UserVM();
            return View(newUser);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserVM user)
        {
            if(!ModelState.IsValid)
                return View(user);

            UserDO newUser = UserBLL.Create(user.GetDataObject());
            return RedirectToAction("Details", "User", new { id = newUser.UserId });
        }



        public ActionResult Delete(int Id)
        {
            UserDO user = UserBLL.GetUser(Id);
            return View(user);
        }

        [HttpPost]
        public ActionResult Delete(UserDO user)
        {
            UserBLL.Delete(user);
            return RedirectToAction("Index");
        }
        


        public ActionResult Details(int Id)
        {
            UserDO user = UserBLL.GetUser(Id);
            return View(user);
        }




        public ActionResult Edit(int Id)
        {
            UserDO userDo = UserBLL.GetUser(Id);
            UserVM user = new UserVM(userDo);
            return View(user);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserVM user)
        {
            if (!ModelState.IsValid)
                return View(user);

            UserBLL.Update(user.GetDataObject());
            return RedirectToAction("Details", "User", new { id = user.UserId });
        }

        
        public ActionResult Index()
        {
            List<UserDO> users = UserBLL.GetAll();
            return View(users);
        }

    }
}
