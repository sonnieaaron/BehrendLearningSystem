using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BehrendLearningSystem.Models;

namespace BehrendLearningSystem.Services
{
    public class ModuleService
    {
        private HomePage _homePage;
        //private readonly string connection;
        //private string sqlQueryString;
        //private SqlCommand command;
        //private SqlDataReader reader;
        //private int nonReader;
        public ModuleService()
        {
            _homePage = new HomePage();
            //would establish the connection here...
        }

        public Course GetCourse(string courseID)
        {
            Course c = new Course();
            if (courseID == null || courseID == "")
            {
                c.courseID = "default";
                return c;
            }
            else
            {
                try
                {
                    //using (var conn = new SqlConnection(connection)){}
                    //we would query the database for the course information

                    //right now it's hardcoded until we get the application on server along with a database. 

                    c.courseDescription = "Course Overview for CMPSC 122";
                    c.courseID = courseID;
                    c.courseName = "CMPSC 122";
                    List<Module> _modules = new List<Module>();
                    Module m1 = new Module();
                    Module m2 = new Module();
                    Module m3 = new Module();
                    Module m4 = new Module();
                    Module m5 = new Module();
                    Module m6 = new Module();
                    Module m7 = new Module();

                    m1.moduleID = "m1";
                    m1.moduleName = "1. Static and dynamic arrays";
                    m1.moduleDescription = "";

                    m2.moduleID = "m2";
                    m2.moduleName = "2. Classes";
                    m2.moduleDescription = "";

                    m3.moduleID = "m3";
                    m3.moduleName = "3. Lists";
                    m3.moduleDescription = "";

                    m4.moduleID = "m4";
                    m4.moduleName = "4. Arrays";
                    m4.moduleDescription = "";

                    m5.moduleID = "m5";
                    m5.moduleName = "5. Queues";
                    m5.moduleDescription = "";

                    m6.moduleID = "m6";
                    m6.moduleName = "6. Vectors, iterators, STL lists";
                    m6.moduleDescription = "";

                    m7.moduleID = "m7";
                    m7.moduleName = "7. Recursion";
                    m7.moduleDescription = "";
                    _modules.Add(m1);
                    _modules.Add(m2);
                    _modules.Add(m3);
                    _modules.Add(m4);
                    _modules.Add(m5);
                    _modules.Add(m6);
                    _modules.Add(m7);
                    c.modules = _modules;

                    return c;
                }
                catch (Exception e)
                {
                    throw new Exception("Exception Thrown: "
                        + "\n  Type:    " + e.GetType().Name
                        + "\n  Message: " + e.Message
                        + "\n  Class:   " + this.GetType().Name
                        + "\n  Method:  " + System.Reflection.MethodBase.GetCurrentMethod().Name);
                }
            }
        }
        public HomePage GetHomePage()
        {
            try
            {
                //hardcoded example rn;
                User _user = new User();
                _user.userFName = "Brett";
                _user.userLName = "Palmer";
                _user.emailID = "bap5329";

                _homePage.user = _user;

                List<Course> _courses = new List<Course>();
                Course c1 = new Course();
                //Course c2 = new Course();
                c1.courseName = "";
                c1.courseID = "CMPSC122";
                c1.courseDescription = "This is the course description";

                List<Module> _modules = new List<Module>();
                Module m1 = new Module();
                m1.moduleName = "Intro to Classes";
                m1.moduleID = "M1";
                m1.moduleDescription = "In this module we will be going into detail about classes";

                _modules.Add(m1);
                c1.modules = _modules;
                _courses.Add(c1);

                _homePage.courses = _courses;

                return _homePage;
            }
            catch(Exception e)
            {
                throw new Exception("Exception Thrown: "
                    + "\n  Type:    " + e.GetType().Name
                    + "\n  Message: " + e.Message
                    + "\n  Class:   " + this.GetType().Name
                    + "\n  Method:  " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
        }

    }
}