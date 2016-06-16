using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;
using WebApplication.Models.CrystalDataSetTableAdapters;
using System.ComponentModel;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;
using System.Data;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        CrystalReportEntities entity = new CrystalReportEntities();
        ProductTableAdapter adapter = new ProductTableAdapter();

        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View(entity.Products.ToList());
        }

        public ActionResult Export()
        {
            try
            {
                ReportDocument rd = new ReportDocument();
                rd.Load(Path.Combine(Server.MapPath("~/Report/CrystalReport1.rpt")));
                rd.SetDataSource((DataTable)adapter.GetAllData());
                Response.Buffer = false;
                Response.ClearContent();
                Response.ClearHeaders();
                Stream str = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                str.Seek(0, SeekOrigin.Begin);
                return File(str, "application/pdf", "Report.pdf");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

    }
}
