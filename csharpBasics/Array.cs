class Array
{
    void learn1DArray()
    {
        byte[] array1 = new byte[10];
        array1[0] = 23;
        float[] array2 = new float[] { 2.1f, 34.5f, 62.8f };
        array2[10] = 28;
        char[] array3 = { 'A', 'B', 'C', 'D' };
        float[] subArray1 = array2;
    }
    void LearnMulDArray()
    {
        int[,] numbers1 = new int[3, 4];
        numbers1[0, 0] = 34892;
        decimal[,] numbers2 = { { 2.2m, 3.6m }, { 14.2m, 12.8m } };
        numbers2[2, 3] = 879;
        decimal[,] numbers3 = { { 1.2m, 3.6m }, { 22.1m, 1.1m }, { 19.1m, 123.2m } };
    }
    
}