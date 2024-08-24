using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using Microsoft.Extensions.Primitives;
using System.Reflection.Metadata;
using System.Security.Principal;

namespace CalcWeb.Pages
{
    public class ThebmiModel : PageModel
    {
        public float BMI { get; set; }
        public string weightv { get; set; }
        public string ih { get; set; }
        public string oh { get; set; }
        public float height;
        public float feet;
        public float meters;
        public float centimeters;
        public float inches;
        public float weight;
        public double iweight;
        public double iheight;
        public float doubleweight;
        public string errormsg;
        public int t;
        public string wu { get; set; }
        public string u { get; set; }
        public int o;
        public int x;
        public int y = 0;
        public int checker;
        int[] checkers = new int[1];





        public void OnPost()
        {
            foreach (string s in Request.Form.Keys)
            {
                if (s.EndsWith("unit"))
                {
                    t = 2;
                    x = 0;
                    y = 0;
                    Console.WriteLine(HttpContext.Session.GetString("wu"));
                    if (HttpContext.Session.GetString("wu") == "lbs.")
                    {
                        ViewData["wu"] = "kg.";
                        ViewData["u"] = "lbs.";
                        HttpContext.Session.SetString("wu", "kg.");
                        HttpContext.Session.SetString("u", "lbs.");
                        ViewData["hidden"] = HttpContext.Session.GetString("hidden");
                        ViewData["ih"] = HttpContext.Session.GetString("ih");
                        ViewData["oh"] = HttpContext.Session.GetString("oh");
                        ViewData["hu1"] = HttpContext.Session.GetString("hu1");
                        ViewData["hu2"] = HttpContext.Session.GetString("hu2");
                        ViewData["inputwidth"] = HttpContext.Session.GetString("inputwidth");
                        HttpContext.Session.SetString("hidden", "");
                        HttpContext.Session.SetString("ih", "ft.");
                        HttpContext.Session.SetString("oh", "in.");
                        HttpContext.Session.SetString("inputwidth", "60px");
                        HttpContext.Session.SetString("hu1", "m");
                        HttpContext.Session.SetString("hu2", "cm");
                    }
                    else
                    {
                        ViewData["wu"] = "lbs.";
                        ViewData["u"] = "kg.";
                        HttpContext.Session.SetString("wu", "lbs.");
                        HttpContext.Session.SetString("u", "kg.");
                        ViewData["hidden"] = HttpContext.Session.GetString("hidden");
                        ViewData["ih"] = HttpContext.Session.GetString("ih");
                        ViewData["oh"] = HttpContext.Session.GetString("oh");
                        ViewData["hu1"] = HttpContext.Session.GetString("hu1");
                        ViewData["hu2"] = HttpContext.Session.GetString("hu2");
                        ViewData["inputwidth"] = HttpContext.Session.GetString("inputwidth");
                    }
                }
                else if (s.EndsWith("hu1"))
                {
                    t = 2;
                    if (HttpContext.Session.GetString("hu1") == "m")
                    {
                        ViewData["hidden"] = "hidden";
                        ViewData["ih"] = "m";
                        ViewData["oh"] = "";
                        ViewData["hu1"] = "cm";
                        ViewData["hu2"] = "ft. & in.";
                        ViewData["inputwidth"] = "140px";
                        HttpContext.Session.SetString("hidden", "hidden");
                        HttpContext.Session.SetString("ih", "m");
                        HttpContext.Session.SetString("oh", "");
                        HttpContext.Session.SetString("inputwidth", "140px");
                        HttpContext.Session.SetString("hu1", "cm");
                        HttpContext.Session.SetString("hu2", "ft. & in.");
                        ViewData["wu"] = HttpContext.Session.GetString("wu");
                        ViewData["u"] = HttpContext.Session.GetString("u"); 
                    }
                    else if (HttpContext.Session.GetString("hu1") == "cm")
                    {
                        ViewData["hidden"] = "hidden";
                        ViewData["ih"] = "cm";
                        ViewData["oh"] = "";
                        ViewData["hu1"] = "ft. & in.";
                        ViewData["hu2"] = "m";
                        ViewData["inputwidth"] = "140px";
                        HttpContext.Session.SetString("hidden", "hidden");
                        HttpContext.Session.SetString("ih", "cm");
                        HttpContext.Session.SetString("oh", "");
                        HttpContext.Session.SetString("inputwidth", "140px");
                        HttpContext.Session.SetString("hu1", "ft. & in.");
                        HttpContext.Session.SetString("hu2", "m");
                        ViewData["wu"] = HttpContext.Session.GetString("wu");
                        ViewData["u"] = HttpContext.Session.GetString("u");
                    }
                    else if (HttpContext.Session.GetString("hu1") == "ft. & in.")
                    {
                        ViewData["inputwidth"] = "60px";
                        ViewData["hidden"] = "";
                        ViewData["ih"] = "ft.";
                        ViewData["oh"] = "in.";
                        ViewData["hu1"] = "m";
                        ViewData["hu2"] = "cm";
                        HttpContext.Session.SetString("hidden", "");
                        HttpContext.Session.SetString("ih", "ft.");
                        HttpContext.Session.SetString("oh", "in.");
                        HttpContext.Session.SetString("inputwidth", "60px");
                        HttpContext.Session.SetString("hu1", "m");
                        HttpContext.Session.SetString("hu2", "cm");
                        ViewData["wu"] = HttpContext.Session.GetString("wu");
                        ViewData["u"] = HttpContext.Session.GetString("u");
                    }
                }
                else if (s.EndsWith("hu2"))
                {
                    t = 2;
                    if (HttpContext.Session.GetString("hu2") == "m")
                    {
                        ViewData["hidden"] = "hidden";
                        ViewData["ih"] = "m";
                        ViewData["oh"] = "";
                        ViewData["hu1"] = "cm";
                        ViewData["hu2"] = "ft. & in.";
                        ViewData["inputwidth"] = "140px";
                        HttpContext.Session.SetString("hidden", "hidden");
                        HttpContext.Session.SetString("ih", "m");
                        HttpContext.Session.SetString("oh", "");
                        HttpContext.Session.SetString("inputwidth", "140px");
                        HttpContext.Session.SetString("hu1", "cm");
                        HttpContext.Session.SetString("hu2", "ft. & in.");
                        ViewData["wu"] = HttpContext.Session.GetString("wu");
                        ViewData["u"] = HttpContext.Session.GetString("u");
                    }
                    else if (HttpContext.Session.GetString("hu2") == "cm")
                    {
                        ViewData["hidden"] = "hidden";
                        ViewData["ih"] = "cm";
                        ViewData["oh"] = "";
                        ViewData["hu1"] = "ft. & in.";
                        ViewData["hu2"] = "m";
                        ViewData["inputwidth"] = "140px";
                        HttpContext.Session.SetString("hidden", "hidden");
                        HttpContext.Session.SetString("ih", "cm");
                        HttpContext.Session.SetString("oh", "");
                        HttpContext.Session.SetString("inputwidth", "140px");
                        HttpContext.Session.SetString("hu1", "ft. & in.");
                        HttpContext.Session.SetString("hu2", "m");
                        ViewData["wu"] = HttpContext.Session.GetString("wu");
                        ViewData["u"] = HttpContext.Session.GetString("u");
                    }
                    else if (HttpContext.Session.GetString("hu2") == "ft. & in.")
                    {
                        ViewData["inputwidth"] = "60px";
                        ViewData["hidden"] = "";
                        ViewData["ih"] = "ft.";
                        ViewData["oh"] = "in.";
                        ViewData["hu1"] = "m";
                        ViewData["hu2"] = "cm";
                        HttpContext.Session.SetString("hidden", "");
                        HttpContext.Session.SetString("ih", "ft.");
                        HttpContext.Session.SetString("oh", "in.");
                        HttpContext.Session.SetString("inputwidth", "60px");
                        HttpContext.Session.SetString("hu1", "m");
                        HttpContext.Session.SetString("hu2", "cm");
                        ViewData["wu"] = HttpContext.Session.GetString("wu");
                        ViewData["u"] = HttpContext.Session.GetString("u");
                    }
                }
            }
            if (t != 2)
            {
                t = 1;
                ViewData["wu"] = HttpContext.Session.GetString("wu");
                ViewData["u"] = HttpContext.Session.GetString("u");
                ViewData["hidden"] = HttpContext.Session.GetString("hidden");
                ViewData["ih"] = HttpContext.Session.GetString("ih");
                ViewData["oh"] = HttpContext.Session.GetString("oh");
                ViewData["hu1"] = HttpContext.Session.GetString("hu1");
                ViewData["hu2"] = HttpContext.Session.GetString("hu2");
                ViewData["inputwidth"] = HttpContext.Session.GetString("inputwidth");
                if (Request.Form["weight"] != StringValues.Empty)
                {
                    weightv = Request.Form["weight"];
                    try
                    {
                        weight = float.Parse(weightv);
                        if (HttpContext.Session.GetString("wu") == "kg.")
                        {
                            iweight = weight * 2.20462;
                            weight = ((float)iweight);
                        }
                    }
                    catch (System.FormatException)
                    {
                        errormsg = "Invalid format. Values must be integer or decimal";
                        ViewData["errorm"] = errormsg;
                        t = 0;
                    }
                }
                if (Request.Form["ih"] != StringValues.Empty)
                {
                    ih = Request.Form["ih"];
                    if (HttpContext.Session.GetString("ih") == "m")
                    {
                        try
                        {
                            meters = float.Parse(ih);
                            iheight = meters* 39.3700787;
                            height = ((float)iheight);
                        }
                        catch (System.FormatException)
                        {
                            errormsg = "Invalid format. Values must be integer or decimal";
                            ViewData["errorm"] = errormsg;
                            t = 0;

                        }
                    }
                    else if (HttpContext.Session.GetString("ih") == "cm")
                    {
                        try
                        {
                            centimeters = float.Parse(ih);
                            iheight = (centimeters / 100) * 39.3700787;
                            height = ((float)iheight);
                        }
                        catch (System.FormatException)
                        {
                            errormsg = "Invalid format. Values must be integer or decimal";
                            ViewData["errorm"] = errormsg;
                            t = 0;

                        }
                    }
                    else if (HttpContext.Session.GetString("ih") == "ft.")
                    {
                        try
                        {
                            feet = float.Parse(ih);
                        }
                        catch (System.FormatException)
                        {
                            errormsg = "Invalid format. Values must be integer or decimal";
                            ViewData["errorm"] = errormsg;
                            t = 0;

                        }
                        if (Request.Form["oh"] != StringValues.Empty)
                        {
                            oh = Request.Form["oh"];
                            try
                            {
                                inches = float.Parse(oh);
                            }
                            catch (System.FormatException)
                            {
                                errormsg = "Invalid format. Values must be integer or decimal";
                                ViewData["errorm"] = errormsg;
                                t = 0;

                            }
                        }
                        if (t != 0)
                        {
                            height = (feet * 12) + inches;
                            Console.WriteLine("b");
                            Console.WriteLine(height);
                        }
                    }
                }
                if (t != 0)
                {
                    System.Diagnostics.Debug.Print(inches.ToString());
                    System.Diagnostics.Debug.Print(height.ToString());
                    System.Diagnostics.Debug.Print(weight.ToString());
                    height = height * height;
                    Console.WriteLine("j");
                    Console.WriteLine(height);
                    System.Diagnostics.Debug.Print(height.ToString());
                    doubleweight = weight * 703;
                    Console.WriteLine(doubleweight);
                    System.Diagnostics.Debug.Print(doubleweight.ToString());
                    BMI = doubleweight / height;
                    Console.WriteLine(BMI);
                    ViewData["BMI"] = "BMI: " + BMI;
                    System.Diagnostics.Debug.Print(BMI.ToString());
                }
                else
                {
                    t = 1;
                }
            }
        }

        public void OnGet()
        {
            ViewData["igreeting"] = "CalcWeb";
            Console.WriteLine(4.ToString());
            Console.WriteLine("jay");
            ViewData["wu"] = "lbs.";
            ViewData["u"] = "kg.";
            checkers[0] = 1;
            HttpContext.Session.SetString("wu", "lbs.");
            HttpContext.Session.SetString("u", "kg.");
            ViewData["hidden"] = "";
            ViewData["ih"] = "ft.";
            ViewData["oh"] = "in.";
            ViewData["hu1"] = "m";
            ViewData["hu2"] = "cm";
            ViewData["inputwidth"] = "60px";
            HttpContext.Session.SetString("hidden", "");
            HttpContext.Session.SetString("ih", "ft.");
            HttpContext.Session.SetString("oh", "in.");
            HttpContext.Session.SetString("inputwidth", "60px");
            HttpContext.Session.SetString("hu1", "m");
            HttpContext.Session.SetString("hu2", "cm");

        }


    }
}


