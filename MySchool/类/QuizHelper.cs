using System;
using System.Collections.Generic;
using System.Text;

namespace MySchool
{
    class QuizHelper
    {
        public static int totalSeconds = 1200; // ������ʱ��20����
        public static int remainSeconds;       // ʣ���ʱ��

        public static int subjectId = 0;       //��¼���Կ�Ŀ
        public static bool showquittips = true;  //����Ƿ���ʾ�˳�

        public static int[] allQuestionIds;    // ���������Id����
        public static int[] allQuestionIds2;
        public static int[] allQuestionIds3;
        public static bool[] selectedStates;   // ��¼��Ӧ�����������Ƿ��Ѿ����������
        public static bool[] selectedStates2;
        public static bool[] selectedStates3;
        public static int questionNum = 14;                        // ѡ������Ŀ����
        public static int questionNum2 = 4;                      // �������Ŀ����
        public static int questionNum3 = 2;                        // �������Ŀ����
        public static int[] selectedQuestionIds = new int[14];     // ѡ��������Id����  
        public static int[] selectedQuestionIds2 = new int[4];
        public static int[] selectedQuestionIds3 = new int[2];
        public static string[] correctAnswers = new string[14];    // ��׼������
        public static string[] correctAnswers2 = new string[4];
        public static string[] studentAnswers = new string[14];    // ѧԱ�Ĵ�  
        public static string[] studentAnswers2 = new string[4];
        public static string[] studentAnswers3 = new string[2];
        
    }
}
