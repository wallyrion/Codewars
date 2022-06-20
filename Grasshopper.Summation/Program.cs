// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run<Benchmark>();


public class Benchmark
{
    [Benchmark]
    public int Summation_100000() => Kata.Summation(100000);
    
    [Benchmark]
    public int Summation_100() => Kata.Summation(100);
    
    [Benchmark]
    public int SummationMath_100000() => Kata.SummationMath(100000);
    
    [Benchmark]
    public int SummationMath_100() => Kata.SummationMath(100);
}


public static class Kata 
{
    public static int Summation(int num) => Enumerable.Range(1, num).Sum();
    public static int SummationMath(int num) => num * (num + 1) / 2;
}