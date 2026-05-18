using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quizgame.Data;

namespace quizgame.DataStructures
{
    internal class gamedata
    {
        private int numberofQuestions;
        private int numberofMathQuestions ;
        private int numberofGeoQuestions;
        private int numberofChemQuestions;
        private int numberofHistoryQuestions;
        private int minvaluofAnswer;
        private int maxvaluofAnswer;
        private string question;
        private int answer;

        public int NumberofQuestions { get { return numberofQuestions; } }
        public int NumberofMathQuestions { get { return numberofMathQuestions; } }
        public int NumberofGeoQuestions { get { return numberofGeoQuestions; } }
        public int NumberofChemQuestions { get { return numberofChemQuestions; } }
        public int NumberofHistoryQuestions { get { return numberofHistoryQuestions; } }

        public int MinvaluofAnswer { get { return minvaluofAnswer; } }
        public int MaxvaluofAnswer { get { return maxvaluofAnswer; }  }

        public string Question { get { return question; } set { question = value; } } 
        public int Answer { get { return answer; } set { answer = value; } } 

        public gamedata(int numberofQuestions,int numberofMathQuestions,int numberofGeoQuestions,int numberofChemQuestions,int numberofHistoryQuestions,int minvaluofAnswer,int maxvaluofAnswer)
        {
            this.numberofQuestions = numberofQuestions;
            this.numberofMathQuestions = numberofMathQuestions;
            this.numberofGeoQuestions = numberofGeoQuestions;
            this.numberofChemQuestions = numberofChemQuestions;
            this.numberofHistoryQuestions = numberofHistoryQuestions;
            this.minvaluofAnswer = minvaluofAnswer;
            this.maxvaluofAnswer = maxvaluofAnswer;
        }



























    }
}
