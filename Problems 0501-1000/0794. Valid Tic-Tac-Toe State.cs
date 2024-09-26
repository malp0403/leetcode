using leetcode.Problems_0501_1000._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Test Data
//var obj = new _0794() { };
//obj.ValidTicTacToe(new string[] { "XXX", "OOX", "OOX" });
//obj.ValidTicTacToe(new string[] { "XXX", "XOO", "OO " });
#endregion

namespace leetcode.Problems_0501_1000._0751_0800
{
    internal class _0794
    {
        #region 09/18/2023  1. ocount vs xcount 2. ovalid vs xvalid 3. if x win, check count; 3. if o win, check count
        public bool ValidTicTacToe_20230918(string[] board)
        {
            int xCount = 0;
            int oCount = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i][j] == 'O') { oCount++; }
                    if (board[i][j] == 'X') { xCount++; }
                }

            }

            if (oCount > xCount || (int)Math.Abs(oCount - xCount) > 1) return false;

            int oValid = 0;
            int xValid = 0;
            //valid row
            for (int i = 0; i < 3; i++)
            {
                if (board[i][0] == board[i][1] && board[i][1] == board[i][2])
                {
                    if (board[i][0] == 'O') oValid++;
                    if (board[i][0] == 'X') xValid++;

                }

            }
            //valid col
            for (int i = 0; i < 3; i++)
            {
                if (board[0][i] == board[1][i] && board[1][i] == board[2][i])
                {
                    if (board[0][i] == 'O') oValid++;
                    if (board[0][i] == 'X') xValid++;
                }
            }
        
            if (board[1][1] != ' ')
            {

                if (board[0][0] == board[1][1] && board[1][1] == board[2][2])
                {
                    if (board[1][1] == 'O') oValid++;
                    if (board[1][1] == 'X') xValid++;
                };
                if (board[0][2] == board[1][1] && board[1][1] == board[2][0])
                {
                    if (board[1][1] == 'O') oValid++;
                    if (board[1][1] == 'X') xValid++;
                };
     
            }

            if (oValid > 0 && xValid > 0) return false;
            //if x win
            if(xValid > 0)
            {
                //ocount must less than xcount
                return xCount > oCount ? true : false;
            }
            //if o win
            if(oValid > 0)
            {
                //ocount must equal to xcount;
                return oCount == xCount;
            }
            return true;









            #endregion
        }
    }
}
