using System.Collections.Generic;
using System.Drawing;
namespace RafayM_ASSN03_TicTacToe
{
    class Player
    {
        public List<int> slots = new List<int>();
        public Image playerImage;
        private string playerName;
        public int NumOfWins;
        public Player(Image img, string name)
        {
            playerImage = img;
            playerName = name;
            NumOfWins = 0;
        }
        public void Reset()
        {
            slots.Clear();
        }
        public bool IsWinner()
        {
            for (int i = 0, x = 0; i < 7; i+=3,x++)
            {
                if (slots.Contains(1 + i) && slots.Contains(2 + i) && slots.Contains(3 + i)|| slots.Contains(1 + x) && slots.Contains(4 + x) && slots.Contains(7 + x) || slots.Contains(1) && slots.Contains(5) && slots.Contains(9) || slots.Contains(3) && slots.Contains(5) && slots.Contains(7))
                {
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            return playerName.ToUpper();
        }
    }
}
