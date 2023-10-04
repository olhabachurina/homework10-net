using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10_net
{
    public class Cafe : IEnumerable<Employee>
    {
        private List<Employee> employees = new List<Employee>();


        public void AddEmployee(Employee employee)// Метод для добавления работника в кафе
        {
            employees.Add(employee);
        }


        public IEnumerator<Employee> GetEnumerator()// Реализация GetEnumerator для IEnumerable
        {
            return employees.GetEnumerator();
        }


        IEnumerator IEnumerable.GetEnumerator()// Реализация GetEnumerator для IEnumerable (неявный метод)
        {
            return GetEnumerator();
        }
    }
}