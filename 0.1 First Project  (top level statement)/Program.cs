Console.WriteLine("Hello, World!");



// Value type
// - наследуются от struct
// - создаются в stack      
bool ch = true;     // Boolean (System.Boolean)
byte byt = 15;      // Byte (ot 0 do 255) unsigned byte
sbyte sbyt = -12;   // Sbyte (signed byte)
char chr = 's';     // Char
short sshort = 0;   // Int16
ushort ushrt = 0;   // UInt16;
int numb = 26;      // Int32;
uint numb1 = 36;    // UInt32
long lng = 2648;    // Int64
ulong lng1 = 2648;  // UInt64

float flt = 2.36f;  // Single
// неявное преобразование из старшего тип в младший запрещено, поэтому нужно дописывать f чтобы не было даббл
double dbl = 36.6;  // Double

decimal dcm = 3659.654m;    // Decimal (хранится в памяти по-другому и не имеет каких-то проблем даббл и флоат)


// Reference type          - все типы данных относятся к одному из этих типов
// - наследуются от class 
// - создаются в heap
// чтобы создать референс тайп нужно писать new чтобы выделить память (кроме стринг)


// string - String
string str = "STEP";
string str1 = new string("STEP");