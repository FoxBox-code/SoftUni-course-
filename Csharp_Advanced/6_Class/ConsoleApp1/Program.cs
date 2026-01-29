
using ConsoleApp1;

Student mainCharachter = new Student()
{
    FistName = "Dante",
    LastName = "Sparda",
    age = 24,
    grade = 6



};
Student brother = new Student();

brother.FistName = "Vergil";
brother.LastName = "Spadra";
brother.age = mainCharachter.age;
brother.grade = 6.6;                                        //Another way of writting 



Charachter(mainCharachter);


static void Charachter(Student charachter)
{
    Console.WriteLine($"Fist name {charachter.FistName} Father's name {charachter.LastName} age {charachter.age} style {charachter.grade}");
}
//This is how we define and display classes



Charachter(brother);