using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Todo.Example.Api.Entities;

namespace Todo.Example.Api.Repository
{
    public class RepositoryFile
    {
        readonly private string[] _lines;

        public RepositoryFile() =>
            this._lines = File.ReadAllLines("..\\Todo.Example.Api\\FileDatabase\\db.txt");

        public List<Activity> GetAllTodoFromFile()
        {
            List<Activity> todos = new List<Activity>();

            foreach (var line in _lines)
            {
                var data = line.Split(',');
                var activity = new Activity(
                                    long.Parse(data[0]),
                                    data[1],
                                    data[2],
                                    data[3],
                                    data[4],
                                    data[5]);

                todos.Add(activity);
            }

            return todos;
        }

        public Activity GetTodoById(int id)
        {
            var result = _lines.ElementAt(id);
            var data = result.Split(',');

            return new Activity(long.Parse(data[0]), data[1], data[2], data[3], data[4], data[5]);
        }

        public void Insert(Activity activity)
        {
            string[] line = new string[] { $"{Environment.NewLine}{activity.Id}, {activity.Name}, {activity.Description}, {activity.DateStart}, {activity.DateFinished}, {activity.Status}" };
            File.AppendAllLines("..\\Todo.Example.Api\\FileDatabase\\db.txt", line);
        }
    }
}