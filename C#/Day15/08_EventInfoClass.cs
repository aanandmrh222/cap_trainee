using System;
using System.Reflection;

namespace ReflectionEventInfoDemo
{
    // ---------------- STUDENT CLASS ----------------
    public class Student
    {
        // Event declaration
        public event EventHandler StudentRegistered;

        public void Register()
        {
            Console.WriteLine("Student Registered");
            StudentRegistered?.Invoke(this, EventArgs.Empty);
        }
    }

    class EventInfoClass
    {
        public static void EventInfoClassMain()
        {
            Student student = new Student();
            Type type = typeof(Student);

            Console.WriteLine("===== EVENT METADATA =====\n");

            // Get EventInfo
            EventInfo eventInfo = type.GetEvent("StudentRegistered");

            Console.WriteLine("Event Name        : " + eventInfo.Name);
            Console.WriteLine("EventHandlerType : " + eventInfo.EventHandlerType);

            Console.WriteLine("\n===== EVENT ACCESS METHODS =====\n");

            // Create delegate (event handler)
            EventHandler handler = new EventHandler(OnStudentRegistered);

            // AddEventHandler(object target, Delegate handler)
            eventInfo.AddEventHandler(student, handler);

            Console.WriteLine("Event handler added using Reflection\n");

            // Trigger event
            student.Register();

            // GetAddMethod()
            MethodInfo addMethod = eventInfo.GetAddMethod();
            Console.WriteLine("\nAdd Method Name: " + addMethod.Name);

            // GetRemoveMethod()
            MethodInfo removeMethod = eventInfo.GetRemoveMethod();
            Console.WriteLine("Remove Method Name: " + removeMethod.Name);

            // RemoveEventHandler(object target, Delegate handler)
            eventInfo.RemoveEventHandler(student, handler);

            Console.WriteLine("\nEvent handler removed using Reflection");

            // Trigger again (no handler)
            student.Register();

        }

        // Event handler method
        static void OnStudentRegistered(object sender, EventArgs e)
        {
            Console.WriteLine("Event handled via Reflection");
        }
    }
}
