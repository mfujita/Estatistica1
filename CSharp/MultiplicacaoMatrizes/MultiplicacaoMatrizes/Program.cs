/* 
https://www.blogcyberini.com/2017/09/algoritmo-multiplicacao-de-matrizes.html
Pseudocódigo da multiplicação de matrizes

multMatrix(Am × n, Bn × p)
    inicializar a matriz Cm × p
    para i ← 1 até m
        para j ← 1 até p
            para k ← 1 até n
                Cij ← Cij + Aik * Bkj
            fim_para
      fim_para
    fim_para
fim_multMatrix 
*/

int[,] mat1 = { { 3, 1 }, { 2, -1 }, { 0, 4 } };
int[,] mat2 = { { 1, -1, 2 }, { 3, 0, 5 } };
int[,] matResul = new int[mat1.GetLength(0), mat2.GetLength(1)];


int[,] MultiplicaMatriz()
{
    if (mat1.GetLength(1) == mat2.GetLength(0))
    {
        for (int i = 0; i < mat1.GetLength(0); i++)
        {
            for (int j = 0; j < mat2.GetLength(1); j++)
            {
                for (int k = 0; k < mat1.GetLength(1); k++)
                {
                    matResul[i, j] += mat1[i, k] * mat2[k, j];
                }
            }
        }
    }
    return matResul;
}

void ImprimeMatriz(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write("{0,3}", mat[i,j]);
        }
        Console.WriteLine();
    }
}

MultiplicaMatriz();
Console.WriteLine("Matriz A");
ImprimeMatriz(mat1);
Console.WriteLine("Matriz B");
ImprimeMatriz(mat2);
Console.WriteLine("Matriz Resultado");
ImprimeMatriz(matResul);