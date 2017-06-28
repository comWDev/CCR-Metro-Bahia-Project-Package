using Umbraco.Web.Mvc;
using System.Web.Mvc;
using dynamicNAV.Models;
using System.Net.Mail;

namespace dynamicNAV.Controllers
{
    public class ContactSurfaceController : SurfaceController
    {
        private const string EmailBody = "<html><body><p>De: {0} {1}</p>Email: {2}<p></p>Mensagem:<br>{3}<p></p><p></p></body></html>";
        public const string PARTIAL_VIEW_FOLDER = "~/Views/Partials/Contact/";

        public ActionResult RenderForm()
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_Contact.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                SendEmail(model);
                TempData["ContactSuccess"] = true;
                return RedirectToCurrentUmbracoPage();

            }
            return CurrentUmbracoPage();
        }

        private void SendEmail(ContactModel model)
        {
            MailMessage message = new MailMessage(model.EmailAddress, "comwdev@gmail.com") { IsBodyHtml = true, };
            message.Subject = string.Format("Inquiry from {0} {1} - {2}", model.FirstName, model.LastName, model.EmailAddress);
            message.Body = string.Format(EmailBody, model.FirstName, model.LastName, model.EmailAddress, model.Message);
            SmtpClient client = new SmtpClient("127.0.0.1", 25);
            client.Send(message);
        }
    }
}