using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FizzBuzz.Pages
{
    public class FizzbuzzModel : PageModel
    {
        [BindProperty]
        public string  fbvalues { get; set; }
        public List<string> result_list { get; set; }
        public IActionResult OnPost()
        {
            if (fbvalues!= null)
            {                
                result_list = new List<string>(); ;
                List<string> txtlist = fbvalues.Split(',').ToList();
                foreach (var i in txtlist)
                {
                    Fizzbuzzmethod(i);
                }
            }
            
            return Page();
        }

        public List<string> Fizzbuzzmethod(string value)
        {
            if (int.TryParse(value, out int d))
            {
                if (d % 3 == 0 && d % 5 == 0)
                {
                    result_list.Add("FizzBuzz");
                }
                else if (d % 3 == 0)
                {
                    result_list.Add("Fizz");
                }
                else if (d % 5 == 0)
                {
                    result_list.Add("Buzz");
                }
                else
                {
                    result_list.Add("Divided " + d + " by 3");
                    result_list.Add("Divided " + d + " by 5");
                }

            }
            else
            {
                result_list.Add("Invalid Item");                
            }
            return result_list;           
        }

    }
}
