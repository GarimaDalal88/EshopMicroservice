using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Shopping.Web.Pages
{
    public class ConfirmationModel : PageModel
    {
        public string Message { get; set; } = default!;
        public void OnGetContact()
        {
            Message = "Your Email was Sent.";
        }

        public void OnGetOrderSubmitted()
        {
            Message = "Your Order submitted successfully";
        }

    }
}
