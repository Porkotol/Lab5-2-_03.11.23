
interface Iparent
{
    string Info();
    double Metod();
}
class Child1 : Iparent
{
    public double pole1; /////pole1-швидкість;
    public double pole2; /////pole2-висота польоту;/
    public double pole3; /////pole3-вартість;
    public Child1(double pole1, double pole2)
    {
        this.pole1 = pole1; this.pole2 = pole2; 
    }
    public string Info()
    {
        return $" Пасажирський лiтак: \n Швидкiсть = {pole1}, Висота польоту = {pole2}, Вартiсть = {pole3}";
    }
    public double Metod()
    {
        pole3 = pole1 * 1000 + pole2 * 100;
        return pole3;
    }
}
class Child2 : Iparent
{
    public double pole1;
    public double pole2;
    public double pole3;

    public Child2(double pole1, double pole2)
    {
        this.pole1 = pole1; this.pole2 = pole2;
    }
    public string Info()
    {
        return $" Винищувач: \n Швидкiсть = {pole1}, Висота польоту = {pole2}, Вартiсть = {pole3}";
    }
    public double Metod()
    {
        pole3 = pole1 * 3000 + pole2 * 200;
        return pole3;
    }
}
class Child3 : Iparent
{
    public double pole1;
    public double pole2;
    public double pole3;
    public int pole4;
    public Child3(double pole1, double pole2, int pole4)
    {
        this.pole1 = pole1; this.pole2 = pole2; this.pole4 = pole4;
    }
    public string Info()
    {
        return $" Бомбардувальник: \n Швидкiсть = {pole1}, Висота польоту = {pole2}, Кiлькiсть бомб = {pole4}, Вартiсть = {pole3}";
    }
    public double Metod()
    {
        pole3 = pole1 * 1500 + pole2 * 150 + pole4 * 50;
        return pole3;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        Iparent plane = null;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");
            int planetp = rand.Next(3); 
            double speed = rand.Next(200, 1000); 
            double vis = rand.Next(8000, 12000);
            int bomb = rand.Next(1, 5);
            switch (planetp)
            {
                case 0:
                    plane = new Child1(speed, vis);
                    break;
                case 1:
                    plane = new Child2(speed, vis);
                    break;
                case 2:
                    plane = new Child3(speed, vis, bomb);
                    break;
            }
            double cost = plane.Metod();
            Console.WriteLine(plane.Info()); 
        }
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");
    }
}