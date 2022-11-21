namespace Lesson6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task[] tasks = InitTasks();
            TaskRunner(tasks);
        }
        private static Task[] InitTasks()
        {
            Task[] tasks = new Task[3];
            tasks[0] = new Task1();
            tasks[1] = new Task2();
            tasks[2] = new Task3();

            return tasks;
        }
        private static void TaskRunner(Task[] tasks)
        {
            foreach (Task item in tasks)
            {
                item.RunTask();
                System.Console.WriteLine("\nДля перехода к следующей задаче нажмите Enter");
                System.Console.ReadKey();
            }
        }
    }
}