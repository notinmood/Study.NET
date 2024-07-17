using CoreConsoleApp.设计模式.Facade外观模式.Biz;

namespace CoreConsoleApp.设计模式.Facade外观模式.UsePattern
{
    /**
   * 代码生成子系统的外观对象
   */
    public class Facade
    {
        /**
         * 客户端需要的，一个简单的调用代码生成的功能，但具体怎么实现的客户不想知道，也没有必要知道。
         * 客户端想要操作更简单点，那就根据客户端的需要来给客户端定义一个简单的接口（就是这里的facade），然后让客户端调用这个接口，剩下的事情就不用客户端管，这样客户端就变得简单了。
         */
        public void Generate()
        {
            new Presentation().Generate();
            new Business().Generate();
            new DAO().Generate();
        }
    }
}
