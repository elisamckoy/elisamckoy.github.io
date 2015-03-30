using System;

namespace BoggleBoardChallenge
{
    public class BoggleBoard
    {
        private string[][] boggle_board = {
             new[] {"b", "r", "a", "e"},
             new[] {"i", "o", "d", "t"},
             new[] {"e", "c", "l", "r"},
             new[] {"t", "a", "k", "e"}
        };

        public string CreateWord(int[][] coords)
        {
            string returnString = "";
            foreach (int[] letter in coords)
            {
                int x = letter[0];
                int y = letter[1];
                returnString += boggle_board[x][y];
            }
            return returnString;
        }
    }
}
