using System;
using System.Collections.Generic;
using System.Text;

namespace csharp
{
    public class Student
    {
        public string Name { get; private set; }

        public Guid Id { get; }

        public string Dept { get; private set; }

        public string Email { get; private set; }

        public Student(string name, string dept, string email)
        {
            Name = name;
            Dept = dept;
            Email = email;
            Id = Guid.NewGuid();
        }

        public void Deconstruct(out string name, out string dept, out string Email, out Guid id)
        {
            name = this.Name;
            dept = this.Dept;
            Email = this.Email;
            id = this.Id;
        }

        public ref int GetScore(int[] data, int id)
        {
            return ref data[id];
        }
    }
}
