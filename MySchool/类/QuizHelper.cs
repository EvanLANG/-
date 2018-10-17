using System;
using System.Collections.Generic;
using System.Text;

namespace MySchool
{
    class QuizHelper
    {
        public static int totalSeconds = 1200; // 答题总时间20分钟
        public static int remainSeconds;       // 剩余的时间

        public static int subjectId = 0;       //记录考试科目
        public static bool showquittips = true;  //标记是否提示退出

        public static int[] allQuestionIds;    // 所有问题的Id数组
        public static int[] allQuestionIds2;
        public static int[] allQuestionIds3;
        public static bool[] selectedStates;   // 记录对应索引的问题是否已经被随机抽中
        public static bool[] selectedStates2;
        public static bool[] selectedStates3;
        public static int questionNum = 14;                        // 选择题题目数量
        public static int questionNum2 = 4;                      // 填空题题目数量
        public static int questionNum3 = 2;                        // 简答题题目数量
        public static int[] selectedQuestionIds = new int[14];     // 选出的问题Id数组  
        public static int[] selectedQuestionIds2 = new int[4];
        public static int[] selectedQuestionIds3 = new int[2];
        public static string[] correctAnswers = new string[14];    // 标准答案数组
        public static string[] correctAnswers2 = new string[4];
        public static string[] studentAnswers = new string[14];    // 学员的答案  
        public static string[] studentAnswers2 = new string[4];
        public static string[] studentAnswers3 = new string[2];
        
    }
}
