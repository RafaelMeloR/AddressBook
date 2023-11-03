using AddressBook_quiz2.Models;
using AddressBookDB.Interface;
using AddressBookDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AddressBook_quiz2.Controllers
{
    public class HomeController : Controller
    {
        IAddressBookRepository _Repo;
        ModelMapping _ModelMaping;

        public HomeController(IAddressBookRepository Repo, ModelMapping ModelMapping)
        {
            _Repo = Repo;
            _ModelMaping = ModelMapping;
        }

        public ActionResult Index()
        {
            SelectLists ddlFilter = new SelectLists();
            ddlFilter.AddressBookList = new SelectList((from a in _Repo.GetAddressBooks()
                                                        select new
                                                        {
                                                            Value = a.Id,
                                                            Text = a.Name.Trim() + " " + a.LastName.Trim()
                                                        }).Distinct(), "Value", "Text");
            return View(ddlFilter);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult GetAddressBook(int pageIndex, int pageSize, string sortField = "Id", string sortOrder = "desc")
        {
            SelectLists ddlFilter = new SelectLists();
            IEnumerable<AddressBookDB.AddressBook> AddressList = null;
            IQueryable<AddressBookDB.AddressBook> Query = null;
            IEnumerable<AddressBookDB.Model.AddressBooks> ResultList = null;

            int itemsCount = 0;
            var param = sortField;
            var propertyInfo = typeof(AddressBookDB.AddressBook).GetProperty(param);
            int skip = (pageIndex - 1) * pageSize;

            try
            {
                using (_Repo)
                {

                    Query = _Repo.GetAddressBooks();
                    itemsCount = Query.Count();

                    switch (sortField)
                    {
                        case  "Name":
                            if (sortOrder == "asc")
                            {
                                AddressList = Query.OrderBy(S => S.Name);
                            }
                            else if (sortOrder == "desc")
                            {
                                AddressList = Query.OrderByDescending(S => S.Name);
                            }
                            break;
                        case "LastName":
                            if (sortOrder == "asc")
                            {
                                AddressList = Query.OrderBy(S => S.LastName);
                            }
                            else if (sortOrder == "desc")
                            {
                                AddressList = Query.OrderByDescending(S => S.LastName);
                            }
                            break;

                        default:
                            AddressList = Query.OrderByDescending(S => S.Id);
                            break;
                    }
                    // CommentsList = Query.OrderByDescending(S => S.CommentDate);

                    ResultList = AddressList.Skip(skip)
                           .Take(pageSize).ToList().ToList()
                           .Select(T => _ModelMaping.LoadAddressBook(T));

                    var res = AddressList.GroupBy(x => x.Id).Select(y => y.First());
                }
            }
            catch (Exception ex)
            {
                //
            }
            var Result = new { data = ResultList, itemsCount = itemsCount };
            if (Result == null)
            {
                //
            }
            return Json(Result, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetAddressBookStudent(int pageIndex, int pageSize, string sortField = "Id", string sortOrder = "desc")
        {
            SelectLists ddlFilter = new SelectLists();
            IEnumerable<AddressBookDB.AddressBook> AddressList = null;
            IQueryable<AddressBookDB.AddressBook> Query = null;
            IEnumerable<AddressBookDB.Model.AddressBooks> ResultList = null;

            int itemsCount = 0;
            var param = sortField;
            var propertyInfo = typeof(AddressBookDB.AddressBook).GetProperty(param);
            int skip = (pageIndex - 1) * pageSize;

            try
            {
                using (_Repo)
                {

                    Query = _Repo.GetAddressBooks();
                    itemsCount = Query.Count();

                    switch (sortField)
                    {
                        case "Name":
                            if (sortOrder == "asc")
                            {
                                AddressList = Query.OrderBy(S => S.Name);
                            }
                            else if (sortOrder == "desc")
                            {
                                AddressList = Query.OrderByDescending(S => S.Name);
                            }
                            break;
                        case "LastName":
                            if (sortOrder == "asc")
                            {
                                AddressList = Query.OrderBy(S => S.LastName);
                            }
                            else if (sortOrder == "desc")
                            {
                                AddressList = Query.OrderByDescending(S => S.LastName);
                            }
                            break;

                        default:
                            AddressList = Query.OrderByDescending(S => S.Id);
                            break;
                    }
                    // CommentsList = Query.OrderByDescending(S => S.CommentDate);

                    ResultList = AddressList.Skip(skip)
                           .Take(pageSize).ToList().ToList()
                           .Select(T => _ModelMaping.LoadAddressBookStudent(T));

                    var res = AddressList.GroupBy(x => x.Id).Select(y => y.First());
                }
            }
            catch (Exception ex)
            {
                //
            }
            var Result = new { data = ResultList, itemsCount = itemsCount };
            if (Result == null)
            {
                //
            }
            return Json(Result, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult GetAddressBookTeacher(int pageIndex, int pageSize, string sortField = "Id", string sortOrder = "desc")
        {
            SelectLists ddlFilter = new SelectLists();
            IEnumerable<AddressBookDB.AddressBook> AddressList = null;
            IQueryable<AddressBookDB.AddressBook> Query = null;
            IEnumerable<AddressBookDB.Model.AddressBooks> ResultList = null;

            int itemsCount = 0;
            var param = sortField;
            var propertyInfo = typeof(AddressBookDB.AddressBook).GetProperty(param);
            int skip = (pageIndex - 1) * pageSize;

            try
            {
                using (_Repo)
                {

                    Query = _Repo.GetAddressBooks();
                    itemsCount = Query.Count();

                    switch (sortField)
                    {
                        case "Name":
                            if (sortOrder == "asc")
                            {
                                AddressList = Query.OrderBy(S => S.Name);
                            }
                            else if (sortOrder == "desc")
                            {
                                AddressList = Query.OrderByDescending(S => S.Name);
                            }
                            break;
                        case "LastName":
                            if (sortOrder == "asc")
                            {
                                AddressList = Query.OrderBy(S => S.LastName);
                            }
                            else if (sortOrder == "desc")
                            {
                                AddressList = Query.OrderByDescending(S => S.LastName);
                            }
                            break;

                        default:
                            AddressList = Query.OrderByDescending(S => S.Id);
                            break;
                    }
                    // CommentsList = Query.OrderByDescending(S => S.CommentDate);

                    ResultList = AddressList.Skip(skip)
                           .Take(pageSize).ToList().ToList()
                           .Select(T => _ModelMaping.LoadAddressBookTeacher(T));

                    var res = AddressList.GroupBy(x => x.Id).Select(y => y.First());
                }
            }
            catch (Exception ex)
            {
                //
            }
            var Result = new { data = ResultList, itemsCount = itemsCount };
            if (Result == null)
            {
                //
            }
            return Json(Result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult AddAddressBook(AddressBooks addressBooks)
        {
            Console.WriteLine("entro");
            if (ModelState.IsValid)
            {
                _Repo.AddAddressBook(addressBooks.Name, addressBooks.LastName, addressBooks.Address, addressBooks.TypeUser);
            }
            else
            {
                return Json(new { message = "ERROR" });
            }

            return Json(new { message = "Form submitted successfully" });
        }
    }
}