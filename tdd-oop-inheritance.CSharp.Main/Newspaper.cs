﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Newspaper : ReadableItem
    {
        /*public string title;

        Boolean onLoan = false;*/

        public Newspaper(string title) {
            Title = title;
        }


        public override string checkIn() {
            return "newspapers are not available for loan";
        }

        public override string checkOut() {
            return "newspapers are not available for loan";
        } 
    }
}
