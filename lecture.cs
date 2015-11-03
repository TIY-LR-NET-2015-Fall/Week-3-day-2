List<int> numbers = new List<int>{ 5,3,10, 99 ,57,4 ,6 ,8};

var count = numbers.Count();  //count 5
var sum = numbers.Sum(); // sum 174
var min = numbers.Min(); // 3 
var max = numbers.Max(); // 99
var avg = numbers.Avg(); //34.8
var hasItems = numbers.Any(); //true
var test = numbers.Count() > 10;//
var test2 = numbers.First(); // 5
var test3 = numbers.First(x=> x > 50); //99
var test4 = numbers.Where(x=> (x % 2) == 0); // 10, 4, 6, 8
var test4 = numbers.First(x=> (x % 2) == 0); // 10

var test5 = numbers.Select(x=>x);  //5 ,3, 10.......
var test6 = numbers.Select(x=>x+1); //6, 4, 11, 100, 58, 5,7,9

var test7 = new[] {
		{ Name = "Daniel", Age = 34},
		{ Name = "Baxley", Age = 30},
		{ Name = "Josh", Age = 31},
		{ Name = "Justin", Age = 24},
		{ Name = "Cason", Age = 27}
	};

test7.Count(); //5
test7.Count(x=> x.Age < 30); // 2
test7.First(); //  { Name = "Daniel", Age = 34}
test7.First().Name; // "Daniel"
test7.Min(x=>x.Age); // 24
test7.Any(); // true
test7.Any(x=>x.Name.StartsWith("Z")); // false
test7.Any(x=>x.Name.StartsWith("J")); // true
test7.Count(x=>x.Name.StartsWith("J")); // 2
test7.Where(x=> x.Age > 30); // { Name = "Daniel", Age = 34},
							//{ Name = "Josh", Age = 31},

test7.Where(x=> x.Age > 30).First();// { Name = "Daniel", Age = 34},
test7.Where(x=> x.Age > 30).Count(); // 2
var something = test7.Select(u => u.Age); //  34,30,31,24,27 // List<int>
var something2 = test7.Select(u => u.Name); //  Daniel, Justin, Josh, Baxley, Cason
var something3 = test7.Select(p=> 
	new { FirstName = p.Name, IsOver30 = p.Age > 30});
//{ Firstname = "Daniel" IsOver30 =true  }
//{ Firstname = "Baxley" IsOver30 = false} 
//{ Firstname = "Josh" IsOver30 =  true } 
//{ Firstname = "Justin" IsOver30 = false }  
//{ Firstname = "Cason", IsOver30 = false }  

var something4 = test7.Select(p=> 
	new { Blah = p.Name + p.Age});
//{ Blah = "Daniel34"},
//{ Blah = "Baxley30"},
//{ Blah = "Josh31"},
//{ Blah = "Justin24"},
//{ Blah = "Cason27"}
something4[0].Blah ; // Daniel34
something4.First();// {Blah = "Daniel34"}
something4.First().Blah;// {Blah = "Daniel34"}

var something5 = test7.Select(p=> p.Name + p.Age) ;// List<string>
//"Daniel34",
//"Baxley30",
//"Josh31"},
//"Justin24",
//"Cason27"
