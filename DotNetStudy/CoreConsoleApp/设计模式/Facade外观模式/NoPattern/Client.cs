using CoreConsoleApp.设计模式.Facade外观模式.Biz;

namespace CoreConsoleApp.设计模式.Facade外观模式.NoPattern

{
    public class Client
    {
        public static void Index()
        {
            /**
             * 存在的问题：
             仔细查看上面的实现，会发现其中有一个问题：那就是客户端为了使用生成代码的功能，需要与生成代码子系统内部的多个模块交互。
             这对于客户端而言，是个麻烦，使得客户端不能简单的使用生成代码的功能。
             而且，如果其中的某个模块发生了变化，还可能会引起客户端也需要跟着变化。
            */

            //现在没有配置文件，就直接使用默认的配置，通常情况下，三层都应该生成，
            //也就是说客户端必须对这些模块都有了解，才能够正确使用它们
            new Presentation().Generate();
            new Business().Generate();
            new DAO().Generate();
        }
    }

}
