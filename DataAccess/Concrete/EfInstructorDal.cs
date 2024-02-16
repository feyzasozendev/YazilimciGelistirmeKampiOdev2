using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfInstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;

        public EfInstructorDal()
        {
            _instructors = new List<Instructor>()
            {
                new Instructor{InstructorId=1, FirstName="Engin", LastName="Demiroğ"},
                new Instructor{InstructorId=2, FirstName="Halit Enes", LastName="Kalaycı"}
            };

        }
        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            Instructor instructorToDelete = _instructors.SingleOrDefault(i => i.InstructorId == instructor.InstructorId);
            _instructors.Remove(instructorToDelete);
        }

        public Instructor Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> GetAll(int id)
        {
            return _instructors;
        }

        public List<Instructor> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Instructor instructor)
        {
            Instructor instructorToUpdate = _instructors.SingleOrDefault(i => i.InstructorId == instructor.InstructorId);
            instructorToUpdate.FirstName = instructor.FirstName;
            instructorToUpdate.LastName = instructor.LastName;
        }
    }
}
