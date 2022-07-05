internal class Program
{
    private static void Main(string[] args)
    {
        // Variables
        int age = 23;
        string name = "Fırat";
        decimal price = 15.99M;
        bool isActive = true;

        // Root
        object test = "test";
        test = 25;
        Console.WriteLine(test);

        int price2 = 15;
        price2 *= 10;
        price2 += 10; //  eşdeğeri : price2 = price2 + 10;
        price2 -= 10;  //  eşdeğeri : price2 = price2 - 10;
        price2++;   //  eşdeğeri : price2 = price2 + 1; || price2 += 1;
        price2--;   //  eşdeğeri : price2 = price2 - 1; || price2 -= 1;

        //Conditions
        int a = 2;
        int b = 0;

        if(b > a){
            Console.WriteLine("b büyük a");
        }else if (b == a){
            Console.WriteLine("b eşit a");
        }else {
            Console.WriteLine("b küçük a");
        }

        int weeksDay = 5;
        switch(weeksDay){
            case 1:
                Console.WriteLine("Pazartesi");
                break;
            case 2:
                Console.WriteLine("Salı");
                break;
            case 3:
                Console.WriteLine("Çarşamba");
                break;
            case 4:
                Console.WriteLine("Perşembe");
                break;
            case 5:
                Console.WriteLine("Cuma");
                break;
            case 6:
                Console.WriteLine("Cumartesi");
                break;
            case 7:
                Console.WriteLine("Pazar");
                break;

            default:
                break;
        }

        //Loops
        for(int i = 0; i < 10; i++){
            Console.Write(i+" ");
        }
        Console.WriteLine();

        // Örnek : 30.07.2022 - 05.08.2022 tarihler arası iş günü izin hesaplama.
        DateTime dtStart =  new DateTime(2022, 7, 30);
        DateTime dtEnd =  new DateTime(2022, 8, 5);
        int totalDays = 0;

        for(DateTime date = dtStart; date <= dtEnd; date = date.AddDays(1)){
            if(date.DayOfWeek != DayOfWeek.Saturday 
            && date.DayOfWeek != DayOfWeek.Sunday){
                totalDays++;
                Console.WriteLine(date.Date+" günü izin kullanabilirsiniz.");
            }
        }
        Console.WriteLine("Hafta sonu hariç izinli gün sayısı: "+ totalDays);

        //Örnek için ikinci yöntem :
        //TimeSpan iki tarih arasundaki zaman aralığını bulur.
        //Fakat örnek için tam olarak bir çözüm değildir (hafta sonlarını da sayar.)
        TimeSpan days = dtEnd - dtStart;
        Console.WriteLine("TimeSpan izinli gün sayısı: "+ days.TotalDays);

        char ch = 'A';
        for(char i = ch; i<'Z'; i++){
            if(i == 'K' || i == 'L') continue;
            if(i == 'R') break;
            Console.Write(i+ " ");
        }
        Console.WriteLine();

        int x = 0;
        //!koşul başta
        while(x < 5){
            Console.Write(x);
            x++;
        }
        Console.WriteLine();

        do{
            Console.Write(x);
            x++;
        }while(x <= 10); //!koşul sonda en az 1 kez çalışır.
        Console.WriteLine();
        
        string[] lstStajyer = {"Hikmet", "Fırat", "Şeymanur", "Oruçhan"};
        foreach(var item in lstStajyer){
            Console.WriteLine(item);
        }

        //Arrays and Collections
        int[] sayilar = new int[4] { 1, 2, 3, 4 };
        List<int> lstAge = new List<int>();
        lstAge.Add(23);
        lstAge.Add(30);
        lstAge.Add(40);
        lstAge.Add(50);
        lstAge.Remove(50);

        List<Student> lstStudents = new List<Student>();
        Student firat = new Student();
        firat.name = "Fırat";
        firat.surName = "Şakar";
        firat.number = 1;
        firat.identityNumber = "11110000";

        lstStudents.Add(firat);
        
        Student testStudent = new Student();
        testStudent.name = "test";
        testStudent.surName = "tester";
        testStudent.number = 2;
        testStudent.identityNumber = "999999999";

        lstStudents.Add(testStudent);
        //lstStudent listesinki student nesnelerinden numberı 2 olan ilk öğeyi getirir.
        //Eğer numberı 2 olan yoksa null döner.
        var student = lstStudents.Where(p => p.number == 2).FirstOrDefault();

        if(student != null){
            Console.WriteLine(student.name + " " + student.surName + " hoşgeldiniz.");
        }
        else{
            Console.WriteLine("Öğrenci kaydınız bulunamadı!");
        }

    }
    public class Student{
            public string name { get; set; }
            public string surName { get; set; }
            public int number { get; set; }
            public string identityNumber { get; set; }
            
            
        }
}