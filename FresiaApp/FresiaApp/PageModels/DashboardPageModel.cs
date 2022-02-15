using FreshMvvm;
using System.Collections.Generic;
using System.Linq;
using FresiaApp.Models;
using FresiaApp.Pages;
using System;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace FresiaApp.PageModels
{
    public class DashboardPageModel : FreshBasePageModel
    {
        //readonly IList<HomeViewModel> source;

        //public ObservableCollection<HomeViewModel> TimelineMenu { get; private set; } = new ObservableCollection<HomeViewModel>();

        public bool IsBusy { get; set; }

        public List<HomeViewModel> TimelineMenu { get; set; }

        public string Timeline { get; set; } = "TODAY'S TIMELINE";

        public ObservableCollection<FeedsModel> Feeds { get; set; }


        public DashboardPageModel()
        {
            //base.Init(initData);
          
            //source = new List<HomeViewModel>();
            //CreateTimelineCollection();
            //RaisePropertyChanged();
        }

        public override async void Init(object initData)
        {
            base.Init(initData);

            IsBusy = true;
            await Task.Delay(2500);
            IsBusy = false;

            CreateTimelineCollection();

            CreateFeedsCollection();

        }

        void CreateFeedsCollection()
        {
            Feeds = new ObservableCollection<FeedsModel>
            {
                new FeedsModel{Title = "School Stand on the Strike!", Description = "The Federal University Dutse, Jigawa State has finally agreed to sit for a Meeting in Sanate Building"},
                new FeedsModel{Title = "School Stand on the Strike!", Description = "The Federal University Dutse, Jigawa State has finally agreed to sit for a Meeting in Sanate Building"},
                new FeedsModel{Title = "School Stand on the Strike!", Description = "The Federal University Dutse, Jigawa State has finally agreed to sit for a Meeting in Sanate Building"},
                new FeedsModel{Title = "School Stand on the Strike!", Description = "The Federal University Dutse, Jigawa State has finally agreed to sit for a Meeting in Sanate Building"},
                new FeedsModel{Title = "School Stand on the Strike!", Description = "The Federal University Dutse, Jigawa State has finally agreed to sit for a Meeting in Sanate Building"}


            };

        }

        void CreateTimelineCollection()
        {

           TimelineMenu = new List<HomeViewModel>
            {
                new HomeViewModel{Time = "04 - 4:30pm", Room = "ROOM 501", CourseTitle = "Theory of Computation", CourseState = "ONGOING CLASS"},
                new HomeViewModel{Time = "08 - 1 am", Room = "ROOM 502", CourseTitle = "Object Oriented Programming 2", CourseState = "UPCOMING CLASS"}
            };

        //    TimelineMenu.Add(new HomeViewModel
        //    {
        //        Time = "04 - 4:30pm",
        //        Room = "Room 501",
        //        CourseTitle = "Theory of Computation",
        //        CourseState = "OnGoing Class"
        //    });

        //    TimelineMenu.Add(new HomeViewModel
        //    {
        //        Time = "04 - 4:30pm",
        //        Room = "Room 501",
        //        CourseTitle = "Theory of Computation",
        //        CourseState = "OnGoing Class"
        //    });

        //    TimelineMenu.Add(new HomeViewModel
        //    {
        //        Time = "04 - 4:30pm",
        //        Room = "Room 501",
        //        CourseTitle = "Theory of Computation",
        //        CourseState = "OnGoing Class"
        //    });

            
        }

    }
}
