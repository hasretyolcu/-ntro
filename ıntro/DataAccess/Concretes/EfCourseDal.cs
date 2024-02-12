﻿using ıntro.DataAccess.Abstracts;
using ıntro.Entities;

public class EfCourseDal:ICourseDal
{
    List<Course> courses;
    public EfCourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "JavaScript";
        course1.Description = " .NET 8 vs... ";
        course1.Price = 0;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "JAVA";
        course2.Description = " Java 17 ... ";
        course2.Price = 10;

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "PYTHON";
        course3.Description = " Python 3.12... ";
        course3.Price = 20;

        courses = new List<Course> { course1, course2, course3 };

    }

    public void Add(Course course)
    {
        throw new NotImplementedException();
    }

    public List<Course> GetAll()
    {
        //sql öğre:))
        //burada db işlemleri yapılır

        return courses;
    }
}

