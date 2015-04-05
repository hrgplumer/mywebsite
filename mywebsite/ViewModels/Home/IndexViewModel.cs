using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mywebsite.Entities;
using mywebsite.Repository;

namespace mywebsite.ViewModels.Home
{
    public class IndexViewModel
    {
        public IEnumerable<CarouselResource> CarouselResources { get; set; }


    }
}