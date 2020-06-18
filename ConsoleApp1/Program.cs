using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace struct_lab_student
{
    partial class Program
    {       
        static Student[] ReadData(string fileName)
        {           
            FileStream fin = null;
            Student[] ReadData1 = null;
            string y = null;
            //try
            //{
            fin = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            byte[] b = new byte[500];

            int i = fin.Read(b, 0, b.Length);

            //Console.WriteLine(Encoding.ASCII.GetString(b, 0, i));

            string strMessage = Encoding.Default.GetString(b);

            //Console.WriteLine(strMessage);
            fin.Close();                             

            Console.WriteLine("Файл відкритий: {0}", fileName);
            Console.WriteLine("");


            char[] arrC;
            string[] arrS = new string[90];
            string str = null;            
            
            int k = -1;
            int o = 0;

            arrC = strMessage.ToCharArray(0, 500);

            Console.Write(arrC);
            Console.WriteLine("");           

            for (int i2 = 0; i2 < 500; i2++)
            {
                if (arrC[i2] == ' ')
                {
                    for (int i3 = o; i3 < i2; i3++)
                    {
                        str = str + arrC[i3];
                        o = i2 + 1;
                    }

                    k++;
                    arrS[k] = str;
                    str = null;
                    
                }
                
            }

            Console.WriteLine("Вивести прізвища студентів жіночої статі (F), що мають 5 з інформатики:");            

            k = 0;
            o = 0;

            string strAll = null;

            for (int i2 = 0; i2 <= 9; i2++)
            {


                if (arrS[3 + k] == "F" && arrS[7 + k] == "5")
                {                                         
                   strAll = strAll + arrS[o] + ", ";                  

                }

                k = k + 9;
                o = o + 9;               
            }

            Console.WriteLine("{0}", strAll);

            //}
            /*catch (IOException exc)
            {
                Console.WriteLine("Помилка при відкриванні файлу: \n" + exc.Message);
               
            }
            finally
            {
                if (fin != null)
                {
                    fin.Close();
                }
            }

            /*StreamReader fstr_in = new StreamReader(fin);

            try
            {
                while ((fileName = fstr_in.ReadLine()) != null)
                {
                    Console.WriteLine(fileName);
                }

            }
            catch (IOException exc)
            {
                Console.WriteLine("Помилка вводу-виводу:\n" + exc.Message);
            }
            finally
            {
                fstr_in.Close();
            }*/

            return ReadData1;

            /*FileStream fin; string s; try { fin = new FileStream("test.txt", FileMode.Open); } catch (IOException exc) { Console.WriteLine("Помилка при вiдкриваннi файлу:\n" + exc.Message); return; }
            StreamReader fstr_in = new StreamReader(fin); try { while ((s = fstr_in.ReadLine()) != null) { Console.WriteLine(s); } } catch (IOException exc) { Console.WriteLine("Помилка вводу-виводу:\n" + exc.Message); } finally { fstr_in.Close(); }*/



            // TODO реалізує цей метод. Він повинен прочитати файл, ім'я якого fileName було передано та заповнене 
        }

        static void runMenu(Student[] studs)
        {

            // TODO реалізує цей метод. Він повинен викликати метод (и) для конкретних варіантів
        }

        static void Main(string[] args)
        {
            Student[] studs = ReadData("input.txt");
            runMenu(studs);
            Console.ReadKey();
        }
    }
}
