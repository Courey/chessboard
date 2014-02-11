using System;
using System.IO;

public class chessboard
{
   public static void Main(string[] args)
   {
      char[,] board = new char[8, 17];
      StreamReader input = new StreamReader("C:\\temp\\board.txt");
      char temp;

      while (input.Peek() >= 0)    
      {
         char c = '-';
         for (int i = 0; i < 8; i++)
         {
            for (int x = 0; x < 17; x++)
            {
               try
               {
                  c = Convert.ToChar(input.Read());
               }
               catch
               {
                  break;
               }
               if (c == ' ')
               {
                  board[i, x] = ' ';
               }
               board[i, x] = Convert.ToChar(c);
            } // end for loop
         } // end read file   
      } // end while statement
      input.Close();

      temp = board[1, 0];
      board[1, 0] = board[3, 0];
      board[3, 0] = temp;
      temp = board[6, 0];
      board[6, 0] = board[4, 0];
      board[4, 0] = temp;

        for (int i = 0; i < 8; i++)
      {
         for (int x = 0; x < 17; x++)
         { 
            Console.Write("{0,1}", board[i,x]);
         }
         Console.WriteLine();
      } 
      Console.ReadLine();
   } // end main
}// end class chessboard
