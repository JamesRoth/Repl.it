/* James Roth - 5/20/19 - GPACalculator.cs - calculating GPA */

using System;

namespace GPACalculatorApp {
  class GPACalculator {
    static void Main(string[] args) {

      int classes;
      double GPA = 0;
      string grade;
      string honors;
      string yesno;

      Console.WriteLine("How many classes will you enter?");
      classes = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Should I ask about honors? (Y/N)");
      honors = Console.ReadLine();

      for (int i = 0; i < classes; i++)
      {
        Console.WriteLine("Enter your grade(A+, A, A-, etc): ");
        grade = Console.ReadLine();

        if (grade == "A+" || grade == "A")
        {
          if (honors == "Y")
          {
            Console.WriteLine("Was this an Honors class? (Y/N)");
            yesno = Console.ReadLine();
            if (yesno == "Y")
            {
              GPA += 4.5;
            }
            else
            {
              GPA += 4;
            }
          }
          else
          {
            GPA += 4;
          }
        }

        else if (grade == "A-")
        {
          if (honors == "Y")
          {
            Console.WriteLine("Was this an Honors class? (Y/N)");
            yesno = Console.ReadLine();
            if (yesno == "Y")
            {
              GPA += 4.2;
            }
            else
            {
              GPA += 3.7;
            }
          }
          else
          {
            GPA += 3.7;
          };
        }

        else if (grade == "B+")
        {
          if (honors == "Y")
          {
            Console.WriteLine("Was this an Honors class? (Y/N)");
            yesno = Console.ReadLine();
            if (yesno == "Y")
            {
              GPA += 3.8;
            }
            else
            {
              GPA += 3.3;
            }
          }
          else
          {
            GPA += 3.3;
          }
        }

        else if (grade == "B")
        {
          if (honors == "Y")
          {
            Console.WriteLine("Was this an Honors class? (Y/N)");
            yesno = Console.ReadLine();
            if (yesno == "Y")
            {
              GPA += 3.5;
            }
            else
            {
              GPA += 3;
            }
          }
          else
          {
            GPA += 3;
          }
        }

        else if (grade == "B-")
        {
         if (honors == "Y")
          {
            Console.WriteLine("Was this an Honors class? (Y/N)");
            yesno = Console.ReadLine();
            if (yesno == "Y")
            {
              GPA += 3.2;
            }
            else
            {
              GPA += 2.7;
            }
          }
          else
          {
            GPA += 2.7;
          }
        }

        else if (grade == "C+")
        {
          if (honors == "Y")
          {
            Console.WriteLine("Was this an Honors class? (Y/N)");
            yesno = Console.ReadLine();
            if (yesno == "Y")
            {
              GPA += 2.8;
            }
            else
            {
              GPA += 2.3;
            }
          }
          else
          {
            GPA += 2.3;
          };
        }

        else if (grade == "C")
        {
          if (honors == "Y")
          {
            Console.WriteLine("Was this an Honors class? (Y/N)");
            yesno = Console.ReadLine();
            if (yesno == "Y")
            {
              GPA += 2;
            }
            else
            {
              GPA += 2.5;
            }
          }
          else
          {
            GPA += 2;
          }
        }

        else if (grade == "C-")
        {
          if (honors == "Y")
          {
            Console.WriteLine("Was this an Honors class? (Y/N)");
            yesno = Console.ReadLine();
            if (yesno == "Y")
            {
              GPA += 2.2;
            }
            else
            {
              GPA += 1.7;
            }
          }
          else
          {
            GPA += 1.7;
          }
        }

        else if (grade == "D+")
        {
          if (honors == "Y")
          {
            Console.WriteLine("Was this an Honors class? (Y/N)");
            yesno = Console.ReadLine();
            if (yesno == "Y")
            {
              GPA += 1.8;
            }
            else
            {
              GPA += 1.3;
            }
          }
          else
          {
            GPA += 1.3;
          };
        }

        else if (grade == "D")
        {
         if (honors == "Y")
          {
            Console.WriteLine("Was this an Honors class? (Y/N)");
            yesno = Console.ReadLine();
            if (yesno == "Y")
            {
              GPA += 1.5;
            }
            else
            {
              GPA += 1;
            }
          }
          else
          {
            GPA += 1;
          }
        }
        else if (grade == "D-")
        {
         if (honors == "Y")
          {
            Console.WriteLine("Was this an Honors class? (Y/N)");
            yesno = Console.ReadLine();
            if (yesno == "Y")
            {
              GPA += 1.2;
            }
            else
            {
              GPA += 0.7;
            }
          }
          else
          {
            GPA += 0.7;
          }
        }

        else
        {
          GPA += 0;
        }

      }
      Console.WriteLine("Your GPA is: " + GPA/classes);
    }
  }
}

