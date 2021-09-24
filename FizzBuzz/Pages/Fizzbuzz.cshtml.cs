using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FizzBuzz.Pages
{
    public class FizzbuzzModel : PageModel
    {
        [BindProperty]
        public string  fbvalues { get; set; }
        public List<string> result_list { get; set; }
        public List<string> output_list { get; set; }   

        public IActionResult OnPost()
        {
            if (fbvalues!= null)
            {                
                result_list = new List<string>(); ;
                List<string> xx = fbvalues.Split(',').ToList();
                foreach (var i in xx)
                {
                    if(int.TryParse(i, out int dividend))
                    {
                        output_list = Fizzbuzzmethod(dividend);

                    }
                    else
                    {
                        output_list.Add("Invalid Item");
                    }
                }
            }

            return Page();
        }

        public List<string> Fizzbuzzmethod(int d)
        {        
            if (d % 3 == 0 && d % 5 == 0)
            {
                result_list.Add("FizzBuzz");
                return result_list;//result = "FizzBuzz";
            }
            else if (d % 3 == 0)
            {
                result_list.Add("Fizz");
                return result_list;
            }
            else if (d % 5 == 0)
            {
                result_list.Add("Buzz");
                return result_list;
            }
            else
            {
                result_list.Add("Divided " + d + " by 3");
                result_list.Add("Divided " + d + " by 5");
                return result_list;
            }
           
        }

    }
}
