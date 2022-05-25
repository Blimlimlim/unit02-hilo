using System;
using System.Collections.Generic;

namespace unit02_hilo
{
    public class Director
    {
        Card currentCard = new Card();
        Card nextCard = new Card();
        bool isPlaying = true;
        int score = 0;
        int totalScore = 300;
        bool isHigherGuess;
        bool isHigher;
        public Director()
        {
        }
        public void StartGame()
        {
            GameStepOne();
            
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        public void GameStepOne()
        {
            currentCard.Pull();
            nextCard.Pull();
            while (currentCard.value == nextCard.value)
            {
                nextCard.Pull();
            }
            Console.WriteLine($"Current card: {currentCard.value}");
            //Console.WriteLine($"Next card:    {nextCard.value}");
            Console.WriteLine($"Current Score {totalScore}");
        }

        public void GetInputs()
        {
            Console.Write("Do you want to keep playing? [y/n] ");
            string playAgain = Console.ReadLine();
            isPlaying = (playAgain == "y");
            Console.Write("Will the next card be higher or lower? [h/l]");
            string playerGuess = Console.ReadLine();
            isHigherGuess = (playerGuess == "h");
        }

        public void DoUpdates()
        {
            if (!isPlaying)
            {
                return;
            }
            score = 0;
            int difference = currentCard.value - nextCard.value;
            if (difference < 0)
            {
                isHigher = true;
            }
            else if (difference > 0)
            {
                isHigher = false;
            }
            if (isHigherGuess == isHigher)
            {
                score = 100;
            }
            else if (isHigherGuess != isHigher)
            {
                score = -75;
            }
            currentCard.value = nextCard.value;
            while (nextCard.value == currentCard.value)
            {
                nextCard.Pull();
            }
            
            totalScore += score;
        }
        public void DoOutputs()
        {
            if (!isPlaying)
            {
                return;
            }
            Console.WriteLine($"Current card: {currentCard.value}");
            //Console.WriteLine($"Next card:    {nextCard.value}");
            Console.WriteLine($"Current Score {totalScore}");
        }
        
    }
}