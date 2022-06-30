using System;
using System.IO;
using System.Collections.Generic;
namespace ListFileManipulation
{

    
    class program
    {
        static void Main(String[] args)
        {
            List<StudentInfo> vList=new List<StudentInfo>();
            vList.Add(new StudentInfo(){Name="Dhanesh",FatherName="Sankar"});
            vList.Add(new StudentInfo(){Name="Priya",FatherName="Siva"});
            vList.Add(new StudentInfo(){Name="Roshini",FatherName="SivaSankar"});
            Insert(vList);
            Display();
            Update();
           
            


            static void Insert(List<StudentInfo>vList)
            {
                StreamWriter write=null;
                if(!File.Exists("Data.csv"))
                {
                    System.Console.WriteLine("File doesn't exist. Creating a new CSV file");
                    //var fs=File.open("out.csv",FileMode.OpenOrCreate);fs.Close();
                    File.Create("Data.csv");
                }
                else
                {
                    write=new StreamWriter(File.OpenWrite("Data.csv"));
                    foreach(var v in vList)
                    {
                        write.WriteLine(v.Name+","+v.FatherName);
                    }
                    write.WriteLine();
                }
                write.Close();

                }

            }


            static void Display()
            {
                StreamReader reader=null;
                List<StudentInfo> listA =new List<StudentInfo>();
                if(File.Exists("Data.csv"))
                {
                    reader=new StreamReader(File.OpenRead("Data.csv"));
                    while(!reader.EndOfStream)
                    {
                        var line=reader.ReadLine();
                        var values=line.Split(',');
                        if(values[0]!="" && values[0]!="n")
                        {
                         listA.Add(new StudentInfo(){Name=values[0],FatherName=values[1]});
                        }
                    }                }

                else
                {
                    System.Console.WriteLine("File doesn't exist");
                }
                reader.Close();
                foreach(var coloumn1 in listA)
                {
                    System.Console.WriteLine("Your Name:\t"+coloumn1.Name+"\t Father Name:\t"+coloumn1.FatherName);
                }
            }
        static void Update()
        {
            System.Console.WriteLine("To update Select Option 0.your Name 1.Father Name ");
            int option=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter name to be updated");
            string name=Console.ReadLine();
            string [] lines=File.ReadAllLines("Data.csv");
            for(int i=0; i<lines.Length; i++)
            {
                if(lines[i]!="")
                {
                    var values=lines[i].Split(',');
                    if(values[option]==name)
                    {
                        System.Console.WriteLine("Enter new name to update: ");
                        string name1=Console.ReadLine();
                        if(option==0)
                        {
                            lines[i]=name1+","+values[1];
                        }
                        else if(option==1)
                        {
                            lines[i]=values[0]+","+name1;
                        }
                    }
                }
           
            }

           File.WriteAllLines("Data.csv",lines);
        }

       




            

         
        }
    }


