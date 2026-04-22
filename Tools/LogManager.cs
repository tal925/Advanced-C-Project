using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class LogManager
    {

        // 1. הגדרת נתיב קבוע לתיקיית הלוגים (סעיף 4 בדף)
        static string LogDirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");

        private static void EnsureDirectoryExists()
        {
            // בדיקה ויצירה של התיקייה הראשית (סעיף 8 בדף)
            if (!Directory.Exists(LogDirPath))
            {
                Directory.CreateDirectory(LogDirPath);
            }
        }

        // 2. פונקציית הכתיבה המרכזית (סעיף 7 בדף)
        public static void WriteToLog(string project, string funcName, string message)
        {
            EnsureDirectoryExists();

            // יצירת שם קובץ לפי חודש (סעיף 6 בדף)
            string fileName = $"Log_{DateTime.Now:MM_yyyy}.txt";
            string filePath = Path.Combine(LogDirPath, fileName);

            // בניית שורת הלוג עם טאבים (\t) כפי שהתבקש
            string logLine = $"{DateTime.Now}\t{project}\t{funcName}:\t{message}";

            // כתיבה לקובץ - true אומר שזה מוסיף לסוף הקובץ ולא דורס
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(logLine);
            }
        }
        public static void CleanOldLogs()
        {
            // בדיקה אם התיקייה בכלל קיימת לפני שמתחילים
            if (!Directory.Exists(LogDirPath)) return;

            // קבלת רשימה של כל הקבצים בתיקייה
            string[] files = Directory.GetFiles(LogDirPath);

            // הגדרת תאריך היעד (חודשיים אחורה מהיום)
            DateTime threshold = DateTime.Now.AddMonths(-2);

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);

                // אם הקובץ נוצר לפני תאריך היעד - מוחקים אותו
                if (fileInfo.CreationTime < threshold)
                {
                    try
                    {
                        fileInfo.Delete();
                    }
                    catch
                    {
                        // אם הקובץ פתוח כרגע בתוכנית אחרת, נתעלם מהשגיאה ונמשיך
                    }
                }
            }
        }

        // פונקציית עזר לתחילת פונקציה
        public static void WriteStart(string project, string methodName, string message = "")
        {
            WriteToLog(project, methodName, $"Started. {message}");
        }

        // פונקציית עזר לסיום פונקציה
        public static void WriteEnd(string project, string methodName, string message = "")
        {
            WriteToLog(project, methodName, $"Ended. {message}");
        }
    }

}

