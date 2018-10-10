using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsApp_2
{
    public class Globals
    {
        public static List<dynamic> items =
            new List<dynamic> {
                new { id = 1, title = "t1", details = "d1", author = "a1" }
                , new { id = 2, title = "t2", details = "d2", author = "a2" }
                , new { id = 3, title = "t3", details = "d3", author = "a3" }
            };
    }
}