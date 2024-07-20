以下代码是可以编译通过的，是因为：
1. myBase2.Test(string) 需要string类型的参数
2. 实际执行的是 Sub.Test(Object)
3. 按照李氏替换原则，是可以用子类string代替父类object使用的。 

![Quickerin](_static/quickerin.png)