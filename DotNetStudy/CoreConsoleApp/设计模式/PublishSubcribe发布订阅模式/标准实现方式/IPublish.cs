using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleApp.设计模式.PublishSubcribe发布订阅模式.标准实现方式
{
    internal interface IPublish
    {
        void Publish<T>(T data);
    }
}
