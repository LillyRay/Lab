using Lab1_1;

class Program
{
    static void Main()
    {
        Rectangle rec = new Rectangle();
        rec.Set_a(rec.Input(1));
        rec.Set_b(rec.Input(2));
        rec.Result(rec.Get_a(), rec.Get_b());
    
    }

   
}

