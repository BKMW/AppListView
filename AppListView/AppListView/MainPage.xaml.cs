using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppListView
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            ListView1.ItemsSource = new string[]
            {
                "Person1",
                "Person2",
                "Person3",
                "Person4"

            };
            //ListView1.ItemsSource = new List<Persons>
            //{
            //          new Persons{ Name ="person1",Status = "welcome", Image = "http://lorempixel.com/400/200/sports/"},
            //    new Persons{ Name ="person2",Status = "Hi", Image = "http://lorempixel.com/400/200/sports/"},
            //    new Persons{ Name ="person3",Status = "Hello", Image = "http://lorempixel.com/400/200/sports/"}
            //      };

        }
	}
}
