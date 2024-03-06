﻿using NUnit.Framework;


[assembly: LevelOfParallelism(6)]

namespace ParallelizationExamples;

[Parallelizable(ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class Class1
{
    private object User;


    [SetUp]
    public void SetUp()
    {
        User = "Иван";
    }
    // [Test, Combinatorial]
    // public async Task Test1(
    //     [Values(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)]
    //     int a,
    //     [Values(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)]
    //     int b,
    //     [Values(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)]
    //     int c)
    // {
    //     var s = 0;
    //     for (var i = 0; i < (a * b * c) * 100000; i++)
    //     {
    //         s++;
    //     }
    // }

    [Test]
    public void Test2()
    {
        User = "Олег";
        Assert.That(User, Is.EqualTo("Олег"));
    }

    [Test]
    public void Test3()
    {
        User = "Олег2";
        Thread.Sleep(2000);
        Assert.That(User, Is.EqualTo("Олег2"));
    }


    [TestCase(1), TestCase(2), TestCase(3)]
    [Parallelizable(ParallelScope.Children)]
    public void TestWithParams(int value)
    {
        Thread.Sleep(2000);
    }
}