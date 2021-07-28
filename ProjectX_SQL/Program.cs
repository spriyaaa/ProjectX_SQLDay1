using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectX_DAL;

namespace ProjectX_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            MiniProjectDBConnection obj = new MiniProjectDBConnection();
            string result = obj.ConnectToDB();
            Console.WriteLine(result);


            var resultfac = obj.GetAllFaculty();
            foreach (var item1 in resultfac)
            {
                Console.WriteLine(item1);
            }

            Console.WriteLine(resultfac.Count);


            List<string> resultcourse = new List<string>();
            resultcourse = obj.GetAllCourse();
            foreach (var item in resultcourse)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(resultcourse.Count);



            List<string> resultgrader = new List<string>();
            resultgrader = obj.GetAllGrader();
            foreach (var item in resultgrader)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(resultgrader.Count);



            List<string> resultbatch = new List<string>();
            resultbatch = obj.GetAllBatch();
            foreach (var item in resultbatch)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(resultbatch.Count);



            List<string> resulttrainee = new List<string>();
            resulttrainee = obj.GetAllTrainee();
            foreach (var item in resulttrainee)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(resulttrainee.Count);


            List<string> resultmodel = new List<string>();
            resultmodel = obj.GetAllModel();
            foreach (var item in resultmodel)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(resultmodel.Count);


        }
    }
}
