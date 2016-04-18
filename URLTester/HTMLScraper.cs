using System;


namespace URLTester{

    public partial class URLTester2 : Form {

        public class HTMLScraper

        {

            public static void SimpleTaskSample()
            {

               
                Console.WriteLine("Start Simple Task Sample");
                var engineConfig = new CrawlerEngineConfig();
                var engine = new CrawlerEngine(engineConfig);
                engine.Start();
                Console.WriteLine();
                Console.WriteLine("Start Task");

            Uri fileURI = new Uri(URLbox2.Text);

            engine.AddTask(new SimpleTaskRequest { Url = fileURI });

                while (!engine.IsIdle)
                {
                    Thread.Sleep(100);
                    TaskResultBase[] results = engine.GetFinishedTaskResults();
                    if (results.Length > 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Processing Results");
                        foreach (SimpleTaskResult result in results)
                        {
                            foreach (var link in result.Links)
                            {
                                Console.WriteLine(link);
                            }
                        }
                    }
                }

              
            }

           


            public class SimpleTask : TaskBase
            {
                #region Public Properties

                
                public new SimpleTaskRequest TaskRequest
                {
                    get
                    {
                        return (SimpleTaskRequest)base.TaskRequest;
                    }
                }

              
                public new SimpleTaskResult TaskResult
                {
                    get
                    {
                        return (SimpleTaskResult)base.TaskResult;
                    }
                }

               


                public override async void StartWork()
                {
             
                    base.TaskResult = new SimpleTaskResult();

                  
                    var request = await new HttpRequest(TaskRequest.Url, new HttpRequestQuota { MaxDownloadSize = 100000, OperationTimeoutMilliseconds = 10000, ResponseTimeoutMilliseconds = 5000 });

                    this.TaskResult.Links = new List<string>();
                    HtmlNodeCollection nodes = request.Html.DocumentNode.SelectNodes("//a[@href]");
                    foreach (var node in nodes)
                    {
                        string href = node.Attributes["href"].Value;
                        this.TaskResult.Links.Add(href);
                    }
                }

                
            }

           
            [DataContract]
            public class SimpleTaskRequest : TaskRequestBase
            {
                #region Public Properties

              
                [DataMember]
                public Uri Url { get; set; }

                #endregion

                #region Public Methods and Operators

               
                public override TaskBase CreateTask()
                {
                    return new SimpleTask();
                }

                #endregion
            }

          
            [DataContract]
            public class SimpleTaskResult : TaskResultBase
            {
                #region Public Properties

               
                [DataMember]
                public List<string> Links { get; set; }

                #endregion
            }
        }
    }

    #endregion
}