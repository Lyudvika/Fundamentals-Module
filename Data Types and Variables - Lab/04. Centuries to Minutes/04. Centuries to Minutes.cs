int centuries = int.Parse(Console.ReadLine());

double years = centuries * 100;
double days = years * 365.2422;
double hours = days * 24;
double minutes = hours * 60;

Console.WriteLine($"{centuries:f0} centuries = {years:f0} years = {days:f0} days = {hours:f0} hours = {minutes:f0} minutes");