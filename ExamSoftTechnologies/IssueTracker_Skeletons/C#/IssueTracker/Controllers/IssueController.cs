namespace IssueTracker.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using IssueTracker.Models;
    using System.Linq;

    public class IssueController : Controller
    {
        private readonly IssueDbContext context;

        public IssueController(IssueDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            // TODO:
            var issue = context.Issues.ToList();
            return View(issue);
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            // TODO:
            return View();
            
        }

        [HttpPost]
        [Route("create")]
        public ActionResult Create(Issue issue)
        {
            // TODO:
            this.context.Add(issue);
            this.context.SaveChanges();
            return Redirect("/");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int id)
        {
            // TODO:
            var issue = this.context.Issues.Find(id);
            return View(issue);

        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int id, Issue issueModel)
        {
            // TODO:
            this.context.Update(issueModel);
            this.context.SaveChanges();
            return Redirect("/");

        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            // TODO:
            var issue = this.context.Issues.Find(id);
            return View(issue);
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id, Issue issueModel)
        {
            // TODO:
            this.context.Remove(issueModel);
            this.context.SaveChanges();
            return Redirect("/");
        }
    }
}
