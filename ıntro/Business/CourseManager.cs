using ıntro.DataAccess.Abstracts;
using ıntro.DataAccess.Concretes;
using ıntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICourseDal = ıntro.DataAccess.Abstracts.ICourseDal;

namespace ıntro.Business;

public class CourseManager
{
    //dependency injection
    
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    

    public List<Course> GetAll()
    {
        //business rules
        
        return _courseDal.GetAll();
    }
}

    
