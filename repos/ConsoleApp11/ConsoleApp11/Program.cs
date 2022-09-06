using System;
using System.Text;

//var user = new string[] { 
//"Sabir Quliyev",
//"sabir@mgmail.com",
//"+994504363465"
//};
//string ex = @"C:\Users\sabirmg\Desktop\folderk\text.txt";
//await File.WriteAllLinesAsync(ex, user);
//foreach (var item in File.ReadAllLines(ex).Select((val, ind) => new {val,ind}))
//{
//    Console.WriteLine($"{item.ind+1} -> {item.val}");
//}


string ex2= @"C:\Users\sabirmg\Desktop\folder\text.txt";
DirectoryInfo info = new DirectoryInfo(ex2);
FileStream fs=File.Open(ex2,FileMode.Create);

string textRandom = "sdfsd sdf sdf ewfwf3ef3 3eg rge erg eg 45ghrgtrh  rthrth";
byte[] byteArr = Encoding.Default.GetBytes(textRandom);
fs.Write(byteArr, 0, byteArr.Length);
fs.Position = 0;
byte[] data = new byte[byteArr.Length];