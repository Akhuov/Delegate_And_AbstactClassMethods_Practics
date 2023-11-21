using Prac_21_;

var a = new Methods();

//Predicate<int> tub = a.Tub;
//Func<int, int> sum = a.Sum;
//Action<string> show = a.Show;

//Console.WriteLine(sum(13));
//Console.WriteLine(tub(2));
//show("AkbarShax");



Func<int, int> sum = a.Sum1;
sum += a.Sum2;
sum += a.Sum3;

System.Delegate[] deleg = sum.GetInvocationList();

foreach (System.Delegate d in deleg)
    Console.WriteLine(d);
//Console.WriteLine(sum(10));


//Action<string> show = a.Show;
//show += a.Show;
//show += a.Show;
//show += a.Show;
//show += a.Show;