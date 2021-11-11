using System;
using System.Collections.Generic;
using System.Text;

namespace connectFour
{
    class Game
    {
        public enum GameTurn
        {
            First,
            Second,
        }
        public static bool isPlayerFirstTurn = true;
        public static bool isPlayerCurrentTurn = true;
        public static bool isGameStarted = false;
        public static bool isGameOver = false;
        public static bool isGameTie = false;
        public static bool isPlayerWin;
        private static Game.GameTurn botTurn;
        private static Game.GameTurn humTurn;

        public static String[,] state = { 
            { "", "", "", "", "", "", },
            { "", "", "", "", "", "", },
            { "", "", "", "", "", "", },
            { "", "", "", "", "", "", },
            { "", "", "", "", "", "", },
            { "", "", "", "", "", "", },
            { "", "", "", "", "", "", },
        };

        public static void Init()
        {
            String [,] initState = {
            { "", "", "", "", "", "", },
            { "", "", "", "", "", "", },
            { "", "", "", "", "", "", },
            { "", "", "", "", "", "", },
            { "", "", "", "", "", "", },
            { "", "", "", "", "", "", },
            { "", "", "", "", "", "", },
            };
            state = initState;
            isPlayerFirstTurn = true;
            isPlayerCurrentTurn = true;
            isGameStarted = false;
            isGameOver = false;
            isPlayerWin = new bool();
            isGameTie = false;
        }

        public static String convertTurnToString(GameTurn turn)
        {
            string result = turn switch
            {
                GameTurn.First => "x",
                GameTurn.Second => "o",
                _ => "",
            };
            return result;
        }

        public static List<int> availableCols(String[,] state)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < 7; i++)
            {
                if (state[i, 0] == "")
                    result.Add(i);
            }
            return result;
        }

        private static int findTopIndex(int colId)
        {
            for (int i = 5; i >= 0; i--)
            {
               if ((state[colId, i]==""))
               {
                    return i;
               }
            }
            throw new ArgumentException("not available column");
        }
        
        public static void doStep(int colId)
        {
            if (Game.isPlayerFirstTurn)
            {
                humTurn = Game.GameTurn.First;
                botTurn = Game.GameTurn.Second;
            }
            else
            {
                humTurn = Game.GameTurn.Second;
                botTurn = Game.GameTurn.First;
            }
            if (!isPlayerCurrentTurn)
                return;

            if (!availableCols(state).Contains(colId))
                return;

            int i = findTopIndex(colId);
            
            if (isPlayerFirstTurn)
            {
                state[colId, i] = convertTurnToString(GameTurn.First);
            } else
            {
                state[colId, i] = convertTurnToString(GameTurn.Second);
            }

            isPlayerCurrentTurn = false;
            if (Game.checkWin(Game.state) == Game.convertTurnToString(botTurn))
            {
                Game.isGameOver = true;
                Game.isPlayerWin = false;
                Game.isGameTie = false;
            }

            if (Game.checkWin(Game.state) == Game.convertTurnToString(humTurn))
            {
                Game.isGameOver = true;
                Game.isPlayerWin = true;
                Game.isGameTie = false;

            }

            if (Game.checkWin(Game.state) == "tie")
            {
                Game.isGameOver = true;
                Game.isGameTie = true;
            }
        }
        private static bool equals4(String a,String b,String c,String d)
        {
            return a != "" && a == b && b == c && c == d;
        }
        /// <summary>
        /// '' - none
        /// 'x' - first winner
        /// 'o' - second winner
        /// 'tie' - tie
        /// </summary>
        /// <param name="state"></param>
        /// <param name="firstTurn"></param>
        /// <returns></returns>
        public static String checkWin(String [,] state)
        {
            //horizontal
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (equals4(state[j, i], state[j + 1, i], state[j + 2, i], state[j + 3, i]))
                        return state[j, i];
                }
            }

            //vertical
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (equals4(state[i,j], state[i, j + 1], state[i, j + 2], state[i, j + 3]))
                        return state[i,j];
                }
            }

            //diagonal-right-angle
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (equals4(state[i,3+j], state[i+1,2+j], state[i+2,1+j], state[i+3,j]))
                        return state[i,3 + j];
                }
            }

            //diagonal-left-angle
            for (int i = 6; i > 2; i--)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (equals4(state[i, 3 + j], state[i - 1, 2 + j], state[i - 2, 1 + j], state[i - 3, j]))
                        return state[i, 3 + j];
                }
            }

            if (availableCols(state).Count==0)
                return "tie";

            return "";
            
        }

    }
}
