using System.Security.Cryptography.X509Certificates;

namespace StringUtility
{
    public interface IActivity
    {
        void Execute();
    }

    public class VideoUploader : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video Uploading...");
        }
    }
    public class SendSms : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending SMS...");
        }
    }
    public class CallWebService : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Calling web service...");
        }
    }

    public class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            foreach (var i in workflow.GetActivities())
            {
                i.Execute();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            var workflow = new Workflow();
            workflow.Add(new VideoUploader());
            workflow.Add(new SendSms());
            workflow.Add(new CallWebService());
            var engine = new WorkflowEngine();
            engine.Run(workflow);
            Console.ReadLine();
        }
    } 
}