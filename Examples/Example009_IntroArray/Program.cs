int Max (int arg1, int arg2, int arg3)
{
    int resualt = arg1;
    if (arg2 > resualt) resualt = arg2;
    if (arg3 > resualt) resualt = arg3;
    return resualt;
}

//              0  1  2  3  4  5  6  7  8
int [] array = {11,21,31,41,15,61,17,18,19};

int max = Max(
Max(array[0], array[1], array[2]),
Max(array[3], array[4], array[5]),
Max(array[6], array[7], array[8])
);

Console.WriteLine(max);