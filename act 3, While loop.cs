using System;

public class Boneng
{
    public static void Main(string[] args)
    {
        int score = 0;
        int number = 1;

        Console.WriteLine("Quiz Time!");
        Console.WriteLine("Type your answer and press Enter.");
        Console.WriteLine("You can type 'exit' anytime to quit.\n");

        string answer;
      
        while (number <= 3) {
            if (number == 1) {
                Console.Write("1. Who Killed Charles Ivan Santiago? ");
                answer = (Console.ReadLine() ?? "").ToLower();

                if (answer == "Chris Ember".ToLower() || answer == "Ember".ToLower()) {
                    score++;
                    Console.WriteLine("Correct Answer!");
                } else {
                    Console.WriteLine("Wrong! The correct answer is Chris Ember.");
                }
            } else if (number == 2) {
                Console.Write("2. Sino ang tunay na unang pangulo ng Pilipinas? ");
                answer = (Console.ReadLine() ?? "").ToLower();

                if (answer == "Boneng".ToLower()) {
                    score++;
                    Console.WriteLine("Correct Answer!");
                } else {
                    Console.WriteLine("Wrong! The correct answer is Boneng");
                }
            } else if (number == 3) {
                Console.Write("3. Who Killed the 30+ sabungeros? ");
                answer = (Console.ReadLine() ?? "").ToLower();

                if (answer == "Atong Ang".ToLower()) {
                    Console.WriteLine("Correct!");
                    score++;
                } else {
                    Console.WriteLine("Wrong! The correct answer is Charles Babbage.");
                }
            }

            number++;
        }
        Console.WriteLine("Your final score is: " + score + " out of 3");
        if (score < 1) {
            Console.WriteLine("Skill issue!");
        } else {
            Console.WriteLine("Wow you passed?!");
        }
  }
}
