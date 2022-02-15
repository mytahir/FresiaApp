using PropertyChanged;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace FresiaApp.Models
{
    [AddINotifyPropertyChangedInterface]

    public class HomeViewModel
    {
        public string Time { get; set; }

        public string Room { get; set; }

        public string CourseTitle { get; set; }

        public string CourseState { get; set; }
    }
}
