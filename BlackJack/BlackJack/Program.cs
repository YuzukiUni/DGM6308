using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomCards = new Random();
            List<string> deck = new List<string> { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            int playerPoints = 0, computerPoints = 0;
            int playerCoins = 100, computerCoins = 100;
            int round = 0;
            while (true)
            {
                round++;
                int betLimit;
                if (round < 3)
                {
                    betLimit = 5;
                }
                else if (round < 6)
                {
                    betLimit = 10;
                }
                else
                {
                    betLimit = 20;
                }

                int playerBet = betLimit;
                int computerBet = betLimit;

                if (playerBet > playerCoins)
                {
                    Console.WriteLine("You don't have enough coins. Your bet is set to " + playerCoins);
                    playerBet = playerCoins;
                }
                if (computerBet > computerCoins)
                {
                    Console.WriteLine("Computer doesn't have enough coins. Its bet is set to " + computerCoins);
                    computerBet = computerCoins;
                }

                Console.WriteLine("Your bet is " + playerBet);
                Console.WriteLine("Computer's bet is " + computerBet);

                int playerTotal = 0, dealerTotal = 0;
                playerTotal += DrawCard(deck, randomCards, "You");
                dealerTotal += DrawCard(deck, randomCards, "Computer");
                playerTotal += DrawCard(deck, randomCards, "You");
                dealerTotal += DrawCard(deck, randomCards, "Computer");

                Console.WriteLine("Your total is " + playerTotal);

                while (playerTotal < 21)
                {
                    if (playerTotal > 21)
                    {
                        Console.WriteLine("Your total is now " + playerTotal);
                        break;
                    }
                    Console.Write("Press 'D' to draw another card, 'B' to add to your bet, or 'H' to stop: ");
                    var key = Console.ReadKey(true).Key;

                    if (key == ConsoleKey.B)
                    {
                        Console.Write("Enter your additional bet (limit " + betLimit + "): ");
                        int additionalBet = int.Parse(Console.ReadLine());

                        if (additionalBet > betLimit || additionalBet > playerCoins - playerBet)
                        {
                            Console.WriteLine("Invalid bet. Your additional bet is set to " + Math.Min(betLimit, playerCoins - playerBet));
                            additionalBet = Math.Min(betLimit, playerCoins - playerBet);
                        }

                        playerBet += additionalBet;
                    }
                    if (key == ConsoleKey.D)
                    {
                        playerTotal += DrawCard(deck, randomCards, "You");
                        Console.WriteLine("Your total is now " + playerTotal);
                        if (playerTotal > 21)
                        {
                            Console.WriteLine("You busted.");
                            break;
                        }
                        dealerTotal += DrawCard(deck, randomCards, "Computer");
                        Console.WriteLine("The dealer's total is now " + dealerTotal);
                    }
                    else if (key == ConsoleKey.H)
                    {
                        break;
                    }
                }

                // Check for busts after all drawing is done
                if (playerTotal > 21)
                {
                    Console.WriteLine("You busted. Computer gets the bet.");
                    playerCoins -= playerBet;
                    computerCoins += playerBet;
                    computerPoints += 10;
                }
                else if (dealerTotal > 21)
                {
                    Console.WriteLine("Dealer busted. You get the bet!");
                    playerCoins += computerBet;
                    computerCoins -= computerBet;
                    playerPoints += 10;
                }
                else if (playerTotal > dealerTotal)
                {
                    Console.WriteLine("You win this round! You get the bet!");
                    playerCoins += computerBet;
                    computerCoins -= computerBet;
                    playerPoints += 10;
                }
                else
                {
                    Console.WriteLine("Computer wins this round! Computer gets the bet.");
                    playerCoins -= playerBet;
                    computerCoins += playerBet;
                    computerPoints += 10;
                }

                Console.WriteLine($"Score: You - {playerPoints}, Computer - {computerPoints}");
                Console.WriteLine($"Coins: You - {playerCoins}, Computer - {computerCoins}");

                if (playerPoints >= 100 || computerCoins <= 0)
                {
                    Console.WriteLine(" You reached 100 points first. You won the game!");
                    break;
                }
                else if (computerPoints >= 100 || playerCoins <= 0)
                {
                    Console.WriteLine("The computer reached 100 points first. You lost the game.");
                    break;
                }
            }
        }

        static int DrawCard(List<string> deck, Random rand, string player)
        {
            string card = deck[rand.Next(deck.Count)];

            Console.WriteLine(player + " drew a " + card);

            if (card == "A")
            {
                return 11;
            }
            else if (card == "K" || card == "Q" || card == "J")
            {
                return 10;
            }
            else
            {
                return int.Parse(card);
            }
        }
    }
}