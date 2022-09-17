// See https://aka.ms/new-console-template for more information
int schet(string[] str,int n){
    int count =0;
    for (int i=0;i<str.Length;i++)
        if(str[i].Length<=n)count++;
    return count;
}

void print(string[] itog){
    Console.Write("[");
    for (int i=0;i<itog.Length;i++){
        Console.Write($"\"{itog[i]}\"");
        if ((i+1)!=itog.Length) Console.Write(",");
    }
    Console.WriteLine("]");
}

void fill(ref string [] itog,string [] str, int n){
    int count =0;
    for (int i=0;i<str.Length;i++)
        if(str[i].Length<=n){
            itog[count] = str[i];
            count++;
        }

}

string [] str = {"hello","2","world",":-)"}; // - тут можно задать файл
int n = 3;  //не больше этого числа символов будут состоять строки в новом массиве

string [] itog = new string[schet(str,n)];
fill(ref itog,str,n);
print(itog);

