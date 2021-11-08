using System;

namespace MatricesMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var Matrices = new SolveMatrices();
            Matrices.MatricesMethod();

            Console.WriteLine("Thank you");
        }
    }
    
    public class SolveMatrices{
      int[,] matrixA2X2=new int[2,2];
      int[,] matrixB2X2=new int[2,2];
      int[,] matrix2X3=new int[2,3];
      int[,] matrix3X2=new int[3,2];
      int[,] matrixA3X3=new int[3,3];     
      int[,] matrixB3X3=new int[3,3];

        public  void MatricesMethod(){

      Console.WriteLine("This solution is designed for matrices of maximum length of 3 for rows and columns."+
          " and minimum length of 2" +
          "\n\n please enter the type of matrices you which to multiple.\n by picking the corresponding alphabet in small letter\n "+
          "a-(2x2)X(2x2)\n b-(2x3)X(3x2)\n c-(3x2)X(2x3)\n d-(3X3)X(3X3)\n "+
          "e-(2x3)X(3x3)\n f-(2x2)X(2x3)\n g-(3x3)X(3x2)\n h-(3x2)X(2x2)\n i-other");

       string choice=Console.ReadLine();

    switch(choice){
     case"a":  
               Console.WriteLine("Enter value for the first matrix first row ");
               matrixA2X2[0,0] = int.Parse( Console.ReadLine());
               matrixA2X2[0,1] = int.Parse(Console.ReadLine());
               Console.WriteLine("Enter value for the first matrix second row ");
               matrixA2X2[1,0] = int.Parse(Console.ReadLine());
               matrixA2X2[1,1] = int.Parse(Console.ReadLine()); 

               Console.WriteLine("Enter value for the second matrix first row");
               matrixB2X2[0,0] = int.Parse(Console.ReadLine());
               matrixB2X2[0,1] = int.Parse(Console.ReadLine()); 
               Console.WriteLine("Enter value for the second matrix second row");
               matrixB2X2[1,0] = int.Parse(Console.ReadLine());
               matrixB2X2[1,1] = int.Parse(Console.ReadLine());
 
                     int[,]  matrixTotal2X2A=new int[2,2];
            matrixTotal2X2A[0, 0] = (matrixA2X2[0, 0] * matrixB2X2[0, 0]) + (matrixA2X2[0, 1] * matrixB2X2[1, 0]);
            matrixTotal2X2A[0, 1] = (matrixA2X2[0, 0] * matrixB2X2[0, 1]) + (matrixA2X2[0, 1] * matrixB2X2[1, 1]);
            matrixTotal2X2A[1, 0] = (matrixA2X2[1, 0] * matrixB2X2[0, 0]) + (matrixA2X2[1, 1] * matrixB2X2[1, 0]);
            matrixTotal2X2A[1, 1] = (matrixA2X2[1, 0] * matrixB2X2[0, 1]) + (matrixA2X2[1, 1] * matrixB2X2[1, 1]);
                    Console.WriteLine("This is the total output of your matrices");
                    Console.WriteLine("It is a 2X2 matrix");
                    for (int i = 0; i < 2; i++) {
                        for (int j = 0; j < 2; j++)
                        { Console.WriteLine(matrixTotal2X2A[i,j]); }
                          Console.WriteLine("");
                          }
                    break;
    
       case"b":Console.WriteLine("Enter value for the first matrix first row ");
               matrix2X3[0,0] = int.Parse( Console.ReadLine());
               matrix2X3[0,1] = int.Parse(Console.ReadLine());
               matrix2X3[0,2] = int.Parse(Console.ReadLine());
               Console.WriteLine("Enter value for the first matrix second row ");
               matrix2X3[1,0] = int.Parse(Console.ReadLine());
               matrix2X3[1,1] = int.Parse(Console.ReadLine()); 
               matrix2X3[1,2] = int.Parse(Console.ReadLine()); 

               Console.WriteLine("Enter value for the second matrix first row");
               matrix3X2[0,0] = int.Parse(Console.ReadLine());
               matrix3X2[0,1] = int.Parse(Console.ReadLine()); 
               Console.WriteLine("Enter value for the second matrix second row");
               matrix3X2[1,0] = int.Parse(Console.ReadLine());
               matrix3X2[1,1] = int.Parse(Console.ReadLine()); 
               Console.WriteLine("Enter value for the second matrix third row");
               matrix3X2[2,0] = int.Parse(Console.ReadLine());
               matrix3X2[2,1] = int.Parse(Console.ReadLine());
                  
                    int[,]  matrixTotal2X2B=new int[2,2];
                    matrixTotal2X2B[0, 0] = (matrix2X3[0, 0] * matrix3X2[0, 0]) + (matrix2X3[0, 1] * matrix3X2[1, 0])+(matrix2X3[0, 2] * matrix3X2[2, 0]);
                    matrixTotal2X2B[0, 1] = (matrix2X3[0, 0] * matrix3X2[0, 1]) + (matrix2X3[0, 1] * matrix3X2[1, 1])+(matrix2X3[0, 2] * matrix3X2[2, 1]);
                    matrixTotal2X2B[1, 0] = (matrix2X3[1, 0] * matrix3X2[0, 0]) + (matrix2X3[1, 1] * matrix3X2[1, 0])+(matrix2X3[1, 2] * matrix3X2[2, 0]);
                    matrixTotal2X2B[1, 1] = (matrix2X3[1, 0] * matrix3X2[0, 1]) + (matrix2X3[1, 1] * matrix3X2[1, 1])+(matrix2X3[1, 2] * matrix3X2[2, 1]);

                    Console.WriteLine("This is the total output of your matrices");
                    Console.WriteLine("It is a 2X2 matrix");
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        { Console.WriteLine(matrixTotal2X2B[i, j]); }          //iterate and printout the matrices
                           Console.WriteLine("");
                    }
                    break;

                   

       case"c":
               Console.WriteLine("Enter value for the first matrix first row");
               matrix3X2[0,0] = int.Parse(Console.ReadLine());
               matrix3X2[0,1] = int.Parse(Console.ReadLine()); 
               Console.WriteLine("Enter value for the first matrix second row");
               matrix3X2[1,0] = int.Parse(Console.ReadLine());
               matrix3X2[1,1] = int.Parse(Console.ReadLine()); 
               Console.WriteLine("Enter value for the first matrix third row");
               matrix3X2[2,0] = int.Parse(Console.ReadLine());
               matrix3X2[2,1] = int.Parse(Console.ReadLine()); 

               Console.WriteLine("Enter value for the second matrix first row ");
               matrix2X3[0,0] = int.Parse( Console.ReadLine());
               matrix2X3[0,1] = int.Parse(Console.ReadLine());
               matrix2X3[0,2] = int.Parse(Console.ReadLine());
               Console.WriteLine("Enter value for the second matrix second row ");
               matrix2X3[1,0] = int.Parse(Console.ReadLine());
               matrix2X3[1,1] = int.Parse(Console.ReadLine()); 
               matrix2X3[1,2] = int.Parse(Console.ReadLine());
                  
                     int[,]  matrixTotal3X3A=new int[3,3];
            matrixTotal3X3A[0, 0] = (matrix2X3[0, 0] * matrix3X2[0, 0]) + (matrix2X3[1, 0] * matrix3X2[0, 1]);
            matrixTotal3X3A[0, 1] = (matrix2X3[0, 1] * matrix3X2[0, 0]) + (matrix2X3[1, 1] * matrix3X2[0, 1]);
            matrixTotal3X3A[0, 2] = (matrix2X3[0, 2] * matrix3X2[0, 0]) + (matrix2X3[1, 2] * matrix3X2[0, 1]);
            matrixTotal3X3A[1, 0] = (matrix2X3[0, 0] * matrix3X2[1, 0]) + (matrix2X3[1, 0] * matrix3X2[1, 1]);  
            matrixTotal3X3A[1, 1] = (matrix2X3[0, 1] * matrix3X2[1, 0]) + (matrix2X3[1, 1] * matrix3X2[1, 1]);
            matrixTotal3X3A[1, 2] = (matrix2X3[0, 2] * matrix3X2[1, 0]) + (matrix2X3[1, 2] * matrix3X2[1, 1]);
            matrixTotal3X3A[2, 0] = (matrix2X3[0, 0] * matrix3X2[2, 0]) + (matrix2X3[1, 0] * matrix3X2[2, 1]);
            matrixTotal3X3A[2, 1] = (matrix2X3[0, 1] * matrix3X2[2, 0]) + (matrix2X3[1, 1] * matrix3X2[2, 1]);
            matrixTotal3X3A[2, 2] = (matrix2X3[0, 2] * matrix3X2[2, 0]) + (matrix2X3[1, 2] * matrix3X2[2, 1]);
               Console.WriteLine("This is the total output of your matrices");
                    Console.WriteLine("It is a 3X3 matrix");
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        { Console.WriteLine(matrixTotal3X3A[i, j]); }
                              Console.WriteLine("");
                    }
                    break;

                   

      case"d": 
               Console.WriteLine("Enter value for the first matrix first row ");
               matrixA3X3[0,0] = int.Parse( Console.ReadLine());
               matrixA3X3[0,1] = int.Parse(Console.ReadLine());
               matrixA3X3[0,2] = int.Parse(Console.ReadLine());
               Console.WriteLine("Enter value for the first matrix second row ");
               matrixA3X3[1,0] = int.Parse(Console.ReadLine());
               matrixA3X3[1,1] = int.Parse(Console.ReadLine()); 
               matrixA3X3[1,2] = int.Parse(Console.ReadLine()); 
               Console.WriteLine("Enter value for the first matrix third row ");
               matrixA3X3[2,0] = int.Parse(Console.ReadLine());
               matrixA3X3[2,1] = int.Parse(Console.ReadLine()); 
               matrixA3X3[2,2] = int.Parse(Console.ReadLine()); 

               Console.WriteLine("Enter value for the second matrix first row ");
               matrixB3X3[0,0] = int.Parse( Console.ReadLine());
               matrixB3X3[0,1] = int.Parse(Console.ReadLine());
               matrixB3X3[0,2] = int.Parse(Console.ReadLine());
               Console.WriteLine("Enter value for the second matrix second row ");
               matrixB3X3[1,0] = int.Parse(Console.ReadLine());
               matrixB3X3[1,1] = int.Parse(Console.ReadLine()); 
               matrixB3X3[1,2] = int.Parse(Console.ReadLine()); 
               Console.WriteLine("Enter value for the second matrix third row ");
               matrixB3X3[2,0] = int.Parse(Console.ReadLine());
               matrixB3X3[2,1] = int.Parse(Console.ReadLine()); 
               matrixB3X3[2,2] = int.Parse(Console.ReadLine());
                    
                int[,]  matrixTotal3X3B=new int[3,3];
         matrixTotal3X3B[0, 0] = (matrixA3X3[0, 0] * matrixB3X3[0, 0]) + (matrixA3X3[0, 1] * matrixB3X3[0, 1]) + (matrixA3X3[0, 2] * matrixB3X3[0, 2]);
         matrixTotal3X3B[0, 1] = (matrixA3X3[0, 0] * matrixB3X3[1, 0]) + (matrixA3X3[0, 1] * matrixB3X3[1, 1]) + (matrixA3X3[0, 2] * matrixB3X3[1, 2]);
         matrixTotal3X3B[0, 2] = (matrixA3X3[0, 0] * matrixB3X3[2, 0]) + (matrixA3X3[0, 1] * matrixB3X3[2, 1]) + (matrixA3X3[0, 2] * matrixB3X3[2, 2]);
         matrixTotal3X3B[1, 0] = (matrixA3X3[1, 0] * matrixB3X3[0, 0]) + (matrixA3X3[1, 1] * matrixB3X3[0, 1]) + (matrixA3X3[1, 2] * matrixB3X3[0, 2]);  
         matrixTotal3X3B[1, 1] = (matrixA3X3[1, 0] * matrixB3X3[1, 0]) + (matrixA3X3[1, 1] * matrixB3X3[1, 1]) + (matrixA3X3[1, 2] * matrixB3X3[1, 2]);
         matrixTotal3X3B[1, 2] = (matrixA3X3[1, 0] * matrixB3X3[2, 0]) + (matrixA3X3[1, 1] * matrixB3X3[2, 1]) + (matrixA3X3[1, 2] * matrixB3X3[2, 2]);
         matrixTotal3X3B[2, 0] = (matrixA3X3[2, 0] * matrixB3X3[0, 0]) + (matrixA3X3[2, 1] * matrixB3X3[0, 1]) + (matrixA3X3[2, 2] * matrixB3X3[0, 2]);
         matrixTotal3X3B[2, 1] = (matrixA3X3[2, 0] * matrixB3X3[1, 0]) + (matrixA3X3[2, 1] * matrixB3X3[1, 1]) + (matrixA3X3[2, 2] * matrixB3X3[1, 2]);
         matrixTotal3X3B[2, 2] = (matrixA3X3[2, 0] * matrixB3X3[2, 0]) + (matrixA3X3[2, 1] * matrixB3X3[2, 1]) + (matrixA3X3[2, 2] * matrixB3X3[2, 2]);
             Console.WriteLine("This is the total output of your matrices");
                   Console.WriteLine("It is a 3X3 matrix");
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        { Console.WriteLine(matrixTotal3X3B[i, j]); }
                        Console.WriteLine("");
                    }

                    break;

       case "e": Console.WriteLine("Your matrices can be multiplied but not covered in this app\n Try picking from a-d");
                 Console.WriteLine("Your resulting would be a 2X3 matrix");

                    break;
       case "f":
                 Console.WriteLine("Your matrices can be multiplied but not covered in this app\n Try picking from a-d");
                 Console.WriteLine("Your resulting would be a 2X3 matrix");
                    break;

       case "g":
                 Console.WriteLine("Your matrices can be multiplied but not covered in this app\n Try picking from a-d");
                 Console.WriteLine("Your resulting would be a 3X2 matrix");
                    break;
       case "h":
                 Console.WriteLine("Your matrices can be multiplied but not covered in this app\n Try picking from a-d");
                 Console.WriteLine("Your resulting would be a 3X2 matrix");
                 break;
       case "i":
                    Console.WriteLine("Your matrices cannot be multiplied");
                        
                    break;

       default : Console.WriteLine("You have not entered a valid selection");
              break;
    }




  
    
            
    
    }
            

            

    }





        
}

