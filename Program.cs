using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Diagnostics;

namespace csharp
{
    delegate int myDele (int x);

    class Program
    {
        static int MySum(int number)
        {
            return number + number;
        }
        static int MyDouble (int x) => x * x;
        static void Main(string[] args)
        {
            myDele f = MySum;
            int numberResult = f(2);
            Console.WriteLine(numberResult);
            myDele f2 = MyDouble;
            numberResult = f2(10);
            numberResult = f2.Invoke(9);
            Console.WriteLine(numberResult);
            


            Console.WriteLine("Hello World!");

            Product product = new Product("bestGood");
            Console.WriteLine(product.Name);
            Console.WriteLine(product.ToString());

            Product oldProduct = new Product(name: "Good Product");
            Product newProduct = new Product(name: "Good Product");
            Console.WriteLine(oldProduct.GetHashCode());
            Console.WriteLine(newProduct.GetHashCode());
            Console.WriteLine(oldProduct.Equals(newProduct));

            Man tom = new Man();
            tom.Shout();
            
            Random random = new Random();
            List<int> numberList = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                numberList.Add(random.Next(i * 10  - 9, i * 10));
            }

            foreach (int number in numberList)
            {
                Console.WriteLine(number);
            }

            foreach (int num in getNumber())
            {
                Console.WriteLine(num);
            }

            var list = new MyList();
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            IEnumerator it = list.GetEnumerator();
            while (it.MoveNext())
            {
                Console.WriteLine(it.Current);
            }

            IEnumerable<int> rangeNumList = Enumerable.Range(1, 100);
            foreach (int data in rangeNumList)
            {
                //Console.WriteLine(data);
                //Console.WriteLine(data.GetHashCode());
            }

            // Pick 9 unique, random, numbers between 1..10 inclusive
            List<int> values = rangeNumList.ToList();
            Random r = new Random();
            List<int> UniqueRandoms = new List<int>();
            
            for (int i = 0; i < 9; ++i)
            {
                int idx = r.Next(0, values.Count);
                UniqueRandoms.Add(values[idx]);
                values.RemoveAt(idx);
            }

            foreach (int uNum in UniqueRandoms)
            {
                Console.WriteLine(uNum);
            }

            IEnumerable<Lecture> lectureList = Enumerable.Repeat<Lecture>(new Lecture
            {
                Id = Guid.NewGuid(),
                Name = "hello",
                Score = random.Next(1, 4),
            }, 10);

            List<Lecture> lecList = new List<Lecture>();
            Guid lecId = Guid.NewGuid();
            var lecName = Guid.NewGuid().ToString();
            for (int i = 0; i <= 10; i++)
            {
                lecList.Add(new Lecture
                {
                    Id = Guid.NewGuid(),
                    Name = Guid.NewGuid().ToString(),
                    Score = random.Next(1,4),
                });
            }

            foreach (Lecture lec in lectureList)
            {
                //Console.WriteLine($"lec id {lec.Id}  \n lec name {lec.Name} \n lec score {lec.Score}");
                //Console.WriteLine($"lec's hascode : {lec.GetHashCode()}");
            }

            foreach (Lecture lec in lecList)
            {
                //Console.WriteLine($"lec id {lec.Id}  \n lec name {lec.Name} \n lec score {lec.Score}");
                //Console.WriteLine($"lec's hascode : {lec.GetHashCode()}");
            }

            lecList.Clear();
            for (int i = 0; i <= 10; i++)
            {
                lecList.Add(new Lecture
                {
                    Id = lecId,
                    Name = lecName,
                    Score = 3,
                });
            }

            foreach (Lecture lec in lecList)
            {
                //Console.WriteLine($"lec id {lec.Id}  \n lec name {lec.Name} \n lec score {lec.Score}");
                //Console.WriteLine($"lec's hascode : {lec.GetHashCode()}");
            }

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("tom", "korea");
            Console.WriteLine(dict.GetHashCode());
            dict.Add("ken", "seoul");
            Console.WriteLine(dict.GetHashCode());

            Console.WriteLine(dict["tom"]);

            List<int> nList = new List<int> { 1, 10, 2, 5, 6, 8, 4, 3, 9, 7};
            Comparer comparer = new Comparer(CultureInfo.CurrentCulture);
            nList.Sort((int a, int b) => a.CompareTo(b));

            foreach (int d in nList)
            {
                //Console.WriteLine(d);
            }

            nList.Sort((int a, int b) => b.CompareTo(a));

            foreach (int d in nList)
            {
                //Console.WriteLine(d);
            }

            lecList.Clear();
            for (int i = 0; i <= 10; i++)
            {
                lecList.Add(new Lecture
                {
                    Id = Guid.NewGuid(),
                    Name = Guid.NewGuid().ToString(),
                    Score = random.Next(1,4),
                });
            }

            Console.WriteLine("CompareTo=====");
            lecList.Sort((Lecture a, Lecture b) => {
                if (a.Score == b.Score) return a.Name.CompareTo(b.Name);
                return a.Score.CompareTo(b.Score);
            });
            foreach (Lecture lec in lecList)
            {
                //Console.WriteLine($"lec id {lec.Id}  \n lec name {lec.Name} \n lec score {lec.Score}");
            }
            Console.WriteLine("OrderBy And ThenBy");
            lecList.OrderBy(x => x.Score).ThenBy(x => x.Name);
            foreach (Lecture lec in lecList)
            {
                //Console.WriteLine($"lec id {lec.Id}  \n lec name {lec.Name} \n lec score {lec.Score}");
            }


            IEnumerable<int> rangeTimeWindowNumber = Enumerable.Range(1, 10);
            List<int> rangeTimeWindowNumberList = rangeTimeWindowNumber.ToList();
            IEnumerable<int> rangeChargeDayNumber = Enumerable.Range(1, 10);
            List<int> rangeChargeDayNumberList = rangeChargeDayNumber.ToList();

            CancelllationPolicy cancelllationPolicy = new CancelllationPolicy();
            cancelllationPolicy.IsRefundable = true;

            for (int i = 0; i < 10; i++)
            {
                int idxTimeWindow = random.Next(0, rangeTimeWindowNumberList.Count - 1);
                int idxChargeDay = random.Next(0, rangeChargeDayNumberList.Count - 1);

                CancellationFeeRule cancellationFeeRule = new CancellationFeeRule
                {
                    TimeWindow = rangeTimeWindowNumberList[idxTimeWindow],
                    ChargeDays = rangeChargeDayNumberList[idxChargeDay],
                    ChargePercentage = random.Next(1, 10) * 10,
                };

                cancelllationPolicy.CancellationFeeRules.Add(cancellationFeeRule);

                rangeTimeWindowNumberList.RemoveAt(idxTimeWindow);
                rangeChargeDayNumberList.RemoveAt(idxChargeDay);
            }
            bool isSorted = false;
            isSorted = IsSorted(cancelllationPolicy.CancellationFeeRules);
            Console.WriteLine(isSorted);

            cancelllationPolicy.CancellationFeeRules.Clear();
            for (int i = 0; i < 10; i++)
            {
                CancellationFeeRule cancellationFeeRule = new CancellationFeeRule
                {
                    TimeWindow = i,
                    ChargeDays = 10 - i,
                    ChargePercentage = 100 - (i * 10),
                };
                cancelllationPolicy.CancellationFeeRules.Add(cancellationFeeRule);
            }

            isSorted = IsSorted(cancelllationPolicy.CancellationFeeRules);
            Console.WriteLine(isSorted);

            MyButton btn = new MyButton();
            btn.Click += new EventHandler(btn_Click);
            btn.Text = "Run";

            Dictionary<int, string> levelOfStudents = new Dictionary<int, string>();
            for (int i = 0; i < 500000; i++)
            {
                levelOfStudents.Add(i, Guid.NewGuid().ToString());
            }
            HashSet<int> studentList = new HashSet<int>();
            for (int i = 0; i < 500000; i++)
            {
                studentList.Add(i);
            }
            Stopwatch watch = new Stopwatch();
            watch.Start();
            string levelLiteral = string.Empty;
            levelOfStudents.TryGetValue(45000, out levelLiteral);
            if (levelLiteral != "")
            {
                watch.Stop();
                Console.WriteLine("ElapsedMilliseconds : " + watch.ElapsedMilliseconds);
            }
            watch.Reset();
            watch.Start();
            int level = 0;
            studentList.TryGetValue(45000, out level);
            if (level != 0)
            {
                watch.Stop();
                Console.WriteLine("ElapsedMilliseconds : " + watch.ElapsedMilliseconds);
            }

            int.TryParse("100", out int resultParse);
            Console.WriteLine(resultParse);

            int.TryParse("209", out var resultNumber);
            Console.WriteLine(resultNumber);

            var expression = new {
                Name = "Tome",
                Age = 10,
                Id = Guid.NewGuid(),
            };
            Console.WriteLine(expression.Name.GetType().Name);
            
            var myList = new {
                Items = new[] { new { Id = Guid.NewGuid(), Name = "Tom" }, new { Id = Guid.NewGuid(), Name = "John" }, new { Id = Guid.NewGuid(), Name = "Bob" }, new { Id = Guid.NewGuid(), Name = "John" }, new { Id = Guid.NewGuid(), Name = "Patrick" } },
            };
            var resultLinq = from item in myList.Items
            where item.Name == "John"
            select item.Id;

            Console.WriteLine(resultLinq.Count());
            

            





        }

        static void btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked");
        }

        static bool IsSorted(List<CancellationFeeRule> feeRules)
        {
            for (int i = 1; i < feeRules.Count; i++)
            {
                if (feeRules[i - 1].TimeWindow.CompareTo(feeRules[i].TimeWindow) > 0)
                {
                    return false;
                }

                if (feeRules[i - 1].ChargeDays.CompareTo(feeRules[i].ChargeDays) < 0)
                {
                    return false;
                }

                if (feeRules[i - 1].ChargeDays.CompareTo(feeRules[i].ChargeDays) == 0)
                {
                    if (feeRules[i - 1].ChargePercentage.CompareTo(feeRules[i].ChargePercentage) <= 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static IEnumerable<int> getNumber()
        {
            yield return 10;
            yield return 20;
            yield return 30;
            yield return 40;
        }
    }
}
