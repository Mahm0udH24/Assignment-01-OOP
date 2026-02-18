using System;

namespace AccessModifierDemo
{
    public class Student
    {

        public string Name;

        private int _score;

        public Student(string name, int score)
        {
            Name = name;
            _score = score;
        }
        public void PrintStudentDetails()
        {

            Console.WriteLine($"Student: {Name}, Score: {_score}");
        }
    }

    class Program
    {
        static void Start()
        {
            Student s1 = new Student("Ahmed", 95);

            s1.Name = "Ahmed Ali";

            s1.PrintStudentDetails();
        }
    }

    /*
     
    1. Private Access Modifier
                              Visibility: Members marked as private are only accessible within the same class or struct.

                              Purpose: It is used to hide sensitive data and internal logic from the outside world, preventing accidental modification.

                              Default: In C#, if you don't specify a modifier for a class member, it defaults to private.

2. Public Access Modifier
                            Visibility: Members marked as public are accessible from anywhere—both inside and outside the class, 
                            and even from other projects that reference your assembly.
                            Purpose: It is used for the "interface" of your class—the methods and properties you want other parts of the program to interact with.
     
     */

    // ========================================================================================================================================================================================================================================

    #region Q3
    /* 
     
    1. Creation Process
                        Template Selection: Open Visual Studio and choose the Class Library project template.

                        Project Naming: Provide a meaningful name for your library project.

                        Logic Implementation: Define your classes and methods (ensure they are marked as public to be accessible later).

                        Building the DLL: Right-click the project and select Build to generate the compiled .dll file.

2. Integration Process
                        Add Reference: In your main application , right-click Dependencies and select Add Project Reference.

                        Linking: Check the box for your Class Library project to link it to your application.

                        Using Directive: Add the using statement at the top of your code file followed by the library's namespace.

                        Execution: Instantiate the classes from the library and call their methods within your main code.
     
     */

    #endregion


    #region Q4
    /*  
     A Class Library is a collection of pre-written classes, interfaces, and methods that are compiled into a dll (Dynamic Link Library) file.
                     Unlike a standard application, a class library cannot be run directly
                     It must be called or referenced by another executable program, such as a Console or Web app.

    Why do we use Class Libraries?
                            Code Reusability: You can write a specific logic (like a math calculator or a database connector) once and use it across multiple different projects without rewriting the code.

                            Separation of Concerns: It allows you to separate your "business logic" from the "user interface," making the code cleaner and easier to manage.

                            Easier Maintenance: If a bug is found in the shared logic, you only need to fix it in the Class Library project,
                                                and all applications referencing it will receive the fix.

                            Security and Encapsulation: You can distribute your library as a compiled .dll file,
                                                        Allowing others to use your functions without seeing or modifying your original source code.
     */

    #endregion



}