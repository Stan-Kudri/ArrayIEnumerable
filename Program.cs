using ArrayIEnumerable;

var one = new Candy("Грильяж", 333);
var two = new Candy("Аленка", 344);
var three = new Candy("Аэрофлот", 222);
var four = new Candy("Кроккк", 522);

var candies = new Candy[] { one, two, three, four };
var purchase = new Purchase(candies);

foreach (var cand in purchase)
{
    Console.WriteLine(cand);
}

foreach (var cand in candies)
{
    Console.WriteLine(cand);
}

