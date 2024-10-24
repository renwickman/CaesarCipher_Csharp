using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      
      Console.WriteLine("Enter your secret message: ");
      string message = Console.ReadLine();
      message = message.ToLower();

      char[] secretMessage = message.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];

      Console.WriteLine(secretMessage.Length);
      Console.WriteLine(encryptedMessage.Length);

      for (int i = 0; i < secretMessage.Length; i++){
        char ltr = secretMessage[i];
        int position = Array.IndexOf(alphabet, ltr);
        int newPosition = (position + 3) % alphabet.Length;
        char newLtr = alphabet[newPosition];
        encryptedMessage[i] = newLtr;
      }
      string msgString = String.Join("", encryptedMessage);
      Console.WriteLine(msgString);
      
    }
  }
}