namespace IntroToENUMS
{
    enum Days
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }
    enum CardValue
    {
        two=2,three=3,four=4,five=5,six=6,seven=7,eight=8,nine,ten,
        Jack,Queen,King,Ace
    }
    enum Suit
    {
        Heart,Diamond,Club,Spade
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          /*  Console.Write("Enter day no. (0-6)");
            int dayNum=int.Parse(Console.ReadLine());
            Days day = (Days)dayNum;
            Console.WriteLine(day);*/
          Random rnd=new Random();
            CardValue cardValue =(CardValue) rnd.Next(2, 15);
            Suit suit = (Suit) rnd.Next(4);
            Console.WriteLine(cardValue + " of " + suit);


        }
    }
}
