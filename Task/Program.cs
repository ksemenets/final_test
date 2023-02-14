//Написать программу, которая из имеющегося массива строк,
//формирует массив из строк, длина которых меньше либо равна 3 символам.

string [] array = {";-)", "qwer","qwe","qw","абырвалг","ghj","98","123"};
string [] GetNewArray(string[]array)
{
    int count = 0;       
    for(int i = 0; i < array.Length; i ++)
    {
        if(array[i].Length <= 3)
           count ++;
    }
    string[] newArray = new string[count];
    int j = 0;
    for(int i = 0; i < array.Length; i ++)
    {
        if(array[i].Length <= 3)
          { newArray[j] = array[i];  
           j ++;   
          }  
    }
    return newArray;
}
void PrintArray(string[] newArray)
{
    for(int i = 0; i < newArray.Length; i ++)
    {
        Console.Write(newArray[i] + ", ");
    }
}
string[] newArray = GetNewArray(array);
PrintArray(newArray);