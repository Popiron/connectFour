using System;
using System.Collections.Generic;
using System.Text;

namespace connectFour
{
    class Bot
    {
        private static Game.GameTurn botTurn;
        private static Game.GameTurn humTurn;
        private static Dictionary<String[,],int> generateSuccessors(String[,] state,Game.GameTurn turn)
        {
            Dictionary<String[,],int> succs = new Dictionary<String[,], int>();
            foreach (int col in Game.availableCols(state))
            {
                succs[doStep(col, state, turn)] = col;
            } 
            return succs;
        }

        private static String[,] doStep(int colId,String[,] state, Game.GameTurn turn)
        {
            String[,] newState = (String [,])state.Clone();
            int i = findTopIndex(colId, newState);

            if (Game.isPlayerFirstTurn)
            {
                newState[colId, i] = Game.convertTurnToString(turn);
            }
            else
            {
                newState[colId, i] = Game.convertTurnToString(turn);
            }

            return newState;

        }

        private static int findTopIndex(int colId, String[,] state)
        {
            for (int i = 5; i >= 0; i--)
            {
                if ((state[colId, i] == ""))
                {
                    return i;
                }
            }
            throw new ArgumentException("not available column");
        }
        public static void bestStep(String[,] state)
        {
            if (Game.isPlayerFirstTurn)
            {
                humTurn = Game.GameTurn.First;
                botTurn = Game.GameTurn.Second;
            } else
            {
                humTurn = Game.GameTurn.Second;
                botTurn = Game.GameTurn.First;
            }

            int bestScore = int.MinValue;
            int bestStep = 0;
            var sucs = generateSuccessors(state, botTurn);
            foreach (var s in sucs)
            {
                int score = MinMax(s.Key,0, false,int.MinValue,int.MaxValue);
                if (score > bestScore)
                {
                    bestScore = score;
                    bestStep = s.Value;
                }
            }

            Game.state = doStep(bestStep, state, botTurn);
            Game.isPlayerCurrentTurn = true;
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

        enum Scores
        {
            x = 1,
            o = -1,
            tie = 0,
        }

        private static int MinMax(String[,] state,int depth,bool isMaximizing, int alpha, int beta)
        {
            String result = Game.checkWin(state);
            if (result != "")
            {
                if (result == Game.convertTurnToString(botTurn))
                    return 1;
                if (result == Game.convertTurnToString(humTurn))
                    return -1;

                return 0;
            }

            if (depth > 7)
                return 0;

            if (isMaximizing)
            {
                int bestScore = int.MinValue;
                var sucs = generateSuccessors(state,botTurn);
                foreach (var s in sucs)
                {
                    
                      int score = MinMax(s.Key, depth + 1, false,alpha,beta);
                      bestScore = Math.Max(bestScore, score);
                    if (bestScore > alpha)
                        alpha = bestScore;
                    if (alpha >= beta)
                        break;
    
                }
                return bestScore;

            } else
            {
                int bestScore = int.MaxValue;
                var sucs = generateSuccessors(state,humTurn);
                foreach (var s in sucs)
                {
                    
                      int score = MinMax(s.Key, depth + 1, true, alpha, beta);
                      bestScore = Math.Min(bestScore, score);
                    if (bestScore < beta)
                        beta = bestScore;
                    if (alpha >= beta)
                        break;

                }

                return bestScore;
            }
        }
    }
}
