class PassingRefByVal
{
    static void Change(int[] pArray)
    {
        pArray[0] = 888;  // 此更改会影响原来的arr。
        pArray = new int[5] { -3, -1, -2, -3, -4 };   // This change is local.
        Console.WriteLine("然后，在Change方法中，数组的第一个元素为: {0}", pArray[0]);
    }

    static void Main()
    {
        int[] arr = { 1, 4, 5 };
        Console.WriteLine("首先,在Main方法里,在没有引用Change方法时,数组的第一个元素为: {0}", arr[0]);

        Change(arr);
        Console.WriteLine("最后，在执行完Change方法后，数组的第一个元素是: {0}", arr[0]);
    }
}
/*输出:
    首先,在Main方法里,在没有引用Change方法时,数组的第一个元素为: 1
    然后，在Change方法中，数组的第一个元素为: -3
    最后，在执行完Change方法后，数组的第一个元素是: 888
*/
/*分析代码
    我们如何理解这段代码?
    首先运行这段代码时,系统执行Main函数,创建了一个整型内容的数组arr,包括3个元素,分别是1,4,5
    执行在屏幕显示内容的命令,内容是"首先,在Main方法里,在没有引用Change方法时,数组的第一个元素为: {0}, arr[0]"
    arr[0]即数组的第一个元素
    这段话中,花括号内的0表示逗号后面给出内容的第一个内容,例:Console.WriteLine({0}{1}, arr[0] arr[2]);结果为1 5,对应数组的第1和第3个元素
    接下来执行下面的命令Change(arr),这个命令是将arr数组以值的形式作为前面Change函数的参数传入Change函数里面
    用一种易于理解的方式说明，就是设定的参数arr将它的值交给Change，在change函数里面执行的是值是arr的值，但是以pArray的形式执行的。用完了要将得到的值还给原来的arr
    放在这个程序中指的是把arr的值交给Change函数，作为Change函数的一个参数执行，那么Change的参数pArray数组起初为1，4，5
    接下来执行pArray[0] = 888命令，那么原来的1，4，5变成了888，4，5
    在Change方法里，新建了一个数组变量为pArray，覆盖了原来的变量pArray，数组共5个内容，分别为-3, -1, -2, -3, -4
    执行Console.WriteLine，显示“然后，在Change方法中，数组的第一个元素为: -3”。这个值指的是执行完Change方法后
    执行完Change方法后，在屏幕上显示执行完Change方法后的arr数组的第一个值。
    由于第一次赋值pArray将arr传送到Change方法的pArray变量，pArray将这个arr的值的第一位改为888。
    然而Change方法又新建了一个变量pArray，arr仅仅将值传送到胡来的pArray，因此后面的pArray变量的值与arr无关，后来的pArray无论怎么变，与此前的arr无关。所以执行Change方法写出的值是新的pArray的第一位
    原来的arr得到的是第一次qArray执行完得到的内容，就是888，4，5，因此后面执行命令时显示的是“最后，在执行完Change方法后，数组的第一个元素是: 888”
*/

