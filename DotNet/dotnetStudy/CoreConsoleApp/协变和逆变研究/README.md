# 说明

> 参考 https://www.cnblogs.com/lemontea/archive/2013/02/17/2915065.html


## 详细说明
泛型委托的实例化其实分为两个步骤：

1. 委托实例化。就是把一个具体的方法作为 new 的参数进行调用，得到委托（委托是一种类型）的一个实例。
2. 泛型实例化。就是将泛型 T，明确为具体的类型，比如 string，int 等。

* 泛型实例化的时候，直观地遵循这李氏替换原理；
* 协变和逆变出现在委托实例化的过程中，底层必然也遵循李氏替换原理，但逆变在表面上反常；

## 特别注意
```JavaScript
public class Sub<T> : Base<T>
{
}
```

这段代码中类型`Sub<T>`对`Base<T>`：

1. 有继承关系,是因为两个T是相同的类型（必须都为string，或者都为object）。
2. 如果Sub的T和Base的T不相同（分别记作T和T'），那么`Sub<T'>`和`Base<T>`不具有继承关系（即便T和T'分别为Object和string这种关系也不行）。

更具体地说明：类型 `Base<T>` 和 类型 `Sub<T>` 之间，
1. 只有 T 相同，才有继承派生关系；
2. 当T 不同的时候，两者间没有关系。
即，类型 `Base<Object>` 和 `Sub<string>`，或者 `Base<string>` 和 `Sub<object>` 之间没有任何继承派生关系
