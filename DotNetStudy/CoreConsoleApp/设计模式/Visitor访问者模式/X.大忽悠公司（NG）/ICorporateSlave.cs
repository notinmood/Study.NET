/**
 * @file   : CorporateSlave.cs
 * @date   : 2024/8/2 11:02:47
 * @mail   : 9727005@qq.com
 * @creator: ShanDong Xiedali
 * @company: HiLand & RainyTop
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsoleApp.设计模式.Visitor访问者模式.X.大忽悠公司NG
{
    public interface ICorporateSlave
    {
        void Accept(IVisitor visitor);
    }
}
