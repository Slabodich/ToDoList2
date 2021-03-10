using System.Collections.Generic;
using WebAppTest.Models;

namespace WebAppTest.DAL
{
    public static class LocalStorage
    {
        public static List<ToDoItem> Items;
        public static List<ToDoStatus> Statuses;
        
        static LocalStorage()
        {
            Statuses = new List<ToDoStatus>
            {
                ToDoStatus.New,
                ToDoStatus.Working,
                ToDoStatus.Complited,
                ToDoStatus.Cancelled,
            };

            Items = new List<ToDoItem>
            {
                new ToDoItem
                {
                    ID = 1,
                    Name = "Поработать с ASP.NET",
                    StartDate = "2021-02-20",
                    EndDate = "2021-02-28",
                    Status = ToDoStatus.Working
                },

                new ToDoItem
                {
                    ID = 2,
                    Name = "Сделать курсач",
                    StartDate = "2021-02-26",
                    EndDate = "2021-06-01",
                    Status = ToDoStatus.New
                },
            };
        }
    }
}
