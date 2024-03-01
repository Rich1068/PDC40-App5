using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity2 : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }
        public Activity2()
        {
            InitializeComponent();

            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee { DisplayName = "Juan Dela Cruz", Position = "President", Image = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/83240012-8303-4d4b-abac-4176896a795d/dgkr9w8-df64af14-e6a1-4d55-a467-39a2577c6403.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzgzMjQwMDEyLTgzMDMtNGQ0Yi1hYmFjLTQxNzY4OTZhNzk1ZFwvZGdrcjl3OC1kZjY0YWYxNC1lNmExLTRkNTUtYTQ2Ny0zOWEyNTc3YzY0MDMucG5nIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.Yyd9mvUlSM_1eajXcIEolFltYbijAuiDtDqkQcwP_Qg" });
            employees.Add(new Employee { DisplayName = "Lorenzo Sangalang", Position = "Drawerist", Image = "" });
            employees.Add(new Employee { DisplayName = "Richard Darwin Sy", Position = "Cookerist", Image = "" });
            employees.Add(new Employee { DisplayName = "Leandro Sangalang", Position = "Drawerist 2nd", Image = "" });
            employees.Add(new Employee { DisplayName = "Mark Anthony Soberano", Position = "Violence", Image = "" });
        }
        public void Menu_Delete(Object sender, EventArgs e)
        {
            DisplayAlert("Delete", "BE gone", "OK");
        }
        public void Menu_More(Object sender, EventArgs e)
        {
            DisplayAlert("More", "MOOOOORE", "OK");
        }
    }
}