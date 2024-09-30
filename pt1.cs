using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Grade_Problem_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string grade = "";
            int mark = 0;

            int GRADE1MARK = 2;
            int GRADE2MARK = 4;
            int GRADE3MARK = 13;
            int GRADE4MARK = 22;
            int GRADE5MARK = 31;
            int GRADE6MARK = 41;
            int GRADE7MARK = 54;
            int GRADE8MARK = 67;
            int GRADE9MARK = 80;
            int marksNeeded = 0;

            Console.WriteLine("What mark did you get on your exam? ");
            mark = int.Parse(Console.ReadLine());

            if (mark < 2)
            {
                grade = "U";
                marksNeeded = GRADE1MARK - mark;
                Console.WriteLine("You got a grade {0} with a mark of {1} and you need {2} marks for the next grade", grade, mark, marksNeeded);
                Console.ReadLine();

            }
            if (mark < GRADE2MARK)
            {
                if (mark > GRADE1MARK)
                {
                    grade = "1";
                    marksNeeded = GRADE2MARK - mark;
                    Console.WriteLine("You got a grade {0} with a mark of {1} and you need {2} marks for the next grade", grade, mark, marksNeeded);
                    Console.ReadLine();
                }
            }
            if (mark < GRADE3MARK)
            {
                if (mark > GRADE2MARK)
                {
                    grade = "2";
                    marksNeeded = GRADE3MARK - mark;
                    Console.WriteLine("You got a grade {0} with a mark of {1} and you need {2} marks for the next grade", grade, mark, marksNeeded);
                    Console.ReadLine();
                }
                if (mark < GRADE4MARK)
                {
                    if (mark > GRADE3MARK)
                    {
                        grade = "3";
                        marksNeeded = GRADE4MARK - mark;
                        Console.WriteLine("You got a grade {0} with a mark of {1} and you need {2} marks for the next grade", grade, mark, marksNeeded);
                        Console.ReadLine();
                    }
                }
                if (mark < GRADE5MARK)
                {
                    if (mark > GRADE4MARK)
                    {
                        grade = "4";
                        marksNeeded = GRADE5MARK - mark;
                        Console.WriteLine("You got a grade {0} with a mark of {1} and you need {2} marks for the next grade", grade, mark, marksNeeded);
                        Console.ReadLine();
                    }

                }
                if (mark < GRADE6MARK)
                {
                    if (mark > GRADE5MARK)
                    {
                        grade = "5";
                        marksNeeded = GRADE6MARK - mark;
                        Console.WriteLine("You got a grade {0} with a mark of {1} and you need {2} marks for the next grade", grade, mark, marksNeeded);
                        Console.ReadLine();
                    }
                }
                if (mark < GRADE7MARK)
                {
                    if (mark > GRADE6MARK)
                    {
                        grade = "6";
                        marksNeeded = GRADE7MARK - mark;
                        Console.WriteLine("You got a grade {0} with a mark of {1} and you need {2} marks for the next grade", grade, mark, marksNeeded);
                        Console.ReadLine();
                    }
                }
                if (mark < GRADE8MARK)
                {
                    if (mark > GRADE7MARK)
                    {
                        grade = "7";
                        marksNeeded = GRADE8MARK - mark;
                        Console.WriteLine("You got a grade {0} with a mark of {1} and you need {2} marks for the next grade", grade, mark, marksNeeded);
                        Console.ReadLine();
                    }
                }
            }
            if (mark < GRADE9MARK)
            {
                if (mark > GRADE8MARK)
                {
                    grade = "8";
                    marksNeeded = GRADE9MARK - mark;
                    Console.WriteLine("You got a grade {0} with a mark of {1} and you need {2} marks for the next grade", grade, mark, marksNeeded);
                    Console.ReadLine();
                }
            }
            else
            {

                grade = "9";
                marksNeeded = GRADE9MARK - mark;
                Console.WriteLine("You got a grade {0} with a mark of {1} and you need {2} marks for the next grade", grade, mark, marksNeeded);
                Console.ReadLine();

            }
        }
    }
}
